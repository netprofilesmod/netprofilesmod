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
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Module Globals
    Public const ProgramVersion As String = "0.1.0"
	Public const ProgramName As String = "Net Profiles mod"
	Public CurrentLang As String = "en-US"
	Public CurrentLangPath As String
	Public CreatingNewProfile As Boolean
	Public CreatingNewMappedDrive As Boolean
	Public CreatingNewRunCommand As Boolean
	
	Public CommonApplicationDataFolder As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) + "\" + ProgramName
	Public ProfilesFolder As String = CommonApplicationDataFolder + "\profiles"
	
	Public ProgramINIFile As String = CommonApplicationDataFolder + "\netprofilesmod.ini"
	Public OKToCloseProgram As Boolean = False
	Public commandArray() As String
	Public EnableLoadTimer As Boolean = True
	Public INIAutoLoad As String
	'Public NetworkCardList As New System.Collections.HashTable()
	Public NetworkCardList As New ArrayList()
	Public RunFromTaskTray As Boolean = False
	Public cScreen As New clsScreenRes
	Private bStandardResOnly As Boolean = True
	Public AskBeforeChangingResolution As Boolean = True
	Public AskAfterChangingResolution As Boolean = True
	
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
	
	Private Declare Function SHGetSpecialFolderLocation Lib "shell32.dll" (ByVal hwndOwner As Integer, ByVal nFolder As Integer, ByRef pidl As Integer) As Integer
	Private Declare Function SHBrowseForFolder Lib "shell32.dll"  Alias "SHBrowseForFolderA"(ByRef lpBrowseInfo As BROWSEINFO) As Integer
	Private Declare Function SHGetPathFromIDList Lib "shell32.dll"  Alias "SHGetPathFromIDListA"(ByVal pidl As Integer, ByVal pszPath As String) As Integer
    Private Declare Function lstrlenW Lib "kernel32" (ByVal lpString As Integer) As Integer
    Private Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal pv_Renamed As Integer)



	
	Public Function GetBrowseNetworkShare(ByRef hwndOwner As Integer, ByRef bNewDialog As Boolean, ByRef bNoNewFolder As Boolean) As String
		Dim bi As BROWSEINFO
		Dim pidl As Integer
		Dim spath As String
		
		If SHGetSpecialFolderLocation(hwndOwner, CSIDL_NETWORK, pidl) = NOERROR Then
			With bi
				.hOwner = hwndOwner
				.pidlRoot = pidl
				.pszDisplayName = Space(MAX_PATH)
				'.lpszTitle = "Select a network computer or share."
				.lpszTitle = Globals.BrowseNetworkShare_Title
				.ulFlags = BIF_RETURNONLYFSDIRS
				If bNewDialog Then .ulFlags = .ulFlags Or BIF_NEWDIALOGSTYLE
				If bNoNewFolder Then .ulFlags = .ulFlags Or BIF_NONEWFOLDERBUTTON
				
			End With

			pidl = SHBrowseForFolder(bi)
			
			If pidl <> 0 Then
				spath = Space(MAX_PATH)
                If CBool(SHGetPathFromIDList(pidl, spath)) Then
                    GetBrowseNetworkShare = TrimNull(spath)
                Else
                    GetBrowseNetworkShare = "\\" & bi.pszDisplayName
                End If
            Else
                GetBrowseNetworkShare = ""
            End If
			
			Call CoTaskMemFree(pidl)
        Else
            GetBrowseNetworkShare = ""
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
	
	Public Sub SaveTCPIPSettings(ByRef IPAddress As String, ByRef SubnetMask As String, ByRef Gateway As String, ByRef PDNSServer As String, ByRef ADNSServer As String, ByRef WINSServer As String, ByRef DNSSuffix As String, ByRef DHCP As Boolean, ByRef MACAddress As String, ByRef ApplyType As String)
		Dim objNetAdapter As Object
		Dim strDNSServers As Object
		Dim strWINSServer As Object
		Dim strDNSSuffix As Object
		Dim strGatewaymetric As Object
		Dim strGateway As Object
		Dim strSubnetMask As Object
		Dim strIPAddress As Object
		Dim colNetAdapters As Object
		Dim objWMIService As Object
		Dim strComputer As Object

		strComputer = "."
        'objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
        objWMIService = GetObject("winmgmts:\\.\root\cimv2")
		Application.DoEvents()
		colNetAdapters = objWMIService.ExecQuery("Select * from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE and MACAddress='" & MACAddress.Replace("-", ":") & "'")
		Application.DoEvents()
		'Dim setIPYN As Boolean
		'Dim setSubnetYN As Boolean
		Dim setGatewayYN As Boolean = False
		Dim setPDNSYN As Boolean = False
		Dim setADNSYN As Boolean = False
		'Dim setWINS As Boolean
		
		If IPAddress.Trim.Length.Equals(0) Then IPAddress = ""
		If SubnetMask.Trim.Length.Equals(0) Then SubnetMask = ""
		If Gateway.Trim.Length <> 0 Then setGatewayYN = True
		If PDNSServer.Trim.Length <> 0 Then setPDNSYN = True
		If ADNSServer.Trim.Length <> 0 Then setADNSYN = True
		If WINSServer.Trim.Length.Equals(0) Then WINSServer = ""
		
		strIPAddress = New Object(){IPAddress}
		strSubnetMask = New Object(){SubnetMask}

		If setGatewayYN.Equals(True) Then
			strGateway = New Object(){Gateway}
			strGatewaymetric = New Object(){1}
		Else
			Dim GatewayValue(-1) As String
			Dim Cost(-1) As String
			strGateway = New Object(){GatewayValue}
			strGatewaymetric = New Object(){Cost}
		End If
		strWINSServer = WINSServer
		If setPDNSYN.Equals(True) And setADNSYN.Equals(True) Then
			strDNSServers = New Object(){PDNSServer, ADNSServer}
		ElseIf setPDNSYN.Equals(True) And setADNSYN.Equals(False) Then 
			strDNSServers = New Object(){PDNSServer}
		ElseIf setPDNSYN.Equals(False) And setADNSYN.Equals(True) Then 
			strDNSServers = New Object(){ADNSServer}
		Else
			strDNSServers = New Object(){""}
		End If
		strDNSSuffix = DNSSuffix
		
        For Each objNetAdapter In colNetAdapters
            If DHCP.Equals(True) Then
                objNetAdapter.SetDNSDomain("")
                Application.DoEvents()
                objNetAdapter.SetDNSServerSearchOrder()
                Application.DoEvents()
                objNetAdapter.SetDynamicDNSRegistration(True)
                Call UpdateProgress(MainForm.StatusLabelWorking_DHCP, ApplyType)
                Application.DoEvents()
                objNetAdapter.EnableDHCP()
                Application.DoEvents()
                objNetAdapter.RenewDHCPLease()
                Application.DoEvents()
                ' EnableDHCP() sometimes applies two default gateways on Windows Vista and newer.
                ' As a workaround we check if more than one gateway is active after enabling DHCP
                ' and assign only the second one.
                Dim CurrentGateways() As String = GetCurrentIPSettings(objNetAdapter.MACAddress).Split(CChar("|"))(3).Split(CChar(","))
                If CurrentGateways.Length > 1 Then
                    objNetAdapter.SetGateways(New Object(){CurrentGateways(1)}, New Object(){1})
                End If
            Else
                objNetAdapter.SetDNSDomain(strDNSSuffix)
                Call UpdateProgress(MainForm.StatusLabelWorking_IPAddress, ApplyType)
                Application.DoEvents()
                objNetAdapter.EnableStatic(strIPAddress, strSubnetMask)
                Call UpdateProgress(MainForm.StatusLabelWorking_Gateway, ApplyType)
                Application.DoEvents()
                objNetAdapter.SetGateways(strGateway, strGatewaymetric)
                Application.DoEvents()
                objNetAdapter.SetDNSServerSearchOrder()
                Call UpdateProgress(MainForm.StatusLabelWorking_DNS, ApplyType)
                Application.DoEvents()
                objNetAdapter.SetDNSServerSearchOrder(strDNSServers)
                Call UpdateProgress(MainForm.StatusLabelWorking_WINS, ApplyType)
                Application.DoEvents()
                objNetAdapter.SetWINSServer(strWINSServer, "")
                Application.DoEvents()
            End If
        Next objNetAdapter
	End Sub
	
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
         oShortcut = oShell.CreateShortcut(Placement & "\" & ShortcutName & ".lnk")
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
		Application.DoEvents
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
'
			For Each queryObj As ManagementObject in searcher.Get()
				Application.DoEvents
                Return CStr(queryObj("NetConnectionID"))
			Next
		Catch err As ManagementException

		End Try
				
		Return ""
	End Function
	
	Public Sub PopulateNetworkCardArray
		NetworkCardList.Clear
		MainForm.toolStripMain.Enabled = False
		MainForm.fileToolStripMenuItem.Enabled = False
		Dim MACAddresses As String = ""
		Dim NetworkInterfaceName As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")
			
			' potofcoffee:
			' tried to patch for issue 1 here
			' (Ref: http://code.google.com/p/netprofiles/issues/detail?id=1)
			' 
			' For some reason, sometimes queryObj doesn't seem to be a valid object
			' probably depends on some specific configurations, but why not check for
			' queryObj being something else than "Nothing" ?
			For Each queryObj As ManagementObject in searcher.Get()
     			Application.DoEvents
     			
     			' check goes here:
     			If not (queryobj Is Nothing) Then 
     				' looking good? Then back to the original code ...
                    If Not MACAddresses.Contains(CStr(queryObj("MACAddress"))) Then
                        NetworkInterfaceName = ""
                        NetworkInterfaceName = GetInterfaceName(CStr(queryObj("MACAddress")))

                        ' Implementing ivan.hrehor's solution from
                        ' http://code.google.com/p/netprofiles/issues/detail?id=1#c18
                        If NetworkInterfaceName Is Nothing Then
                            NetworkInterfaceName = GetNetworkInstanceName(CStr(queryObj("MACAddress").Replace("-", ":")))
                        ElseIf NetworkInterfaceName.Trim().Length = 0 Then
                            NetworkInterfaceName = GetNetworkInstanceName(CStr(queryObj("MACAddress").Replace("-", ":")))
                        End If
                        NetworkCardList.Add(New DictionaryEntry(queryObj("MACAddress"), NetworkInterfaceName))
                        MACAddresses = MACAddresses & CStr(queryObj("MACAddress"))
                    End If
     			End If
			Next
			
            Catch err As ManagementException
                'Nothing
		End Try
		MainForm.toolStripMain.Enabled = True
		MainForm.fileToolStripMenuItem.Enabled = True
	End Sub

	Public Function GetCurrentIPSettings(ThisInterface As String) As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapterConfiguration WHERE MACAddress = '" & ThisInterface & "'") 
'
			For Each queryObj As ManagementObject in searcher.Get()
				Application.DoEvents
                Dim DHCP As String = CStr(queryObj("DHCPEnabled"))
                Dim IPAddress As String = Convert.ToString(queryObj("IPAddress")(0))
                Dim SubnetMask As String = Convert.ToString(queryObj("IPSubnet")(0))
                Dim DefaultGateway As String = CStr(Join(queryObj("DefaultIPGateway"), ","))
                Dim PrimaryDNSServer As String = CStr(Join(queryObj("DNSServerSearchOrder"), ","))
                Dim WINSServer As String = CStr(queryObj("WINSPrimaryServer"))
				Dim DNSSuffix As String = Convert.ToString(queryObj("DNSDomain"))
				Return DHCP & "|" & IPAddress & "|" & SubnetMask & "|" & DefaultGateway & "|" & PrimaryDNSServer & "|" & WINSServer & "|" & DNSSuffix
			Next
		Catch err As ManagementException
			Return ""
		End Try
		Return ""
	End Function

	Public Function GetDefaultPrinter As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_Printer WHERE Default = True") 
'
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
    Public Sub ResolutionsToComboBox()
        'Add valid resolutions to combobox
        'if bStandardResOnly = false or notpassed, it will return all valid resolutions
        Dim strTempRes As String
        Dim strResolutions As String
        Dim strModes() As String
        strResolutions = cScreen.ValidResolutions(bStandardResOnly)
        strModes = Split(strResolutions, ",")
        ProfileSettings.comboBoxDisplaySettings.Items.Clear
        ProfileSettings.comboBoxDisplaySettings.Items.Add("")
        
		Dim lang As SetLanguage = New SetLanguage("/Language/ProfileSettings/")
		
		Dim byText As String = lang.GetText("ScreenResolutionText-By", "by")
		Dim pixelsText As String = lang.GetText("ScreenResolutionText-Pixels", "pixels")

        For Each strTempRes In strModes
            'cboResolution.Items.Add(strTempRes)
            Dim strTempResArray() As String = strTempRes.Split(CChar("x"))
            If strTempResArray.GetUpperBound(0).ToString = "1" Then
            	ProfileSettings.comboBoxDisplaySettings.Items.Add(strTempResArray(0) & " " & byText & " " & strTempResArray(1) & " " & pixelsText)
            End If
        Next
    End Sub  
    
    Public Sub BPPToComboBox()
        'Add valid BPP's (ex 8,16,32) bit to combobox
        Dim strTempBPP As String
        Dim strBPP As String
        Dim strBPPModes() As String

        strBPP = cScreen.ValidBPPs
        strBPPModes = Split(strBPP, ",")
        ProfileSettings.comboBoxDisplayColors.Items.Clear
        ProfileSettings.comboBoxDisplayColors.Items.Add("")
        
		Dim lang As SetLanguage = New SetLanguage("/Language/ProfileSettings/")
		
		Dim bitText As String = lang.GetText("ColorQualityText-Bit", "bit")
		Dim lowestText As String = lang.GetText("ColorQualityText-Lowest", "Lowest")
		Dim highestText As String = lang.GetText("ColorQualityText-Highest", "Highest")
        
        For Each strTempBPP In strBPPModes
            Dim ThisBPP As String = ""
            Select Case strTempBPP
                Case "8"
                    ThisBPP = "256 (8 " & bitText & ")"
                Case "16"
                    ThisBPP = lowestText & " (16 " & bitText & ")"
                Case "32"
                    ThisBPP = highestText & " (32 " & bitText & ")"
            End Select
            ProfileSettings.comboBoxDisplayColors.Items.Add(ThisBPP)
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
      			
      			' potofcoffee:
      			' the problem is right here: Not all "Packet Schedulers" identify by that
      			' name, especially on non-English systems. For now, I added to more keywords
      			' to check, but:
      			' Is there a way to find out whether an object is a real card or a packet 
      			' scheduler?
      			
'                If Not (TheName.Contains("Packet Scheduler") _
'                		Or TheName.Contains("Miniport") _
'                	    Or TheName.Contains("Paketplaner")) Then
                if isPhysicalAdapter(TheName) then 
                    'MessageBox.Show(TheID.Length.ToString)
                    CurrentWirelessSSID = TheID.Substring(0, TheID.Length - 1)
                    'MessageBox.Show(CurrentWirelessSSID.Length.ToString)
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
				If GetNetworkInstanceName(AutoConnectMACAddress(i).ToString).ToLower = CurrentWirelessName.ToLower And AutoConnectSSID(i).ToString.ToLower = CurrentWirelessSSID.ToLower Then
                    Dim ProfileName As String = INIRead(CStr(AutoConnectProfile(i)), "General", "Name", "[No Name]")
					Dim DoNotConfirmAutoActivate As String = INIRead(ProgramINIFile, "Program", "DoNotConfirmAutoActivate", "False")
					If DoNotConfirmAutoActivate.Equals("True") Then
						Globals.INIAutoLoad = AutoConnectProfile(i).ToString
						AutoActivate.Show
					Else
						Globals.INIAutoLoad = AutoConnectProfile(i).ToString
						WirelessDetected.labelSSID.Text = CurrentWirelessSSID.ToString
						WirelessDetected.labelProfile.Text = ProfileName
						WirelessDetected.Show
						'Dim YNResult As Object
						'YNResult = MessageBox.Show("You are connected to " & CurrentWirelessSSID.ToString & "." & vbCrLf & "Would you like to activate the " & ProfileName & " profile?", Globals.ProgramName & " - Wireless Network Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						'If YNResult = System.Windows.Forms.DialogResult.Yes Then
						'	Globals.INIAutoLoad = AutoConnectProfile(i).ToString
						'	AutoActivate.Show
						'End If
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
		For Each objComputer In colComputers
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
	
	Public Class SetLanguage
		Private root As XmlElement
		Private prefix As String
		
		Public Sub New(prefix As String)
			Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
			Dim xDoc As New XmlDocument
			xDoc.Load(Globals.CurrentLangPath)
			
			Me.prefix = prefix
			Me.root = xDoc.DocumentElement
		End Sub
		
		Public Sub SetText(ByRef control As String, ByVal node As String)
			Try
				control = Me.root.SelectSingleNode(Me.prefix & node).InnerText
			Catch
				' The text remains unchanged if the translation is missing
			End Try
		End Sub
		
		Public Sub SetText(ByRef control As String, ByVal node As String, ByVal oldValue As String, ByVal newValue As String)
			Try
				control = Me.root.SelectSingleNode(Me.prefix & node).InnerText.Replace(oldValue, newValue)
			Catch
				' The text remains unchanged if the translation is missing
			End Try
		End Sub
		
		Public Sub SetToolTip(toolTip As ToolTip, control As Control, node As String)
			Try
				toolTip.SetToolTip(control, root.SelectSingleNode(Me.prefix & node).InnerText)
			Catch
				' The tool tip will not be created or changed if the translation is missing
			End Try
		End Sub
		
		Public Function GetText(node As String, defaultText As String) As String
			Try
				Return root.SelectSingleNode(Me.prefix & node).InnerText
			Catch
				' The default is returned if the translation is missing
				Return defaultText
			End Try
		End Function
	End Class

	Public Class FirefoxSettings
		Private const PrefsFile As String = "prefs.js"
		Private const SessionstoreFile As String = "sessionstore.js"
		Private PrefsPath As String
		Private PrefsList As List(Of String)
		
		Public Sub New()
			Dim IniPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\profiles.ini"
			Dim StartWithLastProfile As String = INIRead(iniPath, "General", "StartWithLastProfile", "0")
			Dim i As Integer = 0
			Dim IsDefault As String = ""
			Dim IsRelative As String = ""
			Dim ProfilePath As String = ""
			Dim CurrentPath As String = ""
			Me.PrefsPath = ""
			Me.PrefsList = New List(Of String)
			
			' Iterate over profile sections in profiles.ini starting with [Profile0]
			Do
				' CurrentPath will be empty if reading a non-existent profile section
				CurrentPath = INIRead(IniPath, "Profile" & i, "Path").Replace("/", "\")
				If CurrentPath <> "" Then
					ProfilePath = CurrentPath
					IsDefault = INIRead(IniPath, "Profile" & i, "Default")
					IsRelative = INIRead(IniPath, "Profile" & i, "IsRelative", "1")
					i = i + 1
				End If
			Loop While (IsDefault <> "1" And CurrentPath <> "")
			If (ProfilePath <> "" And (IsDefault = "1" Or i = 1)) Then
				Try
					Dim oRead As System.IO.StreamReader
					If IsRelative = "0" Then
						Me.PrefsPath = ProfilePath
						oRead = File.OpenText(Me.PrefsPath & "\" & FirefoxSettings.PrefsFile)
					Else
						Me.PrefsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\" & ProfilePath
						oRead = File.OpenText(Me.PrefsPath & "\" & FirefoxSettings.PrefsFile)
					End If
					Do While oRead.Peek() >= 0
						Me.PrefsList.Add(oRead.ReadLine)
					Loop
					oRead.Close()
				Catch
					' Failed attempt of reading prefs.js is ignored and PrefsList remains empty
				End Try
			End If
		End Sub
		
		Public Sub ChangeSetting(Setting As String, Value As String)
			' Value = "" will delete setting
			If Value = "" Then
				Me.SetPref(Setting, "")
			Else
				Me.SetPref(Setting, Chr(34) & Value & Chr(34))
			End If
		End Sub
		
		Public Sub ChangeSetting(Setting As String, Value As Boolean)
			If Value Then
				Me.SetPref(Setting, "true")
			Else
				Me.SetPref(Setting, "false")
			End If
		End Sub
		
		Public Sub ChangeSetting(Setting As String, Value As Integer)
			Me.SetPref(Setting, Value.ToString())
		End Sub
		
		Private Sub SetPref(Setting As String, Value As String)
			Dim SettingChanged As Boolean = False
			Dim i As Integer = 0
			While i < Me.PrefsList.Count
				If Me.PrefsList(i).Contains("user_pref(" & Chr(34) & Setting & Chr(34) & ", ") Then
					If SettingChanged Or (Value = "") Then
						' Remove setting if duplicated or has to be deleted
						Me.PrefsList.RemoveAt(i)
					Else
						Me.PrefsList(i) = "user_pref(" & Chr(34) & Setting & Chr(34) & ", " & Value & ");"
						SettingChanged = True
					End If
				End If
				i = i + 1
			End While
			If Not SettingChanged And (Value <> "") Then
				me.PrefsList.Add("user_pref(" & Chr(34) & Setting & Chr(34) & ", " & Value & ");")
			End if
		End Sub
		
		Public Sub SetProxySettings(ByVal ProxyGlobal As String, ByVal ProxyGlobalPort As String, ByVal ProxyHttp As String, ByVal ProxyHttpPort As String, ByVal ProxyHttps As String, ByVal ProxyHttpsPort As String, ByVal ProxyFtp As String, ByVal ProxyFtpPort As String, ByVal ProxySocks As String, ByVal ProxySocksPort As String, ByVal ProxyGopher As String, ByVal ProxyGopherPort As String, ByVal ProxyExceptions As Array)
			Dim ProxyEnable As Boolean
			Dim ShareProxySettings As Boolean
			Dim NoProxyOn As String = ""
			
			For Each Exception As String In ProxyExceptions
				If NoProxyOn = "" Then
					NoProxyOn = Exception
				Else
					NoProxyOn = NoProxyOn & ", " & Exception
				End If
			Next
			
			If ProxyGlobal <> "" Then
				ShareProxySettings = True
				ProxyHttp = ProxyGlobal
				ProxyHttpPort = ProxyGlobalPort
				ProxyHttps = ProxyGlobal
				ProxyHttpsPort = ProxyGlobalPort
				ProxyFtp = ProxyGlobal
				ProxyFtpPort = ProxyGlobalPort
				ProxySocks = ProxyGlobal
				ProxySocksPort = ProxyGlobalPort
				ProxyGopher = ProxyGlobal
				ProxyGopherPort = ProxyGlobalPort
			Else
				ShareProxySettings = False
			End If
			
			If (ProxyGlobal = "" And ProxyHttp = "" And ProxyHttps = "" And ProxyFtp = "" And ProxySocks = "" And ProxyGopher = "") Then
				ProxyEnable = False
			Else
				ProxyEnable = True
			End If
			
			If ProxyEnable Then
				Me.ChangeSetting("network.proxy.type", 1)
				Me.ChangeSetting("network.proxy.share_proxy_settings", ShareProxySettings)
			Else
				Me.ChangeSetting("network.proxy.type", "")
				Me.ChangeSetting("network.proxy.share_proxy_settings", "")
			End If
			Me.ChangeSetting("network.proxy.http", ProxyHttp)
			Me.ChangeSetting("network.proxy.http_port", ProxyHttpPort)
			Me.ChangeSetting("network.proxy.ssl", ProxyHttps)
			Me.ChangeSetting("network.proxy.ssl_port", ProxyHttpsPort)
			Me.ChangeSetting("network.proxy.ftp", ProxyFtp)
			Me.ChangeSetting("network.proxy.ftp_port", ProxyFtpPort)
			Me.ChangeSetting("network.proxy.socks", ProxySocks)
			Me.ChangeSetting("network.proxy.socks_port", ProxySocksPort)
			Me.ChangeSetting("network.proxy.gopher", ProxyGopher)
			Me.ChangeSetting("network.proxy.gopher_port", ProxyGopherPort)
			Me.ChangeSetting("network.proxy.no_proxies_on", NoProxyOn)
		End Sub
	
		Public Sub Apply()
			Dim oRead As System.IO.StreamReader
			Dim oWrite As System.IO.StreamWriter
			Dim FFProcess As System.Diagnostics.Process = Nothing
			Dim FFPath As String = ""
			' List all Firefox processes from all users
			Dim Processes As Process() = System.Diagnostics.Process.GetProcessesByName("firefox")
			For Each Process As System.Diagnostics.Process In Processes
				' Firefox prevents starting itself more than once with the same user account, also if the user is logged
				' in with multiple sessions. Only processes of the current user have to be killed, for simplicity the
				' rare case where Firefox runs in an other session of the current user is ignored.
				If Process.SessionID = System.Diagnostics.Process.GetCurrentProcess().SessionId Then
					FFProcess = Process
					FFPath = Process.MainModule.FileName
				End If
			Next
			
			If FFPath <> "" Then
				Dim MsgBoxManager As MessageBoxManager
				MsgBoxManager = New MessageBoxManager
				MsgBoxManager.AutoClose = True
				MsgBoxManager.AutoCloseResult = System.Windows.Forms.DialogResult.Yes
				MsgBoxManager.CenterWindow = True
				MsgBoxManager.DisableButtons = False
				MsgBoxManager.DisableCancel = False
				MsgBoxManager.HookEnabled = False
				MsgBoxManager.LastCheckState = False
				MsgBoxManager.ShowNextTimeCheck = False
				MsgBoxManager.ShowTitleCountDown = True
				MsgBoxManager.TimeOut = 5
				
				Dim lang As SetLanguage = New SetLanguage("/Language/Misc/")
				
				Dim ConfirmPromptTitle As String = lang.GetText("FirefoxSettings-ConfirmPrompt-Title", "Confirm Firefox Restart")
				Dim ConfirmPromptMessage As String = lang.GetText("FirefoxSettings-ConfirmPrompt-Message", "Would you like to restart Firefox to apply the new settings?")
				
				'Confirm Prompt: Returns Yes/No (DialogResult)
				MsgBoxManager.HookEnabled = True
				Dim ShowConfirmPrompt As System.Windows.Forms.DialogResult = MessageBox.Show(ConfirmPromptMessage, ConfirmPromptTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
				MsgBoxManager.HookEnabled = False
				
				If ShowConfirmPrompt = System.Windows.Forms.DialogResult.Yes Then
					' Make sure Firefox restores the previous session after killing it (default setting is enabled but set it anyway)
					Me.ChangeSetting("browser.sessionstore.resume_from_crash", True)
					
					FFProcess.Kill()
					' Wait until process is killed or timeout occurs after 5 seconds
					FFProcess.WaitForExit(5000)
				Else
					FFPath = ""
				End If
			End If
			
			' Save modified preferences (will have no affect if Firefox is running and the restart was denied)
			Try
				oWrite = File.CreateText(Me.PrefsPath & "\" & FirefoxSettings.PrefsFile)
				For Each Line As String In Me.PrefsList
					oWrite.WriteLine(Line)
				Next
				oWrite.Close()
			Catch
				' Ignore falied attempts to write prefs.js
			End Try
			
			' Start Firefox if it was killed before changing the settings
			If FFPath <> "" Then
				Try
					' Prevent displaying the recovery page by setting the counter of recent crashes to 0
					oRead = File.OpenText(Me.PrefsPath & "\" & FirefoxSettings.SessionstoreFile)
					Dim Sessionstore As String = oRead.ReadToEnd
					oRead.Close()
					Dim Pos1 As Integer = Sessionstore.IndexOf(",""recentCrashes"":") + ",""recentCrashes"":".Length
					Dim Pos2 As Integer = Pos1 + Sessionstore.Substring(Pos1).IndexOf("}")
					oWrite = File.CreateText(Me.PrefsPath & "\" & FirefoxSettings.SessionstoreFile)
					oWrite.Write(Sessionstore.Substring(0, Pos1) & "0" & Sessionstore.Substring(Pos2))
					oWrite.Close
				Catch
					' Ignore falied attempt to change sessionstore.js
				End Try
				
				Process.Start(FFPath)
			End If
		End Sub
	End Class
End Module
