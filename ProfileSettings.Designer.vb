'
' Created by SharpDevelop.
' User: Daniel Milner
' Date: 1/26/2007
' Time: 10:18 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class ProfileSettings
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
		'MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileSettings))
		Me.tabControl1 = New System.Windows.Forms.TabControl
		Me.tabPageIPSettings = New System.Windows.Forms.TabPage
		Me.buttonGetCurrentIPSettings = New System.Windows.Forms.Button
		Me.checkBoxDHCP = New System.Windows.Forms.CheckBox
		Me.textBoxWINSServer4 = New System.Windows.Forms.TextBox
		Me.textBoxWINSServer3 = New System.Windows.Forms.TextBox
		Me.textBoxWINSServer2 = New System.Windows.Forms.TextBox
		Me.textBoxWINSServer1 = New System.Windows.Forms.TextBox
		Me.label24 = New System.Windows.Forms.Label
		Me.label25 = New System.Windows.Forms.Label
		Me.label26 = New System.Windows.Forms.Label
		Me.pictureBoxWINSServer = New System.Windows.Forms.PictureBox
		Me.textBoxAlternateDNSServer4 = New System.Windows.Forms.TextBox
		Me.textBoxAlternateDNSServer3 = New System.Windows.Forms.TextBox
		Me.textBoxAlternateDNSServer2 = New System.Windows.Forms.TextBox
		Me.textBoxAlternateDNSServer1 = New System.Windows.Forms.TextBox
		Me.label21 = New System.Windows.Forms.Label
		Me.label22 = New System.Windows.Forms.Label
		Me.label23 = New System.Windows.Forms.Label
		Me.pictureBoxAlternateDNSServer = New System.Windows.Forms.PictureBox
		Me.textBoxPrimaryDNSServer4 = New System.Windows.Forms.TextBox
		Me.textBoxPrimaryDNSServer3 = New System.Windows.Forms.TextBox
		Me.textBoxPrimaryDNSServer2 = New System.Windows.Forms.TextBox
		Me.textBoxPrimaryDNSServer1 = New System.Windows.Forms.TextBox
		Me.label18 = New System.Windows.Forms.Label
		Me.label19 = New System.Windows.Forms.Label
		Me.label20 = New System.Windows.Forms.Label
		Me.pictureBoxPrimaryDNSServer = New System.Windows.Forms.PictureBox
		Me.textBoxDefaultGateway4 = New System.Windows.Forms.TextBox
		Me.textBoxDefaultGateway3 = New System.Windows.Forms.TextBox
		Me.textBoxDefaultGateway2 = New System.Windows.Forms.TextBox
		Me.textBoxDefaultGateway1 = New System.Windows.Forms.TextBox
		Me.label15 = New System.Windows.Forms.Label
		Me.label16 = New System.Windows.Forms.Label
		Me.label17 = New System.Windows.Forms.Label
		Me.pictureBoxDefaultGateway = New System.Windows.Forms.PictureBox
		Me.textBoxSubnetMask4 = New System.Windows.Forms.TextBox
		Me.textBoxSubnetMask3 = New System.Windows.Forms.TextBox
		Me.textBoxSubnetMask2 = New System.Windows.Forms.TextBox
		Me.textBoxSubnetMask1 = New System.Windows.Forms.TextBox
		Me.label12 = New System.Windows.Forms.Label
		Me.label13 = New System.Windows.Forms.Label
		Me.label14 = New System.Windows.Forms.Label
		Me.pictureBoxSubnetMask = New System.Windows.Forms.PictureBox
		Me.labelWINSServer = New System.Windows.Forms.Label
		Me.labelAlternateDNSServer = New System.Windows.Forms.Label
		Me.labelPrimaryDNSServer = New System.Windows.Forms.Label
		Me.labelDefaultGateway = New System.Windows.Forms.Label
		Me.labelSubnetMask = New System.Windows.Forms.Label
		Me.textBoxIPAddress4 = New System.Windows.Forms.TextBox
		Me.textBoxIPAddress3 = New System.Windows.Forms.TextBox
		Me.textBoxIPAddress2 = New System.Windows.Forms.TextBox
		Me.textBoxIPAddress1 = New System.Windows.Forms.TextBox
		Me.label9 = New System.Windows.Forms.Label
		Me.label8 = New System.Windows.Forms.Label
		Me.label7 = New System.Windows.Forms.Label
		Me.pictureBoxIPAddress = New System.Windows.Forms.PictureBox
		Me.labelIPAddress = New System.Windows.Forms.Label
		Me.tabPageInternet = New System.Windows.Forms.TabPage
		Me.groupBoxPleaseNote = New System.Windows.Forms.GroupBox
		Me.labelPleaseNote = New System.Windows.Forms.Label
		Me.groupBoxAutoConfigAddress = New System.Windows.Forms.GroupBox
		Me.textBoxAutoConfigAddress = New System.Windows.Forms.TextBox
		Me.buttonClearFirefox = New System.Windows.Forms.Button
		Me.groupBoxWebBrowsers = New System.Windows.Forms.GroupBox
		Me.checkBoxOpera = New System.Windows.Forms.CheckBox
		Me.checkBoxIE = New System.Windows.Forms.CheckBox
		Me.checkBoxFirefox = New System.Windows.Forms.CheckBox
		Me.groupBoxProxy = New System.Windows.Forms.GroupBox
		Me.checkBoxBypassProxyForLocalAddresses = New System.Windows.Forms.CheckBox
		Me.textBoxPort = New System.Windows.Forms.TextBox
		Me.textBoxServerAddress = New System.Windows.Forms.TextBox
		Me.labelPort = New System.Windows.Forms.Label
		Me.labelServerAddress = New System.Windows.Forms.Label
		Me.checkBoxUseProxySettings = New System.Windows.Forms.CheckBox
		Me.groupBoxHomepage = New System.Windows.Forms.GroupBox
		Me.labelHomepageNote = New System.Windows.Forms.Label
		Me.buttonUseBlankHomepage = New System.Windows.Forms.Button
		Me.textBoxDefaultHomepage = New System.Windows.Forms.TextBox
		Me.tabPageMappedDrives = New System.Windows.Forms.TabPage
		Me.listViewMappedDrives = New System.Windows.Forms.ListView
		Me.columnHeaderDrive = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderPath = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderUsername = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderPassword = New System.Windows.Forms.ColumnHeader
		Me.imageListDrives = New System.Windows.Forms.ImageList(Me.components)
		Me.toolStripMappedDrives = New System.Windows.Forms.ToolStrip
		Me.toolStripButtonAddDrive = New System.Windows.Forms.ToolStripButton
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.toolStripButtonEditDrive = New System.Windows.Forms.ToolStripButton
		Me.toolStripButtonRemoveDrive = New System.Windows.Forms.ToolStripButton
		Me.tabPagePrinter = New System.Windows.Forms.TabPage
		Me.groupBoxPrinter = New System.Windows.Forms.GroupBox
		Me.comboBoxPrinters = New System.Windows.Forms.ComboBox
		Me.buttonGetDefaultPrinter = New System.Windows.Forms.Button
		Me.tabPageRun = New System.Windows.Forms.TabPage
		Me.listViewRun = New System.Windows.Forms.ListView
		Me.columnHeaderRunPath = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderRunArguments = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderRunRun = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderRunUsername = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderRunPassword = New System.Windows.Forms.ColumnHeader
		Me.columnHeaderRunDomain = New System.Windows.Forms.ColumnHeader
		Me.toolStripRun = New System.Windows.Forms.ToolStrip
		Me.toolStripButtonAddProgram = New System.Windows.Forms.ToolStripButton
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.toolStripButtonEditProgram = New System.Windows.Forms.ToolStripButton
		Me.toolStripButtonRemoveProgram = New System.Windows.Forms.ToolStripButton
		Me.tabPageDesktop = New System.Windows.Forms.TabPage
		Me.groupBoxDisplaySettings = New System.Windows.Forms.GroupBox
		Me.labelColorQuality = New System.Windows.Forms.Label
		Me.labelScreenResolution = New System.Windows.Forms.Label
		Me.buttonGetCurrentDisplaySettings = New System.Windows.Forms.Button
		Me.comboBoxDisplayColors = New System.Windows.Forms.ComboBox
		Me.comboBoxDisplaySettings = New System.Windows.Forms.ComboBox
		Me.groupBoxWallpaper = New System.Windows.Forms.GroupBox
		Me.groupBoxWallpaperPreview = New System.Windows.Forms.GroupBox
		Me.pictureBoxWallpaperPreview = New System.Windows.Forms.PictureBox
		Me.buttonResetWallpaper = New System.Windows.Forms.Button
		Me.buttonBrowseWallpaper = New System.Windows.Forms.Button
		Me.textBoxWallpaperPath = New System.Windows.Forms.TextBox
		Me.tabPageWireless = New System.Windows.Forms.TabPage
		Me.labelWirelessVista = New System.Windows.Forms.Label
		Me.groupBoxWireless = New System.Windows.Forms.GroupBox
		Me.labelSSID = New System.Windows.Forms.Label
		Me.labelSSIDNotes = New System.Windows.Forms.Label
		Me.textBoxAutoActivateSSID = New System.Windows.Forms.TextBox
		Me.buttonClose = New System.Windows.Forms.Button
		Me.buttonSave = New System.Windows.Forms.Button
		Me.labelProfileName = New System.Windows.Forms.Label
		Me.textBoxProfileName = New System.Windows.Forms.TextBox
		Me.labelNetworkCard = New System.Windows.Forms.Label
		Me.comboBoxNetworkCards = New System.Windows.Forms.ComboBox
		Me.progressBar1 = New System.Windows.Forms.ProgressBar
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.labelWorking = New System.Windows.Forms.Label
		Me.openFileDialogWallpaper = New System.Windows.Forms.OpenFileDialog
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.tabControl1.SuspendLayout
		Me.tabPageIPSettings.SuspendLayout
		CType(Me.pictureBoxWINSServer,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBoxAlternateDNSServer,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBoxPrimaryDNSServer,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBoxDefaultGateway,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBoxSubnetMask,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBoxIPAddress,System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPageInternet.SuspendLayout
		Me.groupBoxPleaseNote.SuspendLayout
		Me.groupBoxAutoConfigAddress.SuspendLayout
		Me.groupBoxWebBrowsers.SuspendLayout
		Me.groupBoxProxy.SuspendLayout
		Me.groupBoxHomepage.SuspendLayout
		Me.tabPageMappedDrives.SuspendLayout
		Me.toolStripMappedDrives.SuspendLayout
		Me.tabPagePrinter.SuspendLayout
		Me.groupBoxPrinter.SuspendLayout
		Me.tabPageRun.SuspendLayout
		Me.toolStripRun.SuspendLayout
		Me.tabPageDesktop.SuspendLayout
		Me.groupBoxDisplaySettings.SuspendLayout
		Me.groupBoxWallpaper.SuspendLayout
		Me.groupBoxWallpaperPreview.SuspendLayout
		CType(Me.pictureBoxWallpaperPreview,System.ComponentModel.ISupportInitialize).BeginInit
		Me.tabPageWireless.SuspendLayout
		Me.groupBoxWireless.SuspendLayout
		Me.SuspendLayout
		'
		'tabControl1
		'
		Me.tabControl1.AccessibleDescription = Nothing
		Me.tabControl1.AccessibleName = Nothing
		Me.tabControl1.Alignment = CType(resources.GetObject("tabControl1.Alignment"),System.Windows.Forms.TabAlignment)
		Me.tabControl1.Anchor = CType(resources.GetObject("tabControl1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabControl1.Appearance = CType(resources.GetObject("tabControl1.Appearance"),System.Windows.Forms.TabAppearance)
		Me.tabControl1.BackgroundImage = Nothing
		Me.tabControl1.BackgroundImageLayout = CType(resources.GetObject("tabControl1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabControl1.Controls.Add(Me.tabPageIPSettings)
		Me.tabControl1.Controls.Add(Me.tabPageInternet)
		Me.tabControl1.Controls.Add(Me.tabPageMappedDrives)
		Me.tabControl1.Controls.Add(Me.tabPagePrinter)
		Me.tabControl1.Controls.Add(Me.tabPageRun)
		Me.tabControl1.Controls.Add(Me.tabPageDesktop)
		Me.tabControl1.Controls.Add(Me.tabPageWireless)
		Me.tabControl1.Dock = CType(resources.GetObject("tabControl1.Dock"),System.Windows.Forms.DockStyle)
		Me.tabControl1.Font = Nothing
		Me.tabControl1.ImeMode = CType(resources.GetObject("tabControl1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabControl1.Location = CType(resources.GetObject("tabControl1.Location"),System.Drawing.Point)
		Me.tabControl1.Multiline = true
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.RightToLeft = CType(resources.GetObject("tabControl1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabControl1.RightToLeftLayout = CType(resources.GetObject("tabControl1.RightToLeftLayout"),Boolean)
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.ShowToolTips = CType(resources.GetObject("tabControl1.ShowToolTips"),Boolean)
		Me.tabControl1.Size = CType(resources.GetObject("tabControl1.Size"),System.Drawing.Size)
		Me.tabControl1.TabIndex = CType(resources.GetObject("tabControl1.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.tabControl1, resources.GetString("tabControl1.ToolTip"))
		'
		'tabPageIPSettings
		'
		Me.tabPageIPSettings.AccessibleDescription = Nothing
		Me.tabPageIPSettings.AccessibleName = Nothing
		Me.tabPageIPSettings.Anchor = CType(resources.GetObject("tabPageIPSettings.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPageIPSettings.AutoScroll = CType(resources.GetObject("tabPageIPSettings.AutoScroll"),Boolean)
		Me.tabPageIPSettings.BackgroundImage = Nothing
		Me.tabPageIPSettings.BackgroundImageLayout = CType(resources.GetObject("tabPageIPSettings.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPageIPSettings.Controls.Add(Me.buttonGetCurrentIPSettings)
		Me.tabPageIPSettings.Controls.Add(Me.checkBoxDHCP)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxWINSServer4)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxWINSServer3)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxWINSServer2)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxWINSServer1)
		Me.tabPageIPSettings.Controls.Add(Me.label24)
		Me.tabPageIPSettings.Controls.Add(Me.label25)
		Me.tabPageIPSettings.Controls.Add(Me.label26)
		Me.tabPageIPSettings.Controls.Add(Me.pictureBoxWINSServer)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxAlternateDNSServer4)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxAlternateDNSServer3)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxAlternateDNSServer2)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxAlternateDNSServer1)
		Me.tabPageIPSettings.Controls.Add(Me.label21)
		Me.tabPageIPSettings.Controls.Add(Me.label22)
		Me.tabPageIPSettings.Controls.Add(Me.label23)
		Me.tabPageIPSettings.Controls.Add(Me.pictureBoxAlternateDNSServer)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxPrimaryDNSServer4)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxPrimaryDNSServer3)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxPrimaryDNSServer2)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxPrimaryDNSServer1)
		Me.tabPageIPSettings.Controls.Add(Me.label18)
		Me.tabPageIPSettings.Controls.Add(Me.label19)
		Me.tabPageIPSettings.Controls.Add(Me.label20)
		Me.tabPageIPSettings.Controls.Add(Me.pictureBoxPrimaryDNSServer)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxDefaultGateway4)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxDefaultGateway3)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxDefaultGateway2)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxDefaultGateway1)
		Me.tabPageIPSettings.Controls.Add(Me.label15)
		Me.tabPageIPSettings.Controls.Add(Me.label16)
		Me.tabPageIPSettings.Controls.Add(Me.label17)
		Me.tabPageIPSettings.Controls.Add(Me.pictureBoxDefaultGateway)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxSubnetMask4)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxSubnetMask3)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxSubnetMask2)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxSubnetMask1)
		Me.tabPageIPSettings.Controls.Add(Me.label12)
		Me.tabPageIPSettings.Controls.Add(Me.label13)
		Me.tabPageIPSettings.Controls.Add(Me.label14)
		Me.tabPageIPSettings.Controls.Add(Me.pictureBoxSubnetMask)
		Me.tabPageIPSettings.Controls.Add(Me.labelWINSServer)
		Me.tabPageIPSettings.Controls.Add(Me.labelAlternateDNSServer)
		Me.tabPageIPSettings.Controls.Add(Me.labelPrimaryDNSServer)
		Me.tabPageIPSettings.Controls.Add(Me.labelDefaultGateway)
		Me.tabPageIPSettings.Controls.Add(Me.labelSubnetMask)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxIPAddress4)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxIPAddress3)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxIPAddress2)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxIPAddress1)
		Me.tabPageIPSettings.Controls.Add(Me.label9)
		Me.tabPageIPSettings.Controls.Add(Me.label8)
		Me.tabPageIPSettings.Controls.Add(Me.label7)
		Me.tabPageIPSettings.Controls.Add(Me.pictureBoxIPAddress)
		Me.tabPageIPSettings.Controls.Add(Me.labelIPAddress)
		Me.tabPageIPSettings.Dock = CType(resources.GetObject("tabPageIPSettings.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPageIPSettings.Font = Nothing
		Me.tabPageIPSettings.ImageIndex = CType(resources.GetObject("tabPageIPSettings.ImageIndex"),Integer)
		Me.tabPageIPSettings.ImageKey = resources.GetString("tabPageIPSettings.ImageKey")
		Me.tabPageIPSettings.ImeMode = CType(resources.GetObject("tabPageIPSettings.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPageIPSettings.Location = CType(resources.GetObject("tabPageIPSettings.Location"),System.Drawing.Point)
		Me.tabPageIPSettings.Name = "tabPageIPSettings"
		Me.tabPageIPSettings.Padding = CType(resources.GetObject("tabPageIPSettings.Padding"),System.Windows.Forms.Padding)
		Me.tabPageIPSettings.RightToLeft = CType(resources.GetObject("tabPageIPSettings.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPageIPSettings.Size = CType(resources.GetObject("tabPageIPSettings.Size"),System.Drawing.Size)
		Me.tabPageIPSettings.TabIndex = CType(resources.GetObject("tabPageIPSettings.TabIndex"),Integer)
		Me.tabPageIPSettings.Text = resources.GetString("tabPageIPSettings.Text")
		Me.toolTip1.SetToolTip(Me.tabPageIPSettings, resources.GetString("tabPageIPSettings.ToolTip"))
		Me.tabPageIPSettings.ToolTipText = resources.GetString("tabPageIPSettings.ToolTipText")
		Me.tabPageIPSettings.UseVisualStyleBackColor = true
		'
		'buttonGetCurrentIPSettings
		'
		Me.buttonGetCurrentIPSettings.AccessibleDescription = Nothing
		Me.buttonGetCurrentIPSettings.AccessibleName = Nothing
		Me.buttonGetCurrentIPSettings.Anchor = CType(resources.GetObject("buttonGetCurrentIPSettings.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonGetCurrentIPSettings.AutoEllipsis = true
		Me.buttonGetCurrentIPSettings.AutoSize = CType(resources.GetObject("buttonGetCurrentIPSettings.AutoSize"),Boolean)
		Me.buttonGetCurrentIPSettings.AutoSizeMode = CType(resources.GetObject("buttonGetCurrentIPSettings.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonGetCurrentIPSettings.BackgroundImage = Nothing
		Me.buttonGetCurrentIPSettings.BackgroundImageLayout = CType(resources.GetObject("buttonGetCurrentIPSettings.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonGetCurrentIPSettings.Dock = CType(resources.GetObject("buttonGetCurrentIPSettings.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonGetCurrentIPSettings.FlatStyle = CType(resources.GetObject("buttonGetCurrentIPSettings.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonGetCurrentIPSettings.Font = Nothing
		Me.buttonGetCurrentIPSettings.Image = CType(resources.GetObject("buttonGetCurrentIPSettings.Image"),System.Drawing.Image)
		Me.buttonGetCurrentIPSettings.ImageAlign = CType(resources.GetObject("buttonGetCurrentIPSettings.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonGetCurrentIPSettings.ImageIndex = CType(resources.GetObject("buttonGetCurrentIPSettings.ImageIndex"),Integer)
		Me.buttonGetCurrentIPSettings.ImageKey = resources.GetString("buttonGetCurrentIPSettings.ImageKey")
		Me.buttonGetCurrentIPSettings.ImeMode = CType(resources.GetObject("buttonGetCurrentIPSettings.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonGetCurrentIPSettings.Location = CType(resources.GetObject("buttonGetCurrentIPSettings.Location"),System.Drawing.Point)
		Me.buttonGetCurrentIPSettings.Name = "buttonGetCurrentIPSettings"
		Me.buttonGetCurrentIPSettings.RightToLeft = CType(resources.GetObject("buttonGetCurrentIPSettings.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonGetCurrentIPSettings.Size = CType(resources.GetObject("buttonGetCurrentIPSettings.Size"),System.Drawing.Size)
		Me.buttonGetCurrentIPSettings.TabIndex = CType(resources.GetObject("buttonGetCurrentIPSettings.TabIndex"),Integer)
		Me.buttonGetCurrentIPSettings.Text = resources.GetString("buttonGetCurrentIPSettings.Text")
		Me.buttonGetCurrentIPSettings.TextAlign = CType(resources.GetObject("buttonGetCurrentIPSettings.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonGetCurrentIPSettings.TextImageRelation = CType(resources.GetObject("buttonGetCurrentIPSettings.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonGetCurrentIPSettings, resources.GetString("buttonGetCurrentIPSettings.ToolTip"))
		Me.buttonGetCurrentIPSettings.UseVisualStyleBackColor = true
		AddHandler Me.buttonGetCurrentIPSettings.Click, AddressOf Me.ButtonGetCurrentIPSettingsClick
		'
		'checkBoxDHCP
		'
		Me.checkBoxDHCP.AccessibleDescription = Nothing
		Me.checkBoxDHCP.AccessibleName = Nothing
		Me.checkBoxDHCP.Anchor = CType(resources.GetObject("checkBoxDHCP.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.checkBoxDHCP.Appearance = CType(resources.GetObject("checkBoxDHCP.Appearance"),System.Windows.Forms.Appearance)
		Me.checkBoxDHCP.AutoSize = CType(resources.GetObject("checkBoxDHCP.AutoSize"),Boolean)
		Me.checkBoxDHCP.BackgroundImage = Nothing
		Me.checkBoxDHCP.BackgroundImageLayout = CType(resources.GetObject("checkBoxDHCP.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkBoxDHCP.CheckAlign = CType(resources.GetObject("checkBoxDHCP.CheckAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxDHCP.Dock = CType(resources.GetObject("checkBoxDHCP.Dock"),System.Windows.Forms.DockStyle)
		Me.checkBoxDHCP.FlatStyle = CType(resources.GetObject("checkBoxDHCP.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.checkBoxDHCP.Font = Nothing
		Me.checkBoxDHCP.ImageAlign = CType(resources.GetObject("checkBoxDHCP.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxDHCP.ImageIndex = CType(resources.GetObject("checkBoxDHCP.ImageIndex"),Integer)
		Me.checkBoxDHCP.ImageKey = resources.GetString("checkBoxDHCP.ImageKey")
		Me.checkBoxDHCP.ImeMode = CType(resources.GetObject("checkBoxDHCP.ImeMode"),System.Windows.Forms.ImeMode)
		Me.checkBoxDHCP.Location = CType(resources.GetObject("checkBoxDHCP.Location"),System.Drawing.Point)
		Me.checkBoxDHCP.Name = "checkBoxDHCP"
		Me.checkBoxDHCP.RightToLeft = CType(resources.GetObject("checkBoxDHCP.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.checkBoxDHCP.Size = CType(resources.GetObject("checkBoxDHCP.Size"),System.Drawing.Size)
		Me.checkBoxDHCP.TabIndex = CType(resources.GetObject("checkBoxDHCP.TabIndex"),Integer)
		Me.checkBoxDHCP.Text = resources.GetString("checkBoxDHCP.Text")
		Me.checkBoxDHCP.TextAlign = CType(resources.GetObject("checkBoxDHCP.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxDHCP.TextImageRelation = CType(resources.GetObject("checkBoxDHCP.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.checkBoxDHCP, resources.GetString("checkBoxDHCP.ToolTip"))
		Me.checkBoxDHCP.UseVisualStyleBackColor = true
		AddHandler Me.checkBoxDHCP.CheckedChanged, AddressOf Me.CheckBoxDHCPCheckedChanged
		'
		'textBoxWINSServer4
		'
		Me.textBoxWINSServer4.AccessibleDescription = Nothing
		Me.textBoxWINSServer4.AccessibleName = Nothing
		Me.textBoxWINSServer4.Anchor = CType(resources.GetObject("textBoxWINSServer4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxWINSServer4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer4.BackgroundImage = Nothing
		Me.textBoxWINSServer4.BackgroundImageLayout = CType(resources.GetObject("textBoxWINSServer4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxWINSServer4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxWINSServer4.Dock = CType(resources.GetObject("textBoxWINSServer4.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxWINSServer4.Font = Nothing
		Me.textBoxWINSServer4.ImeMode = CType(resources.GetObject("textBoxWINSServer4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxWINSServer4.Location = CType(resources.GetObject("textBoxWINSServer4.Location"),System.Drawing.Point)
		Me.textBoxWINSServer4.MaxLength = CType(resources.GetObject("textBoxWINSServer4.MaxLength"),Integer)
		Me.textBoxWINSServer4.Multiline = CType(resources.GetObject("textBoxWINSServer4.Multiline"),Boolean)
		Me.textBoxWINSServer4.Name = "textBoxWINSServer4"
		Me.textBoxWINSServer4.PasswordChar = CType(resources.GetObject("textBoxWINSServer4.PasswordChar"),Char)
		Me.textBoxWINSServer4.RightToLeft = CType(resources.GetObject("textBoxWINSServer4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxWINSServer4.ScrollBars = CType(resources.GetObject("textBoxWINSServer4.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxWINSServer4.Size = CType(resources.GetObject("textBoxWINSServer4.Size"),System.Drawing.Size)
		Me.textBoxWINSServer4.TabIndex = CType(resources.GetObject("textBoxWINSServer4.TabIndex"),Integer)
		Me.textBoxWINSServer4.TabStop = false
		Me.textBoxWINSServer4.TextAlign = CType(resources.GetObject("textBoxWINSServer4.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxWINSServer4, resources.GetString("textBoxWINSServer4.ToolTip"))
		Me.textBoxWINSServer4.WordWrap = CType(resources.GetObject("textBoxWINSServer4.WordWrap"),Boolean)
		AddHandler Me.textBoxWINSServer4.KeyPress, AddressOf Me.TextBoxWINSServer4KeyPress
		'
		'textBoxWINSServer3
		'
		Me.textBoxWINSServer3.AccessibleDescription = Nothing
		Me.textBoxWINSServer3.AccessibleName = Nothing
		Me.textBoxWINSServer3.Anchor = CType(resources.GetObject("textBoxWINSServer3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxWINSServer3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer3.BackgroundImage = Nothing
		Me.textBoxWINSServer3.BackgroundImageLayout = CType(resources.GetObject("textBoxWINSServer3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxWINSServer3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxWINSServer3.Dock = CType(resources.GetObject("textBoxWINSServer3.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxWINSServer3.Font = Nothing
		Me.textBoxWINSServer3.ImeMode = CType(resources.GetObject("textBoxWINSServer3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxWINSServer3.Location = CType(resources.GetObject("textBoxWINSServer3.Location"),System.Drawing.Point)
		Me.textBoxWINSServer3.MaxLength = CType(resources.GetObject("textBoxWINSServer3.MaxLength"),Integer)
		Me.textBoxWINSServer3.Multiline = CType(resources.GetObject("textBoxWINSServer3.Multiline"),Boolean)
		Me.textBoxWINSServer3.Name = "textBoxWINSServer3"
		Me.textBoxWINSServer3.PasswordChar = CType(resources.GetObject("textBoxWINSServer3.PasswordChar"),Char)
		Me.textBoxWINSServer3.RightToLeft = CType(resources.GetObject("textBoxWINSServer3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxWINSServer3.ScrollBars = CType(resources.GetObject("textBoxWINSServer3.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxWINSServer3.Size = CType(resources.GetObject("textBoxWINSServer3.Size"),System.Drawing.Size)
		Me.textBoxWINSServer3.TabIndex = CType(resources.GetObject("textBoxWINSServer3.TabIndex"),Integer)
		Me.textBoxWINSServer3.TabStop = false
		Me.textBoxWINSServer3.TextAlign = CType(resources.GetObject("textBoxWINSServer3.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxWINSServer3, resources.GetString("textBoxWINSServer3.ToolTip"))
		Me.textBoxWINSServer3.WordWrap = CType(resources.GetObject("textBoxWINSServer3.WordWrap"),Boolean)
		AddHandler Me.textBoxWINSServer3.KeyPress, AddressOf Me.TextBoxWINSServer3KeyPress
		'
		'textBoxWINSServer2
		'
		Me.textBoxWINSServer2.AccessibleDescription = Nothing
		Me.textBoxWINSServer2.AccessibleName = Nothing
		Me.textBoxWINSServer2.Anchor = CType(resources.GetObject("textBoxWINSServer2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxWINSServer2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer2.BackgroundImage = Nothing
		Me.textBoxWINSServer2.BackgroundImageLayout = CType(resources.GetObject("textBoxWINSServer2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxWINSServer2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxWINSServer2.Dock = CType(resources.GetObject("textBoxWINSServer2.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxWINSServer2.Font = Nothing
		Me.textBoxWINSServer2.ImeMode = CType(resources.GetObject("textBoxWINSServer2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxWINSServer2.Location = CType(resources.GetObject("textBoxWINSServer2.Location"),System.Drawing.Point)
		Me.textBoxWINSServer2.MaxLength = CType(resources.GetObject("textBoxWINSServer2.MaxLength"),Integer)
		Me.textBoxWINSServer2.Multiline = CType(resources.GetObject("textBoxWINSServer2.Multiline"),Boolean)
		Me.textBoxWINSServer2.Name = "textBoxWINSServer2"
		Me.textBoxWINSServer2.PasswordChar = CType(resources.GetObject("textBoxWINSServer2.PasswordChar"),Char)
		Me.textBoxWINSServer2.RightToLeft = CType(resources.GetObject("textBoxWINSServer2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxWINSServer2.ScrollBars = CType(resources.GetObject("textBoxWINSServer2.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxWINSServer2.Size = CType(resources.GetObject("textBoxWINSServer2.Size"),System.Drawing.Size)
		Me.textBoxWINSServer2.TabIndex = CType(resources.GetObject("textBoxWINSServer2.TabIndex"),Integer)
		Me.textBoxWINSServer2.TabStop = false
		Me.textBoxWINSServer2.TextAlign = CType(resources.GetObject("textBoxWINSServer2.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxWINSServer2, resources.GetString("textBoxWINSServer2.ToolTip"))
		Me.textBoxWINSServer2.WordWrap = CType(resources.GetObject("textBoxWINSServer2.WordWrap"),Boolean)
		AddHandler Me.textBoxWINSServer2.KeyPress, AddressOf Me.TextBoxWINSServer2KeyPress
		'
		'textBoxWINSServer1
		'
		Me.textBoxWINSServer1.AccessibleDescription = Nothing
		Me.textBoxWINSServer1.AccessibleName = Nothing
		Me.textBoxWINSServer1.Anchor = CType(resources.GetObject("textBoxWINSServer1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxWINSServer1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer1.BackgroundImage = Nothing
		Me.textBoxWINSServer1.BackgroundImageLayout = CType(resources.GetObject("textBoxWINSServer1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxWINSServer1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxWINSServer1.Dock = CType(resources.GetObject("textBoxWINSServer1.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxWINSServer1.Font = Nothing
		Me.textBoxWINSServer1.ImeMode = CType(resources.GetObject("textBoxWINSServer1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxWINSServer1.Location = CType(resources.GetObject("textBoxWINSServer1.Location"),System.Drawing.Point)
		Me.textBoxWINSServer1.MaxLength = CType(resources.GetObject("textBoxWINSServer1.MaxLength"),Integer)
		Me.textBoxWINSServer1.Multiline = CType(resources.GetObject("textBoxWINSServer1.Multiline"),Boolean)
		Me.textBoxWINSServer1.Name = "textBoxWINSServer1"
		Me.textBoxWINSServer1.PasswordChar = CType(resources.GetObject("textBoxWINSServer1.PasswordChar"),Char)
		Me.textBoxWINSServer1.RightToLeft = CType(resources.GetObject("textBoxWINSServer1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxWINSServer1.ScrollBars = CType(resources.GetObject("textBoxWINSServer1.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxWINSServer1.Size = CType(resources.GetObject("textBoxWINSServer1.Size"),System.Drawing.Size)
		Me.textBoxWINSServer1.TabIndex = CType(resources.GetObject("textBoxWINSServer1.TabIndex"),Integer)
		Me.textBoxWINSServer1.TextAlign = CType(resources.GetObject("textBoxWINSServer1.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxWINSServer1, resources.GetString("textBoxWINSServer1.ToolTip"))
		Me.textBoxWINSServer1.WordWrap = CType(resources.GetObject("textBoxWINSServer1.WordWrap"),Boolean)
		AddHandler Me.textBoxWINSServer1.KeyPress, AddressOf Me.TextBoxWINSServer1KeyPress
		'
		'label24
		'
		Me.label24.AccessibleDescription = Nothing
		Me.label24.AccessibleName = Nothing
		Me.label24.Anchor = CType(resources.GetObject("label24.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label24.AutoSize = CType(resources.GetObject("label24.AutoSize"),Boolean)
		Me.label24.BackColor = System.Drawing.SystemColors.Window
		Me.label24.BackgroundImageLayout = CType(resources.GetObject("label24.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label24.Dock = CType(resources.GetObject("label24.Dock"),System.Windows.Forms.DockStyle)
		Me.label24.Font = Nothing
		Me.label24.ImageAlign = CType(resources.GetObject("label24.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label24.ImageIndex = CType(resources.GetObject("label24.ImageIndex"),Integer)
		Me.label24.ImageKey = resources.GetString("label24.ImageKey")
		Me.label24.ImeMode = CType(resources.GetObject("label24.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label24.Location = CType(resources.GetObject("label24.Location"),System.Drawing.Point)
		Me.label24.Name = "label24"
		Me.label24.RightToLeft = CType(resources.GetObject("label24.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label24.Size = CType(resources.GetObject("label24.Size"),System.Drawing.Size)
		Me.label24.TabIndex = CType(resources.GetObject("label24.TabIndex"),Integer)
		Me.label24.Text = resources.GetString("label24.Text")
		Me.label24.TextAlign = CType(resources.GetObject("label24.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label24, resources.GetString("label24.ToolTip"))
		'
		'label25
		'
		Me.label25.AccessibleDescription = Nothing
		Me.label25.AccessibleName = Nothing
		Me.label25.Anchor = CType(resources.GetObject("label25.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label25.AutoSize = CType(resources.GetObject("label25.AutoSize"),Boolean)
		Me.label25.BackColor = System.Drawing.SystemColors.Window
		Me.label25.BackgroundImageLayout = CType(resources.GetObject("label25.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label25.Dock = CType(resources.GetObject("label25.Dock"),System.Windows.Forms.DockStyle)
		Me.label25.Font = Nothing
		Me.label25.ImageAlign = CType(resources.GetObject("label25.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label25.ImageIndex = CType(resources.GetObject("label25.ImageIndex"),Integer)
		Me.label25.ImageKey = resources.GetString("label25.ImageKey")
		Me.label25.ImeMode = CType(resources.GetObject("label25.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label25.Location = CType(resources.GetObject("label25.Location"),System.Drawing.Point)
		Me.label25.Name = "label25"
		Me.label25.RightToLeft = CType(resources.GetObject("label25.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label25.Size = CType(resources.GetObject("label25.Size"),System.Drawing.Size)
		Me.label25.TabIndex = CType(resources.GetObject("label25.TabIndex"),Integer)
		Me.label25.Text = resources.GetString("label25.Text")
		Me.label25.TextAlign = CType(resources.GetObject("label25.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label25, resources.GetString("label25.ToolTip"))
		'
		'label26
		'
		Me.label26.AccessibleDescription = Nothing
		Me.label26.AccessibleName = Nothing
		Me.label26.Anchor = CType(resources.GetObject("label26.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label26.AutoSize = CType(resources.GetObject("label26.AutoSize"),Boolean)
		Me.label26.BackColor = System.Drawing.SystemColors.Window
		Me.label26.BackgroundImageLayout = CType(resources.GetObject("label26.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label26.Dock = CType(resources.GetObject("label26.Dock"),System.Windows.Forms.DockStyle)
		Me.label26.Font = Nothing
		Me.label26.ImageAlign = CType(resources.GetObject("label26.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label26.ImageIndex = CType(resources.GetObject("label26.ImageIndex"),Integer)
		Me.label26.ImageKey = resources.GetString("label26.ImageKey")
		Me.label26.ImeMode = CType(resources.GetObject("label26.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label26.Location = CType(resources.GetObject("label26.Location"),System.Drawing.Point)
		Me.label26.Name = "label26"
		Me.label26.RightToLeft = CType(resources.GetObject("label26.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label26.Size = CType(resources.GetObject("label26.Size"),System.Drawing.Size)
		Me.label26.TabIndex = CType(resources.GetObject("label26.TabIndex"),Integer)
		Me.label26.Text = resources.GetString("label26.Text")
		Me.label26.TextAlign = CType(resources.GetObject("label26.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label26, resources.GetString("label26.ToolTip"))
		'
		'pictureBoxWINSServer
		'
		Me.pictureBoxWINSServer.AccessibleDescription = Nothing
		Me.pictureBoxWINSServer.AccessibleName = Nothing
		Me.pictureBoxWINSServer.Anchor = CType(resources.GetObject("pictureBoxWINSServer.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxWINSServer.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxWINSServer.BackgroundImage = Nothing
		Me.pictureBoxWINSServer.BackgroundImageLayout = CType(resources.GetObject("pictureBoxWINSServer.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxWINSServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxWINSServer.Dock = CType(resources.GetObject("pictureBoxWINSServer.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxWINSServer.Font = Nothing
		Me.pictureBoxWINSServer.ImageLocation = Nothing
		Me.pictureBoxWINSServer.ImeMode = CType(resources.GetObject("pictureBoxWINSServer.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxWINSServer.Location = CType(resources.GetObject("pictureBoxWINSServer.Location"),System.Drawing.Point)
		Me.pictureBoxWINSServer.Name = "pictureBoxWINSServer"
		Me.pictureBoxWINSServer.RightToLeft = CType(resources.GetObject("pictureBoxWINSServer.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxWINSServer.Size = CType(resources.GetObject("pictureBoxWINSServer.Size"),System.Drawing.Size)
		Me.pictureBoxWINSServer.SizeMode = CType(resources.GetObject("pictureBoxWINSServer.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxWINSServer.TabIndex = CType(resources.GetObject("pictureBoxWINSServer.TabIndex"),Integer)
		Me.pictureBoxWINSServer.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxWINSServer, resources.GetString("pictureBoxWINSServer.ToolTip"))
		Me.pictureBoxWINSServer.WaitOnLoad = CType(resources.GetObject("pictureBoxWINSServer.WaitOnLoad"),Boolean)
		'
		'textBoxAlternateDNSServer4
		'
		Me.textBoxAlternateDNSServer4.AccessibleDescription = Nothing
		Me.textBoxAlternateDNSServer4.AccessibleName = Nothing
		Me.textBoxAlternateDNSServer4.Anchor = CType(resources.GetObject("textBoxAlternateDNSServer4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxAlternateDNSServer4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer4.BackgroundImage = Nothing
		Me.textBoxAlternateDNSServer4.BackgroundImageLayout = CType(resources.GetObject("textBoxAlternateDNSServer4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxAlternateDNSServer4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxAlternateDNSServer4.Dock = CType(resources.GetObject("textBoxAlternateDNSServer4.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxAlternateDNSServer4.Font = Nothing
		Me.textBoxAlternateDNSServer4.ImeMode = CType(resources.GetObject("textBoxAlternateDNSServer4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxAlternateDNSServer4.Location = CType(resources.GetObject("textBoxAlternateDNSServer4.Location"),System.Drawing.Point)
		Me.textBoxAlternateDNSServer4.MaxLength = CType(resources.GetObject("textBoxAlternateDNSServer4.MaxLength"),Integer)
		Me.textBoxAlternateDNSServer4.Multiline = CType(resources.GetObject("textBoxAlternateDNSServer4.Multiline"),Boolean)
		Me.textBoxAlternateDNSServer4.Name = "textBoxAlternateDNSServer4"
		Me.textBoxAlternateDNSServer4.PasswordChar = CType(resources.GetObject("textBoxAlternateDNSServer4.PasswordChar"),Char)
		Me.textBoxAlternateDNSServer4.RightToLeft = CType(resources.GetObject("textBoxAlternateDNSServer4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxAlternateDNSServer4.ScrollBars = CType(resources.GetObject("textBoxAlternateDNSServer4.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxAlternateDNSServer4.Size = CType(resources.GetObject("textBoxAlternateDNSServer4.Size"),System.Drawing.Size)
		Me.textBoxAlternateDNSServer4.TabIndex = CType(resources.GetObject("textBoxAlternateDNSServer4.TabIndex"),Integer)
		Me.textBoxAlternateDNSServer4.TabStop = false
		Me.textBoxAlternateDNSServer4.TextAlign = CType(resources.GetObject("textBoxAlternateDNSServer4.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxAlternateDNSServer4, resources.GetString("textBoxAlternateDNSServer4.ToolTip"))
		Me.textBoxAlternateDNSServer4.WordWrap = CType(resources.GetObject("textBoxAlternateDNSServer4.WordWrap"),Boolean)
		AddHandler Me.textBoxAlternateDNSServer4.KeyPress, AddressOf Me.TextBoxAlternateDNSServer4KeyPress
		'
		'textBoxAlternateDNSServer3
		'
		Me.textBoxAlternateDNSServer3.AccessibleDescription = Nothing
		Me.textBoxAlternateDNSServer3.AccessibleName = Nothing
		Me.textBoxAlternateDNSServer3.Anchor = CType(resources.GetObject("textBoxAlternateDNSServer3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxAlternateDNSServer3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer3.BackgroundImage = Nothing
		Me.textBoxAlternateDNSServer3.BackgroundImageLayout = CType(resources.GetObject("textBoxAlternateDNSServer3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxAlternateDNSServer3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxAlternateDNSServer3.Dock = CType(resources.GetObject("textBoxAlternateDNSServer3.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxAlternateDNSServer3.Font = Nothing
		Me.textBoxAlternateDNSServer3.ImeMode = CType(resources.GetObject("textBoxAlternateDNSServer3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxAlternateDNSServer3.Location = CType(resources.GetObject("textBoxAlternateDNSServer3.Location"),System.Drawing.Point)
		Me.textBoxAlternateDNSServer3.MaxLength = CType(resources.GetObject("textBoxAlternateDNSServer3.MaxLength"),Integer)
		Me.textBoxAlternateDNSServer3.Multiline = CType(resources.GetObject("textBoxAlternateDNSServer3.Multiline"),Boolean)
		Me.textBoxAlternateDNSServer3.Name = "textBoxAlternateDNSServer3"
		Me.textBoxAlternateDNSServer3.PasswordChar = CType(resources.GetObject("textBoxAlternateDNSServer3.PasswordChar"),Char)
		Me.textBoxAlternateDNSServer3.RightToLeft = CType(resources.GetObject("textBoxAlternateDNSServer3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxAlternateDNSServer3.ScrollBars = CType(resources.GetObject("textBoxAlternateDNSServer3.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxAlternateDNSServer3.Size = CType(resources.GetObject("textBoxAlternateDNSServer3.Size"),System.Drawing.Size)
		Me.textBoxAlternateDNSServer3.TabIndex = CType(resources.GetObject("textBoxAlternateDNSServer3.TabIndex"),Integer)
		Me.textBoxAlternateDNSServer3.TabStop = false
		Me.textBoxAlternateDNSServer3.TextAlign = CType(resources.GetObject("textBoxAlternateDNSServer3.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxAlternateDNSServer3, resources.GetString("textBoxAlternateDNSServer3.ToolTip"))
		Me.textBoxAlternateDNSServer3.WordWrap = CType(resources.GetObject("textBoxAlternateDNSServer3.WordWrap"),Boolean)
		AddHandler Me.textBoxAlternateDNSServer3.KeyPress, AddressOf Me.TextBoxAlternateDNSServer3KeyPress
		'
		'textBoxAlternateDNSServer2
		'
		Me.textBoxAlternateDNSServer2.AccessibleDescription = Nothing
		Me.textBoxAlternateDNSServer2.AccessibleName = Nothing
		Me.textBoxAlternateDNSServer2.Anchor = CType(resources.GetObject("textBoxAlternateDNSServer2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxAlternateDNSServer2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer2.BackgroundImage = Nothing
		Me.textBoxAlternateDNSServer2.BackgroundImageLayout = CType(resources.GetObject("textBoxAlternateDNSServer2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxAlternateDNSServer2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxAlternateDNSServer2.Dock = CType(resources.GetObject("textBoxAlternateDNSServer2.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxAlternateDNSServer2.Font = Nothing
		Me.textBoxAlternateDNSServer2.ImeMode = CType(resources.GetObject("textBoxAlternateDNSServer2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxAlternateDNSServer2.Location = CType(resources.GetObject("textBoxAlternateDNSServer2.Location"),System.Drawing.Point)
		Me.textBoxAlternateDNSServer2.MaxLength = CType(resources.GetObject("textBoxAlternateDNSServer2.MaxLength"),Integer)
		Me.textBoxAlternateDNSServer2.Multiline = CType(resources.GetObject("textBoxAlternateDNSServer2.Multiline"),Boolean)
		Me.textBoxAlternateDNSServer2.Name = "textBoxAlternateDNSServer2"
		Me.textBoxAlternateDNSServer2.PasswordChar = CType(resources.GetObject("textBoxAlternateDNSServer2.PasswordChar"),Char)
		Me.textBoxAlternateDNSServer2.RightToLeft = CType(resources.GetObject("textBoxAlternateDNSServer2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxAlternateDNSServer2.ScrollBars = CType(resources.GetObject("textBoxAlternateDNSServer2.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxAlternateDNSServer2.Size = CType(resources.GetObject("textBoxAlternateDNSServer2.Size"),System.Drawing.Size)
		Me.textBoxAlternateDNSServer2.TabIndex = CType(resources.GetObject("textBoxAlternateDNSServer2.TabIndex"),Integer)
		Me.textBoxAlternateDNSServer2.TabStop = false
		Me.textBoxAlternateDNSServer2.TextAlign = CType(resources.GetObject("textBoxAlternateDNSServer2.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxAlternateDNSServer2, resources.GetString("textBoxAlternateDNSServer2.ToolTip"))
		Me.textBoxAlternateDNSServer2.WordWrap = CType(resources.GetObject("textBoxAlternateDNSServer2.WordWrap"),Boolean)
		AddHandler Me.textBoxAlternateDNSServer2.KeyPress, AddressOf Me.TextBoxAlternateDNSServer2KeyPress
		'
		'textBoxAlternateDNSServer1
		'
		Me.textBoxAlternateDNSServer1.AccessibleDescription = Nothing
		Me.textBoxAlternateDNSServer1.AccessibleName = Nothing
		Me.textBoxAlternateDNSServer1.Anchor = CType(resources.GetObject("textBoxAlternateDNSServer1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxAlternateDNSServer1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer1.BackgroundImage = Nothing
		Me.textBoxAlternateDNSServer1.BackgroundImageLayout = CType(resources.GetObject("textBoxAlternateDNSServer1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxAlternateDNSServer1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxAlternateDNSServer1.Dock = CType(resources.GetObject("textBoxAlternateDNSServer1.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxAlternateDNSServer1.Font = Nothing
		Me.textBoxAlternateDNSServer1.ImeMode = CType(resources.GetObject("textBoxAlternateDNSServer1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxAlternateDNSServer1.Location = CType(resources.GetObject("textBoxAlternateDNSServer1.Location"),System.Drawing.Point)
		Me.textBoxAlternateDNSServer1.MaxLength = CType(resources.GetObject("textBoxAlternateDNSServer1.MaxLength"),Integer)
		Me.textBoxAlternateDNSServer1.Multiline = CType(resources.GetObject("textBoxAlternateDNSServer1.Multiline"),Boolean)
		Me.textBoxAlternateDNSServer1.Name = "textBoxAlternateDNSServer1"
		Me.textBoxAlternateDNSServer1.PasswordChar = CType(resources.GetObject("textBoxAlternateDNSServer1.PasswordChar"),Char)
		Me.textBoxAlternateDNSServer1.RightToLeft = CType(resources.GetObject("textBoxAlternateDNSServer1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxAlternateDNSServer1.ScrollBars = CType(resources.GetObject("textBoxAlternateDNSServer1.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxAlternateDNSServer1.Size = CType(resources.GetObject("textBoxAlternateDNSServer1.Size"),System.Drawing.Size)
		Me.textBoxAlternateDNSServer1.TabIndex = CType(resources.GetObject("textBoxAlternateDNSServer1.TabIndex"),Integer)
		Me.textBoxAlternateDNSServer1.TextAlign = CType(resources.GetObject("textBoxAlternateDNSServer1.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxAlternateDNSServer1, resources.GetString("textBoxAlternateDNSServer1.ToolTip"))
		Me.textBoxAlternateDNSServer1.WordWrap = CType(resources.GetObject("textBoxAlternateDNSServer1.WordWrap"),Boolean)
		AddHandler Me.textBoxAlternateDNSServer1.KeyPress, AddressOf Me.TextBoxAlternateDNSServer1KeyPress
		'
		'label21
		'
		Me.label21.AccessibleDescription = Nothing
		Me.label21.AccessibleName = Nothing
		Me.label21.Anchor = CType(resources.GetObject("label21.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label21.AutoSize = CType(resources.GetObject("label21.AutoSize"),Boolean)
		Me.label21.BackColor = System.Drawing.SystemColors.Window
		Me.label21.BackgroundImageLayout = CType(resources.GetObject("label21.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label21.Dock = CType(resources.GetObject("label21.Dock"),System.Windows.Forms.DockStyle)
		Me.label21.Font = Nothing
		Me.label21.ImageAlign = CType(resources.GetObject("label21.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label21.ImageIndex = CType(resources.GetObject("label21.ImageIndex"),Integer)
		Me.label21.ImageKey = resources.GetString("label21.ImageKey")
		Me.label21.ImeMode = CType(resources.GetObject("label21.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label21.Location = CType(resources.GetObject("label21.Location"),System.Drawing.Point)
		Me.label21.Name = "label21"
		Me.label21.RightToLeft = CType(resources.GetObject("label21.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label21.Size = CType(resources.GetObject("label21.Size"),System.Drawing.Size)
		Me.label21.TabIndex = CType(resources.GetObject("label21.TabIndex"),Integer)
		Me.label21.Text = resources.GetString("label21.Text")
		Me.label21.TextAlign = CType(resources.GetObject("label21.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label21, resources.GetString("label21.ToolTip"))
		'
		'label22
		'
		Me.label22.AccessibleDescription = Nothing
		Me.label22.AccessibleName = Nothing
		Me.label22.Anchor = CType(resources.GetObject("label22.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label22.AutoSize = CType(resources.GetObject("label22.AutoSize"),Boolean)
		Me.label22.BackColor = System.Drawing.SystemColors.Window
		Me.label22.BackgroundImageLayout = CType(resources.GetObject("label22.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label22.Dock = CType(resources.GetObject("label22.Dock"),System.Windows.Forms.DockStyle)
		Me.label22.Font = Nothing
		Me.label22.ImageAlign = CType(resources.GetObject("label22.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label22.ImageIndex = CType(resources.GetObject("label22.ImageIndex"),Integer)
		Me.label22.ImageKey = resources.GetString("label22.ImageKey")
		Me.label22.ImeMode = CType(resources.GetObject("label22.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label22.Location = CType(resources.GetObject("label22.Location"),System.Drawing.Point)
		Me.label22.Name = "label22"
		Me.label22.RightToLeft = CType(resources.GetObject("label22.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label22.Size = CType(resources.GetObject("label22.Size"),System.Drawing.Size)
		Me.label22.TabIndex = CType(resources.GetObject("label22.TabIndex"),Integer)
		Me.label22.Text = resources.GetString("label22.Text")
		Me.label22.TextAlign = CType(resources.GetObject("label22.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label22, resources.GetString("label22.ToolTip"))
		'
		'label23
		'
		Me.label23.AccessibleDescription = Nothing
		Me.label23.AccessibleName = Nothing
		Me.label23.Anchor = CType(resources.GetObject("label23.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label23.AutoSize = CType(resources.GetObject("label23.AutoSize"),Boolean)
		Me.label23.BackColor = System.Drawing.SystemColors.Window
		Me.label23.BackgroundImageLayout = CType(resources.GetObject("label23.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label23.Dock = CType(resources.GetObject("label23.Dock"),System.Windows.Forms.DockStyle)
		Me.label23.Font = Nothing
		Me.label23.ImageAlign = CType(resources.GetObject("label23.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label23.ImageIndex = CType(resources.GetObject("label23.ImageIndex"),Integer)
		Me.label23.ImageKey = resources.GetString("label23.ImageKey")
		Me.label23.ImeMode = CType(resources.GetObject("label23.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label23.Location = CType(resources.GetObject("label23.Location"),System.Drawing.Point)
		Me.label23.Name = "label23"
		Me.label23.RightToLeft = CType(resources.GetObject("label23.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label23.Size = CType(resources.GetObject("label23.Size"),System.Drawing.Size)
		Me.label23.TabIndex = CType(resources.GetObject("label23.TabIndex"),Integer)
		Me.label23.Text = resources.GetString("label23.Text")
		Me.label23.TextAlign = CType(resources.GetObject("label23.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label23, resources.GetString("label23.ToolTip"))
		'
		'pictureBoxAlternateDNSServer
		'
		Me.pictureBoxAlternateDNSServer.AccessibleDescription = Nothing
		Me.pictureBoxAlternateDNSServer.AccessibleName = Nothing
		Me.pictureBoxAlternateDNSServer.Anchor = CType(resources.GetObject("pictureBoxAlternateDNSServer.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxAlternateDNSServer.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxAlternateDNSServer.BackgroundImage = Nothing
		Me.pictureBoxAlternateDNSServer.BackgroundImageLayout = CType(resources.GetObject("pictureBoxAlternateDNSServer.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxAlternateDNSServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxAlternateDNSServer.Dock = CType(resources.GetObject("pictureBoxAlternateDNSServer.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxAlternateDNSServer.Font = Nothing
		Me.pictureBoxAlternateDNSServer.ImageLocation = Nothing
		Me.pictureBoxAlternateDNSServer.ImeMode = CType(resources.GetObject("pictureBoxAlternateDNSServer.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxAlternateDNSServer.Location = CType(resources.GetObject("pictureBoxAlternateDNSServer.Location"),System.Drawing.Point)
		Me.pictureBoxAlternateDNSServer.Name = "pictureBoxAlternateDNSServer"
		Me.pictureBoxAlternateDNSServer.RightToLeft = CType(resources.GetObject("pictureBoxAlternateDNSServer.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxAlternateDNSServer.Size = CType(resources.GetObject("pictureBoxAlternateDNSServer.Size"),System.Drawing.Size)
		Me.pictureBoxAlternateDNSServer.SizeMode = CType(resources.GetObject("pictureBoxAlternateDNSServer.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxAlternateDNSServer.TabIndex = CType(resources.GetObject("pictureBoxAlternateDNSServer.TabIndex"),Integer)
		Me.pictureBoxAlternateDNSServer.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxAlternateDNSServer, resources.GetString("pictureBoxAlternateDNSServer.ToolTip"))
		Me.pictureBoxAlternateDNSServer.WaitOnLoad = CType(resources.GetObject("pictureBoxAlternateDNSServer.WaitOnLoad"),Boolean)
		'
		'textBoxPrimaryDNSServer4
		'
		Me.textBoxPrimaryDNSServer4.AccessibleDescription = Nothing
		Me.textBoxPrimaryDNSServer4.AccessibleName = Nothing
		Me.textBoxPrimaryDNSServer4.Anchor = CType(resources.GetObject("textBoxPrimaryDNSServer4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPrimaryDNSServer4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer4.BackgroundImage = Nothing
		Me.textBoxPrimaryDNSServer4.BackgroundImageLayout = CType(resources.GetObject("textBoxPrimaryDNSServer4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPrimaryDNSServer4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxPrimaryDNSServer4.Dock = CType(resources.GetObject("textBoxPrimaryDNSServer4.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPrimaryDNSServer4.Font = Nothing
		Me.textBoxPrimaryDNSServer4.ImeMode = CType(resources.GetObject("textBoxPrimaryDNSServer4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPrimaryDNSServer4.Location = CType(resources.GetObject("textBoxPrimaryDNSServer4.Location"),System.Drawing.Point)
		Me.textBoxPrimaryDNSServer4.MaxLength = CType(resources.GetObject("textBoxPrimaryDNSServer4.MaxLength"),Integer)
		Me.textBoxPrimaryDNSServer4.Multiline = CType(resources.GetObject("textBoxPrimaryDNSServer4.Multiline"),Boolean)
		Me.textBoxPrimaryDNSServer4.Name = "textBoxPrimaryDNSServer4"
		Me.textBoxPrimaryDNSServer4.PasswordChar = CType(resources.GetObject("textBoxPrimaryDNSServer4.PasswordChar"),Char)
		Me.textBoxPrimaryDNSServer4.RightToLeft = CType(resources.GetObject("textBoxPrimaryDNSServer4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPrimaryDNSServer4.ScrollBars = CType(resources.GetObject("textBoxPrimaryDNSServer4.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPrimaryDNSServer4.Size = CType(resources.GetObject("textBoxPrimaryDNSServer4.Size"),System.Drawing.Size)
		Me.textBoxPrimaryDNSServer4.TabIndex = CType(resources.GetObject("textBoxPrimaryDNSServer4.TabIndex"),Integer)
		Me.textBoxPrimaryDNSServer4.TabStop = false
		Me.textBoxPrimaryDNSServer4.TextAlign = CType(resources.GetObject("textBoxPrimaryDNSServer4.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxPrimaryDNSServer4, resources.GetString("textBoxPrimaryDNSServer4.ToolTip"))
		Me.textBoxPrimaryDNSServer4.WordWrap = CType(resources.GetObject("textBoxPrimaryDNSServer4.WordWrap"),Boolean)
		AddHandler Me.textBoxPrimaryDNSServer4.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer4KeyPress
		'
		'textBoxPrimaryDNSServer3
		'
		Me.textBoxPrimaryDNSServer3.AccessibleDescription = Nothing
		Me.textBoxPrimaryDNSServer3.AccessibleName = Nothing
		Me.textBoxPrimaryDNSServer3.Anchor = CType(resources.GetObject("textBoxPrimaryDNSServer3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPrimaryDNSServer3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer3.BackgroundImage = Nothing
		Me.textBoxPrimaryDNSServer3.BackgroundImageLayout = CType(resources.GetObject("textBoxPrimaryDNSServer3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPrimaryDNSServer3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxPrimaryDNSServer3.Dock = CType(resources.GetObject("textBoxPrimaryDNSServer3.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPrimaryDNSServer3.Font = Nothing
		Me.textBoxPrimaryDNSServer3.ImeMode = CType(resources.GetObject("textBoxPrimaryDNSServer3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPrimaryDNSServer3.Location = CType(resources.GetObject("textBoxPrimaryDNSServer3.Location"),System.Drawing.Point)
		Me.textBoxPrimaryDNSServer3.MaxLength = CType(resources.GetObject("textBoxPrimaryDNSServer3.MaxLength"),Integer)
		Me.textBoxPrimaryDNSServer3.Multiline = CType(resources.GetObject("textBoxPrimaryDNSServer3.Multiline"),Boolean)
		Me.textBoxPrimaryDNSServer3.Name = "textBoxPrimaryDNSServer3"
		Me.textBoxPrimaryDNSServer3.PasswordChar = CType(resources.GetObject("textBoxPrimaryDNSServer3.PasswordChar"),Char)
		Me.textBoxPrimaryDNSServer3.RightToLeft = CType(resources.GetObject("textBoxPrimaryDNSServer3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPrimaryDNSServer3.ScrollBars = CType(resources.GetObject("textBoxPrimaryDNSServer3.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPrimaryDNSServer3.Size = CType(resources.GetObject("textBoxPrimaryDNSServer3.Size"),System.Drawing.Size)
		Me.textBoxPrimaryDNSServer3.TabIndex = CType(resources.GetObject("textBoxPrimaryDNSServer3.TabIndex"),Integer)
		Me.textBoxPrimaryDNSServer3.TabStop = false
		Me.textBoxPrimaryDNSServer3.TextAlign = CType(resources.GetObject("textBoxPrimaryDNSServer3.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxPrimaryDNSServer3, resources.GetString("textBoxPrimaryDNSServer3.ToolTip"))
		Me.textBoxPrimaryDNSServer3.WordWrap = CType(resources.GetObject("textBoxPrimaryDNSServer3.WordWrap"),Boolean)
		AddHandler Me.textBoxPrimaryDNSServer3.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer3KeyPress
		'
		'textBoxPrimaryDNSServer2
		'
		Me.textBoxPrimaryDNSServer2.AccessibleDescription = Nothing
		Me.textBoxPrimaryDNSServer2.AccessibleName = Nothing
		Me.textBoxPrimaryDNSServer2.Anchor = CType(resources.GetObject("textBoxPrimaryDNSServer2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPrimaryDNSServer2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer2.BackgroundImage = Nothing
		Me.textBoxPrimaryDNSServer2.BackgroundImageLayout = CType(resources.GetObject("textBoxPrimaryDNSServer2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPrimaryDNSServer2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxPrimaryDNSServer2.Dock = CType(resources.GetObject("textBoxPrimaryDNSServer2.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPrimaryDNSServer2.Font = Nothing
		Me.textBoxPrimaryDNSServer2.ImeMode = CType(resources.GetObject("textBoxPrimaryDNSServer2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPrimaryDNSServer2.Location = CType(resources.GetObject("textBoxPrimaryDNSServer2.Location"),System.Drawing.Point)
		Me.textBoxPrimaryDNSServer2.MaxLength = CType(resources.GetObject("textBoxPrimaryDNSServer2.MaxLength"),Integer)
		Me.textBoxPrimaryDNSServer2.Multiline = CType(resources.GetObject("textBoxPrimaryDNSServer2.Multiline"),Boolean)
		Me.textBoxPrimaryDNSServer2.Name = "textBoxPrimaryDNSServer2"
		Me.textBoxPrimaryDNSServer2.PasswordChar = CType(resources.GetObject("textBoxPrimaryDNSServer2.PasswordChar"),Char)
		Me.textBoxPrimaryDNSServer2.RightToLeft = CType(resources.GetObject("textBoxPrimaryDNSServer2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPrimaryDNSServer2.ScrollBars = CType(resources.GetObject("textBoxPrimaryDNSServer2.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPrimaryDNSServer2.Size = CType(resources.GetObject("textBoxPrimaryDNSServer2.Size"),System.Drawing.Size)
		Me.textBoxPrimaryDNSServer2.TabIndex = CType(resources.GetObject("textBoxPrimaryDNSServer2.TabIndex"),Integer)
		Me.textBoxPrimaryDNSServer2.TabStop = false
		Me.textBoxPrimaryDNSServer2.TextAlign = CType(resources.GetObject("textBoxPrimaryDNSServer2.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxPrimaryDNSServer2, resources.GetString("textBoxPrimaryDNSServer2.ToolTip"))
		Me.textBoxPrimaryDNSServer2.WordWrap = CType(resources.GetObject("textBoxPrimaryDNSServer2.WordWrap"),Boolean)
		AddHandler Me.textBoxPrimaryDNSServer2.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer2KeyPress
		'
		'textBoxPrimaryDNSServer1
		'
		Me.textBoxPrimaryDNSServer1.AccessibleDescription = Nothing
		Me.textBoxPrimaryDNSServer1.AccessibleName = Nothing
		Me.textBoxPrimaryDNSServer1.Anchor = CType(resources.GetObject("textBoxPrimaryDNSServer1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPrimaryDNSServer1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer1.BackgroundImage = Nothing
		Me.textBoxPrimaryDNSServer1.BackgroundImageLayout = CType(resources.GetObject("textBoxPrimaryDNSServer1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPrimaryDNSServer1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxPrimaryDNSServer1.Dock = CType(resources.GetObject("textBoxPrimaryDNSServer1.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPrimaryDNSServer1.Font = Nothing
		Me.textBoxPrimaryDNSServer1.ImeMode = CType(resources.GetObject("textBoxPrimaryDNSServer1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPrimaryDNSServer1.Location = CType(resources.GetObject("textBoxPrimaryDNSServer1.Location"),System.Drawing.Point)
		Me.textBoxPrimaryDNSServer1.MaxLength = CType(resources.GetObject("textBoxPrimaryDNSServer1.MaxLength"),Integer)
		Me.textBoxPrimaryDNSServer1.Multiline = CType(resources.GetObject("textBoxPrimaryDNSServer1.Multiline"),Boolean)
		Me.textBoxPrimaryDNSServer1.Name = "textBoxPrimaryDNSServer1"
		Me.textBoxPrimaryDNSServer1.PasswordChar = CType(resources.GetObject("textBoxPrimaryDNSServer1.PasswordChar"),Char)
		Me.textBoxPrimaryDNSServer1.RightToLeft = CType(resources.GetObject("textBoxPrimaryDNSServer1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPrimaryDNSServer1.ScrollBars = CType(resources.GetObject("textBoxPrimaryDNSServer1.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPrimaryDNSServer1.Size = CType(resources.GetObject("textBoxPrimaryDNSServer1.Size"),System.Drawing.Size)
		Me.textBoxPrimaryDNSServer1.TabIndex = CType(resources.GetObject("textBoxPrimaryDNSServer1.TabIndex"),Integer)
		Me.textBoxPrimaryDNSServer1.TextAlign = CType(resources.GetObject("textBoxPrimaryDNSServer1.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxPrimaryDNSServer1, resources.GetString("textBoxPrimaryDNSServer1.ToolTip"))
		Me.textBoxPrimaryDNSServer1.WordWrap = CType(resources.GetObject("textBoxPrimaryDNSServer1.WordWrap"),Boolean)
		AddHandler Me.textBoxPrimaryDNSServer1.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer1KeyPress
		'
		'label18
		'
		Me.label18.AccessibleDescription = Nothing
		Me.label18.AccessibleName = Nothing
		Me.label18.Anchor = CType(resources.GetObject("label18.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label18.AutoSize = CType(resources.GetObject("label18.AutoSize"),Boolean)
		Me.label18.BackColor = System.Drawing.SystemColors.Window
		Me.label18.BackgroundImageLayout = CType(resources.GetObject("label18.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label18.Dock = CType(resources.GetObject("label18.Dock"),System.Windows.Forms.DockStyle)
		Me.label18.Font = Nothing
		Me.label18.ImageAlign = CType(resources.GetObject("label18.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label18.ImageIndex = CType(resources.GetObject("label18.ImageIndex"),Integer)
		Me.label18.ImageKey = resources.GetString("label18.ImageKey")
		Me.label18.ImeMode = CType(resources.GetObject("label18.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label18.Location = CType(resources.GetObject("label18.Location"),System.Drawing.Point)
		Me.label18.Name = "label18"
		Me.label18.RightToLeft = CType(resources.GetObject("label18.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label18.Size = CType(resources.GetObject("label18.Size"),System.Drawing.Size)
		Me.label18.TabIndex = CType(resources.GetObject("label18.TabIndex"),Integer)
		Me.label18.Text = resources.GetString("label18.Text")
		Me.label18.TextAlign = CType(resources.GetObject("label18.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label18, resources.GetString("label18.ToolTip"))
		'
		'label19
		'
		Me.label19.AccessibleDescription = Nothing
		Me.label19.AccessibleName = Nothing
		Me.label19.Anchor = CType(resources.GetObject("label19.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label19.AutoSize = CType(resources.GetObject("label19.AutoSize"),Boolean)
		Me.label19.BackColor = System.Drawing.SystemColors.Window
		Me.label19.BackgroundImageLayout = CType(resources.GetObject("label19.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label19.Dock = CType(resources.GetObject("label19.Dock"),System.Windows.Forms.DockStyle)
		Me.label19.Font = Nothing
		Me.label19.ImageAlign = CType(resources.GetObject("label19.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label19.ImageIndex = CType(resources.GetObject("label19.ImageIndex"),Integer)
		Me.label19.ImageKey = resources.GetString("label19.ImageKey")
		Me.label19.ImeMode = CType(resources.GetObject("label19.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label19.Location = CType(resources.GetObject("label19.Location"),System.Drawing.Point)
		Me.label19.Name = "label19"
		Me.label19.RightToLeft = CType(resources.GetObject("label19.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label19.Size = CType(resources.GetObject("label19.Size"),System.Drawing.Size)
		Me.label19.TabIndex = CType(resources.GetObject("label19.TabIndex"),Integer)
		Me.label19.Text = resources.GetString("label19.Text")
		Me.label19.TextAlign = CType(resources.GetObject("label19.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label19, resources.GetString("label19.ToolTip"))
		'
		'label20
		'
		Me.label20.AccessibleDescription = Nothing
		Me.label20.AccessibleName = Nothing
		Me.label20.Anchor = CType(resources.GetObject("label20.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label20.AutoSize = CType(resources.GetObject("label20.AutoSize"),Boolean)
		Me.label20.BackColor = System.Drawing.SystemColors.Window
		Me.label20.BackgroundImageLayout = CType(resources.GetObject("label20.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label20.Dock = CType(resources.GetObject("label20.Dock"),System.Windows.Forms.DockStyle)
		Me.label20.Font = Nothing
		Me.label20.ImageAlign = CType(resources.GetObject("label20.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label20.ImageIndex = CType(resources.GetObject("label20.ImageIndex"),Integer)
		Me.label20.ImageKey = resources.GetString("label20.ImageKey")
		Me.label20.ImeMode = CType(resources.GetObject("label20.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label20.Location = CType(resources.GetObject("label20.Location"),System.Drawing.Point)
		Me.label20.Name = "label20"
		Me.label20.RightToLeft = CType(resources.GetObject("label20.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label20.Size = CType(resources.GetObject("label20.Size"),System.Drawing.Size)
		Me.label20.TabIndex = CType(resources.GetObject("label20.TabIndex"),Integer)
		Me.label20.Text = resources.GetString("label20.Text")
		Me.label20.TextAlign = CType(resources.GetObject("label20.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label20, resources.GetString("label20.ToolTip"))
		'
		'pictureBoxPrimaryDNSServer
		'
		Me.pictureBoxPrimaryDNSServer.AccessibleDescription = Nothing
		Me.pictureBoxPrimaryDNSServer.AccessibleName = Nothing
		Me.pictureBoxPrimaryDNSServer.Anchor = CType(resources.GetObject("pictureBoxPrimaryDNSServer.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxPrimaryDNSServer.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxPrimaryDNSServer.BackgroundImage = Nothing
		Me.pictureBoxPrimaryDNSServer.BackgroundImageLayout = CType(resources.GetObject("pictureBoxPrimaryDNSServer.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxPrimaryDNSServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxPrimaryDNSServer.Dock = CType(resources.GetObject("pictureBoxPrimaryDNSServer.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxPrimaryDNSServer.Font = Nothing
		Me.pictureBoxPrimaryDNSServer.ImageLocation = Nothing
		Me.pictureBoxPrimaryDNSServer.ImeMode = CType(resources.GetObject("pictureBoxPrimaryDNSServer.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxPrimaryDNSServer.Location = CType(resources.GetObject("pictureBoxPrimaryDNSServer.Location"),System.Drawing.Point)
		Me.pictureBoxPrimaryDNSServer.Name = "pictureBoxPrimaryDNSServer"
		Me.pictureBoxPrimaryDNSServer.RightToLeft = CType(resources.GetObject("pictureBoxPrimaryDNSServer.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxPrimaryDNSServer.Size = CType(resources.GetObject("pictureBoxPrimaryDNSServer.Size"),System.Drawing.Size)
		Me.pictureBoxPrimaryDNSServer.SizeMode = CType(resources.GetObject("pictureBoxPrimaryDNSServer.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxPrimaryDNSServer.TabIndex = CType(resources.GetObject("pictureBoxPrimaryDNSServer.TabIndex"),Integer)
		Me.pictureBoxPrimaryDNSServer.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxPrimaryDNSServer, resources.GetString("pictureBoxPrimaryDNSServer.ToolTip"))
		Me.pictureBoxPrimaryDNSServer.WaitOnLoad = CType(resources.GetObject("pictureBoxPrimaryDNSServer.WaitOnLoad"),Boolean)
		'
		'textBoxDefaultGateway4
		'
		Me.textBoxDefaultGateway4.AccessibleDescription = Nothing
		Me.textBoxDefaultGateway4.AccessibleName = Nothing
		Me.textBoxDefaultGateway4.Anchor = CType(resources.GetObject("textBoxDefaultGateway4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxDefaultGateway4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway4.BackgroundImage = Nothing
		Me.textBoxDefaultGateway4.BackgroundImageLayout = CType(resources.GetObject("textBoxDefaultGateway4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxDefaultGateway4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxDefaultGateway4.Dock = CType(resources.GetObject("textBoxDefaultGateway4.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxDefaultGateway4.Font = Nothing
		Me.textBoxDefaultGateway4.ImeMode = CType(resources.GetObject("textBoxDefaultGateway4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxDefaultGateway4.Location = CType(resources.GetObject("textBoxDefaultGateway4.Location"),System.Drawing.Point)
		Me.textBoxDefaultGateway4.MaxLength = CType(resources.GetObject("textBoxDefaultGateway4.MaxLength"),Integer)
		Me.textBoxDefaultGateway4.Multiline = CType(resources.GetObject("textBoxDefaultGateway4.Multiline"),Boolean)
		Me.textBoxDefaultGateway4.Name = "textBoxDefaultGateway4"
		Me.textBoxDefaultGateway4.PasswordChar = CType(resources.GetObject("textBoxDefaultGateway4.PasswordChar"),Char)
		Me.textBoxDefaultGateway4.RightToLeft = CType(resources.GetObject("textBoxDefaultGateway4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxDefaultGateway4.ScrollBars = CType(resources.GetObject("textBoxDefaultGateway4.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxDefaultGateway4.Size = CType(resources.GetObject("textBoxDefaultGateway4.Size"),System.Drawing.Size)
		Me.textBoxDefaultGateway4.TabIndex = CType(resources.GetObject("textBoxDefaultGateway4.TabIndex"),Integer)
		Me.textBoxDefaultGateway4.TabStop = false
		Me.textBoxDefaultGateway4.TextAlign = CType(resources.GetObject("textBoxDefaultGateway4.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxDefaultGateway4, resources.GetString("textBoxDefaultGateway4.ToolTip"))
		Me.textBoxDefaultGateway4.WordWrap = CType(resources.GetObject("textBoxDefaultGateway4.WordWrap"),Boolean)
		AddHandler Me.textBoxDefaultGateway4.KeyPress, AddressOf Me.TextBoxDefaultGateway4KeyPress
		'
		'textBoxDefaultGateway3
		'
		Me.textBoxDefaultGateway3.AccessibleDescription = Nothing
		Me.textBoxDefaultGateway3.AccessibleName = Nothing
		Me.textBoxDefaultGateway3.Anchor = CType(resources.GetObject("textBoxDefaultGateway3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxDefaultGateway3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway3.BackgroundImage = Nothing
		Me.textBoxDefaultGateway3.BackgroundImageLayout = CType(resources.GetObject("textBoxDefaultGateway3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxDefaultGateway3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxDefaultGateway3.Dock = CType(resources.GetObject("textBoxDefaultGateway3.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxDefaultGateway3.Font = Nothing
		Me.textBoxDefaultGateway3.ImeMode = CType(resources.GetObject("textBoxDefaultGateway3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxDefaultGateway3.Location = CType(resources.GetObject("textBoxDefaultGateway3.Location"),System.Drawing.Point)
		Me.textBoxDefaultGateway3.MaxLength = CType(resources.GetObject("textBoxDefaultGateway3.MaxLength"),Integer)
		Me.textBoxDefaultGateway3.Multiline = CType(resources.GetObject("textBoxDefaultGateway3.Multiline"),Boolean)
		Me.textBoxDefaultGateway3.Name = "textBoxDefaultGateway3"
		Me.textBoxDefaultGateway3.PasswordChar = CType(resources.GetObject("textBoxDefaultGateway3.PasswordChar"),Char)
		Me.textBoxDefaultGateway3.RightToLeft = CType(resources.GetObject("textBoxDefaultGateway3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxDefaultGateway3.ScrollBars = CType(resources.GetObject("textBoxDefaultGateway3.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxDefaultGateway3.Size = CType(resources.GetObject("textBoxDefaultGateway3.Size"),System.Drawing.Size)
		Me.textBoxDefaultGateway3.TabIndex = CType(resources.GetObject("textBoxDefaultGateway3.TabIndex"),Integer)
		Me.textBoxDefaultGateway3.TabStop = false
		Me.textBoxDefaultGateway3.TextAlign = CType(resources.GetObject("textBoxDefaultGateway3.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxDefaultGateway3, resources.GetString("textBoxDefaultGateway3.ToolTip"))
		Me.textBoxDefaultGateway3.WordWrap = CType(resources.GetObject("textBoxDefaultGateway3.WordWrap"),Boolean)
		AddHandler Me.textBoxDefaultGateway3.KeyPress, AddressOf Me.TextBoxDefaultGateway3KeyPress
		'
		'textBoxDefaultGateway2
		'
		Me.textBoxDefaultGateway2.AccessibleDescription = Nothing
		Me.textBoxDefaultGateway2.AccessibleName = Nothing
		Me.textBoxDefaultGateway2.Anchor = CType(resources.GetObject("textBoxDefaultGateway2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxDefaultGateway2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway2.BackgroundImage = Nothing
		Me.textBoxDefaultGateway2.BackgroundImageLayout = CType(resources.GetObject("textBoxDefaultGateway2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxDefaultGateway2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxDefaultGateway2.Dock = CType(resources.GetObject("textBoxDefaultGateway2.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxDefaultGateway2.Font = Nothing
		Me.textBoxDefaultGateway2.ImeMode = CType(resources.GetObject("textBoxDefaultGateway2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxDefaultGateway2.Location = CType(resources.GetObject("textBoxDefaultGateway2.Location"),System.Drawing.Point)
		Me.textBoxDefaultGateway2.MaxLength = CType(resources.GetObject("textBoxDefaultGateway2.MaxLength"),Integer)
		Me.textBoxDefaultGateway2.Multiline = CType(resources.GetObject("textBoxDefaultGateway2.Multiline"),Boolean)
		Me.textBoxDefaultGateway2.Name = "textBoxDefaultGateway2"
		Me.textBoxDefaultGateway2.PasswordChar = CType(resources.GetObject("textBoxDefaultGateway2.PasswordChar"),Char)
		Me.textBoxDefaultGateway2.RightToLeft = CType(resources.GetObject("textBoxDefaultGateway2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxDefaultGateway2.ScrollBars = CType(resources.GetObject("textBoxDefaultGateway2.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxDefaultGateway2.Size = CType(resources.GetObject("textBoxDefaultGateway2.Size"),System.Drawing.Size)
		Me.textBoxDefaultGateway2.TabIndex = CType(resources.GetObject("textBoxDefaultGateway2.TabIndex"),Integer)
		Me.textBoxDefaultGateway2.TabStop = false
		Me.textBoxDefaultGateway2.TextAlign = CType(resources.GetObject("textBoxDefaultGateway2.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxDefaultGateway2, resources.GetString("textBoxDefaultGateway2.ToolTip"))
		Me.textBoxDefaultGateway2.WordWrap = CType(resources.GetObject("textBoxDefaultGateway2.WordWrap"),Boolean)
		AddHandler Me.textBoxDefaultGateway2.KeyPress, AddressOf Me.TextBoxDefaultGateway2KeyPress
		'
		'textBoxDefaultGateway1
		'
		Me.textBoxDefaultGateway1.AccessibleDescription = Nothing
		Me.textBoxDefaultGateway1.AccessibleName = Nothing
		Me.textBoxDefaultGateway1.Anchor = CType(resources.GetObject("textBoxDefaultGateway1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxDefaultGateway1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway1.BackgroundImage = Nothing
		Me.textBoxDefaultGateway1.BackgroundImageLayout = CType(resources.GetObject("textBoxDefaultGateway1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxDefaultGateway1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxDefaultGateway1.Dock = CType(resources.GetObject("textBoxDefaultGateway1.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxDefaultGateway1.Font = Nothing
		Me.textBoxDefaultGateway1.ImeMode = CType(resources.GetObject("textBoxDefaultGateway1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxDefaultGateway1.Location = CType(resources.GetObject("textBoxDefaultGateway1.Location"),System.Drawing.Point)
		Me.textBoxDefaultGateway1.MaxLength = CType(resources.GetObject("textBoxDefaultGateway1.MaxLength"),Integer)
		Me.textBoxDefaultGateway1.Multiline = CType(resources.GetObject("textBoxDefaultGateway1.Multiline"),Boolean)
		Me.textBoxDefaultGateway1.Name = "textBoxDefaultGateway1"
		Me.textBoxDefaultGateway1.PasswordChar = CType(resources.GetObject("textBoxDefaultGateway1.PasswordChar"),Char)
		Me.textBoxDefaultGateway1.RightToLeft = CType(resources.GetObject("textBoxDefaultGateway1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxDefaultGateway1.ScrollBars = CType(resources.GetObject("textBoxDefaultGateway1.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxDefaultGateway1.Size = CType(resources.GetObject("textBoxDefaultGateway1.Size"),System.Drawing.Size)
		Me.textBoxDefaultGateway1.TabIndex = CType(resources.GetObject("textBoxDefaultGateway1.TabIndex"),Integer)
		Me.textBoxDefaultGateway1.TextAlign = CType(resources.GetObject("textBoxDefaultGateway1.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxDefaultGateway1, resources.GetString("textBoxDefaultGateway1.ToolTip"))
		Me.textBoxDefaultGateway1.WordWrap = CType(resources.GetObject("textBoxDefaultGateway1.WordWrap"),Boolean)
		AddHandler Me.textBoxDefaultGateway1.KeyPress, AddressOf Me.TextBoxDefaultGateway1KeyPress
		'
		'label15
		'
		Me.label15.AccessibleDescription = Nothing
		Me.label15.AccessibleName = Nothing
		Me.label15.Anchor = CType(resources.GetObject("label15.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label15.AutoSize = CType(resources.GetObject("label15.AutoSize"),Boolean)
		Me.label15.BackColor = System.Drawing.SystemColors.Window
		Me.label15.BackgroundImageLayout = CType(resources.GetObject("label15.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label15.Dock = CType(resources.GetObject("label15.Dock"),System.Windows.Forms.DockStyle)
		Me.label15.Font = Nothing
		Me.label15.ImageAlign = CType(resources.GetObject("label15.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label15.ImageIndex = CType(resources.GetObject("label15.ImageIndex"),Integer)
		Me.label15.ImageKey = resources.GetString("label15.ImageKey")
		Me.label15.ImeMode = CType(resources.GetObject("label15.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label15.Location = CType(resources.GetObject("label15.Location"),System.Drawing.Point)
		Me.label15.Name = "label15"
		Me.label15.RightToLeft = CType(resources.GetObject("label15.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label15.Size = CType(resources.GetObject("label15.Size"),System.Drawing.Size)
		Me.label15.TabIndex = CType(resources.GetObject("label15.TabIndex"),Integer)
		Me.label15.Text = resources.GetString("label15.Text")
		Me.label15.TextAlign = CType(resources.GetObject("label15.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label15, resources.GetString("label15.ToolTip"))
		'
		'label16
		'
		Me.label16.AccessibleDescription = Nothing
		Me.label16.AccessibleName = Nothing
		Me.label16.Anchor = CType(resources.GetObject("label16.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label16.AutoSize = CType(resources.GetObject("label16.AutoSize"),Boolean)
		Me.label16.BackColor = System.Drawing.SystemColors.Window
		Me.label16.BackgroundImageLayout = CType(resources.GetObject("label16.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label16.Dock = CType(resources.GetObject("label16.Dock"),System.Windows.Forms.DockStyle)
		Me.label16.Font = Nothing
		Me.label16.ImageAlign = CType(resources.GetObject("label16.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label16.ImageIndex = CType(resources.GetObject("label16.ImageIndex"),Integer)
		Me.label16.ImageKey = resources.GetString("label16.ImageKey")
		Me.label16.ImeMode = CType(resources.GetObject("label16.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label16.Location = CType(resources.GetObject("label16.Location"),System.Drawing.Point)
		Me.label16.Name = "label16"
		Me.label16.RightToLeft = CType(resources.GetObject("label16.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label16.Size = CType(resources.GetObject("label16.Size"),System.Drawing.Size)
		Me.label16.TabIndex = CType(resources.GetObject("label16.TabIndex"),Integer)
		Me.label16.Text = resources.GetString("label16.Text")
		Me.label16.TextAlign = CType(resources.GetObject("label16.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label16, resources.GetString("label16.ToolTip"))
		'
		'label17
		'
		Me.label17.AccessibleDescription = Nothing
		Me.label17.AccessibleName = Nothing
		Me.label17.Anchor = CType(resources.GetObject("label17.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label17.AutoSize = CType(resources.GetObject("label17.AutoSize"),Boolean)
		Me.label17.BackColor = System.Drawing.SystemColors.Window
		Me.label17.BackgroundImageLayout = CType(resources.GetObject("label17.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label17.Dock = CType(resources.GetObject("label17.Dock"),System.Windows.Forms.DockStyle)
		Me.label17.Font = Nothing
		Me.label17.ImageAlign = CType(resources.GetObject("label17.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label17.ImageIndex = CType(resources.GetObject("label17.ImageIndex"),Integer)
		Me.label17.ImageKey = resources.GetString("label17.ImageKey")
		Me.label17.ImeMode = CType(resources.GetObject("label17.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label17.Location = CType(resources.GetObject("label17.Location"),System.Drawing.Point)
		Me.label17.Name = "label17"
		Me.label17.RightToLeft = CType(resources.GetObject("label17.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label17.Size = CType(resources.GetObject("label17.Size"),System.Drawing.Size)
		Me.label17.TabIndex = CType(resources.GetObject("label17.TabIndex"),Integer)
		Me.label17.Text = resources.GetString("label17.Text")
		Me.label17.TextAlign = CType(resources.GetObject("label17.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label17, resources.GetString("label17.ToolTip"))
		'
		'pictureBoxDefaultGateway
		'
		Me.pictureBoxDefaultGateway.AccessibleDescription = Nothing
		Me.pictureBoxDefaultGateway.AccessibleName = Nothing
		Me.pictureBoxDefaultGateway.Anchor = CType(resources.GetObject("pictureBoxDefaultGateway.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxDefaultGateway.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxDefaultGateway.BackgroundImage = Nothing
		Me.pictureBoxDefaultGateway.BackgroundImageLayout = CType(resources.GetObject("pictureBoxDefaultGateway.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxDefaultGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxDefaultGateway.Dock = CType(resources.GetObject("pictureBoxDefaultGateway.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxDefaultGateway.Font = Nothing
		Me.pictureBoxDefaultGateway.ImageLocation = Nothing
		Me.pictureBoxDefaultGateway.ImeMode = CType(resources.GetObject("pictureBoxDefaultGateway.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxDefaultGateway.Location = CType(resources.GetObject("pictureBoxDefaultGateway.Location"),System.Drawing.Point)
		Me.pictureBoxDefaultGateway.Name = "pictureBoxDefaultGateway"
		Me.pictureBoxDefaultGateway.RightToLeft = CType(resources.GetObject("pictureBoxDefaultGateway.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxDefaultGateway.Size = CType(resources.GetObject("pictureBoxDefaultGateway.Size"),System.Drawing.Size)
		Me.pictureBoxDefaultGateway.SizeMode = CType(resources.GetObject("pictureBoxDefaultGateway.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxDefaultGateway.TabIndex = CType(resources.GetObject("pictureBoxDefaultGateway.TabIndex"),Integer)
		Me.pictureBoxDefaultGateway.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxDefaultGateway, resources.GetString("pictureBoxDefaultGateway.ToolTip"))
		Me.pictureBoxDefaultGateway.WaitOnLoad = CType(resources.GetObject("pictureBoxDefaultGateway.WaitOnLoad"),Boolean)
		'
		'textBoxSubnetMask4
		'
		Me.textBoxSubnetMask4.AccessibleDescription = Nothing
		Me.textBoxSubnetMask4.AccessibleName = Nothing
		Me.textBoxSubnetMask4.Anchor = CType(resources.GetObject("textBoxSubnetMask4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxSubnetMask4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask4.BackgroundImage = Nothing
		Me.textBoxSubnetMask4.BackgroundImageLayout = CType(resources.GetObject("textBoxSubnetMask4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxSubnetMask4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxSubnetMask4.Dock = CType(resources.GetObject("textBoxSubnetMask4.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxSubnetMask4.Font = Nothing
		Me.textBoxSubnetMask4.ImeMode = CType(resources.GetObject("textBoxSubnetMask4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxSubnetMask4.Location = CType(resources.GetObject("textBoxSubnetMask4.Location"),System.Drawing.Point)
		Me.textBoxSubnetMask4.MaxLength = CType(resources.GetObject("textBoxSubnetMask4.MaxLength"),Integer)
		Me.textBoxSubnetMask4.Multiline = CType(resources.GetObject("textBoxSubnetMask4.Multiline"),Boolean)
		Me.textBoxSubnetMask4.Name = "textBoxSubnetMask4"
		Me.textBoxSubnetMask4.PasswordChar = CType(resources.GetObject("textBoxSubnetMask4.PasswordChar"),Char)
		Me.textBoxSubnetMask4.RightToLeft = CType(resources.GetObject("textBoxSubnetMask4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxSubnetMask4.ScrollBars = CType(resources.GetObject("textBoxSubnetMask4.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxSubnetMask4.Size = CType(resources.GetObject("textBoxSubnetMask4.Size"),System.Drawing.Size)
		Me.textBoxSubnetMask4.TabIndex = CType(resources.GetObject("textBoxSubnetMask4.TabIndex"),Integer)
		Me.textBoxSubnetMask4.TabStop = false
		Me.textBoxSubnetMask4.TextAlign = CType(resources.GetObject("textBoxSubnetMask4.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxSubnetMask4, resources.GetString("textBoxSubnetMask4.ToolTip"))
		Me.textBoxSubnetMask4.WordWrap = CType(resources.GetObject("textBoxSubnetMask4.WordWrap"),Boolean)
		AddHandler Me.textBoxSubnetMask4.KeyPress, AddressOf Me.TextBoxSubnetMask4KeyPress
		'
		'textBoxSubnetMask3
		'
		Me.textBoxSubnetMask3.AccessibleDescription = Nothing
		Me.textBoxSubnetMask3.AccessibleName = Nothing
		Me.textBoxSubnetMask3.Anchor = CType(resources.GetObject("textBoxSubnetMask3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxSubnetMask3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask3.BackgroundImage = Nothing
		Me.textBoxSubnetMask3.BackgroundImageLayout = CType(resources.GetObject("textBoxSubnetMask3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxSubnetMask3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxSubnetMask3.Dock = CType(resources.GetObject("textBoxSubnetMask3.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxSubnetMask3.Font = Nothing
		Me.textBoxSubnetMask3.ImeMode = CType(resources.GetObject("textBoxSubnetMask3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxSubnetMask3.Location = CType(resources.GetObject("textBoxSubnetMask3.Location"),System.Drawing.Point)
		Me.textBoxSubnetMask3.MaxLength = CType(resources.GetObject("textBoxSubnetMask3.MaxLength"),Integer)
		Me.textBoxSubnetMask3.Multiline = CType(resources.GetObject("textBoxSubnetMask3.Multiline"),Boolean)
		Me.textBoxSubnetMask3.Name = "textBoxSubnetMask3"
		Me.textBoxSubnetMask3.PasswordChar = CType(resources.GetObject("textBoxSubnetMask3.PasswordChar"),Char)
		Me.textBoxSubnetMask3.RightToLeft = CType(resources.GetObject("textBoxSubnetMask3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxSubnetMask3.ScrollBars = CType(resources.GetObject("textBoxSubnetMask3.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxSubnetMask3.Size = CType(resources.GetObject("textBoxSubnetMask3.Size"),System.Drawing.Size)
		Me.textBoxSubnetMask3.TabIndex = CType(resources.GetObject("textBoxSubnetMask3.TabIndex"),Integer)
		Me.textBoxSubnetMask3.TabStop = false
		Me.textBoxSubnetMask3.TextAlign = CType(resources.GetObject("textBoxSubnetMask3.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxSubnetMask3, resources.GetString("textBoxSubnetMask3.ToolTip"))
		Me.textBoxSubnetMask3.WordWrap = CType(resources.GetObject("textBoxSubnetMask3.WordWrap"),Boolean)
		AddHandler Me.textBoxSubnetMask3.KeyPress, AddressOf Me.TextBoxSubnetMask3KeyPress
		'
		'textBoxSubnetMask2
		'
		Me.textBoxSubnetMask2.AccessibleDescription = Nothing
		Me.textBoxSubnetMask2.AccessibleName = Nothing
		Me.textBoxSubnetMask2.Anchor = CType(resources.GetObject("textBoxSubnetMask2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxSubnetMask2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask2.BackgroundImage = Nothing
		Me.textBoxSubnetMask2.BackgroundImageLayout = CType(resources.GetObject("textBoxSubnetMask2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxSubnetMask2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxSubnetMask2.Dock = CType(resources.GetObject("textBoxSubnetMask2.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxSubnetMask2.Font = Nothing
		Me.textBoxSubnetMask2.ImeMode = CType(resources.GetObject("textBoxSubnetMask2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxSubnetMask2.Location = CType(resources.GetObject("textBoxSubnetMask2.Location"),System.Drawing.Point)
		Me.textBoxSubnetMask2.MaxLength = CType(resources.GetObject("textBoxSubnetMask2.MaxLength"),Integer)
		Me.textBoxSubnetMask2.Multiline = CType(resources.GetObject("textBoxSubnetMask2.Multiline"),Boolean)
		Me.textBoxSubnetMask2.Name = "textBoxSubnetMask2"
		Me.textBoxSubnetMask2.PasswordChar = CType(resources.GetObject("textBoxSubnetMask2.PasswordChar"),Char)
		Me.textBoxSubnetMask2.RightToLeft = CType(resources.GetObject("textBoxSubnetMask2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxSubnetMask2.ScrollBars = CType(resources.GetObject("textBoxSubnetMask2.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxSubnetMask2.Size = CType(resources.GetObject("textBoxSubnetMask2.Size"),System.Drawing.Size)
		Me.textBoxSubnetMask2.TabIndex = CType(resources.GetObject("textBoxSubnetMask2.TabIndex"),Integer)
		Me.textBoxSubnetMask2.TabStop = false
		Me.textBoxSubnetMask2.TextAlign = CType(resources.GetObject("textBoxSubnetMask2.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxSubnetMask2, resources.GetString("textBoxSubnetMask2.ToolTip"))
		Me.textBoxSubnetMask2.WordWrap = CType(resources.GetObject("textBoxSubnetMask2.WordWrap"),Boolean)
		AddHandler Me.textBoxSubnetMask2.KeyPress, AddressOf Me.TextBoxSubnetMask2KeyPress
		'
		'textBoxSubnetMask1
		'
		Me.textBoxSubnetMask1.AccessibleDescription = Nothing
		Me.textBoxSubnetMask1.AccessibleName = Nothing
		Me.textBoxSubnetMask1.Anchor = CType(resources.GetObject("textBoxSubnetMask1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxSubnetMask1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask1.BackgroundImage = Nothing
		Me.textBoxSubnetMask1.BackgroundImageLayout = CType(resources.GetObject("textBoxSubnetMask1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxSubnetMask1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxSubnetMask1.Dock = CType(resources.GetObject("textBoxSubnetMask1.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxSubnetMask1.Font = Nothing
		Me.textBoxSubnetMask1.ImeMode = CType(resources.GetObject("textBoxSubnetMask1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxSubnetMask1.Location = CType(resources.GetObject("textBoxSubnetMask1.Location"),System.Drawing.Point)
		Me.textBoxSubnetMask1.MaxLength = CType(resources.GetObject("textBoxSubnetMask1.MaxLength"),Integer)
		Me.textBoxSubnetMask1.Multiline = CType(resources.GetObject("textBoxSubnetMask1.Multiline"),Boolean)
		Me.textBoxSubnetMask1.Name = "textBoxSubnetMask1"
		Me.textBoxSubnetMask1.PasswordChar = CType(resources.GetObject("textBoxSubnetMask1.PasswordChar"),Char)
		Me.textBoxSubnetMask1.RightToLeft = CType(resources.GetObject("textBoxSubnetMask1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxSubnetMask1.ScrollBars = CType(resources.GetObject("textBoxSubnetMask1.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxSubnetMask1.Size = CType(resources.GetObject("textBoxSubnetMask1.Size"),System.Drawing.Size)
		Me.textBoxSubnetMask1.TabIndex = CType(resources.GetObject("textBoxSubnetMask1.TabIndex"),Integer)
		Me.textBoxSubnetMask1.TextAlign = CType(resources.GetObject("textBoxSubnetMask1.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxSubnetMask1, resources.GetString("textBoxSubnetMask1.ToolTip"))
		Me.textBoxSubnetMask1.WordWrap = CType(resources.GetObject("textBoxSubnetMask1.WordWrap"),Boolean)
		AddHandler Me.textBoxSubnetMask1.KeyPress, AddressOf Me.TextBoxSubnetMask1KeyPress
		'
		'label12
		'
		Me.label12.AccessibleDescription = Nothing
		Me.label12.AccessibleName = Nothing
		Me.label12.Anchor = CType(resources.GetObject("label12.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label12.AutoSize = CType(resources.GetObject("label12.AutoSize"),Boolean)
		Me.label12.BackColor = System.Drawing.SystemColors.Window
		Me.label12.BackgroundImageLayout = CType(resources.GetObject("label12.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label12.Dock = CType(resources.GetObject("label12.Dock"),System.Windows.Forms.DockStyle)
		Me.label12.Font = Nothing
		Me.label12.ImageAlign = CType(resources.GetObject("label12.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label12.ImageIndex = CType(resources.GetObject("label12.ImageIndex"),Integer)
		Me.label12.ImageKey = resources.GetString("label12.ImageKey")
		Me.label12.ImeMode = CType(resources.GetObject("label12.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label12.Location = CType(resources.GetObject("label12.Location"),System.Drawing.Point)
		Me.label12.Name = "label12"
		Me.label12.RightToLeft = CType(resources.GetObject("label12.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label12.Size = CType(resources.GetObject("label12.Size"),System.Drawing.Size)
		Me.label12.TabIndex = CType(resources.GetObject("label12.TabIndex"),Integer)
		Me.label12.Text = resources.GetString("label12.Text")
		Me.label12.TextAlign = CType(resources.GetObject("label12.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label12, resources.GetString("label12.ToolTip"))
		'
		'label13
		'
		Me.label13.AccessibleDescription = Nothing
		Me.label13.AccessibleName = Nothing
		Me.label13.Anchor = CType(resources.GetObject("label13.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label13.AutoSize = CType(resources.GetObject("label13.AutoSize"),Boolean)
		Me.label13.BackColor = System.Drawing.SystemColors.Window
		Me.label13.BackgroundImageLayout = CType(resources.GetObject("label13.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label13.Dock = CType(resources.GetObject("label13.Dock"),System.Windows.Forms.DockStyle)
		Me.label13.Font = Nothing
		Me.label13.ImageAlign = CType(resources.GetObject("label13.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label13.ImageIndex = CType(resources.GetObject("label13.ImageIndex"),Integer)
		Me.label13.ImageKey = resources.GetString("label13.ImageKey")
		Me.label13.ImeMode = CType(resources.GetObject("label13.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label13.Location = CType(resources.GetObject("label13.Location"),System.Drawing.Point)
		Me.label13.Name = "label13"
		Me.label13.RightToLeft = CType(resources.GetObject("label13.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label13.Size = CType(resources.GetObject("label13.Size"),System.Drawing.Size)
		Me.label13.TabIndex = CType(resources.GetObject("label13.TabIndex"),Integer)
		Me.label13.Text = resources.GetString("label13.Text")
		Me.label13.TextAlign = CType(resources.GetObject("label13.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label13, resources.GetString("label13.ToolTip"))
		'
		'label14
		'
		Me.label14.AccessibleDescription = Nothing
		Me.label14.AccessibleName = Nothing
		Me.label14.Anchor = CType(resources.GetObject("label14.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label14.AutoSize = CType(resources.GetObject("label14.AutoSize"),Boolean)
		Me.label14.BackColor = System.Drawing.SystemColors.Window
		Me.label14.BackgroundImageLayout = CType(resources.GetObject("label14.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label14.Dock = CType(resources.GetObject("label14.Dock"),System.Windows.Forms.DockStyle)
		Me.label14.Font = Nothing
		Me.label14.ImageAlign = CType(resources.GetObject("label14.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label14.ImageIndex = CType(resources.GetObject("label14.ImageIndex"),Integer)
		Me.label14.ImageKey = resources.GetString("label14.ImageKey")
		Me.label14.ImeMode = CType(resources.GetObject("label14.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label14.Location = CType(resources.GetObject("label14.Location"),System.Drawing.Point)
		Me.label14.Name = "label14"
		Me.label14.RightToLeft = CType(resources.GetObject("label14.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label14.Size = CType(resources.GetObject("label14.Size"),System.Drawing.Size)
		Me.label14.TabIndex = CType(resources.GetObject("label14.TabIndex"),Integer)
		Me.label14.Text = resources.GetString("label14.Text")
		Me.label14.TextAlign = CType(resources.GetObject("label14.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label14, resources.GetString("label14.ToolTip"))
		'
		'pictureBoxSubnetMask
		'
		Me.pictureBoxSubnetMask.AccessibleDescription = Nothing
		Me.pictureBoxSubnetMask.AccessibleName = Nothing
		Me.pictureBoxSubnetMask.Anchor = CType(resources.GetObject("pictureBoxSubnetMask.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxSubnetMask.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxSubnetMask.BackgroundImage = Nothing
		Me.pictureBoxSubnetMask.BackgroundImageLayout = CType(resources.GetObject("pictureBoxSubnetMask.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxSubnetMask.Dock = CType(resources.GetObject("pictureBoxSubnetMask.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxSubnetMask.Font = Nothing
		Me.pictureBoxSubnetMask.ImageLocation = Nothing
		Me.pictureBoxSubnetMask.ImeMode = CType(resources.GetObject("pictureBoxSubnetMask.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxSubnetMask.Location = CType(resources.GetObject("pictureBoxSubnetMask.Location"),System.Drawing.Point)
		Me.pictureBoxSubnetMask.Name = "pictureBoxSubnetMask"
		Me.pictureBoxSubnetMask.RightToLeft = CType(resources.GetObject("pictureBoxSubnetMask.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxSubnetMask.Size = CType(resources.GetObject("pictureBoxSubnetMask.Size"),System.Drawing.Size)
		Me.pictureBoxSubnetMask.SizeMode = CType(resources.GetObject("pictureBoxSubnetMask.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxSubnetMask.TabIndex = CType(resources.GetObject("pictureBoxSubnetMask.TabIndex"),Integer)
		Me.pictureBoxSubnetMask.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxSubnetMask, resources.GetString("pictureBoxSubnetMask.ToolTip"))
		Me.pictureBoxSubnetMask.WaitOnLoad = CType(resources.GetObject("pictureBoxSubnetMask.WaitOnLoad"),Boolean)
		'
		'labelWINSServer
		'
		Me.labelWINSServer.AccessibleDescription = Nothing
		Me.labelWINSServer.AccessibleName = Nothing
		Me.labelWINSServer.Anchor = CType(resources.GetObject("labelWINSServer.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelWINSServer.AutoSize = CType(resources.GetObject("labelWINSServer.AutoSize"),Boolean)
		Me.labelWINSServer.BackgroundImageLayout = CType(resources.GetObject("labelWINSServer.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelWINSServer.Dock = CType(resources.GetObject("labelWINSServer.Dock"),System.Windows.Forms.DockStyle)
		Me.labelWINSServer.Font = Nothing
		Me.labelWINSServer.ImageAlign = CType(resources.GetObject("labelWINSServer.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelWINSServer.ImageIndex = CType(resources.GetObject("labelWINSServer.ImageIndex"),Integer)
		Me.labelWINSServer.ImageKey = resources.GetString("labelWINSServer.ImageKey")
		Me.labelWINSServer.ImeMode = CType(resources.GetObject("labelWINSServer.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelWINSServer.Location = CType(resources.GetObject("labelWINSServer.Location"),System.Drawing.Point)
		Me.labelWINSServer.Name = "labelWINSServer"
		Me.labelWINSServer.RightToLeft = CType(resources.GetObject("labelWINSServer.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelWINSServer.Size = CType(resources.GetObject("labelWINSServer.Size"),System.Drawing.Size)
		Me.labelWINSServer.TabIndex = CType(resources.GetObject("labelWINSServer.TabIndex"),Integer)
		Me.labelWINSServer.Text = resources.GetString("labelWINSServer.Text")
		Me.labelWINSServer.TextAlign = CType(resources.GetObject("labelWINSServer.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelWINSServer, resources.GetString("labelWINSServer.ToolTip"))
		'
		'labelAlternateDNSServer
		'
		Me.labelAlternateDNSServer.AccessibleDescription = Nothing
		Me.labelAlternateDNSServer.AccessibleName = Nothing
		Me.labelAlternateDNSServer.Anchor = CType(resources.GetObject("labelAlternateDNSServer.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelAlternateDNSServer.AutoSize = CType(resources.GetObject("labelAlternateDNSServer.AutoSize"),Boolean)
		Me.labelAlternateDNSServer.BackgroundImageLayout = CType(resources.GetObject("labelAlternateDNSServer.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelAlternateDNSServer.Dock = CType(resources.GetObject("labelAlternateDNSServer.Dock"),System.Windows.Forms.DockStyle)
		Me.labelAlternateDNSServer.Font = Nothing
		Me.labelAlternateDNSServer.ImageAlign = CType(resources.GetObject("labelAlternateDNSServer.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelAlternateDNSServer.ImageIndex = CType(resources.GetObject("labelAlternateDNSServer.ImageIndex"),Integer)
		Me.labelAlternateDNSServer.ImageKey = resources.GetString("labelAlternateDNSServer.ImageKey")
		Me.labelAlternateDNSServer.ImeMode = CType(resources.GetObject("labelAlternateDNSServer.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelAlternateDNSServer.Location = CType(resources.GetObject("labelAlternateDNSServer.Location"),System.Drawing.Point)
		Me.labelAlternateDNSServer.Name = "labelAlternateDNSServer"
		Me.labelAlternateDNSServer.RightToLeft = CType(resources.GetObject("labelAlternateDNSServer.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelAlternateDNSServer.Size = CType(resources.GetObject("labelAlternateDNSServer.Size"),System.Drawing.Size)
		Me.labelAlternateDNSServer.TabIndex = CType(resources.GetObject("labelAlternateDNSServer.TabIndex"),Integer)
		Me.labelAlternateDNSServer.Text = resources.GetString("labelAlternateDNSServer.Text")
		Me.labelAlternateDNSServer.TextAlign = CType(resources.GetObject("labelAlternateDNSServer.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelAlternateDNSServer, resources.GetString("labelAlternateDNSServer.ToolTip"))
		'
		'labelPrimaryDNSServer
		'
		Me.labelPrimaryDNSServer.AccessibleDescription = Nothing
		Me.labelPrimaryDNSServer.AccessibleName = Nothing
		Me.labelPrimaryDNSServer.Anchor = CType(resources.GetObject("labelPrimaryDNSServer.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelPrimaryDNSServer.AutoSize = CType(resources.GetObject("labelPrimaryDNSServer.AutoSize"),Boolean)
		Me.labelPrimaryDNSServer.BackgroundImageLayout = CType(resources.GetObject("labelPrimaryDNSServer.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelPrimaryDNSServer.Dock = CType(resources.GetObject("labelPrimaryDNSServer.Dock"),System.Windows.Forms.DockStyle)
		Me.labelPrimaryDNSServer.Font = Nothing
		Me.labelPrimaryDNSServer.ImageAlign = CType(resources.GetObject("labelPrimaryDNSServer.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelPrimaryDNSServer.ImageIndex = CType(resources.GetObject("labelPrimaryDNSServer.ImageIndex"),Integer)
		Me.labelPrimaryDNSServer.ImageKey = resources.GetString("labelPrimaryDNSServer.ImageKey")
		Me.labelPrimaryDNSServer.ImeMode = CType(resources.GetObject("labelPrimaryDNSServer.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelPrimaryDNSServer.Location = CType(resources.GetObject("labelPrimaryDNSServer.Location"),System.Drawing.Point)
		Me.labelPrimaryDNSServer.Name = "labelPrimaryDNSServer"
		Me.labelPrimaryDNSServer.RightToLeft = CType(resources.GetObject("labelPrimaryDNSServer.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelPrimaryDNSServer.Size = CType(resources.GetObject("labelPrimaryDNSServer.Size"),System.Drawing.Size)
		Me.labelPrimaryDNSServer.TabIndex = CType(resources.GetObject("labelPrimaryDNSServer.TabIndex"),Integer)
		Me.labelPrimaryDNSServer.Text = resources.GetString("labelPrimaryDNSServer.Text")
		Me.labelPrimaryDNSServer.TextAlign = CType(resources.GetObject("labelPrimaryDNSServer.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelPrimaryDNSServer, resources.GetString("labelPrimaryDNSServer.ToolTip"))
		'
		'labelDefaultGateway
		'
		Me.labelDefaultGateway.AccessibleDescription = Nothing
		Me.labelDefaultGateway.AccessibleName = Nothing
		Me.labelDefaultGateway.Anchor = CType(resources.GetObject("labelDefaultGateway.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelDefaultGateway.AutoSize = CType(resources.GetObject("labelDefaultGateway.AutoSize"),Boolean)
		Me.labelDefaultGateway.BackgroundImageLayout = CType(resources.GetObject("labelDefaultGateway.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelDefaultGateway.Dock = CType(resources.GetObject("labelDefaultGateway.Dock"),System.Windows.Forms.DockStyle)
		Me.labelDefaultGateway.Font = Nothing
		Me.labelDefaultGateway.ImageAlign = CType(resources.GetObject("labelDefaultGateway.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelDefaultGateway.ImageIndex = CType(resources.GetObject("labelDefaultGateway.ImageIndex"),Integer)
		Me.labelDefaultGateway.ImageKey = resources.GetString("labelDefaultGateway.ImageKey")
		Me.labelDefaultGateway.ImeMode = CType(resources.GetObject("labelDefaultGateway.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelDefaultGateway.Location = CType(resources.GetObject("labelDefaultGateway.Location"),System.Drawing.Point)
		Me.labelDefaultGateway.Name = "labelDefaultGateway"
		Me.labelDefaultGateway.RightToLeft = CType(resources.GetObject("labelDefaultGateway.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelDefaultGateway.Size = CType(resources.GetObject("labelDefaultGateway.Size"),System.Drawing.Size)
		Me.labelDefaultGateway.TabIndex = CType(resources.GetObject("labelDefaultGateway.TabIndex"),Integer)
		Me.labelDefaultGateway.Text = resources.GetString("labelDefaultGateway.Text")
		Me.labelDefaultGateway.TextAlign = CType(resources.GetObject("labelDefaultGateway.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelDefaultGateway, resources.GetString("labelDefaultGateway.ToolTip"))
		'
		'labelSubnetMask
		'
		Me.labelSubnetMask.AccessibleDescription = Nothing
		Me.labelSubnetMask.AccessibleName = Nothing
		Me.labelSubnetMask.Anchor = CType(resources.GetObject("labelSubnetMask.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelSubnetMask.AutoSize = CType(resources.GetObject("labelSubnetMask.AutoSize"),Boolean)
		Me.labelSubnetMask.BackgroundImageLayout = CType(resources.GetObject("labelSubnetMask.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelSubnetMask.Dock = CType(resources.GetObject("labelSubnetMask.Dock"),System.Windows.Forms.DockStyle)
		Me.labelSubnetMask.Font = Nothing
		Me.labelSubnetMask.ImageAlign = CType(resources.GetObject("labelSubnetMask.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelSubnetMask.ImageIndex = CType(resources.GetObject("labelSubnetMask.ImageIndex"),Integer)
		Me.labelSubnetMask.ImageKey = resources.GetString("labelSubnetMask.ImageKey")
		Me.labelSubnetMask.ImeMode = CType(resources.GetObject("labelSubnetMask.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelSubnetMask.Location = CType(resources.GetObject("labelSubnetMask.Location"),System.Drawing.Point)
		Me.labelSubnetMask.Name = "labelSubnetMask"
		Me.labelSubnetMask.RightToLeft = CType(resources.GetObject("labelSubnetMask.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelSubnetMask.Size = CType(resources.GetObject("labelSubnetMask.Size"),System.Drawing.Size)
		Me.labelSubnetMask.TabIndex = CType(resources.GetObject("labelSubnetMask.TabIndex"),Integer)
		Me.labelSubnetMask.Text = resources.GetString("labelSubnetMask.Text")
		Me.labelSubnetMask.TextAlign = CType(resources.GetObject("labelSubnetMask.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelSubnetMask, resources.GetString("labelSubnetMask.ToolTip"))
		'
		'textBoxIPAddress4
		'
		Me.textBoxIPAddress4.AccessibleDescription = Nothing
		Me.textBoxIPAddress4.AccessibleName = Nothing
		Me.textBoxIPAddress4.Anchor = CType(resources.GetObject("textBoxIPAddress4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxIPAddress4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress4.BackgroundImage = Nothing
		Me.textBoxIPAddress4.BackgroundImageLayout = CType(resources.GetObject("textBoxIPAddress4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxIPAddress4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxIPAddress4.Dock = CType(resources.GetObject("textBoxIPAddress4.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxIPAddress4.Font = Nothing
		Me.textBoxIPAddress4.ImeMode = CType(resources.GetObject("textBoxIPAddress4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxIPAddress4.Location = CType(resources.GetObject("textBoxIPAddress4.Location"),System.Drawing.Point)
		Me.textBoxIPAddress4.MaxLength = CType(resources.GetObject("textBoxIPAddress4.MaxLength"),Integer)
		Me.textBoxIPAddress4.Multiline = CType(resources.GetObject("textBoxIPAddress4.Multiline"),Boolean)
		Me.textBoxIPAddress4.Name = "textBoxIPAddress4"
		Me.textBoxIPAddress4.PasswordChar = CType(resources.GetObject("textBoxIPAddress4.PasswordChar"),Char)
		Me.textBoxIPAddress4.RightToLeft = CType(resources.GetObject("textBoxIPAddress4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxIPAddress4.ScrollBars = CType(resources.GetObject("textBoxIPAddress4.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxIPAddress4.Size = CType(resources.GetObject("textBoxIPAddress4.Size"),System.Drawing.Size)
		Me.textBoxIPAddress4.TabIndex = CType(resources.GetObject("textBoxIPAddress4.TabIndex"),Integer)
		Me.textBoxIPAddress4.TabStop = false
		Me.textBoxIPAddress4.TextAlign = CType(resources.GetObject("textBoxIPAddress4.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxIPAddress4, resources.GetString("textBoxIPAddress4.ToolTip"))
		Me.textBoxIPAddress4.WordWrap = CType(resources.GetObject("textBoxIPAddress4.WordWrap"),Boolean)
		AddHandler Me.textBoxIPAddress4.KeyPress, AddressOf Me.TextBoxIPAddress4KeyPress
		'
		'textBoxIPAddress3
		'
		Me.textBoxIPAddress3.AccessibleDescription = Nothing
		Me.textBoxIPAddress3.AccessibleName = Nothing
		Me.textBoxIPAddress3.Anchor = CType(resources.GetObject("textBoxIPAddress3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxIPAddress3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress3.BackgroundImage = Nothing
		Me.textBoxIPAddress3.BackgroundImageLayout = CType(resources.GetObject("textBoxIPAddress3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxIPAddress3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxIPAddress3.Dock = CType(resources.GetObject("textBoxIPAddress3.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxIPAddress3.Font = Nothing
		Me.textBoxIPAddress3.ImeMode = CType(resources.GetObject("textBoxIPAddress3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxIPAddress3.Location = CType(resources.GetObject("textBoxIPAddress3.Location"),System.Drawing.Point)
		Me.textBoxIPAddress3.MaxLength = CType(resources.GetObject("textBoxIPAddress3.MaxLength"),Integer)
		Me.textBoxIPAddress3.Multiline = CType(resources.GetObject("textBoxIPAddress3.Multiline"),Boolean)
		Me.textBoxIPAddress3.Name = "textBoxIPAddress3"
		Me.textBoxIPAddress3.PasswordChar = CType(resources.GetObject("textBoxIPAddress3.PasswordChar"),Char)
		Me.textBoxIPAddress3.RightToLeft = CType(resources.GetObject("textBoxIPAddress3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxIPAddress3.ScrollBars = CType(resources.GetObject("textBoxIPAddress3.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxIPAddress3.Size = CType(resources.GetObject("textBoxIPAddress3.Size"),System.Drawing.Size)
		Me.textBoxIPAddress3.TabIndex = CType(resources.GetObject("textBoxIPAddress3.TabIndex"),Integer)
		Me.textBoxIPAddress3.TabStop = false
		Me.textBoxIPAddress3.TextAlign = CType(resources.GetObject("textBoxIPAddress3.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxIPAddress3, resources.GetString("textBoxIPAddress3.ToolTip"))
		Me.textBoxIPAddress3.WordWrap = CType(resources.GetObject("textBoxIPAddress3.WordWrap"),Boolean)
		AddHandler Me.textBoxIPAddress3.KeyPress, AddressOf Me.TextBoxIPAddress3KeyPress
		'
		'textBoxIPAddress2
		'
		Me.textBoxIPAddress2.AccessibleDescription = Nothing
		Me.textBoxIPAddress2.AccessibleName = Nothing
		Me.textBoxIPAddress2.Anchor = CType(resources.GetObject("textBoxIPAddress2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxIPAddress2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress2.BackgroundImage = Nothing
		Me.textBoxIPAddress2.BackgroundImageLayout = CType(resources.GetObject("textBoxIPAddress2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxIPAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxIPAddress2.Dock = CType(resources.GetObject("textBoxIPAddress2.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxIPAddress2.Font = Nothing
		Me.textBoxIPAddress2.ImeMode = CType(resources.GetObject("textBoxIPAddress2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxIPAddress2.Location = CType(resources.GetObject("textBoxIPAddress2.Location"),System.Drawing.Point)
		Me.textBoxIPAddress2.MaxLength = CType(resources.GetObject("textBoxIPAddress2.MaxLength"),Integer)
		Me.textBoxIPAddress2.Multiline = CType(resources.GetObject("textBoxIPAddress2.Multiline"),Boolean)
		Me.textBoxIPAddress2.Name = "textBoxIPAddress2"
		Me.textBoxIPAddress2.PasswordChar = CType(resources.GetObject("textBoxIPAddress2.PasswordChar"),Char)
		Me.textBoxIPAddress2.RightToLeft = CType(resources.GetObject("textBoxIPAddress2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxIPAddress2.ScrollBars = CType(resources.GetObject("textBoxIPAddress2.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxIPAddress2.Size = CType(resources.GetObject("textBoxIPAddress2.Size"),System.Drawing.Size)
		Me.textBoxIPAddress2.TabIndex = CType(resources.GetObject("textBoxIPAddress2.TabIndex"),Integer)
		Me.textBoxIPAddress2.TabStop = false
		Me.textBoxIPAddress2.TextAlign = CType(resources.GetObject("textBoxIPAddress2.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxIPAddress2, resources.GetString("textBoxIPAddress2.ToolTip"))
		Me.textBoxIPAddress2.WordWrap = CType(resources.GetObject("textBoxIPAddress2.WordWrap"),Boolean)
		AddHandler Me.textBoxIPAddress2.KeyPress, AddressOf Me.TextBoxIPAddress2KeyPress
		'
		'textBoxIPAddress1
		'
		Me.textBoxIPAddress1.AccessibleDescription = Nothing
		Me.textBoxIPAddress1.AccessibleName = Nothing
		Me.textBoxIPAddress1.Anchor = CType(resources.GetObject("textBoxIPAddress1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxIPAddress1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress1.BackgroundImage = Nothing
		Me.textBoxIPAddress1.BackgroundImageLayout = CType(resources.GetObject("textBoxIPAddress1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxIPAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBoxIPAddress1.Dock = CType(resources.GetObject("textBoxIPAddress1.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxIPAddress1.Font = Nothing
		Me.textBoxIPAddress1.ImeMode = CType(resources.GetObject("textBoxIPAddress1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxIPAddress1.Location = CType(resources.GetObject("textBoxIPAddress1.Location"),System.Drawing.Point)
		Me.textBoxIPAddress1.MaxLength = CType(resources.GetObject("textBoxIPAddress1.MaxLength"),Integer)
		Me.textBoxIPAddress1.Multiline = CType(resources.GetObject("textBoxIPAddress1.Multiline"),Boolean)
		Me.textBoxIPAddress1.Name = "textBoxIPAddress1"
		Me.textBoxIPAddress1.PasswordChar = CType(resources.GetObject("textBoxIPAddress1.PasswordChar"),Char)
		Me.textBoxIPAddress1.RightToLeft = CType(resources.GetObject("textBoxIPAddress1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxIPAddress1.ScrollBars = CType(resources.GetObject("textBoxIPAddress1.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxIPAddress1.Size = CType(resources.GetObject("textBoxIPAddress1.Size"),System.Drawing.Size)
		Me.textBoxIPAddress1.TabIndex = CType(resources.GetObject("textBoxIPAddress1.TabIndex"),Integer)
		Me.textBoxIPAddress1.TextAlign = CType(resources.GetObject("textBoxIPAddress1.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxIPAddress1, resources.GetString("textBoxIPAddress1.ToolTip"))
		Me.textBoxIPAddress1.WordWrap = CType(resources.GetObject("textBoxIPAddress1.WordWrap"),Boolean)
		AddHandler Me.textBoxIPAddress1.KeyPress, AddressOf Me.TextBoxIPAddress1KeyPress
		'
		'label9
		'
		Me.label9.AccessibleDescription = Nothing
		Me.label9.AccessibleName = Nothing
		Me.label9.Anchor = CType(resources.GetObject("label9.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label9.AutoSize = CType(resources.GetObject("label9.AutoSize"),Boolean)
		Me.label9.BackColor = System.Drawing.SystemColors.Window
		Me.label9.BackgroundImageLayout = CType(resources.GetObject("label9.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label9.Dock = CType(resources.GetObject("label9.Dock"),System.Windows.Forms.DockStyle)
		Me.label9.Font = Nothing
		Me.label9.ImageAlign = CType(resources.GetObject("label9.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label9.ImageIndex = CType(resources.GetObject("label9.ImageIndex"),Integer)
		Me.label9.ImageKey = resources.GetString("label9.ImageKey")
		Me.label9.ImeMode = CType(resources.GetObject("label9.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label9.Location = CType(resources.GetObject("label9.Location"),System.Drawing.Point)
		Me.label9.Name = "label9"
		Me.label9.RightToLeft = CType(resources.GetObject("label9.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label9.Size = CType(resources.GetObject("label9.Size"),System.Drawing.Size)
		Me.label9.TabIndex = CType(resources.GetObject("label9.TabIndex"),Integer)
		Me.label9.Text = resources.GetString("label9.Text")
		Me.label9.TextAlign = CType(resources.GetObject("label9.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label9, resources.GetString("label9.ToolTip"))
		'
		'label8
		'
		Me.label8.AccessibleDescription = Nothing
		Me.label8.AccessibleName = Nothing
		Me.label8.Anchor = CType(resources.GetObject("label8.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label8.AutoSize = CType(resources.GetObject("label8.AutoSize"),Boolean)
		Me.label8.BackColor = System.Drawing.SystemColors.Window
		Me.label8.BackgroundImageLayout = CType(resources.GetObject("label8.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label8.Dock = CType(resources.GetObject("label8.Dock"),System.Windows.Forms.DockStyle)
		Me.label8.Font = Nothing
		Me.label8.ImageAlign = CType(resources.GetObject("label8.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label8.ImageIndex = CType(resources.GetObject("label8.ImageIndex"),Integer)
		Me.label8.ImageKey = resources.GetString("label8.ImageKey")
		Me.label8.ImeMode = CType(resources.GetObject("label8.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label8.Location = CType(resources.GetObject("label8.Location"),System.Drawing.Point)
		Me.label8.Name = "label8"
		Me.label8.RightToLeft = CType(resources.GetObject("label8.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label8.Size = CType(resources.GetObject("label8.Size"),System.Drawing.Size)
		Me.label8.TabIndex = CType(resources.GetObject("label8.TabIndex"),Integer)
		Me.label8.Text = resources.GetString("label8.Text")
		Me.label8.TextAlign = CType(resources.GetObject("label8.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label8, resources.GetString("label8.ToolTip"))
		'
		'label7
		'
		Me.label7.AccessibleDescription = Nothing
		Me.label7.AccessibleName = Nothing
		Me.label7.Anchor = CType(resources.GetObject("label7.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label7.AutoSize = CType(resources.GetObject("label7.AutoSize"),Boolean)
		Me.label7.BackColor = System.Drawing.SystemColors.Window
		Me.label7.BackgroundImageLayout = CType(resources.GetObject("label7.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label7.Dock = CType(resources.GetObject("label7.Dock"),System.Windows.Forms.DockStyle)
		Me.label7.Font = Nothing
		Me.label7.ImageAlign = CType(resources.GetObject("label7.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label7.ImageIndex = CType(resources.GetObject("label7.ImageIndex"),Integer)
		Me.label7.ImageKey = resources.GetString("label7.ImageKey")
		Me.label7.ImeMode = CType(resources.GetObject("label7.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label7.Location = CType(resources.GetObject("label7.Location"),System.Drawing.Point)
		Me.label7.Name = "label7"
		Me.label7.RightToLeft = CType(resources.GetObject("label7.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label7.Size = CType(resources.GetObject("label7.Size"),System.Drawing.Size)
		Me.label7.TabIndex = CType(resources.GetObject("label7.TabIndex"),Integer)
		Me.label7.Text = resources.GetString("label7.Text")
		Me.label7.TextAlign = CType(resources.GetObject("label7.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.label7, resources.GetString("label7.ToolTip"))
		'
		'pictureBoxIPAddress
		'
		Me.pictureBoxIPAddress.AccessibleDescription = Nothing
		Me.pictureBoxIPAddress.AccessibleName = Nothing
		Me.pictureBoxIPAddress.Anchor = CType(resources.GetObject("pictureBoxIPAddress.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxIPAddress.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxIPAddress.BackgroundImage = Nothing
		Me.pictureBoxIPAddress.BackgroundImageLayout = CType(resources.GetObject("pictureBoxIPAddress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxIPAddress.Dock = CType(resources.GetObject("pictureBoxIPAddress.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxIPAddress.Font = Nothing
		Me.pictureBoxIPAddress.ImageLocation = Nothing
		Me.pictureBoxIPAddress.ImeMode = CType(resources.GetObject("pictureBoxIPAddress.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxIPAddress.Location = CType(resources.GetObject("pictureBoxIPAddress.Location"),System.Drawing.Point)
		Me.pictureBoxIPAddress.Name = "pictureBoxIPAddress"
		Me.pictureBoxIPAddress.RightToLeft = CType(resources.GetObject("pictureBoxIPAddress.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxIPAddress.Size = CType(resources.GetObject("pictureBoxIPAddress.Size"),System.Drawing.Size)
		Me.pictureBoxIPAddress.SizeMode = CType(resources.GetObject("pictureBoxIPAddress.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxIPAddress.TabIndex = CType(resources.GetObject("pictureBoxIPAddress.TabIndex"),Integer)
		Me.pictureBoxIPAddress.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxIPAddress, resources.GetString("pictureBoxIPAddress.ToolTip"))
		Me.pictureBoxIPAddress.WaitOnLoad = CType(resources.GetObject("pictureBoxIPAddress.WaitOnLoad"),Boolean)
		'
		'labelIPAddress
		'
		Me.labelIPAddress.AccessibleDescription = Nothing
		Me.labelIPAddress.AccessibleName = Nothing
		Me.labelIPAddress.Anchor = CType(resources.GetObject("labelIPAddress.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelIPAddress.AutoSize = CType(resources.GetObject("labelIPAddress.AutoSize"),Boolean)
		Me.labelIPAddress.BackgroundImageLayout = CType(resources.GetObject("labelIPAddress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelIPAddress.Dock = CType(resources.GetObject("labelIPAddress.Dock"),System.Windows.Forms.DockStyle)
		Me.labelIPAddress.Font = Nothing
		Me.labelIPAddress.ImageAlign = CType(resources.GetObject("labelIPAddress.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelIPAddress.ImageIndex = CType(resources.GetObject("labelIPAddress.ImageIndex"),Integer)
		Me.labelIPAddress.ImageKey = resources.GetString("labelIPAddress.ImageKey")
		Me.labelIPAddress.ImeMode = CType(resources.GetObject("labelIPAddress.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelIPAddress.Location = CType(resources.GetObject("labelIPAddress.Location"),System.Drawing.Point)
		Me.labelIPAddress.Name = "labelIPAddress"
		Me.labelIPAddress.RightToLeft = CType(resources.GetObject("labelIPAddress.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelIPAddress.Size = CType(resources.GetObject("labelIPAddress.Size"),System.Drawing.Size)
		Me.labelIPAddress.TabIndex = CType(resources.GetObject("labelIPAddress.TabIndex"),Integer)
		Me.labelIPAddress.Text = resources.GetString("labelIPAddress.Text")
		Me.labelIPAddress.TextAlign = CType(resources.GetObject("labelIPAddress.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelIPAddress, resources.GetString("labelIPAddress.ToolTip"))
		'
		'tabPageInternet
		'
		Me.tabPageInternet.AccessibleDescription = Nothing
		Me.tabPageInternet.AccessibleName = Nothing
		Me.tabPageInternet.Anchor = CType(resources.GetObject("tabPageInternet.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPageInternet.AutoScroll = CType(resources.GetObject("tabPageInternet.AutoScroll"),Boolean)
		Me.tabPageInternet.BackgroundImage = Nothing
		Me.tabPageInternet.BackgroundImageLayout = CType(resources.GetObject("tabPageInternet.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPageInternet.Controls.Add(Me.groupBoxPleaseNote)
		Me.tabPageInternet.Controls.Add(Me.groupBoxAutoConfigAddress)
		Me.tabPageInternet.Controls.Add(Me.buttonClearFirefox)
		Me.tabPageInternet.Controls.Add(Me.groupBoxWebBrowsers)
		Me.tabPageInternet.Controls.Add(Me.groupBoxProxy)
		Me.tabPageInternet.Controls.Add(Me.groupBoxHomepage)
		Me.tabPageInternet.Dock = CType(resources.GetObject("tabPageInternet.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPageInternet.Font = Nothing
		Me.tabPageInternet.ImageIndex = CType(resources.GetObject("tabPageInternet.ImageIndex"),Integer)
		Me.tabPageInternet.ImageKey = resources.GetString("tabPageInternet.ImageKey")
		Me.tabPageInternet.ImeMode = CType(resources.GetObject("tabPageInternet.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPageInternet.Location = CType(resources.GetObject("tabPageInternet.Location"),System.Drawing.Point)
		Me.tabPageInternet.Name = "tabPageInternet"
		Me.tabPageInternet.RightToLeft = CType(resources.GetObject("tabPageInternet.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPageInternet.Size = CType(resources.GetObject("tabPageInternet.Size"),System.Drawing.Size)
		Me.tabPageInternet.TabIndex = CType(resources.GetObject("tabPageInternet.TabIndex"),Integer)
		Me.tabPageInternet.Text = resources.GetString("tabPageInternet.Text")
		Me.toolTip1.SetToolTip(Me.tabPageInternet, resources.GetString("tabPageInternet.ToolTip"))
		Me.tabPageInternet.ToolTipText = resources.GetString("tabPageInternet.ToolTipText")
		Me.tabPageInternet.UseVisualStyleBackColor = true
		'
		'groupBoxPleaseNote
		'
		Me.groupBoxPleaseNote.AccessibleDescription = Nothing
		Me.groupBoxPleaseNote.AccessibleName = Nothing
		Me.groupBoxPleaseNote.Anchor = CType(resources.GetObject("groupBoxPleaseNote.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxPleaseNote.AutoSize = CType(resources.GetObject("groupBoxPleaseNote.AutoSize"),Boolean)
		Me.groupBoxPleaseNote.AutoSizeMode = CType(resources.GetObject("groupBoxPleaseNote.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxPleaseNote.BackgroundImage = Nothing
		Me.groupBoxPleaseNote.BackgroundImageLayout = CType(resources.GetObject("groupBoxPleaseNote.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxPleaseNote.Controls.Add(Me.labelPleaseNote)
		Me.groupBoxPleaseNote.Dock = CType(resources.GetObject("groupBoxPleaseNote.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxPleaseNote.Font = CType(resources.GetObject("groupBoxPleaseNote.Font"),System.Drawing.Font)
		Me.groupBoxPleaseNote.ImeMode = CType(resources.GetObject("groupBoxPleaseNote.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxPleaseNote.Location = CType(resources.GetObject("groupBoxPleaseNote.Location"),System.Drawing.Point)
		Me.groupBoxPleaseNote.Name = "groupBoxPleaseNote"
		Me.groupBoxPleaseNote.RightToLeft = CType(resources.GetObject("groupBoxPleaseNote.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxPleaseNote.Size = CType(resources.GetObject("groupBoxPleaseNote.Size"),System.Drawing.Size)
		Me.groupBoxPleaseNote.TabIndex = CType(resources.GetObject("groupBoxPleaseNote.TabIndex"),Integer)
		Me.groupBoxPleaseNote.TabStop = false
		Me.groupBoxPleaseNote.Text = resources.GetString("groupBoxPleaseNote.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxPleaseNote, resources.GetString("groupBoxPleaseNote.ToolTip"))
		'
		'labelPleaseNote
		'
		Me.labelPleaseNote.AccessibleDescription = Nothing
		Me.labelPleaseNote.AccessibleName = Nothing
		Me.labelPleaseNote.Anchor = CType(resources.GetObject("labelPleaseNote.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelPleaseNote.AutoSize = CType(resources.GetObject("labelPleaseNote.AutoSize"),Boolean)
		Me.labelPleaseNote.BackgroundImageLayout = CType(resources.GetObject("labelPleaseNote.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelPleaseNote.Dock = CType(resources.GetObject("labelPleaseNote.Dock"),System.Windows.Forms.DockStyle)
		Me.labelPleaseNote.Font = CType(resources.GetObject("labelPleaseNote.Font"),System.Drawing.Font)
		Me.labelPleaseNote.ImageAlign = CType(resources.GetObject("labelPleaseNote.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelPleaseNote.ImageIndex = CType(resources.GetObject("labelPleaseNote.ImageIndex"),Integer)
		Me.labelPleaseNote.ImageKey = resources.GetString("labelPleaseNote.ImageKey")
		Me.labelPleaseNote.ImeMode = CType(resources.GetObject("labelPleaseNote.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelPleaseNote.Location = CType(resources.GetObject("labelPleaseNote.Location"),System.Drawing.Point)
		Me.labelPleaseNote.Name = "labelPleaseNote"
		Me.labelPleaseNote.RightToLeft = CType(resources.GetObject("labelPleaseNote.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelPleaseNote.Size = CType(resources.GetObject("labelPleaseNote.Size"),System.Drawing.Size)
		Me.labelPleaseNote.TabIndex = CType(resources.GetObject("labelPleaseNote.TabIndex"),Integer)
		Me.labelPleaseNote.Text = resources.GetString("labelPleaseNote.Text")
		Me.labelPleaseNote.TextAlign = CType(resources.GetObject("labelPleaseNote.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelPleaseNote, resources.GetString("labelPleaseNote.ToolTip"))
		'
		'groupBoxAutoConfigAddress
		'
		Me.groupBoxAutoConfigAddress.AccessibleDescription = Nothing
		Me.groupBoxAutoConfigAddress.AccessibleName = Nothing
		Me.groupBoxAutoConfigAddress.Anchor = CType(resources.GetObject("groupBoxAutoConfigAddress.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxAutoConfigAddress.AutoSize = CType(resources.GetObject("groupBoxAutoConfigAddress.AutoSize"),Boolean)
		Me.groupBoxAutoConfigAddress.AutoSizeMode = CType(resources.GetObject("groupBoxAutoConfigAddress.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxAutoConfigAddress.BackgroundImage = Nothing
		Me.groupBoxAutoConfigAddress.BackgroundImageLayout = CType(resources.GetObject("groupBoxAutoConfigAddress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxAutoConfigAddress.Controls.Add(Me.textBoxAutoConfigAddress)
		Me.groupBoxAutoConfigAddress.Dock = CType(resources.GetObject("groupBoxAutoConfigAddress.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxAutoConfigAddress.Font = CType(resources.GetObject("groupBoxAutoConfigAddress.Font"),System.Drawing.Font)
		Me.groupBoxAutoConfigAddress.ImeMode = CType(resources.GetObject("groupBoxAutoConfigAddress.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxAutoConfigAddress.Location = CType(resources.GetObject("groupBoxAutoConfigAddress.Location"),System.Drawing.Point)
		Me.groupBoxAutoConfigAddress.Name = "groupBoxAutoConfigAddress"
		Me.groupBoxAutoConfigAddress.RightToLeft = CType(resources.GetObject("groupBoxAutoConfigAddress.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxAutoConfigAddress.Size = CType(resources.GetObject("groupBoxAutoConfigAddress.Size"),System.Drawing.Size)
		Me.groupBoxAutoConfigAddress.TabIndex = CType(resources.GetObject("groupBoxAutoConfigAddress.TabIndex"),Integer)
		Me.groupBoxAutoConfigAddress.TabStop = false
		Me.groupBoxAutoConfigAddress.Text = resources.GetString("groupBoxAutoConfigAddress.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxAutoConfigAddress, resources.GetString("groupBoxAutoConfigAddress.ToolTip"))
		'
		'textBoxAutoConfigAddress
		'
		Me.textBoxAutoConfigAddress.AccessibleDescription = Nothing
		Me.textBoxAutoConfigAddress.AccessibleName = Nothing
		Me.textBoxAutoConfigAddress.Anchor = CType(resources.GetObject("textBoxAutoConfigAddress.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxAutoConfigAddress.BackgroundImage = Nothing
		Me.textBoxAutoConfigAddress.BackgroundImageLayout = CType(resources.GetObject("textBoxAutoConfigAddress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxAutoConfigAddress.Dock = CType(resources.GetObject("textBoxAutoConfigAddress.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxAutoConfigAddress.Font = CType(resources.GetObject("textBoxAutoConfigAddress.Font"),System.Drawing.Font)
		Me.textBoxAutoConfigAddress.ImeMode = CType(resources.GetObject("textBoxAutoConfigAddress.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxAutoConfigAddress.Location = CType(resources.GetObject("textBoxAutoConfigAddress.Location"),System.Drawing.Point)
		Me.textBoxAutoConfigAddress.MaxLength = CType(resources.GetObject("textBoxAutoConfigAddress.MaxLength"),Integer)
		Me.textBoxAutoConfigAddress.Multiline = CType(resources.GetObject("textBoxAutoConfigAddress.Multiline"),Boolean)
		Me.textBoxAutoConfigAddress.Name = "textBoxAutoConfigAddress"
		Me.textBoxAutoConfigAddress.PasswordChar = CType(resources.GetObject("textBoxAutoConfigAddress.PasswordChar"),Char)
		Me.textBoxAutoConfigAddress.RightToLeft = CType(resources.GetObject("textBoxAutoConfigAddress.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxAutoConfigAddress.ScrollBars = CType(resources.GetObject("textBoxAutoConfigAddress.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxAutoConfigAddress.Size = CType(resources.GetObject("textBoxAutoConfigAddress.Size"),System.Drawing.Size)
		Me.textBoxAutoConfigAddress.TabIndex = CType(resources.GetObject("textBoxAutoConfigAddress.TabIndex"),Integer)
		Me.textBoxAutoConfigAddress.TextAlign = CType(resources.GetObject("textBoxAutoConfigAddress.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxAutoConfigAddress, resources.GetString("textBoxAutoConfigAddress.ToolTip"))
		Me.textBoxAutoConfigAddress.WordWrap = CType(resources.GetObject("textBoxAutoConfigAddress.WordWrap"),Boolean)
		'
		'buttonClearFirefox
		'
		Me.buttonClearFirefox.AccessibleDescription = Nothing
		Me.buttonClearFirefox.AccessibleName = Nothing
		Me.buttonClearFirefox.Anchor = CType(resources.GetObject("buttonClearFirefox.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonClearFirefox.AutoSize = CType(resources.GetObject("buttonClearFirefox.AutoSize"),Boolean)
		Me.buttonClearFirefox.AutoSizeMode = CType(resources.GetObject("buttonClearFirefox.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonClearFirefox.BackgroundImage = Nothing
		Me.buttonClearFirefox.BackgroundImageLayout = CType(resources.GetObject("buttonClearFirefox.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonClearFirefox.Dock = CType(resources.GetObject("buttonClearFirefox.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonClearFirefox.FlatStyle = CType(resources.GetObject("buttonClearFirefox.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonClearFirefox.Font = Nothing
		Me.buttonClearFirefox.ImageAlign = CType(resources.GetObject("buttonClearFirefox.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonClearFirefox.ImageIndex = CType(resources.GetObject("buttonClearFirefox.ImageIndex"),Integer)
		Me.buttonClearFirefox.ImageKey = resources.GetString("buttonClearFirefox.ImageKey")
		Me.buttonClearFirefox.ImeMode = CType(resources.GetObject("buttonClearFirefox.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonClearFirefox.Location = CType(resources.GetObject("buttonClearFirefox.Location"),System.Drawing.Point)
		Me.buttonClearFirefox.Name = "buttonClearFirefox"
		Me.buttonClearFirefox.RightToLeft = CType(resources.GetObject("buttonClearFirefox.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonClearFirefox.Size = CType(resources.GetObject("buttonClearFirefox.Size"),System.Drawing.Size)
		Me.buttonClearFirefox.TabIndex = CType(resources.GetObject("buttonClearFirefox.TabIndex"),Integer)
		Me.buttonClearFirefox.Text = resources.GetString("buttonClearFirefox.Text")
		Me.buttonClearFirefox.TextAlign = CType(resources.GetObject("buttonClearFirefox.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonClearFirefox.TextImageRelation = CType(resources.GetObject("buttonClearFirefox.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonClearFirefox, resources.GetString("buttonClearFirefox.ToolTip"))
		Me.buttonClearFirefox.UseVisualStyleBackColor = true
		AddHandler Me.buttonClearFirefox.Click, AddressOf Me.ButtonClearFirefoxClick
		'
		'groupBoxWebBrowsers
		'
		Me.groupBoxWebBrowsers.AccessibleDescription = Nothing
		Me.groupBoxWebBrowsers.AccessibleName = Nothing
		Me.groupBoxWebBrowsers.Anchor = CType(resources.GetObject("groupBoxWebBrowsers.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxWebBrowsers.AutoSize = CType(resources.GetObject("groupBoxWebBrowsers.AutoSize"),Boolean)
		Me.groupBoxWebBrowsers.AutoSizeMode = CType(resources.GetObject("groupBoxWebBrowsers.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxWebBrowsers.BackgroundImage = Nothing
		Me.groupBoxWebBrowsers.BackgroundImageLayout = CType(resources.GetObject("groupBoxWebBrowsers.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxWebBrowsers.Controls.Add(Me.checkBoxOpera)
		Me.groupBoxWebBrowsers.Controls.Add(Me.checkBoxIE)
		Me.groupBoxWebBrowsers.Controls.Add(Me.checkBoxFirefox)
		Me.groupBoxWebBrowsers.Dock = CType(resources.GetObject("groupBoxWebBrowsers.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxWebBrowsers.Font = CType(resources.GetObject("groupBoxWebBrowsers.Font"),System.Drawing.Font)
		Me.groupBoxWebBrowsers.ImeMode = CType(resources.GetObject("groupBoxWebBrowsers.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxWebBrowsers.Location = CType(resources.GetObject("groupBoxWebBrowsers.Location"),System.Drawing.Point)
		Me.groupBoxWebBrowsers.Name = "groupBoxWebBrowsers"
		Me.groupBoxWebBrowsers.RightToLeft = CType(resources.GetObject("groupBoxWebBrowsers.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxWebBrowsers.Size = CType(resources.GetObject("groupBoxWebBrowsers.Size"),System.Drawing.Size)
		Me.groupBoxWebBrowsers.TabIndex = CType(resources.GetObject("groupBoxWebBrowsers.TabIndex"),Integer)
		Me.groupBoxWebBrowsers.TabStop = false
		Me.groupBoxWebBrowsers.Text = resources.GetString("groupBoxWebBrowsers.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxWebBrowsers, resources.GetString("groupBoxWebBrowsers.ToolTip"))
		'
		'checkBoxOpera
		'
		Me.checkBoxOpera.AccessibleDescription = Nothing
		Me.checkBoxOpera.AccessibleName = Nothing
		Me.checkBoxOpera.Anchor = CType(resources.GetObject("checkBoxOpera.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.checkBoxOpera.Appearance = CType(resources.GetObject("checkBoxOpera.Appearance"),System.Windows.Forms.Appearance)
		Me.checkBoxOpera.AutoSize = CType(resources.GetObject("checkBoxOpera.AutoSize"),Boolean)
		Me.checkBoxOpera.BackgroundImage = Nothing
		Me.checkBoxOpera.BackgroundImageLayout = CType(resources.GetObject("checkBoxOpera.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkBoxOpera.CheckAlign = CType(resources.GetObject("checkBoxOpera.CheckAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxOpera.Dock = CType(resources.GetObject("checkBoxOpera.Dock"),System.Windows.Forms.DockStyle)
		Me.checkBoxOpera.FlatStyle = CType(resources.GetObject("checkBoxOpera.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.checkBoxOpera.Font = CType(resources.GetObject("checkBoxOpera.Font"),System.Drawing.Font)
		Me.checkBoxOpera.ImageAlign = CType(resources.GetObject("checkBoxOpera.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxOpera.ImageIndex = CType(resources.GetObject("checkBoxOpera.ImageIndex"),Integer)
		Me.checkBoxOpera.ImageKey = resources.GetString("checkBoxOpera.ImageKey")
		Me.checkBoxOpera.ImeMode = CType(resources.GetObject("checkBoxOpera.ImeMode"),System.Windows.Forms.ImeMode)
		Me.checkBoxOpera.Location = CType(resources.GetObject("checkBoxOpera.Location"),System.Drawing.Point)
		Me.checkBoxOpera.Name = "checkBoxOpera"
		Me.checkBoxOpera.RightToLeft = CType(resources.GetObject("checkBoxOpera.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.checkBoxOpera.Size = CType(resources.GetObject("checkBoxOpera.Size"),System.Drawing.Size)
		Me.checkBoxOpera.TabIndex = CType(resources.GetObject("checkBoxOpera.TabIndex"),Integer)
		Me.checkBoxOpera.Text = resources.GetString("checkBoxOpera.Text")
		Me.checkBoxOpera.TextAlign = CType(resources.GetObject("checkBoxOpera.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxOpera.TextImageRelation = CType(resources.GetObject("checkBoxOpera.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.checkBoxOpera, resources.GetString("checkBoxOpera.ToolTip"))
		Me.checkBoxOpera.UseVisualStyleBackColor = true
		'
		'checkBoxIE
		'
		Me.checkBoxIE.AccessibleDescription = Nothing
		Me.checkBoxIE.AccessibleName = Nothing
		Me.checkBoxIE.Anchor = CType(resources.GetObject("checkBoxIE.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.checkBoxIE.Appearance = CType(resources.GetObject("checkBoxIE.Appearance"),System.Windows.Forms.Appearance)
		Me.checkBoxIE.AutoSize = CType(resources.GetObject("checkBoxIE.AutoSize"),Boolean)
		Me.checkBoxIE.BackgroundImage = Nothing
		Me.checkBoxIE.BackgroundImageLayout = CType(resources.GetObject("checkBoxIE.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkBoxIE.CheckAlign = CType(resources.GetObject("checkBoxIE.CheckAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxIE.Dock = CType(resources.GetObject("checkBoxIE.Dock"),System.Windows.Forms.DockStyle)
		Me.checkBoxIE.FlatStyle = CType(resources.GetObject("checkBoxIE.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.checkBoxIE.Font = CType(resources.GetObject("checkBoxIE.Font"),System.Drawing.Font)
		Me.checkBoxIE.ImageAlign = CType(resources.GetObject("checkBoxIE.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxIE.ImageIndex = CType(resources.GetObject("checkBoxIE.ImageIndex"),Integer)
		Me.checkBoxIE.ImageKey = resources.GetString("checkBoxIE.ImageKey")
		Me.checkBoxIE.ImeMode = CType(resources.GetObject("checkBoxIE.ImeMode"),System.Windows.Forms.ImeMode)
		Me.checkBoxIE.Location = CType(resources.GetObject("checkBoxIE.Location"),System.Drawing.Point)
		Me.checkBoxIE.Name = "checkBoxIE"
		Me.checkBoxIE.RightToLeft = CType(resources.GetObject("checkBoxIE.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.checkBoxIE.Size = CType(resources.GetObject("checkBoxIE.Size"),System.Drawing.Size)
		Me.checkBoxIE.TabIndex = CType(resources.GetObject("checkBoxIE.TabIndex"),Integer)
		Me.checkBoxIE.Text = resources.GetString("checkBoxIE.Text")
		Me.checkBoxIE.TextAlign = CType(resources.GetObject("checkBoxIE.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxIE.TextImageRelation = CType(resources.GetObject("checkBoxIE.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.checkBoxIE, resources.GetString("checkBoxIE.ToolTip"))
		Me.checkBoxIE.UseVisualStyleBackColor = true
		'
		'checkBoxFirefox
		'
		Me.checkBoxFirefox.AccessibleDescription = Nothing
		Me.checkBoxFirefox.AccessibleName = Nothing
		Me.checkBoxFirefox.Anchor = CType(resources.GetObject("checkBoxFirefox.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.checkBoxFirefox.Appearance = CType(resources.GetObject("checkBoxFirefox.Appearance"),System.Windows.Forms.Appearance)
		Me.checkBoxFirefox.AutoSize = CType(resources.GetObject("checkBoxFirefox.AutoSize"),Boolean)
		Me.checkBoxFirefox.BackgroundImage = Nothing
		Me.checkBoxFirefox.BackgroundImageLayout = CType(resources.GetObject("checkBoxFirefox.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkBoxFirefox.CheckAlign = CType(resources.GetObject("checkBoxFirefox.CheckAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxFirefox.Dock = CType(resources.GetObject("checkBoxFirefox.Dock"),System.Windows.Forms.DockStyle)
		Me.checkBoxFirefox.FlatStyle = CType(resources.GetObject("checkBoxFirefox.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.checkBoxFirefox.Font = CType(resources.GetObject("checkBoxFirefox.Font"),System.Drawing.Font)
		Me.checkBoxFirefox.ImageAlign = CType(resources.GetObject("checkBoxFirefox.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxFirefox.ImageIndex = CType(resources.GetObject("checkBoxFirefox.ImageIndex"),Integer)
		Me.checkBoxFirefox.ImageKey = resources.GetString("checkBoxFirefox.ImageKey")
		Me.checkBoxFirefox.ImeMode = CType(resources.GetObject("checkBoxFirefox.ImeMode"),System.Windows.Forms.ImeMode)
		Me.checkBoxFirefox.Location = CType(resources.GetObject("checkBoxFirefox.Location"),System.Drawing.Point)
		Me.checkBoxFirefox.Name = "checkBoxFirefox"
		Me.checkBoxFirefox.RightToLeft = CType(resources.GetObject("checkBoxFirefox.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.checkBoxFirefox.Size = CType(resources.GetObject("checkBoxFirefox.Size"),System.Drawing.Size)
		Me.checkBoxFirefox.TabIndex = CType(resources.GetObject("checkBoxFirefox.TabIndex"),Integer)
		Me.checkBoxFirefox.Text = resources.GetString("checkBoxFirefox.Text")
		Me.checkBoxFirefox.TextAlign = CType(resources.GetObject("checkBoxFirefox.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxFirefox.TextImageRelation = CType(resources.GetObject("checkBoxFirefox.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.checkBoxFirefox, resources.GetString("checkBoxFirefox.ToolTip"))
		Me.checkBoxFirefox.UseVisualStyleBackColor = true
		'
		'groupBoxProxy
		'
		Me.groupBoxProxy.AccessibleDescription = Nothing
		Me.groupBoxProxy.AccessibleName = Nothing
		Me.groupBoxProxy.Anchor = CType(resources.GetObject("groupBoxProxy.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxProxy.AutoSize = CType(resources.GetObject("groupBoxProxy.AutoSize"),Boolean)
		Me.groupBoxProxy.AutoSizeMode = CType(resources.GetObject("groupBoxProxy.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxProxy.BackgroundImage = Nothing
		Me.groupBoxProxy.BackgroundImageLayout = CType(resources.GetObject("groupBoxProxy.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxProxy.Controls.Add(Me.checkBoxBypassProxyForLocalAddresses)
		Me.groupBoxProxy.Controls.Add(Me.textBoxPort)
		Me.groupBoxProxy.Controls.Add(Me.textBoxServerAddress)
		Me.groupBoxProxy.Controls.Add(Me.labelPort)
		Me.groupBoxProxy.Controls.Add(Me.labelServerAddress)
		Me.groupBoxProxy.Controls.Add(Me.checkBoxUseProxySettings)
		Me.groupBoxProxy.Dock = CType(resources.GetObject("groupBoxProxy.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxProxy.Font = CType(resources.GetObject("groupBoxProxy.Font"),System.Drawing.Font)
		Me.groupBoxProxy.ImeMode = CType(resources.GetObject("groupBoxProxy.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxProxy.Location = CType(resources.GetObject("groupBoxProxy.Location"),System.Drawing.Point)
		Me.groupBoxProxy.Name = "groupBoxProxy"
		Me.groupBoxProxy.RightToLeft = CType(resources.GetObject("groupBoxProxy.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxProxy.Size = CType(resources.GetObject("groupBoxProxy.Size"),System.Drawing.Size)
		Me.groupBoxProxy.TabIndex = CType(resources.GetObject("groupBoxProxy.TabIndex"),Integer)
		Me.groupBoxProxy.TabStop = false
		Me.groupBoxProxy.Text = resources.GetString("groupBoxProxy.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxProxy, resources.GetString("groupBoxProxy.ToolTip"))
		'
		'checkBoxBypassProxyForLocalAddresses
		'
		Me.checkBoxBypassProxyForLocalAddresses.AccessibleDescription = Nothing
		Me.checkBoxBypassProxyForLocalAddresses.AccessibleName = Nothing
		Me.checkBoxBypassProxyForLocalAddresses.Anchor = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.checkBoxBypassProxyForLocalAddresses.Appearance = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Appearance"),System.Windows.Forms.Appearance)
		Me.checkBoxBypassProxyForLocalAddresses.AutoSize = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.AutoSize"),Boolean)
		Me.checkBoxBypassProxyForLocalAddresses.BackgroundImage = Nothing
		Me.checkBoxBypassProxyForLocalAddresses.BackgroundImageLayout = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkBoxBypassProxyForLocalAddresses.CheckAlign = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.CheckAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxBypassProxyForLocalAddresses.Dock = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Dock"),System.Windows.Forms.DockStyle)
		Me.checkBoxBypassProxyForLocalAddresses.Enabled = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Enabled"),Boolean)
		Me.checkBoxBypassProxyForLocalAddresses.FlatStyle = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.checkBoxBypassProxyForLocalAddresses.Font = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Font"),System.Drawing.Font)
		Me.checkBoxBypassProxyForLocalAddresses.ImageAlign = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxBypassProxyForLocalAddresses.ImageIndex = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.ImageIndex"),Integer)
		Me.checkBoxBypassProxyForLocalAddresses.ImageKey = resources.GetString("checkBoxBypassProxyForLocalAddresses.ImageKey")
		Me.checkBoxBypassProxyForLocalAddresses.ImeMode = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.ImeMode"),System.Windows.Forms.ImeMode)
		Me.checkBoxBypassProxyForLocalAddresses.Location = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Location"),System.Drawing.Point)
		Me.checkBoxBypassProxyForLocalAddresses.Name = "checkBoxBypassProxyForLocalAddresses"
		Me.checkBoxBypassProxyForLocalAddresses.RightToLeft = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.checkBoxBypassProxyForLocalAddresses.Size = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.Size"),System.Drawing.Size)
		Me.checkBoxBypassProxyForLocalAddresses.TabIndex = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.TabIndex"),Integer)
		Me.checkBoxBypassProxyForLocalAddresses.Text = resources.GetString("checkBoxBypassProxyForLocalAddresses.Text")
		Me.checkBoxBypassProxyForLocalAddresses.TextAlign = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxBypassProxyForLocalAddresses.TextImageRelation = CType(resources.GetObject("checkBoxBypassProxyForLocalAddresses.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.checkBoxBypassProxyForLocalAddresses, resources.GetString("checkBoxBypassProxyForLocalAddresses.ToolTip"))
		Me.checkBoxBypassProxyForLocalAddresses.UseVisualStyleBackColor = true
		'
		'textBoxPort
		'
		Me.textBoxPort.AccessibleDescription = Nothing
		Me.textBoxPort.AccessibleName = Nothing
		Me.textBoxPort.Anchor = CType(resources.GetObject("textBoxPort.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPort.BackgroundImage = Nothing
		Me.textBoxPort.BackgroundImageLayout = CType(resources.GetObject("textBoxPort.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPort.Dock = CType(resources.GetObject("textBoxPort.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPort.Enabled = CType(resources.GetObject("textBoxPort.Enabled"),Boolean)
		Me.textBoxPort.Font = CType(resources.GetObject("textBoxPort.Font"),System.Drawing.Font)
		Me.textBoxPort.ImeMode = CType(resources.GetObject("textBoxPort.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPort.Location = CType(resources.GetObject("textBoxPort.Location"),System.Drawing.Point)
		Me.textBoxPort.MaxLength = CType(resources.GetObject("textBoxPort.MaxLength"),Integer)
		Me.textBoxPort.Multiline = CType(resources.GetObject("textBoxPort.Multiline"),Boolean)
		Me.textBoxPort.Name = "textBoxPort"
		Me.textBoxPort.PasswordChar = CType(resources.GetObject("textBoxPort.PasswordChar"),Char)
		Me.textBoxPort.RightToLeft = CType(resources.GetObject("textBoxPort.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPort.ScrollBars = CType(resources.GetObject("textBoxPort.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPort.Size = CType(resources.GetObject("textBoxPort.Size"),System.Drawing.Size)
		Me.textBoxPort.TabIndex = CType(resources.GetObject("textBoxPort.TabIndex"),Integer)
		Me.textBoxPort.TextAlign = CType(resources.GetObject("textBoxPort.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxPort, resources.GetString("textBoxPort.ToolTip"))
		Me.textBoxPort.WordWrap = CType(resources.GetObject("textBoxPort.WordWrap"),Boolean)
		'
		'textBoxServerAddress
		'
		Me.textBoxServerAddress.AccessibleDescription = Nothing
		Me.textBoxServerAddress.AccessibleName = Nothing
		Me.textBoxServerAddress.Anchor = CType(resources.GetObject("textBoxServerAddress.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxServerAddress.BackgroundImage = Nothing
		Me.textBoxServerAddress.BackgroundImageLayout = CType(resources.GetObject("textBoxServerAddress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxServerAddress.Dock = CType(resources.GetObject("textBoxServerAddress.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxServerAddress.Enabled = CType(resources.GetObject("textBoxServerAddress.Enabled"),Boolean)
		Me.textBoxServerAddress.Font = CType(resources.GetObject("textBoxServerAddress.Font"),System.Drawing.Font)
		Me.textBoxServerAddress.ImeMode = CType(resources.GetObject("textBoxServerAddress.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxServerAddress.Location = CType(resources.GetObject("textBoxServerAddress.Location"),System.Drawing.Point)
		Me.textBoxServerAddress.MaxLength = CType(resources.GetObject("textBoxServerAddress.MaxLength"),Integer)
		Me.textBoxServerAddress.Multiline = CType(resources.GetObject("textBoxServerAddress.Multiline"),Boolean)
		Me.textBoxServerAddress.Name = "textBoxServerAddress"
		Me.textBoxServerAddress.PasswordChar = CType(resources.GetObject("textBoxServerAddress.PasswordChar"),Char)
		Me.textBoxServerAddress.RightToLeft = CType(resources.GetObject("textBoxServerAddress.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxServerAddress.ScrollBars = CType(resources.GetObject("textBoxServerAddress.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxServerAddress.Size = CType(resources.GetObject("textBoxServerAddress.Size"),System.Drawing.Size)
		Me.textBoxServerAddress.TabIndex = CType(resources.GetObject("textBoxServerAddress.TabIndex"),Integer)
		Me.textBoxServerAddress.TextAlign = CType(resources.GetObject("textBoxServerAddress.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxServerAddress, resources.GetString("textBoxServerAddress.ToolTip"))
		Me.textBoxServerAddress.WordWrap = CType(resources.GetObject("textBoxServerAddress.WordWrap"),Boolean)
		'
		'labelPort
		'
		Me.labelPort.AccessibleDescription = Nothing
		Me.labelPort.AccessibleName = Nothing
		Me.labelPort.Anchor = CType(resources.GetObject("labelPort.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelPort.AutoSize = CType(resources.GetObject("labelPort.AutoSize"),Boolean)
		Me.labelPort.BackgroundImageLayout = CType(resources.GetObject("labelPort.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelPort.Dock = CType(resources.GetObject("labelPort.Dock"),System.Windows.Forms.DockStyle)
		Me.labelPort.Enabled = CType(resources.GetObject("labelPort.Enabled"),Boolean)
		Me.labelPort.Font = CType(resources.GetObject("labelPort.Font"),System.Drawing.Font)
		Me.labelPort.ImageAlign = CType(resources.GetObject("labelPort.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelPort.ImageIndex = CType(resources.GetObject("labelPort.ImageIndex"),Integer)
		Me.labelPort.ImageKey = resources.GetString("labelPort.ImageKey")
		Me.labelPort.ImeMode = CType(resources.GetObject("labelPort.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelPort.Location = CType(resources.GetObject("labelPort.Location"),System.Drawing.Point)
		Me.labelPort.Name = "labelPort"
		Me.labelPort.RightToLeft = CType(resources.GetObject("labelPort.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelPort.Size = CType(resources.GetObject("labelPort.Size"),System.Drawing.Size)
		Me.labelPort.TabIndex = CType(resources.GetObject("labelPort.TabIndex"),Integer)
		Me.labelPort.Text = resources.GetString("labelPort.Text")
		Me.labelPort.TextAlign = CType(resources.GetObject("labelPort.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelPort, resources.GetString("labelPort.ToolTip"))
		'
		'labelServerAddress
		'
		Me.labelServerAddress.AccessibleDescription = Nothing
		Me.labelServerAddress.AccessibleName = Nothing
		Me.labelServerAddress.Anchor = CType(resources.GetObject("labelServerAddress.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelServerAddress.AutoSize = CType(resources.GetObject("labelServerAddress.AutoSize"),Boolean)
		Me.labelServerAddress.BackgroundImageLayout = CType(resources.GetObject("labelServerAddress.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelServerAddress.Dock = CType(resources.GetObject("labelServerAddress.Dock"),System.Windows.Forms.DockStyle)
		Me.labelServerAddress.Enabled = CType(resources.GetObject("labelServerAddress.Enabled"),Boolean)
		Me.labelServerAddress.Font = CType(resources.GetObject("labelServerAddress.Font"),System.Drawing.Font)
		Me.labelServerAddress.ImageAlign = CType(resources.GetObject("labelServerAddress.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelServerAddress.ImageIndex = CType(resources.GetObject("labelServerAddress.ImageIndex"),Integer)
		Me.labelServerAddress.ImageKey = resources.GetString("labelServerAddress.ImageKey")
		Me.labelServerAddress.ImeMode = CType(resources.GetObject("labelServerAddress.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelServerAddress.Location = CType(resources.GetObject("labelServerAddress.Location"),System.Drawing.Point)
		Me.labelServerAddress.Name = "labelServerAddress"
		Me.labelServerAddress.RightToLeft = CType(resources.GetObject("labelServerAddress.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelServerAddress.Size = CType(resources.GetObject("labelServerAddress.Size"),System.Drawing.Size)
		Me.labelServerAddress.TabIndex = CType(resources.GetObject("labelServerAddress.TabIndex"),Integer)
		Me.labelServerAddress.Text = resources.GetString("labelServerAddress.Text")
		Me.labelServerAddress.TextAlign = CType(resources.GetObject("labelServerAddress.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelServerAddress, resources.GetString("labelServerAddress.ToolTip"))
		'
		'checkBoxUseProxySettings
		'
		Me.checkBoxUseProxySettings.AccessibleDescription = Nothing
		Me.checkBoxUseProxySettings.AccessibleName = Nothing
		Me.checkBoxUseProxySettings.Anchor = CType(resources.GetObject("checkBoxUseProxySettings.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.checkBoxUseProxySettings.Appearance = CType(resources.GetObject("checkBoxUseProxySettings.Appearance"),System.Windows.Forms.Appearance)
		Me.checkBoxUseProxySettings.AutoSize = CType(resources.GetObject("checkBoxUseProxySettings.AutoSize"),Boolean)
		Me.checkBoxUseProxySettings.BackgroundImage = Nothing
		Me.checkBoxUseProxySettings.BackgroundImageLayout = CType(resources.GetObject("checkBoxUseProxySettings.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.checkBoxUseProxySettings.CheckAlign = CType(resources.GetObject("checkBoxUseProxySettings.CheckAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxUseProxySettings.Dock = CType(resources.GetObject("checkBoxUseProxySettings.Dock"),System.Windows.Forms.DockStyle)
		Me.checkBoxUseProxySettings.FlatStyle = CType(resources.GetObject("checkBoxUseProxySettings.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.checkBoxUseProxySettings.Font = Nothing
		Me.checkBoxUseProxySettings.ImageAlign = CType(resources.GetObject("checkBoxUseProxySettings.ImageAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxUseProxySettings.ImageIndex = CType(resources.GetObject("checkBoxUseProxySettings.ImageIndex"),Integer)
		Me.checkBoxUseProxySettings.ImageKey = resources.GetString("checkBoxUseProxySettings.ImageKey")
		Me.checkBoxUseProxySettings.ImeMode = CType(resources.GetObject("checkBoxUseProxySettings.ImeMode"),System.Windows.Forms.ImeMode)
		Me.checkBoxUseProxySettings.Location = CType(resources.GetObject("checkBoxUseProxySettings.Location"),System.Drawing.Point)
		Me.checkBoxUseProxySettings.Name = "checkBoxUseProxySettings"
		Me.checkBoxUseProxySettings.RightToLeft = CType(resources.GetObject("checkBoxUseProxySettings.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.checkBoxUseProxySettings.Size = CType(resources.GetObject("checkBoxUseProxySettings.Size"),System.Drawing.Size)
		Me.checkBoxUseProxySettings.TabIndex = CType(resources.GetObject("checkBoxUseProxySettings.TabIndex"),Integer)
		Me.checkBoxUseProxySettings.TextAlign = CType(resources.GetObject("checkBoxUseProxySettings.TextAlign"),System.Drawing.ContentAlignment)
		Me.checkBoxUseProxySettings.TextImageRelation = CType(resources.GetObject("checkBoxUseProxySettings.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.checkBoxUseProxySettings, resources.GetString("checkBoxUseProxySettings.ToolTip"))
		Me.checkBoxUseProxySettings.UseVisualStyleBackColor = true
		AddHandler Me.checkBoxUseProxySettings.CheckedChanged, AddressOf Me.CheckBoxUseProxySettingsCheckedChanged
		'
		'groupBoxHomepage
		'
		Me.groupBoxHomepage.AccessibleDescription = Nothing
		Me.groupBoxHomepage.AccessibleName = Nothing
		Me.groupBoxHomepage.Anchor = CType(resources.GetObject("groupBoxHomepage.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxHomepage.AutoSize = CType(resources.GetObject("groupBoxHomepage.AutoSize"),Boolean)
		Me.groupBoxHomepage.AutoSizeMode = CType(resources.GetObject("groupBoxHomepage.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxHomepage.BackgroundImage = Nothing
		Me.groupBoxHomepage.BackgroundImageLayout = CType(resources.GetObject("groupBoxHomepage.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxHomepage.Controls.Add(Me.labelHomepageNote)
		Me.groupBoxHomepage.Controls.Add(Me.buttonUseBlankHomepage)
		Me.groupBoxHomepage.Controls.Add(Me.textBoxDefaultHomepage)
		Me.groupBoxHomepage.Dock = CType(resources.GetObject("groupBoxHomepage.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxHomepage.Font = CType(resources.GetObject("groupBoxHomepage.Font"),System.Drawing.Font)
		Me.groupBoxHomepage.ImeMode = CType(resources.GetObject("groupBoxHomepage.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxHomepage.Location = CType(resources.GetObject("groupBoxHomepage.Location"),System.Drawing.Point)
		Me.groupBoxHomepage.Name = "groupBoxHomepage"
		Me.groupBoxHomepage.RightToLeft = CType(resources.GetObject("groupBoxHomepage.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxHomepage.Size = CType(resources.GetObject("groupBoxHomepage.Size"),System.Drawing.Size)
		Me.groupBoxHomepage.TabIndex = CType(resources.GetObject("groupBoxHomepage.TabIndex"),Integer)
		Me.groupBoxHomepage.TabStop = false
		Me.groupBoxHomepage.Text = resources.GetString("groupBoxHomepage.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxHomepage, resources.GetString("groupBoxHomepage.ToolTip"))
		'
		'labelHomepageNote
		'
		Me.labelHomepageNote.AccessibleDescription = Nothing
		Me.labelHomepageNote.AccessibleName = Nothing
		Me.labelHomepageNote.Anchor = CType(resources.GetObject("labelHomepageNote.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelHomepageNote.AutoSize = CType(resources.GetObject("labelHomepageNote.AutoSize"),Boolean)
		Me.labelHomepageNote.BackgroundImageLayout = CType(resources.GetObject("labelHomepageNote.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelHomepageNote.Dock = CType(resources.GetObject("labelHomepageNote.Dock"),System.Windows.Forms.DockStyle)
		Me.labelHomepageNote.Font = CType(resources.GetObject("labelHomepageNote.Font"),System.Drawing.Font)
		Me.labelHomepageNote.ImageAlign = CType(resources.GetObject("labelHomepageNote.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelHomepageNote.ImageIndex = CType(resources.GetObject("labelHomepageNote.ImageIndex"),Integer)
		Me.labelHomepageNote.ImageKey = resources.GetString("labelHomepageNote.ImageKey")
		Me.labelHomepageNote.ImeMode = CType(resources.GetObject("labelHomepageNote.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelHomepageNote.Location = CType(resources.GetObject("labelHomepageNote.Location"),System.Drawing.Point)
		Me.labelHomepageNote.Name = "labelHomepageNote"
		Me.labelHomepageNote.RightToLeft = CType(resources.GetObject("labelHomepageNote.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelHomepageNote.Size = CType(resources.GetObject("labelHomepageNote.Size"),System.Drawing.Size)
		Me.labelHomepageNote.TabIndex = CType(resources.GetObject("labelHomepageNote.TabIndex"),Integer)
		Me.labelHomepageNote.Text = resources.GetString("labelHomepageNote.Text")
		Me.labelHomepageNote.TextAlign = CType(resources.GetObject("labelHomepageNote.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelHomepageNote, resources.GetString("labelHomepageNote.ToolTip"))
		'
		'buttonUseBlankHomepage
		'
		Me.buttonUseBlankHomepage.AccessibleDescription = Nothing
		Me.buttonUseBlankHomepage.AccessibleName = Nothing
		Me.buttonUseBlankHomepage.Anchor = CType(resources.GetObject("buttonUseBlankHomepage.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonUseBlankHomepage.AutoSize = CType(resources.GetObject("buttonUseBlankHomepage.AutoSize"),Boolean)
		Me.buttonUseBlankHomepage.AutoSizeMode = CType(resources.GetObject("buttonUseBlankHomepage.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonUseBlankHomepage.BackgroundImage = Nothing
		Me.buttonUseBlankHomepage.BackgroundImageLayout = CType(resources.GetObject("buttonUseBlankHomepage.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonUseBlankHomepage.Dock = CType(resources.GetObject("buttonUseBlankHomepage.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonUseBlankHomepage.FlatStyle = CType(resources.GetObject("buttonUseBlankHomepage.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonUseBlankHomepage.Font = CType(resources.GetObject("buttonUseBlankHomepage.Font"),System.Drawing.Font)
		Me.buttonUseBlankHomepage.ImageAlign = CType(resources.GetObject("buttonUseBlankHomepage.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonUseBlankHomepage.ImageIndex = CType(resources.GetObject("buttonUseBlankHomepage.ImageIndex"),Integer)
		Me.buttonUseBlankHomepage.ImageKey = resources.GetString("buttonUseBlankHomepage.ImageKey")
		Me.buttonUseBlankHomepage.ImeMode = CType(resources.GetObject("buttonUseBlankHomepage.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonUseBlankHomepage.Location = CType(resources.GetObject("buttonUseBlankHomepage.Location"),System.Drawing.Point)
		Me.buttonUseBlankHomepage.Name = "buttonUseBlankHomepage"
		Me.buttonUseBlankHomepage.RightToLeft = CType(resources.GetObject("buttonUseBlankHomepage.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonUseBlankHomepage.Size = CType(resources.GetObject("buttonUseBlankHomepage.Size"),System.Drawing.Size)
		Me.buttonUseBlankHomepage.TabIndex = CType(resources.GetObject("buttonUseBlankHomepage.TabIndex"),Integer)
		Me.buttonUseBlankHomepage.Text = resources.GetString("buttonUseBlankHomepage.Text")
		Me.buttonUseBlankHomepage.TextAlign = CType(resources.GetObject("buttonUseBlankHomepage.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonUseBlankHomepage.TextImageRelation = CType(resources.GetObject("buttonUseBlankHomepage.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonUseBlankHomepage, resources.GetString("buttonUseBlankHomepage.ToolTip"))
		Me.buttonUseBlankHomepage.UseVisualStyleBackColor = true
		AddHandler Me.buttonUseBlankHomepage.Click, AddressOf Me.ButtonUseBlankHomepageClick
		'
		'textBoxDefaultHomepage
		'
		Me.textBoxDefaultHomepage.AccessibleDescription = Nothing
		Me.textBoxDefaultHomepage.AccessibleName = Nothing
		Me.textBoxDefaultHomepage.Anchor = CType(resources.GetObject("textBoxDefaultHomepage.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxDefaultHomepage.BackgroundImage = Nothing
		Me.textBoxDefaultHomepage.BackgroundImageLayout = CType(resources.GetObject("textBoxDefaultHomepage.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxDefaultHomepage.Dock = CType(resources.GetObject("textBoxDefaultHomepage.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxDefaultHomepage.Font = CType(resources.GetObject("textBoxDefaultHomepage.Font"),System.Drawing.Font)
		Me.textBoxDefaultHomepage.ImeMode = CType(resources.GetObject("textBoxDefaultHomepage.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxDefaultHomepage.Location = CType(resources.GetObject("textBoxDefaultHomepage.Location"),System.Drawing.Point)
		Me.textBoxDefaultHomepage.MaxLength = CType(resources.GetObject("textBoxDefaultHomepage.MaxLength"),Integer)
		Me.textBoxDefaultHomepage.Multiline = CType(resources.GetObject("textBoxDefaultHomepage.Multiline"),Boolean)
		Me.textBoxDefaultHomepage.Name = "textBoxDefaultHomepage"
		Me.textBoxDefaultHomepage.PasswordChar = CType(resources.GetObject("textBoxDefaultHomepage.PasswordChar"),Char)
		Me.textBoxDefaultHomepage.RightToLeft = CType(resources.GetObject("textBoxDefaultHomepage.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxDefaultHomepage.ScrollBars = CType(resources.GetObject("textBoxDefaultHomepage.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxDefaultHomepage.Size = CType(resources.GetObject("textBoxDefaultHomepage.Size"),System.Drawing.Size)
		Me.textBoxDefaultHomepage.TabIndex = CType(resources.GetObject("textBoxDefaultHomepage.TabIndex"),Integer)
		Me.textBoxDefaultHomepage.TextAlign = CType(resources.GetObject("textBoxDefaultHomepage.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxDefaultHomepage, resources.GetString("textBoxDefaultHomepage.ToolTip"))
		Me.textBoxDefaultHomepage.WordWrap = CType(resources.GetObject("textBoxDefaultHomepage.WordWrap"),Boolean)
		'
		'tabPageMappedDrives
		'
		Me.tabPageMappedDrives.AccessibleDescription = Nothing
		Me.tabPageMappedDrives.AccessibleName = Nothing
		Me.tabPageMappedDrives.Anchor = CType(resources.GetObject("tabPageMappedDrives.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPageMappedDrives.AutoScroll = CType(resources.GetObject("tabPageMappedDrives.AutoScroll"),Boolean)
		Me.tabPageMappedDrives.BackgroundImage = Nothing
		Me.tabPageMappedDrives.BackgroundImageLayout = CType(resources.GetObject("tabPageMappedDrives.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPageMappedDrives.Controls.Add(Me.listViewMappedDrives)
		Me.tabPageMappedDrives.Controls.Add(Me.toolStripMappedDrives)
		Me.tabPageMappedDrives.Dock = CType(resources.GetObject("tabPageMappedDrives.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPageMappedDrives.Font = Nothing
		Me.tabPageMappedDrives.ImageIndex = CType(resources.GetObject("tabPageMappedDrives.ImageIndex"),Integer)
		Me.tabPageMappedDrives.ImageKey = resources.GetString("tabPageMappedDrives.ImageKey")
		Me.tabPageMappedDrives.ImeMode = CType(resources.GetObject("tabPageMappedDrives.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPageMappedDrives.Location = CType(resources.GetObject("tabPageMappedDrives.Location"),System.Drawing.Point)
		Me.tabPageMappedDrives.Name = "tabPageMappedDrives"
		Me.tabPageMappedDrives.Padding = CType(resources.GetObject("tabPageMappedDrives.Padding"),System.Windows.Forms.Padding)
		Me.tabPageMappedDrives.RightToLeft = CType(resources.GetObject("tabPageMappedDrives.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPageMappedDrives.Size = CType(resources.GetObject("tabPageMappedDrives.Size"),System.Drawing.Size)
		Me.tabPageMappedDrives.TabIndex = CType(resources.GetObject("tabPageMappedDrives.TabIndex"),Integer)
		Me.tabPageMappedDrives.Text = resources.GetString("tabPageMappedDrives.Text")
		Me.toolTip1.SetToolTip(Me.tabPageMappedDrives, resources.GetString("tabPageMappedDrives.ToolTip"))
		Me.tabPageMappedDrives.ToolTipText = resources.GetString("tabPageMappedDrives.ToolTipText")
		Me.tabPageMappedDrives.UseVisualStyleBackColor = true
		'
		'listViewMappedDrives
		'
		Me.listViewMappedDrives.AccessibleDescription = Nothing
		Me.listViewMappedDrives.AccessibleName = Nothing
		Me.listViewMappedDrives.Alignment = CType(resources.GetObject("listViewMappedDrives.Alignment"),System.Windows.Forms.ListViewAlignment)
		Me.listViewMappedDrives.Anchor = CType(resources.GetObject("listViewMappedDrives.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.listViewMappedDrives.BackgroundImage = Nothing
		Me.listViewMappedDrives.BackgroundImageLayout = CType(resources.GetObject("listViewMappedDrives.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.listViewMappedDrives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderDrive, Me.columnHeaderPath, Me.columnHeaderUsername, Me.columnHeaderPassword})
		Me.listViewMappedDrives.Dock = CType(resources.GetObject("listViewMappedDrives.Dock"),System.Windows.Forms.DockStyle)
		Me.listViewMappedDrives.Font = Nothing
		Me.listViewMappedDrives.FullRowSelect = true
		Me.listViewMappedDrives.GridLines = true
		Me.listViewMappedDrives.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.listViewMappedDrives.HideSelection = false
		Me.listViewMappedDrives.ImeMode = CType(resources.GetObject("listViewMappedDrives.ImeMode"),System.Windows.Forms.ImeMode)
		Me.listViewMappedDrives.LabelWrap = CType(resources.GetObject("listViewMappedDrives.LabelWrap"),Boolean)
		Me.listViewMappedDrives.Location = CType(resources.GetObject("listViewMappedDrives.Location"),System.Drawing.Point)
		Me.listViewMappedDrives.MultiSelect = false
		Me.listViewMappedDrives.Name = "listViewMappedDrives"
		Me.listViewMappedDrives.RightToLeft = CType(resources.GetObject("listViewMappedDrives.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.listViewMappedDrives.RightToLeftLayout = CType(resources.GetObject("listViewMappedDrives.RightToLeftLayout"),Boolean)
		Me.listViewMappedDrives.Size = CType(resources.GetObject("listViewMappedDrives.Size"),System.Drawing.Size)
		Me.listViewMappedDrives.SmallImageList = Me.imageListDrives
		Me.listViewMappedDrives.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.listViewMappedDrives.TabIndex = CType(resources.GetObject("listViewMappedDrives.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.listViewMappedDrives, resources.GetString("listViewMappedDrives.ToolTip"))
		Me.listViewMappedDrives.UseCompatibleStateImageBehavior = false
		Me.listViewMappedDrives.View = System.Windows.Forms.View.Details
		'
		'columnHeaderDrive
		'
		Me.columnHeaderDrive.Text = resources.GetString("columnHeaderDrive.Text")
		Me.columnHeaderDrive.TextAlign = CType(resources.GetObject("columnHeaderDrive.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderDrive.Width = CType(resources.GetObject("columnHeaderDrive.Width"),Integer)
		'
		'columnHeaderPath
		'
		Me.columnHeaderPath.Text = resources.GetString("columnHeaderPath.Text")
		Me.columnHeaderPath.TextAlign = CType(resources.GetObject("columnHeaderPath.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderPath.Width = CType(resources.GetObject("columnHeaderPath.Width"),Integer)
		'
		'columnHeaderUsername
		'
		Me.columnHeaderUsername.Text = resources.GetString("columnHeaderUsername.Text")
		Me.columnHeaderUsername.TextAlign = CType(resources.GetObject("columnHeaderUsername.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderUsername.Width = CType(resources.GetObject("columnHeaderUsername.Width"),Integer)
		'
		'columnHeaderPassword
		'
		Me.columnHeaderPassword.Text = resources.GetString("columnHeaderPassword.Text")
		Me.columnHeaderPassword.TextAlign = CType(resources.GetObject("columnHeaderPassword.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderPassword.Width = CType(resources.GetObject("columnHeaderPassword.Width"),Integer)
		'
		'imageListDrives
		'
		Me.imageListDrives.ImageStream = CType(resources.GetObject("imageListDrives.ImageStream"),System.Windows.Forms.ImageListStreamer)
		Me.imageListDrives.TransparentColor = System.Drawing.Color.Transparent
		Me.imageListDrives.Images.SetKeyName(0, "drive_network.png")
		'
		'toolStripMappedDrives
		'
		Me.toolStripMappedDrives.AccessibleDescription = Nothing
		Me.toolStripMappedDrives.AccessibleName = Nothing
		Me.toolStripMappedDrives.Anchor = CType(resources.GetObject("toolStripMappedDrives.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.toolStripMappedDrives.AutoSize = CType(resources.GetObject("toolStripMappedDrives.AutoSize"),Boolean)
		Me.toolStripMappedDrives.BackgroundImage = Nothing
		Me.toolStripMappedDrives.BackgroundImageLayout = CType(resources.GetObject("toolStripMappedDrives.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripMappedDrives.Dock = CType(resources.GetObject("toolStripMappedDrives.Dock"),System.Windows.Forms.DockStyle)
		Me.toolStripMappedDrives.Font = Nothing
		Me.toolStripMappedDrives.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.toolStripMappedDrives.ImeMode = CType(resources.GetObject("toolStripMappedDrives.ImeMode"),System.Windows.Forms.ImeMode)
		Me.toolStripMappedDrives.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonAddDrive, Me.toolStripSeparator1, Me.toolStripButtonEditDrive, Me.toolStripButtonRemoveDrive})
		Me.toolStripMappedDrives.Location = CType(resources.GetObject("toolStripMappedDrives.Location"),System.Drawing.Point)
		Me.toolStripMappedDrives.Name = "toolStripMappedDrives"
		Me.toolStripMappedDrives.RightToLeft = CType(resources.GetObject("toolStripMappedDrives.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.toolStripMappedDrives.Size = CType(resources.GetObject("toolStripMappedDrives.Size"),System.Drawing.Size)
		Me.toolStripMappedDrives.TabIndex = CType(resources.GetObject("toolStripMappedDrives.TabIndex"),Integer)
		Me.toolStripMappedDrives.Text = resources.GetString("toolStripMappedDrives.Text")
		Me.toolTip1.SetToolTip(Me.toolStripMappedDrives, resources.GetString("toolStripMappedDrives.ToolTip"))
		'
		'toolStripButtonAddDrive
		'
		Me.toolStripButtonAddDrive.AccessibleDescription = Nothing
		Me.toolStripButtonAddDrive.AccessibleName = Nothing
		Me.toolStripButtonAddDrive.AutoSize = CType(resources.GetObject("toolStripButtonAddDrive.AutoSize"),Boolean)
		Me.toolStripButtonAddDrive.BackgroundImage = Nothing
		Me.toolStripButtonAddDrive.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonAddDrive.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonAddDrive.Enabled = CType(resources.GetObject("toolStripButtonAddDrive.Enabled"),Boolean)
		Me.toolStripButtonAddDrive.Image = CType(resources.GetObject("toolStripButtonAddDrive.Image"),System.Drawing.Image)
		Me.toolStripButtonAddDrive.ImageAlign = CType(resources.GetObject("toolStripButtonAddDrive.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonAddDrive.ImageScaling = CType(resources.GetObject("toolStripButtonAddDrive.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonAddDrive.ImageTransparentColor = CType(resources.GetObject("toolStripButtonAddDrive.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonAddDrive.Name = "toolStripButtonAddDrive"
		Me.toolStripButtonAddDrive.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonAddDrive.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonAddDrive.Size = CType(resources.GetObject("toolStripButtonAddDrive.Size"),System.Drawing.Size)
		Me.toolStripButtonAddDrive.Text = resources.GetString("toolStripButtonAddDrive.Text")
		Me.toolStripButtonAddDrive.TextAlign = CType(resources.GetObject("toolStripButtonAddDrive.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonAddDrive.TextImageRelation = CType(resources.GetObject("toolStripButtonAddDrive.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonAddDrive.Click, AddressOf Me.ToolStripButtonAddDriveClick
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.AccessibleDescription = Nothing
		Me.toolStripSeparator1.AccessibleName = Nothing
		Me.toolStripSeparator1.AutoSize = CType(resources.GetObject("toolStripSeparator1.AutoSize"),Boolean)
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = CType(resources.GetObject("toolStripSeparator1.Size"),System.Drawing.Size)
		'
		'toolStripButtonEditDrive
		'
		Me.toolStripButtonEditDrive.AccessibleDescription = Nothing
		Me.toolStripButtonEditDrive.AccessibleName = Nothing
		Me.toolStripButtonEditDrive.AutoSize = CType(resources.GetObject("toolStripButtonEditDrive.AutoSize"),Boolean)
		Me.toolStripButtonEditDrive.BackgroundImage = Nothing
		Me.toolStripButtonEditDrive.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonEditDrive.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonEditDrive.Enabled = CType(resources.GetObject("toolStripButtonEditDrive.Enabled"),Boolean)
		Me.toolStripButtonEditDrive.Image = CType(resources.GetObject("toolStripButtonEditDrive.Image"),System.Drawing.Image)
		Me.toolStripButtonEditDrive.ImageAlign = CType(resources.GetObject("toolStripButtonEditDrive.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonEditDrive.ImageScaling = CType(resources.GetObject("toolStripButtonEditDrive.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonEditDrive.ImageTransparentColor = CType(resources.GetObject("toolStripButtonEditDrive.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonEditDrive.Name = "toolStripButtonEditDrive"
		Me.toolStripButtonEditDrive.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonEditDrive.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonEditDrive.Size = CType(resources.GetObject("toolStripButtonEditDrive.Size"),System.Drawing.Size)
		Me.toolStripButtonEditDrive.Text = resources.GetString("toolStripButtonEditDrive.Text")
		Me.toolStripButtonEditDrive.TextAlign = CType(resources.GetObject("toolStripButtonEditDrive.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonEditDrive.TextImageRelation = CType(resources.GetObject("toolStripButtonEditDrive.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonEditDrive.Click, AddressOf Me.ToolStripButtonEditDriveClick
		'
		'toolStripButtonRemoveDrive
		'
		Me.toolStripButtonRemoveDrive.AccessibleDescription = Nothing
		Me.toolStripButtonRemoveDrive.AccessibleName = Nothing
		Me.toolStripButtonRemoveDrive.AutoSize = CType(resources.GetObject("toolStripButtonRemoveDrive.AutoSize"),Boolean)
		Me.toolStripButtonRemoveDrive.BackgroundImage = Nothing
		Me.toolStripButtonRemoveDrive.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonRemoveDrive.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonRemoveDrive.Enabled = CType(resources.GetObject("toolStripButtonRemoveDrive.Enabled"),Boolean)
		Me.toolStripButtonRemoveDrive.Image = CType(resources.GetObject("toolStripButtonRemoveDrive.Image"),System.Drawing.Image)
		Me.toolStripButtonRemoveDrive.ImageAlign = CType(resources.GetObject("toolStripButtonRemoveDrive.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonRemoveDrive.ImageScaling = CType(resources.GetObject("toolStripButtonRemoveDrive.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonRemoveDrive.ImageTransparentColor = CType(resources.GetObject("toolStripButtonRemoveDrive.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonRemoveDrive.Name = "toolStripButtonRemoveDrive"
		Me.toolStripButtonRemoveDrive.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonRemoveDrive.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonRemoveDrive.Size = CType(resources.GetObject("toolStripButtonRemoveDrive.Size"),System.Drawing.Size)
		Me.toolStripButtonRemoveDrive.Text = resources.GetString("toolStripButtonRemoveDrive.Text")
		Me.toolStripButtonRemoveDrive.TextAlign = CType(resources.GetObject("toolStripButtonRemoveDrive.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonRemoveDrive.TextImageRelation = CType(resources.GetObject("toolStripButtonRemoveDrive.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonRemoveDrive.Click, AddressOf Me.ToolStripButtonRemoveDriveClick
		'
		'tabPagePrinter
		'
		Me.tabPagePrinter.AccessibleDescription = Nothing
		Me.tabPagePrinter.AccessibleName = Nothing
		Me.tabPagePrinter.Anchor = CType(resources.GetObject("tabPagePrinter.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPagePrinter.AutoScroll = CType(resources.GetObject("tabPagePrinter.AutoScroll"),Boolean)
		Me.tabPagePrinter.BackgroundImage = Nothing
		Me.tabPagePrinter.BackgroundImageLayout = CType(resources.GetObject("tabPagePrinter.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPagePrinter.Controls.Add(Me.groupBoxPrinter)
		Me.tabPagePrinter.Dock = CType(resources.GetObject("tabPagePrinter.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPagePrinter.Font = Nothing
		Me.tabPagePrinter.ImageIndex = CType(resources.GetObject("tabPagePrinter.ImageIndex"),Integer)
		Me.tabPagePrinter.ImageKey = resources.GetString("tabPagePrinter.ImageKey")
		Me.tabPagePrinter.ImeMode = CType(resources.GetObject("tabPagePrinter.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPagePrinter.Location = CType(resources.GetObject("tabPagePrinter.Location"),System.Drawing.Point)
		Me.tabPagePrinter.Name = "tabPagePrinter"
		Me.tabPagePrinter.RightToLeft = CType(resources.GetObject("tabPagePrinter.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPagePrinter.Size = CType(resources.GetObject("tabPagePrinter.Size"),System.Drawing.Size)
		Me.tabPagePrinter.TabIndex = CType(resources.GetObject("tabPagePrinter.TabIndex"),Integer)
		Me.tabPagePrinter.Text = resources.GetString("tabPagePrinter.Text")
		Me.toolTip1.SetToolTip(Me.tabPagePrinter, resources.GetString("tabPagePrinter.ToolTip"))
		Me.tabPagePrinter.ToolTipText = resources.GetString("tabPagePrinter.ToolTipText")
		Me.tabPagePrinter.UseVisualStyleBackColor = true
		'
		'groupBoxPrinter
		'
		Me.groupBoxPrinter.AccessibleDescription = Nothing
		Me.groupBoxPrinter.AccessibleName = Nothing
		Me.groupBoxPrinter.Anchor = CType(resources.GetObject("groupBoxPrinter.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxPrinter.AutoSize = CType(resources.GetObject("groupBoxPrinter.AutoSize"),Boolean)
		Me.groupBoxPrinter.AutoSizeMode = CType(resources.GetObject("groupBoxPrinter.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxPrinter.BackgroundImage = Nothing
		Me.groupBoxPrinter.BackgroundImageLayout = CType(resources.GetObject("groupBoxPrinter.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxPrinter.Controls.Add(Me.comboBoxPrinters)
		Me.groupBoxPrinter.Controls.Add(Me.buttonGetDefaultPrinter)
		Me.groupBoxPrinter.Dock = CType(resources.GetObject("groupBoxPrinter.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxPrinter.Font = CType(resources.GetObject("groupBoxPrinter.Font"),System.Drawing.Font)
		Me.groupBoxPrinter.ImeMode = CType(resources.GetObject("groupBoxPrinter.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxPrinter.Location = CType(resources.GetObject("groupBoxPrinter.Location"),System.Drawing.Point)
		Me.groupBoxPrinter.Name = "groupBoxPrinter"
		Me.groupBoxPrinter.RightToLeft = CType(resources.GetObject("groupBoxPrinter.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxPrinter.Size = CType(resources.GetObject("groupBoxPrinter.Size"),System.Drawing.Size)
		Me.groupBoxPrinter.TabIndex = CType(resources.GetObject("groupBoxPrinter.TabIndex"),Integer)
		Me.groupBoxPrinter.TabStop = false
		Me.groupBoxPrinter.Text = resources.GetString("groupBoxPrinter.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxPrinter, resources.GetString("groupBoxPrinter.ToolTip"))
		'
		'comboBoxPrinters
		'
		Me.comboBoxPrinters.AccessibleDescription = Nothing
		Me.comboBoxPrinters.AccessibleName = Nothing
		Me.comboBoxPrinters.Anchor = CType(resources.GetObject("comboBoxPrinters.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxPrinters.BackgroundImage = Nothing
		Me.comboBoxPrinters.BackgroundImageLayout = CType(resources.GetObject("comboBoxPrinters.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxPrinters.Dock = CType(resources.GetObject("comboBoxPrinters.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxPrinters.FlatStyle = CType(resources.GetObject("comboBoxPrinters.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxPrinters.Font = CType(resources.GetObject("comboBoxPrinters.Font"),System.Drawing.Font)
		Me.comboBoxPrinters.FormattingEnabled = true
		Me.comboBoxPrinters.ImeMode = CType(resources.GetObject("comboBoxPrinters.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxPrinters.IntegralHeight = CType(resources.GetObject("comboBoxPrinters.IntegralHeight"),Boolean)
		Me.comboBoxPrinters.Location = CType(resources.GetObject("comboBoxPrinters.Location"),System.Drawing.Point)
		Me.comboBoxPrinters.MaxDropDownItems = CType(resources.GetObject("comboBoxPrinters.MaxDropDownItems"),Integer)
		Me.comboBoxPrinters.MaxLength = CType(resources.GetObject("comboBoxPrinters.MaxLength"),Integer)
		Me.comboBoxPrinters.Name = "comboBoxPrinters"
		Me.comboBoxPrinters.RightToLeft = CType(resources.GetObject("comboBoxPrinters.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxPrinters.Size = CType(resources.GetObject("comboBoxPrinters.Size"),System.Drawing.Size)
		Me.comboBoxPrinters.TabIndex = CType(resources.GetObject("comboBoxPrinters.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.comboBoxPrinters, resources.GetString("comboBoxPrinters.ToolTip"))
		'
		'buttonGetDefaultPrinter
		'
		Me.buttonGetDefaultPrinter.AccessibleDescription = Nothing
		Me.buttonGetDefaultPrinter.AccessibleName = Nothing
		Me.buttonGetDefaultPrinter.Anchor = CType(resources.GetObject("buttonGetDefaultPrinter.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonGetDefaultPrinter.AutoSize = CType(resources.GetObject("buttonGetDefaultPrinter.AutoSize"),Boolean)
		Me.buttonGetDefaultPrinter.AutoSizeMode = CType(resources.GetObject("buttonGetDefaultPrinter.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonGetDefaultPrinter.BackgroundImage = Nothing
		Me.buttonGetDefaultPrinter.BackgroundImageLayout = CType(resources.GetObject("buttonGetDefaultPrinter.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonGetDefaultPrinter.Dock = CType(resources.GetObject("buttonGetDefaultPrinter.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonGetDefaultPrinter.FlatStyle = CType(resources.GetObject("buttonGetDefaultPrinter.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonGetDefaultPrinter.Font = CType(resources.GetObject("buttonGetDefaultPrinter.Font"),System.Drawing.Font)
		Me.buttonGetDefaultPrinter.Image = CType(resources.GetObject("buttonGetDefaultPrinter.Image"),System.Drawing.Image)
		Me.buttonGetDefaultPrinter.ImageAlign = CType(resources.GetObject("buttonGetDefaultPrinter.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonGetDefaultPrinter.ImageIndex = CType(resources.GetObject("buttonGetDefaultPrinter.ImageIndex"),Integer)
		Me.buttonGetDefaultPrinter.ImageKey = resources.GetString("buttonGetDefaultPrinter.ImageKey")
		Me.buttonGetDefaultPrinter.ImeMode = CType(resources.GetObject("buttonGetDefaultPrinter.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonGetDefaultPrinter.Location = CType(resources.GetObject("buttonGetDefaultPrinter.Location"),System.Drawing.Point)
		Me.buttonGetDefaultPrinter.Name = "buttonGetDefaultPrinter"
		Me.buttonGetDefaultPrinter.RightToLeft = CType(resources.GetObject("buttonGetDefaultPrinter.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonGetDefaultPrinter.Size = CType(resources.GetObject("buttonGetDefaultPrinter.Size"),System.Drawing.Size)
		Me.buttonGetDefaultPrinter.TabIndex = CType(resources.GetObject("buttonGetDefaultPrinter.TabIndex"),Integer)
		Me.buttonGetDefaultPrinter.Text = resources.GetString("buttonGetDefaultPrinter.Text")
		Me.buttonGetDefaultPrinter.TextAlign = CType(resources.GetObject("buttonGetDefaultPrinter.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonGetDefaultPrinter.TextImageRelation = CType(resources.GetObject("buttonGetDefaultPrinter.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonGetDefaultPrinter, resources.GetString("buttonGetDefaultPrinter.ToolTip"))
		Me.buttonGetDefaultPrinter.UseVisualStyleBackColor = true
		AddHandler Me.buttonGetDefaultPrinter.Click, AddressOf Me.ButtonGetDefaultPrinterClick
		'
		'tabPageRun
		'
		Me.tabPageRun.AccessibleDescription = Nothing
		Me.tabPageRun.AccessibleName = Nothing
		Me.tabPageRun.Anchor = CType(resources.GetObject("tabPageRun.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPageRun.AutoScroll = CType(resources.GetObject("tabPageRun.AutoScroll"),Boolean)
		Me.tabPageRun.BackgroundImage = Nothing
		Me.tabPageRun.BackgroundImageLayout = CType(resources.GetObject("tabPageRun.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPageRun.Controls.Add(Me.listViewRun)
		Me.tabPageRun.Controls.Add(Me.toolStripRun)
		Me.tabPageRun.Dock = CType(resources.GetObject("tabPageRun.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPageRun.Font = Nothing
		Me.tabPageRun.ImageIndex = CType(resources.GetObject("tabPageRun.ImageIndex"),Integer)
		Me.tabPageRun.ImageKey = resources.GetString("tabPageRun.ImageKey")
		Me.tabPageRun.ImeMode = CType(resources.GetObject("tabPageRun.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPageRun.Location = CType(resources.GetObject("tabPageRun.Location"),System.Drawing.Point)
		Me.tabPageRun.Name = "tabPageRun"
		Me.tabPageRun.RightToLeft = CType(resources.GetObject("tabPageRun.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPageRun.Size = CType(resources.GetObject("tabPageRun.Size"),System.Drawing.Size)
		Me.tabPageRun.TabIndex = CType(resources.GetObject("tabPageRun.TabIndex"),Integer)
		Me.tabPageRun.Text = resources.GetString("tabPageRun.Text")
		Me.toolTip1.SetToolTip(Me.tabPageRun, resources.GetString("tabPageRun.ToolTip"))
		Me.tabPageRun.ToolTipText = resources.GetString("tabPageRun.ToolTipText")
		Me.tabPageRun.UseVisualStyleBackColor = true
		'
		'listViewRun
		'
		Me.listViewRun.AccessibleDescription = Nothing
		Me.listViewRun.AccessibleName = Nothing
		Me.listViewRun.Alignment = CType(resources.GetObject("listViewRun.Alignment"),System.Windows.Forms.ListViewAlignment)
		Me.listViewRun.Anchor = CType(resources.GetObject("listViewRun.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.listViewRun.BackgroundImage = Nothing
		Me.listViewRun.BackgroundImageLayout = CType(resources.GetObject("listViewRun.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.listViewRun.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderRunPath, Me.columnHeaderRunArguments, Me.columnHeaderRunRun, Me.columnHeaderRunUsername, Me.columnHeaderRunPassword, Me.columnHeaderRunDomain})
		Me.listViewRun.Dock = CType(resources.GetObject("listViewRun.Dock"),System.Windows.Forms.DockStyle)
		Me.listViewRun.Font = Nothing
		Me.listViewRun.FullRowSelect = true
		Me.listViewRun.GridLines = true
		Me.listViewRun.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.listViewRun.HideSelection = false
		Me.listViewRun.ImeMode = CType(resources.GetObject("listViewRun.ImeMode"),System.Windows.Forms.ImeMode)
		Me.listViewRun.LabelWrap = CType(resources.GetObject("listViewRun.LabelWrap"),Boolean)
		Me.listViewRun.Location = CType(resources.GetObject("listViewRun.Location"),System.Drawing.Point)
		Me.listViewRun.MultiSelect = false
		Me.listViewRun.Name = "listViewRun"
		Me.listViewRun.RightToLeft = CType(resources.GetObject("listViewRun.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.listViewRun.RightToLeftLayout = CType(resources.GetObject("listViewRun.RightToLeftLayout"),Boolean)
		Me.listViewRun.Size = CType(resources.GetObject("listViewRun.Size"),System.Drawing.Size)
		Me.listViewRun.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.listViewRun.TabIndex = CType(resources.GetObject("listViewRun.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.listViewRun, resources.GetString("listViewRun.ToolTip"))
		Me.listViewRun.UseCompatibleStateImageBehavior = false
		Me.listViewRun.View = System.Windows.Forms.View.Details
		'
		'columnHeaderRunPath
		'
		Me.columnHeaderRunPath.Text = resources.GetString("columnHeaderRunPath.Text")
		Me.columnHeaderRunPath.TextAlign = CType(resources.GetObject("columnHeaderRunPath.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderRunPath.Width = CType(resources.GetObject("columnHeaderRunPath.Width"),Integer)
		'
		'columnHeaderRunArguments
		'
		Me.columnHeaderRunArguments.Text = resources.GetString("columnHeaderRunArguments.Text")
		Me.columnHeaderRunArguments.TextAlign = CType(resources.GetObject("columnHeaderRunArguments.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderRunArguments.Width = CType(resources.GetObject("columnHeaderRunArguments.Width"),Integer)
		'
		'columnHeaderRunRun
		'
		Me.columnHeaderRunRun.Text = resources.GetString("columnHeaderRunRun.Text")
		Me.columnHeaderRunRun.TextAlign = CType(resources.GetObject("columnHeaderRunRun.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderRunRun.Width = CType(resources.GetObject("columnHeaderRunRun.Width"),Integer)
		'
		'columnHeaderRunUsername
		'
		Me.columnHeaderRunUsername.Text = resources.GetString("columnHeaderRunUsername.Text")
		Me.columnHeaderRunUsername.TextAlign = CType(resources.GetObject("columnHeaderRunUsername.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderRunUsername.Width = CType(resources.GetObject("columnHeaderRunUsername.Width"),Integer)
		'
		'columnHeaderRunPassword
		'
		Me.columnHeaderRunPassword.Text = resources.GetString("columnHeaderRunPassword.Text")
		Me.columnHeaderRunPassword.TextAlign = CType(resources.GetObject("columnHeaderRunPassword.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderRunPassword.Width = CType(resources.GetObject("columnHeaderRunPassword.Width"),Integer)
		'
		'columnHeaderRunDomain
		'
		Me.columnHeaderRunDomain.Text = resources.GetString("columnHeaderRunDomain.Text")
		Me.columnHeaderRunDomain.TextAlign = CType(resources.GetObject("columnHeaderRunDomain.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.columnHeaderRunDomain.Width = CType(resources.GetObject("columnHeaderRunDomain.Width"),Integer)
		'
		'toolStripRun
		'
		Me.toolStripRun.AccessibleDescription = Nothing
		Me.toolStripRun.AccessibleName = Nothing
		Me.toolStripRun.Anchor = CType(resources.GetObject("toolStripRun.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.toolStripRun.AutoSize = CType(resources.GetObject("toolStripRun.AutoSize"),Boolean)
		Me.toolStripRun.BackgroundImage = Nothing
		Me.toolStripRun.BackgroundImageLayout = CType(resources.GetObject("toolStripRun.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripRun.Dock = CType(resources.GetObject("toolStripRun.Dock"),System.Windows.Forms.DockStyle)
		Me.toolStripRun.Font = Nothing
		Me.toolStripRun.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.toolStripRun.ImeMode = CType(resources.GetObject("toolStripRun.ImeMode"),System.Windows.Forms.ImeMode)
		Me.toolStripRun.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonAddProgram, Me.toolStripSeparator2, Me.toolStripButtonEditProgram, Me.toolStripButtonRemoveProgram})
		Me.toolStripRun.Location = CType(resources.GetObject("toolStripRun.Location"),System.Drawing.Point)
		Me.toolStripRun.Name = "toolStripRun"
		Me.toolStripRun.RightToLeft = CType(resources.GetObject("toolStripRun.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.toolStripRun.Size = CType(resources.GetObject("toolStripRun.Size"),System.Drawing.Size)
		Me.toolStripRun.TabIndex = CType(resources.GetObject("toolStripRun.TabIndex"),Integer)
		Me.toolStripRun.Text = resources.GetString("toolStripRun.Text")
		Me.toolTip1.SetToolTip(Me.toolStripRun, resources.GetString("toolStripRun.ToolTip"))
		'
		'toolStripButtonAddProgram
		'
		Me.toolStripButtonAddProgram.AccessibleDescription = Nothing
		Me.toolStripButtonAddProgram.AccessibleName = Nothing
		Me.toolStripButtonAddProgram.AutoSize = CType(resources.GetObject("toolStripButtonAddProgram.AutoSize"),Boolean)
		Me.toolStripButtonAddProgram.BackgroundImage = Nothing
		Me.toolStripButtonAddProgram.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonAddProgram.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonAddProgram.Enabled = CType(resources.GetObject("toolStripButtonAddProgram.Enabled"),Boolean)
		Me.toolStripButtonAddProgram.Image = CType(resources.GetObject("toolStripButtonAddProgram.Image"),System.Drawing.Image)
		Me.toolStripButtonAddProgram.ImageAlign = CType(resources.GetObject("toolStripButtonAddProgram.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonAddProgram.ImageScaling = CType(resources.GetObject("toolStripButtonAddProgram.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonAddProgram.ImageTransparentColor = CType(resources.GetObject("toolStripButtonAddProgram.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonAddProgram.Name = "toolStripButtonAddProgram"
		Me.toolStripButtonAddProgram.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonAddProgram.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonAddProgram.Size = CType(resources.GetObject("toolStripButtonAddProgram.Size"),System.Drawing.Size)
		Me.toolStripButtonAddProgram.Text = resources.GetString("toolStripButtonAddProgram.Text")
		Me.toolStripButtonAddProgram.TextAlign = CType(resources.GetObject("toolStripButtonAddProgram.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonAddProgram.TextImageRelation = CType(resources.GetObject("toolStripButtonAddProgram.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonAddProgram.Click, AddressOf Me.ToolStripButtonAddProgramClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.AccessibleDescription = Nothing
		Me.toolStripSeparator2.AccessibleName = Nothing
		Me.toolStripSeparator2.AutoSize = CType(resources.GetObject("toolStripSeparator2.AutoSize"),Boolean)
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = CType(resources.GetObject("toolStripSeparator2.Size"),System.Drawing.Size)
		'
		'toolStripButtonEditProgram
		'
		Me.toolStripButtonEditProgram.AccessibleDescription = Nothing
		Me.toolStripButtonEditProgram.AccessibleName = Nothing
		Me.toolStripButtonEditProgram.AutoSize = CType(resources.GetObject("toolStripButtonEditProgram.AutoSize"),Boolean)
		Me.toolStripButtonEditProgram.BackgroundImage = Nothing
		Me.toolStripButtonEditProgram.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonEditProgram.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonEditProgram.Enabled = CType(resources.GetObject("toolStripButtonEditProgram.Enabled"),Boolean)
		Me.toolStripButtonEditProgram.Image = CType(resources.GetObject("toolStripButtonEditProgram.Image"),System.Drawing.Image)
		Me.toolStripButtonEditProgram.ImageAlign = CType(resources.GetObject("toolStripButtonEditProgram.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonEditProgram.ImageScaling = CType(resources.GetObject("toolStripButtonEditProgram.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonEditProgram.ImageTransparentColor = CType(resources.GetObject("toolStripButtonEditProgram.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonEditProgram.Name = "toolStripButtonEditProgram"
		Me.toolStripButtonEditProgram.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonEditProgram.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonEditProgram.Size = CType(resources.GetObject("toolStripButtonEditProgram.Size"),System.Drawing.Size)
		Me.toolStripButtonEditProgram.Text = resources.GetString("toolStripButtonEditProgram.Text")
		Me.toolStripButtonEditProgram.TextAlign = CType(resources.GetObject("toolStripButtonEditProgram.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonEditProgram.TextImageRelation = CType(resources.GetObject("toolStripButtonEditProgram.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonEditProgram.Click, AddressOf Me.ToolStripButtonEditProgramClick
		'
		'toolStripButtonRemoveProgram
		'
		Me.toolStripButtonRemoveProgram.AccessibleDescription = Nothing
		Me.toolStripButtonRemoveProgram.AccessibleName = Nothing
		Me.toolStripButtonRemoveProgram.AutoSize = CType(resources.GetObject("toolStripButtonRemoveProgram.AutoSize"),Boolean)
		Me.toolStripButtonRemoveProgram.BackgroundImage = Nothing
		Me.toolStripButtonRemoveProgram.BackgroundImageLayout = CType(resources.GetObject("toolStripButtonRemoveProgram.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.toolStripButtonRemoveProgram.Enabled = CType(resources.GetObject("toolStripButtonRemoveProgram.Enabled"),Boolean)
		Me.toolStripButtonRemoveProgram.Image = CType(resources.GetObject("toolStripButtonRemoveProgram.Image"),System.Drawing.Image)
		Me.toolStripButtonRemoveProgram.ImageAlign = CType(resources.GetObject("toolStripButtonRemoveProgram.ImageAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonRemoveProgram.ImageScaling = CType(resources.GetObject("toolStripButtonRemoveProgram.ImageScaling"),System.Windows.Forms.ToolStripItemImageScaling)
		Me.toolStripButtonRemoveProgram.ImageTransparentColor = CType(resources.GetObject("toolStripButtonRemoveProgram.ImageTransparentColor"),System.Drawing.Color)
		Me.toolStripButtonRemoveProgram.Name = "toolStripButtonRemoveProgram"
		Me.toolStripButtonRemoveProgram.RightToLeftAutoMirrorImage = CType(resources.GetObject("toolStripButtonRemoveProgram.RightToLeftAutoMirrorImage"),Boolean)
		Me.toolStripButtonRemoveProgram.Size = CType(resources.GetObject("toolStripButtonRemoveProgram.Size"),System.Drawing.Size)
		Me.toolStripButtonRemoveProgram.Text = resources.GetString("toolStripButtonRemoveProgram.Text")
		Me.toolStripButtonRemoveProgram.TextAlign = CType(resources.GetObject("toolStripButtonRemoveProgram.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolStripButtonRemoveProgram.TextImageRelation = CType(resources.GetObject("toolStripButtonRemoveProgram.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		AddHandler Me.toolStripButtonRemoveProgram.Click, AddressOf Me.ToolStripButtonRemoveProgramClick
		'
		'tabPageDesktop
		'
		Me.tabPageDesktop.AccessibleDescription = Nothing
		Me.tabPageDesktop.AccessibleName = Nothing
		Me.tabPageDesktop.Anchor = CType(resources.GetObject("tabPageDesktop.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPageDesktop.AutoScroll = CType(resources.GetObject("tabPageDesktop.AutoScroll"),Boolean)
		Me.tabPageDesktop.BackgroundImage = Nothing
		Me.tabPageDesktop.BackgroundImageLayout = CType(resources.GetObject("tabPageDesktop.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPageDesktop.Controls.Add(Me.groupBoxDisplaySettings)
		Me.tabPageDesktop.Controls.Add(Me.groupBoxWallpaper)
		Me.tabPageDesktop.Dock = CType(resources.GetObject("tabPageDesktop.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPageDesktop.Font = Nothing
		Me.tabPageDesktop.ImageIndex = CType(resources.GetObject("tabPageDesktop.ImageIndex"),Integer)
		Me.tabPageDesktop.ImageKey = resources.GetString("tabPageDesktop.ImageKey")
		Me.tabPageDesktop.ImeMode = CType(resources.GetObject("tabPageDesktop.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPageDesktop.Location = CType(resources.GetObject("tabPageDesktop.Location"),System.Drawing.Point)
		Me.tabPageDesktop.Name = "tabPageDesktop"
		Me.tabPageDesktop.RightToLeft = CType(resources.GetObject("tabPageDesktop.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPageDesktop.Size = CType(resources.GetObject("tabPageDesktop.Size"),System.Drawing.Size)
		Me.tabPageDesktop.TabIndex = CType(resources.GetObject("tabPageDesktop.TabIndex"),Integer)
		Me.tabPageDesktop.Text = resources.GetString("tabPageDesktop.Text")
		Me.toolTip1.SetToolTip(Me.tabPageDesktop, resources.GetString("tabPageDesktop.ToolTip"))
		Me.tabPageDesktop.ToolTipText = resources.GetString("tabPageDesktop.ToolTipText")
		Me.tabPageDesktop.UseVisualStyleBackColor = true
		'
		'groupBoxDisplaySettings
		'
		Me.groupBoxDisplaySettings.AccessibleDescription = Nothing
		Me.groupBoxDisplaySettings.AccessibleName = Nothing
		Me.groupBoxDisplaySettings.Anchor = CType(resources.GetObject("groupBoxDisplaySettings.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxDisplaySettings.AutoSize = CType(resources.GetObject("groupBoxDisplaySettings.AutoSize"),Boolean)
		Me.groupBoxDisplaySettings.AutoSizeMode = CType(resources.GetObject("groupBoxDisplaySettings.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxDisplaySettings.BackgroundImage = Nothing
		Me.groupBoxDisplaySettings.BackgroundImageLayout = CType(resources.GetObject("groupBoxDisplaySettings.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxDisplaySettings.Controls.Add(Me.labelColorQuality)
		Me.groupBoxDisplaySettings.Controls.Add(Me.labelScreenResolution)
		Me.groupBoxDisplaySettings.Controls.Add(Me.buttonGetCurrentDisplaySettings)
		Me.groupBoxDisplaySettings.Controls.Add(Me.comboBoxDisplayColors)
		Me.groupBoxDisplaySettings.Controls.Add(Me.comboBoxDisplaySettings)
		Me.groupBoxDisplaySettings.Dock = CType(resources.GetObject("groupBoxDisplaySettings.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxDisplaySettings.Font = CType(resources.GetObject("groupBoxDisplaySettings.Font"),System.Drawing.Font)
		Me.groupBoxDisplaySettings.ImeMode = CType(resources.GetObject("groupBoxDisplaySettings.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxDisplaySettings.Location = CType(resources.GetObject("groupBoxDisplaySettings.Location"),System.Drawing.Point)
		Me.groupBoxDisplaySettings.Name = "groupBoxDisplaySettings"
		Me.groupBoxDisplaySettings.RightToLeft = CType(resources.GetObject("groupBoxDisplaySettings.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxDisplaySettings.Size = CType(resources.GetObject("groupBoxDisplaySettings.Size"),System.Drawing.Size)
		Me.groupBoxDisplaySettings.TabIndex = CType(resources.GetObject("groupBoxDisplaySettings.TabIndex"),Integer)
		Me.groupBoxDisplaySettings.TabStop = false
		Me.groupBoxDisplaySettings.Text = resources.GetString("groupBoxDisplaySettings.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxDisplaySettings, resources.GetString("groupBoxDisplaySettings.ToolTip"))
		'
		'labelColorQuality
		'
		Me.labelColorQuality.AccessibleDescription = Nothing
		Me.labelColorQuality.AccessibleName = Nothing
		Me.labelColorQuality.Anchor = CType(resources.GetObject("labelColorQuality.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelColorQuality.AutoSize = CType(resources.GetObject("labelColorQuality.AutoSize"),Boolean)
		Me.labelColorQuality.BackgroundImageLayout = CType(resources.GetObject("labelColorQuality.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelColorQuality.Dock = CType(resources.GetObject("labelColorQuality.Dock"),System.Windows.Forms.DockStyle)
		Me.labelColorQuality.Font = CType(resources.GetObject("labelColorQuality.Font"),System.Drawing.Font)
		Me.labelColorQuality.ImageAlign = CType(resources.GetObject("labelColorQuality.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelColorQuality.ImageIndex = CType(resources.GetObject("labelColorQuality.ImageIndex"),Integer)
		Me.labelColorQuality.ImageKey = resources.GetString("labelColorQuality.ImageKey")
		Me.labelColorQuality.ImeMode = CType(resources.GetObject("labelColorQuality.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelColorQuality.Location = CType(resources.GetObject("labelColorQuality.Location"),System.Drawing.Point)
		Me.labelColorQuality.Name = "labelColorQuality"
		Me.labelColorQuality.RightToLeft = CType(resources.GetObject("labelColorQuality.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelColorQuality.Size = CType(resources.GetObject("labelColorQuality.Size"),System.Drawing.Size)
		Me.labelColorQuality.TabIndex = CType(resources.GetObject("labelColorQuality.TabIndex"),Integer)
		Me.labelColorQuality.Text = resources.GetString("labelColorQuality.Text")
		Me.labelColorQuality.TextAlign = CType(resources.GetObject("labelColorQuality.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelColorQuality, resources.GetString("labelColorQuality.ToolTip"))
		'
		'labelScreenResolution
		'
		Me.labelScreenResolution.AccessibleDescription = Nothing
		Me.labelScreenResolution.AccessibleName = Nothing
		Me.labelScreenResolution.Anchor = CType(resources.GetObject("labelScreenResolution.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelScreenResolution.AutoSize = CType(resources.GetObject("labelScreenResolution.AutoSize"),Boolean)
		Me.labelScreenResolution.BackgroundImageLayout = CType(resources.GetObject("labelScreenResolution.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelScreenResolution.Dock = CType(resources.GetObject("labelScreenResolution.Dock"),System.Windows.Forms.DockStyle)
		Me.labelScreenResolution.Font = CType(resources.GetObject("labelScreenResolution.Font"),System.Drawing.Font)
		Me.labelScreenResolution.ImageAlign = CType(resources.GetObject("labelScreenResolution.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelScreenResolution.ImageIndex = CType(resources.GetObject("labelScreenResolution.ImageIndex"),Integer)
		Me.labelScreenResolution.ImageKey = resources.GetString("labelScreenResolution.ImageKey")
		Me.labelScreenResolution.ImeMode = CType(resources.GetObject("labelScreenResolution.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelScreenResolution.Location = CType(resources.GetObject("labelScreenResolution.Location"),System.Drawing.Point)
		Me.labelScreenResolution.Name = "labelScreenResolution"
		Me.labelScreenResolution.RightToLeft = CType(resources.GetObject("labelScreenResolution.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelScreenResolution.Size = CType(resources.GetObject("labelScreenResolution.Size"),System.Drawing.Size)
		Me.labelScreenResolution.TabIndex = CType(resources.GetObject("labelScreenResolution.TabIndex"),Integer)
		Me.labelScreenResolution.Text = resources.GetString("labelScreenResolution.Text")
		Me.labelScreenResolution.TextAlign = CType(resources.GetObject("labelScreenResolution.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelScreenResolution, resources.GetString("labelScreenResolution.ToolTip"))
		'
		'buttonGetCurrentDisplaySettings
		'
		Me.buttonGetCurrentDisplaySettings.AccessibleDescription = Nothing
		Me.buttonGetCurrentDisplaySettings.AccessibleName = Nothing
		Me.buttonGetCurrentDisplaySettings.Anchor = CType(resources.GetObject("buttonGetCurrentDisplaySettings.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonGetCurrentDisplaySettings.AutoEllipsis = true
		Me.buttonGetCurrentDisplaySettings.AutoSize = CType(resources.GetObject("buttonGetCurrentDisplaySettings.AutoSize"),Boolean)
		Me.buttonGetCurrentDisplaySettings.AutoSizeMode = CType(resources.GetObject("buttonGetCurrentDisplaySettings.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonGetCurrentDisplaySettings.BackgroundImage = Nothing
		Me.buttonGetCurrentDisplaySettings.BackgroundImageLayout = CType(resources.GetObject("buttonGetCurrentDisplaySettings.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonGetCurrentDisplaySettings.Dock = CType(resources.GetObject("buttonGetCurrentDisplaySettings.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonGetCurrentDisplaySettings.FlatStyle = CType(resources.GetObject("buttonGetCurrentDisplaySettings.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonGetCurrentDisplaySettings.Font = CType(resources.GetObject("buttonGetCurrentDisplaySettings.Font"),System.Drawing.Font)
		Me.buttonGetCurrentDisplaySettings.Image = CType(resources.GetObject("buttonGetCurrentDisplaySettings.Image"),System.Drawing.Image)
		Me.buttonGetCurrentDisplaySettings.ImageAlign = CType(resources.GetObject("buttonGetCurrentDisplaySettings.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonGetCurrentDisplaySettings.ImageIndex = CType(resources.GetObject("buttonGetCurrentDisplaySettings.ImageIndex"),Integer)
		Me.buttonGetCurrentDisplaySettings.ImageKey = resources.GetString("buttonGetCurrentDisplaySettings.ImageKey")
		Me.buttonGetCurrentDisplaySettings.ImeMode = CType(resources.GetObject("buttonGetCurrentDisplaySettings.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonGetCurrentDisplaySettings.Location = CType(resources.GetObject("buttonGetCurrentDisplaySettings.Location"),System.Drawing.Point)
		Me.buttonGetCurrentDisplaySettings.Name = "buttonGetCurrentDisplaySettings"
		Me.buttonGetCurrentDisplaySettings.RightToLeft = CType(resources.GetObject("buttonGetCurrentDisplaySettings.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonGetCurrentDisplaySettings.Size = CType(resources.GetObject("buttonGetCurrentDisplaySettings.Size"),System.Drawing.Size)
		Me.buttonGetCurrentDisplaySettings.TabIndex = CType(resources.GetObject("buttonGetCurrentDisplaySettings.TabIndex"),Integer)
		Me.buttonGetCurrentDisplaySettings.Text = resources.GetString("buttonGetCurrentDisplaySettings.Text")
		Me.buttonGetCurrentDisplaySettings.TextAlign = CType(resources.GetObject("buttonGetCurrentDisplaySettings.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonGetCurrentDisplaySettings.TextImageRelation = CType(resources.GetObject("buttonGetCurrentDisplaySettings.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonGetCurrentDisplaySettings, resources.GetString("buttonGetCurrentDisplaySettings.ToolTip"))
		Me.buttonGetCurrentDisplaySettings.UseVisualStyleBackColor = true
		AddHandler Me.buttonGetCurrentDisplaySettings.Click, AddressOf Me.ButtonGetCurrentDisplaySettingsClick
		'
		'comboBoxDisplayColors
		'
		Me.comboBoxDisplayColors.AccessibleDescription = Nothing
		Me.comboBoxDisplayColors.AccessibleName = Nothing
		Me.comboBoxDisplayColors.Anchor = CType(resources.GetObject("comboBoxDisplayColors.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxDisplayColors.BackgroundImage = Nothing
		Me.comboBoxDisplayColors.BackgroundImageLayout = CType(resources.GetObject("comboBoxDisplayColors.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxDisplayColors.Dock = CType(resources.GetObject("comboBoxDisplayColors.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxDisplayColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxDisplayColors.FlatStyle = CType(resources.GetObject("comboBoxDisplayColors.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxDisplayColors.Font = CType(resources.GetObject("comboBoxDisplayColors.Font"),System.Drawing.Font)
		Me.comboBoxDisplayColors.FormattingEnabled = true
		Me.comboBoxDisplayColors.ImeMode = CType(resources.GetObject("comboBoxDisplayColors.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxDisplayColors.IntegralHeight = CType(resources.GetObject("comboBoxDisplayColors.IntegralHeight"),Boolean)
		Me.comboBoxDisplayColors.Location = CType(resources.GetObject("comboBoxDisplayColors.Location"),System.Drawing.Point)
		Me.comboBoxDisplayColors.MaxDropDownItems = CType(resources.GetObject("comboBoxDisplayColors.MaxDropDownItems"),Integer)
		Me.comboBoxDisplayColors.MaxLength = CType(resources.GetObject("comboBoxDisplayColors.MaxLength"),Integer)
		Me.comboBoxDisplayColors.Name = "comboBoxDisplayColors"
		Me.comboBoxDisplayColors.RightToLeft = CType(resources.GetObject("comboBoxDisplayColors.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxDisplayColors.Size = CType(resources.GetObject("comboBoxDisplayColors.Size"),System.Drawing.Size)
		Me.comboBoxDisplayColors.TabIndex = CType(resources.GetObject("comboBoxDisplayColors.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.comboBoxDisplayColors, resources.GetString("comboBoxDisplayColors.ToolTip"))
		'
		'comboBoxDisplaySettings
		'
		Me.comboBoxDisplaySettings.AccessibleDescription = Nothing
		Me.comboBoxDisplaySettings.AccessibleName = Nothing
		Me.comboBoxDisplaySettings.Anchor = CType(resources.GetObject("comboBoxDisplaySettings.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxDisplaySettings.BackgroundImage = Nothing
		Me.comboBoxDisplaySettings.BackgroundImageLayout = CType(resources.GetObject("comboBoxDisplaySettings.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxDisplaySettings.Dock = CType(resources.GetObject("comboBoxDisplaySettings.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxDisplaySettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxDisplaySettings.FlatStyle = CType(resources.GetObject("comboBoxDisplaySettings.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxDisplaySettings.Font = CType(resources.GetObject("comboBoxDisplaySettings.Font"),System.Drawing.Font)
		Me.comboBoxDisplaySettings.FormattingEnabled = true
		Me.comboBoxDisplaySettings.ImeMode = CType(resources.GetObject("comboBoxDisplaySettings.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxDisplaySettings.IntegralHeight = CType(resources.GetObject("comboBoxDisplaySettings.IntegralHeight"),Boolean)
		Me.comboBoxDisplaySettings.Location = CType(resources.GetObject("comboBoxDisplaySettings.Location"),System.Drawing.Point)
		Me.comboBoxDisplaySettings.MaxDropDownItems = CType(resources.GetObject("comboBoxDisplaySettings.MaxDropDownItems"),Integer)
		Me.comboBoxDisplaySettings.MaxLength = CType(resources.GetObject("comboBoxDisplaySettings.MaxLength"),Integer)
		Me.comboBoxDisplaySettings.Name = "comboBoxDisplaySettings"
		Me.comboBoxDisplaySettings.RightToLeft = CType(resources.GetObject("comboBoxDisplaySettings.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxDisplaySettings.Size = CType(resources.GetObject("comboBoxDisplaySettings.Size"),System.Drawing.Size)
		Me.comboBoxDisplaySettings.TabIndex = CType(resources.GetObject("comboBoxDisplaySettings.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.comboBoxDisplaySettings, resources.GetString("comboBoxDisplaySettings.ToolTip"))
		'
		'groupBoxWallpaper
		'
		Me.groupBoxWallpaper.AccessibleDescription = Nothing
		Me.groupBoxWallpaper.AccessibleName = Nothing
		Me.groupBoxWallpaper.Anchor = CType(resources.GetObject("groupBoxWallpaper.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxWallpaper.AutoSize = CType(resources.GetObject("groupBoxWallpaper.AutoSize"),Boolean)
		Me.groupBoxWallpaper.AutoSizeMode = CType(resources.GetObject("groupBoxWallpaper.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxWallpaper.BackgroundImage = Nothing
		Me.groupBoxWallpaper.BackgroundImageLayout = CType(resources.GetObject("groupBoxWallpaper.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxWallpaper.Controls.Add(Me.groupBoxWallpaperPreview)
		Me.groupBoxWallpaper.Controls.Add(Me.buttonResetWallpaper)
		Me.groupBoxWallpaper.Controls.Add(Me.buttonBrowseWallpaper)
		Me.groupBoxWallpaper.Controls.Add(Me.textBoxWallpaperPath)
		Me.groupBoxWallpaper.Dock = CType(resources.GetObject("groupBoxWallpaper.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxWallpaper.Font = CType(resources.GetObject("groupBoxWallpaper.Font"),System.Drawing.Font)
		Me.groupBoxWallpaper.ImeMode = CType(resources.GetObject("groupBoxWallpaper.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxWallpaper.Location = CType(resources.GetObject("groupBoxWallpaper.Location"),System.Drawing.Point)
		Me.groupBoxWallpaper.Name = "groupBoxWallpaper"
		Me.groupBoxWallpaper.RightToLeft = CType(resources.GetObject("groupBoxWallpaper.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxWallpaper.Size = CType(resources.GetObject("groupBoxWallpaper.Size"),System.Drawing.Size)
		Me.groupBoxWallpaper.TabIndex = CType(resources.GetObject("groupBoxWallpaper.TabIndex"),Integer)
		Me.groupBoxWallpaper.TabStop = false
		Me.groupBoxWallpaper.Text = resources.GetString("groupBoxWallpaper.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxWallpaper, resources.GetString("groupBoxWallpaper.ToolTip"))
		'
		'groupBoxWallpaperPreview
		'
		Me.groupBoxWallpaperPreview.AccessibleDescription = Nothing
		Me.groupBoxWallpaperPreview.AccessibleName = Nothing
		Me.groupBoxWallpaperPreview.Anchor = CType(resources.GetObject("groupBoxWallpaperPreview.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxWallpaperPreview.AutoSize = CType(resources.GetObject("groupBoxWallpaperPreview.AutoSize"),Boolean)
		Me.groupBoxWallpaperPreview.AutoSizeMode = CType(resources.GetObject("groupBoxWallpaperPreview.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxWallpaperPreview.BackgroundImage = Nothing
		Me.groupBoxWallpaperPreview.BackgroundImageLayout = CType(resources.GetObject("groupBoxWallpaperPreview.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxWallpaperPreview.Controls.Add(Me.pictureBoxWallpaperPreview)
		Me.groupBoxWallpaperPreview.Dock = CType(resources.GetObject("groupBoxWallpaperPreview.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxWallpaperPreview.Font = Nothing
		Me.groupBoxWallpaperPreview.ImeMode = CType(resources.GetObject("groupBoxWallpaperPreview.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxWallpaperPreview.Location = CType(resources.GetObject("groupBoxWallpaperPreview.Location"),System.Drawing.Point)
		Me.groupBoxWallpaperPreview.Name = "groupBoxWallpaperPreview"
		Me.groupBoxWallpaperPreview.RightToLeft = CType(resources.GetObject("groupBoxWallpaperPreview.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxWallpaperPreview.Size = CType(resources.GetObject("groupBoxWallpaperPreview.Size"),System.Drawing.Size)
		Me.groupBoxWallpaperPreview.TabIndex = CType(resources.GetObject("groupBoxWallpaperPreview.TabIndex"),Integer)
		Me.groupBoxWallpaperPreview.TabStop = false
		Me.groupBoxWallpaperPreview.Text = resources.GetString("groupBoxWallpaperPreview.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxWallpaperPreview, resources.GetString("groupBoxWallpaperPreview.ToolTip"))
		'
		'pictureBoxWallpaperPreview
		'
		Me.pictureBoxWallpaperPreview.AccessibleDescription = Nothing
		Me.pictureBoxWallpaperPreview.AccessibleName = Nothing
		Me.pictureBoxWallpaperPreview.Anchor = CType(resources.GetObject("pictureBoxWallpaperPreview.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxWallpaperPreview.BackgroundImage = Nothing
		Me.pictureBoxWallpaperPreview.BackgroundImageLayout = CType(resources.GetObject("pictureBoxWallpaperPreview.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBoxWallpaperPreview.Dock = CType(resources.GetObject("pictureBoxWallpaperPreview.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBoxWallpaperPreview.Font = Nothing
		Me.pictureBoxWallpaperPreview.ImageLocation = Nothing
		Me.pictureBoxWallpaperPreview.ImeMode = CType(resources.GetObject("pictureBoxWallpaperPreview.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBoxWallpaperPreview.Location = CType(resources.GetObject("pictureBoxWallpaperPreview.Location"),System.Drawing.Point)
		Me.pictureBoxWallpaperPreview.Name = "pictureBoxWallpaperPreview"
		Me.pictureBoxWallpaperPreview.RightToLeft = CType(resources.GetObject("pictureBoxWallpaperPreview.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBoxWallpaperPreview.Size = CType(resources.GetObject("pictureBoxWallpaperPreview.Size"),System.Drawing.Size)
		Me.pictureBoxWallpaperPreview.SizeMode = CType(resources.GetObject("pictureBoxWallpaperPreview.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBoxWallpaperPreview.TabIndex = CType(resources.GetObject("pictureBoxWallpaperPreview.TabIndex"),Integer)
		Me.pictureBoxWallpaperPreview.TabStop = false
		Me.toolTip1.SetToolTip(Me.pictureBoxWallpaperPreview, resources.GetString("pictureBoxWallpaperPreview.ToolTip"))
		Me.pictureBoxWallpaperPreview.WaitOnLoad = CType(resources.GetObject("pictureBoxWallpaperPreview.WaitOnLoad"),Boolean)
		'
		'buttonResetWallpaper
		'
		Me.buttonResetWallpaper.AccessibleDescription = Nothing
		Me.buttonResetWallpaper.AccessibleName = Nothing
		Me.buttonResetWallpaper.Anchor = CType(resources.GetObject("buttonResetWallpaper.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonResetWallpaper.AutoSize = CType(resources.GetObject("buttonResetWallpaper.AutoSize"),Boolean)
		Me.buttonResetWallpaper.AutoSizeMode = CType(resources.GetObject("buttonResetWallpaper.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonResetWallpaper.BackgroundImage = Nothing
		Me.buttonResetWallpaper.BackgroundImageLayout = CType(resources.GetObject("buttonResetWallpaper.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonResetWallpaper.Dock = CType(resources.GetObject("buttonResetWallpaper.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonResetWallpaper.FlatStyle = CType(resources.GetObject("buttonResetWallpaper.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonResetWallpaper.Font = Nothing
		Me.buttonResetWallpaper.Image = CType(resources.GetObject("buttonResetWallpaper.Image"),System.Drawing.Image)
		Me.buttonResetWallpaper.ImageAlign = CType(resources.GetObject("buttonResetWallpaper.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonResetWallpaper.ImageIndex = CType(resources.GetObject("buttonResetWallpaper.ImageIndex"),Integer)
		Me.buttonResetWallpaper.ImageKey = resources.GetString("buttonResetWallpaper.ImageKey")
		Me.buttonResetWallpaper.ImeMode = CType(resources.GetObject("buttonResetWallpaper.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonResetWallpaper.Location = CType(resources.GetObject("buttonResetWallpaper.Location"),System.Drawing.Point)
		Me.buttonResetWallpaper.Name = "buttonResetWallpaper"
		Me.buttonResetWallpaper.RightToLeft = CType(resources.GetObject("buttonResetWallpaper.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonResetWallpaper.Size = CType(resources.GetObject("buttonResetWallpaper.Size"),System.Drawing.Size)
		Me.buttonResetWallpaper.TabIndex = CType(resources.GetObject("buttonResetWallpaper.TabIndex"),Integer)
		Me.buttonResetWallpaper.TextAlign = CType(resources.GetObject("buttonResetWallpaper.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonResetWallpaper.TextImageRelation = CType(resources.GetObject("buttonResetWallpaper.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonResetWallpaper, resources.GetString("buttonResetWallpaper.ToolTip"))
		Me.buttonResetWallpaper.UseVisualStyleBackColor = true
		AddHandler Me.buttonResetWallpaper.Click, AddressOf Me.ButtonResetWallpaperClick
		'
		'buttonBrowseWallpaper
		'
		Me.buttonBrowseWallpaper.AccessibleDescription = Nothing
		Me.buttonBrowseWallpaper.AccessibleName = Nothing
		Me.buttonBrowseWallpaper.Anchor = CType(resources.GetObject("buttonBrowseWallpaper.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonBrowseWallpaper.AutoSize = CType(resources.GetObject("buttonBrowseWallpaper.AutoSize"),Boolean)
		Me.buttonBrowseWallpaper.AutoSizeMode = CType(resources.GetObject("buttonBrowseWallpaper.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonBrowseWallpaper.BackgroundImage = Nothing
		Me.buttonBrowseWallpaper.BackgroundImageLayout = CType(resources.GetObject("buttonBrowseWallpaper.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonBrowseWallpaper.Dock = CType(resources.GetObject("buttonBrowseWallpaper.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonBrowseWallpaper.FlatStyle = CType(resources.GetObject("buttonBrowseWallpaper.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonBrowseWallpaper.Font = Nothing
		Me.buttonBrowseWallpaper.Image = CType(resources.GetObject("buttonBrowseWallpaper.Image"),System.Drawing.Image)
		Me.buttonBrowseWallpaper.ImageAlign = CType(resources.GetObject("buttonBrowseWallpaper.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonBrowseWallpaper.ImageIndex = CType(resources.GetObject("buttonBrowseWallpaper.ImageIndex"),Integer)
		Me.buttonBrowseWallpaper.ImageKey = resources.GetString("buttonBrowseWallpaper.ImageKey")
		Me.buttonBrowseWallpaper.ImeMode = CType(resources.GetObject("buttonBrowseWallpaper.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonBrowseWallpaper.Location = CType(resources.GetObject("buttonBrowseWallpaper.Location"),System.Drawing.Point)
		Me.buttonBrowseWallpaper.Name = "buttonBrowseWallpaper"
		Me.buttonBrowseWallpaper.RightToLeft = CType(resources.GetObject("buttonBrowseWallpaper.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonBrowseWallpaper.Size = CType(resources.GetObject("buttonBrowseWallpaper.Size"),System.Drawing.Size)
		Me.buttonBrowseWallpaper.TabIndex = CType(resources.GetObject("buttonBrowseWallpaper.TabIndex"),Integer)
		Me.buttonBrowseWallpaper.TextAlign = CType(resources.GetObject("buttonBrowseWallpaper.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonBrowseWallpaper.TextImageRelation = CType(resources.GetObject("buttonBrowseWallpaper.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonBrowseWallpaper, resources.GetString("buttonBrowseWallpaper.ToolTip"))
		Me.buttonBrowseWallpaper.UseVisualStyleBackColor = true
		AddHandler Me.buttonBrowseWallpaper.Click, AddressOf Me.ButtonBrowseWallpaperClick
		'
		'textBoxWallpaperPath
		'
		Me.textBoxWallpaperPath.AccessibleDescription = Nothing
		Me.textBoxWallpaperPath.AccessibleName = Nothing
		Me.textBoxWallpaperPath.Anchor = CType(resources.GetObject("textBoxWallpaperPath.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxWallpaperPath.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWallpaperPath.BackgroundImage = Nothing
		Me.textBoxWallpaperPath.BackgroundImageLayout = CType(resources.GetObject("textBoxWallpaperPath.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxWallpaperPath.Dock = CType(resources.GetObject("textBoxWallpaperPath.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxWallpaperPath.Font = CType(resources.GetObject("textBoxWallpaperPath.Font"),System.Drawing.Font)
		Me.textBoxWallpaperPath.ImeMode = CType(resources.GetObject("textBoxWallpaperPath.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxWallpaperPath.Location = CType(resources.GetObject("textBoxWallpaperPath.Location"),System.Drawing.Point)
		Me.textBoxWallpaperPath.MaxLength = CType(resources.GetObject("textBoxWallpaperPath.MaxLength"),Integer)
		Me.textBoxWallpaperPath.Multiline = CType(resources.GetObject("textBoxWallpaperPath.Multiline"),Boolean)
		Me.textBoxWallpaperPath.Name = "textBoxWallpaperPath"
		Me.textBoxWallpaperPath.PasswordChar = CType(resources.GetObject("textBoxWallpaperPath.PasswordChar"),Char)
		Me.textBoxWallpaperPath.ReadOnly = true
		Me.textBoxWallpaperPath.RightToLeft = CType(resources.GetObject("textBoxWallpaperPath.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxWallpaperPath.ScrollBars = CType(resources.GetObject("textBoxWallpaperPath.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxWallpaperPath.Size = CType(resources.GetObject("textBoxWallpaperPath.Size"),System.Drawing.Size)
		Me.textBoxWallpaperPath.TabIndex = CType(resources.GetObject("textBoxWallpaperPath.TabIndex"),Integer)
		Me.textBoxWallpaperPath.TextAlign = CType(resources.GetObject("textBoxWallpaperPath.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxWallpaperPath, resources.GetString("textBoxWallpaperPath.ToolTip"))
		Me.textBoxWallpaperPath.WordWrap = CType(resources.GetObject("textBoxWallpaperPath.WordWrap"),Boolean)
		'
		'tabPageWireless
		'
		Me.tabPageWireless.AccessibleDescription = Nothing
		Me.tabPageWireless.AccessibleName = Nothing
		Me.tabPageWireless.Anchor = CType(resources.GetObject("tabPageWireless.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.tabPageWireless.AutoScroll = CType(resources.GetObject("tabPageWireless.AutoScroll"),Boolean)
		Me.tabPageWireless.BackgroundImage = Nothing
		Me.tabPageWireless.BackgroundImageLayout = CType(resources.GetObject("tabPageWireless.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.tabPageWireless.Controls.Add(Me.labelWirelessVista)
		Me.tabPageWireless.Controls.Add(Me.groupBoxWireless)
		Me.tabPageWireless.Dock = CType(resources.GetObject("tabPageWireless.Dock"),System.Windows.Forms.DockStyle)
		Me.tabPageWireless.Font = Nothing
		Me.tabPageWireless.ImageIndex = CType(resources.GetObject("tabPageWireless.ImageIndex"),Integer)
		Me.tabPageWireless.ImageKey = resources.GetString("tabPageWireless.ImageKey")
		Me.tabPageWireless.ImeMode = CType(resources.GetObject("tabPageWireless.ImeMode"),System.Windows.Forms.ImeMode)
		Me.tabPageWireless.Location = CType(resources.GetObject("tabPageWireless.Location"),System.Drawing.Point)
		Me.tabPageWireless.Name = "tabPageWireless"
		Me.tabPageWireless.RightToLeft = CType(resources.GetObject("tabPageWireless.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.tabPageWireless.Size = CType(resources.GetObject("tabPageWireless.Size"),System.Drawing.Size)
		Me.tabPageWireless.TabIndex = CType(resources.GetObject("tabPageWireless.TabIndex"),Integer)
		Me.tabPageWireless.Text = resources.GetString("tabPageWireless.Text")
		Me.toolTip1.SetToolTip(Me.tabPageWireless, resources.GetString("tabPageWireless.ToolTip"))
		Me.tabPageWireless.ToolTipText = resources.GetString("tabPageWireless.ToolTipText")
		Me.tabPageWireless.UseVisualStyleBackColor = true
		'
		'labelWirelessVista
		'
		Me.labelWirelessVista.AccessibleDescription = Nothing
		Me.labelWirelessVista.AccessibleName = Nothing
		Me.labelWirelessVista.Anchor = CType(resources.GetObject("labelWirelessVista.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelWirelessVista.AutoSize = CType(resources.GetObject("labelWirelessVista.AutoSize"),Boolean)
		Me.labelWirelessVista.BackgroundImageLayout = CType(resources.GetObject("labelWirelessVista.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelWirelessVista.Dock = CType(resources.GetObject("labelWirelessVista.Dock"),System.Windows.Forms.DockStyle)
		Me.labelWirelessVista.Font = Nothing
		Me.labelWirelessVista.ImageAlign = CType(resources.GetObject("labelWirelessVista.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelWirelessVista.ImageIndex = CType(resources.GetObject("labelWirelessVista.ImageIndex"),Integer)
		Me.labelWirelessVista.ImageKey = resources.GetString("labelWirelessVista.ImageKey")
		Me.labelWirelessVista.ImeMode = CType(resources.GetObject("labelWirelessVista.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelWirelessVista.Location = CType(resources.GetObject("labelWirelessVista.Location"),System.Drawing.Point)
		Me.labelWirelessVista.Name = "labelWirelessVista"
		Me.labelWirelessVista.RightToLeft = CType(resources.GetObject("labelWirelessVista.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelWirelessVista.Size = CType(resources.GetObject("labelWirelessVista.Size"),System.Drawing.Size)
		Me.labelWirelessVista.TabIndex = CType(resources.GetObject("labelWirelessVista.TabIndex"),Integer)
		Me.labelWirelessVista.Text = resources.GetString("labelWirelessVista.Text")
		Me.labelWirelessVista.TextAlign = CType(resources.GetObject("labelWirelessVista.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelWirelessVista, resources.GetString("labelWirelessVista.ToolTip"))
		Me.labelWirelessVista.Visible = CType(resources.GetObject("labelWirelessVista.Visible"),Boolean)
		'
		'groupBoxWireless
		'
		Me.groupBoxWireless.AccessibleDescription = Nothing
		Me.groupBoxWireless.AccessibleName = Nothing
		Me.groupBoxWireless.Anchor = CType(resources.GetObject("groupBoxWireless.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxWireless.AutoSize = CType(resources.GetObject("groupBoxWireless.AutoSize"),Boolean)
		Me.groupBoxWireless.AutoSizeMode = CType(resources.GetObject("groupBoxWireless.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxWireless.BackgroundImage = Nothing
		Me.groupBoxWireless.BackgroundImageLayout = CType(resources.GetObject("groupBoxWireless.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxWireless.Controls.Add(Me.labelSSID)
		Me.groupBoxWireless.Controls.Add(Me.labelSSIDNotes)
		Me.groupBoxWireless.Controls.Add(Me.textBoxAutoActivateSSID)
		Me.groupBoxWireless.Dock = CType(resources.GetObject("groupBoxWireless.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxWireless.Font = CType(resources.GetObject("groupBoxWireless.Font"),System.Drawing.Font)
		Me.groupBoxWireless.ImeMode = CType(resources.GetObject("groupBoxWireless.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxWireless.Location = CType(resources.GetObject("groupBoxWireless.Location"),System.Drawing.Point)
		Me.groupBoxWireless.Name = "groupBoxWireless"
		Me.groupBoxWireless.RightToLeft = CType(resources.GetObject("groupBoxWireless.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxWireless.Size = CType(resources.GetObject("groupBoxWireless.Size"),System.Drawing.Size)
		Me.groupBoxWireless.TabIndex = CType(resources.GetObject("groupBoxWireless.TabIndex"),Integer)
		Me.groupBoxWireless.TabStop = false
		Me.groupBoxWireless.Text = resources.GetString("groupBoxWireless.Text")
		Me.toolTip1.SetToolTip(Me.groupBoxWireless, resources.GetString("groupBoxWireless.ToolTip"))
		'
		'labelSSID
		'
		Me.labelSSID.AccessibleDescription = Nothing
		Me.labelSSID.AccessibleName = Nothing
		Me.labelSSID.Anchor = CType(resources.GetObject("labelSSID.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelSSID.AutoSize = CType(resources.GetObject("labelSSID.AutoSize"),Boolean)
		Me.labelSSID.BackgroundImageLayout = CType(resources.GetObject("labelSSID.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelSSID.Dock = CType(resources.GetObject("labelSSID.Dock"),System.Windows.Forms.DockStyle)
		Me.labelSSID.Font = CType(resources.GetObject("labelSSID.Font"),System.Drawing.Font)
		Me.labelSSID.ImageAlign = CType(resources.GetObject("labelSSID.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelSSID.ImageIndex = CType(resources.GetObject("labelSSID.ImageIndex"),Integer)
		Me.labelSSID.ImageKey = resources.GetString("labelSSID.ImageKey")
		Me.labelSSID.ImeMode = CType(resources.GetObject("labelSSID.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelSSID.Location = CType(resources.GetObject("labelSSID.Location"),System.Drawing.Point)
		Me.labelSSID.Name = "labelSSID"
		Me.labelSSID.RightToLeft = CType(resources.GetObject("labelSSID.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelSSID.Size = CType(resources.GetObject("labelSSID.Size"),System.Drawing.Size)
		Me.labelSSID.TabIndex = CType(resources.GetObject("labelSSID.TabIndex"),Integer)
		Me.labelSSID.Text = resources.GetString("labelSSID.Text")
		Me.labelSSID.TextAlign = CType(resources.GetObject("labelSSID.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelSSID, resources.GetString("labelSSID.ToolTip"))
		'
		'labelSSIDNotes
		'
		Me.labelSSIDNotes.AccessibleDescription = Nothing
		Me.labelSSIDNotes.AccessibleName = Nothing
		Me.labelSSIDNotes.Anchor = CType(resources.GetObject("labelSSIDNotes.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelSSIDNotes.AutoSize = CType(resources.GetObject("labelSSIDNotes.AutoSize"),Boolean)
		Me.labelSSIDNotes.BackgroundImageLayout = CType(resources.GetObject("labelSSIDNotes.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelSSIDNotes.Dock = CType(resources.GetObject("labelSSIDNotes.Dock"),System.Windows.Forms.DockStyle)
		Me.labelSSIDNotes.Font = CType(resources.GetObject("labelSSIDNotes.Font"),System.Drawing.Font)
		Me.labelSSIDNotes.ImageAlign = CType(resources.GetObject("labelSSIDNotes.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelSSIDNotes.ImageIndex = CType(resources.GetObject("labelSSIDNotes.ImageIndex"),Integer)
		Me.labelSSIDNotes.ImageKey = resources.GetString("labelSSIDNotes.ImageKey")
		Me.labelSSIDNotes.ImeMode = CType(resources.GetObject("labelSSIDNotes.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelSSIDNotes.Location = CType(resources.GetObject("labelSSIDNotes.Location"),System.Drawing.Point)
		Me.labelSSIDNotes.Name = "labelSSIDNotes"
		Me.labelSSIDNotes.RightToLeft = CType(resources.GetObject("labelSSIDNotes.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelSSIDNotes.Size = CType(resources.GetObject("labelSSIDNotes.Size"),System.Drawing.Size)
		Me.labelSSIDNotes.TabIndex = CType(resources.GetObject("labelSSIDNotes.TabIndex"),Integer)
		Me.labelSSIDNotes.Text = resources.GetString("labelSSIDNotes.Text")
		Me.labelSSIDNotes.TextAlign = CType(resources.GetObject("labelSSIDNotes.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelSSIDNotes, resources.GetString("labelSSIDNotes.ToolTip"))
		'
		'textBoxAutoActivateSSID
		'
		Me.textBoxAutoActivateSSID.AccessibleDescription = Nothing
		Me.textBoxAutoActivateSSID.AccessibleName = Nothing
		Me.textBoxAutoActivateSSID.Anchor = CType(resources.GetObject("textBoxAutoActivateSSID.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxAutoActivateSSID.BackgroundImage = Nothing
		Me.textBoxAutoActivateSSID.BackgroundImageLayout = CType(resources.GetObject("textBoxAutoActivateSSID.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxAutoActivateSSID.Dock = CType(resources.GetObject("textBoxAutoActivateSSID.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxAutoActivateSSID.Font = CType(resources.GetObject("textBoxAutoActivateSSID.Font"),System.Drawing.Font)
		Me.textBoxAutoActivateSSID.ImeMode = CType(resources.GetObject("textBoxAutoActivateSSID.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxAutoActivateSSID.Location = CType(resources.GetObject("textBoxAutoActivateSSID.Location"),System.Drawing.Point)
		Me.textBoxAutoActivateSSID.MaxLength = CType(resources.GetObject("textBoxAutoActivateSSID.MaxLength"),Integer)
		Me.textBoxAutoActivateSSID.Multiline = CType(resources.GetObject("textBoxAutoActivateSSID.Multiline"),Boolean)
		Me.textBoxAutoActivateSSID.Name = "textBoxAutoActivateSSID"
		Me.textBoxAutoActivateSSID.PasswordChar = CType(resources.GetObject("textBoxAutoActivateSSID.PasswordChar"),Char)
		Me.textBoxAutoActivateSSID.RightToLeft = CType(resources.GetObject("textBoxAutoActivateSSID.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxAutoActivateSSID.ScrollBars = CType(resources.GetObject("textBoxAutoActivateSSID.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxAutoActivateSSID.Size = CType(resources.GetObject("textBoxAutoActivateSSID.Size"),System.Drawing.Size)
		Me.textBoxAutoActivateSSID.TabIndex = CType(resources.GetObject("textBoxAutoActivateSSID.TabIndex"),Integer)
		Me.textBoxAutoActivateSSID.TextAlign = CType(resources.GetObject("textBoxAutoActivateSSID.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxAutoActivateSSID, resources.GetString("textBoxAutoActivateSSID.ToolTip"))
		Me.textBoxAutoActivateSSID.WordWrap = CType(resources.GetObject("textBoxAutoActivateSSID.WordWrap"),Boolean)
		'
		'buttonClose
		'
		Me.buttonClose.AccessibleDescription = Nothing
		Me.buttonClose.AccessibleName = Nothing
		Me.buttonClose.Anchor = CType(resources.GetObject("buttonClose.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonClose.AutoSize = CType(resources.GetObject("buttonClose.AutoSize"),Boolean)
		Me.buttonClose.AutoSizeMode = CType(resources.GetObject("buttonClose.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonClose.BackgroundImage = Nothing
		Me.buttonClose.BackgroundImageLayout = CType(resources.GetObject("buttonClose.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonClose.Dock = CType(resources.GetObject("buttonClose.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonClose.FlatStyle = CType(resources.GetObject("buttonClose.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonClose.Font = Nothing
		Me.buttonClose.Image = CType(resources.GetObject("buttonClose.Image"),System.Drawing.Image)
		Me.buttonClose.ImageAlign = CType(resources.GetObject("buttonClose.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonClose.ImageIndex = CType(resources.GetObject("buttonClose.ImageIndex"),Integer)
		Me.buttonClose.ImageKey = resources.GetString("buttonClose.ImageKey")
		Me.buttonClose.ImeMode = CType(resources.GetObject("buttonClose.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonClose.Location = CType(resources.GetObject("buttonClose.Location"),System.Drawing.Point)
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.RightToLeft = CType(resources.GetObject("buttonClose.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonClose.Size = CType(resources.GetObject("buttonClose.Size"),System.Drawing.Size)
		Me.buttonClose.TabIndex = CType(resources.GetObject("buttonClose.TabIndex"),Integer)
		Me.buttonClose.Text = resources.GetString("buttonClose.Text")
		Me.buttonClose.TextAlign = CType(resources.GetObject("buttonClose.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonClose.TextImageRelation = CType(resources.GetObject("buttonClose.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonClose, resources.GetString("buttonClose.ToolTip"))
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.ButtonCloseClick
		'
		'buttonSave
		'
		Me.buttonSave.AccessibleDescription = Nothing
		Me.buttonSave.AccessibleName = Nothing
		Me.buttonSave.Anchor = CType(resources.GetObject("buttonSave.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonSave.AutoSize = CType(resources.GetObject("buttonSave.AutoSize"),Boolean)
		Me.buttonSave.AutoSizeMode = CType(resources.GetObject("buttonSave.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonSave.BackgroundImage = Nothing
		Me.buttonSave.BackgroundImageLayout = CType(resources.GetObject("buttonSave.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonSave.Dock = CType(resources.GetObject("buttonSave.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonSave.FlatStyle = CType(resources.GetObject("buttonSave.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonSave.Font = Nothing
		Me.buttonSave.Image = CType(resources.GetObject("buttonSave.Image"),System.Drawing.Image)
		Me.buttonSave.ImageAlign = CType(resources.GetObject("buttonSave.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonSave.ImageIndex = CType(resources.GetObject("buttonSave.ImageIndex"),Integer)
		Me.buttonSave.ImageKey = resources.GetString("buttonSave.ImageKey")
		Me.buttonSave.ImeMode = CType(resources.GetObject("buttonSave.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonSave.Location = CType(resources.GetObject("buttonSave.Location"),System.Drawing.Point)
		Me.buttonSave.Name = "buttonSave"
		Me.buttonSave.RightToLeft = CType(resources.GetObject("buttonSave.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonSave.Size = CType(resources.GetObject("buttonSave.Size"),System.Drawing.Size)
		Me.buttonSave.TabIndex = CType(resources.GetObject("buttonSave.TabIndex"),Integer)
		Me.buttonSave.Text = resources.GetString("buttonSave.Text")
		Me.buttonSave.TextAlign = CType(resources.GetObject("buttonSave.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonSave.TextImageRelation = CType(resources.GetObject("buttonSave.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.toolTip1.SetToolTip(Me.buttonSave, resources.GetString("buttonSave.ToolTip"))
		Me.buttonSave.UseVisualStyleBackColor = true
		AddHandler Me.buttonSave.Click, AddressOf Me.ButtonSaveClick
		'
		'labelProfileName
		'
		Me.labelProfileName.AccessibleDescription = Nothing
		Me.labelProfileName.AccessibleName = Nothing
		Me.labelProfileName.Anchor = CType(resources.GetObject("labelProfileName.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelProfileName.AutoSize = CType(resources.GetObject("labelProfileName.AutoSize"),Boolean)
		Me.labelProfileName.BackgroundImageLayout = CType(resources.GetObject("labelProfileName.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelProfileName.Dock = CType(resources.GetObject("labelProfileName.Dock"),System.Windows.Forms.DockStyle)
		Me.labelProfileName.Font = Nothing
		Me.labelProfileName.ImageAlign = CType(resources.GetObject("labelProfileName.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelProfileName.ImageIndex = CType(resources.GetObject("labelProfileName.ImageIndex"),Integer)
		Me.labelProfileName.ImageKey = resources.GetString("labelProfileName.ImageKey")
		Me.labelProfileName.ImeMode = CType(resources.GetObject("labelProfileName.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelProfileName.Location = CType(resources.GetObject("labelProfileName.Location"),System.Drawing.Point)
		Me.labelProfileName.Name = "labelProfileName"
		Me.labelProfileName.RightToLeft = CType(resources.GetObject("labelProfileName.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelProfileName.Size = CType(resources.GetObject("labelProfileName.Size"),System.Drawing.Size)
		Me.labelProfileName.TabIndex = CType(resources.GetObject("labelProfileName.TabIndex"),Integer)
		Me.labelProfileName.Text = resources.GetString("labelProfileName.Text")
		Me.labelProfileName.TextAlign = CType(resources.GetObject("labelProfileName.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelProfileName, resources.GetString("labelProfileName.ToolTip"))
		'
		'textBoxProfileName
		'
		Me.textBoxProfileName.AccessibleDescription = Nothing
		Me.textBoxProfileName.AccessibleName = Nothing
		Me.textBoxProfileName.Anchor = CType(resources.GetObject("textBoxProfileName.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxProfileName.BackgroundImage = Nothing
		Me.textBoxProfileName.BackgroundImageLayout = CType(resources.GetObject("textBoxProfileName.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxProfileName.Dock = CType(resources.GetObject("textBoxProfileName.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxProfileName.Font = Nothing
		Me.textBoxProfileName.ImeMode = CType(resources.GetObject("textBoxProfileName.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxProfileName.Location = CType(resources.GetObject("textBoxProfileName.Location"),System.Drawing.Point)
		Me.textBoxProfileName.MaxLength = CType(resources.GetObject("textBoxProfileName.MaxLength"),Integer)
		Me.textBoxProfileName.Multiline = CType(resources.GetObject("textBoxProfileName.Multiline"),Boolean)
		Me.textBoxProfileName.Name = "textBoxProfileName"
		Me.textBoxProfileName.PasswordChar = CType(resources.GetObject("textBoxProfileName.PasswordChar"),Char)
		Me.textBoxProfileName.RightToLeft = CType(resources.GetObject("textBoxProfileName.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxProfileName.ScrollBars = CType(resources.GetObject("textBoxProfileName.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxProfileName.Size = CType(resources.GetObject("textBoxProfileName.Size"),System.Drawing.Size)
		Me.textBoxProfileName.TabIndex = CType(resources.GetObject("textBoxProfileName.TabIndex"),Integer)
		Me.textBoxProfileName.TextAlign = CType(resources.GetObject("textBoxProfileName.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.toolTip1.SetToolTip(Me.textBoxProfileName, resources.GetString("textBoxProfileName.ToolTip"))
		Me.textBoxProfileName.WordWrap = CType(resources.GetObject("textBoxProfileName.WordWrap"),Boolean)
		'
		'labelNetworkCard
		'
		Me.labelNetworkCard.AccessibleDescription = Nothing
		Me.labelNetworkCard.AccessibleName = Nothing
		Me.labelNetworkCard.Anchor = CType(resources.GetObject("labelNetworkCard.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelNetworkCard.AutoSize = CType(resources.GetObject("labelNetworkCard.AutoSize"),Boolean)
		Me.labelNetworkCard.BackgroundImageLayout = CType(resources.GetObject("labelNetworkCard.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelNetworkCard.Dock = CType(resources.GetObject("labelNetworkCard.Dock"),System.Windows.Forms.DockStyle)
		Me.labelNetworkCard.Font = Nothing
		Me.labelNetworkCard.ImageAlign = CType(resources.GetObject("labelNetworkCard.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelNetworkCard.ImageIndex = CType(resources.GetObject("labelNetworkCard.ImageIndex"),Integer)
		Me.labelNetworkCard.ImageKey = resources.GetString("labelNetworkCard.ImageKey")
		Me.labelNetworkCard.ImeMode = CType(resources.GetObject("labelNetworkCard.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelNetworkCard.Location = CType(resources.GetObject("labelNetworkCard.Location"),System.Drawing.Point)
		Me.labelNetworkCard.Name = "labelNetworkCard"
		Me.labelNetworkCard.RightToLeft = CType(resources.GetObject("labelNetworkCard.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelNetworkCard.Size = CType(resources.GetObject("labelNetworkCard.Size"),System.Drawing.Size)
		Me.labelNetworkCard.TabIndex = CType(resources.GetObject("labelNetworkCard.TabIndex"),Integer)
		Me.labelNetworkCard.Text = resources.GetString("labelNetworkCard.Text")
		Me.labelNetworkCard.TextAlign = CType(resources.GetObject("labelNetworkCard.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelNetworkCard, resources.GetString("labelNetworkCard.ToolTip"))
		'
		'comboBoxNetworkCards
		'
		Me.comboBoxNetworkCards.AccessibleDescription = Nothing
		Me.comboBoxNetworkCards.AccessibleName = Nothing
		Me.comboBoxNetworkCards.Anchor = CType(resources.GetObject("comboBoxNetworkCards.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxNetworkCards.BackgroundImage = Nothing
		Me.comboBoxNetworkCards.BackgroundImageLayout = CType(resources.GetObject("comboBoxNetworkCards.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxNetworkCards.Dock = CType(resources.GetObject("comboBoxNetworkCards.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxNetworkCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxNetworkCards.FlatStyle = CType(resources.GetObject("comboBoxNetworkCards.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxNetworkCards.Font = Nothing
		Me.comboBoxNetworkCards.FormattingEnabled = true
		Me.comboBoxNetworkCards.ImeMode = CType(resources.GetObject("comboBoxNetworkCards.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxNetworkCards.IntegralHeight = CType(resources.GetObject("comboBoxNetworkCards.IntegralHeight"),Boolean)
		Me.comboBoxNetworkCards.Location = CType(resources.GetObject("comboBoxNetworkCards.Location"),System.Drawing.Point)
		Me.comboBoxNetworkCards.MaxDropDownItems = CType(resources.GetObject("comboBoxNetworkCards.MaxDropDownItems"),Integer)
		Me.comboBoxNetworkCards.MaxLength = CType(resources.GetObject("comboBoxNetworkCards.MaxLength"),Integer)
		Me.comboBoxNetworkCards.Name = "comboBoxNetworkCards"
		Me.comboBoxNetworkCards.RightToLeft = CType(resources.GetObject("comboBoxNetworkCards.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxNetworkCards.Size = CType(resources.GetObject("comboBoxNetworkCards.Size"),System.Drawing.Size)
		Me.comboBoxNetworkCards.TabIndex = CType(resources.GetObject("comboBoxNetworkCards.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.comboBoxNetworkCards, resources.GetString("comboBoxNetworkCards.ToolTip"))
		'
		'progressBar1
		'
		Me.progressBar1.AccessibleDescription = Nothing
		Me.progressBar1.AccessibleName = Nothing
		Me.progressBar1.Anchor = CType(resources.GetObject("progressBar1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.progressBar1.BackgroundImage = Nothing
		Me.progressBar1.BackgroundImageLayout = CType(resources.GetObject("progressBar1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.progressBar1.Dock = CType(resources.GetObject("progressBar1.Dock"),System.Windows.Forms.DockStyle)
		Me.progressBar1.Font = Nothing
		Me.progressBar1.ImeMode = CType(resources.GetObject("progressBar1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.progressBar1.Location = CType(resources.GetObject("progressBar1.Location"),System.Drawing.Point)
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.RightToLeft = CType(resources.GetObject("progressBar1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.progressBar1.RightToLeftLayout = CType(resources.GetObject("progressBar1.RightToLeftLayout"),Boolean)
		Me.progressBar1.Size = CType(resources.GetObject("progressBar1.Size"),System.Drawing.Size)
		Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		Me.progressBar1.TabIndex = CType(resources.GetObject("progressBar1.TabIndex"),Integer)
		Me.toolTip1.SetToolTip(Me.progressBar1, resources.GetString("progressBar1.ToolTip"))
		Me.progressBar1.Visible = CType(resources.GetObject("progressBar1.Visible"),Boolean)
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'labelWorking
		'
		Me.labelWorking.AccessibleDescription = Nothing
		Me.labelWorking.AccessibleName = Nothing
		Me.labelWorking.Anchor = CType(resources.GetObject("labelWorking.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelWorking.AutoSize = CType(resources.GetObject("labelWorking.AutoSize"),Boolean)
		Me.labelWorking.BackgroundImageLayout = CType(resources.GetObject("labelWorking.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelWorking.Dock = CType(resources.GetObject("labelWorking.Dock"),System.Windows.Forms.DockStyle)
		Me.labelWorking.Font = Nothing
		Me.labelWorking.ImageAlign = CType(resources.GetObject("labelWorking.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelWorking.ImageIndex = CType(resources.GetObject("labelWorking.ImageIndex"),Integer)
		Me.labelWorking.ImageKey = resources.GetString("labelWorking.ImageKey")
		Me.labelWorking.ImeMode = CType(resources.GetObject("labelWorking.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelWorking.Location = CType(resources.GetObject("labelWorking.Location"),System.Drawing.Point)
		Me.labelWorking.Name = "labelWorking"
		Me.labelWorking.RightToLeft = CType(resources.GetObject("labelWorking.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelWorking.Size = CType(resources.GetObject("labelWorking.Size"),System.Drawing.Size)
		Me.labelWorking.TabIndex = CType(resources.GetObject("labelWorking.TabIndex"),Integer)
		Me.labelWorking.TextAlign = CType(resources.GetObject("labelWorking.TextAlign"),System.Drawing.ContentAlignment)
		Me.toolTip1.SetToolTip(Me.labelWorking, resources.GetString("labelWorking.ToolTip"))
		Me.labelWorking.Visible = CType(resources.GetObject("labelWorking.Visible"),Boolean)
		'
		'openFileDialogWallpaper
		'
		Me.openFileDialogWallpaper.Filter = resources.GetString("openFileDialogWallpaper.Filter")
		Me.openFileDialogWallpaper.Title = resources.GetString("openFileDialogWallpaper.Title")
		'
		'ProfileSettings
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
		Me.Controls.Add(Me.labelWorking)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.comboBoxNetworkCards)
		Me.Controls.Add(Me.labelNetworkCard)
		Me.Controls.Add(Me.textBoxProfileName)
		Me.Controls.Add(Me.labelProfileName)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.tabControl1)
		Me.Font = Nothing
		Me.Icon = Nothing
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "ProfileSettings"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		Me.toolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
		AddHandler FormClosed, AddressOf Me.ProfileSettingsFormClosed
		AddHandler Load, AddressOf Me.ProfileSettingsLoad
		Me.tabControl1.ResumeLayout(false)
		Me.tabPageIPSettings.ResumeLayout(false)
		Me.tabPageIPSettings.PerformLayout
		CType(Me.pictureBoxWINSServer,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBoxAlternateDNSServer,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBoxPrimaryDNSServer,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBoxDefaultGateway,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBoxSubnetMask,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBoxIPAddress,System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPageInternet.ResumeLayout(false)
		Me.groupBoxPleaseNote.ResumeLayout(false)
		Me.groupBoxAutoConfigAddress.ResumeLayout(false)
		Me.groupBoxAutoConfigAddress.PerformLayout
		Me.groupBoxWebBrowsers.ResumeLayout(false)
		Me.groupBoxWebBrowsers.PerformLayout
		Me.groupBoxProxy.ResumeLayout(false)
		Me.groupBoxProxy.PerformLayout
		Me.groupBoxHomepage.ResumeLayout(false)
		Me.groupBoxHomepage.PerformLayout
		Me.tabPageMappedDrives.ResumeLayout(false)
		Me.tabPageMappedDrives.PerformLayout
		Me.toolStripMappedDrives.ResumeLayout(false)
		Me.toolStripMappedDrives.PerformLayout
		Me.tabPagePrinter.ResumeLayout(false)
		Me.groupBoxPrinter.ResumeLayout(false)
		Me.tabPageRun.ResumeLayout(false)
		Me.tabPageRun.PerformLayout
		Me.toolStripRun.ResumeLayout(false)
		Me.toolStripRun.PerformLayout
		Me.tabPageDesktop.ResumeLayout(false)
		Me.groupBoxDisplaySettings.ResumeLayout(false)
		Me.groupBoxDisplaySettings.PerformLayout
		Me.groupBoxWallpaper.ResumeLayout(false)
		Me.groupBoxWallpaper.PerformLayout
		Me.groupBoxWallpaperPreview.ResumeLayout(false)
		CType(Me.pictureBoxWallpaperPreview,System.ComponentModel.ISupportInitialize).EndInit
		Me.tabPageWireless.ResumeLayout(false)
		Me.groupBoxWireless.ResumeLayout(false)
		Me.groupBoxWireless.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelWirelessVista As System.Windows.Forms.Label
	Private labelPleaseNote As System.Windows.Forms.Label
	Private groupBoxPleaseNote As System.Windows.Forms.GroupBox
	Private checkBoxOpera As System.Windows.Forms.CheckBox
	Private groupBoxWallpaperPreview As System.Windows.Forms.GroupBox
	Private pictureBoxWallpaperPreview As System.Windows.Forms.PictureBox
	Private textBoxAutoConfigAddress As System.Windows.Forms.TextBox
	Private groupBoxAutoConfigAddress As System.Windows.Forms.GroupBox
	Private checkBoxBypassProxyForLocalAddresses As System.Windows.Forms.CheckBox
	Private groupBoxWallpaper As System.Windows.Forms.GroupBox
	Private groupBoxDisplaySettings As System.Windows.Forms.GroupBox
	Private labelColorQuality As System.Windows.Forms.Label
	Private labelScreenResolution As System.Windows.Forms.Label
	Private groupBoxWireless As System.Windows.Forms.GroupBox
	Private labelSSID As System.Windows.Forms.Label
	Private labelSSIDNotes As System.Windows.Forms.Label
	Private groupBoxPrinter As System.Windows.Forms.GroupBox
	Private groupBoxHomepage As System.Windows.Forms.GroupBox
	Private groupBoxProxy As System.Windows.Forms.GroupBox
	Private labelHomepageNote As System.Windows.Forms.Label
	Private tabPageIPSettings As System.Windows.Forms.TabPage
	Private tabPageMappedDrives As System.Windows.Forms.TabPage
	Private labelProfileName As System.Windows.Forms.Label
	Private labelNetworkCard As System.Windows.Forms.Label
	Private tabPagePrinter As System.Windows.Forms.TabPage
	Private tabPageInternet As System.Windows.Forms.TabPage
	Private tabPageWireless As System.Windows.Forms.TabPage
	Private tabPageRun As System.Windows.Forms.TabPage
	Private tabPageDesktop As System.Windows.Forms.TabPage
	Private buttonClearFirefox As System.Windows.Forms.Button
	Private groupBoxWebBrowsers As System.Windows.Forms.GroupBox
	Private checkBoxIE As System.Windows.Forms.CheckBox
	Private checkBoxFirefox As System.Windows.Forms.CheckBox
	Private textBoxAutoActivateSSID As System.Windows.Forms.TextBox
	Private buttonGetCurrentDisplaySettings As System.Windows.Forms.Button
	Public comboBoxDisplayColors As System.Windows.Forms.ComboBox
	Public comboBoxDisplaySettings As System.Windows.Forms.ComboBox
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private buttonResetWallpaper As System.Windows.Forms.Button
	Private textBoxWallpaperPath As System.Windows.Forms.TextBox
	Private openFileDialogWallpaper As System.Windows.Forms.OpenFileDialog
	Private buttonBrowseWallpaper As System.Windows.Forms.Button
	Private columnHeaderRunDomain As System.Windows.Forms.ColumnHeader
	Private columnHeaderRunPassword As System.Windows.Forms.ColumnHeader
	Private columnHeaderRunUsername As System.Windows.Forms.ColumnHeader
	Private columnHeaderRunRun As System.Windows.Forms.ColumnHeader
	Private columnHeaderRunPath As System.Windows.Forms.ColumnHeader
	Private columnHeaderRunArguments As System.Windows.Forms.ColumnHeader
	Private toolStripButtonRemoveProgram As System.Windows.Forms.ToolStripButton
	Private toolStripButtonEditProgram As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private toolStripButtonAddProgram As System.Windows.Forms.ToolStripButton
	Private toolStripRun As System.Windows.Forms.ToolStrip
	Public listViewRun As System.Windows.Forms.ListView
	Private buttonGetDefaultPrinter As System.Windows.Forms.Button
	Private buttonGetCurrentIPSettings As System.Windows.Forms.Button
	Private checkBoxUseProxySettings As System.Windows.Forms.CheckBox
	Private labelServerAddress As System.Windows.Forms.Label
	Private labelPort As System.Windows.Forms.Label
	Private textBoxServerAddress As System.Windows.Forms.TextBox
	Private textBoxPort As System.Windows.Forms.TextBox
	Private textBoxDefaultHomepage As System.Windows.Forms.TextBox
	Private buttonUseBlankHomepage As System.Windows.Forms.Button
	Private comboBoxPrinters As System.Windows.Forms.ComboBox
	Private toolStripMappedDrives As System.Windows.Forms.ToolStrip
	Private labelWorking As System.Windows.Forms.Label
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private toolStripButtonEditDrive As System.Windows.Forms.ToolStripButton
	Private toolStripButtonAddDrive As System.Windows.Forms.ToolStripButton
	Private toolStripButtonRemoveDrive As System.Windows.Forms.ToolStripButton
	Private imageListDrives As System.Windows.Forms.ImageList
	Private columnHeaderPassword As System.Windows.Forms.ColumnHeader
	Private columnHeaderUsername As System.Windows.Forms.ColumnHeader
	Private columnHeaderPath As System.Windows.Forms.ColumnHeader
	Private columnHeaderDrive As System.Windows.Forms.ColumnHeader
	Public listViewMappedDrives As System.Windows.Forms.ListView
	Private labelIPAddress As System.Windows.Forms.Label
	Private labelPrimaryDNSServer As System.Windows.Forms.Label
	Private labelDefaultGateway As System.Windows.Forms.Label
	Private labelSubnetMask As System.Windows.Forms.Label
	Private labelWINSServer As System.Windows.Forms.Label
	Private labelAlternateDNSServer As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
	Private progressBar1 As System.Windows.Forms.ProgressBar
	Private textBoxSubnetMask1 As System.Windows.Forms.TextBox
	Private textBoxSubnetMask2 As System.Windows.Forms.TextBox
	Private textBoxSubnetMask3 As System.Windows.Forms.TextBox
	Private textBoxSubnetMask4 As System.Windows.Forms.TextBox
	Private textBoxDefaultGateway1 As System.Windows.Forms.TextBox
	Private textBoxDefaultGateway2 As System.Windows.Forms.TextBox
	Private textBoxDefaultGateway3 As System.Windows.Forms.TextBox
	Private textBoxDefaultGateway4 As System.Windows.Forms.TextBox
	Private textBoxPrimaryDNSServer1 As System.Windows.Forms.TextBox
	Private textBoxPrimaryDNSServer2 As System.Windows.Forms.TextBox
	Private textBoxPrimaryDNSServer3 As System.Windows.Forms.TextBox
	Private textBoxPrimaryDNSServer4 As System.Windows.Forms.TextBox
	Private textBoxAlternateDNSServer1 As System.Windows.Forms.TextBox
	Private textBoxAlternateDNSServer2 As System.Windows.Forms.TextBox
	Private textBoxAlternateDNSServer3 As System.Windows.Forms.TextBox
	Private textBoxAlternateDNSServer4 As System.Windows.Forms.TextBox
	Private textBoxWINSServer1 As System.Windows.Forms.TextBox
	Private textBoxWINSServer2 As System.Windows.Forms.TextBox
	Private textBoxWINSServer3 As System.Windows.Forms.TextBox
	Private textBoxWINSServer4 As System.Windows.Forms.TextBox
	Private textBoxIPAddress1 As System.Windows.Forms.TextBox
	Private textBoxIPAddress2 As System.Windows.Forms.TextBox
	Private textBoxIPAddress3 As System.Windows.Forms.TextBox
	Private textBoxIPAddress4 As System.Windows.Forms.TextBox
	Private pictureBoxSubnetMask As System.Windows.Forms.PictureBox
	Private pictureBoxDefaultGateway As System.Windows.Forms.PictureBox
	Private pictureBoxPrimaryDNSServer As System.Windows.Forms.PictureBox
	Private pictureBoxAlternateDNSServer As System.Windows.Forms.PictureBox
	Private pictureBoxWINSServer As System.Windows.Forms.PictureBox
	Private checkBoxDHCP As System.Windows.Forms.CheckBox
	Private pictureBoxIPAddress As System.Windows.Forms.PictureBox
	Private label14 As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label20 As System.Windows.Forms.Label
	Private label19 As System.Windows.Forms.Label
	Private label18 As System.Windows.Forms.Label
	Private label23 As System.Windows.Forms.Label
	Private label22 As System.Windows.Forms.Label
	Private label21 As System.Windows.Forms.Label
	Private label26 As System.Windows.Forms.Label
	Private label25 As System.Windows.Forms.Label
	Private label24 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private comboBoxNetworkCards As System.Windows.Forms.ComboBox
	Private textBoxProfileName As System.Windows.Forms.TextBox
	Private buttonSave As System.Windows.Forms.Button
	Private buttonClose As System.Windows.Forms.Button
	Private tabControl1 As System.Windows.Forms.TabControl
End Class
