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

Public Module Globals
	Public ProgramVersion As String = "2.1.6"
	Public ProgramName As String = "Net Profiles"
	Public CurrentLang As String = "en-US"
	Public CurrentLangPath As String
	Public CreatingNewProfile As Boolean
	Public CreatingNewMappedDrive As Boolean
	Public CreatingNewRunCommand As Boolean
	Public ProgramINIFile As String = My.Application.Info.DirectoryPath & "\netprofiles.ini"
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
				If SHGetPathFromIDList(pidl, spath) Then
					GetBrowseNetworkShare = TrimNull(spath)
				Else
					GetBrowseNetworkShare = "\\" & bi.pszDisplayName
				End If
			End If
			
			Call CoTaskMemFree(pidl)
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
	
	Public Sub SaveTCPIPSettings(ByRef IPAddress As String, ByRef SubnetMask As String, ByRef Gateway As String, ByRef PDNSServer As String, ByRef ADNSServer As String, ByRef WINSServer As String, ByRef DHCP As Boolean, ByRef MACAddress As String, ByRef ApplyType As String)
		Dim objNetAdapter As Object
		Dim strDNSServers As Object
		Dim strWINSServer As Object
		Dim strGatewaymetric As Object
		Dim strGateway As Object
		Dim strSubnetMask As Object
		Dim strIPAddress As Object
		Dim colNetAdapters As Object
		Dim objWMIService As Object
		Dim strComputer As Object

		strComputer = "."
		objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
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
		
		For	Each objNetAdapter In colNetAdapters
			If DHCP.Equals(True) Then
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
			Else
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
		DisconnectNetworkDrive = WNetCancelConnection2(sDrv, CONNECT_UPDATE_PROFILE, sForce)
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
		
		Dim NETR As NETRESOURCE
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
	
	'*** START PRINTERS ***
	Public Sub SetDefaultPrinter(ByRef defaultPrinter As String)
		Dim objprinter As Object
		Dim colInstalledPrinters As Object
		Dim objWMIService As Object
		Dim strComputer As Object
		strComputer = "."
		objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
		colInstalledPrinters = objWMIService.ExecQuery("Select * from Win32_Printer")
		For	Each objprinter In colInstalledPrinters
			Application.DoEvents()
			If objprinter.Name = defaultPrinter Then
				objprinter.SetDefaultPrinter()
			End If
		Next objprinter
	End Sub
	'*** END PRINTERS ***
	
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
         Placement = oShell.SpecialFolders.Item("Desktop")
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
				Return queryObj("NetConnectionID")
			Next
		Catch err As ManagementException
			Return ""
		End Try
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
			
			For Each queryObj As ManagementObject in searcher.Get()
     			Application.DoEvents
     			If Not MACAddresses.Contains(queryObj("MACAddress")) Then
     				NetworkInterfaceName = ""
     				NetworkInterfaceName = GetInterfaceName(queryObj("MACAddress"))
     				If NetworkInterfaceName.Trim.Length = 0 Then
     					NetworkInterfaceName = GetNetworkInstanceName(queryObj("MACAddress").Replace("-",":"))
     				End If
     				NetworkCardList.Add(New DictionaryEntry(queryObj("MACAddress"), NetworkInterfaceName))
     				MACAddresses = MACAddresses & queryObj("MACAddress")
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
				Dim DHCP As String = queryObj("DHCPEnabled")
				Dim IPAddress As String = queryObj("IPAddress")(0)
				Dim SubnetMask As String = queryObj("IPSubnet")(0)
				Dim DefaultGateway As String = Join(queryObj("DefaultIPGateway"), ",")
				Dim PrimaryDNSServer As String = Join(queryObj("DNSServerSearchOrder"), ",")
				Dim WINSServer As String = queryObj("WINSPrimaryServer")
				Return DHCP & "|" & IPAddress & "|" & SubnetMask & "|" & DefaultGateway & "|" & PrimaryDNSServer & "|" & WINSServer
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
				Return queryObj("Name")
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
    Private Const SPI_SETDESKWALLPAPER = 20
    Private Const SPIF_UPDATEINIFILE = &H1
    
    Public Sub SetWallpaper(ByVal WallpaperFile As String)
		MainForm.pictureBoxWallpaper.Image = Image.FromFile(WallpaperFile)
        'just some generic path and name for the image in the picturebox 
        'to save to
        Dim imagePath As String = My.Application.Info.DirectoryPath & "\wallpaper.bmp"

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
        
        Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement
		Dim byText As String = root.SelectSingleNode("/Language/ProfileSettings/ScreenResolutionText-By").InnerText
		Dim pixelsText As String = root.SelectSingleNode("/Language/ProfileSettings/ScreenResolutionText-Pixels").InnerText

        For Each strTempRes In strModes
            'cboResolution.Items.Add(strTempRes)
            Dim strTempResArray() As String = strTempRes.Split("x")
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
        
        Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement
		Dim bitText As String = root.SelectSingleNode("/Language/ProfileSettings/ColorQualityText-Bit").InnerText
		Dim lowestText As String = root.SelectSingleNode("/Language/ProfileSettings/ColorQualityText-Lowest").InnerText
		Dim highestText As String = root.SelectSingleNode("/Language/ProfileSettings/ColorQualityText-Highest").InnerText
        
        For Each strTempBPP In strBPPModes
            Dim ThisBPP As String = ""
            Select Case strTempBPP
                Case 8
                    ThisBPP = "256 (8 " & bitText & ")"
                Case 16
                    ThisBPP = lowestText & " (16 " & bitText & ")"
                Case 32
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
				f = (Adapter("Manufacturer") <> "Microsoft")
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
				For i = 0 To queryObj("Ndis80211SsId")(0)
      				TheID = TheID & chr(queryObj("Ndis80211SsId")(i + 4))
      			Next
      			TheName = queryObj("InstanceName")
      			
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
					Dim ProfileName As String = INIRead(AutoConnectProfile(i), "General", "Name", "[No Name]")
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
						'YNResult = MessageBox.Show("You are connected to " & CurrentWirelessSSID.ToString & "." & vbCrLf & "Would you like to activate the " & ProfileName & " profile?", "Net Profiles - Wireless Network Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
				Return queryObj("Description")
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
        Dim oReg As Microsoft.Win32.Registry
        Dim oRegKey As Microsoft.Win32.RegistryKey

        'oRegKey = oReg.LocalMachine.OpenSubKey(PathToValue, True)
        oRegKey = oReg.CurrentUser.OpenSubKey(PathToValue, True)
        oRegKey.SetValue(KeyName, ValueToUse)
    End Sub
    
    Public Sub DeleteRegistryKey(ByVal PathToValue As String, ByVal KeyName As String)
        Dim oReg As Microsoft.Win32.Registry
        Dim oRegKey As Microsoft.Win32.RegistryKey

        'oRegKey = oReg.LocalMachine.OpenSubKey(PathToValue, True)
        oRegKey = oReg.CurrentUser.OpenSubKey(PathToValue, True)
        oRegKey.DeleteValue(KeyName, False)
    End Sub
    
    Public Sub SaveOperaSettings(ByVal ProxyServer As String, ByVal ProxyPort As String, ByVal ProxyEnable As Integer, ByVal AutoProxyConfigURL As String, ByVal ProxyBypass As Boolean, ByVal DefaultHomepage As String)
    	Dim OperaSettingsINI As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Opera\Opera\profile\opera6.ini"
    	Dim f As New IO.FileInfo(OperaSettingsINI)
        If f.Exists = True Then
        	If ProxyServer.Length > 0 Then
        		INIWrite(OperaSettingsINI, "Proxy", "HTTP Server", ProxyServer.Trim & ":" & ProxyPort.Trim)
        	Else
        		INIWrite(OperaSettingsINI, "Proxy", "HTTP Server", "")
        	End If
        	INIWrite(OperaSettingsINI, "Proxy", "Use HTTP", ProxyEnable)
        	INIWrite(OperaSettingsINI, "Proxy", "Use HTTPS", ProxyEnable)
        	Dim AutoProxyConfigEnable As Integer = 0
        	If AutoProxyConfigURL.Length > 0 Then
        		AutoProxyConfigEnable = 1
        	End If
        	INIWrite(OperaSettingsINI, "Proxy", "Use Automatic Proxy Configuration", AutoProxyConfigEnable)
        	INIWrite(OperaSettingsINI, "Proxy", "Automatic Proxy Configuration URL", AutoProxyConfigURL.Trim)
        	Dim UseProxyOnLocal As Integer = 1
        	If ProxyBypass.Equals(True) Then
        		UseProxyOnLocal = 0
        	End If
        	INIWrite(OperaSettingsINI, "Proxy", "Use Proxy On Local Names Check", UseProxyOnLocal)
        	If DefaultHomepage.Length > 0 Then
        		INIWrite(OperaSettingsINI, "User Prefs", "Home URL", DefaultHomepage)
        	End If
        End If
    End Sub
    
    Public Sub SaveFirefoxAutoConfigAddress(ByVal AutoConfigAddress As String)
    	Dim FireFoxProfilesDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\Profiles"
		If Not Dir(FireFoxProfilesDir, FileAttribute.Directory) = "" Then
			Dim FirefoxProfiles As New DirectoryInfo(FireFoxProfilesDir)
			Dim Dirs As DirectoryInfo() = FirefoxProfiles.GetDirectories("*.default")
			Dim DirectoryName As DirectoryInfo
			For Each DirectoryName In Dirs
				Try
					If Not Dir(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js", FileAttribute.Normal) = "" Then
						Dim oFile As System.IO.File
						Dim oRead As System.IO.StreamReader
						oRead = oFile.OpenText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						Dim CurrentFile As String = ""
						Dim CurrentLine As String = ""
						Dim AutoConfigAddressExists As Boolean = False
						While oRead.Peek <> -1
							CurrentLine = oRead.ReadLine()
							If CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.autoconfig_url" & Chr(34) & ", ") Then
								CurrentLine = "user_pref(" & Chr(34) & "network.proxy.autoconfig_url" & Chr(34) & ", " & Chr(34) & AutoConfigAddress & Chr(34) & ");"
								AutoConfigAddressExists = True
							End If
							If CurrentFile.Length = 0 Then
								CurrentFile = CurrentLine
							Else
								CurrentFile = CurrentFile & vbCrLf & CurrentLine
							End If
						End While
						oRead.Close()
						'If CurrentFile.Length = 0 Then
						'	CurrentFile = "user_pref(" & Chr(34) & "network.proxy.autoconfig_url" & Chr(34) & ", " & Chr(34) & AutoConfigAddress & Chr(34) & ");"
						'End If
						If AutoConfigAddressExists = False Then
							CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "network.proxy.autoconfig_url" & Chr(34) & ", " & Chr(34) & AutoConfigAddress & Chr(34) & ");"
						End If
						
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.Write(CurrentFile)
						oWrite.Close()
					Else
						Dim oFile As System.IO.File
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.WriteLine("user_pref(" & Chr(34) & "network.proxy.autoconfig_url" & Chr(34) & ", " & Chr(34) & AutoConfigAddress & Chr(34) & ");")
						oWrite.Close()
					End If
				Catch
				
				End Try
			Next
		End If
    End Sub
    
    Public Sub SaveFirefoxSettings(ByVal ProxyServer As String, ByVal ProxyPort As String, ByVal ProxyEnable As String)
    	Dim FireFoxProfilesDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\Profiles"
		If Not Dir(FireFoxProfilesDir, FileAttribute.Directory) = "" Then
			Dim FirefoxProfiles As New DirectoryInfo(FireFoxProfilesDir)
			Dim Dirs As DirectoryInfo() = FirefoxProfiles.GetDirectories("*.default")
			Dim DirectoryName As DirectoryInfo
			For Each DirectoryName In Dirs
				Try
					If Not Dir(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js", FileAttribute.Normal) = "" Then
						Dim oFile As System.IO.File
						Dim oRead As System.IO.StreamReader
						oRead = oFile.OpenText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						Dim CurrentFile As String = ""
						Dim CurrentLine As String = ""
						Dim ProxyHTTPExists As Boolean = False
						Dim ProxyPortExists As Boolean = False
						Dim ProxyTypeExists As Boolean = False
						While oRead.Peek <> -1
							CurrentLine = oRead.ReadLine()
							If CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.http" & Chr(34) & ", ") Then
								CurrentLine = "user_pref(" & Chr(34) & "network.proxy.http" & Chr(34) & ", " & Chr(34) & ProxyServer & Chr(34) & ");"
								ProxyHTTPExists = True
							ElseIf CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.http_port" & Chr(34) & ", ") Then
								CurrentLine = "user_pref(" & Chr(34) & "network.proxy.http_port" & Chr(34) & ", " & ProxyPort & ");"
								ProxyPortExists = True
							ElseIf CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.type" & Chr(34) & ", ") Then
								CurrentLine = "user_pref(" & Chr(34) & "network.proxy.type" & Chr(34) & ", " & ProxyEnable & ");"
								ProxyTypeExists = True
							End If
							If CurrentFile.Length = 0 Then
								CurrentFile = CurrentLine
							Else
								CurrentFile = CurrentFile & vbCrLf & CurrentLine
							End If
						End While
						oRead.Close()
						'If CurrentFile.Length = 0 Then
						'	CurrentFile = "user_pref(" & Chr(34) & "network.proxy.http" & Chr(34) & ", " & Chr(34) & ProxyServer & Chr(34) & ");"
						'	CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "network.proxy.http_port" & Chr(34) & ", " & ProxyPort & ");"
						'	CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "network.proxy.type" & Chr(34) & ", " & ProxyEnable & ");"
						'End If
						If ProxyHTTPExists = False Then
							CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "network.proxy.http" & Chr(34) & ", " & Chr(34) & ProxyServer & Chr(34) & ");"
						End If
						If ProxyPortExists = False Then
							CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "network.proxy.http_port" & Chr(34) & ", " & ProxyPort & ");"
						End If
						If ProxyTypeExists = False Then
							CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "network.proxy.type" & Chr(34) & ", " & ProxyEnable & ");"
						End If
						
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.Write(CurrentFile)
						oWrite.Close()
					Else
						Dim oFile As System.IO.File
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.WriteLine("user_pref(" & Chr(34) & "network.proxy.http" & Chr(34) & ", " & Chr(34) & ProxyServer & Chr(34) & ");")
						oWrite.WriteLine("user_pref(" & Chr(34) & "network.proxy.http_port" & Chr(34) & ", " & ProxyPort & ");")
						oWrite.WriteLine("user_pref(" & Chr(34) & "network.proxy.type" & Chr(34) & ", " & ProxyEnable & ");")
						oWrite.Close()
					End If
				Catch
				
				End Try
			Next
		End If
    End Sub
    
	Public Sub DeleteFirefoxSettings()
    	Dim FireFoxProfilesDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\Profiles"
		If Not Dir(FireFoxProfilesDir, FileAttribute.Directory) = "" Then
			Dim FirefoxProfiles As New DirectoryInfo(FireFoxProfilesDir)
			Dim Dirs As DirectoryInfo() = FirefoxProfiles.GetDirectories("*.default")
			Dim DirectoryName As DirectoryInfo
			For Each DirectoryName In Dirs
				Try
					If Not Dir(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js", FileAttribute.Normal) = "" Then
						Dim oFile As System.IO.File
						Dim oRead As System.IO.StreamReader
						oRead = oFile.OpenText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						Dim CurrentFile As String = ""
						Dim CurrentLine As String = ""
						While oRead.Peek <> -1
							CurrentLine = oRead.ReadLine()
							If CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.http" & Chr(34) & ", ") Then
								CurrentLine = ""
							ElseIf CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.http_port" & Chr(34) & ", ") Then
								CurrentLine = ""
							ElseIf CurrentLine.Contains("user_pref(" & Chr(34) & "network.proxy.type" & Chr(34) & ", ") Then
								CurrentLine = ""
							ElseIf CurrentLine.Contains("user_pref(" & Chr(34) & "browser.startup.homepage" & Chr(34) & ", ") Then
								CurrentLine = ""
							End If
							If CurrentLine.Length > 0 Then
								If CurrentFile.Length = 0 Then
									CurrentFile = CurrentLine
								Else
									CurrentFile = CurrentFile & vbCrLf & CurrentLine
								End If
							End If
						End While
						oRead.Close()
						
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.Write(CurrentFile)
						oWrite.Close()
					Else
						
					End If
				Catch
				
				End Try
			Next
		End If
    End Sub
    
    Public Sub SaveFirefoxHomepage(ByVal Homepage As String)
    	Dim FireFoxProfilesDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\Profiles"
		If Not Dir(FireFoxProfilesDir, FileAttribute.Directory) = "" Then
			Dim FirefoxProfiles As New DirectoryInfo(FireFoxProfilesDir)
			Dim Dirs As DirectoryInfo() = FirefoxProfiles.GetDirectories("*.default")
			Dim DirectoryName As DirectoryInfo
			For Each DirectoryName In Dirs
				Try
					If Not Dir(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js", FileAttribute.Normal) = "" Then
						Dim oFile As System.IO.File
						Dim oRead As System.IO.StreamReader
						oRead = oFile.OpenText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						Dim CurrentFile As String = ""
						Dim CurrentLine As String = ""
						Dim LineExists As Boolean = False
						While oRead.Peek <> -1
							CurrentLine = oRead.ReadLine()
							If CurrentLine.Contains("user_pref(" & Chr(34) & "browser.startup.homepage" & Chr(34) & ", ") Then
								CurrentLine = "user_pref(" & Chr(34) & "browser.startup.homepage" & Chr(34) & ", " & Chr(34) & Homepage & Chr(34) & ");"
								LineExists = True
							End If
							If CurrentFile.Length = 0 Then
								CurrentFile = CurrentLine
							Else
								CurrentFile = CurrentFile & vbCrLf & CurrentLine
							End If
						End While
						oRead.Close()
						If CurrentFile.Length = 0 Then
							CurrentFile = "user_pref(" & Chr(34) & "browser.startup.homepage" & Chr(34) & ", " & Chr(34) & Homepage & Chr(34) & ");"
						End If
						If LineExists = False Then
							CurrentFile = CurrentFile & vbCrLf & "user_pref(" & Chr(34) & "browser.startup.homepage" & Chr(34) & ", " & Chr(34) & Homepage & Chr(34) & ");"
						End If
						
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.Write(CurrentFile)
						oWrite.Close()
					Else
						Dim oFile As System.IO.File
						Dim oWrite As System.IO.StreamWriter
						oWrite = oFile.CreateText(FireFoxProfilesDir & "\" & DirectoryName.Name & "\user.js")
						oWrite.WriteLine("user_pref(" & Chr(34) & "browser.startup.homepage" & Chr(34) & ", " & Chr(34) & Homepage & Chr(34) & ");")
						oWrite.Close()
					End If
				Catch
				
				End Try
			Next
		End If
    End Sub
    
    Public Sub RenameComputer(ByVal NewName As String)
    	Dim objComputer As Object
		Dim colComputers As Object
		Dim objWMIService As Object
		Dim strComputer As Object
		strComputer = "."
		objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
		colComputers = objWMIService.ExecQuery("Select * from Win32_ComputerSystem")
		For Each objComputer In colComputers
			ObjComputer.Rename(NewName)
		Next
    End Sub
    
End Module
