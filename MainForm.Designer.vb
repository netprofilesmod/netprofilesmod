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
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip
		Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripMenuItemNewProfile = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.applyProfileToolStripMenuItemApplyProfile = New System.Windows.Forms.ToolStripMenuItem
		Me.activateOnDifferentNetworkCardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
		Me.toolStripMenuItemCopyProfile = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripMenuItemEditProfile = New System.Windows.Forms.ToolStripMenuItem
		Me.deleteToolStripMenuItemDeleteProfile = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
		Me.createDesktopShortcutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toggleToolbarTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.minimizeToTrayOnCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.minimizeToTrayOnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.screenResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.askBeforeChangingResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.runWhenILogInToWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
		Me.languageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
		Me.customizeDesktopShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.reloadNetworkInterfacesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.reloadProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.netProfilesWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.checkForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripMain = New System.Windows.Forms.ToolStrip
		Me.toolStripButtonNewProfile = New System.Windows.Forms.ToolStripButton
		Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
		Me.toolStripButtonApplyProfile = New System.Windows.Forms.ToolStripButton
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.toolStripButtonCopyProfile = New System.Windows.Forms.ToolStripButton
		Me.toolStripButtonEditProfile = New System.Windows.Forms.ToolStripButton
		Me.toolStripButtonDeleteProfile = New System.Windows.Forms.ToolStripButton
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip
		Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
		Me.toolStripStatusLabelProgress = New System.Windows.Forms.ToolStripStatusLabel
		Me.toolStripStatusLabelWorking = New System.Windows.Forms.ToolStripStatusLabel
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me.imageListProfiles = New System.Windows.Forms.ImageList(Me.components)
		Me.listViewProfiles = New System.Windows.Forms.ListView
		Me.columnHeaderName = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderIPAddress = New System.Windows.Forms.ColumnHeader
		Me.contextMenuStripProfiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.applyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.activateOnDifferentNetworkCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
		Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
		Me.createDesktopShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.timerLoad = New System.Windows.Forms.Timer(Me.components)
		Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.contextMenuStripSystemTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.showHideWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.profilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
		Me.exitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
		Me.pictureBoxWallpaper = New System.Windows.Forms.PictureBox
		Me.messageBoxManager1 = New MessageBoxManager
		Me.timerDetectWireless = New System.Windows.Forms.Timer(Me.components)
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
		Me.menuStrip1.AccessibleDescription = Nothing
		Me.menuStrip1.AccessibleName = Nothing
		Me.menuStrip1.Anchor = CType(resources.GetObject("menuStrip1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.menuStrip1.AutoSize = CType(resources.GetObject("menuStrip1.AutoSize"),Boolean)
		Me.menuStrip1.BackgroundImage = Nothing
		Me.menuStrip1.BackgroundImageLayout = CType(resources.GetObject("menuStrip1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.menuStrip1.Dock = CType(resources.GetObject("menuStrip1.Dock"),System.Windows.Forms.DockStyle)
		Me.menuStrip1.Font = Nothing
		Me.menuStrip1.ImeMode = CType(resources.GetObject("menuStrip1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.optionsToolStripMenuItem, Me.helpToolStripMenuItem})
		Me.menuStrip1.Location = CType(resources.GetObject("menuStrip1.Location"),System.Drawing.Point)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.RightToLeft = CType(resources.GetObject("menuStrip1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.menuStrip1.Size = CType(resources.GetObject("menuStrip1.Size"),System.Drawing.Size)
		Me.menuStrip1.TabIndex = CType(resources.GetObject("menuStrip1.TabIndex"),Integer)
		Me.menuStrip1.Text = resources.GetString("menuStrip1.Text")
		Me.toolTip1.SetToolTip(Me.menuStrip1, resources.GetString("menuStrip1.ToolTip"))
		'
		'fileToolStripMenuItem
		'
		Me.fileToolStripMenuItem.AccessibleDescription = Nothing
		Me.fileToolStripMenuItem.AccessibleName = Nothing
		Me.fileToolStripMenuItem.AutoSize = CType(resources.GetObject("fileToolStripMenuItem.AutoSize"),Boolean)
		Me.fileToolStripMenuItem.BackgroundImage = Nothing
		Me.fileToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("fileToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemNewProfile, Me.toolStripSeparator1, Me.applyProfileToolStripMenuItemApplyProfile, Me.activateOnDifferentNetworkCardToolStripMenuItem1, Me.toolStripSeparator3, Me.toolStripMenuItemCopyProfile, Me.toolStripMenuItemEditProfile, Me.deleteToolStripMenuItemDeleteProfile, Me.toolStripSeparator6, Me.createDesktopShortcutToolStripMenuItem1, Me.toolStripSeparator7, Me.exitToolStripMenuItem})
		Me.fileToolStripMenuItem.Enabled = CType(resources.GetObject("fileToolStripMenuItem.Enabled"),Boolean)
		Me.fileToolStripMenuItem.ImageAlign = CType(resources.GetObject("fileToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.fileToolStripMenuItem.ImageScaling = CType(resources.GetObject("fileToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
		Me.fileToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("fileToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.fileToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.fileToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("fileToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.fileToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("fileToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.fileToolStripMenuItem.Size = CType(resources.GetObject("fileToolStripMenuItem.Size"),System.Drawing.Size)
		Me.fileToolStripMenuItem.Text = resources.GetString("fileToolStripMenuItem.Text")
		Me.fileToolStripMenuItem.TextAlign = CType(resources.GetObject("fileToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.fileToolStripMenuItem.TextImageRelation = CType(resources.GetObject("fileToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.fileToolStripMenuItem.DropDownOpening, AddressOf Me.FileToolStripMenuItemDropDownOpening
		'
		'toolStripMenuItemNewProfile
		'
		Me.toolStripMenuItemNewProfile.AccessibleDescription = Nothing
		Me.toolStripMenuItemNewProfile.AccessibleName = Nothing
		Me.toolStripMenuItemNewProfile.AutoSize = CType(resources.GetObject("toolStripMenuItemNewProfile.AutoSize"),Boolean)
		Me.toolStripMenuItemNewProfile.BackgroundImage = Nothing
		Me.toolStripMenuItemNewProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripMenuItemNewProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripMenuItemNewProfile.Enabled = CType(resources.GetObject("toolStripMenuItemNewProfile.Enabled"),Boolean)
		Me.toolStripMenuItemNewProfile.Image = CType(resources.GetObject("toolStripMenuItemNewProfile.Image"),System.Drawing.Image)
		Me.toolStripMenuItemNewProfile.ImageAlign = CType(resources.GetObject("toolStripMenuItemNewProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripMenuItemNewProfile.ImageScaling = CType(resources.GetObject("toolStripMenuItemNewProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripMenuItemNewProfile.Name = "toolStripMenuItemNewProfile"
		Me.toolStripMenuItemNewProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripMenuItemNewProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripMenuItemNewProfile.ShortcutKeyDisplayString = Nothing
		Me.toolStripMenuItemNewProfile.ShortcutKeys = CType(resources.GetObject("toolStripMenuItemNewProfile.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.toolStripMenuItemNewProfile.ShowShortcutKeys = CType(resources.GetObject("toolStripMenuItemNewProfile.ShowShortcutKeys"),Boolean)
		Me.toolStripMenuItemNewProfile.Size = CType(resources.GetObject("toolStripMenuItemNewProfile.Size"),System.Drawing.Size)
		Me.toolStripMenuItemNewProfile.Text = resources.GetString("toolStripMenuItemNewProfile.Text")
		Me.toolStripMenuItemNewProfile.TextAlign = CType(resources.GetObject("toolStripMenuItemNewProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripMenuItemNewProfile.TextImageRelation = CType(resources.GetObject("toolStripMenuItemNewProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripMenuItemNewProfile.Click, AddressOf Me.ToolStripMenuItemNewProfileClick
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.AccessibleDescription = Nothing
		Me.toolStripSeparator1.AccessibleName = Nothing
		Me.toolStripSeparator1.AutoSize = CType(resources.GetObject("toolStripSeparator1.AutoSize"),Boolean)
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = CType(resources.GetObject("toolStripSeparator1.Size"),System.Drawing.Size)
		'
		'applyProfileToolStripMenuItemApplyProfile
		'
		Me.applyProfileToolStripMenuItemApplyProfile.AccessibleDescription = Nothing
		Me.applyProfileToolStripMenuItemApplyProfile.AccessibleName = Nothing
		Me.applyProfileToolStripMenuItemApplyProfile.AutoSize = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.AutoSize"),Boolean)
		Me.applyProfileToolStripMenuItemApplyProfile.BackgroundImage = Nothing
		Me.applyProfileToolStripMenuItemApplyProfile.BackgroundImageLayout = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.applyProfileToolStripMenuItemApplyProfile.Enabled = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.Enabled"),Boolean)
		Me.applyProfileToolStripMenuItemApplyProfile.Image = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.Image"),System.Drawing.Image)
		Me.applyProfileToolStripMenuItemApplyProfile.ImageAlign = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.applyProfileToolStripMenuItemApplyProfile.ImageScaling = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.applyProfileToolStripMenuItemApplyProfile.Name = "applyProfileToolStripMenuItemApplyProfile"
		Me.applyProfileToolStripMenuItemApplyProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.applyProfileToolStripMenuItemApplyProfile.ShortcutKeyDisplayString = Nothing
		Me.applyProfileToolStripMenuItemApplyProfile.ShortcutKeys = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.applyProfileToolStripMenuItemApplyProfile.ShowShortcutKeys = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.ShowShortcutKeys"),Boolean)
		Me.applyProfileToolStripMenuItemApplyProfile.Size = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.Size"),System.Drawing.Size)
		Me.applyProfileToolStripMenuItemApplyProfile.Text = resources.GetString("applyProfileToolStripMenuItemApplyProfile.Text")
		Me.applyProfileToolStripMenuItemApplyProfile.TextAlign = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.applyProfileToolStripMenuItemApplyProfile.TextImageRelation = CType(resources.GetObject("applyProfileToolStripMenuItemApplyProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.applyProfileToolStripMenuItemApplyProfile.Click, AddressOf Me.ApplyProfileToolStripMenuItemApplyProfileClick
		'
		'activateOnDifferentNetworkCardToolStripMenuItem1
		'
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.AccessibleDescription = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.AccessibleName = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.AutoSize = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.AutoSize"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.BackgroundImage = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.BackgroundImageLayout = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Enabled = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.Enabled"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Image = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.Image"),System.Drawing.Image)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.ImageAlign = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.ImageAlign"),System.Drawing.ContentAlignment)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.ImageScaling = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Name = "activateOnDifferentNetworkCardToolStripMenuItem1"
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.RightToLeftAutoMirrorImage = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.RightToLeftAutoMirrorImage"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.ShortcutKeyDisplayString = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.ShortcutKeys = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.ShowShortcutKeys = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.ShowShortcutKeys"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Size = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.Size"),System.Drawing.Size)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.Text = resources.GetString("activateOnDifferentNetworkCardToolStripMenuItem1.Text")
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.TextAlign = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.TextAlign"),System.Drawing.ContentAlignment)
		Me.activateOnDifferentNetworkCardToolStripMenuItem1.TextImageRelation = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem1.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.activateOnDifferentNetworkCardToolStripMenuItem1.Click, AddressOf Me.ActivateOnDifferentNetworkCardToolStripMenuItem1Click
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.AccessibleDescription = Nothing
		Me.toolStripSeparator3.AccessibleName = Nothing
		Me.toolStripSeparator3.AutoSize = CType(resources.GetObject("toolStripSeparator3.AutoSize"),Boolean)
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = CType(resources.GetObject("toolStripSeparator3.Size"),System.Drawing.Size)
		'
		'toolStripMenuItemCopyProfile
		'
		Me.toolStripMenuItemCopyProfile.AccessibleDescription = Nothing
		Me.toolStripMenuItemCopyProfile.AccessibleName = Nothing
		Me.toolStripMenuItemCopyProfile.AutoSize = CType(resources.GetObject("toolStripMenuItemCopyProfile.AutoSize"),Boolean)
		Me.toolStripMenuItemCopyProfile.BackgroundImage = Nothing
		Me.toolStripMenuItemCopyProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripMenuItemCopyProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripMenuItemCopyProfile.Enabled = CType(resources.GetObject("toolStripMenuItemCopyProfile.Enabled"),Boolean)
		Me.toolStripMenuItemCopyProfile.Image = CType(resources.GetObject("toolStripMenuItemCopyProfile.Image"),System.Drawing.Image)
		Me.toolStripMenuItemCopyProfile.ImageAlign = CType(resources.GetObject("toolStripMenuItemCopyProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripMenuItemCopyProfile.ImageScaling = CType(resources.GetObject("toolStripMenuItemCopyProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripMenuItemCopyProfile.Name = "toolStripMenuItemCopyProfile"
		Me.toolStripMenuItemCopyProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripMenuItemCopyProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripMenuItemCopyProfile.ShortcutKeyDisplayString = Nothing
		Me.toolStripMenuItemCopyProfile.ShortcutKeys = CType(resources.GetObject("toolStripMenuItemCopyProfile.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.toolStripMenuItemCopyProfile.ShowShortcutKeys = CType(resources.GetObject("toolStripMenuItemCopyProfile.ShowShortcutKeys"),Boolean)
		Me.toolStripMenuItemCopyProfile.Size = CType(resources.GetObject("toolStripMenuItemCopyProfile.Size"),System.Drawing.Size)
		Me.toolStripMenuItemCopyProfile.Text = resources.GetString("toolStripMenuItemCopyProfile.Text")
		Me.toolStripMenuItemCopyProfile.TextAlign = CType(resources.GetObject("toolStripMenuItemCopyProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripMenuItemCopyProfile.TextImageRelation = CType(resources.GetObject("toolStripMenuItemCopyProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripMenuItemCopyProfile.Click, AddressOf Me.toolStripMenuItemCopyProfileClick
		'
		'toolStripMenuItemEditProfile
		'
		Me.toolStripMenuItemEditProfile.AccessibleDescription = Nothing
		Me.toolStripMenuItemEditProfile.AccessibleName = Nothing
		Me.toolStripMenuItemEditProfile.AutoSize = CType(resources.GetObject("toolStripMenuItemEditProfile.AutoSize"),Boolean)
		Me.toolStripMenuItemEditProfile.BackgroundImage = Nothing
		Me.toolStripMenuItemEditProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripMenuItemEditProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripMenuItemEditProfile.Enabled = CType(resources.GetObject("toolStripMenuItemEditProfile.Enabled"),Boolean)
		Me.toolStripMenuItemEditProfile.Image = CType(resources.GetObject("toolStripMenuItemEditProfile.Image"),System.Drawing.Image)
		Me.toolStripMenuItemEditProfile.ImageAlign = CType(resources.GetObject("toolStripMenuItemEditProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripMenuItemEditProfile.ImageScaling = CType(resources.GetObject("toolStripMenuItemEditProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripMenuItemEditProfile.Name = "toolStripMenuItemEditProfile"
		Me.toolStripMenuItemEditProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripMenuItemEditProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripMenuItemEditProfile.ShortcutKeyDisplayString = Nothing
		Me.toolStripMenuItemEditProfile.ShortcutKeys = CType(resources.GetObject("toolStripMenuItemEditProfile.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.toolStripMenuItemEditProfile.ShowShortcutKeys = CType(resources.GetObject("toolStripMenuItemEditProfile.ShowShortcutKeys"),Boolean)
		Me.toolStripMenuItemEditProfile.Size = CType(resources.GetObject("toolStripMenuItemEditProfile.Size"),System.Drawing.Size)
		Me.toolStripMenuItemEditProfile.Text = resources.GetString("toolStripMenuItemEditProfile.Text")
		Me.toolStripMenuItemEditProfile.TextAlign = CType(resources.GetObject("toolStripMenuItemEditProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripMenuItemEditProfile.TextImageRelation = CType(resources.GetObject("toolStripMenuItemEditProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripMenuItemEditProfile.Click, AddressOf Me.ToolStripMenuItemEditProfileClick
		'
		'deleteToolStripMenuItemDeleteProfile
		'
		Me.deleteToolStripMenuItemDeleteProfile.AccessibleDescription = Nothing
		Me.deleteToolStripMenuItemDeleteProfile.AccessibleName = Nothing
		Me.deleteToolStripMenuItemDeleteProfile.AutoSize = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.AutoSize"),Boolean)
		Me.deleteToolStripMenuItemDeleteProfile.BackgroundImage = Nothing
		Me.deleteToolStripMenuItemDeleteProfile.BackgroundImageLayout = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.deleteToolStripMenuItemDeleteProfile.Enabled = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.Enabled"),Boolean)
		Me.deleteToolStripMenuItemDeleteProfile.Image = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.Image"),System.Drawing.Image)
		Me.deleteToolStripMenuItemDeleteProfile.ImageAlign = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.deleteToolStripMenuItemDeleteProfile.ImageScaling = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.deleteToolStripMenuItemDeleteProfile.Name = "deleteToolStripMenuItemDeleteProfile"
		Me.deleteToolStripMenuItemDeleteProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.deleteToolStripMenuItemDeleteProfile.ShortcutKeyDisplayString = Nothing
		Me.deleteToolStripMenuItemDeleteProfile.ShortcutKeys = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.deleteToolStripMenuItemDeleteProfile.ShowShortcutKeys = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.ShowShortcutKeys"),Boolean)
		Me.deleteToolStripMenuItemDeleteProfile.Size = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.Size"),System.Drawing.Size)
		Me.deleteToolStripMenuItemDeleteProfile.Text = resources.GetString("deleteToolStripMenuItemDeleteProfile.Text")
		Me.deleteToolStripMenuItemDeleteProfile.TextAlign = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.deleteToolStripMenuItemDeleteProfile.TextImageRelation = CType(resources.GetObject("deleteToolStripMenuItemDeleteProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.deleteToolStripMenuItemDeleteProfile.Click, AddressOf Me.DeleteToolStripMenuItemDeleteProfileClick
		'
		'toolStripSeparator6
		'
		Me.toolStripSeparator6.AccessibleDescription = Nothing
		Me.toolStripSeparator6.AccessibleName = Nothing
		Me.toolStripSeparator6.AutoSize = CType(resources.GetObject("toolStripSeparator6.AutoSize"),Boolean)
		Me.toolStripSeparator6.Name = "toolStripSeparator6"
		Me.toolStripSeparator6.Size = CType(resources.GetObject("toolStripSeparator6.Size"),System.Drawing.Size)
		'
		'createDesktopShortcutToolStripMenuItem1
		'
		Me.createDesktopShortcutToolStripMenuItem1.AccessibleDescription = Nothing
		Me.createDesktopShortcutToolStripMenuItem1.AccessibleName = Nothing
		Me.createDesktopShortcutToolStripMenuItem1.AutoSize = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.AutoSize"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem1.BackgroundImage = Nothing
		Me.createDesktopShortcutToolStripMenuItem1.BackgroundImageLayout = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.createDesktopShortcutToolStripMenuItem1.Enabled = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.Enabled"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem1.Image = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.Image"),System.Drawing.Image)
		Me.createDesktopShortcutToolStripMenuItem1.ImageAlign = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.ImageAlign"),System.Drawing.ContentAlignment)
		Me.createDesktopShortcutToolStripMenuItem1.ImageScaling = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.createDesktopShortcutToolStripMenuItem1.Name = "createDesktopShortcutToolStripMenuItem1"
		Me.createDesktopShortcutToolStripMenuItem1.RightToLeftAutoMirrorImage = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.RightToLeftAutoMirrorImage"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem1.ShortcutKeyDisplayString = Nothing
		Me.createDesktopShortcutToolStripMenuItem1.ShortcutKeys = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.createDesktopShortcutToolStripMenuItem1.ShowShortcutKeys = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.ShowShortcutKeys"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem1.Size = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.Size"),System.Drawing.Size)
		Me.createDesktopShortcutToolStripMenuItem1.Text = resources.GetString("createDesktopShortcutToolStripMenuItem1.Text")
		Me.createDesktopShortcutToolStripMenuItem1.TextAlign = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.TextAlign"),System.Drawing.ContentAlignment)
		Me.createDesktopShortcutToolStripMenuItem1.TextImageRelation = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem1.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.createDesktopShortcutToolStripMenuItem1.Click, AddressOf Me.CreateDesktopShortcutToolStripMenuItem1Click
		'
		'toolStripSeparator7
		'
		Me.toolStripSeparator7.AccessibleDescription = Nothing
		Me.toolStripSeparator7.AccessibleName = Nothing
		Me.toolStripSeparator7.AutoSize = CType(resources.GetObject("toolStripSeparator7.AutoSize"),Boolean)
		Me.toolStripSeparator7.Name = "toolStripSeparator7"
		Me.toolStripSeparator7.Size = CType(resources.GetObject("toolStripSeparator7.Size"),System.Drawing.Size)
		'
		'exitToolStripMenuItem
		'
		Me.exitToolStripMenuItem.AccessibleDescription = Nothing
		Me.exitToolStripMenuItem.AccessibleName = Nothing
		Me.exitToolStripMenuItem.AutoSize = CType(resources.GetObject("exitToolStripMenuItem.AutoSize"),Boolean)
		Me.exitToolStripMenuItem.BackgroundImage = Nothing
		Me.exitToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("exitToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.exitToolStripMenuItem.Enabled = CType(resources.GetObject("exitToolStripMenuItem.Enabled"),Boolean)
		Me.exitToolStripMenuItem.Image = CType(resources.GetObject("exitToolStripMenuItem.Image"),System.Drawing.Image)
		Me.exitToolStripMenuItem.ImageAlign = CType(resources.GetObject("exitToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.exitToolStripMenuItem.ImageScaling = CType(resources.GetObject("exitToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		Me.exitToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("exitToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.exitToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.exitToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("exitToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.exitToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("exitToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.exitToolStripMenuItem.Size = CType(resources.GetObject("exitToolStripMenuItem.Size"),System.Drawing.Size)
		Me.exitToolStripMenuItem.Text = resources.GetString("exitToolStripMenuItem.Text")
		Me.exitToolStripMenuItem.TextAlign = CType(resources.GetObject("exitToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.exitToolStripMenuItem.TextImageRelation = CType(resources.GetObject("exitToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.ExitToolStripMenuItemClick
		'
		'optionsToolStripMenuItem
		'
		Me.optionsToolStripMenuItem.AccessibleDescription = Nothing
		Me.optionsToolStripMenuItem.AccessibleName = Nothing
		Me.optionsToolStripMenuItem.AutoSize = CType(resources.GetObject("optionsToolStripMenuItem.AutoSize"),Boolean)
		Me.optionsToolStripMenuItem.BackgroundImage = Nothing
		Me.optionsToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("optionsToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.optionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toggleToolbarTextToolStripMenuItem, Me.minimizeToTrayOnCloseToolStripMenuItem, Me.minimizeToTrayOnStartupToolStripMenuItem, Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem, Me.screenResolutionToolStripMenuItem, Me.runWhenILogInToWindowsToolStripMenuItem, Me.toolStripSeparator9, Me.languageToolStripMenuItem, Me.toolStripSeparator11, Me.customizeDesktopShortcutsToolStripMenuItem, Me.reloadNetworkInterfacesToolStripMenuItem, Me.reloadProfilesToolStripMenuItem})
		Me.optionsToolStripMenuItem.Enabled = CType(resources.GetObject("optionsToolStripMenuItem.Enabled"),Boolean)
		Me.optionsToolStripMenuItem.ImageAlign = CType(resources.GetObject("optionsToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.optionsToolStripMenuItem.ImageScaling = CType(resources.GetObject("optionsToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
		Me.optionsToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("optionsToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.optionsToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.optionsToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("optionsToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.optionsToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("optionsToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.optionsToolStripMenuItem.Size = CType(resources.GetObject("optionsToolStripMenuItem.Size"),System.Drawing.Size)
		Me.optionsToolStripMenuItem.Text = resources.GetString("optionsToolStripMenuItem.Text")
		Me.optionsToolStripMenuItem.TextAlign = CType(resources.GetObject("optionsToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.optionsToolStripMenuItem.TextImageRelation = CType(resources.GetObject("optionsToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		'
		'toggleToolbarTextToolStripMenuItem
		'
		Me.toggleToolbarTextToolStripMenuItem.AccessibleDescription = Nothing
		Me.toggleToolbarTextToolStripMenuItem.AccessibleName = Nothing
		Me.toggleToolbarTextToolStripMenuItem.AutoSize = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.AutoSize"),Boolean)
		Me.toggleToolbarTextToolStripMenuItem.BackgroundImage = Nothing
		Me.toggleToolbarTextToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toggleToolbarTextToolStripMenuItem.Checked = true
		Me.toggleToolbarTextToolStripMenuItem.CheckOnClick = true
		Me.toggleToolbarTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.toggleToolbarTextToolStripMenuItem.Enabled = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.Enabled"),Boolean)
		Me.toggleToolbarTextToolStripMenuItem.ImageAlign = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toggleToolbarTextToolStripMenuItem.ImageScaling = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toggleToolbarTextToolStripMenuItem.Name = "toggleToolbarTextToolStripMenuItem"
		Me.toggleToolbarTextToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.toggleToolbarTextToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.toggleToolbarTextToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.toggleToolbarTextToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.toggleToolbarTextToolStripMenuItem.Size = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.Size"),System.Drawing.Size)
		Me.toggleToolbarTextToolStripMenuItem.Text = resources.GetString("toggleToolbarTextToolStripMenuItem.Text")
		Me.toggleToolbarTextToolStripMenuItem.TextAlign = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.toggleToolbarTextToolStripMenuItem.TextImageRelation = CType(resources.GetObject("toggleToolbarTextToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toggleToolbarTextToolStripMenuItem.Click, AddressOf Me.ToggleToolbarTextToolStripMenuItemClick
		'
		'minimizeToTrayOnCloseToolStripMenuItem
		'
		Me.minimizeToTrayOnCloseToolStripMenuItem.AccessibleDescription = Nothing
		Me.minimizeToTrayOnCloseToolStripMenuItem.AccessibleName = Nothing
		Me.minimizeToTrayOnCloseToolStripMenuItem.AutoSize = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.AutoSize"),Boolean)
		Me.minimizeToTrayOnCloseToolStripMenuItem.BackgroundImage = Nothing
		Me.minimizeToTrayOnCloseToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.minimizeToTrayOnCloseToolStripMenuItem.Checked = true
		Me.minimizeToTrayOnCloseToolStripMenuItem.CheckOnClick = true
		Me.minimizeToTrayOnCloseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.minimizeToTrayOnCloseToolStripMenuItem.Enabled = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.Enabled"),Boolean)
		Me.minimizeToTrayOnCloseToolStripMenuItem.ImageAlign = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.minimizeToTrayOnCloseToolStripMenuItem.ImageScaling = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.minimizeToTrayOnCloseToolStripMenuItem.Name = "minimizeToTrayOnCloseToolStripMenuItem"
		Me.minimizeToTrayOnCloseToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.minimizeToTrayOnCloseToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.minimizeToTrayOnCloseToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.minimizeToTrayOnCloseToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.minimizeToTrayOnCloseToolStripMenuItem.Size = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.Size"),System.Drawing.Size)
		Me.minimizeToTrayOnCloseToolStripMenuItem.Text = resources.GetString("minimizeToTrayOnCloseToolStripMenuItem.Text")
		Me.minimizeToTrayOnCloseToolStripMenuItem.TextAlign = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.minimizeToTrayOnCloseToolStripMenuItem.TextImageRelation = CType(resources.GetObject("minimizeToTrayOnCloseToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.minimizeToTrayOnCloseToolStripMenuItem.Click, AddressOf Me.MinimizeToTrayOnCloseToolStripMenuItemClick
		'
		'minimizeToTrayOnStartupToolStripMenuItem
		'
		Me.minimizeToTrayOnStartupToolStripMenuItem.AccessibleDescription = Nothing
		Me.minimizeToTrayOnStartupToolStripMenuItem.AccessibleName = Nothing
		Me.minimizeToTrayOnStartupToolStripMenuItem.AutoSize = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.AutoSize"),Boolean)
		Me.minimizeToTrayOnStartupToolStripMenuItem.BackgroundImage = Nothing
		Me.minimizeToTrayOnStartupToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.minimizeToTrayOnStartupToolStripMenuItem.CheckOnClick = true
		Me.minimizeToTrayOnStartupToolStripMenuItem.Enabled = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.Enabled"),Boolean)
		Me.minimizeToTrayOnStartupToolStripMenuItem.ImageAlign = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.minimizeToTrayOnStartupToolStripMenuItem.ImageScaling = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.minimizeToTrayOnStartupToolStripMenuItem.Name = "minimizeToTrayOnStartupToolStripMenuItem"
		Me.minimizeToTrayOnStartupToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.minimizeToTrayOnStartupToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.minimizeToTrayOnStartupToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.minimizeToTrayOnStartupToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.minimizeToTrayOnStartupToolStripMenuItem.Size = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.Size"),System.Drawing.Size)
		Me.minimizeToTrayOnStartupToolStripMenuItem.Text = resources.GetString("minimizeToTrayOnStartupToolStripMenuItem.Text")
		Me.minimizeToTrayOnStartupToolStripMenuItem.TextAlign = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.minimizeToTrayOnStartupToolStripMenuItem.TextImageRelation = CType(resources.GetObject("minimizeToTrayOnStartupToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.minimizeToTrayOnStartupToolStripMenuItem.Click, AddressOf Me.MinimizeToTrayOnStartupToolStripMenuItemClick
		'
		'dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem
		'
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.AccessibleDescription = Nothing
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.AccessibleName = Nothing
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.AutoSize = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.AutoSize"),Boolean)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.BackgroundImage = Nothing
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.BackgroundImageLayou"& _ 
				"t"),System.Windows.Forms.ImageLayout)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.CheckOnClick = true
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Enabled = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Enabled"),Boolean)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ImageAlign = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ImageScaling = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Name = "dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem"
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.RightToLeftAutoMirro"& _ 
				"rImage"),Boolean)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Size = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Size"),System.Drawing.Size)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Text = resources.GetString("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Text")
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.TextAlign = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.TextImageRelation = CType(resources.GetObject("dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem.Click, AddressOf Me.DontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItemClick
		'
		'screenResolutionToolStripMenuItem
		'
		Me.screenResolutionToolStripMenuItem.AccessibleDescription = Nothing
		Me.screenResolutionToolStripMenuItem.AccessibleName = Nothing
		Me.screenResolutionToolStripMenuItem.AutoSize = CType(resources.GetObject("screenResolutionToolStripMenuItem.AutoSize"),Boolean)
		Me.screenResolutionToolStripMenuItem.BackgroundImage = Nothing
		Me.screenResolutionToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("screenResolutionToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.screenResolutionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.askBeforeChangingResolutionToolStripMenuItem, Me.confirmSettingsAfterChangingResolutionToolStripMenuItem})
		Me.screenResolutionToolStripMenuItem.Enabled = CType(resources.GetObject("screenResolutionToolStripMenuItem.Enabled"),Boolean)
		Me.screenResolutionToolStripMenuItem.ImageAlign = CType(resources.GetObject("screenResolutionToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.screenResolutionToolStripMenuItem.ImageScaling = CType(resources.GetObject("screenResolutionToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.screenResolutionToolStripMenuItem.Name = "screenResolutionToolStripMenuItem"
		Me.screenResolutionToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("screenResolutionToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.screenResolutionToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.screenResolutionToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("screenResolutionToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.screenResolutionToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("screenResolutionToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.screenResolutionToolStripMenuItem.Size = CType(resources.GetObject("screenResolutionToolStripMenuItem.Size"),System.Drawing.Size)
		Me.screenResolutionToolStripMenuItem.Text = resources.GetString("screenResolutionToolStripMenuItem.Text")
		Me.screenResolutionToolStripMenuItem.TextAlign = CType(resources.GetObject("screenResolutionToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.screenResolutionToolStripMenuItem.TextImageRelation = CType(resources.GetObject("screenResolutionToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		'
		'askBeforeChangingResolutionToolStripMenuItem
		'
		Me.askBeforeChangingResolutionToolStripMenuItem.AccessibleDescription = Nothing
		Me.askBeforeChangingResolutionToolStripMenuItem.AccessibleName = Nothing
		Me.askBeforeChangingResolutionToolStripMenuItem.AutoSize = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.AutoSize"),Boolean)
		Me.askBeforeChangingResolutionToolStripMenuItem.BackgroundImage = Nothing
		Me.askBeforeChangingResolutionToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.askBeforeChangingResolutionToolStripMenuItem.Checked = true
		Me.askBeforeChangingResolutionToolStripMenuItem.CheckOnClick = true
		Me.askBeforeChangingResolutionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.askBeforeChangingResolutionToolStripMenuItem.Enabled = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.Enabled"),Boolean)
		Me.askBeforeChangingResolutionToolStripMenuItem.ImageAlign = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.askBeforeChangingResolutionToolStripMenuItem.ImageScaling = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.askBeforeChangingResolutionToolStripMenuItem.Name = "askBeforeChangingResolutionToolStripMenuItem"
		Me.askBeforeChangingResolutionToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.askBeforeChangingResolutionToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.askBeforeChangingResolutionToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.askBeforeChangingResolutionToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.askBeforeChangingResolutionToolStripMenuItem.Size = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.Size"),System.Drawing.Size)
		Me.askBeforeChangingResolutionToolStripMenuItem.Text = resources.GetString("askBeforeChangingResolutionToolStripMenuItem.Text")
		Me.askBeforeChangingResolutionToolStripMenuItem.TextAlign = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.askBeforeChangingResolutionToolStripMenuItem.TextImageRelation = CType(resources.GetObject("askBeforeChangingResolutionToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.askBeforeChangingResolutionToolStripMenuItem.Click, AddressOf Me.AskBeforeChangingResolutionToolStripMenuItemClick
		'
		'confirmSettingsAfterChangingResolutionToolStripMenuItem
		'
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.AccessibleDescription = Nothing
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.AccessibleName = Nothing
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.AutoSize = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.AutoSize"),Boolean)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.BackgroundImage = Nothing
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Checked = true
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.CheckOnClick = true
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Enabled = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.Enabled"),Boolean)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.ImageAlign = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.ImageScaling = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Name = "confirmSettingsAfterChangingResolutionToolStripMenuItem"
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.RightToLeftAutoMirrorImag"& _ 
				"e"),Boolean)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Size = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.Size"),System.Drawing.Size)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Text = resources.GetString("confirmSettingsAfterChangingResolutionToolStripMenuItem.Text")
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.TextAlign = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.TextImageRelation = CType(resources.GetObject("confirmSettingsAfterChangingResolutionToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.confirmSettingsAfterChangingResolutionToolStripMenuItem.Click, AddressOf Me.ConfirmSettingsAfterChangingResolutionToolStripMenuItemClick
		'
		'runWhenILogInToWindowsToolStripMenuItem
		'
		Me.runWhenILogInToWindowsToolStripMenuItem.AccessibleDescription = Nothing
		Me.runWhenILogInToWindowsToolStripMenuItem.AccessibleName = Nothing
		Me.runWhenILogInToWindowsToolStripMenuItem.AutoSize = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.AutoSize"),Boolean)
		Me.runWhenILogInToWindowsToolStripMenuItem.BackgroundImage = Nothing
		Me.runWhenILogInToWindowsToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.runWhenILogInToWindowsToolStripMenuItem.CheckOnClick = true
		Me.runWhenILogInToWindowsToolStripMenuItem.Enabled = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.Enabled"),Boolean)
		Me.runWhenILogInToWindowsToolStripMenuItem.ImageAlign = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.runWhenILogInToWindowsToolStripMenuItem.ImageScaling = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.runWhenILogInToWindowsToolStripMenuItem.Name = "runWhenILogInToWindowsToolStripMenuItem"
		Me.runWhenILogInToWindowsToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.runWhenILogInToWindowsToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.runWhenILogInToWindowsToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.runWhenILogInToWindowsToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.runWhenILogInToWindowsToolStripMenuItem.Size = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.Size"),System.Drawing.Size)
		Me.runWhenILogInToWindowsToolStripMenuItem.Text = resources.GetString("runWhenILogInToWindowsToolStripMenuItem.Text")
		Me.runWhenILogInToWindowsToolStripMenuItem.TextAlign = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.runWhenILogInToWindowsToolStripMenuItem.TextImageRelation = CType(resources.GetObject("runWhenILogInToWindowsToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.runWhenILogInToWindowsToolStripMenuItem.Click, AddressOf Me.RunWhenILogInToWindowsToolStripMenuItemClick
		'
		'toolStripSeparator9
		'
		Me.toolStripSeparator9.AccessibleDescription = Nothing
		Me.toolStripSeparator9.AccessibleName = Nothing
		Me.toolStripSeparator9.AutoSize = CType(resources.GetObject("toolStripSeparator9.AutoSize"),Boolean)
		Me.toolStripSeparator9.Name = "toolStripSeparator9"
		Me.toolStripSeparator9.Size = CType(resources.GetObject("toolStripSeparator9.Size"),System.Drawing.Size)
		'
		'languageToolStripMenuItem
		'
		Me.languageToolStripMenuItem.AccessibleDescription = Nothing
		Me.languageToolStripMenuItem.AccessibleName = Nothing
		Me.languageToolStripMenuItem.AutoSize = CType(resources.GetObject("languageToolStripMenuItem.AutoSize"),Boolean)
		Me.languageToolStripMenuItem.BackgroundImage = Nothing
		Me.languageToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("languageToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.languageToolStripMenuItem.Enabled = CType(resources.GetObject("languageToolStripMenuItem.Enabled"),Boolean)
		Me.languageToolStripMenuItem.ImageAlign = CType(resources.GetObject("languageToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.languageToolStripMenuItem.ImageScaling = CType(resources.GetObject("languageToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.languageToolStripMenuItem.Name = "languageToolStripMenuItem"
		Me.languageToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("languageToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.languageToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.languageToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("languageToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.languageToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("languageToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.languageToolStripMenuItem.Size = CType(resources.GetObject("languageToolStripMenuItem.Size"),System.Drawing.Size)
		Me.languageToolStripMenuItem.Text = resources.GetString("languageToolStripMenuItem.Text")
		Me.languageToolStripMenuItem.TextAlign = CType(resources.GetObject("languageToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.languageToolStripMenuItem.TextImageRelation = CType(resources.GetObject("languageToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		'
		'toolStripSeparator11
		'
		Me.toolStripSeparator11.AccessibleDescription = Nothing
		Me.toolStripSeparator11.AccessibleName = Nothing
		Me.toolStripSeparator11.AutoSize = CType(resources.GetObject("toolStripSeparator11.AutoSize"),Boolean)
		Me.toolStripSeparator11.Name = "toolStripSeparator11"
		Me.toolStripSeparator11.Size = CType(resources.GetObject("toolStripSeparator11.Size"),System.Drawing.Size)
		'
		'customizeDesktopShortcutsToolStripMenuItem
		'
		Me.customizeDesktopShortcutsToolStripMenuItem.AccessibleDescription = Nothing
		Me.customizeDesktopShortcutsToolStripMenuItem.AccessibleName = Nothing
		Me.customizeDesktopShortcutsToolStripMenuItem.AutoSize = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.AutoSize"),Boolean)
		Me.customizeDesktopShortcutsToolStripMenuItem.BackgroundImage = Nothing
		Me.customizeDesktopShortcutsToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.customizeDesktopShortcutsToolStripMenuItem.Enabled = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.Enabled"),Boolean)
		Me.customizeDesktopShortcutsToolStripMenuItem.Image = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.Image"),System.Drawing.Image)
		Me.customizeDesktopShortcutsToolStripMenuItem.ImageAlign = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.customizeDesktopShortcutsToolStripMenuItem.ImageScaling = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.customizeDesktopShortcutsToolStripMenuItem.Name = "customizeDesktopShortcutsToolStripMenuItem"
		Me.customizeDesktopShortcutsToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.customizeDesktopShortcutsToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.customizeDesktopShortcutsToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.customizeDesktopShortcutsToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.customizeDesktopShortcutsToolStripMenuItem.Size = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.Size"),System.Drawing.Size)
		Me.customizeDesktopShortcutsToolStripMenuItem.Text = resources.GetString("customizeDesktopShortcutsToolStripMenuItem.Text")
		Me.customizeDesktopShortcutsToolStripMenuItem.TextAlign = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.customizeDesktopShortcutsToolStripMenuItem.TextImageRelation = CType(resources.GetObject("customizeDesktopShortcutsToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.customizeDesktopShortcutsToolStripMenuItem.Click, AddressOf Me.CustomizeDesktopShortcutsToolStripMenuItemClick
		'
		'reloadNetworkInterfacesToolStripMenuItem
		'
		Me.reloadNetworkInterfacesToolStripMenuItem.AccessibleDescription = Nothing
		Me.reloadNetworkInterfacesToolStripMenuItem.AccessibleName = Nothing
		Me.reloadNetworkInterfacesToolStripMenuItem.AutoSize = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.AutoSize"),Boolean)
		Me.reloadNetworkInterfacesToolStripMenuItem.BackgroundImage = Nothing
		Me.reloadNetworkInterfacesToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.reloadNetworkInterfacesToolStripMenuItem.Enabled = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.Enabled"),Boolean)
		Me.reloadNetworkInterfacesToolStripMenuItem.Image = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.Image"),System.Drawing.Image)
		Me.reloadNetworkInterfacesToolStripMenuItem.ImageAlign = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.reloadNetworkInterfacesToolStripMenuItem.ImageScaling = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.reloadNetworkInterfacesToolStripMenuItem.Name = "reloadNetworkInterfacesToolStripMenuItem"
		Me.reloadNetworkInterfacesToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.reloadNetworkInterfacesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.reloadNetworkInterfacesToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.reloadNetworkInterfacesToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.reloadNetworkInterfacesToolStripMenuItem.Size = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.Size"),System.Drawing.Size)
		Me.reloadNetworkInterfacesToolStripMenuItem.Text = resources.GetString("reloadNetworkInterfacesToolStripMenuItem.Text")
		Me.reloadNetworkInterfacesToolStripMenuItem.TextAlign = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.reloadNetworkInterfacesToolStripMenuItem.TextImageRelation = CType(resources.GetObject("reloadNetworkInterfacesToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.reloadNetworkInterfacesToolStripMenuItem.Click, AddressOf Me.ReloadNetworkInterfacesToolStripMenuItemClick
		'
		'reloadProfilesToolStripMenuItem
		'
		Me.reloadProfilesToolStripMenuItem.AccessibleDescription = Nothing
		Me.reloadProfilesToolStripMenuItem.AccessibleName = Nothing
		Me.reloadProfilesToolStripMenuItem.AutoSize = CType(resources.GetObject("reloadProfilesToolStripMenuItem.AutoSize"),Boolean)
		Me.reloadProfilesToolStripMenuItem.BackgroundImage = Nothing
		Me.reloadProfilesToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("reloadProfilesToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.reloadProfilesToolStripMenuItem.Enabled = CType(resources.GetObject("reloadProfilesToolStripMenuItem.Enabled"),Boolean)
		Me.reloadProfilesToolStripMenuItem.Image = CType(resources.GetObject("reloadProfilesToolStripMenuItem.Image"),System.Drawing.Image)
		Me.reloadProfilesToolStripMenuItem.ImageAlign = CType(resources.GetObject("reloadProfilesToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.reloadProfilesToolStripMenuItem.ImageScaling = CType(resources.GetObject("reloadProfilesToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.reloadProfilesToolStripMenuItem.Name = "reloadProfilesToolStripMenuItem"
		Me.reloadProfilesToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("reloadProfilesToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.reloadProfilesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.reloadProfilesToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("reloadProfilesToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.reloadProfilesToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("reloadProfilesToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.reloadProfilesToolStripMenuItem.Size = CType(resources.GetObject("reloadProfilesToolStripMenuItem.Size"),System.Drawing.Size)
		Me.reloadProfilesToolStripMenuItem.Text = resources.GetString("reloadProfilesToolStripMenuItem.Text")
		Me.reloadProfilesToolStripMenuItem.TextAlign = CType(resources.GetObject("reloadProfilesToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.reloadProfilesToolStripMenuItem.TextImageRelation = CType(resources.GetObject("reloadProfilesToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.reloadProfilesToolStripMenuItem.Click, AddressOf Me.ReloadProfilesToolStripMenuItemClick
		'
		'helpToolStripMenuItem
		'
		Me.helpToolStripMenuItem.AccessibleDescription = Nothing
		Me.helpToolStripMenuItem.AccessibleName = Nothing
		Me.helpToolStripMenuItem.AutoSize = CType(resources.GetObject("helpToolStripMenuItem.AutoSize"),Boolean)
		Me.helpToolStripMenuItem.BackgroundImage = Nothing
		Me.helpToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("helpToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.netProfilesWebsiteToolStripMenuItem, Me.checkForUpdatesToolStripMenuItem, Me.aboutToolStripMenuItem})
		Me.helpToolStripMenuItem.Enabled = CType(resources.GetObject("helpToolStripMenuItem.Enabled"),Boolean)
		Me.helpToolStripMenuItem.ImageAlign = CType(resources.GetObject("helpToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.helpToolStripMenuItem.ImageScaling = CType(resources.GetObject("helpToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
		Me.helpToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("helpToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.helpToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.helpToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("helpToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.helpToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("helpToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.helpToolStripMenuItem.Size = CType(resources.GetObject("helpToolStripMenuItem.Size"),System.Drawing.Size)
		Me.helpToolStripMenuItem.Text = resources.GetString("helpToolStripMenuItem.Text")
		Me.helpToolStripMenuItem.TextAlign = CType(resources.GetObject("helpToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.helpToolStripMenuItem.TextImageRelation = CType(resources.GetObject("helpToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		'
		'netProfilesWebsiteToolStripMenuItem
		'
		Me.netProfilesWebsiteToolStripMenuItem.AccessibleDescription = Nothing
		Me.netProfilesWebsiteToolStripMenuItem.AccessibleName = Nothing
		Me.netProfilesWebsiteToolStripMenuItem.AutoSize = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.AutoSize"),Boolean)
		Me.netProfilesWebsiteToolStripMenuItem.BackgroundImage = Nothing
		Me.netProfilesWebsiteToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.netProfilesWebsiteToolStripMenuItem.Enabled = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.Enabled"),Boolean)
		Me.netProfilesWebsiteToolStripMenuItem.Image = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.Image"),System.Drawing.Image)
		Me.netProfilesWebsiteToolStripMenuItem.ImageAlign = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.netProfilesWebsiteToolStripMenuItem.ImageScaling = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.netProfilesWebsiteToolStripMenuItem.Name = "netProfilesWebsiteToolStripMenuItem"
		Me.netProfilesWebsiteToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.netProfilesWebsiteToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.netProfilesWebsiteToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.netProfilesWebsiteToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.netProfilesWebsiteToolStripMenuItem.Size = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.Size"),System.Drawing.Size)
		Me.netProfilesWebsiteToolStripMenuItem.Text = resources.GetString("netProfilesWebsiteToolStripMenuItem.Text")
		Me.netProfilesWebsiteToolStripMenuItem.TextAlign = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.netProfilesWebsiteToolStripMenuItem.TextImageRelation = CType(resources.GetObject("netProfilesWebsiteToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.netProfilesWebsiteToolStripMenuItem.Click, AddressOf Me.NetProfilesWebsiteToolStripMenuItemClick
		'
		'checkForUpdatesToolStripMenuItem
		'
		Me.checkForUpdatesToolStripMenuItem.AccessibleDescription = Nothing
		Me.checkForUpdatesToolStripMenuItem.AccessibleName = Nothing
		Me.checkForUpdatesToolStripMenuItem.AutoSize = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.AutoSize"),Boolean)
		Me.checkForUpdatesToolStripMenuItem.BackgroundImage = Nothing
		Me.checkForUpdatesToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkForUpdatesToolStripMenuItem.Enabled = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.Enabled"),Boolean)
		Me.checkForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.Image"),System.Drawing.Image)
		Me.checkForUpdatesToolStripMenuItem.ImageAlign = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkForUpdatesToolStripMenuItem.ImageScaling = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem"
		Me.checkForUpdatesToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.checkForUpdatesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.checkForUpdatesToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.checkForUpdatesToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.checkForUpdatesToolStripMenuItem.Size = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.Size"),System.Drawing.Size)
		Me.checkForUpdatesToolStripMenuItem.Text = resources.GetString("checkForUpdatesToolStripMenuItem.Text")
		Me.checkForUpdatesToolStripMenuItem.TextAlign = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkForUpdatesToolStripMenuItem.TextImageRelation = CType(resources.GetObject("checkForUpdatesToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.checkForUpdatesToolStripMenuItem.Click, AddressOf Me.CheckForUpdatesToolStripMenuItemClick
		'
		'aboutToolStripMenuItem
		'
		Me.aboutToolStripMenuItem.AccessibleDescription = Nothing
		Me.aboutToolStripMenuItem.AccessibleName = Nothing
		Me.aboutToolStripMenuItem.AutoSize = CType(resources.GetObject("aboutToolStripMenuItem.AutoSize"),Boolean)
		Me.aboutToolStripMenuItem.BackgroundImage = Nothing
		Me.aboutToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("aboutToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.aboutToolStripMenuItem.Enabled = CType(resources.GetObject("aboutToolStripMenuItem.Enabled"),Boolean)
		Me.aboutToolStripMenuItem.Image = CType(resources.GetObject("aboutToolStripMenuItem.Image"),System.Drawing.Image)
		Me.aboutToolStripMenuItem.ImageAlign = CType(resources.GetObject("aboutToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.aboutToolStripMenuItem.ImageScaling = CType(resources.GetObject("aboutToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("aboutToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.aboutToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.aboutToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("aboutToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.aboutToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("aboutToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.aboutToolStripMenuItem.Size = CType(resources.GetObject("aboutToolStripMenuItem.Size"),System.Drawing.Size)
		Me.aboutToolStripMenuItem.Text = resources.GetString("aboutToolStripMenuItem.Text")
		Me.aboutToolStripMenuItem.TextAlign = CType(resources.GetObject("aboutToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.aboutToolStripMenuItem.TextImageRelation = CType(resources.GetObject("aboutToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.aboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItemClick
		'
		'toolStripMain
		'
		Me.toolStripMain.AccessibleDescription = Nothing
		Me.toolStripMain.AccessibleName = Nothing
		Me.toolStripMain.Anchor = CType(resources.GetObject("toolStripMain.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.toolStripMain.AutoSize = CType(resources.GetObject("toolStripMain.AutoSize"),Boolean)
		Me.toolStripMain.BackgroundImage = Nothing
		Me.toolStripMain.BackgroundImageLayout = CType(resources.GetObject("toolStripMain.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripMain.Dock = CType(resources.GetObject("toolStripMain.Dock"),System.Windows.Forms.DockStyle)
		Me.toolStripMain.Font = Nothing
		Me.toolStripMain.ImeMode = CType(resources.GetObject("toolStripMain.ImeMode"),System.Windows.Forms.ImeMode)
		Me.toolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonNewProfile, Me.toolStripSeparator10, Me.toolStripButtonApplyProfile, Me.toolStripSeparator2, Me.toolStripButtonCopyProfile, Me.toolStripButtonEditProfile, Me.toolStripButtonDeleteProfile})
		Me.toolStripMain.Location = CType(resources.GetObject("toolStripMain.Location"),System.Drawing.Point)
		Me.toolStripMain.Name = "toolStripMain"
		Me.toolStripMain.RightToLeft = CType(resources.GetObject("toolStripMain.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.toolStripMain.Size = CType(resources.GetObject("toolStripMain.Size"),System.Drawing.Size)
		Me.toolStripMain.TabIndex = CType(resources.GetObject("toolStripMain.TabIndex"),Integer)
		Me.toolStripMain.Text = resources.GetString("toolStripMain.Text")
		Me.toolTip1.SetToolTip(Me.toolStripMain, resources.GetString("toolStripMain.ToolTip"))
		'
		'toolStripButtonNewProfile
		'
		Me.toolStripButtonNewProfile.AccessibleDescription = Nothing
		Me.toolStripButtonNewProfile.AccessibleName = Nothing
		Me.toolStripButtonNewProfile.AutoSize = CType(resources.GetObject("toolStripButtonNewProfile.AutoSize"),Boolean)
		Me.toolStripButtonNewProfile.BackgroundImage = Nothing
		Me.toolStripButtonNewProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonNewProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonNewProfile.Enabled = CType(resources.GetObject("toolStripButtonNewProfile.Enabled"),Boolean)
		Me.toolStripButtonNewProfile.Image = CType(resources.GetObject("toolStripButtonNewProfile.Image"),System.Drawing.Image)
		Me.toolStripButtonNewProfile.ImageAlign = CType(resources.GetObject("toolStripButtonNewProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonNewProfile.ImageScaling = CType(resources.GetObject("toolStripButtonNewProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonNewProfile.ImageTransparentColor = CType(resources.GetObject("toolStripButtonNewProfile.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonNewProfile.Name = "toolStripButtonNewProfile"
		Me.toolStripButtonNewProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonNewProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonNewProfile.Size = CType(resources.GetObject("toolStripButtonNewProfile.Size"),System.Drawing.Size)
		Me.toolStripButtonNewProfile.Text = resources.GetString("toolStripButtonNewProfile.Text")
		Me.toolStripButtonNewProfile.TextAlign = CType(resources.GetObject("toolStripButtonNewProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonNewProfile.TextImageRelation = CType(resources.GetObject("toolStripButtonNewProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonNewProfile.Click, AddressOf Me.ToolStripButtonNewProfileClick
		'
		'toolStripSeparator10
		'
		Me.toolStripSeparator10.AccessibleDescription = Nothing
		Me.toolStripSeparator10.AccessibleName = Nothing
		Me.toolStripSeparator10.AutoSize = CType(resources.GetObject("toolStripSeparator10.AutoSize"),Boolean)
		Me.toolStripSeparator10.Name = "toolStripSeparator10"
		Me.toolStripSeparator10.Size = CType(resources.GetObject("toolStripSeparator10.Size"),System.Drawing.Size)
		'
		'toolStripButtonApplyProfile
		'
		Me.toolStripButtonApplyProfile.AccessibleDescription = Nothing
		Me.toolStripButtonApplyProfile.AccessibleName = Nothing
		Me.toolStripButtonApplyProfile.AutoSize = CType(resources.GetObject("toolStripButtonApplyProfile.AutoSize"),Boolean)
		Me.toolStripButtonApplyProfile.BackgroundImage = Nothing
		Me.toolStripButtonApplyProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonApplyProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonApplyProfile.Enabled = CType(resources.GetObject("toolStripButtonApplyProfile.Enabled"),Boolean)
		Me.toolStripButtonApplyProfile.Image = CType(resources.GetObject("toolStripButtonApplyProfile.Image"),System.Drawing.Image)
		Me.toolStripButtonApplyProfile.ImageAlign = CType(resources.GetObject("toolStripButtonApplyProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonApplyProfile.ImageScaling = CType(resources.GetObject("toolStripButtonApplyProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonApplyProfile.ImageTransparentColor = CType(resources.GetObject("toolStripButtonApplyProfile.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonApplyProfile.Name = "toolStripButtonApplyProfile"
		Me.toolStripButtonApplyProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonApplyProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonApplyProfile.Size = CType(resources.GetObject("toolStripButtonApplyProfile.Size"),System.Drawing.Size)
		Me.toolStripButtonApplyProfile.Text = resources.GetString("toolStripButtonApplyProfile.Text")
		Me.toolStripButtonApplyProfile.TextAlign = CType(resources.GetObject("toolStripButtonApplyProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonApplyProfile.TextImageRelation = CType(resources.GetObject("toolStripButtonApplyProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonApplyProfile.Click, AddressOf Me.ToolStripButtonApplyProfileClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.AccessibleDescription = Nothing
		Me.toolStripSeparator2.AccessibleName = Nothing
		Me.toolStripSeparator2.AutoSize = CType(resources.GetObject("toolStripSeparator2.AutoSize"),Boolean)
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = CType(resources.GetObject("toolStripSeparator2.Size"),System.Drawing.Size)
		'
		'toolStripButtonCopyProfile
		'
		Me.toolStripButtonCopyProfile.AccessibleDescription = Nothing
		Me.toolStripButtonCopyProfile.AccessibleName = Nothing
		Me.toolStripButtonCopyProfile.AutoSize = CType(resources.GetObject("toolStripButtonCopyProfile.AutoSize"),Boolean)
		Me.toolStripButtonCopyProfile.BackgroundImage = Nothing
		Me.toolStripButtonCopyProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonCopyProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonCopyProfile.Enabled = CType(resources.GetObject("toolStripButtonCopyProfile.Enabled"),Boolean)
		Me.toolStripButtonCopyProfile.Image = CType(resources.GetObject("toolStripButtonCopyProfile.Image"),System.Drawing.Image)
		Me.toolStripButtonCopyProfile.ImageAlign = CType(resources.GetObject("toolStripButtonCopyProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonCopyProfile.ImageScaling = CType(resources.GetObject("toolStripButtonCopyProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonCopyProfile.ImageTransparentColor = CType(resources.GetObject("toolStripButtonCopyProfile.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonCopyProfile.Name = "toolStripButtonCopyProfile"
		Me.toolStripButtonCopyProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonCopyProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonCopyProfile.Size = CType(resources.GetObject("toolStripButtonCopyProfile.Size"),System.Drawing.Size)
		Me.toolStripButtonCopyProfile.Text = resources.GetString("toolStripButtonCopyProfile.Text")
		Me.toolStripButtonCopyProfile.TextAlign = CType(resources.GetObject("toolStripButtonCopyProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonCopyProfile.TextImageRelation = CType(resources.GetObject("toolStripButtonCopyProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonCopyProfile.Click, AddressOf Me.ToolStripButtonCopyProfileClick
		'
		'toolStripButtonEditProfile
		'
		Me.toolStripButtonEditProfile.AccessibleDescription = Nothing
		Me.toolStripButtonEditProfile.AccessibleName = Nothing
		Me.toolStripButtonEditProfile.AutoSize = CType(resources.GetObject("toolStripButtonEditProfile.AutoSize"),Boolean)
		Me.toolStripButtonEditProfile.BackgroundImage = Nothing
		Me.toolStripButtonEditProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonEditProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonEditProfile.Enabled = CType(resources.GetObject("toolStripButtonEditProfile.Enabled"),Boolean)
		Me.toolStripButtonEditProfile.Image = CType(resources.GetObject("toolStripButtonEditProfile.Image"),System.Drawing.Image)
		Me.toolStripButtonEditProfile.ImageAlign = CType(resources.GetObject("toolStripButtonEditProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonEditProfile.ImageScaling = CType(resources.GetObject("toolStripButtonEditProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonEditProfile.ImageTransparentColor = CType(resources.GetObject("toolStripButtonEditProfile.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonEditProfile.Name = "toolStripButtonEditProfile"
		Me.toolStripButtonEditProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonEditProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonEditProfile.Size = CType(resources.GetObject("toolStripButtonEditProfile.Size"),System.Drawing.Size)
		Me.toolStripButtonEditProfile.Text = resources.GetString("toolStripButtonEditProfile.Text")
		Me.toolStripButtonEditProfile.TextAlign = CType(resources.GetObject("toolStripButtonEditProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonEditProfile.TextImageRelation = CType(resources.GetObject("toolStripButtonEditProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonEditProfile.Click, AddressOf Me.ToolStripButtonEditProfileClick
		'
		'toolStripButtonDeleteProfile
		'
		Me.toolStripButtonDeleteProfile.AccessibleDescription = Nothing
		Me.toolStripButtonDeleteProfile.AccessibleName = Nothing
		Me.toolStripButtonDeleteProfile.AutoSize = CType(resources.GetObject("toolStripButtonDeleteProfile.AutoSize"),Boolean)
		Me.toolStripButtonDeleteProfile.BackgroundImage = Nothing
		Me.toolStripButtonDeleteProfile.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonDeleteProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonDeleteProfile.Enabled = CType(resources.GetObject("toolStripButtonDeleteProfile.Enabled"),Boolean)
		Me.toolStripButtonDeleteProfile.Image = CType(resources.GetObject("toolStripButtonDeleteProfile.Image"),System.Drawing.Image)
		Me.toolStripButtonDeleteProfile.ImageAlign = CType(resources.GetObject("toolStripButtonDeleteProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonDeleteProfile.ImageScaling = CType(resources.GetObject("toolStripButtonDeleteProfile.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonDeleteProfile.ImageTransparentColor = CType(resources.GetObject("toolStripButtonDeleteProfile.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonDeleteProfile.Name = "toolStripButtonDeleteProfile"
		Me.toolStripButtonDeleteProfile.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonDeleteProfile.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonDeleteProfile.Size = CType(resources.GetObject("toolStripButtonDeleteProfile.Size"),System.Drawing.Size)
		Me.toolStripButtonDeleteProfile.Text = resources.GetString("toolStripButtonDeleteProfile.Text")
		Me.toolStripButtonDeleteProfile.TextAlign = CType(resources.GetObject("toolStripButtonDeleteProfile.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonDeleteProfile.TextImageRelation = CType(resources.GetObject("toolStripButtonDeleteProfile.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonDeleteProfile.Click, AddressOf Me.ToolStripButtonDeleteProfileClick
		'
		'statusStrip1
		'
		Me.statusStrip1.AccessibleDescription = Nothing
		Me.statusStrip1.AccessibleName = Nothing
		Me.statusStrip1.Anchor = CType(resources.GetObject("statusStrip1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.statusStrip1.AutoSize = CType(resources.GetObject("statusStrip1.AutoSize"),Boolean)
		Me.statusStrip1.BackgroundImage = Nothing
		Me.statusStrip1.BackgroundImageLayout = CType(resources.GetObject("statusStrip1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.statusStrip1.Dock = CType(resources.GetObject("statusStrip1.Dock"),System.Windows.Forms.DockStyle)
		Me.statusStrip1.Font = Nothing
		Me.statusStrip1.ImeMode = CType(resources.GetObject("statusStrip1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripProgressBar1, Me.toolStripStatusLabelProgress, Me.toolStripStatusLabelWorking, Me.toolStripStatusLabel1})
		Me.statusStrip1.Location = CType(resources.GetObject("statusStrip1.Location"),System.Drawing.Point)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.RightToLeft = CType(resources.GetObject("statusStrip1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.statusStrip1.Size = CType(resources.GetObject("statusStrip1.Size"),System.Drawing.Size)
		Me.statusStrip1.TabIndex = CType(resources.GetObject("statusStrip1.TabIndex"),Integer)
		Me.statusStrip1.Text = resources.GetString("statusStrip1.Text")
		Me.toolTip1.SetToolTip(Me.statusStrip1, resources.GetString("statusStrip1.ToolTip"))
		'
		'toolStripProgressBar1
		'
		Me.toolStripProgressBar1.AccessibleDescription = Nothing
		Me.toolStripProgressBar1.AccessibleName = Nothing
		Me.toolStripProgressBar1.AutoSize = CType(resources.GetObject("toolStripProgressBar1.AutoSize"),Boolean)
		Me.toolStripProgressBar1.Enabled = CType(resources.GetObject("toolStripProgressBar1.Enabled"),Boolean)
		Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
		Me.toolStripProgressBar1.RightToLeftLayout = CType(resources.GetObject("toolStripProgressBar1.RightToLeftLayout"),Boolean)
		Me.toolStripProgressBar1.Size = CType(resources.GetObject("toolStripProgressBar1.Size"),System.Drawing.Size)
		Me.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		Me.toolStripProgressBar1.TextAlign = CType(resources.GetObject("toolStripProgressBar1.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripProgressBar1.TextImageRelation = CType(resources.GetObject("toolStripProgressBar1.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolStripProgressBar1.Visible = CType(resources.GetObject("toolStripProgressBar1.Visible"),Boolean)
		'
		'toolStripStatusLabelProgress
		'
		Me.toolStripStatusLabelProgress.AccessibleDescription = Nothing
		Me.toolStripStatusLabelProgress.AccessibleName = Nothing
		Me.toolStripStatusLabelProgress.AutoSize = CType(resources.GetObject("toolStripStatusLabelProgress.AutoSize"),Boolean)
		Me.toolStripStatusLabelProgress.BackgroundImage = Nothing
		Me.toolStripStatusLabelProgress.BackgroundImageLayout = CType(resources.GetObject("toolStripStatusLabelProgress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripStatusLabelProgress.Enabled = CType(resources.GetObject("toolStripStatusLabelProgress.Enabled"),Boolean)
		Me.toolStripStatusLabelProgress.ImageAlign = CType(resources.GetObject("toolStripStatusLabelProgress.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripStatusLabelProgress.ImageScaling = CType(resources.GetObject("toolStripStatusLabelProgress.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripStatusLabelProgress.Name = "toolStripStatusLabelProgress"
		Me.toolStripStatusLabelProgress.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripStatusLabelProgress.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripStatusLabelProgress.Size = CType(resources.GetObject("toolStripStatusLabelProgress.Size"),System.Drawing.Size)
		Me.toolStripStatusLabelProgress.Text = resources.GetString("toolStripStatusLabelProgress.Text")
		Me.toolStripStatusLabelProgress.TextAlign = CType(resources.GetObject("toolStripStatusLabelProgress.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripStatusLabelProgress.TextImageRelation = CType(resources.GetObject("toolStripStatusLabelProgress.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		'
		'toolStripStatusLabelWorking
		'
		Me.toolStripStatusLabelWorking.AccessibleDescription = Nothing
		Me.toolStripStatusLabelWorking.AccessibleName = Nothing
		Me.toolStripStatusLabelWorking.AutoSize = CType(resources.GetObject("toolStripStatusLabelWorking.AutoSize"),Boolean)
		Me.toolStripStatusLabelWorking.BackgroundImage = Nothing
		Me.toolStripStatusLabelWorking.BackgroundImageLayout = CType(resources.GetObject("toolStripStatusLabelWorking.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripStatusLabelWorking.Enabled = CType(resources.GetObject("toolStripStatusLabelWorking.Enabled"),Boolean)
		Me.toolStripStatusLabelWorking.ImageAlign = CType(resources.GetObject("toolStripStatusLabelWorking.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripStatusLabelWorking.ImageScaling = CType(resources.GetObject("toolStripStatusLabelWorking.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripStatusLabelWorking.Name = "toolStripStatusLabelWorking"
		Me.toolStripStatusLabelWorking.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripStatusLabelWorking.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripStatusLabelWorking.Size = CType(resources.GetObject("toolStripStatusLabelWorking.Size"),System.Drawing.Size)
		Me.toolStripStatusLabelWorking.Text = resources.GetString("toolStripStatusLabelWorking.Text")
		Me.toolStripStatusLabelWorking.TextAlign = CType(resources.GetObject("toolStripStatusLabelWorking.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripStatusLabelWorking.TextImageRelation = CType(resources.GetObject("toolStripStatusLabelWorking.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolStripStatusLabelWorking.Visible = CType(resources.GetObject("toolStripStatusLabelWorking.Visible"),Boolean)
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.AccessibleDescription = Nothing
		Me.toolStripStatusLabel1.AccessibleName = Nothing
		Me.toolStripStatusLabel1.AutoSize = CType(resources.GetObject("toolStripStatusLabel1.AutoSize"),Boolean)
		Me.toolStripStatusLabel1.BackgroundImage = Nothing
		Me.toolStripStatusLabel1.BackgroundImageLayout = CType(resources.GetObject("toolStripStatusLabel1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.toolStripStatusLabel1.Enabled = CType(resources.GetObject("toolStripStatusLabel1.Enabled"),Boolean)
		Me.toolStripStatusLabel1.ImageAlign = CType(resources.GetObject("toolStripStatusLabel1.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripStatusLabel1.ImageScaling = CType(resources.GetObject("toolStripStatusLabel1.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripStatusLabel1.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripStatusLabel1.Size = CType(resources.GetObject("toolStripStatusLabel1.Size"),System.Drawing.Size)
		Me.toolStripStatusLabel1.Spring = true
		Me.toolStripStatusLabel1.Text = resources.GetString("toolStripStatusLabel1.Text")
		Me.toolStripStatusLabel1.TextAlign = CType(resources.GetObject("toolStripStatusLabel1.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripStatusLabel1.TextImageRelation = CType(resources.GetObject("toolStripStatusLabel1.TextImageRelation"),System.Windows.Forms.TextImageRelation)
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
		Me.listViewProfiles.AccessibleDescription = Nothing
		Me.listViewProfiles.AccessibleName = Nothing
		Me.listViewProfiles.Alignment = CType(resources.GetObject("listViewProfiles.Alignment"),System.Windows.Forms.ListViewAlignment)
		Me.listViewProfiles.Anchor = CType(resources.GetObject("listViewProfiles.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.listViewProfiles.BackgroundImage = Nothing
		Me.listViewProfiles.BackgroundImageLayout = CType(resources.GetObject("listViewProfiles.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.listViewProfiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderName, Me.columnHeaderIPAddress})
		Me.listViewProfiles.ContextMenuStrip = Me.contextMenuStripProfiles
		Me.listViewProfiles.Dock = CType(resources.GetObject("listViewProfiles.Dock"),System.Windows.Forms.DockStyle)
		Me.listViewProfiles.Font = Nothing
		Me.listViewProfiles.GridLines = true
		Me.listViewProfiles.ImeMode = CType(resources.GetObject("listViewProfiles.ImeMode"),System.Windows.Forms.ImeMode)
		Me.listViewProfiles.LabelWrap = CType(resources.GetObject("listViewProfiles.LabelWrap"),Boolean)
		Me.listViewProfiles.LargeImageList = Me.imageListProfiles
		Me.listViewProfiles.Location = CType(resources.GetObject("listViewProfiles.Location"),System.Drawing.Point)
		Me.listViewProfiles.Name = "listViewProfiles"
		Me.listViewProfiles.RightToLeft = CType(resources.GetObject("listViewProfiles.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.listViewProfiles.RightToLeftLayout = CType(resources.GetObject("listViewProfiles.RightToLeftLayout"),Boolean)
		Me.listViewProfiles.Size = CType(resources.GetObject("listViewProfiles.Size"),System.Drawing.Size)
		Me.listViewProfiles.TabIndex = CType(resources.GetObject("listViewProfiles.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.listViewProfiles, resources.GetString("listViewProfiles.ToolTip"))
		Me.listViewProfiles.UseCompatibleStateImageBehavior = false
		Me.listViewProfiles.View = System.Windows.Forms.View.Tile
		AddHandler Me.listViewProfiles.DoubleClick, AddressOf Me.ListViewProfilesDoubleClick
		AddHandler Me.listViewProfiles.ItemSelectionChanged, AddressOf Me.ListViewProfilesItemSelectionChanged
		'
		'columnHeaderName
		'
		Me.columnHeaderName.Text = resources.GetString("columnHeaderName.Text")
		Me.columnHeaderName.TextAlign = CType(resources.GetObject("columnHeaderName.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderName.Width = CType(resources.GetObject("columnHeaderName.Width"),Integer)
		'
		'columnHeaderIPAddress
		'
		Me.columnHeaderIPAddress.Text = resources.GetString("columnHeaderIPAddress.Text")
		Me.columnHeaderIPAddress.TextAlign = CType(resources.GetObject("columnHeaderIPAddress.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderIPAddress.Width = CType(resources.GetObject("columnHeaderIPAddress.Width"),Integer)
		'
		'contextMenuStripProfiles
		'
		Me.contextMenuStripProfiles.AccessibleDescription = Nothing
		Me.contextMenuStripProfiles.AccessibleName = Nothing
		Me.contextMenuStripProfiles.Anchor = CType(resources.GetObject("contextMenuStripProfiles.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.contextMenuStripProfiles.AutoSize = CType(resources.GetObject("contextMenuStripProfiles.AutoSize"),Boolean)
		Me.contextMenuStripProfiles.BackgroundImage = Nothing
		Me.contextMenuStripProfiles.BackgroundImageLayout = CType(resources.GetObject("contextMenuStripProfiles.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.contextMenuStripProfiles.Dock = CType(resources.GetObject("contextMenuStripProfiles.Dock"),System.Windows.Forms.DockStyle)
		Me.contextMenuStripProfiles.Font = Nothing
		Me.contextMenuStripProfiles.ImeMode = CType(resources.GetObject("contextMenuStripProfiles.ImeMode"),System.Windows.Forms.ImeMode)
		Me.contextMenuStripProfiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.applyProfileToolStripMenuItem, Me.activateOnDifferentNetworkCardToolStripMenuItem, Me.toolStripSeparator4, Me.copyToolStripMenuItem, Me.editToolStripMenuItem, Me.deleteToolStripMenuItem, Me.toolStripSeparator8, Me.createDesktopShortcutToolStripMenuItem})
		Me.contextMenuStripProfiles.Name = "contextMenuStripProfiles"
		Me.contextMenuStripProfiles.RightToLeft = CType(resources.GetObject("contextMenuStripProfiles.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.contextMenuStripProfiles.Size = CType(resources.GetObject("contextMenuStripProfiles.Size"),System.Drawing.Size)
		Me.toolTip1.SetToolTip(Me.contextMenuStripProfiles, resources.GetString("contextMenuStripProfiles.ToolTip"))
		AddHandler Me.contextMenuStripProfiles.Opening, AddressOf Me.ContextMenuStripProfilesOpening
		'
		'applyProfileToolStripMenuItem
		'
		Me.applyProfileToolStripMenuItem.AccessibleDescription = Nothing
		Me.applyProfileToolStripMenuItem.AccessibleName = Nothing
		Me.applyProfileToolStripMenuItem.AutoSize = CType(resources.GetObject("applyProfileToolStripMenuItem.AutoSize"),Boolean)
		Me.applyProfileToolStripMenuItem.BackgroundImage = Nothing
		Me.applyProfileToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("applyProfileToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.applyProfileToolStripMenuItem.Enabled = CType(resources.GetObject("applyProfileToolStripMenuItem.Enabled"),Boolean)
		Me.applyProfileToolStripMenuItem.Font = CType(resources.GetObject("applyProfileToolStripMenuItem.Font"),System.Drawing.Font)
		Me.applyProfileToolStripMenuItem.Image = CType(resources.GetObject("applyProfileToolStripMenuItem.Image"),System.Drawing.Image)
		Me.applyProfileToolStripMenuItem.ImageAlign = CType(resources.GetObject("applyProfileToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.applyProfileToolStripMenuItem.ImageScaling = CType(resources.GetObject("applyProfileToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.applyProfileToolStripMenuItem.Name = "applyProfileToolStripMenuItem"
		Me.applyProfileToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("applyProfileToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.applyProfileToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.applyProfileToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("applyProfileToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.applyProfileToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("applyProfileToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.applyProfileToolStripMenuItem.Size = CType(resources.GetObject("applyProfileToolStripMenuItem.Size"),System.Drawing.Size)
		Me.applyProfileToolStripMenuItem.Text = resources.GetString("applyProfileToolStripMenuItem.Text")
		Me.applyProfileToolStripMenuItem.TextAlign = CType(resources.GetObject("applyProfileToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.applyProfileToolStripMenuItem.TextImageRelation = CType(resources.GetObject("applyProfileToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.applyProfileToolStripMenuItem.Click, AddressOf Me.ApplyProfileToolStripMenuItemClick
		'
		'activateOnDifferentNetworkCardToolStripMenuItem
		'
		Me.activateOnDifferentNetworkCardToolStripMenuItem.AccessibleDescription = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem.AccessibleName = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem.AutoSize = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.AutoSize"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.BackgroundImage = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Enabled = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.Enabled"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Image = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.Image"),System.Drawing.Image)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.ImageAlign = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.ImageScaling = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Name = "activateOnDifferentNetworkCardToolStripMenuItem"
		Me.activateOnDifferentNetworkCardToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.activateOnDifferentNetworkCardToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Size = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.Size"),System.Drawing.Size)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.Text = resources.GetString("activateOnDifferentNetworkCardToolStripMenuItem.Text")
		Me.activateOnDifferentNetworkCardToolStripMenuItem.TextAlign = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.activateOnDifferentNetworkCardToolStripMenuItem.TextImageRelation = CType(resources.GetObject("activateOnDifferentNetworkCardToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.activateOnDifferentNetworkCardToolStripMenuItem.Click, AddressOf Me.ActivateOnDifferentNetworkCardToolStripMenuItemClick
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.AccessibleDescription = Nothing
		Me.toolStripSeparator4.AccessibleName = Nothing
		Me.toolStripSeparator4.AutoSize = CType(resources.GetObject("toolStripSeparator4.AutoSize"),Boolean)
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = CType(resources.GetObject("toolStripSeparator4.Size"),System.Drawing.Size)
		'
		'copyToolStripMenuItem
		'
		Me.copyToolStripMenuItem.AccessibleDescription = Nothing
		Me.copyToolStripMenuItem.AccessibleName = Nothing
		Me.copyToolStripMenuItem.AutoSize = CType(resources.GetObject("copyToolStripMenuItem.AutoSize"),Boolean)
		Me.copyToolStripMenuItem.BackgroundImage = Nothing
		Me.copyToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("copyToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.copyToolStripMenuItem.Enabled = CType(resources.GetObject("copyToolStripMenuItem.Enabled"),Boolean)
		Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"),System.Drawing.Image)
		Me.copyToolStripMenuItem.ImageAlign = CType(resources.GetObject("copyToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.copyToolStripMenuItem.ImageScaling = CType(resources.GetObject("copyToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
		Me.copyToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("copyToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.copyToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.copyToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("copyToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.copyToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("copyToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.copyToolStripMenuItem.Size = CType(resources.GetObject("copyToolStripMenuItem.Size"),System.Drawing.Size)
		Me.copyToolStripMenuItem.Text = resources.GetString("copyToolStripMenuItem.Text")
		Me.copyToolStripMenuItem.TextAlign = CType(resources.GetObject("copyToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.copyToolStripMenuItem.TextImageRelation = CType(resources.GetObject("copyToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.copyToolStripMenuItem.Click, AddressOf Me.CopyToolStripMenuItemClick
		'
		'editToolStripMenuItem
		'
		Me.editToolStripMenuItem.AccessibleDescription = Nothing
		Me.editToolStripMenuItem.AccessibleName = Nothing
		Me.editToolStripMenuItem.AutoSize = CType(resources.GetObject("editToolStripMenuItem.AutoSize"),Boolean)
		Me.editToolStripMenuItem.BackgroundImage = Nothing
		Me.editToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("editToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.editToolStripMenuItem.Enabled = CType(resources.GetObject("editToolStripMenuItem.Enabled"),Boolean)
		Me.editToolStripMenuItem.Image = CType(resources.GetObject("editToolStripMenuItem.Image"),System.Drawing.Image)
		Me.editToolStripMenuItem.ImageAlign = CType(resources.GetObject("editToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.editToolStripMenuItem.ImageScaling = CType(resources.GetObject("editToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
		Me.editToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("editToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.editToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.editToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("editToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.editToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("editToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.editToolStripMenuItem.Size = CType(resources.GetObject("editToolStripMenuItem.Size"),System.Drawing.Size)
		Me.editToolStripMenuItem.Text = resources.GetString("editToolStripMenuItem.Text")
		Me.editToolStripMenuItem.TextAlign = CType(resources.GetObject("editToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.editToolStripMenuItem.TextImageRelation = CType(resources.GetObject("editToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.editToolStripMenuItem.Click, AddressOf Me.EditToolStripMenuItemClick
		'
		'deleteToolStripMenuItem
		'
		Me.deleteToolStripMenuItem.AccessibleDescription = Nothing
		Me.deleteToolStripMenuItem.AccessibleName = Nothing
		Me.deleteToolStripMenuItem.AutoSize = CType(resources.GetObject("deleteToolStripMenuItem.AutoSize"),Boolean)
		Me.deleteToolStripMenuItem.BackgroundImage = Nothing
		Me.deleteToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("deleteToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.deleteToolStripMenuItem.Enabled = CType(resources.GetObject("deleteToolStripMenuItem.Enabled"),Boolean)
		Me.deleteToolStripMenuItem.Image = CType(resources.GetObject("deleteToolStripMenuItem.Image"),System.Drawing.Image)
		Me.deleteToolStripMenuItem.ImageAlign = CType(resources.GetObject("deleteToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.deleteToolStripMenuItem.ImageScaling = CType(resources.GetObject("deleteToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
		Me.deleteToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("deleteToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.deleteToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.deleteToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("deleteToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.deleteToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("deleteToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.deleteToolStripMenuItem.Size = CType(resources.GetObject("deleteToolStripMenuItem.Size"),System.Drawing.Size)
		Me.deleteToolStripMenuItem.Text = resources.GetString("deleteToolStripMenuItem.Text")
		Me.deleteToolStripMenuItem.TextAlign = CType(resources.GetObject("deleteToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.deleteToolStripMenuItem.TextImageRelation = CType(resources.GetObject("deleteToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.deleteToolStripMenuItem.Click, AddressOf Me.DeleteToolStripMenuItemClick
		'
		'toolStripSeparator8
		'
		Me.toolStripSeparator8.AccessibleDescription = Nothing
		Me.toolStripSeparator8.AccessibleName = Nothing
		Me.toolStripSeparator8.AutoSize = CType(resources.GetObject("toolStripSeparator8.AutoSize"),Boolean)
		Me.toolStripSeparator8.Name = "toolStripSeparator8"
		Me.toolStripSeparator8.Size = CType(resources.GetObject("toolStripSeparator8.Size"),System.Drawing.Size)
		'
		'createDesktopShortcutToolStripMenuItem
		'
		Me.createDesktopShortcutToolStripMenuItem.AccessibleDescription = Nothing
		Me.createDesktopShortcutToolStripMenuItem.AccessibleName = Nothing
		Me.createDesktopShortcutToolStripMenuItem.AutoSize = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.AutoSize"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem.BackgroundImage = Nothing
		Me.createDesktopShortcutToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.createDesktopShortcutToolStripMenuItem.Enabled = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.Enabled"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem.Image = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.Image"),System.Drawing.Image)
		Me.createDesktopShortcutToolStripMenuItem.ImageAlign = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.createDesktopShortcutToolStripMenuItem.ImageScaling = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.createDesktopShortcutToolStripMenuItem.Name = "createDesktopShortcutToolStripMenuItem"
		Me.createDesktopShortcutToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.createDesktopShortcutToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.createDesktopShortcutToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.createDesktopShortcutToolStripMenuItem.Size = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.Size"),System.Drawing.Size)
		Me.createDesktopShortcutToolStripMenuItem.Text = resources.GetString("createDesktopShortcutToolStripMenuItem.Text")
		Me.createDesktopShortcutToolStripMenuItem.TextAlign = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.createDesktopShortcutToolStripMenuItem.TextImageRelation = CType(resources.GetObject("createDesktopShortcutToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.createDesktopShortcutToolStripMenuItem.Click, AddressOf Me.CreateDesktopShortcutToolStripMenuItemClick
		'
		'timerLoad
		'
		AddHandler Me.timerLoad.Tick, AddressOf Me.TimerLoadTick
		'
		'notifyIcon1
		'
		Me.notifyIcon1.BalloonTipText = resources.GetString("notifyIcon1.BalloonTipText")
		Me.notifyIcon1.BalloonTipTitle = resources.GetString("notifyIcon1.BalloonTipTitle")
		Me.notifyIcon1.ContextMenuStrip = Me.contextMenuStripSystemTray
		Me.notifyIcon1.Icon = CType(resources.GetObject("notifyIcon1.Icon"),System.Drawing.Icon)
		Me.notifyIcon1.Text = resources.GetString("notifyIcon1.Text")
		Me.notifyIcon1.Visible = CType(resources.GetObject("notifyIcon1.Visible"),Boolean)
		AddHandler Me.notifyIcon1.DoubleClick, AddressOf Me.NotifyIcon1DoubleClick
		'
		'contextMenuStripSystemTray
		'
		Me.contextMenuStripSystemTray.AccessibleDescription = Nothing
		Me.contextMenuStripSystemTray.AccessibleName = Nothing
		Me.contextMenuStripSystemTray.Anchor = CType(resources.GetObject("contextMenuStripSystemTray.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.contextMenuStripSystemTray.AutoSize = CType(resources.GetObject("contextMenuStripSystemTray.AutoSize"),Boolean)
		Me.contextMenuStripSystemTray.BackgroundImage = Nothing
		Me.contextMenuStripSystemTray.BackgroundImageLayout = CType(resources.GetObject("contextMenuStripSystemTray.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.contextMenuStripSystemTray.Dock = CType(resources.GetObject("contextMenuStripSystemTray.Dock"),System.Windows.Forms.DockStyle)
		Me.contextMenuStripSystemTray.Font = Nothing
		Me.contextMenuStripSystemTray.ImeMode = CType(resources.GetObject("contextMenuStripSystemTray.ImeMode"),System.Windows.Forms.ImeMode)
		Me.contextMenuStripSystemTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showHideWindowToolStripMenuItem, Me.profilesToolStripMenuItem, Me.toolStripSeparator5, Me.exitToolStripMenuItem1})
		Me.contextMenuStripSystemTray.Name = "contextMenuStripSystemTray"
		Me.contextMenuStripSystemTray.RightToLeft = CType(resources.GetObject("contextMenuStripSystemTray.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.contextMenuStripSystemTray.Size = CType(resources.GetObject("contextMenuStripSystemTray.Size"),System.Drawing.Size)
		Me.toolTip1.SetToolTip(Me.contextMenuStripSystemTray, resources.GetString("contextMenuStripSystemTray.ToolTip"))
		'
		'showHideWindowToolStripMenuItem
		'
		Me.showHideWindowToolStripMenuItem.AccessibleDescription = Nothing
		Me.showHideWindowToolStripMenuItem.AccessibleName = Nothing
		Me.showHideWindowToolStripMenuItem.AutoSize = CType(resources.GetObject("showHideWindowToolStripMenuItem.AutoSize"),Boolean)
		Me.showHideWindowToolStripMenuItem.BackgroundImage = Nothing
		Me.showHideWindowToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("showHideWindowToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.showHideWindowToolStripMenuItem.Enabled = CType(resources.GetObject("showHideWindowToolStripMenuItem.Enabled"),Boolean)
		Me.showHideWindowToolStripMenuItem.Font = CType(resources.GetObject("showHideWindowToolStripMenuItem.Font"),System.Drawing.Font)
		Me.showHideWindowToolStripMenuItem.Image = CType(resources.GetObject("showHideWindowToolStripMenuItem.Image"),System.Drawing.Image)
		Me.showHideWindowToolStripMenuItem.ImageAlign = CType(resources.GetObject("showHideWindowToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.showHideWindowToolStripMenuItem.ImageScaling = CType(resources.GetObject("showHideWindowToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.showHideWindowToolStripMenuItem.Name = "showHideWindowToolStripMenuItem"
		Me.showHideWindowToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("showHideWindowToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.showHideWindowToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.showHideWindowToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("showHideWindowToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.showHideWindowToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("showHideWindowToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.showHideWindowToolStripMenuItem.Size = CType(resources.GetObject("showHideWindowToolStripMenuItem.Size"),System.Drawing.Size)
		Me.showHideWindowToolStripMenuItem.Text = resources.GetString("showHideWindowToolStripMenuItem.Text")
		Me.showHideWindowToolStripMenuItem.TextAlign = CType(resources.GetObject("showHideWindowToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.showHideWindowToolStripMenuItem.TextImageRelation = CType(resources.GetObject("showHideWindowToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.showHideWindowToolStripMenuItem.Click, AddressOf Me.ShowHideWindowToolStripMenuItemClick
		'
		'profilesToolStripMenuItem
		'
		Me.profilesToolStripMenuItem.AccessibleDescription = Nothing
		Me.profilesToolStripMenuItem.AccessibleName = Nothing
		Me.profilesToolStripMenuItem.AutoSize = CType(resources.GetObject("profilesToolStripMenuItem.AutoSize"),Boolean)
		Me.profilesToolStripMenuItem.BackgroundImage = Nothing
		Me.profilesToolStripMenuItem.BackgroundImageLayout = CType(resources.GetObject("profilesToolStripMenuItem.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.profilesToolStripMenuItem.Enabled = CType(resources.GetObject("profilesToolStripMenuItem.Enabled"),Boolean)
		Me.profilesToolStripMenuItem.Image = CType(resources.GetObject("profilesToolStripMenuItem.Image"),System.Drawing.Image)
		Me.profilesToolStripMenuItem.ImageAlign = CType(resources.GetObject("profilesToolStripMenuItem.ImageAlign"),System.Drawing.ContentAlignment)
		Me.profilesToolStripMenuItem.ImageScaling = CType(resources.GetObject("profilesToolStripMenuItem.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem"
		Me.profilesToolStripMenuItem.RightToLeftAutoMirrorImage = CType(resources.GetObject("profilesToolStripMenuItem.RightToLeftAutoMirrorImage"),Boolean)
		Me.profilesToolStripMenuItem.ShortcutKeyDisplayString = Nothing
		Me.profilesToolStripMenuItem.ShortcutKeys = CType(resources.GetObject("profilesToolStripMenuItem.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.profilesToolStripMenuItem.ShowShortcutKeys = CType(resources.GetObject("profilesToolStripMenuItem.ShowShortcutKeys"),Boolean)
		Me.profilesToolStripMenuItem.Size = CType(resources.GetObject("profilesToolStripMenuItem.Size"),System.Drawing.Size)
		Me.profilesToolStripMenuItem.Text = resources.GetString("profilesToolStripMenuItem.Text")
		Me.profilesToolStripMenuItem.TextAlign = CType(resources.GetObject("profilesToolStripMenuItem.TextAlign"),System.Drawing.ContentAlignment)
		Me.profilesToolStripMenuItem.TextImageRelation = CType(resources.GetObject("profilesToolStripMenuItem.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.AccessibleDescription = Nothing
		Me.toolStripSeparator5.AccessibleName = Nothing
		Me.toolStripSeparator5.AutoSize = CType(resources.GetObject("toolStripSeparator5.AutoSize"),Boolean)
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = CType(resources.GetObject("toolStripSeparator5.Size"),System.Drawing.Size)
		'
		'exitToolStripMenuItem1
		'
		Me.exitToolStripMenuItem1.AccessibleDescription = Nothing
		Me.exitToolStripMenuItem1.AccessibleName = Nothing
		Me.exitToolStripMenuItem1.AutoSize = CType(resources.GetObject("exitToolStripMenuItem1.AutoSize"),Boolean)
		Me.exitToolStripMenuItem1.BackgroundImage = Nothing
		Me.exitToolStripMenuItem1.BackgroundImageLayout = CType(resources.GetObject("exitToolStripMenuItem1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.exitToolStripMenuItem1.Enabled = CType(resources.GetObject("exitToolStripMenuItem1.Enabled"),Boolean)
		Me.exitToolStripMenuItem1.Image = CType(resources.GetObject("exitToolStripMenuItem1.Image"),System.Drawing.Image)
		Me.exitToolStripMenuItem1.ImageAlign = CType(resources.GetObject("exitToolStripMenuItem1.ImageAlign"),System.Drawing.ContentAlignment)
		Me.exitToolStripMenuItem1.ImageScaling = CType(resources.GetObject("exitToolStripMenuItem1.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1"
		Me.exitToolStripMenuItem1.RightToLeftAutoMirrorImage = CType(resources.GetObject("exitToolStripMenuItem1.RightToLeftAutoMirrorImage"),Boolean)
		Me.exitToolStripMenuItem1.ShortcutKeyDisplayString = Nothing
		Me.exitToolStripMenuItem1.ShortcutKeys = CType(resources.GetObject("exitToolStripMenuItem1.ShortcutKeys"),System.Windows.Forms.Keys)
		Me.exitToolStripMenuItem1.ShowShortcutKeys = CType(resources.GetObject("exitToolStripMenuItem1.ShowShortcutKeys"),Boolean)
		Me.exitToolStripMenuItem1.Size = CType(resources.GetObject("exitToolStripMenuItem1.Size"),System.Drawing.Size)
		Me.exitToolStripMenuItem1.Text = resources.GetString("exitToolStripMenuItem1.Text")
		Me.exitToolStripMenuItem1.TextAlign = CType(resources.GetObject("exitToolStripMenuItem1.TextAlign"),System.Drawing.ContentAlignment)
		Me.exitToolStripMenuItem1.TextImageRelation = CType(resources.GetObject("exitToolStripMenuItem1.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.exitToolStripMenuItem1.Click, AddressOf Me.ExitToolStripMenuItem1Click
		'
		'pictureBoxWallpaper
		'
		Me.pictureBoxWallpaper.AccessibleDescription = Nothing
		Me.pictureBoxWallpaper.AccessibleName = Nothing
		Me.pictureBoxWallpaper.Anchor = CType(resources.GetObject("pictureBoxWallpaper.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxWallpaper.BackgroundImage = Nothing
		Me.pictureBoxWallpaper.BackgroundImageLayout = CType(resources.GetObject("pictureBoxWallpaper.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxWallpaper.Dock = CType(resources.GetObject("pictureBoxWallpaper.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxWallpaper.Font = Nothing
		Me.pictureBoxWallpaper.ImageLocation = Nothing
		Me.pictureBoxWallpaper.ImeMode = CType(resources.GetObject("pictureBoxWallpaper.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxWallpaper.Location = CType(resources.GetObject("pictureBoxWallpaper.Location"),System.Drawing.Point)
		Me.pictureBoxWallpaper.Name = "pictureBoxWallpaper"
		Me.pictureBoxWallpaper.RightToLeft = CType(resources.GetObject("pictureBoxWallpaper.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxWallpaper.Size = CType(resources.GetObject("pictureBoxWallpaper.Size"),System.Drawing.Size)
		Me.pictureBoxWallpaper.SizeMode = CType(resources.GetObject("pictureBoxWallpaper.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxWallpaper.TabIndex = CType(resources.GetObject("pictureBoxWallpaper.TabIndex"),Integer)
		Me.pictureBoxWallpaper.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxWallpaper, resources.GetString("pictureBoxWallpaper.ToolTip"))
		Me.pictureBoxWallpaper.Visible = CType(resources.GetObject("pictureBoxWallpaper.Visible"),Boolean)
		Me.pictureBoxWallpaper.WaitOnLoad = CType(resources.GetObject("pictureBoxWallpaper.WaitOnLoad"),Boolean)
		'
		'messageBoxManager1
		'
		Me.messageBoxManager1.AutoClose = true
		Me.messageBoxManager1.AutoCloseResult = System.Windows.Forms.DialogResult.No
		Me.messageBoxManager1.CenterWindow = true
		Me.messageBoxManager1.DisableButtons = false
		Me.messageBoxManager1.DisableCancel = false
		Me.messageBoxManager1.HookEnabled = false
		Me.messageBoxManager1.LastCheckState = false
		Me.messageBoxManager1.ShowNextTimeCheck = false
		Me.messageBoxManager1.ShowTitleCountDown = true
		Me.messageBoxManager1.TimeOut = 20
		'
		'timerDetectWireless
		'
		Me.timerDetectWireless.Interval = 3000
		AddHandler Me.timerDetectWireless.Tick, AddressOf Me.TimerDetectWirelessTick
		'
		'MainForm
		'
		Me.AccessibleDescription = Nothing
		Me.AccessibleName = Nothing
		Me.AutoScaleDimensions = CType(resources.GetObject("$this.AutoScaleDimensions"),System.Drawing.SizeF)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"),Boolean)
		Me.AutoSize = CType(resources.GetObject("$this.AutoSize"),Boolean)
		Me.AutoSizeMode = CType(resources.GetObject("$this.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.BackgroundImage = Nothing
		Me.BackgroundImageLayout = CType(resources.GetObject("$this.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.ClientSize = CType(resources.GetObject("$this.ClientSize"),System.Drawing.Size)
		Me.Controls.Add(Me.pictureBoxWallpaper)
		Me.Controls.Add(Me.listViewProfiles)
		Me.Controls.Add(Me.toolStripMain)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Font = Nothing
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MainMenuStrip = Me.menuStrip1
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.Name = "MainForm"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		Me.toolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
		AddHandler Load, AddressOf Me.MainFormLoad
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
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
	Private toolStripButtonCopyProfile As System.Windows.Forms.ToolStripButton
	Private toolStripMenuItemCopyProfile As System.Windows.Forms.ToolStripMenuItem
	Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private languageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private netProfilesWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private runWhenILogInToWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private dontAskBeforeAutoActivatingWirelessProfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private minimizeToTrayOnStartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public timerDetectWireless As System.Windows.Forms.Timer
	Private messageBoxManager1 As MessageBoxManager
	Private confirmSettingsAfterChangingResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private askBeforeChangingResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private screenResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public pictureBoxWallpaper As System.Windows.Forms.PictureBox
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private activateOnDifferentNetworkCardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private activateOnDifferentNetworkCardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private createDesktopShortcutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private reloadProfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private reloadNetworkInterfacesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private customizeDesktopShortcutsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private createDesktopShortcutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private minimizeToTrayOnCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private applyProfileToolStripMenuItemApplyProfile As System.Windows.Forms.ToolStripMenuItem
	Private deleteToolStripMenuItemDeleteProfile As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItemEditProfile As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItemNewProfile As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private exitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private profilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private showHideWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private contextMenuStripSystemTray As System.Windows.Forms.ContextMenuStrip
	Private notifyIcon1 As System.Windows.Forms.NotifyIcon
	Private deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private applyProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private contextMenuStripProfiles As System.Windows.Forms.ContextMenuStrip
	Public toolStripStatusLabelWorking As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
	Private timerLoad As System.Windows.Forms.Timer
	Private columnHeaderIPAddress As System.Windows.Forms.ColumnHeader
	Private columnHeaderName As System.Windows.Forms.ColumnHeader
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private toggleToolbarTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public toolStripMain As System.Windows.Forms.ToolStrip
	Private toolStripStatusLabelProgress As System.Windows.Forms.ToolStripStatusLabel
	Private imageListProfiles As System.Windows.Forms.ImageList
	Public listViewProfiles As System.Windows.Forms.ListView
	Private toolStripButtonApplyProfile As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private checkForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripButtonNewProfile As System.Windows.Forms.ToolStripButton
	Private toolStripButtonEditProfile As System.Windows.Forms.ToolStripButton
	Private toolStripButtonDeleteProfile As System.Windows.Forms.ToolStripButton
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Public fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
