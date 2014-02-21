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
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItemNewProfile = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.applyProfileToolStripMenuItemApplyProfile = New System.Windows.Forms.ToolStripMenuItem()
		Me.activateOnDifferentNetworkCardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripMenuItemCopyProfile = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItemEditProfile = New System.Windows.Forms.ToolStripMenuItem()
		Me.deleteToolStripMenuItemDeleteProfile = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.createDesktopShortcutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toggleToolbarTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.minimizeToTrayOnCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.minimizeToTrayOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.dontAskBeforeRestartingFirefoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.screenResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.askBeforeChangingResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.runWhenILogInToWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
		Me.languageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
		Me.customizeDesktopShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.reloadProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.netProfilesWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.checkForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMain = New System.Windows.Forms.ToolStrip()
		Me.toolStripButtonNewProfile = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripButtonApplyProfile = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripButtonCopyProfile = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButtonEditProfile = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButtonDeleteProfile = New System.Windows.Forms.ToolStripButton()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
		Me.toolStripStatusLabelProgress = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabelWorking = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.imageListProfiles = New System.Windows.Forms.ImageList(Me.components)
		Me.listViewProfiles = New System.Windows.Forms.ListView()
		Me.columnHeaderName = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderIPAddress = New System.Windows.Forms.ColumnHeader()
		Me.contextMenuStripProfiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.applyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.activateOnDifferentNetworkCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.createDesktopShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.timerUpdateAdapters = New System.Windows.Forms.Timer(Me.components)
		Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.contextMenuStripSystemTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.showHideWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.profilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.exitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.pictureBoxWallpaper = New System.Windows.Forms.PictureBox()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.backgroundWorkerScanAdapters = New System.ComponentModel.BackgroundWorker()
		Me.backgroundWorkerApplyProfile = New System.ComponentModel.BackgroundWorker()
		Me.menuStrip1.SuspendLayout
		Me.toolStripMain.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.contextMenuStripProfiles.SuspendLayout
		Me.contextMenuStripSystemTray.SuspendLayout
		CType(Me.pictureBoxWallpaper,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.optionsToolStripMenuItem, Me.helpToolStripMenuItem})
		resources.ApplyResources(Me.menuStrip1, "menuStrip1")
		Me.menuStrip1.Name = "menuStrip1"
		'
		'fileToolStripMenuItem
		'
		Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemNewProfile, Me.toolStripSeparator1, Me.applyProfileToolStripMenuItemApplyProfile, Me.activateOnDifferentNetworkCardToolStripMenuItem1, Me.toolStripSeparator3, Me.toolStripMenuItemCopyProfile, Me.toolStripMenuItemEditProfile, Me.deleteToolStripMenuItemDeleteProfile, Me.toolStripSeparator6, Me.createDesktopShortcutToolStripMenuItem1, Me.toolStripSeparator7, Me.exitToolStripMenuItem})
		Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
		resources.ApplyResources(Me.fileToolStripMenuItem, "fileToolStripMenuItem")
		'
		'toolStripMenuItemNewProfile
		'
		resources.ApplyResources(Me.toolStripMenuItemNewProfile, "toolStripMenuItemNewProfile")
		Me.toolStripMenuItemNewProfile.Name = "toolStripMenuItemNewProfile"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
		'
		'applyProfileToolStripMenuItemApplyProfile
		'
		resources.ApplyResources(Me.applyProfileToolStripMenuItemApplyProfile, "applyProfileToolStripMenuItemApplyProfile")
		Me.applyProfileToolStripMenuItemApplyProfile.Name = "applyProfileToolStripMenuItemApplyProfile"
		'
		'activateOnDifferentNetworkCardToolStripMenuItem1
		'
		resources.ApplyResources(Me.activateOnDifferentNetworkCardToolStripMenuItem1, "activateOnDifferentNetworkCardToolStripMenuItem1")
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Name = "activateOnDifferentNetworkCardToolStripMenuItem1"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		resources.ApplyResources(Me.toolStripSeparator3, "toolStripSeparator3")
		'
		'toolStripMenuItemCopyProfile
		'
		resources.ApplyResources(Me.toolStripMenuItemCopyProfile, "toolStripMenuItemCopyProfile")
		Me.toolStripMenuItemCopyProfile.Name = "toolStripMenuItemCopyProfile"
		'
		'toolStripMenuItemEditProfile
		'
		resources.ApplyResources(Me.toolStripMenuItemEditProfile, "toolStripMenuItemEditProfile")
		Me.toolStripMenuItemEditProfile.Name = "toolStripMenuItemEditProfile"
		'
		'deleteToolStripMenuItemDeleteProfile
		'
		resources.ApplyResources(Me.deleteToolStripMenuItemDeleteProfile, "deleteToolStripMenuItemDeleteProfile")
		Me.deleteToolStripMenuItemDeleteProfile.Name = "deleteToolStripMenuItemDeleteProfile"
		'
		'toolStripSeparator6
		'
		Me.toolStripSeparator6.Name = "toolStripSeparator6"
		resources.ApplyResources(Me.toolStripSeparator6, "toolStripSeparator6")
		'
		'createDesktopShortcutToolStripMenuItem1
		'
		resources.ApplyResources(Me.createDesktopShortcutToolStripMenuItem1, "createDesktopShortcutToolStripMenuItem1")
		Me.createDesktopShortcutToolStripMenuItem1.Name = "createDesktopShortcutToolStripMenuItem1"
		'
		'toolStripSeparator7
		'
		Me.toolStripSeparator7.Name = "toolStripSeparator7"
		resources.ApplyResources(Me.toolStripSeparator7, "toolStripSeparator7")
		'
		'exitToolStripMenuItem
		'
		resources.ApplyResources(Me.exitToolStripMenuItem, "exitToolStripMenuItem")
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		'
		'optionsToolStripMenuItem
		'
		Me.optionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toggleToolbarTextToolStripMenuItem, Me.minimizeToTrayOnCloseToolStripMenuItem, Me.minimizeToTrayOnStartupToolStripMenuItem, Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem, Me.dontAskBeforeRestartingFirefoxToolStripMenuItem, Me.screenResolutionToolStripMenuItem, Me.runWhenILogInToWindowsToolStripMenuItem, Me.toolStripSeparator9, Me.languageToolStripMenuItem, Me.toolStripSeparator11, Me.customizeDesktopShortcutsToolStripMenuItem, Me.reloadProfilesToolStripMenuItem})
		Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
		resources.ApplyResources(Me.optionsToolStripMenuItem, "optionsToolStripMenuItem")
		'
		'toggleToolbarTextToolStripMenuItem
		'
		Me.toggleToolbarTextToolStripMenuItem.Checked = true
		Me.toggleToolbarTextToolStripMenuItem.CheckOnClick = true
		Me.toggleToolbarTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.toggleToolbarTextToolStripMenuItem.Name = "toggleToolbarTextToolStripMenuItem"
		resources.ApplyResources(Me.toggleToolbarTextToolStripMenuItem, "toggleToolbarTextToolStripMenuItem")
		'
		'minimizeToTrayOnCloseToolStripMenuItem
		'
		Me.minimizeToTrayOnCloseToolStripMenuItem.Checked = true
		Me.minimizeToTrayOnCloseToolStripMenuItem.CheckOnClick = true
		Me.minimizeToTrayOnCloseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.minimizeToTrayOnCloseToolStripMenuItem.Name = "minimizeToTrayOnCloseToolStripMenuItem"
		resources.ApplyResources(Me.minimizeToTrayOnCloseToolStripMenuItem, "minimizeToTrayOnCloseToolStripMenuItem")
		'
		'minimizeToTrayOnStartupToolStripMenuItem
		'
		Me.minimizeToTrayOnStartupToolStripMenuItem.CheckOnClick = true
		Me.minimizeToTrayOnStartupToolStripMenuItem.Name = "minimizeToTrayOnStartupToolStripMenuItem"
		resources.ApplyResources(Me.minimizeToTrayOnStartupToolStripMenuItem, "minimizeToTrayOnStartupToolStripMenuItem")
		'
		'dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem
		'
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.CheckOnClick = true
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Name = "dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem"
		resources.ApplyResources(Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem, "dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem")
		'
		'dontAskBeforeRestartingFirefoxToolStripMenuItem
		'
		Me.dontAskBeforeRestartingFirefoxToolStripMenuItem.CheckOnClick = true
		Me.dontAskBeforeRestartingFirefoxToolStripMenuItem.Name = "dontAskBeforeRestartingFirefoxToolStripMenuItem"
		resources.ApplyResources(Me.dontAskBeforeRestartingFirefoxToolStripMenuItem, "dontAskBeforeRestartingFirefoxToolStripMenuItem")
		'
		'screenResolutionToolStripMenuItem
		'
		Me.screenResolutionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.askBeforeChangingResolutionToolStripMenuItem, Me.confirmSettingsAfterChangingResolutionToolStripMenuItem})
		Me.screenResolutionToolStripMenuItem.Name = "screenResolutionToolStripMenuItem"
		resources.ApplyResources(Me.screenResolutionToolStripMenuItem, "screenResolutionToolStripMenuItem")
		'
		'askBeforeChangingResolutionToolStripMenuItem
		'
		Me.askBeforeChangingResolutionToolStripMenuItem.Checked = true
		Me.askBeforeChangingResolutionToolStripMenuItem.CheckOnClick = true
		Me.askBeforeChangingResolutionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.askBeforeChangingResolutionToolStripMenuItem.Name = "askBeforeChangingResolutionToolStripMenuItem"
		resources.ApplyResources(Me.askBeforeChangingResolutionToolStripMenuItem, "askBeforeChangingResolutionToolStripMenuItem")
		'
		'confirmSettingsAfterChangingResolutionToolStripMenuItem
		'
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked = true
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.CheckOnClick = true
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Name = "confirmSettingsAfterChangingResolutionToolStripMenuItem"
		resources.ApplyResources(Me.confirmSettingsAfterChangingResolutionToolStripMenuItem, "confirmSettingsAfterChangingResolutionToolStripMenuItem")
		'
		'runWhenILogInToWindowsToolStripMenuItem
		'
		Me.runWhenILogInToWindowsToolStripMenuItem.CheckOnClick = true
		Me.runWhenILogInToWindowsToolStripMenuItem.Name = "runWhenILogInToWindowsToolStripMenuItem"
		resources.ApplyResources(Me.runWhenILogInToWindowsToolStripMenuItem, "runWhenILogInToWindowsToolStripMenuItem")
		'
		'toolStripSeparator9
		'
		Me.toolStripSeparator9.Name = "toolStripSeparator9"
		resources.ApplyResources(Me.toolStripSeparator9, "toolStripSeparator9")
		'
		'languageToolStripMenuItem
		'
		Me.languageToolStripMenuItem.Name = "languageToolStripMenuItem"
		resources.ApplyResources(Me.languageToolStripMenuItem, "languageToolStripMenuItem")
		'
		'toolStripSeparator11
		'
		Me.toolStripSeparator11.Name = "toolStripSeparator11"
		resources.ApplyResources(Me.toolStripSeparator11, "toolStripSeparator11")
		'
		'customizeDesktopShortcutsToolStripMenuItem
		'
		resources.ApplyResources(Me.customizeDesktopShortcutsToolStripMenuItem, "customizeDesktopShortcutsToolStripMenuItem")
		Me.customizeDesktopShortcutsToolStripMenuItem.Name = "customizeDesktopShortcutsToolStripMenuItem"
		'
		'reloadProfilesToolStripMenuItem
		'
		resources.ApplyResources(Me.reloadProfilesToolStripMenuItem, "reloadProfilesToolStripMenuItem")
		Me.reloadProfilesToolStripMenuItem.Name = "reloadProfilesToolStripMenuItem"
		'
		'helpToolStripMenuItem
		'
		Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.netProfilesWebsiteToolStripMenuItem, Me.checkForUpdatesToolStripMenuItem, Me.aboutToolStripMenuItem})
		Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
		resources.ApplyResources(Me.helpToolStripMenuItem, "helpToolStripMenuItem")
		'
		'netProfilesWebsiteToolStripMenuItem
		'
		resources.ApplyResources(Me.netProfilesWebsiteToolStripMenuItem, "netProfilesWebsiteToolStripMenuItem")
		Me.netProfilesWebsiteToolStripMenuItem.Name = "netProfilesWebsiteToolStripMenuItem"
		'
		'checkForUpdatesToolStripMenuItem
		'
		resources.ApplyResources(Me.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem")
		Me.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem"
		'
		'aboutToolStripMenuItem
		'
		resources.ApplyResources(Me.aboutToolStripMenuItem, "aboutToolStripMenuItem")
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		'
		'toolStripMain
		'
		Me.toolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonNewProfile, Me.toolStripSeparator10, Me.toolStripButtonApplyProfile, Me.toolStripSeparator2, Me.toolStripButtonCopyProfile, Me.toolStripButtonEditProfile, Me.toolStripButtonDeleteProfile})
		resources.ApplyResources(Me.toolStripMain, "toolStripMain")
		Me.toolStripMain.Name = "toolStripMain"
		'
		'toolStripButtonNewProfile
		'
		resources.ApplyResources(Me.toolStripButtonNewProfile, "toolStripButtonNewProfile")
		Me.toolStripButtonNewProfile.Name = "toolStripButtonNewProfile"
		'
		'toolStripSeparator10
		'
		Me.toolStripSeparator10.Name = "toolStripSeparator10"
		resources.ApplyResources(Me.toolStripSeparator10, "toolStripSeparator10")
		'
		'toolStripButtonApplyProfile
		'
		resources.ApplyResources(Me.toolStripButtonApplyProfile, "toolStripButtonApplyProfile")
		Me.toolStripButtonApplyProfile.Name = "toolStripButtonApplyProfile"
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
		'
		'toolStripButtonCopyProfile
		'
		resources.ApplyResources(Me.toolStripButtonCopyProfile, "toolStripButtonCopyProfile")
		Me.toolStripButtonCopyProfile.Name = "toolStripButtonCopyProfile"
		'
		'toolStripButtonEditProfile
		'
		resources.ApplyResources(Me.toolStripButtonEditProfile, "toolStripButtonEditProfile")
		Me.toolStripButtonEditProfile.Name = "toolStripButtonEditProfile"
		'
		'toolStripButtonDeleteProfile
		'
		resources.ApplyResources(Me.toolStripButtonDeleteProfile, "toolStripButtonDeleteProfile")
		Me.toolStripButtonDeleteProfile.Name = "toolStripButtonDeleteProfile"
		'
		'statusStrip1
		'
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripProgressBar1, Me.toolStripStatusLabelProgress, Me.toolStripStatusLabelWorking, Me.toolStripStatusLabel1})
		resources.ApplyResources(Me.statusStrip1, "statusStrip1")
		Me.statusStrip1.Name = "statusStrip1"
		'
		'toolStripProgressBar1
		'
		Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
		resources.ApplyResources(Me.toolStripProgressBar1, "toolStripProgressBar1")
		Me.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		'
		'toolStripStatusLabelProgress
		'
		Me.toolStripStatusLabelProgress.Name = "toolStripStatusLabelProgress"
		resources.ApplyResources(Me.toolStripStatusLabelProgress, "toolStripStatusLabelProgress")
		'
		'toolStripStatusLabelWorking
		'
		Me.toolStripStatusLabelWorking.Name = "toolStripStatusLabelWorking"
		resources.ApplyResources(Me.toolStripStatusLabelWorking, "toolStripStatusLabelWorking")
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		resources.ApplyResources(Me.toolStripStatusLabel1, "toolStripStatusLabel1")
		Me.toolStripStatusLabel1.Spring = true
		'
		'imageListProfiles
		'
		Me.imageListProfiles.ImageStream = CType(resources.GetObject("imageListProfiles.ImageStream"),System.Windows.Forms.ImageListStreamer)
		Me.imageListProfiles.TransparentColor = System.Drawing.Color.Transparent
		Me.imageListProfiles.Images.SetKeyName(0, "rasdlg_dll_Ico27_ico_Ico1.ico")
		Me.imageListProfiles.Images.SetKeyName(1, "xpsp2res_2021.ico")
		Me.imageListProfiles.Images.SetKeyName(2, "irprops_151.ico")
		'
		'listViewProfiles
		'
		Me.listViewProfiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderName, Me.columnHeaderIPAddress})
		Me.listViewProfiles.ContextMenuStrip = Me.contextMenuStripProfiles
		resources.ApplyResources(Me.listViewProfiles, "listViewProfiles")
		Me.listViewProfiles.GridLines = true
		Me.listViewProfiles.LargeImageList = Me.imageListProfiles
		Me.listViewProfiles.MultiSelect = false
		Me.listViewProfiles.Name = "listViewProfiles"
		Me.listViewProfiles.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.listViewProfiles.UseCompatibleStateImageBehavior = false
		Me.listViewProfiles.View = System.Windows.Forms.View.Tile
		'
		'columnHeaderName
		'
		resources.ApplyResources(Me.columnHeaderName, "columnHeaderName")
		'
		'columnHeaderIPAddress
		'
		resources.ApplyResources(Me.columnHeaderIPAddress, "columnHeaderIPAddress")
		'
		'contextMenuStripProfiles
		'
		Me.contextMenuStripProfiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.applyProfileToolStripMenuItem, Me.activateOnDifferentNetworkCardToolStripMenuItem, Me.toolStripSeparator4, Me.copyToolStripMenuItem, Me.editToolStripMenuItem, Me.deleteToolStripMenuItem, Me.toolStripSeparator8, Me.createDesktopShortcutToolStripMenuItem})
		Me.contextMenuStripProfiles.Name = "contextMenuStripProfiles"
		resources.ApplyResources(Me.contextMenuStripProfiles, "contextMenuStripProfiles")
		'
		'applyProfileToolStripMenuItem
		'
		resources.ApplyResources(Me.applyProfileToolStripMenuItem, "applyProfileToolStripMenuItem")
		Me.applyProfileToolStripMenuItem.Name = "applyProfileToolStripMenuItem"
		'
		'activateOnDifferentNetworkCardToolStripMenuItem
		'
		resources.ApplyResources(Me.activateOnDifferentNetworkCardToolStripMenuItem, "activateOnDifferentNetworkCardToolStripMenuItem")
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Name = "activateOnDifferentNetworkCardToolStripMenuItem"
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		resources.ApplyResources(Me.toolStripSeparator4, "toolStripSeparator4")
		'
		'copyToolStripMenuItem
		'
		resources.ApplyResources(Me.copyToolStripMenuItem, "copyToolStripMenuItem")
		Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
		'
		'editToolStripMenuItem
		'
		resources.ApplyResources(Me.editToolStripMenuItem, "editToolStripMenuItem")
		Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
		'
		'deleteToolStripMenuItem
		'
		resources.ApplyResources(Me.deleteToolStripMenuItem, "deleteToolStripMenuItem")
		Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
		'
		'toolStripSeparator8
		'
		Me.toolStripSeparator8.Name = "toolStripSeparator8"
		resources.ApplyResources(Me.toolStripSeparator8, "toolStripSeparator8")
		'
		'createDesktopShortcutToolStripMenuItem
		'
		resources.ApplyResources(Me.createDesktopShortcutToolStripMenuItem, "createDesktopShortcutToolStripMenuItem")
		Me.createDesktopShortcutToolStripMenuItem.Name = "createDesktopShortcutToolStripMenuItem"
		'
		'notifyIcon1
		'
		Me.notifyIcon1.ContextMenuStrip = Me.contextMenuStripSystemTray
		resources.ApplyResources(Me.notifyIcon1, "notifyIcon1")
		'
		'contextMenuStripSystemTray
		'
		Me.contextMenuStripSystemTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showHideWindowToolStripMenuItem, Me.profilesToolStripMenuItem, Me.toolStripSeparator5, Me.exitToolStripMenuItem1})
		Me.contextMenuStripSystemTray.Name = "contextMenuStripSystemTray"
		resources.ApplyResources(Me.contextMenuStripSystemTray, "contextMenuStripSystemTray")
		'
		'showHideWindowToolStripMenuItem
		'
		resources.ApplyResources(Me.showHideWindowToolStripMenuItem, "showHideWindowToolStripMenuItem")
		Me.showHideWindowToolStripMenuItem.Name = "showHideWindowToolStripMenuItem"
		'
		'profilesToolStripMenuItem
		'
		resources.ApplyResources(Me.profilesToolStripMenuItem, "profilesToolStripMenuItem")
		Me.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		resources.ApplyResources(Me.toolStripSeparator5, "toolStripSeparator5")
		'
		'exitToolStripMenuItem1
		'
		resources.ApplyResources(Me.exitToolStripMenuItem1, "exitToolStripMenuItem1")
		Me.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1"
		'
		'pictureBoxWallpaper
		'
		resources.ApplyResources(Me.pictureBoxWallpaper, "pictureBoxWallpaper")
		Me.pictureBoxWallpaper.Name = "pictureBoxWallpaper"
		Me.pictureBoxWallpaper.TabStop = false
		'
		'backgroundWorkerScanAdapters
		'
		Me.backgroundWorkerScanAdapters.WorkerReportsProgress = true
		AddHandler Me.backgroundWorkerScanAdapters.DoWork, AddressOf Me.BackgroundWorkerScanAdaptersDoWork
		AddHandler Me.backgroundWorkerScanAdapters.ProgressChanged, AddressOf Me.BackgroundWorkerScanAdaptersProgressChanged
		'
		'backgroundWorkerApplyProfile
		'
		Me.backgroundWorkerApplyProfile.WorkerReportsProgress = true
		Me.backgroundWorkerApplyProfile.WorkerSupportsCancellation = true
		AddHandler Me.backgroundWorkerApplyProfile.DoWork, AddressOf Me.BackgroundWorkerApplyProfileDoWork
		AddHandler Me.backgroundWorkerApplyProfile.ProgressChanged, AddressOf Me.BackgroundWorkerApplyProfileProgressChanged
		AddHandler Me.backgroundWorkerApplyProfile.RunWorkerCompleted, AddressOf Me.BackgroundWorkerApplyProfileRunWorkerCompleted
		'
		'MainForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pictureBoxWallpaper)
		Me.Controls.Add(Me.listViewProfiles)
		Me.Controls.Add(Me.toolStripMain)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.toolStripMain.ResumeLayout(false)
		Me.toolStripMain.PerformLayout
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.contextMenuStripProfiles.ResumeLayout(false)
		Me.contextMenuStripSystemTray.ResumeLayout(false)
		CType(Me.pictureBoxWallpaper,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
    End Sub
	Private backgroundWorkerApplyProfile As System.ComponentModel.BackgroundWorker
	Private backgroundWorkerScanAdapters As System.ComponentModel.BackgroundWorker
	Private WithEvents toolStripButtonCopyProfile As System.Windows.Forms.ToolStripButton
	Private WithEvents toolStripMenuItemCopyProfile As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private languageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents netProfilesWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents runWhenILogInToWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents dontAskBeforeRestartingFirefoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents minimizeToTrayOnStartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents confirmSettingsAfterChangingResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents askBeforeChangingResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private screenResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public pictureBoxWallpaper As System.Windows.Forms.PictureBox
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents activateOnDifferentNetworkCardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents activateOnDifferentNetworkCardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents createDesktopShortcutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents reloadProfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents customizeDesktopShortcutsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents createDesktopShortcutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents minimizeToTrayOnCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents applyProfileToolStripMenuItemApplyProfile As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents deleteToolStripMenuItemDeleteProfile As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripMenuItemEditProfile As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripMenuItemNewProfile As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents exitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private profilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents showHideWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private contextMenuStripSystemTray As System.Windows.Forms.ContextMenuStrip
	Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon
	Private WithEvents deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents applyProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents contextMenuStripProfiles As System.Windows.Forms.ContextMenuStrip
	Public toolStripStatusLabelWorking As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
	Private WithEvents timerUpdateAdapters As System.Windows.Forms.Timer
	Private columnHeaderIPAddress As System.Windows.Forms.ColumnHeader
	Private columnHeaderName As System.Windows.Forms.ColumnHeader
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private WithEvents toggleToolbarTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public toolStripMain As System.Windows.Forms.ToolStrip
	Private toolStripStatusLabelProgress As System.Windows.Forms.ToolStripStatusLabel
	Private imageListProfiles As System.Windows.Forms.ImageList
	Public WithEvents listViewProfiles As System.Windows.Forms.ListView
	Private WithEvents toolStripButtonApplyProfile As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents checkForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripButtonNewProfile As System.Windows.Forms.ToolStripButton
	Private WithEvents toolStripButtonEditProfile As System.Windows.Forms.ToolStripButton
	Private WithEvents toolStripButtonDeleteProfile As System.Windows.Forms.ToolStripButton
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
