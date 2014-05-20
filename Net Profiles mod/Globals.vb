'
' Copyright 2004-2012 Hugo Anton Feldhammer, Urs Geissbühler, Daniel Milner
'
'
' This file is part of Net Profiles mod.
'
' Net Profiles mod is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' Net Profiles mod is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with Net Profiles mod.  If not, see <http://www.gnu.org/licenses/>.
'
'
' Created by SharpDevelop.
' User: DMilner
' Date: 1/26/2007
' Time: 3:13 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Option Explicit

Imports Microsoft.Win32
Imports System.Management
Imports System.Drawing.Imaging
Imports AppModule.Globals
Imports NativeWifi

Public Module Globals
	Public CurrentLang As String = "en-US"
	Public CurrentLangPath As String
	Public CreatingNewProfile As Boolean
	Public CreatingNewMappedDrive As Boolean
	Public CreatingNewRunCommand As Boolean
	Public ResolutionFormatter As String = "{0} x {1}"
	
	Public ProgramINIFile As String = CommonApplicationDataFolder + "\netprofilesmod.ini"
	Public OKToCloseProgram As Boolean = False
	Public commandArray() As String
	Public EnableLoadTimer As Boolean = True
	Public INIAutoLoad As String
	Public NetworkCardList As New ArrayList()
	Public RunFromTaskTray As Boolean = False
	Public cScreen As New clsScreenRes
	
	Public CurrentWirelessSSID As String = ""
	Public CurrentWirelessName As String = ""
	Public LastWirelessSSID As String = ""
	Public LastWirelessName As String = ""
	Public AutoConnectSSID As New ArrayList()
	Public AutoConnectProfile As New ArrayList()
	Public AutoConnectMACAddress As New ArrayList()
	Public SSIDi As Integer
	
	Public BrowseNetworkShare_Title As String
	
	Declare Function GetPrivateProfileSection Lib "kernel32"  Alias "GetPrivateProfileSectionA"(ByVal sSectionName As String, ByVal sReturnedString As String, ByVal lSize As Integer, ByVal sFileName As String) As Integer
	
	Public Function StrReverse(ByVal str As String) As String
		Dim chars As Char() = str.ToCharArray()

		Array.Reverse(chars)
		Return New String(chars)
	End Function
	
	' potofcoffee:
	' set default printer through Windows API is way faster!
	' The old way, which did a WMI query, forced windows to try and contact EVERY
	' installed printer, even non-connected network printers. The wait for timeouts
	' made this a very slow function. This one is very speedy!
    public Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Long

	
	'*** START NETWORK STUFF ***
	Private Structure BROWSEINFO 'bi
		Dim hOwner As Integer
		Dim pidlRoot As Integer
		Dim pszDisplayName As String 'return display name of item selected
		Dim lpszTitle As String 'text to go in the banner over the tree
		Dim ulFlags As Integer 'flags that control the return stuff
		Dim lpfn As Integer
		Dim lParam As Integer 'extra info passed back in callbacks
		Dim iImage As Integer 'output var: where to return the Image index
	End Structure
	
	Private Const NOERROR As Integer = 0
	Private Const MAX_PATH As Integer = 260
	Private Const CSIDL_NETWORK As Integer = &H12s
	Private Const BIF_RETURNONLYFSDIRS As Integer = &H1s
	Private Const BIF_NEWDIALOGSTYLE As Integer = &H40s
	Private Const BIF_NONEWFOLDERBUTTON As Integer = &H200s
	
	Private Declare Function lstrlenW Lib "kernel32" (ByVal lpString As Integer) As Integer
	Private Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal pv_Renamed As Integer)
	
	
	'Code snippet from http://www.codeproject.com/Articles/20547/How-to-Browse-Network-Folders-using-Folder-Dialog
	Public Function GetNetworkFolders(ByVal oFolderBrowserDialog As FolderBrowserDialog) As String
		'Get type of Folder Dialog
		Dim type As Type = oFolderBrowserDialog.[GetType]
		'Get Fieldinfo for rootfolder
		Dim fieldInfo As Reflection.FieldInfo = type.GetField("rootFolder", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
		'Now set the value for Folder Dialog using DirectCast
		'18 = Network Neighborhood is the root
		fieldInfo.SetValue(oFolderBrowserDialog, DirectCast(18, Environment.SpecialFolder))
		If oFolderBrowserDialog.ShowDialog() = DialogResult.OK Then
			Return oFolderBrowserDialog.SelectedPath
		Else
			Return ""
		End If
	End Function
	
	Private Function TrimNull(ByRef startstr As String) As String
		
		'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
		TrimNull = Left(startstr, lstrlenW(VarPtrAny(startstr)))
		'TrimNull = startstr.Substring(0, startstr.Insert(0, Source)
		
	End Function
	
	Public Function VarPtrAny(ByVal o As String) As Integer
		Dim GC As System.Runtime.InteropServices.GCHandle = System.Runtime.InteropServices.GCHandle.Alloc(o, System.Runtime.InteropServices.GCHandleType.Pinned )
		Dim ret As Integer = GC.AddrOfPinnedObject.ToInt32
		GC.Free()
		Return ret
	End Function
	'*** END NETWORK STUFF ***
	
	'*** START MAPPED DRIVES ***
	Public Const CONNECT_UPDATE_PROFILE As Short = &H1s
	Private Declare Function WNetCancelConnection2 Lib "mpr.dll"  Alias "WNetCancelConnection2A"(ByVal lpName As String, ByVal dwFlags As Integer, ByVal fForce As Integer) As Integer
	
	Public Function DisconnectNetworkDrive(ByRef sDrv As String, ByRef sForce As Boolean) As Boolean
        DisconnectNetworkDrive = CBool(WNetCancelConnection2(sDrv, CONNECT_UPDATE_PROFILE, CInt(sForce)))
	End Function
	
	Public Structure NETRESOURCE
		Dim dwScope As Integer
		Dim dwType As Integer
		Dim dwDisplayType As Integer
		Dim dwUsage As Integer
		Dim lpLocalName As String
		Dim lpRemoteName As String
		Dim lpComment As String
		Dim lpProvider As String
	End Structure
	
	Public Const RESOURCE_GLOBALNET As Short = &H2s
	Public Const RESOURCETYPE_DISK As Short = &H1s
	Public Const RESOURCEDISPLAYTYPE_SHARE As Short = &H3s
	Public Const RESOURCEUSAGE_CONNECTABLE As Short = &H1s
	Public Const ERROR_SUCCESS As Short = 0
	
	Public Declare Function WNetAddConnection2 Lib "mpr"  Alias "WNetAddConnection2A"(ByRef lpNetResource As NETRESOURCE, ByVal lpPassword As String, ByVal lpUserName As String, ByVal dwFlags As Integer) As Integer
	
	Public Function ConnectThisNetworkDrive(ByRef sServer As String, ByRef sDrv As String, ByRef sUsername As String, ByRef sPassword As String) As Boolean
		
		'attempts to connect to the passed network
		'connection to the specified drive.
		'ErrInfo=ERROR_SUCCESS if successful.
		
		Dim NETR As NETRESOURCE = New NETRESOURCE
		Dim errInfo As Integer
		
		With NETR
			.dwScope = RESOURCE_GLOBALNET
			.dwType = RESOURCETYPE_DISK
			.dwDisplayType = RESOURCEDISPLAYTYPE_SHARE
			.dwUsage = RESOURCEUSAGE_CONNECTABLE
			.lpRemoteName = sServer
			.lpLocalName = sDrv
		End With
		
		errInfo = WNetAddConnection2(NETR, sPassword, sUsername, CONNECT_UPDATE_PROFILE)
		
		If errInfo <> ERROR_SUCCESS Then
			sUsername = "administrator"
			errInfo = WNetAddConnection2(NETR, sPassword, sUsername, CONNECT_UPDATE_PROFILE)
		End If
		
		ConnectThisNetworkDrive = errInfo = ERROR_SUCCESS
		
	End Function
	'*** END MAPPED DRIVES ***
	
    '*** START DEFAULT HOMEPAGE ***
	Public Sub SetHomepage(ByRef URL As String)
		Dim regKey As RegistryKey
		regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\Main\", True)
		regKey.SetValue("Start Page", URL)
	End Sub
	'*** END DEFAULT HOMEPAGE ***
	
	'*** START CREATE SHORTCUT ***
	Public Sub CreateShortcut(ByVal ShortcutName As String, ByVal ShortcutPath As String, Optional ByVal ShortcutArg As String = "", Optional ByVal ShortcutDesc As String = "", Optional ByVal ShortcutDir As String = "", Optional ByVal ShortcutIcon As String = "", Optional ByRef WinStyle As Integer = 4)
		Dim Placement As String
		Dim oShell As New IWshRuntimeLibrary.IWshShell_Class()
		Dim oShortcut As IWshRuntimeLibrary.IWshShortcut_Class
		Placement = CStr(oShell.SpecialFolders.Item("Desktop"))
		oShortcut = DirectCast(oShell.CreateShortcut(Placement & "\" & ShortcutName & ".lnk"), IWshRuntimeLibrary.IWshShortcut_Class)
		oShortcut.TargetPath = ShortcutPath
		oShortcut.Description = ShortcutDesc
		oShortcut.Arguments = ShortcutArg
		oShortcut.WorkingDirectory = ShortcutDir
		oShortcut.IconLocation = System.Reflection.Assembly.GetExecutingAssembly.Location() & ", 0"
		oShortcut.WindowStyle = WinStyle
		oShortcut.Save()
		oShell = Nothing
		oShortcut = Nothing
	End Sub 
	'*** END CREATE SHORTCUT ***
	
	Public Sub UpdateProgress(ByVal ThisText As String, ByVal ProgressType As String)
		If ProgressType.Equals("normal") Then
			MainForm.toolStripStatusLabelWorking.Text = ThisText
			MainForm.toolStripStatusLabelWorking.Visible = True
		ElseIf ProgressType.Equals("auto") Then
			AutoActivate.labelStatus.Text = ThisText
			AutoActivate.labelStatus.Visible = True
		End If
	End Sub
	
	Public Function GetStoredInterfaceName(ThisInterface As String) As String
		Dim Item As DictionaryEntry
		For Each Item In NetworkCardList
			Application.DoEvents
			If ThisInterface.Replace("-",":") = Item.Key.ToString Then
				Return Item.Value.ToString
			End If
		Next
		Return ""
	End Function
	
	Public Function GetInterfaceName(ThisInterface As String) As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapter WHERE MACAddress = '" & ThisInterface.Replace("-",":") & "'") 
			
			For Each queryObj As ManagementObject in searcher.Get()
				Application.DoEvents
				Return CStr(queryObj("NetConnectionID"))
			Next
		Catch err As ManagementException
			
		End Try
				
		Return ""
	End Function
	
	Public Function PopulateNetworkCardArray() As ArrayList
		Dim NetworkAdapters As New ArrayList()
		Dim MACAddresses As String = ""
		Dim NetworkInterfaceName As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")
			
			For Each queryObj As ManagementObject in searcher.Get()
				Application.DoEvents
				
				' For some reason, sometimes queryObj doesn't seem to be a valid object
				' probably depends on some specific configurations, but why not check for
				' queryObj being something else than "Nothing" ?
				If not (queryobj Is Nothing) Then 
					If Not MACAddresses.Contains(CStr(queryObj("MACAddress"))) Then
						NetworkInterfaceName = ""
						NetworkInterfaceName = GetInterfaceName(CStr(queryObj("MACAddress")))
						
						If NetworkInterfaceName Is Nothing Then
							NetworkInterfaceName = GetNetworkInstanceName(CStr(queryObj("MACAddress").Replace("-", ":")))
						ElseIf NetworkInterfaceName.Trim().Length = 0 Then
							NetworkInterfaceName = GetNetworkInstanceName(CStr(queryObj("MACAddress").Replace("-", ":")))
						End If
						NetworkAdapters.Add(New DictionaryEntry(queryObj("MACAddress"), NetworkInterfaceName))
						MACAddresses = MACAddresses & CStr(queryObj("MACAddress"))
					End If
				End If
			Next
			
		Catch err As ManagementException
				
		End Try
		
		Return NetworkAdapters
	End Function
	
	Public Function GetDefaultPrinter As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_Printer WHERE Default = True") 
			
			For Each queryObj As ManagementObject in searcher.Get()
				Application.DoEvents
				Return CStr(queryObj("Name"))
			Next
		Catch err As ManagementException
			Return ""
		End Try
		Return ""
	End Function
	
	'*** CHANGE WALLPAPER ***
	'api to set the systems parameters for changing the wallpaper
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    'constants to be used with the above api
    Private Const SPI_SETDESKWALLPAPER As Integer = 20
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    
    Public Sub SetWallpaper(ByVal WallpaperFile As String)
		MainForm.pictureBoxWallpaper.Image = Image.FromFile(WallpaperFile)
        'just some generic path and name for the image in the picturebox 
        'to save to
        Dim imagePath As String = CommonApplicationDataFolder & "\wallpaper.bmp"

        'the image must be in bitmap format for it to work as a 
        'wallpaper, unless I am not doing something right
        MainForm.pictureBoxWallpaper.Image.Save(imagePath, ImageFormat.Bmp)

        'set the parameters to change the wallpaper to the image you 
        'selected
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINIFILE)

    End Sub
    '*** END CHANGE WALLPAPER ***
    
    
	'*** START DISPLAY SETTINGS ***
	Public Sub ResolutionsToComboBox(ResolutionFromProfile As String)
		'Add resolutions to combobox
		Dim profileResolution As Integer()
		Dim resolutionSeparator() As String = {String.Format(ResolutionFormatter, "", "")}
		Try
			Dim profileRes As String() = ResolutionFromProfile.Split(resolutionSeparator, StringSplitOptions.None)
			profileResolution = New Integer(){Convert.ToInt32(profileRes(0)), Convert.ToInt32(profileRes(1))}
		Catch
			profileResolution = New Integer(){}
		End Try
		Dim resolutions As List(Of Integer())
		resolutions = cScreen.GetResolutions(profileResolution)
		ProfileSettings.comboBoxDisplaySettings.Items.Clear
		ProfileSettings.comboBoxDisplaySettings.Items.Add("")
		
		For Each resolution As Integer() In resolutions
			ProfileSettings.comboBoxDisplaySettings.Items.Add(String.Format(ResolutionFormatter, resolution(0).ToString(), resolution(1).ToString()))
		Next
	End Sub
    '*** END DISPLAY SETTINGS ***
    
    
    ' potofcoffee:
 	' new function to determine whether a particular network adapter is a physical 
 	' adapter or merely some kind of packet scheduler.
 	' We proceed to do this as follows:
 	' 1. Try to find the name of the adapter in a list of available network adapters
 	' 2. If found, try to exclude Microsoft as the manufacturer
 	' This should catch most PacketSchedulers
 	'
 	' Reference:
 	' http://www.eggheadcafe.com/forumarchives/win32programmerwmi/Oct2005/post25122084.asp
    Public Function isPhysicalAdapter(theName As String) As Boolean
    	Dim searcher As New ManagementObjectSearcher( _
    				"\root\cimv2", _
    				"Select * from Win32_NetworkAdapter WHERE Caption LIKE '%" & theName & "%'")
    	dim result as ManagementObjectCollection 
		result = searcher.Get()
		If result.Count > 0 Then
			Dim f As Boolean
			For Each Adapter As ManagementObject In result
                f = CBool(Adapter("Manufacturer") IsNot "Microsoft")
			Next
			return f
		Else
			' not even found: this can't be a physical adapter
			return false
		End If
	End Function
	
	Public Sub GetConnectedSSIDs()
		Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
		' On Vista and newer the Managed Wifi API is used to detect the connected SSIDs, on XP WMI is used
		If osInfo.Version.Major >= 6 Then
			If Not IsNothing(MainForm.Wlan) Then
				CurrentWirelessSSID = ""
				CurrentWirelessName = ""
				Try
					For Each wlanInterface As WlanClient.WlanInterface In MainForm.Wlan.Interfaces
						If wlanInterface.InterfaceState = NativeWifi.Wlan.WlanInterfaceState.Connected Then
							Dim ssid As Wlan.Dot11Ssid  = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid
							CurrentWirelessSSID = System.Text.Encoding.ASCII.GetChars(ssid.SSID, 0, Convert.ToInt32(ssid.SSIDLength))
							CurrentWirelessName = wlanInterface.InterfaceDescription
							If CurrentWirelessSSID.Length > 0 Then
								Call CompareWirelessSSID()
							Else
								CurrentWirelessSSID = ""
								CurrentWirelessName = ""
								LastWirelessSSID = ""
								LastWirelessName = ""
							End If
						End If
					Next
				Catch
					CurrentWirelessSSID = ""
					CurrentWirelessName = ""
					LastWirelessSSID = ""
					LastWirelessName = ""
				End Try
			End If
		Else
			Try
				Dim searcher As New ManagementObjectSearcher( _
					"\root\wmi", _
					"Select * from MSNdis_80211_ServiceSetIdentifier Where active=true") 
				
				CurrentWirelessSSID = ""
				CurrentWirelessName = ""
				Dim TheID As String = ""
				Dim TheName As String = ""
				For Each queryObj As ManagementObject in searcher.Get()
					Dim i As Integer
					Dim ThisName As String = ""
					For i = 0 To CInt(queryObj("Ndis80211SsId")(0))
						TheID = TheID & Chr(CInt(queryObj("Ndis80211SsId")(i + 4)))
					Next
					TheName = CStr(queryObj("InstanceName"))
					
					if isPhysicalAdapter(TheName) then 
						CurrentWirelessSSID = TheID.Substring(0, TheID.Length - 1)
						CurrentWirelessName = TheName.ToString 
						
						If CurrentWirelessSSID.Length > 0 Then
							Call CompareWirelessSSID()
						Else
							CurrentWirelessSSID = ""
							CurrentWirelessName = ""
							LastWirelessSSID = ""
							LastWirelessName = ""
						End If
					End If
				Next
			Catch err As ManagementException
				CurrentWirelessSSID = ""
				CurrentWirelessName = ""
				LastWirelessSSID = ""
				LastWirelessName = ""
			End Try
		End If
	End Sub
	
	Public Sub CompareWirelessSSID()
		If Not CurrentWirelessSSID.Equals(LastWirelessSSID) And Not CurrentWirelessName.Equals(LastWirelessName) Then
			'MessageBox.Show(CurrentWirelessSSID & " = " & LastWirelessSSID)
			'MessageBox.Show(CurrentWirelessName & " = " & LastWirelessName)
			'MessageBox.Show("You just connected to: " & CurrentWirelessSSID)
			Dim i As Integer
			'For i = Globals.AutoConnectSSID.GetLowerBound(0) To Globals.AutoConnectSSID.GetUpperBound(0) - 1
			'	MessageBox.Show(Globals.AutoConnectSSID(i))
			'Next
			For i = 0 To AutoConnectSSID.Count - 1
				If GetNetworkInstanceName(AutoConnectMACAddress(i).ToString).ToLower = CurrentWirelessName.ToLower And _
					AutoConnectSSID(i).ToString.ToLower = CurrentWirelessSSID.ToLower And Not MainForm.ProfileApplyInProgress Then
					
					Dim ProfileName As String = INIRead(CStr(AutoConnectProfile(i)), "General", "Name", "[No Name]")
					If MainForm.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Checked Then
						Globals.INIAutoLoad = AutoConnectProfile(i).ToString
						AutoActivate.Show
					Else
						Globals.INIAutoLoad = AutoConnectProfile(i).ToString
						WirelessDetected.labelSSID.Text = CurrentWirelessSSID.ToString
						WirelessDetected.labelProfile.Text = ProfileName
						WirelessDetected.Show
					End If
				End If
			Next
			'AutoConnectSSID
		End If
		LastWirelessSSID = CurrentWirelessSSID
		LastWirelessName = CurrentWirelessName
	End Sub
	
	Public Function GetNetworkInstanceName(ByVal MAC As String) As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapter WHERE MACAddress = '" & MAC & "'") 
'
			For Each queryObj As ManagementObject in searcher.Get()
				Application.DoEvents
                Return CStr(queryObj("Description"))
			Next
		Catch err As ManagementException
			Return ""
		End Try
		Return ""
	End Function
	
	Public Function GetRegistryKey(ByVal regLocation As String, ByVal regKey As String) As String
        Dim RegistryValue As String

        'RegistryValue = Registry.LocalMachine.OpenSubKey(regLocation, False).GetValue(regKey, "").ToString
        RegistryValue = Registry.CurrentUser.OpenSubKey(regLocation, False).GetValue(regKey, "").ToString
        Return RegistryValue
    End Function

    Public Sub SetRegistryKey(ByVal PathToValue As String, ByVal KeyName As String, ByVal ValueToUse As String)
        'Dim oReg As Microsoft.Win32.Registry
        Dim oRegKey As Microsoft.Win32.RegistryKey

        'oRegKey = oReg.LocalMachine.OpenSubKey(PathToValue, True)
        oRegKey = Registry.CurrentUser.OpenSubKey(PathToValue, True)
        oRegKey.SetValue(KeyName, ValueToUse)
    End Sub
    
    Public Sub DeleteRegistryKey(ByVal PathToValue As String, ByVal KeyName As String)
        'Dim oReg As Microsoft.Win32.Registry
        Dim oRegKey As Microsoft.Win32.RegistryKey

        'oRegKey = oReg.LocalMachine.OpenSubKey(PathToValue, True)
        oRegKey = Registry.CurrentUser.OpenSubKey(PathToValue, True)
        oRegKey.DeleteValue(KeyName, False)
    End Sub
    
    Public Sub RenameComputer(ByVal NewName As String)
    	Dim objComputer As Object
		Dim colComputers As Object
		Dim objWMIService As Object
		Dim strComputer As Object
		strComputer = "."
        objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
		colComputers = objWMIService.ExecQuery("Select * from Win32_ComputerSystem")
		For Each objComputer In DirectCast(colComputers, Collections.IEnumerable)
			ObjComputer.Rename(NewName)
		Next
    End Sub

	Public Sub ProcessProxySettings(ByVal ProxyServer As String, ByVal Protocol As String, ByRef Server As String, ByRef Port As String)
		If ProxyServer.StartsWith(Protocol & "=") Then
			Dim Proxy As Array = ProxyServer.Split("="C)(1).Split(":"C)
			Server = Convert.ToString(Proxy(0))
			If Proxy.Length > 1 Then
				Port = Convert.ToString(Proxy(1))
				If Port.Length = 0 Then
					Port = ""
				End If
			Else
				Port = ""
			End If
		End If
	End Sub

	Public Sub ShowException(Message As String, Caption As String)
		MessageBox.Show("Press Ctrl-C to copy this message to the clipboard" + vbCrLf + vbCrLf + Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop)
	End Sub
End Module
