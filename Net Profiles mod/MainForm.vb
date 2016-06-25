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
' Date: 1/25/2007
' Time: 10:49 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.IO
Imports System.Management
Imports Microsoft.Win32
Imports IWshRuntimeLibrary
Imports System.Diagnostics.Process
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Xml
Imports AppModule.InterProcessComm
Imports AppModule.NamedPipes
Imports AppModule.Globals
Imports NativeWifi

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
		' On Vista and newer the Managed Wifi API is used to detect the connected SSIDs
		If osInfo.Version.Major >= 6 Then
			Try
				Me.Wlan = New WlanClient()
			Catch
				' Fails if the WLAN AutoConfig service isn't started (on systems without WLAN adapters).
			End Try
		End If
		
		toolStripStatusLabel1.Text = ProgramName & " " & ProgramVersion
		'
		'messageBoxManager1
		'
		Me.messageBoxManager1 = New MessageBoxManager
		Me.messageBoxManager1.AutoClose = True
		Me.messageBoxManager1.AutoCloseResult = System.Windows.Forms.DialogResult.No
		Me.messageBoxManager1.CenterWindow = True
		Me.messageBoxManager1.DisableButtons = False
		Me.messageBoxManager1.DisableCancel = False
		Me.messageBoxManager1.HookEnabled = False
		Me.messageBoxManager1.LastCheckState = False
		Me.messageBoxManager1.ShowNextTimeCheck = False
		Me.messageBoxManager1.ShowTitleCountDown = True
		Me.messageBoxManager1.TimeOut = 20
	End Sub
	
	Public StatusLabelWorking As String
	Public StatusLabelWorking_Preloading As String
	Public StatusLabelWorking_Activating As String
	Public StatusLabelWorking_UnmapDrives As String
	Public StatusLabelWorking_MapDrives As String
	Public StatusLabelWorking_Printer As String
	Public StatusLabelWorking_Internet As String
	Public StatusLabelWorking_Homepage As String
	Public StatusLabelWorking_Programs As String
	Public StatusLabelWorking_Wallpaper As String
	Public StatusLabelWorking_Resolution As String
	Public StatusLabelWorking_Reloading As String
	Public StatusLabelWorking_DHCP As String
	Public StatusLabelWorking_IPAddress As String
	Public StatusLabelWorking_Gateway As String
	Public StatusLabelWorking_DNS As String
	Public StatusLabelWorking_WINS As String
	Public NoNetworkProfilesMessageBox_1 As String
	Public NoNetworkProfilesMessageBox_2 As String
	Public DeleteProfileMessageBox As String
	Public DeleteProfileMessageBox_Title As String
	Public ShortcutConfigDefault As String
	Public CreateShortcutMessagebox As String
	Public CheckForUpdates_Latest As String
	Public CheckForUpdates_New_1 As String
	Public CheckForUpdates_New_2 As String
	Public CheckForUpdates_Title As String
	Public CheckForUpdates_Error_1 As String
	Public CheckForUpdates_Error_2 As String
	Private messageBoxManager1 As MessageBoxManager
	Private specialExitPermission As String = ""
	Public ProfileApplyInProgress As Boolean = False
	Private NetworkAddressChangedQueue As BlockingQueue = New BlockingQueue()
	Public Wlan As WlanClient = Nothing
	
	
	Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        CurrentLangPath = My.Application.Info.DirectoryPath & "\lang\" & INIRead(Globals.ProgramINIFile, "Program", "Language", "en-US.xml")
        CurrentLang = INIRead(Globals.ProgramINIFile, "Program", "Language", "en-US.xml")
        CurrentLang = CurrentLang.Substring(0, CurrentLang.Length - 4)
        Call LoadLanguage()

        'TODO: Replace Microsoft.VisualBasic
        If Microsoft.VisualBasic.Command.Length > 0 Then
            commandArray = Microsoft.VisualBasic.Command.Split(System.Convert.ToChar("|"))
            Select Case commandArray(0)
                Case "auto"
                    Globals.EnableLoadTimer = False
                    Me.notifyIcon1.Visible = False
                    Me.Visible = False
                    AutoActivate.ShowDialog()
            End Select
        End If
        'TODO: Replace Microsoft.VisualBasic
        ' The profiles folder is created by the installer with limited rights for users. To allow debugging while the
        ' application is not installed, the folder is created here. In this case non-administrators are able to add
        ' profile files.
        If Dir(ProfilesFolder, Microsoft.VisualBasic.FileAttribute.Directory) = "" Then
            MkDir((ProfilesFolder))
        End If
        Dim ShowToolbarText As String = INIRead(Globals.ProgramINIFile, "Program", "ShowToolbarText", "True")
        If ShowToolbarText = "False" Then
            Call Me.ToggleToolbarTextToolStripMenuItemClick(sender, e)
        End If
        Dim MinimizeToTray As String = INIRead(Globals.ProgramINIFile, "Program", "MinimizeToTray", "False")
        If MinimizeToTray.Equals("False") Then
            Globals.OKToCloseProgram = True
            Me.minimizeToTrayOnCloseToolStripMenuItem.Checked = False
        Else
            Globals.OKToCloseProgram = False
            Me.minimizeToTrayOnCloseToolStripMenuItem.Checked = True
        End If

        Dim LocationTop As String = INIRead(Globals.ProgramINIFile, "Program", "LocationTop", "")
        Dim LocationLeft As String = INIRead(Globals.ProgramINIFile, "Program", "LocationLeft", "")
        If LocationTop.Length > 0 And LocationLeft.Length > 0 Then
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Location = New System.Drawing.Point(CInt(LocationLeft), CInt(LocationTop))
        End If
        Dim WindowWidth As String = INIRead(Globals.ProgramINIFile, "Program", "WindowWidth", "")
        Dim WindowHeight As String = INIRead(Globals.ProgramINIFile, "Program", "WindowHeight", "")
        If WindowWidth.Length > 0 And WindowHeight.Length > 0 Then
            Me.Size = New Size(CInt(WindowWidth), CInt(WindowHeight))
        End If
        Dim AskBeforeChangingResolution As String = INIRead(Globals.ProgramINIFile, "Program", "AskBeforeChangingResolution", "True")
        If AskBeforeChangingResolution.Equals("False") Then
            Me.askBeforeChangingResolutionToolStripMenuItem.Checked = False
        End If
        Dim AskAfterChangingResolution As String = INIRead(Globals.ProgramINIFile, "Program", "AskAfterChangingResolution", "True")
        If AskAfterChangingResolution.Equals("False") Then
            Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked = False
        End If
        Dim ToTrayOnStartup As String = INIRead(Globals.ProgramINIFile, "Program", "ToTrayOnStartup", "False")
        If ToTrayOnStartup = "True" Then
            Me.minimizeToTrayOnStartupToolStripMenuItem.Checked = True
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            Me.ShowInTaskbar = False
        End If
        Dim DoNotConfirmAutoActivate As String = INIRead(Globals.ProgramINIFile, "Program", "DoNotConfirmAutoActivate", "False")
        If DoNotConfirmAutoActivate.Equals("True") Then
            Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Checked = True
        End If
        Dim DoNotConfirmAutoRestartFirefox As String = INIRead(Globals.ProgramINIFile, "Program", "DoNotConfirmAutoRestartFirefox", "False")
        If DoNotConfirmAutoRestartFirefox.Equals("True") Then
            Me.dontAskBeforeRestartingFirefoxToolStripMenuItem.Checked = True
        End If
        If GetRegistryKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", ProgramName).Length > 0 Then
            Me.runWhenILogInToWindowsToolStripMenuItem.Checked = True
        End If
        If Globals.EnableLoadTimer.Equals(True) Then
            Me.timerUpdateAdapters.Enabled = True
        End If

        Call GetLanguages()
    End Sub
	
	Public Sub GetLanguages()
		Dim LanguagePath As New DirectoryInfo(My.Application.Info.DirectoryPath & "\lang")
        Dim Files As FileInfo() = LanguagePath.GetFiles("*.xml")
        Dim Filename As FileInfo
        Dim LanguageMenuItem As ToolStripMenuItem

        For Each Filename In Files
            Try
                Dim xDoc As New XmlDocument
				xDoc.Load(Filename.FullName)
				Dim root As XmlElement = xDoc.DocumentElement
				
				LanguageMenuItem = DirectCast(Me.languageToolStripMenuItem.DropDownItems.Add(root.SelectSingleNode( _
					"/Language").Attributes("display_name").Value), ToolStripMenuItem)
                LanguageMenuItem.Tag = Filename.Name
                LanguageMenuItem.CheckOnClick = True
                AddHandler LanguageMenuItem.Click, AddressOf LanguageMenuClick
                If Filename.FullName.ToLower = CurrentLangPath.ToLower Then
                	LanguageMenuItem.Checked = True
                End If
            Catch E As Exception
                
            End Try
        Next
	End Sub
	
	Private Sub LanguageMenuClick(sender as Object, e as System.EventArgs)
        If sender.Checked = True Then
            Dim LangMenuItem As ToolStripMenuItem
            For Each LangMenuItem In Me.languageToolStripMenuItem.DropDownItems
                If LangMenuItem.Tag.Substring(0, LangMenuItem.Tag.Length - 4) = CurrentLang.ToLower Then
                    LangMenuItem.Checked = False
                End If
            Next
            CurrentLang = CStr(sender.Tag).Substring(0, CInt(sender.Tag.Length) - 4)
            CurrentLangPath = CStr(My.Application.Info.DirectoryPath & "\lang\" & sender.Tag)
            INIWrite(Globals.ProgramINIFile, "Program", "Language", CStr(sender.Tag))
            Call LoadLanguage()
        Else
            sender.Checked = True
        End If
	End Sub
	
	Public Sub LoadLanguage()
        Dim lang As SetLanguage = New SetLanguage("/Language/MainForm/")
        
        lang.SetText(Me.fileToolStripMenuItem.Text, "fileToolStripMenuItem")
        lang.SetText(Me.toolStripMenuItemNewProfile.Text, "toolStripMenuItemNewProfile")
        lang.SetText(Me.languageToolStripMenuItem.Text, "languageToolStripMenuItem")
        lang.SetText(Me.applyProfileToolStripMenuItemApplyProfile.Text, "applyProfileToolStripMenuItemApplyProfile")
        lang.SetText(Me.activateOnDifferentNetworkCardToolStripMenuItem1.Text, "activateOnDifferentNetworkCardToolStripMenuItem1")
        lang.SetText(Me.toolStripMenuItemCopyProfile.Text, "toolStripMenuItemCopyProfile")
        lang.SetText(Me.toolStripMenuItemEditProfile.Text, "toolStripMenuItemEditProfile")
        lang.SetText(Me.deleteToolStripMenuItemDeleteProfile.Text, "deleteToolStripMenuItemDeleteProfile")
        lang.SetText(Me.createDesktopShortcutToolStripMenuItem1.Text, "createDesktopShortcutToolStripMenuItem1")
        lang.SetText(Me.exitToolStripMenuItem.Text, "exitToolStripMenuItem")
        lang.SetText(Me.optionsToolStripMenuItem.Text, "optionsToolStripMenuItem")
        lang.SetText(Me.toggleToolbarTextToolStripMenuItem.Text, "toggleToolbarTextToolStripMenuItem")
        lang.SetText(Me.minimizeToTrayOnCloseToolStripMenuItem.Text, "minimizeToTrayOnCloseToolStripMenuItem")
        lang.SetText(Me.minimizeToTrayOnStartupToolStripMenuItem.Text, "minimizeToTrayOnStartupToolStripMenuItem")
        lang.SetText(Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Text, "dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem")
        lang.SetText(Me.dontAskBeforeRestartingFirefoxToolStripMenuItem.Text, "dontAskBeforeRestartingFirefoxToolStripMenuItem")
        lang.SetText(Me.screenResolutionToolStripMenuItem.Text, "screenResolutionToolStripMenuItem")
        lang.SetText(Me.askBeforeChangingResolutionToolStripMenuItem.Text, "askBeforeChangingResolutionToolStripMenuItem")
        lang.SetText(Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Text, "confirmSettingsAfterChangingResolutionToolStripMenuItem")
        lang.SetText(Me.runWhenILogInToWindowsToolStripMenuItem.Text, "runWhenILogInToWindowsToolStripMenuItem")
        lang.SetText(Me.customizeDesktopShortcutsToolStripMenuItem.Text, "customizeDesktopShortcutsToolStripMenuItem")
        lang.SetText(Me.reloadProfilesToolStripMenuItem.Text, "reloadProfilesToolStripMenuItem")
        lang.SetText(Me.helpToolStripMenuItem.Text, "helpToolStripMenuItem")
        lang.SetText(Me.netProfilesWebsiteToolStripMenuItem.Text, "netProfilesWebsiteToolStripMenuItem", "%1", ProgramName)
        lang.SetText(Me.checkForUpdatesToolStripMenuItem.Text, "checkForUpdatesToolStripMenuItem")
        lang.SetText(Me.aboutToolStripMenuItem.Text, "aboutToolStripMenuItem")
        lang.SetText(Me.toolStripButtonNewProfile.Text, "toolStripButtonNewProfile")
        lang.SetText(Me.toolStripButtonApplyProfile.Text, "toolStripButtonApplyProfile")
        lang.SetText(Me.toolStripButtonCopyProfile.Text, "toolStripButtonCopyProfile")
        lang.SetText(Me.toolStripButtonEditProfile.Text, "toolStripButtonEditProfile")
        lang.SetText(Me.toolStripButtonDeleteProfile.Text, "toolStripButtonDeleteProfile")
        lang.SetText(Me.StatusLabelWorking, "toolStripStatusLabelWorking")
        lang.SetText(Me.StatusLabelWorking_Preloading, "toolStripStatusLabelWorking-Preloading")
        lang.SetText(Me.StatusLabelWorking_Activating, "toolStripStatusLabelWorking-Activating")
        lang.SetText(Me.StatusLabelWorking_UnmapDrives, "toolStripStatusLabelWorking-UnmapDrives")
        lang.SetText(Me.StatusLabelWorking_MapDrives, "toolStripStatusLabelWorking-MapDrives")
        lang.SetText(Me.StatusLabelWorking_Printer, "toolStripStatusLabelWorking-Printer")
        lang.SetText(Me.StatusLabelWorking_Internet, "toolStripStatusLabelWorking-Internet")
        lang.SetText(Me.StatusLabelWorking_Homepage, "toolStripStatusLabelWorking-Homepage")
        lang.SetText(Me.StatusLabelWorking_Programs, "toolStripStatusLabelWorking-Programs")
        lang.SetText(Me.StatusLabelWorking_Wallpaper, "toolStripStatusLabelWorking-Wallpaper")
        lang.SetText(Me.StatusLabelWorking_Resolution, "toolStripStatusLabelWorking-Resolution")
        lang.SetText(Me.StatusLabelWorking_Reloading, "toolStripStatusLabelWorking-Reloading")
        lang.SetText(Me.StatusLabelWorking_DHCP, "toolStripStatusLabelWorking-DHCP")
        lang.SetText(Me.StatusLabelWorking_IPAddress, "toolStripStatusLabelWorking-IPAddress")
        lang.SetText(Me.applyProfileToolStripMenuItem.Text, "applyProfileToolStripMenuItem")
        lang.SetText(Me.activateOnDifferentNetworkCardToolStripMenuItem.Text, "activateOnDifferentNetworkCardToolStripMenuItem")
        lang.SetText(Me.copyToolStripMenuItem.Text, "copyToolStripMenuItem")
        lang.SetText(Me.editToolStripMenuItem.Text, "editToolStripMenuItem")
        lang.SetText(Me.deleteToolStripMenuItem.Text, "deleteToolStripMenuItem")
        lang.SetText(Me.createDesktopShortcutToolStripMenuItem.Text, "createDesktopShortcutToolStripMenuItem")
        lang.SetText(Me.showHideWindowToolStripMenuItem.Text, "showHideWindowToolStripMenuItem")
        lang.SetText(Me.profilesToolStripMenuItem.Text, "profilesToolStripMenuItem")
        lang.SetText(Me.exitToolStripMenuItem1.Text, "exitToolStripMenuItem1")
        lang.SetText(Me.NoNetworkProfilesMessageBox_1, "NoNetworkProfilesMessageBox-1")
        lang.SetText(Me.NoNetworkProfilesMessageBox_2, "NoNetworkProfilesMessageBox-2")
        lang.SetText(Me.DeleteProfileMessageBox, "DeleteProfileMessageBox")
        lang.SetText(Me.DeleteProfileMessageBox_Title, "DeleteProfileMessageBox-Title")
        lang.SetText(Me.ShortcutConfigDefault, "ShortcutConfigDefault")
        lang.SetText(Me.CreateShortcutMessagebox, "CreateShortcutMessagebox")
        lang.SetText(Me.CheckForUpdates_Latest, "CheckForUpdates-Latest")
        lang.SetText(Me.CheckForUpdates_New_1, "CheckForUpdates-New-1", "%1", ProgramName)
        lang.SetText(Me.CheckForUpdates_New_2, "CheckForUpdates-New-2", "%1", ProgramName)
        lang.SetText(Me.CheckForUpdates_Title, "CheckForUpdates-Title", "%1", ProgramName)
        lang.SetText(Me.CheckForUpdates_Error_1, "CheckForUpdates-Error-1")
        lang.SetText(Me.CheckForUpdates_Error_2, "CheckForUpdates-Error-2")
    End Sub
	
    Sub ToggleToolbarTextToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles toggleToolbarTextToolStripMenuItem.Click
        Dim i As Integer
        For i = 0 To Me.toolStripMain.Items.Count - 1
            If Me.toolStripMain.Items.Item(i).DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText Then
                Me.toolStripMain.Items.Item(i).DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
                INIWrite(Globals.ProgramINIFile, "Program", "ShowToolbarText", "False")
            Else
                Me.toolStripMain.Items.Item(i).DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
                INIWrite(Globals.ProgramINIFile, "Program", "ShowToolbarText", "True")
            End If
        Next
    End Sub
	
	Public Sub GetProfileCategories()
		Me.listViewProfiles.Items.Clear
		Me.listViewProfiles.Groups.Clear()
		Me.profilesToolStripMenuItem.DropDownItems.Clear
		Dim ProfileCategories As New DirectoryInfo(ProfilesFolder)
		Dim Dirs As DirectoryInfo() = ProfileCategories.GetDirectories("*.*")
		Dim DirectoryName As DirectoryInfo
		Dim CategoryMenu As ToolStripMenuItem
		For Each DirectoryName In Dirs
			Try
				Dim NewProfileCategoryName As String = GetStoredInterfaceName(DirectoryName.Name)
				If NewProfileCategoryName.Trim.Length > 0 Then
					Dim ThisInterfaceType As String = GetInterfaceType(DirectoryName.Name)
					Dim NewProfileCategory As New ListViewGroup(NewProfileCategoryName, HorizontalAlignment.Left)
					NewProfileCategory.Name = DirectoryName.Name
					If Me.listViewProfiles.Groups.Count > 0 Then
						For i As Integer = 0 To Me.listViewProfiles.Groups.Count - 1
							If NewProfileCategory.Header < Me.listViewProfiles.Groups.Item(i).Header Then
								Me.listViewProfiles.Groups.Insert(i, NewProfileCategory)
								Exit For
							End If
							If i = Me.listViewProfiles.Groups.Count - 1 Then
								' Add at last position
								Me.listViewProfiles.Groups.Add(NewProfileCategory)
							End If
						Next
					Else
						Me.listViewProfiles.Groups.Add(NewProfileCategory)
					End If
                	If DirectoryName.GetFiles().Length > 0 And (NewProfileCategoryName.Trim <> "Error" Or NewProfileCategoryName.Trim <> "") Then
                		CategoryMenu = DirectCast(Me.profilesToolStripMenuItem.DropDownItems.Add(NewProfileCategoryName), ToolStripMenuItem)
                		If ThisInterfaceType.ToLower.Contains("wlan") Then
                			CategoryMenu.Image = Me.imageListProfiles.Images(1)
                		ElseIf ThisInterfaceType.ToLower.Contains("bluetooth") Then
                			CategoryMenu.Image = Me.imageListProfiles.Images(2)
                		Else
                			CategoryMenu.Image = Me.imageListProfiles.Images(0)
                		End If
                        Call GetProfiles(DirectoryName.FullName, NewProfileCategory, CategoryMenu, ThisInterfaceType)
                	End If
				End If
			Catch E As Exception
			
			End Try
		Next
	End Sub
	
	Public Sub GetProfiles(DirectoryPath as String, GroupName As ListViewGroup, CategoryMenu As ToolStripMenuItem, ThisInterfaceType As String)
		Dim ProfilesPath As New DirectoryInfo(DirectoryPath)
        Dim Files As FileInfo() = ProfilesPath.GetFiles("*.*")
        Dim Filename As FileInfo
        Dim ProfileMenuItem As ToolStripMenuItem

        For Each Filename In Files
            Try
                Dim ThisListItem As ListViewItem
                ThisListItem = Me.listViewProfiles.Items.Add(INIRead(Filename.FullName,"General","Name", "[No Name]"))
                ThisListItem.Group = GroupName
                If Filename.FullName.ToLower = INIRead(Globals.ProgramINIFile,"Program","Last Activated Profile", "").ToLower Then
                	ThisListItem.Font = New System.Drawing.Font(ThisListItem.Font, FontStyle.Bold)
                End If
                If INIRead(Filename.FullName,"TCP/IP Settings","DHCP", "0") = "0" Then
                	ThisListItem.SubItems.Add(INIRead(Filename.FullName,"TCP/IP Settings","IP Address", "0.0.0.0"))
                Else
                	ThisListItem.SubItems.Add("Dynamic IP")
                End If
                ThisListItem.SubItems.Item(1).ForeColor = System.Drawing.Color.Gray
                ThisListItem.SubItems.Add(Filename.Name)
                ThisListItem.SubItems.Add(Filename.FullName)
                
                ProfileMenuItem = DirectCast(CategoryMenu.DropDownItems.Add(INIRead(Filename.FullName, "General", _
                    "Name", "[No Name]")), ToolStripMenuItem)
                ProfileMenuItem.Tag = Filename.FullName
                ProfileMenuItem.ToolTipText = "Activate " & ProfileMenuItem.Text
                AddHandler ProfileMenuItem.Click, AddressOf SystemTrayMenuClick
           
                
                If ThisInterfaceType.ToLower.Contains("wlan") Then
                	ThisListItem.ImageIndex = 1
                	ProfileMenuItem.Image = Me.imageListProfiles.Images(1)
                ElseIf ThisInterfaceType.ToLower.Contains("bluetooth") Then
                	ThisListItem.ImageIndex = 2
                	ProfileMenuItem.Image = Me.imageListProfiles.Images(2)
                Else
                	ThisListItem.ImageIndex = 0
                	ProfileMenuItem.Image = Me.imageListProfiles.Images(0)
                End If
                
                Dim AutoConnectSSID As String = INIRead(Filename.FullName,"Wireless","AutoActivateSSID", "")
                If AutoConnectSSID.Length > 0 Then
                	Globals.AutoConnectSSID.Add(AutoConnectSSID)
                	Globals.AutoConnectProfile.Add(Filename.FullName)
                	Globals.AutoConnectMACAddress.Add(DirectoryPath.Substring(DirectoryPath.LastIndexOf("\")+1, DirectoryPath.Length-DirectoryPath.LastIndexOf("\")-1).Replace("-", ":"))
                End If
                
            Catch E As Exception
                
            End Try
        Next
        Me.listViewProfiles.Sort()

	End Sub
	
	Private Sub SystemTrayMenuClick(sender as Object, e as System.EventArgs)
        Globals.INIAutoLoad = CStr(sender.Tag)
		AutoActivate.Show
	End Sub
	
	Public Function GetInterfaceType(ThisInterface As String) As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapter WHERE MACAddress = '" & ThisInterface.Replace("-",":") & "'") 

			For Each queryObj As ManagementObject in searcher.Get()
                Return CStr(queryObj("ProductName"))
			Next
		Catch err As ManagementException
			Return "Error"
		End Try
		Return ""
	End Function
	
    Sub ToolStripButtonNewProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButtonNewProfile.Click
        CreatingNewProfile = True
        ProfileSettings.ShowDialog()
    End Sub
	
    Sub ToolStripButtonEditProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButtonEditProfile.Click
        Call Me.EditProfile()
    End Sub
	
	Public Sub EditProfile
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			CreatingNewProfile = False
			ProfileSettings.ShowDialog
		End If
	End Sub
	
	Sub TimerUpdateAdaptersTick(ByVal sender As Object, ByVal e As EventArgs) Handles timerUpdateAdapters.Tick
		Me.timerUpdateAdapters.Enabled = False
		Me.toolStripProgressBar1.Enabled = True
		Me.toolStripProgressBar1.Visible = True
		Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking_Preloading
		Me.toolStripStatusLabelWorking.Visible = True
		
		NetworkCardList = PopulateNetworkCardArray()
		RefreshProfiles()
		
		If Me.listViewProfiles.Items.Count = 0 Then
			Dim YNResult As Object
			YNResult = MessageBox.Show(Me.NoNetworkProfilesMessageBox_1 & vbCrLf & Me.NoNetworkProfilesMessageBox_2, ProgramName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If YNResult = DialogResult.Yes Then
				CreatingNewProfile = True
				ProfileSettings.ShowDialog()
			End If
		End If
		
		' Auto activate profile if specified SSID is connected
		GetConnectedSSIDs()
		
		' Handler is called if the system notifies a change of the network address
		AddHandler NetworkChange.NetworkAddressChanged, AddressOf NetworkAddressChanged
		
		' Run the backgroundworker that will prepare the new adapter list on an adress change
		Me.backgroundWorkerScanAdapters.RunWorkerAsync()
	End Sub
	
	Private Sub NetworkAddressChanged(ByVal sender As Object, ByVal e As EventArgs)
		' Runs if the system notifies a change of the network adress
		' This allows to detect changes of adapter connection states
		
		' Inform the backgroundworker about the change
		Me.NetworkAddressChangedQueue.Enqueue(0)
	End Sub
	
	Sub BackgroundWorkerScanAdaptersDoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
		While True
			Try
				' Blocks until an element is available
				Me.NetworkAddressChangedQueue.Dequeue()
			Catch
			End Try
			
			'HACK: WMI seems to deliver old adapter configurations if excuted immediately after the NetworkAddressChanged event
			Threading.Thread.Sleep(1000)
			' Populate the list of the available network adapters using WMI (CPU intensive)
			Dim currentAdapters As ArrayList = PopulateNetworkCardArray()
			
			' Submit the list of network adapters to the progess handler
			Me.backgroundWorkerScanAdapters.ReportProgress(0, currentAdapters)
		End While
	End Sub
	
	Sub BackgroundWorkerScanAdaptersProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
		' Checks the adapter list for changes and updates the profiles list if necessary
		
		Dim currentAdapters As ArrayList = DirectCast(e.UserState, ArrayList)
		Dim changed As Boolean = False
		
		If currentAdapters.Count = NetworkCardList.Count Then
			For i As Integer = 0 To currentAdapters.Count - 1
				If Not (CStr(currentAdapters(i).Key) = CStr(NetworkCardList(i).Key) And CStr(currentAdapters(i).Value) = CStr(NetworkCardList(i).Value)) Then
					changed = True
					Exit For
				End If
			Next
		Else
			changed = True
		End If
		
		If changed Then
			NetworkCardList = currentAdapters
			RefreshProfiles()
		End If
		
		' Auto activate profile if specified SSID is connected
		GetConnectedSSIDs()

	End Sub
	
	Public Sub RefreshProfiles
		If Not Me.ProfileApplyInProgress Then
			Me.toolStripProgressBar1.Enabled = True
			Me.toolStripProgressBar1.Visible = True
			Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking
			Me.toolStripStatusLabelWorking.Visible = True
		End If
		Me.SetProfileOperationsState(False)
		Globals.AutoConnectSSID.Clear
		Globals.AutoConnectProfile.Clear
		Globals.AutoConnectMACAddress.Clear
		Call GetProfileCategories
		If Not Me.ProfileApplyInProgress Then
			Me.toolStripProgressBar1.Visible = False
			Me.toolStripProgressBar1.Enabled = False
			Me.toolStripStatusLabelWorking.Visible = False
		End If
	End Sub
	
    Sub ToolStripButtonDeleteProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButtonDeleteProfile.Click
        Call Me.DeleteProfile()
    End Sub
	
	Public Sub DeleteProfile
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Dim YNResult As Object
			YNResult = MessageBox.Show(Me.DeleteProfileMessageBox.Replace("%1", Me.listViewProfiles.FocusedItem.Text), Me.DeleteProfileMessageBox_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If YNResult = DialogResult.Yes Then
                RemoveProfile(ProfilesFolder & "\" & Me.listViewProfiles.SelectedItems.Item(0).Group.Name.ToString & "\" & Me.listViewProfiles.SelectedItems(0).SubItems(2).Text)
                Call Me.RefreshProfiles()
            Else
                Exit Sub
            End If
		End If		
	End Sub
	
    Sub ContextMenuStripProfilesOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles contextMenuStripProfiles.Opening
        If Me.listViewProfiles.SelectedItems.Count = 0 Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
	
    Sub ApplyProfileToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles applyProfileToolStripMenuItem.Click
        If Me.listViewProfiles.SelectedItems.Count > 0 Then
            Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
        End If
    End Sub
	
    Sub EditToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles editToolStripMenuItem.Click
        Call Me.EditProfile()
    End Sub
	
    Sub DeleteToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles deleteToolStripMenuItem.Click
        Call Me.DeleteProfile()
    End Sub
	
	Public Sub ApplyProfile(ByVal ThisProfile As String, ByVal ApplyType As String, Optional ByVal MACAddress As String = "")
		If Not Me.backgroundWorkerApplyProfile.IsBusy Then
			Me.ProfileApplyInProgress = True
			UpdateProgress(Me.StatusLabelWorking_Activating, ApplyType)
			
			If ApplyType.Equals("normal") Then
				Me.toolStripProgressBar1.Enabled = True
				Me.toolStripProgressBar1.Visible = True
				Me.SetProfileOperationsState(False)
			End If
			
			For i As Integer = 0 To Me.listViewProfiles.Items.Count - 1
				Me.listViewProfiles.Items.Item(i).Font = New System.Drawing.Font(Me.listViewProfiles.Items.Item(i).Font, FontStyle.Regular)
				If Me.listViewProfiles.Items.Item(i).SubItems.Item(3).Text = ThisProfile Then
					Me.listViewProfiles.Items.Item(i).Font = New System.Drawing.Font(Me.listViewProfiles.Items.Item(i).Font, FontStyle.Bold)
					Me.listViewProfiles.Items.Item(i).SubItems.Item(1).Font = New System.Drawing.Font(Me.listViewProfiles.Items.Item(i).Font, FontStyle.Regular)
				End If
			Next
			
			INIWrite(Globals.ProgramINIFile, "Program", "Last Activated Profile", ThisProfile)
			
			backgroundWorkerApplyProfile.RunWorkerAsync(New String() {ThisProfile, MACAddress, ApplyType})
		End If
	End Sub
	
	Sub BackgroundWorkerApplyProfileDoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
		Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
		Dim ThisProfile As String = DirectCast(e.Argument(0), String)
		Dim MACAddress As String = DirectCast(e.Argument(1), String)
		Dim ApplyType As String = DirectCast(e.Argument(2), String)
		
		'*** START SAVE TCP/IP SETTINGS ***
		'HACK: The profiles folder path prefix is removed here before sending the profile to the service.
		'      Maybe all functions dealing with profiles should be updated to use partial paths.
		Dim strIPAddress As String = INIRead(ThisProfile, "TCP/IP Settings", "IP Address", "")
		Dim strSubnetMask As String = INIRead(ThisProfile, "TCP/IP Settings", "Subnet Mask", "")
		Dim strDHCP As String = INIRead(ThisProfile, "TCP/IP Settings", "DHCP", "0")
		
		' Only apply TCP/IP settings if IP and netmask are set or DHCP is enabled
		If ((strIPAddress <> "") And (strSubnetMask <> "")) Or (strDHCP = "1") Then
			If strDHCP = "1" Then
				' Allow to exit the program while waiting for possible timeout for DHCP renew
				backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_DHCP, ApplyType, "ExitAnyway"})
			Else
				backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_IPAddress, ApplyType})
			End If
			Dim Profile As String = ThisProfile.Substring(ProfilesFolder.Length)
			Dim clientConnection As IInterProcessConnection = Nothing
			Try
				clientConnection = New ClientPipeConnection("NetProfilesMod", ".")
				clientConnection.Connect()
				clientConnection.Write(Profile + "|" + MACAddress)
				Dim status As String = clientConnection.Read()
				clientConnection.Close()
				If Not status.Equals("OK") Then
					ShowException(status, "Service Exception")
				End If
			Catch ex As Exception
				ShowException(ex.ToString(), "Named Pipe Client Exception")
				clientConnection.Dispose()
			End Try
		End If
		
		If worker.CancellationPending Then
			e.Cancel = True
			Exit Sub
		End If
		'*** END SAVE TCP/IP SETTINGS ***
		
		'*** START DISCONNECT PREVIOUSLY MAPPED DRIVES ***
		backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_UnmapDrives, ApplyType})
		Dim DisconnectTheseDrives() As String
		DisconnectTheseDrives = INIRead(Globals.ProgramINIFile, "Options", "Mapped Drives", "").Split(System.Convert.ToChar("|"))
		Dim TheDrive As Object
		For TheDrive = DisconnectTheseDrives.GetLowerBound(0) To DisconnectTheseDrives.GetUpperBound(0)
			DisconnectNetworkDrive(DisconnectTheseDrives(System.Convert.ToInt16(TheDrive)), True)
		Next TheDrive
		
		If worker.CancellationPending Then
			INIWrite(Globals.ProgramINIFile, "Options", "Mapped Drives", "")
			e.Cancel = True
			Exit Sub
		End If
		'*** END DISCONNECT PREVIOUSLY MAPPED DRIVES ***
		
		'*** START MAP NEW DRIVES ***
		' Allow to exit the program while waiting for possible timeout for connecting mapped drive
		backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_MapDrives, ApplyType, "ExitAnyway"})
		Dim CurrentlyMappedDrives As String = ""
		Dim iniText As String
		Dim iniArray() As String
		iniText = INIRead(ThisProfile, "Mapped Drives")
		iniText = iniText.Replace(ControlChars.NullChar, "|")
		iniText = Trim(iniText)
		iniArray = iniText.Split(System.Convert.ToChar("|"))
		Dim iniArray2() As String
		Dim X As Integer
		For X = iniArray.GetLowerBound(0) To (iniArray.GetUpperBound(0) - 1)
			iniArray2 = INIRead(ThisProfile, "Mapped Drives", iniArray(X), "").Split(System.Convert.ToChar("|"))
			ConnectThisNetworkDrive(iniArray2(0), iniArray(X), SubstitutionDecode(iniArray2(1)), SubstitutionDecode(iniArray2(2)))
			CurrentlyMappedDrives = CurrentlyMappedDrives & "|" & iniArray(X)
			
			If worker.CancellationPending Then
				INIWrite(Globals.ProgramINIFile, "Options", "Mapped Drives", CurrentlyMappedDrives.Substring(1, CurrentlyMappedDrives.Length - 1))
				e.Cancel = True
				Exit Sub
			End If
		Next X
		If CurrentlyMappedDrives.Length > 1 Then
			INIWrite(Globals.ProgramINIFile, "Options", "Mapped Drives", CurrentlyMappedDrives.Substring(1, CurrentlyMappedDrives.Length - 1))
		Else
			INIWrite(Globals.ProgramINIFile, "Options", "Mapped Drives", "")
		End If
		
		If worker.CancellationPending Then
			e.Cancel = True
			Exit Sub
		End If
		'*** END MAP NEW DRIVES ***
		
		'*** START SETTING DEFAULT PRINTER ***
		Dim NewDefaultPrinter As String = INIRead(ThisProfile, "Printer", "Default", "")
		If NewDefaultPrinter.Length > 0 Then
			backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_Printer, ApplyType})
			Call SetDefaultPrinter(NewDefaultPrinter)
		End If
		
		If worker.CancellationPending Then
			e.Cancel = True
			Exit Sub
		End If
		'*** END SETTING DEFAULT PRINTER ***
		
		'*** START INTERNET SETTINGS ***
		backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_Internet, ApplyType})
		Dim strAutoConfigAddress As String = INIRead(ThisProfile, "Internet Settings", "AutoConfigAddress", "")
		Dim strUseProxySettings As String = INIRead(ThisProfile, "Internet Settings", "UseProxySettings", "0")
		Dim boolUseProxySettings As Boolean
		If strUseProxySettings.Equals("0") Then boolUseProxySettings = False
		If strUseProxySettings.Equals("1") Then boolUseProxySettings = True
		Dim strProxyServerAddress As String = INIRead(ThisProfile, "Internet Settings", "ProxyServerAddress", "")
		Dim strProxyExceptions As String = INIRead(ThisProfile, "Internet Settings", "ProxyExceptions", "")
		Dim boolProxyBypass As Boolean = Convert.ToBoolean(INIRead(ThisProfile, "Internet Settings", "ProxyBypass", Convert.ToString(False)))
		Dim boolProxyIE As Boolean = Convert.ToBoolean(INIRead(ThisProfile, "Internet Settings", "InternetExplorer", Convert.ToString(False)))
		Dim boolProxyFirefox As Boolean = Convert.ToBoolean(INIRead(ThisProfile, "Internet Settings", "Firefox", Convert.ToString(False)))
		Dim strDefaultHomepage As String = INIRead(ThisProfile, "Internet Settings", "DefaultHomepage", "")
		
		Dim FFSettings As FirefoxSettings = Nothing
		If boolProxyFirefox Then
			FFSettings = New FirefoxSettings
		End If
		
		Dim regKey As RegistryKey
		regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings\", True)
		Dim ProxyGlobal As String = ""
		Dim ProxyGlobalPort As String = ""
		Dim ProxyHttp As String = ""
		Dim ProxyHttpPort As String = ""
		Dim ProxyHttps As String = ""
		Dim ProxyHttpsPort As String = ""
		Dim ProxyFtp As String = ""
		Dim ProxyFtpPort As String = ""
		Dim ProxySocks As String = ""
		Dim ProxySocksPort As String = ""
		Dim ProxyGopher As String = ""
		Dim ProxyGopherPort As String = ""
		
		If boolUseProxySettings.Equals(True) Then
			If strProxyServerAddress.Length > 0 Then
				'Server address specified: set proxy
				If Not (strProxyServerAddress.Contains("=")) Then
					If strProxyServerAddress.Contains(":") Then
						ProxyGlobal = Split(strProxyServerAddress, ":")(0)
						ProxyGlobalPort = Split(strProxyServerAddress, ":")(1)
						If ProxyGlobalPort.Length = 0 Then
							ProxyGlobalPort = "80"
						End If
					Else
						ProxyGlobal = strProxyServerAddress
						ProxyGlobalPort = "80"
					End If
				Else
					Dim ArrProxyServers() As String = Split(strProxyServerAddress, ";")
					For Each ProxyProtocol As String In ArrProxyServers
						ProcessProxySettings(ProxyProtocol, "http", ProxyHttp, ProxyHttpPort)
						ProcessProxySettings(ProxyProtocol, "https", ProxyHttps, ProxyHttpsPort)
						ProcessProxySettings(ProxyProtocol, "ftp", ProxyFtp, ProxyFtpPort)
						ProcessProxySettings(ProxyProtocol, "socks", ProxySocks, ProxySocksPort)
						ProcessProxySettings(ProxyProtocol, "gopher", ProxyGopher, ProxyGopherPort)
					Next
					If ProxyHttp <> "" And ProxyHttpPort = "" Then
						ProxyHttpPort = "80"
					End If
					If ProxyHttps <> "" And ProxyHttpsPort = "" Then
						ProxyHttpsPort = "443"
					End If
					If ProxyFtp <> "" And ProxyFtpPort = "" Then
						ProxyFtpPort = "21"
					End If
					If ProxySocks <> "" And ProxySocksPort = "" Then
						ProxySocksPort = "0"
					End If
					If ProxyGopher <> "" And ProxyGopherPort = "" Then
						ProxyGopherPort = "0"
					End If
				End If
				If boolProxyIE.Equals(True) Then
					regKey.SetValue("ProxyEnable", 1)
					If ProxyGlobal <> "" Then
						regKey.SetValue("ProxyServer", ProxyGlobal & ":" & ProxyGlobalPort)
					Else
						Dim ProxyReg As String = ""
						If ProxyHttp <> "" Then
							ProxyReg = "http=" & ProxyHttp & ":" & ProxyHttpPort
						End If
						If ProxyHttps <> "" Then
							If ProxyReg <> "" Then
								ProxyReg = ProxyReg & ";"
							End If
							ProxyReg = ProxyReg & "https=" & ProxyHttps & ":" & ProxyHttpsPort
						End If
						If ProxyFtp <> "" Then
							If ProxyReg <> "" Then
								ProxyReg = ProxyReg & ";"
							End If
							ProxyReg = ProxyReg & "ftp=" & ProxyFtp & ":" & ProxyFtpPort
						End If
						If ProxySocks <> "" Then
							If ProxyReg <> "" Then
								ProxyReg = ProxyReg & ";"
							End If
							ProxyReg = ProxyReg & "socks=" & ProxySocks & ":" & ProxySocksPort
						End If
						regKey.SetValue("ProxyServer", ProxyReg)
					End If
					If boolProxyBypass.Equals(True) Then
						If strProxyExceptions.Length > 0 Then
							regKey.SetValue("ProxyOverride", strProxyExceptions & ";<local>")
						Else
							regKey.SetValue("ProxyOverride", "<local>")
						End If
					Else
						If strProxyExceptions.Length > 0 Then
							regKey.SetValue("ProxyOverride", strProxyExceptions)
						Else
							Try
								regKey.DeleteValue("ProxyOverride")
							Catch
								'Ignore the exception in case the key already didn't exist
							End Try
						End If
					End If
				End If
				If boolProxyFirefox.Equals(True) Then
					Dim ProxyExceptions() As String = {}
					If strProxyExceptions <> "" Then
						ProxyExceptions = strProxyExceptions.Split(";"C)
						For i As Integer = 0 To ProxyExceptions.Length - 1
							'Remove leading asterisk from proxy exceptions for Firefox
							If ProxyExceptions(i).Substring(0, 1) = "*" Then
								ProxyExceptions(i) = ProxyExceptions(i).Substring(1)
							End If
							If ProxyExceptions(i).Substring(ProxyExceptions(i).Length - 1) = "*" Then
								'Remove trailing asterisk from proxy exceptions for Firefox
								ProxyExceptions(i) = ProxyExceptions(i).Substring(0, ProxyExceptions(i).Length - 1)
								
								'Convert IP ranges from IE format with wildcards to Firefox format with netmask (192.168.* -> 192.168.0.0/16)
								Dim pattern8 As String = "^\d{1,3}\.\z"
								Dim pattern16 As String = "^\d{1,3}\.\d{1,3}\.\z"
								Dim pattern24 As String = "^\d{1,3}\.\d{1,3}\.\d{1,3}\.\z"
								If System.Text.RegularExpressions.Regex.Match(ProxyExceptions(i), pattern8).Success Then
									ProxyExceptions(i) = ProxyExceptions(i) & "0.0.0/8"
								ElseIf System.Text.RegularExpressions.Regex.Match(ProxyExceptions(i), pattern16).Success Then
									ProxyExceptions(i) = ProxyExceptions(i) & "0.0/16"
								ElseIf System.Text.RegularExpressions.Regex.Match(ProxyExceptions(i), pattern24).Success Then
									ProxyExceptions(i) = ProxyExceptions(i) & "0/24"
								End If
								'Dim m As Boolean = System.Text.RegularExpressions.Regex.Match(ProxyExceptions(i), "\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b").Success
							End If
						Next i
					End If
					FFSettings.SetProxySettings(ProxyGlobal, ProxyGlobalPort, ProxyHttp, ProxyHttpPort, ProxyHttps, ProxyHttpsPort, ProxyFtp, ProxyFtpPort, ProxySocks, ProxySocksPort, ProxyGopher, ProxyGopher, ProxyExceptions, boolProxyBypass)
				End If
			Else
				'Empty server address: clear proxy
				If boolProxyIE.Equals(True) Then
					regKey.SetValue("ProxyEnable", 0)
					regKey.DeleteValue("ProxyServer", False)
					regKey.DeleteValue("ProxyOverride", False)
				End If
				If boolProxyFirefox.Equals(True) Then
					FFSettings.SetProxySettings("", "", "", "", "", "", "", "", "", "", "", "", New String() {}, True)
				End If
			End If
		End If
		
		If boolProxyIE.Equals(True) Then
			If strAutoConfigAddress.Length > 0 Then
				regKey.SetValue("AutoConfigURL", strAutoConfigAddress)
			Else
				regKey.DeleteValue("AutoConfigURL", False)
			End If
		End If
		If boolProxyFirefox.Equals(True) Then
			FFSettings.ChangeSetting("network.proxy.autoconfig_url", strAutoConfigAddress)
			If Not boolUseProxySettings Then
				FFSettings.ChangeSetting("network.proxy.type", 2)
			End If
		End If
		
		If strDefaultHomepage.Trim.Length > 0 Then
			If boolProxyIE.Equals(True) Then
				SetHomepage(strDefaultHomepage)
			End If
			If boolProxyFirefox.Equals(True) Then
				FFSettings.ChangeSetting("browser.startup.homepage", strDefaultHomepage)
			End If
		End If
		
		If boolProxyFirefox Then
			FFSettings.Apply(Me.dontAskBeforeRestartingFirefoxToolStripMenuItem.Checked)
		End If
		
		If worker.CancellationPending Then
			e.Cancel = True
			Exit Sub
		End If
		'*** END INTERNET SETTINGS ***
		
		'*** START RUNNING PROGRAMS ***
		backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_Programs, ApplyType})
		Dim iniRunText As String
		Dim iniRunArray() As String
		iniRunText = INIRead(ThisProfile, "Run")
		iniRunText = iniRunText.Replace(ControlChars.NullChar, "|")
		iniRunText = Trim(iniRunText)
		iniRunArray = iniRunText.Split(System.Convert.ToChar("|"))
		Dim iniRunArray2() As String
		Dim XRun As Integer
		For XRun = iniRunArray.GetLowerBound(0) To (iniRunArray.GetUpperBound(0) - 1)
			'TODO: Replace Microsoft.VisualBasic
			iniRunArray2 = Microsoft.VisualBasic.Strings.Split(INIRead(ThisProfile, "Run", iniRunArray(XRun), ""), "||")
			Dim ThisProgram As System.Diagnostics.Process = New System.Diagnostics.Process()
			ThisProgram.StartInfo.FileName = iniRunArray2(0)
			ThisProgram.StartInfo.WorkingDirectory = Path.GetDirectoryName(ThisProgram.StartInfo.FileName)
			If iniRunArray2(2).Length > 0 Then
				Select Case iniRunArray2(2)
					Case "Normal"
						ThisProgram.StartInfo.WindowStyle = ProcessWindowStyle.Normal
					Case "Minimized"
						ThisProgram.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
					Case "Maximized"
						ThisProgram.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
					Case "Hidden"
						ThisProgram.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
				End Select
			End If
			If iniRunArray2(1).Length > 0 Then
				ThisProgram.StartInfo.Arguments = iniRunArray2(1)
			End If
			If iniRunArray2(3).Length > 0 Then
				ThisProgram.StartInfo.UserName = SubstitutionDecode(iniRunArray2(3))
				If iniRunArray2(4).Length > 0 Then
					Dim pw As New System.Security.SecureString
					For Each ch As Char In SubstitutionDecode(iniRunArray2(4))
						pw.AppendChar(ch)
					Next
					ThisProgram.StartInfo.Password = pw
				End If
			End If
			If iniRunArray2(5).Length > 0 Then
				ThisProgram.StartInfo.Domain = SubstitutionDecode(iniRunArray2(5))
			End If
			If ThisProgram.StartInfo.UserName = "" Then
				ThisProgram.StartInfo.UseShellExecute = True
			Else
				'The Process must have UseShellExecute set to false to start as a user, Minimized/Maximized/Hidden will have no effect
				ThisProgram.StartInfo.UseShellExecute = False
			End If
			Try
				ThisProgram.Start()
			Catch ex As Exception
				MessageBox.Show(ex.Message, ThisProgram.StartInfo.FileName, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		
			If worker.CancellationPending Then
				e.Cancel = True
				Exit Sub
			End If
		Next XRun
		'*** END RUNNING PROGRAMS ***
		
		'*** APPLY WALLPAPER ***
		Dim NewWallpaper As String = INIRead(ThisProfile, "Desktop", "Wallpaper", "")
		If NewWallpaper.Length > 0 Then
			If System.IO.File.Exists(NewWallpaper) Then
				backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_Wallpaper, ApplyType})
				Call SetWallpaper(NewWallpaper)
			End If
		End If
		
		If worker.CancellationPending Then
			e.Cancel = True
			Exit Sub
		End If
		'*** END APPLY WALLPAPER ***
		
		'*** START DISPLAY SETTINGS ***
		Me.messageBoxManager1.HookEnabled = True
		Dim newResolution As Integer() = Nothing
		Dim resolutionSeparator() As String = {String.Format(ResolutionFormatter, "", "")}
		Try
			Dim profileResolution As String() = INIRead(ThisProfile, "Desktop", "ScreenResolution", "").Split(resolutionSeparator, StringSplitOptions.None)
			newResolution = New Integer() {Convert.ToInt32(profileResolution(0)), Convert.ToInt32(profileResolution(1))}
		Catch
		End Try
		
		If Not IsNothing(newResolution) Then
			backgroundWorkerApplyProfile.ReportProgress(0, New String() {Me.StatusLabelWorking_Resolution, ApplyType})
			'Prompt for Confirmation (ConfirmPrompt)
			Dim changeResolution As System.Windows.Forms.DialogResult
			If Me.askBeforeChangingResolutionToolStripMenuItem.Checked Then
				Dim lang As SetLanguage = New SetLanguage("/Language/Misc/")
				
				Dim ConfirmPromptTitle As String = lang.GetText("DisplaySettings-ConfirmPrompt-Title", "Confirm Display Change")
				Dim ConfirmPromptMessage As String = lang.GetText("DisplaySettings-ConfirmPrompt-Message", "Would you like to change your display settings?")
				Dim ResolutionText As String = lang.GetText("DisplaySettings-Resolution", "Resolution:")
				
				'Confirm Prompt: Returns Yes/No (DialogResult)
				Dim strMessage As String
				strMessage = ConfirmPromptMessage & vbCrLf
				strMessage += vbCrLf & ResolutionText & " " & ResolutionFormatter
				strMessage = String.Format(strMessage, newResolution(0), newResolution(1))
				changeResolution = MessageBox.Show(strMessage, ConfirmPromptTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
			Else
				changeResolution = System.Windows.Forms.DialogResult.Yes
			End If
			
			If changeResolution = System.Windows.Forms.DialogResult.Yes Then
				Dim currentSettings As Integer() = cScreen.GetCurrentSettings()
				
				' Change resolution
				cScreen.SetDisplay(newResolution(0), newResolution(1))
				
				If Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked Then
					Dim lang As SetLanguage = New SetLanguage("/Language/Misc/")
					
					Dim RevertPromptTitle As String = lang.GetText("DisplaySettings-RevertPrompt-Title", "Display Changed")
					Dim RevertPromptMessage As String = lang.GetText("DisplaySettings-RevertPrompt-Message", "Would you like to keep your current settings?")
					Dim ResolutionText As String = lang.GetText("DisplaySettings-Resolution", "Resolution:")
					Dim BitsText As String = lang.GetText("DisplaySettings-Bits", "Color Bits:")
					Dim RefreshText As String = lang.GetText("DisplaySettings-Refresh", "Refresh:")
					
					'Revert Prompt: Returns Yes/No (DialogResult)
					Dim strMessage As String
					strMessage = RevertPromptMessage & vbCrLf
					strMessage += vbCrLf & ResolutionText & " " & ResolutionFormatter
					strMessage = String.Format(strMessage, newResolution(0), newResolution(1))
					If MessageBox.Show(strMessage, RevertPromptTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
						cScreen.SetDisplay(currentSettings(0), currentSettings(1), currentSettings(2), currentSettings(3))
					End If
				End If
			End If
		End If
		'*** END DISPLAY SETTINGS ***
		
		' Disable countdown for message boxes
		Me.messageBoxManager1.HookEnabled = False
		
		' Remember the mode for worker completed handler
		e.Result = ApplyType
	End Sub
	
	Sub BackgroundWorkerApplyProfileProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
		UpdateProgress(e.UserState(0).ToString(), e.UserState(1).ToString())
		Try
			Me.specialExitPermission = e.UserState(2).ToString()
		Catch
			Me.specialExitPermission = ""
		End Try
	End Sub
	
	Sub BackgroundWorkerApplyProfileRunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
		Me.specialExitPermission = ""
		If e.Cancelled Then
			Me.Close()
		Else
			Dim applyType As String = e.Result.ToString
			If applyType = "normal" Then
				Me.toolStripProgressBar1.Visible = False
				Me.toolStripProgressBar1.Enabled = False
				Me.toolStripStatusLabelWorking.Visible = False
				Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking
				Me.ProfileApplyInProgress = False
				If Me.listViewProfiles.SelectedItems.Count > 0 Then
					Me.SetProfileOperationsState(True)
				Else
					Me.SetProfileOperationsState(False)
				End If
			ElseIf applyType = "auto" Then
				Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
				If CommandLineArgs.Count > 0 Then
					' Exit after automatic profile application
					Me.Close()
				End If
			End If
		End If
	End Sub
	
    Sub ToolStripButtonApplyProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButtonApplyProfile.Click
        If Me.listViewProfiles.SelectedItems.Count > 0 Then
            Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
        End If
    End Sub
	
    Sub ToolStripMenuItemNewProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemNewProfile.Click
        CreatingNewProfile = True
        ProfileSettings.ShowDialog()
    End Sub
	
    Sub ToolStripMenuItemEditProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemEditProfile.Click
        Call Me.EditProfile()
    End Sub
	
    Sub DeleteToolStripMenuItemDeleteProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles deleteToolStripMenuItemDeleteProfile.Click
        Call Me.DeleteProfile()
    End Sub
	
    Sub ApplyProfileToolStripMenuItemApplyProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles applyProfileToolStripMenuItemApplyProfile.Click
        If Me.listViewProfiles.SelectedItems.Count > 0 Then
            Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
        End If
    End Sub
	
    Sub ExitToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
        Globals.OKToCloseProgram = True
        Me.Close()
    End Sub
	
	Sub MainFormFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
		If e.CloseReason = System.Windows.Forms.CloseReason.UserClosing Then
			If Not Globals.OKToCloseProgram Then
				' Minimize to tray
				Me.ToggleProgramVisibility()
				e.Cancel = True
			End If
		End If
		If Me.Visible And Not Me.WindowState = FormWindowState.Minimized Then
			INIWrite(Globals.ProgramINIFile, "Program", "LocationTop", Me.Top.ToString)
			INIWrite(Globals.ProgramINIFile, "Program", "LocationLeft", Me.Left.ToString)
			INIWrite(Globals.ProgramINIFile, "Program", "WindowWidth", Me.Width.ToString)
			INIWrite(Globals.ProgramINIFile, "Program", "WindowHeight", Me.Height.ToString)
		End If
		If backgroundWorkerApplyProfile.IsBusy And Globals.OKToCloseProgram Then
			backgroundWorkerApplyProfile.CancelAsync()
			If Not Me.specialExitPermission = "ExitAnyway" Then
				' The worker completed handler will call close again when a clean exit is possible
				e.Cancel = True
			End If
		End If
	End Sub
	
	Sub ExitToolStripMenuItem1Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem1.Click
		Globals.OKToCloseProgram = True
		Me.Close()
	End Sub
	
    Sub ShowHideWindowToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles showHideWindowToolStripMenuItem.Click
        Call Me.ToggleProgramVisibility()
    End Sub
	
    Sub MinimizeToTrayOnCloseToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles minimizeToTrayOnCloseToolStripMenuItem.Click
        If Me.minimizeToTrayOnCloseToolStripMenuItem.Checked.Equals(True) Then
            INIWrite(Globals.ProgramINIFile, "Program", "MinimizeToTray", "True")
            Globals.OKToCloseProgram = False
        Else
            INIWrite(Globals.ProgramINIFile, "Program", "MinimizeToTray", "False")
            Globals.OKToCloseProgram = True
        End If
    End Sub
	
    Sub NotifyIcon1DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles notifyIcon1.DoubleClick
        Call Me.ToggleProgramVisibility()
    End Sub
	
	Public Sub ToggleProgramVisibility
		If Me.ShowInTaskbar.Equals(False) Then
			INIWrite(Globals.ProgramINIFile, "Program", "LocationTop", Me.Top.ToString)
			INIWrite(Globals.ProgramINIFile, "Program", "LocationLeft", Me.Left.ToString)
			Me.ShowInTaskbar = True
			Me.Visible = True
			Me.WindowState = FormWindowState.Normal
		Else
			If Me.Visible.Equals(True) Then
				INIWrite(Globals.ProgramINIFile, "Program", "LocationTop", Me.Top.ToString)
				INIWrite(Globals.ProgramINIFile, "Program", "LocationLeft", Me.Left.ToString)
				Me.WindowState = FormWindowState.Minimized
				Me.Visible = False
				Me.ShowInTaskbar = True
			Else
				Me.ShowInTaskbar = True
				Me.Visible = True
				Me.WindowState = FormWindowState.Normal
			End If
		End If
			
	End Sub
	
	Sub SetProfileOperationsState(Enabled As Boolean)
		Dim state As Boolean = Enabled And Not Me.ProfileApplyInProgress
		Me.toolStripMenuItemEditProfile.Enabled = state
		Me.deleteToolStripMenuItemDeleteProfile.Enabled = state
		Me.applyProfileToolStripMenuItemApplyProfile.Enabled = state
		Me.createDesktopShortcutToolStripMenuItem1.Enabled = state
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Enabled = state
		Me.toolStripMenuItemCopyProfile.Enabled = state
		
		Me.toolStripButtonApplyProfile.Enabled = state
		Me.toolStripButtonEditProfile.Enabled = state
		Me.toolStripButtonDeleteProfile.Enabled = state
		Me.toolStripButtonCopyProfile.Enabled = state
	End Sub
	
	Sub CreateDesktopShortcut
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Dim ShortcutConfig As String = INIRead(ProgramINIFile,"General","DesktopShortcutConfig", "")
			If ShortcutConfig.Trim.Length = 0 Then
				ShortcutConfig = "Activate %2 on %1"
			End If
			Dim ProfileName As String = Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(0).Text
			Dim InterfaceName As String = Me.listViewProfiles.SelectedItems.Item(0).Group.ToString
			Dim IPAddress As String = Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(1).Text
			Dim MACAddress As String = Me.listViewProfiles.SelectedItems.Item(0).Group.Name.ToString
			
			ShortcutConfig = ShortcutConfig.Replace("%1", InterfaceName)
			ShortcutConfig = ShortcutConfig.Replace("%2", ProfileName)
			ShortcutConfig = ShortcutConfig.Replace("%3", IPAddress)
			ShortcutConfig = ShortcutConfig.Replace("%4", MACAddress)
			
			CreateShortcut(ShortcutConfig, My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe", "auto|" & Me.listViewProfiles.SelectedItems.Item(0).Group.Name & "|" & Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(2).Text,,,)
			MessageBox.Show(Me.CreateShortcutMessagebox, ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub
	
    Sub CreateDesktopShortcutToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles createDesktopShortcutToolStripMenuItem.Click
        Call CreateDesktopShortcut()
    End Sub
	
    Sub CustomizeDesktopShortcutsToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles customizeDesktopShortcutsToolStripMenuItem.Click
        DesktopShortcut.ShowDialog()
    End Sub
	
    Sub ReloadProfilesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles reloadProfilesToolStripMenuItem.Click
        Call RefreshProfiles()
    End Sub
	
    Sub CreateDesktopShortcutToolStripMenuItem1Click(ByVal sender As Object, ByVal e As EventArgs) Handles createDesktopShortcutToolStripMenuItem1.Click
        Call CreateDesktopShortcut()
    End Sub
	
	Sub ToolStripButtonCreateDesktopShortcutClick(ByVal sender As Object, ByVal e As EventArgs)
		Call CreateDesktopShortcut
	End Sub
	
    Sub ActivateOnDifferentNetworkCardToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles activateOnDifferentNetworkCardToolStripMenuItem.Click
        ActivateSelectNetworkCard.ShowDialog()
    End Sub
	
    Sub ActivateOnDifferentNetworkCardToolStripMenuItem1Click(ByVal sender As Object, ByVal e As EventArgs) Handles activateOnDifferentNetworkCardToolStripMenuItem1.Click
        ActivateSelectNetworkCard.ShowDialog()
    End Sub
	
    Sub AskBeforeChangingResolutionToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles askBeforeChangingResolutionToolStripMenuItem.Click
        INIWrite(Globals.ProgramINIFile, "Program", "AskBeforeChangingResolution", Me.askBeforeChangingResolutionToolStripMenuItem.Checked.ToString)
    End Sub
	
    Sub ConfirmSettingsAfterChangingResolutionToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles confirmSettingsAfterChangingResolutionToolStripMenuItem.Click
        INIWrite(Globals.ProgramINIFile, "Program", "AskAfterChangingResolution", Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked.ToString)
    End Sub
	
    Sub MinimizeToTrayOnStartupToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles minimizeToTrayOnStartupToolStripMenuItem.Click
        INIWrite(Globals.ProgramINIFile, "Program", "ToTrayOnStartup", Me.minimizeToTrayOnStartupToolStripMenuItem.Checked.ToString)
    End Sub
	
    Sub DontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Click
        INIWrite(Globals.ProgramINIFile, "Program", "DoNotConfirmAutoActivate", Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Checked.ToString)
    End Sub
	
    Sub DontAskBeforeRestartingFirefoxToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles dontAskBeforeRestartingFirefoxToolStripMenuItem.Click
        INIWrite(Globals.ProgramINIFile, "Program", "DoNotConfirmAutoRestartFirefox", Me.dontAskBeforeRestartingFirefoxToolStripMenuItem.Checked.ToString)
    End Sub
    
    Sub RunWhenILogInToWindowsToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles runWhenILogInToWindowsToolStripMenuItem.Click
        If Me.runWhenILogInToWindowsToolStripMenuItem.Checked.Equals(True) Then
            Call SetRegistryKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", ProgramName, Chr(34) & Application.ExecutablePath & Chr(34))
        Else
            Call DeleteRegistryKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", ProgramName)
        End If
    End Sub
	
    Sub AboutToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
	
    Sub ListViewProfilesDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles listViewProfiles.DoubleClick
        If Me.listViewProfiles.SelectedItems.Count > 0 Then
            Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
        End If
    End Sub
	
	Sub ListViewProfilesItemSelectionChanged(ByVal sender As Object, ByVal e As ListViewItemSelectionChangedEventArgs) Handles listViewProfiles.ItemSelectionChanged
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Me.SetProfileOperationsState(True)
		Else
			Me.SetProfileOperationsState(False)
		End If
	End Sub
	
    Sub CheckForUpdatesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkForUpdatesToolStripMenuItem.Click
        Application.DoEvents()
        Try
            const markBegin As String = "%%___"
            const markEnd As String = "___%%"
            Dim wrq As WebRequest = WebRequest.Create("https://raw.githubusercontent.com/netprofilesmod/netprofilesmod/meta/latestversion.md")
            Dim wrp As WebResponse = wrq.GetResponse()
            Application.DoEvents()
            Dim sr As StreamReader = New StreamReader(wrp.GetResponseStream())
            Application.DoEvents()
            Dim wikiLatestversion As String = sr.ReadToEnd()
            Dim currentVersion As String = wikiLatestversion.Substring(wikiLatestversion.IndexOf(markBegin) + markBegin.Length, wikiLatestversion.IndexOf(markEnd) - wikiLatestversion.IndexOf(markBegin) - markBegin.Length)
            If currentVersion.Trim = ProgramVersion Then
                MessageBox.Show(Me.CheckForUpdates_Latest, ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim YNResult As Object
                YNResult = MessageBox.Show(Me.CheckForUpdates_New_1.Replace("%2", currentVersion.Trim) & vbCrLf & Me.CheckForUpdates_New_2, Me.CheckForUpdates_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If YNResult = DialogResult.Yes Then
                    Application.DoEvents()
                    Start("https://github.com/netprofilesmod/netprofilesmod/releases/latest")
                End If
            End If
        Catch
            MessageBox.Show(Me.CheckForUpdates_Error_1 & vbCrLf & Me.CheckForUpdates_Error_2, ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
	
    Sub CopyToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
        CopyProfile.ShowDialog()
    End Sub
	
    Sub toolStripMenuItemCopyProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItemCopyProfile.Click
        CopyProfile.ShowDialog()
    End Sub
	
    Sub ToolStripButtonCopyProfileClick(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButtonCopyProfile.Click
        CopyProfile.ShowDialog()
    End Sub
	
    Sub NetProfilesWebsiteToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles netProfilesWebsiteToolStripMenuItem.Click
        Start("https://github.com/netprofilesmod/netprofilesmod")
    End Sub
End Class
