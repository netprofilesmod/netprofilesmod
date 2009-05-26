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
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
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
	
	Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs)
		Globals.CurrentLangPath = My.Application.Info.DirectoryPath & "\lang\" & INIRead(Globals.ProgramINIFile, "Program", "Language", "en-US.xml")
		Globals.CurrentLang = INIRead(Globals.ProgramINIFile, "Program", "Language", "en-US.xml")
		Globals.CurrentLang = Globals.CurrentLang.Substring(0, Globals.CurrentLang.Length - 4)
		Call LoadLanguage

		If Microsoft.VisualBasic.Command.Length > 0 Then
			commandArray = Microsoft.VisualBasic.Command.Split("|")
			Select Case commandArray(0)
				Case "auto"
					Globals.EnableLoadTimer = False
					Me.notifyIcon1.Visible = False
					Me.Visible = False
					AutoActivate.ShowDialog
			End Select
		End If
		If Dir(My.Application.Info.DirectoryPath & "\profiles", FileAttribute.Directory) = "" Then
			MkDir((My.Application.Info.DirectoryPath & "\profiles"))
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
			Me.Location = new System.Drawing.Point(CInt(LocationLeft), CInt(LocationTop))
		End If
		Dim WindowWidth As String = INIRead(Globals.ProgramINIFile, "Program", "WindowWidth", "")
		Dim WindowHeight As String = INIRead(Globals.ProgramINIFile, "Program", "WindowHeight", "")
		If WindowWidth.Length > 0 And WindowHeight.Length > 0 Then
			Me.Size = new Size(CInt(WindowWidth), CInt(WindowHeight))
		End If
		Dim AskBeforeChangingResolution As String = INIRead(Globals.ProgramINIFile, "Program", "AskBeforeChangingResolution", "True")
		If AskBeforeChangingResolution.Equals("False") Then
			Globals.AskBeforeChangingResolution = False
			Me.askBeforeChangingResolutionToolStripMenuItem.Checked = False
		End If
		Dim AskAfterChangingResolution As String = INIRead(Globals.ProgramINIFile, "Program", "AskAfterChangingResolution", "True")
		If AskAfterChangingResolution.Equals("False") Then
			Globals.AskAfterChangingResolution = False
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
		If GetRegistryKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Net Profiles").Length > 0 Then
			Me.runWhenILogInToWindowsToolStripMenuItem.Checked = True
		End If
		If Globals.EnableLoadTimer.Equals(True) Then
			Me.timerLoad.Enabled = True
		End If
		
		Call GetLanguages
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
				
                LanguageMenuItem = Me.languageToolStripMenuItem.DropDownItems.Add(root.SelectSingleNode("/Language").Attributes("display_name").Value)
                LanguageMenuItem.Tag = Filename.Name
                LanguageMenuItem.CheckOnClick = True
                AddHandler LanguageMenuItem.Click, AddressOf LanguageMenuClick
                If Filename.FullName.ToLower = Globals.CurrentLangPath.ToLower Then
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
				If LangMenuItem.Tag.Substring(0, LangMenuItem.Tag.Length - 4) = Globals.CurrentLang.ToLower Then
					LangMenuItem.Checked = False
				End If
			Next
			Globals.CurrentLang = sender.Tag.Substring(0, sender.Tag.Length - 4)
			Globals.CurrentLangPath = My.Application.Info.DirectoryPath & "\lang\" & sender.Tag
			INIWrite(Globals.ProgramINIFile, "Program", "Language", sender.Tag)
			Call LoadLanguage()
		Else
			sender.Checked = True
		End If
	End Sub
	
	Public Sub LoadLanguage()
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.fileToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/fileToolStripMenuItem").InnerText
		Me.toolStripMenuItemNewProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripMenuItemNewProfile").InnerText
		Me.languageToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/languageToolStripMenuItem").InnerText
		Me.applyProfileToolStripMenuItemApplyProfile.Text = root.SelectSingleNode("/Language/MainForm/applyProfileToolStripMenuItemApplyProfile").InnerText
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Text = root.SelectSingleNode("/Language/MainForm/activateOnDifferentNetworkCardToolStripMenuItem1").InnerText
		Me.toolStripMenuItemCopyProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripMenuItemCopyProfile").InnerText
		Me.toolStripMenuItemEditProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripMenuItemEditProfile").InnerText
		Me.deleteToolStripMenuItemDeleteProfile.Text = root.SelectSingleNode("/Language/MainForm/deleteToolStripMenuItemDeleteProfile").InnerText
		Me.createDesktopShortcutToolStripMenuItem1.Text = root.SelectSingleNode("/Language/MainForm/createDesktopShortcutToolStripMenuItem1").InnerText
		Me.exitToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/exitToolStripMenuItem").InnerText
		Me.optionsToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/optionsToolStripMenuItem").InnerText
		Me.toggleToolbarTextToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/toggleToolbarTextToolStripMenuItem").InnerText
		Me.minimizeToTrayOnCloseToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/minimizeToTrayOnCloseToolStripMenuItem").InnerText
		Me.minimizeToTrayOnStartupToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/minimizeToTrayOnStartupToolStripMenuItem").InnerText
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem").InnerText
		Me.screenResolutionToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/screenResolutionToolStripMenuItem").InnerText
		Me.askBeforeChangingResolutionToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/askBeforeChangingResolutionToolStripMenuItem").InnerText
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/confirmSettingsAfterChangingResolutionToolStripMenuItem").InnerText
		Me.runWhenILogInToWindowsToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/runWhenILogInToWindowsToolStripMenuItem").InnerText
		Me.customizeDesktopShortcutsToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/customizeDesktopShortcutsToolStripMenuItem").InnerText
		Me.reloadNetworkInterfacesToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/reloadNetworkInterfacesToolStripMenuItem").InnerText
		Me.reloadProfilesToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/reloadProfilesToolStripMenuItem").InnerText
		Me.helpToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/helpToolStripMenuItem").InnerText
		Me.netProfilesWebsiteToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/netProfilesWebsiteToolStripMenuItem").InnerText.Replace("%1", Globals.ProgramName)
		Me.checkForUpdatesToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/checkForUpdatesToolStripMenuItem").InnerText
		Me.aboutToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/aboutToolStripMenuItem").InnerText
		Me.toolStripButtonNewProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripButtonNewProfile").InnerText
		Me.toolStripButtonApplyProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripButtonApplyProfile").InnerText
		Me.toolStripButtonCopyProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripButtonCopyProfile").InnerText
		Me.toolStripButtonEditProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripButtonEditProfile").InnerText
		Me.toolStripButtonDeleteProfile.Text = root.SelectSingleNode("/Language/MainForm/toolStripButtonDeleteProfile").InnerText
		Me.StatusLabelWorking = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking").InnerText
		Me.StatusLabelWorking_Preloading = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Preloading").InnerText
		Me.StatusLabelWorking_Activating = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Activating").InnerText
		Me.StatusLabelWorking_UnmapDrives = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-UnmapDrives").InnerText
		Me.StatusLabelWorking_MapDrives = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-MapDrives").InnerText
		Me.StatusLabelWorking_Printer = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Printer").InnerText
		Me.StatusLabelWorking_Internet = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Internet").InnerText
		Me.StatusLabelWorking_Homepage = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Homepage").InnerText
		Me.StatusLabelWorking_Programs = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Programs").InnerText
		Me.StatusLabelWorking_Wallpaper = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Wallpaper").InnerText
		Me.StatusLabelWorking_Resolution = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Resolution").InnerText
		Me.StatusLabelWorking_Reloading = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Reloading").InnerText
		Me.StatusLabelWorking_DHCP = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-DHCP").InnerText
		Me.StatusLabelWorking_IPAddress = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-IPAddress").InnerText
		Me.StatusLabelWorking_Gateway = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-Gateway").InnerText
		Me.StatusLabelWorking_DNS = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-DNS").InnerText
		Me.StatusLabelWorking_WINS = root.SelectSingleNode("/Language/MainForm/toolStripStatusLabelWorking-WINS").InnerText
		Me.applyProfileToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/applyProfileToolStripMenuItem").InnerText
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/activateOnDifferentNetworkCardToolStripMenuItem").InnerText
		Me.copyToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/copyToolStripMenuItem").InnerText
		Me.editToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/editToolStripMenuItem").InnerText
		Me.deleteToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/deleteToolStripMenuItem").InnerText
		Me.createDesktopShortcutToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/createDesktopShortcutToolStripMenuItem").InnerText
		Me.showHideWindowToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/showHideWindowToolStripMenuItem").InnerText
		Me.profilesToolStripMenuItem.Text = root.SelectSingleNode("/Language/MainForm/profilesToolStripMenuItem").InnerText
		Me.exitToolStripMenuItem1.Text = root.SelectSingleNode("/Language/MainForm/exitToolStripMenuItem1").InnerText
		Me.NoNetworkProfilesMessageBox_1 = root.SelectSingleNode("/Language/MainForm/NoNetworkProfilesMessageBox-1").InnerText
		Me.NoNetworkProfilesMessageBox_2 = root.SelectSingleNode("/Language/MainForm/NoNetworkProfilesMessageBox-2").InnerText
		Me.DeleteProfileMessageBox = root.SelectSingleNode("/Language/MainForm/DeleteProfileMessageBox").InnerText
		Me.DeleteProfileMessageBox_Title = root.SelectSingleNode("/Language/MainForm/DeleteProfileMessageBox-Title").InnerText
		Me.ShortcutConfigDefault = root.SelectSingleNode("/Language/MainForm/ShortcutConfigDefault").InnerText
		Me.CreateShortcutMessagebox = root.SelectSingleNode("/Language/MainForm/CreateShortcutMessagebox").InnerText
		Me.CheckForUpdates_Latest = root.SelectSingleNode("/Language/MainForm/CheckForUpdates-Latest").InnerText
		Me.CheckForUpdates_New_1 = root.SelectSingleNode("/Language/MainForm/CheckForUpdates-New-1").InnerText.Replace("%1", Globals.ProgramName)
		Me.CheckForUpdates_New_2 = root.SelectSingleNode("/Language/MainForm/CheckForUpdates-New-2").InnerText.Replace("%1", Globals.ProgramName)
		Me.CheckForUpdates_Title = root.SelectSingleNode("/Language/MainForm/CheckForUpdates-Title").InnerText.Replace("%1", Globals.ProgramName)
		Me.CheckForUpdates_Error_1 = root.SelectSingleNode("/Language/MainForm/CheckForUpdates-Error-1").InnerText
		Me.CheckForUpdates_Error_2 = root.SelectSingleNode("/Language/MainForm/CheckForUpdates-Error-2").InnerText
	End Sub
	
	Sub ToggleToolbarTextToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim i As Integer
		For i = 0 To Me.toolStripMain.Items.Count-1
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
		Me.profilesToolStripMenuItem.DropDownItems.Clear
		Dim ProfileCategories As New DirectoryInfo(My.Application.Info.DirectoryPath & "\profiles\")
		Dim Dirs As DirectoryInfo() = ProfileCategories.GetDirectories("*.*")
		Dim DirectoryName As DirectoryInfo
		Dim CategoryMenu As ToolStripMenuItem
		For Each DirectoryName In Dirs
            Try
				Application.DoEvents()
				Dim NewProfileCategoryName As String = GetStoredInterfaceName(DirectoryName.Name)
				If NewProfileCategoryName.Trim.Length > 0 Then
					Application.DoEvents()
					Dim ThisInterfaceType As String = GetInterfaceType(DirectoryName.Name)
                	Application.DoEvents()
                	Dim NewProfileCategory As New ListViewGroup(NewProfileCategoryName, HorizontalAlignment.Left)
                	Application.DoEvents()
                	NewProfileCategory.Name = DirectoryName.Name
                	Application.DoEvents()
                	Me.listViewProfiles.Groups.Add(NewProfileCategory)
                	Application.DoEvents()
                	If DirectoryName.GetFiles().Length > 0 And (NewProfileCategoryName.Trim <> "Error" Or NewProfileCategoryName.Trim <> "") Then
                		Application.DoEvents()
                		CategoryMenu = Me.profilesToolStripMenuItem.DropDownItems.Add(NewProfileCategoryName)
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
                Application.DoEvents()
                Dim ThisListItem As ListViewItem
                ThisListItem = Me.listViewProfiles.Items.Add(INIRead(Filename.FullName,"General","Name", "[No Name]"))
                Application.DoEvents()
                ThisListItem.Group = GroupName
                Application.DoEvents()
                If Filename.FullName.ToLower = INIRead(Globals.ProgramINIFile,"Program","Last Activated Profile", "").ToLower Then
                	ThisListItem.Font = New System.Drawing.Font(ThisListItem.Font, FontStyle.Bold)
                End If
                If INIRead(Filename.FullName,"TCP/IP Settings","DHCP", "0") = "0" Then
                	ThisListItem.SubItems.Add(INIRead(Filename.FullName,"TCP/IP Settings","IP Address", "0.0.0.0"))
                Else
                	ThisListItem.SubItems.Add("Dynamic IP")
                End If
                Application.DoEvents()
                ThisListItem.SubItems.Item(1).ForeColor = System.Drawing.Color.Gray
                Application.DoEvents()
                ThisListItem.SubItems.Add(Filename.Name)
                Application.DoEvents()
                ThisListItem.SubItems.Add(Filename.FullName)
                
                Application.DoEvents()
                ProfileMenuItem = CategoryMenu.DropDownItems.Add(INIRead(Filename.FullName,"General","Name", "[No Name]"))
                ProfileMenuItem.Tag = Filename.FullName
                ProfileMenuItem.ToolTipText = "Activate " & ProfileMenuItem.Text
                AddHandler ProfileMenuItem.Click, AddressOf SystemTrayMenuClick
           
                
                Application.DoEvents()
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
	End Sub
	
	Private Sub SystemTrayMenuClick(sender as Object, e as System.EventArgs)
		Globals.INIAutoLoad = sender.Tag
		AutoActivate.Show
	End Sub
	
	Public Function GetInterfaceType(ThisInterface As String) As String
		Try
			Dim searcher As New ManagementObjectSearcher( _
				"root\CIMV2", _
				"SELECT * FROM Win32_NetworkAdapter WHERE MACAddress = '" & ThisInterface.Replace("-",":") & "'") 

			For Each queryObj As ManagementObject in searcher.Get()
				Return queryObj("ProductName")
			Next
		Catch err As ManagementException
			Return "Error"
		End Try
		Return ""
	End Function
	
	Sub ToolStripButtonNewProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.CreatingNewProfile = True
		ProfileSettings.ShowDialog()
	End Sub
	
	Sub ToolStripButtonEditProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.EditProfile
	End Sub
	
	Public Sub EditProfile
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Globals.CreatingNewProfile = False
			ProfileSettings.ShowDialog
		End If
	End Sub
	
	Sub TimerLoadTick(ByVal sender As Object, ByVal e As EventArgs)
		Me.timerLoad.Enabled = False
		Me.toolStripProgressBar1.Enabled = True
		Me.toolStripProgressBar1.Visible = True
		Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking_Preloading
		Me.toolStripStatusLabelWorking.Visible = True
		Call PopulateNetworkCardArray
		Call RefreshProfiles
		If Me.listViewProfiles.Items.Count = 0 Then
			Dim YNResult As Object
			YNResult = MessageBox.Show(Me.NoNetworkProfilesMessageBox_1 & vbCrLf & Me.NoNetworkProfilesMessageBox_2, "Net Profiles", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If YNResult = Me.DialogResult.Yes Then
				Globals.CreatingNewProfile = True
				ProfileSettings.ShowDialog
			End If
		End If
	End Sub
	
	Public Sub RefreshProfiles
		Me.toolStripProgressBar1.Enabled = True
		Me.toolStripProgressBar1.Visible = True
		Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking
		Me.toolStripStatusLabelWorking.Visible = True
		Me.toolStripButtonApplyProfile.Enabled = False
		Me.toolStripButtonCopyProfile.Enabled = False
		Me.toolStripButtonEditProfile.Enabled = False
		Me.toolStripButtonDeleteProfile.Enabled = False
		Globals.AutoConnectSSID.Clear
		Globals.AutoConnectProfile.Clear
		Globals.AutoConnectMACAddress.Clear
		Me.timerDetectWireless.Enabled = False
		Call GetProfileCategories
		If Globals.AutoConnectSSID.Count > 0 Then
			Me.timerDetectWireless.Enabled = True
		End If
		Me.toolStripProgressBar1.Visible = False
		Me.toolStripProgressBar1.Enabled = False
		Me.toolStripStatusLabelWorking.Visible = False
	End Sub
	
	Sub ToolStripButtonDeleteProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.DeleteProfile
	End Sub
	
	Public Sub DeleteProfile
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Dim YNResult As Object
			YNResult = MessageBox.Show(Me.DeleteProfileMessageBox.Replace("%1", Me.listViewProfiles.FocusedItem.Text), Me.DeleteProfileMessageBox_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If YNResult = Me.DialogResult.Yes Then
				System.IO.File.Delete(My.Application.Info.DirectoryPath & "\profiles\" & Me.listViewProfiles.SelectedItems.Item(0).Group.Name.ToString & "\" & Me.listViewProfiles.SelectedItems(0).SubItems(2).Text)
				Call Me.RefreshProfiles
			Else
				Exit Sub
			End If
		End If		
	End Sub
	
	Sub ContextMenuStripProfilesOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
		If Me.listViewProfiles.SelectedItems.Count = 0 Then
			e.Cancel = True
		Else
			e.Cancel = False
		End If
	End Sub
	
	Sub ApplyProfileToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
		End If
	End Sub
	
	Sub EditToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.EditProfile
	End Sub
	
	Sub DeleteToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.DeleteProfile
	End Sub
	
    Public Sub ApplyProfile(ByVal ThisProfile As String, ByVal ApplyType As String, Optional ByVal MACAddress As String = "")
        Call UpdateProgress(Me.StatusLabelWorking_Activating, ApplyType)
        If ApplyType.Equals("normal") Then
            Me.toolStripProgressBar1.Enabled = True
            Me.toolStripProgressBar1.Visible = True
        End If

        Dim i As Integer
        For i = 0 To Me.listViewProfiles.Items.Count - 1
            Me.listViewProfiles.Items.Item(i).Font = New System.Drawing.Font(Me.listViewProfiles.Items.Item(i).Font, FontStyle.Regular)
            If Me.listViewProfiles.Items.Item(i).SubItems.Item(3).Text = ThisProfile Then
                Me.listViewProfiles.Items.Item(i).Font = New System.Drawing.Font(Me.listViewProfiles.Items.Item(i).Font, FontStyle.Bold)
                Me.listViewProfiles.Items.Item(i).SubItems.Item(1).Font = New System.Drawing.Font(Me.listViewProfiles.Items.Item(i).Font, FontStyle.Regular)
            End If
        Next
        INIWrite(Globals.ProgramINIFile, "Program", "Last Activated Profile", ThisProfile)

        '*** START SAVE TCP/IP SETTINGS ***
        Dim strIPAddress As String = INIRead(ThisProfile, "TCP/IP Settings", "IP Address", "")
        Dim strSubnetMask As String = INIRead(ThisProfile, "TCP/IP Settings", "Subnet Mask", "")
        Dim strDefaultGateway As String = INIRead(ThisProfile, "TCP/IP Settings", "Default Gateway", "")
        Dim strPrefDNSServer As String = INIRead(ThisProfile, "TCP/IP Settings", "DNS Server", "")
        Dim strAltDNSServer As String = INIRead(ThisProfile, "TCP/IP Settings", "Alternate DNS Server", "")
        Dim strWINSServer As String = INIRead(ThisProfile, "TCP/IP Settings", "WINS Server", "")
        Dim strDHCP As String = INIRead(ThisProfile, "TCP/IP Settings", "DHCP", "0")
        Dim boolDHCP As Boolean
        If strDHCP.Equals("0") Then boolDHCP = False
        If strDHCP.Equals("1") Then boolDHCP = True
        Dim strAutoConfigAddress As String = INIRead(ThisProfile, "Internet Settings", "AutoConfigAddress", "")
        Dim strUseProxySettings As String = INIRead(ThisProfile, "Internet Settings", "UseProxySettings", "0")
        Dim boolUseProxySettings As Boolean
        If strUseProxySettings.Equals("0") Then boolUseProxySettings = False
        If strUseProxySettings.Equals("1") Then boolUseProxySettings = True
        Dim strProxyServerAddress As String = INIRead(ThisProfile, "Internet Settings", "ProxyServerAddress", "")
        Dim strProxyServerPort As String = INIRead(ThisProfile, "Internet Settings", "ProxyServerPort", "")
        Dim boolProxyBypass As Boolean = INIRead(ThisProfile, "Internet Settings", "ProxyBypass", False)
        Dim boolProxyIE As Boolean = INIRead(ThisProfile, "Internet Settings", "InternetExplorer", False)
        Dim boolProxyFirefox As Boolean = INIRead(ThisProfile, "Internet Settings", "Firefox", False)
        Dim boolOpera As Boolean = INIRead(ThisProfile, "Internet Settings", "Opera", False)
        Dim strDefaultHomepage As String = INIRead(ThisProfile, "Internet Settings", "DefaultHomepage", "")
        Dim TheMACAddress() As String = StrReverse(ThisProfile).Split("\")
        Dim UseThisMACAddress As String = StrReverse(TheMACAddress(1))
        If MACAddress.Length > 0 Then
            UseThisMACAddress = MACAddress
        End If

        Call SaveTCPIPSettings(strIPAddress, strSubnetMask, strDefaultGateway, strPrefDNSServer, strAltDNSServer, strWINSServer, boolDHCP, UseThisMACAddress, ApplyType)
        '*** END SAVE TCP/IP SETTINGS ***

        '*** START DISCONNECT PREVIOUSLY MAPPED DRIVES ***
        Call UpdateProgress(Me.StatusLabelWorking_UnmapDrives, ApplyType)
        Dim DisconnectTheseDrives() As String
        DisconnectTheseDrives = INIRead(Globals.ProgramINIFile, "Options", "Mapped Drives", "").Split("|")
        Dim TheDrive As Object
        For TheDrive = DisconnectTheseDrives.GetLowerBound(0) To DisconnectTheseDrives.GetUpperBound(0)
            Application.DoEvents()
            DisconnectNetworkDrive(DisconnectTheseDrives(TheDrive), True)
        Next TheDrive
        '*** END DISCONNECT PREVIOUSLY MAPPED DRIVES ***

        '*** START MAP NEW DRIVES ***
        Call UpdateProgress(Me.StatusLabelWorking_MapDrives, ApplyType)
        Dim CurrentlyMappedDrives As String = ""
        Dim iniText As String
        Dim iniArray() As String
        iniText = INIRead(ThisProfile, "Mapped Drives")
        iniText = iniText.Replace(ControlChars.NullChar, "|")
        iniText = Trim(iniText)
        iniArray = iniText.Split("|")
        Dim iniArray2() As String
        Dim X As Integer
        For X = iniArray.GetLowerBound(0) To (iniArray.GetUpperBound(0) - 1)
            Application.DoEvents()
            iniArray2 = INIRead(ThisProfile, "Mapped Drives", iniArray(X), "").Split("|")
            ConnectThisNetworkDrive(iniArray2(0), iniArray(X), SubstitutionDecode(iniArray2(1)), SubstitutionDecode(iniArray2(2)))
            CurrentlyMappedDrives = CurrentlyMappedDrives & "|" & iniArray(X)
        Next X
        If CurrentlyMappedDrives.Length > 1 Then
            INIWrite(Globals.ProgramINIFile, "Options", "Mapped Drives", CurrentlyMappedDrives.Substring(1, CurrentlyMappedDrives.Length - 1))
        Else
            INIWrite(Globals.ProgramINIFile, "Options", "Mapped Drives", "")
        End If
        '*** END MAP NEW DRIVES ***

        '*** START SETTING DEFAULT PRINTER ***
        Dim NewDefaultPrinter As String = INIRead(ThisProfile, "Printer", "Default", "")
        If NewDefaultPrinter.Length > 0 Then
            Call UpdateProgress(Me.StatusLabelWorking_Printer, ApplyType)
            Call SetDefaultPrinter(NewDefaultPrinter)
        End If
        '*** END SETTING DEFAULT PRINTER ***

        '*** START INTERNET SETTINGS ***
        Call UpdateProgress(Me.StatusLabelWorking_Internet, ApplyType)
        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings\", True)
        If boolUseProxySettings.Equals(True) Then
            If boolProxyIE.Equals(True) Then
                regKey.SetValue("ProxyEnable", 1)
                If strProxyServerPort.Length > 0 Then
                    regKey.SetValue("ProxyServer", strProxyServerAddress & ":" & strProxyServerPort)
                Else
                    regKey.SetValue("ProxyServer", strProxyServerAddress)
                End If
                If boolProxyBypass.Equals(True) Then
                    regKey.SetValue("ProxyOverride", "<local>")
                Else
                    regKey.DeleteValue("ProxyOverride")
                End If
            Else
                regKey.SetValue("ProxyEnable", 0)
                regKey.SetValue("ProxyServer", "")
            End If
            If boolProxyFirefox.Equals(True) Then
                If strProxyServerPort.Length > 0 Then
                    Call SaveFirefoxSettings(strProxyServerAddress, strProxyServerPort, "1")
                Else
                    Call SaveFirefoxSettings(strProxyServerAddress, "0", "1")
                End If
            Else
                Call SaveFirefoxSettings("", "0", "0")
            End If
        Else
            regKey.SetValue("ProxyEnable", 0)
            regKey.SetValue("ProxyServer", "")
            regKey.DeleteValue("ProxyOverride", False)
            Call SaveFirefoxSettings("", "0", "0")
        End If
        If boolProxyIE.Equals(True) Then
            If strAutoConfigAddress.Length > 0 Then
                regKey.SetValue("AutoConfigURL", strAutoConfigAddress)
            Else
                regKey.DeleteValue("AutoConfigURL", False)
            End If
        End If
        If boolProxyFirefox.Equals(True) Then
            If strAutoConfigAddress.Length > 0 Then
                Call SaveFirefoxAutoConfigAddress(strAutoConfigAddress)
            Else
                Call SaveFirefoxAutoConfigAddress("")
            End If
        End If

        If boolOpera.Equals(True) Then
            Call SaveOperaSettings(strProxyServerAddress, strProxyServerPort, strUseProxySettings, strAutoConfigAddress, boolProxyBypass, strDefaultHomepage)
        End If

        Call UpdateProgress(Me.StatusLabelWorking_Homepage, ApplyType)
        If strDefaultHomepage.Trim.Length > 0 Then
            If boolProxyIE.Equals(True) Then
                SetHomepage(strDefaultHomepage)
            End If
            If boolProxyFirefox.Equals(True) Then
                Call SaveFirefoxHomepage(strDefaultHomepage)
            End If
        End If
        '*** END INTERNET SETTINGS ***

        '*** START RUNNING PROGRAMS ***
        Call UpdateProgress(Me.StatusLabelWorking_Programs, ApplyType)
        Dim iniRunText As String
        Dim iniRunArray() As String
        iniRunText = INIRead(ThisProfile, "Run")
        iniRunText = iniRunText.Replace(ControlChars.NullChar, "|")
        iniRunText = Trim(iniRunText)
        iniRunArray = iniRunText.Split("|")
        Dim iniRunArray2() As String
        Dim XRun As Integer
        For XRun = iniRunArray.GetLowerBound(0) To (iniRunArray.GetUpperBound(0) - 1)
            Application.DoEvents()
            iniRunArray2 = Microsoft.VisualBasic.Strings.Split(INIRead(ThisProfile, "Run", iniRunArray(XRun), ""), "||")
            Dim ThisProgram As System.Diagnostics.Process = New System.Diagnostics.Process()
            ThisProgram.StartInfo.FileName = iniRunArray2(0)
            If iniRunArray2(2).Length > 0 Then
                Application.DoEvents()
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
            Application.DoEvents()
            If iniRunArray2(1).Length > 0 Then
                ThisProgram.StartInfo.Arguments = iniRunArray2(1)
            End If
            Application.DoEvents()
            If iniRunArray2(3).Length > 0 Then
                ThisProgram.StartInfo.UserName = SubstitutionDecode(iniRunArray2(3))
            End If
            Application.DoEvents()
            If iniRunArray2(4).Length > 0 Then
                Dim pw As New System.Security.SecureString
                For Each ch As Char In SubstitutionDecode(iniRunArray2(4))
                    pw.AppendChar(ch)
                Next
                ThisProgram.StartInfo.Password = pw
            End If
            Application.DoEvents()
            If iniRunArray2(5).Length > 0 Then
                ThisProgram.StartInfo.Domain = SubstitutionDecode(iniRunArray2(5))
            End If
            Application.DoEvents()
            ThisProgram.StartInfo.UseShellExecute = True
            ThisProgram.Start()
            Application.DoEvents()
        Next XRun
        '*** END RUNNING PROGRAMS ***

        '*** APPLY WALLPAPER ***
        Dim NewWallpaper As String = INIRead(ThisProfile, "Desktop", "Wallpaper", "")
        If NewWallpaper.Length > 0 Then
            If System.IO.File.Exists(NewWallpaper) Then
                Call UpdateProgress(Me.StatusLabelWorking_Wallpaper, ApplyType)
                Call SetWallpaper(NewWallpaper)
            End If
        End If
        '*** END APPLY WALLPAPER ***

        '*** START DISPLAY SETTINGS ***
        Me.messageBoxManager1.HookEnabled = True
        Dim NewDisplayResolution As String = INIRead(ThisProfile, "Desktop", "ScreenResolution", "")
        Dim NewColorQuality As String = INIRead(ThisProfile, "Desktop", "ColorQuality", "")
        cScreen.bConfimPrompt = Globals.AskBeforeChangingResolution
        cScreen.bRevertPrompt = Globals.AskAfterChangingResolution
        cScreen.bValidate = True
        If NewDisplayResolution.Length > 0 And NewColorQuality.Length > 0 Then
            Dim ResArray() As String = NewDisplayResolution.Split(" ")
            Dim ResW As Integer = CInt(ResArray(0))
            Dim ResH As Integer = CInt(ResArray(2))
            Dim ResC As Integer = CInt("16")
            If NewColorQuality.Contains("8") Then ResC = CInt("8")
            If NewColorQuality.Contains("16") Then ResC = CInt("16")
            If NewColorQuality.Contains("32") Then ResC = CInt("32")
            Call UpdateProgress(Me.StatusLabelWorking_Resolution, ApplyType)
            cScreen.ChangeResolution(ResW, ResH, ResC)
        ElseIf NewDisplayResolution.Length > 0 And NewColorQuality.Length = 0 Then
            Dim ResArray() As String = NewDisplayResolution.Split(" ")
            Dim ResW As Integer = ResArray(0)
            Dim ResH As Integer = ResArray(2)
            Call UpdateProgress(Me.StatusLabelWorking_Resolution, ApplyType)
            cScreen.ChangeResolution(ResW, ResH)
        End If
        Me.messageBoxManager1.HookEnabled = False
        '*** END DISPLAY SETTINGS ***

        If ApplyType.Equals("normal") Then
            Me.toolStripProgressBar1.Visible = False
            Me.toolStripProgressBar1.Enabled = False
            Me.toolStripStatusLabelWorking.Visible = False
            Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking
        End If
    End Sub
	
	Sub ToolStripButtonApplyProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
		End If
	End Sub
	
	Sub ToolStripMenuItemNewProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.CreatingNewProfile = True
		ProfileSettings.ShowDialog
	End Sub
	
	Sub ToolStripMenuItemEditProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.EditProfile
	End Sub
	
	Sub DeleteToolStripMenuItemDeleteProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.DeleteProfile
	End Sub
	
	Sub ApplyProfileToolStripMenuItemApplyProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
		End If
	End Sub
	
	Sub ExitToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.OKToCloseProgram = True
		Me.Close
	End Sub
	
	Sub MainFormFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
		If e.CloseReason = System.Windows.Forms.CloseReason.WindowsShutDown Then
			
		Else
			If Me.toolStripProgressBar1.Visible = True Or Globals.OKToCloseProgram = False Then
				If Me.toolStripProgressBar1.Visible = False Then
					Call Me.ToggleProgramVisibility
				End If
				e.Cancel = True
			Else
				e.Cancel = False
			End If
			If Me.Visible.Equals(True) And Me.WindowState <> FormWindowState.Minimized Then
				INIWrite(Globals.ProgramINIFile, "Program", "LocationTop", Me.Top.ToString)
				INIWrite(Globals.ProgramINIFile, "Program", "LocationLeft", Me.Left.ToString)
				INIWrite(Globals.ProgramINIFile, "Program", "WindowWidth", Me.Width.ToString)
				INIWrite(Globals.ProgramINIFile, "Program", "WindowHeight", Me.Height.ToString)
			End If		
		End If
	End Sub
	
	Sub ExitToolStripMenuItem1Click(ByVal sender As Object, ByVal e As EventArgs)
		Globals.OKToCloseProgram = True
		Me.Close
	End Sub
	
	Sub ShowHideWindowToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.ToggleProgramVisibility
	End Sub
	
	Sub MinimizeToTrayOnCloseToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.minimizeToTrayOnCloseToolStripMenuItem.Checked.Equals(True) Then
			INIWrite(Globals.ProgramINIFile, "Program", "MinimizeToTray", "True")
			Globals.OKToCloseProgram = False
		Else
			INIWrite(Globals.ProgramINIFile, "Program", "MinimizeToTray", "False")
			Globals.OKToCloseProgram = True
		End If
	End Sub
	
	Sub NotifyIcon1DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.ToggleProgramVisibility
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
	
	Sub FileToolStripMenuItemDropDownOpening(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Me.toolStripMenuItemEditProfile.Enabled = True
			Me.deleteToolStripMenuItemDeleteProfile.Enabled = True
			Me.applyProfileToolStripMenuItemApplyProfile.Enabled = True
			Me.createDesktopShortcutToolStripMenuItem1.Enabled = True
			Me.activateOnDifferentNetworkCardToolStripMenuItem1.Enabled = True
			Me.toolStripMenuItemCopyProfile.Enabled = True
		Else
			Me.toolStripMenuItemEditProfile.Enabled = False
			Me.deleteToolStripMenuItemDeleteProfile.Enabled = False
			Me.applyProfileToolStripMenuItemApplyProfile.Enabled = False
			Me.createDesktopShortcutToolStripMenuItem1.Enabled = False
			Me.activateOnDifferentNetworkCardToolStripMenuItem1.Enabled = False
			Me.toolStripMenuItemCopyProfile.Enabled = False
		End If
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
			MessageBox.Show(Me.CreateShortcutMessagebox, "Net Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub
	
	Sub CreateDesktopShortcutToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Call CreateDesktopShortcut
	End Sub
	
	Sub CustomizeDesktopShortcutsToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		DesktopShortcut.ShowDialog
	End Sub
	
	Sub ReloadNetworkInterfacesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.toolStripProgressBar1.Enabled = True
		Me.toolStripProgressBar1.Visible = True
		Me.toolStripStatusLabelWorking.Text = Me.StatusLabelWorking_Reloading
		Me.toolStripStatusLabelWorking.Visible = True
		Call PopulateNetworkCardArray
		Me.toolStripProgressBar1.Visible = False
		Me.toolStripProgressBar1.Enabled = False
		Me.toolStripStatusLabelWorking.Visible = False
	End Sub
	
	Sub ReloadProfilesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Call RefreshProfiles
	End Sub
	
	Sub CreateDesktopShortcutToolStripMenuItem1Click(ByVal sender As Object, ByVal e As EventArgs)
		Call CreateDesktopShortcut
	End Sub
	
	Sub ToolStripButtonCreateDesktopShortcutClick(ByVal sender As Object, ByVal e As EventArgs)
		Call CreateDesktopShortcut
	End Sub
	
	Sub ActivateOnDifferentNetworkCardToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		ActivateSelectNetworkCard.ShowDialog
	End Sub
	
	Sub ActivateOnDifferentNetworkCardToolStripMenuItem1Click(ByVal sender As Object, ByVal e As EventArgs)
		ActivateSelectNetworkCard.ShowDialog
	End Sub
	
	Sub AskBeforeChangingResolutionToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.AskBeforeChangingResolution = Me.askBeforeChangingResolutionToolStripMenuItem.Checked
		INIWrite(Globals.ProgramINIFile, "Program", "AskBeforeChangingResolution", Me.askBeforeChangingResolutionToolStripMenuItem.Checked.ToString)
	End Sub
	
	Sub ConfirmSettingsAfterChangingResolutionToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.AskAfterChangingResolution = Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked
		INIWrite(Globals.ProgramINIFile, "Program", "AskAfterChangingResolution", Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked.ToString)
	End Sub
	
	Sub TimerDetectWirelessTick(ByVal sender As Object, ByVal e As EventArgs)
		Me.timerDetectWireless.Enabled = False
		Call GetConnectedSSIDs()
		Me.timerDetectWireless.Enabled = True
	End Sub
	
	Sub MinimizeToTrayOnStartupToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		INIWrite(Globals.ProgramINIFile, "Program", "ToTrayOnStartup", Me.minimizeToTrayOnStartupToolStripMenuItem.Checked.ToString)
	End Sub
	
	Sub DontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		INIWrite(Globals.ProgramINIFile, "Program", "DoNotConfirmAutoActivate", Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Checked.ToString)
	End Sub
	
	Sub RunWhenILogInToWindowsToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.runWhenILogInToWindowsToolStripMenuItem.Checked.Equals(True) Then
			Call SetRegistryKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Net Profiles", Chr(34) & Application.ExecutablePath & Chr(34))
		Else
			Call DeleteRegistryKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Net Profiles")
		End If
	End Sub
	
	Sub AboutToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		About.ShowDialog
	End Sub
	
	Sub ListViewProfilesDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Call Me.ApplyProfile(Me.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal")
		End If
	End Sub
	
	Sub ListViewProfilesItemSelectionChanged(ByVal sender As Object, ByVal e As ListViewItemSelectionChangedEventArgs)
		If Me.listViewProfiles.SelectedItems.Count > 0 Then
			Me.toolStripButtonApplyProfile.Enabled = True
			Me.toolStripButtonEditProfile.Enabled = True
			Me.toolStripButtonDeleteProfile.Enabled = True
			Me.toolStripButtonCopyProfile.Enabled = True
		Else
			Me.toolStripButtonApplyProfile.Enabled = False
			Me.toolStripButtonEditProfile.Enabled = False
			Me.toolStripButtonDeleteProfile.Enabled = False
			Me.toolStripButtonCopyProfile.Enabled = False
		End If
	End Sub
	
	Sub CheckForUpdatesToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Application.DoEvents
		Try
			Dim wrq As WebRequest = WebRequest.Create("http://www.milnersolutions.com/netprofiles/currentversion.php")
			Dim wrp As WebResponse = wrq.GetResponse()
			Application.DoEvents
			Dim sr As StreamReader = New StreamReader(wrp.GetResponseStream())
			Application.DoEvents
			Dim currentVersion As String = sr.ReadToEnd()
			If currentVersion.Trim = Globals.ProgramVersion Then
				MessageBox.Show(Me.CheckForUpdates_Latest, "Net Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				Dim YNResult As Object
				YNResult = MessageBox.Show(Me.CheckForUpdates_New_1.Replace("%2", currentVersion.Trim) & vbCrLf & Me.CheckForUpdates_New_2, Me.CheckForUpdates_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If YNResult = Me.DialogResult.Yes Then
					Application.DoEvents
					Start("http://code.google.com/p/netprofiles/")
				End If
			End If
		Catch
			MessageBox.Show(Me.CheckForUpdates_Error_1 & vbCrLf & Me.CheckForUpdates_Error_2, "Net Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Try
		
	End Sub
	
	Sub CopyToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		CopyProfile.ShowDialog
	End Sub
	
	Sub toolStripMenuItemCopyProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		CopyProfile.ShowDialog
	End Sub
	
	Sub ToolStripButtonCopyProfileClick(ByVal sender As Object, ByVal e As EventArgs)
		CopyProfile.ShowDialog
	End Sub
	
	Sub NetProfilesWebsiteToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
		Start("http://code.google.com/p/netprofiles/")
	End Sub
End Class
