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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileSettings))
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPageIPSettings = New System.Windows.Forms.TabPage()
		Me.labelDNSSuffix = New System.Windows.Forms.Label()
		Me.textBoxDNSSuffix = New System.Windows.Forms.TextBox()
		Me.buttonGetCurrentIPSettings = New System.Windows.Forms.Button()
		Me.checkBoxDHCP = New System.Windows.Forms.CheckBox()
		Me.textBoxWINSServer4 = New System.Windows.Forms.TextBox()
		Me.textBoxWINSServer3 = New System.Windows.Forms.TextBox()
		Me.textBoxWINSServer2 = New System.Windows.Forms.TextBox()
		Me.textBoxWINSServer1 = New System.Windows.Forms.TextBox()
		Me.label24 = New System.Windows.Forms.Label()
		Me.label25 = New System.Windows.Forms.Label()
		Me.label26 = New System.Windows.Forms.Label()
		Me.pictureBoxWINSServer = New System.Windows.Forms.PictureBox()
		Me.textBoxAlternateDNSServer4 = New System.Windows.Forms.TextBox()
		Me.textBoxAlternateDNSServer3 = New System.Windows.Forms.TextBox()
		Me.textBoxAlternateDNSServer2 = New System.Windows.Forms.TextBox()
		Me.textBoxAlternateDNSServer1 = New System.Windows.Forms.TextBox()
		Me.label21 = New System.Windows.Forms.Label()
		Me.label22 = New System.Windows.Forms.Label()
		Me.label23 = New System.Windows.Forms.Label()
		Me.pictureBoxAlternateDNSServer = New System.Windows.Forms.PictureBox()
		Me.textBoxPrimaryDNSServer4 = New System.Windows.Forms.TextBox()
		Me.textBoxPrimaryDNSServer3 = New System.Windows.Forms.TextBox()
		Me.textBoxPrimaryDNSServer2 = New System.Windows.Forms.TextBox()
		Me.textBoxPrimaryDNSServer1 = New System.Windows.Forms.TextBox()
		Me.label18 = New System.Windows.Forms.Label()
		Me.label19 = New System.Windows.Forms.Label()
		Me.label20 = New System.Windows.Forms.Label()
		Me.pictureBoxPrimaryDNSServer = New System.Windows.Forms.PictureBox()
		Me.textBoxDefaultGateway4 = New System.Windows.Forms.TextBox()
		Me.textBoxDefaultGateway3 = New System.Windows.Forms.TextBox()
		Me.textBoxDefaultGateway2 = New System.Windows.Forms.TextBox()
		Me.textBoxDefaultGateway1 = New System.Windows.Forms.TextBox()
		Me.label15 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.label17 = New System.Windows.Forms.Label()
		Me.pictureBoxDefaultGateway = New System.Windows.Forms.PictureBox()
		Me.textBoxSubnetMask4 = New System.Windows.Forms.TextBox()
		Me.textBoxSubnetMask3 = New System.Windows.Forms.TextBox()
		Me.textBoxSubnetMask2 = New System.Windows.Forms.TextBox()
		Me.textBoxSubnetMask1 = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.pictureBoxSubnetMask = New System.Windows.Forms.PictureBox()
		Me.labelWINSServer = New System.Windows.Forms.Label()
		Me.labelAlternateDNSServer = New System.Windows.Forms.Label()
		Me.labelPrimaryDNSServer = New System.Windows.Forms.Label()
		Me.labelDefaultGateway = New System.Windows.Forms.Label()
		Me.labelSubnetMask = New System.Windows.Forms.Label()
		Me.textBoxIPAddress4 = New System.Windows.Forms.TextBox()
		Me.textBoxIPAddress3 = New System.Windows.Forms.TextBox()
		Me.textBoxIPAddress2 = New System.Windows.Forms.TextBox()
		Me.textBoxIPAddress1 = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.pictureBoxIPAddress = New System.Windows.Forms.PictureBox()
		Me.labelIPAddress = New System.Windows.Forms.Label()
		Me.tabPageInternet = New System.Windows.Forms.TabPage()
		Me.groupBoxPleaseNote = New System.Windows.Forms.GroupBox()
		Me.labelPleaseNote = New System.Windows.Forms.Label()
		Me.groupBoxAutoConfigAddress = New System.Windows.Forms.GroupBox()
		Me.textBoxAutoConfigAddress = New System.Windows.Forms.TextBox()
		Me.groupBoxWebBrowsers = New System.Windows.Forms.GroupBox()
		Me.checkBoxIE = New System.Windows.Forms.CheckBox()
		Me.checkBoxFirefox = New System.Windows.Forms.CheckBox()
		Me.groupBoxProxy = New System.Windows.Forms.GroupBox()
		Me.checkBoxBypassProxyForLocalAddresses = New System.Windows.Forms.CheckBox()
		Me.textBoxExceptions = New System.Windows.Forms.TextBox()
		Me.textBoxServerAddress = New System.Windows.Forms.TextBox()
		Me.labelExceptions = New System.Windows.Forms.Label()
		Me.labelServerAddress = New System.Windows.Forms.Label()
		Me.checkBoxUseProxySettings = New System.Windows.Forms.CheckBox()
		Me.groupBoxHomepage = New System.Windows.Forms.GroupBox()
		Me.labelHomepageNote = New System.Windows.Forms.Label()
		Me.buttonUseBlankHomepage = New System.Windows.Forms.Button()
		Me.textBoxDefaultHomepage = New System.Windows.Forms.TextBox()
		Me.tabPageMappedDrives = New System.Windows.Forms.TabPage()
		Me.listViewMappedDrives = New System.Windows.Forms.ListView()
		Me.columnHeaderDrive = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderPath = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderUsername = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderPassword = New System.Windows.Forms.ColumnHeader()
		Me.imageListDrives = New System.Windows.Forms.ImageList(Me.components)
		Me.toolStripMappedDrives = New System.Windows.Forms.ToolStrip()
		Me.toolStripButtonAddDrive = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripButtonEditDrive = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButtonRemoveDrive = New System.Windows.Forms.ToolStripButton()
		Me.tabPagePrinter = New System.Windows.Forms.TabPage()
		Me.groupBoxPrinter = New System.Windows.Forms.GroupBox()
		Me.comboBoxPrinters = New System.Windows.Forms.ComboBox()
		Me.buttonGetDefaultPrinter = New System.Windows.Forms.Button()
		Me.tabPageRun = New System.Windows.Forms.TabPage()
		Me.listViewRun = New System.Windows.Forms.ListView()
		Me.columnHeaderRunPath = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderRunArguments = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderRunRun = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderRunUsername = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderRunPassword = New System.Windows.Forms.ColumnHeader()
		Me.columnHeaderRunDomain = New System.Windows.Forms.ColumnHeader()
		Me.toolStripRun = New System.Windows.Forms.ToolStrip()
		Me.toolStripButtonAddProgram = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripButtonEditProgram = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButtonRemoveProgram = New System.Windows.Forms.ToolStripButton()
		Me.tabPageDesktop = New System.Windows.Forms.TabPage()
		Me.groupBoxDisplaySettings = New System.Windows.Forms.GroupBox()
		Me.labelScreenResolution = New System.Windows.Forms.Label()
		Me.buttonGetCurrentDisplaySettings = New System.Windows.Forms.Button()
		Me.comboBoxDisplaySettings = New System.Windows.Forms.ComboBox()
		Me.groupBoxWallpaper = New System.Windows.Forms.GroupBox()
		Me.groupBoxWallpaperPreview = New System.Windows.Forms.GroupBox()
		Me.pictureBoxWallpaperPreview = New System.Windows.Forms.PictureBox()
		Me.buttonResetWallpaper = New System.Windows.Forms.Button()
		Me.buttonBrowseWallpaper = New System.Windows.Forms.Button()
		Me.textBoxWallpaperPath = New System.Windows.Forms.TextBox()
		Me.tabPageWireless = New System.Windows.Forms.TabPage()
		Me.groupBoxWireless = New System.Windows.Forms.GroupBox()
		Me.labelSSID = New System.Windows.Forms.Label()
		Me.labelSSIDNotes = New System.Windows.Forms.Label()
		Me.textBoxAutoActivateSSID = New System.Windows.Forms.TextBox()
		Me.buttonClose = New System.Windows.Forms.Button()
		Me.buttonSave = New System.Windows.Forms.Button()
		Me.labelProfileName = New System.Windows.Forms.Label()
		Me.textBoxProfileName = New System.Windows.Forms.TextBox()
		Me.labelNetworkCard = New System.Windows.Forms.Label()
		Me.comboBoxNetworkCards = New System.Windows.Forms.ComboBox()
		Me.progressBar1 = New System.Windows.Forms.ProgressBar()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.labelWorking = New System.Windows.Forms.Label()
		Me.openFileDialogWallpaper = New System.Windows.Forms.OpenFileDialog()
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
		Me.tabControl1.Controls.Add(Me.tabPageIPSettings)
		Me.tabControl1.Controls.Add(Me.tabPageInternet)
		Me.tabControl1.Controls.Add(Me.tabPageMappedDrives)
		Me.tabControl1.Controls.Add(Me.tabPagePrinter)
		Me.tabControl1.Controls.Add(Me.tabPageRun)
		Me.tabControl1.Controls.Add(Me.tabPageDesktop)
		Me.tabControl1.Controls.Add(Me.tabPageWireless)
		resources.ApplyResources(Me.tabControl1, "tabControl1")
		Me.tabControl1.Multiline = true
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		'
		'tabPageIPSettings
		'
		Me.tabPageIPSettings.Controls.Add(Me.labelDNSSuffix)
		Me.tabPageIPSettings.Controls.Add(Me.textBoxDNSSuffix)
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
		resources.ApplyResources(Me.tabPageIPSettings, "tabPageIPSettings")
		Me.tabPageIPSettings.Name = "tabPageIPSettings"
		Me.tabPageIPSettings.UseVisualStyleBackColor = true
		'
		'labelDNSSuffix
		'
		resources.ApplyResources(Me.labelDNSSuffix, "labelDNSSuffix")
		Me.labelDNSSuffix.Name = "labelDNSSuffix"
		'
		'textBoxDNSSuffix
		'
		resources.ApplyResources(Me.textBoxDNSSuffix, "textBoxDNSSuffix")
		Me.textBoxDNSSuffix.Name = "textBoxDNSSuffix"
		'
		'buttonGetCurrentIPSettings
		'
		Me.buttonGetCurrentIPSettings.AutoEllipsis = true
		resources.ApplyResources(Me.buttonGetCurrentIPSettings, "buttonGetCurrentIPSettings")
		Me.buttonGetCurrentIPSettings.Name = "buttonGetCurrentIPSettings"
		Me.buttonGetCurrentIPSettings.UseVisualStyleBackColor = true
		AddHandler Me.buttonGetCurrentIPSettings.Click, AddressOf Me.ButtonGetCurrentIPSettingsClick
		'
		'checkBoxDHCP
		'
		resources.ApplyResources(Me.checkBoxDHCP, "checkBoxDHCP")
		Me.checkBoxDHCP.Name = "checkBoxDHCP"
		Me.checkBoxDHCP.UseVisualStyleBackColor = true
		AddHandler Me.checkBoxDHCP.CheckedChanged, AddressOf Me.CheckBoxDHCPCheckedChanged
		'
		'textBoxWINSServer4
		'
		Me.textBoxWINSServer4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer4.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxWINSServer4, "textBoxWINSServer4")
		Me.textBoxWINSServer4.Name = "textBoxWINSServer4"
		Me.textBoxWINSServer4.TabStop = false
		AddHandler Me.textBoxWINSServer4.KeyPress, AddressOf Me.TextBoxWINSServer4KeyPress
		'
		'textBoxWINSServer3
		'
		Me.textBoxWINSServer3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer3.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxWINSServer3, "textBoxWINSServer3")
		Me.textBoxWINSServer3.Name = "textBoxWINSServer3"
		Me.textBoxWINSServer3.TabStop = false
		AddHandler Me.textBoxWINSServer3.KeyPress, AddressOf Me.TextBoxWINSServer3KeyPress
		'
		'textBoxWINSServer2
		'
		Me.textBoxWINSServer2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer2.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxWINSServer2, "textBoxWINSServer2")
		Me.textBoxWINSServer2.Name = "textBoxWINSServer2"
		Me.textBoxWINSServer2.TabStop = false
		AddHandler Me.textBoxWINSServer2.KeyPress, AddressOf Me.TextBoxWINSServer2KeyPress
		'
		'textBoxWINSServer1
		'
		Me.textBoxWINSServer1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxWINSServer1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxWINSServer1, "textBoxWINSServer1")
		Me.textBoxWINSServer1.Name = "textBoxWINSServer1"
		AddHandler Me.textBoxWINSServer1.KeyPress, AddressOf Me.TextBoxWINSServer1KeyPress
		'
		'label24
		'
		resources.ApplyResources(Me.label24, "label24")
		Me.label24.BackColor = System.Drawing.SystemColors.Window
		Me.label24.Name = "label24"
		'
		'label25
		'
		resources.ApplyResources(Me.label25, "label25")
		Me.label25.BackColor = System.Drawing.SystemColors.Window
		Me.label25.Name = "label25"
		'
		'label26
		'
		resources.ApplyResources(Me.label26, "label26")
		Me.label26.BackColor = System.Drawing.SystemColors.Window
		Me.label26.Name = "label26"
		'
		'pictureBoxWINSServer
		'
		Me.pictureBoxWINSServer.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxWINSServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pictureBoxWINSServer, "pictureBoxWINSServer")
		Me.pictureBoxWINSServer.Name = "pictureBoxWINSServer"
		Me.pictureBoxWINSServer.TabStop = false
		'
		'textBoxAlternateDNSServer4
		'
		Me.textBoxAlternateDNSServer4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer4.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxAlternateDNSServer4, "textBoxAlternateDNSServer4")
		Me.textBoxAlternateDNSServer4.Name = "textBoxAlternateDNSServer4"
		Me.textBoxAlternateDNSServer4.TabStop = false
		AddHandler Me.textBoxAlternateDNSServer4.KeyPress, AddressOf Me.TextBoxAlternateDNSServer4KeyPress
		'
		'textBoxAlternateDNSServer3
		'
		Me.textBoxAlternateDNSServer3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer3.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxAlternateDNSServer3, "textBoxAlternateDNSServer3")
		Me.textBoxAlternateDNSServer3.Name = "textBoxAlternateDNSServer3"
		Me.textBoxAlternateDNSServer3.TabStop = false
		AddHandler Me.textBoxAlternateDNSServer3.KeyPress, AddressOf Me.TextBoxAlternateDNSServer3KeyPress
		'
		'textBoxAlternateDNSServer2
		'
		Me.textBoxAlternateDNSServer2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer2.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxAlternateDNSServer2, "textBoxAlternateDNSServer2")
		Me.textBoxAlternateDNSServer2.Name = "textBoxAlternateDNSServer2"
		Me.textBoxAlternateDNSServer2.TabStop = false
		AddHandler Me.textBoxAlternateDNSServer2.KeyPress, AddressOf Me.TextBoxAlternateDNSServer2KeyPress
		'
		'textBoxAlternateDNSServer1
		'
		Me.textBoxAlternateDNSServer1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxAlternateDNSServer1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxAlternateDNSServer1, "textBoxAlternateDNSServer1")
		Me.textBoxAlternateDNSServer1.Name = "textBoxAlternateDNSServer1"
		AddHandler Me.textBoxAlternateDNSServer1.KeyPress, AddressOf Me.TextBoxAlternateDNSServer1KeyPress
		'
		'label21
		'
		resources.ApplyResources(Me.label21, "label21")
		Me.label21.BackColor = System.Drawing.SystemColors.Window
		Me.label21.Name = "label21"
		'
		'label22
		'
		resources.ApplyResources(Me.label22, "label22")
		Me.label22.BackColor = System.Drawing.SystemColors.Window
		Me.label22.Name = "label22"
		'
		'label23
		'
		resources.ApplyResources(Me.label23, "label23")
		Me.label23.BackColor = System.Drawing.SystemColors.Window
		Me.label23.Name = "label23"
		'
		'pictureBoxAlternateDNSServer
		'
		Me.pictureBoxAlternateDNSServer.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxAlternateDNSServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pictureBoxAlternateDNSServer, "pictureBoxAlternateDNSServer")
		Me.pictureBoxAlternateDNSServer.Name = "pictureBoxAlternateDNSServer"
		Me.pictureBoxAlternateDNSServer.TabStop = false
		'
		'textBoxPrimaryDNSServer4
		'
		Me.textBoxPrimaryDNSServer4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer4.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxPrimaryDNSServer4, "textBoxPrimaryDNSServer4")
		Me.textBoxPrimaryDNSServer4.Name = "textBoxPrimaryDNSServer4"
		Me.textBoxPrimaryDNSServer4.TabStop = false
		AddHandler Me.textBoxPrimaryDNSServer4.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer4KeyPress
		'
		'textBoxPrimaryDNSServer3
		'
		Me.textBoxPrimaryDNSServer3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer3.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxPrimaryDNSServer3, "textBoxPrimaryDNSServer3")
		Me.textBoxPrimaryDNSServer3.Name = "textBoxPrimaryDNSServer3"
		Me.textBoxPrimaryDNSServer3.TabStop = false
		AddHandler Me.textBoxPrimaryDNSServer3.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer3KeyPress
		'
		'textBoxPrimaryDNSServer2
		'
		Me.textBoxPrimaryDNSServer2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer2.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxPrimaryDNSServer2, "textBoxPrimaryDNSServer2")
		Me.textBoxPrimaryDNSServer2.Name = "textBoxPrimaryDNSServer2"
		Me.textBoxPrimaryDNSServer2.TabStop = false
		AddHandler Me.textBoxPrimaryDNSServer2.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer2KeyPress
		'
		'textBoxPrimaryDNSServer1
		'
		Me.textBoxPrimaryDNSServer1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxPrimaryDNSServer1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxPrimaryDNSServer1, "textBoxPrimaryDNSServer1")
		Me.textBoxPrimaryDNSServer1.Name = "textBoxPrimaryDNSServer1"
		AddHandler Me.textBoxPrimaryDNSServer1.KeyPress, AddressOf Me.TextBoxPrimaryDNSServer1KeyPress
		'
		'label18
		'
		resources.ApplyResources(Me.label18, "label18")
		Me.label18.BackColor = System.Drawing.SystemColors.Window
		Me.label18.Name = "label18"
		'
		'label19
		'
		resources.ApplyResources(Me.label19, "label19")
		Me.label19.BackColor = System.Drawing.SystemColors.Window
		Me.label19.Name = "label19"
		'
		'label20
		'
		resources.ApplyResources(Me.label20, "label20")
		Me.label20.BackColor = System.Drawing.SystemColors.Window
		Me.label20.Name = "label20"
		'
		'pictureBoxPrimaryDNSServer
		'
		Me.pictureBoxPrimaryDNSServer.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxPrimaryDNSServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pictureBoxPrimaryDNSServer, "pictureBoxPrimaryDNSServer")
		Me.pictureBoxPrimaryDNSServer.Name = "pictureBoxPrimaryDNSServer"
		Me.pictureBoxPrimaryDNSServer.TabStop = false
		'
		'textBoxDefaultGateway4
		'
		Me.textBoxDefaultGateway4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway4.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxDefaultGateway4, "textBoxDefaultGateway4")
		Me.textBoxDefaultGateway4.Name = "textBoxDefaultGateway4"
		Me.textBoxDefaultGateway4.TabStop = false
		AddHandler Me.textBoxDefaultGateway4.KeyPress, AddressOf Me.TextBoxDefaultGateway4KeyPress
		'
		'textBoxDefaultGateway3
		'
		Me.textBoxDefaultGateway3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway3.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxDefaultGateway3, "textBoxDefaultGateway3")
		Me.textBoxDefaultGateway3.Name = "textBoxDefaultGateway3"
		Me.textBoxDefaultGateway3.TabStop = false
		AddHandler Me.textBoxDefaultGateway3.KeyPress, AddressOf Me.TextBoxDefaultGateway3KeyPress
		'
		'textBoxDefaultGateway2
		'
		Me.textBoxDefaultGateway2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway2.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxDefaultGateway2, "textBoxDefaultGateway2")
		Me.textBoxDefaultGateway2.Name = "textBoxDefaultGateway2"
		Me.textBoxDefaultGateway2.TabStop = false
		AddHandler Me.textBoxDefaultGateway2.KeyPress, AddressOf Me.TextBoxDefaultGateway2KeyPress
		'
		'textBoxDefaultGateway1
		'
		Me.textBoxDefaultGateway1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxDefaultGateway1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxDefaultGateway1, "textBoxDefaultGateway1")
		Me.textBoxDefaultGateway1.Name = "textBoxDefaultGateway1"
		AddHandler Me.textBoxDefaultGateway1.KeyPress, AddressOf Me.TextBoxDefaultGateway1KeyPress
		'
		'label15
		'
		resources.ApplyResources(Me.label15, "label15")
		Me.label15.BackColor = System.Drawing.SystemColors.Window
		Me.label15.Name = "label15"
		'
		'label16
		'
		resources.ApplyResources(Me.label16, "label16")
		Me.label16.BackColor = System.Drawing.SystemColors.Window
		Me.label16.Name = "label16"
		'
		'label17
		'
		resources.ApplyResources(Me.label17, "label17")
		Me.label17.BackColor = System.Drawing.SystemColors.Window
		Me.label17.Name = "label17"
		'
		'pictureBoxDefaultGateway
		'
		Me.pictureBoxDefaultGateway.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxDefaultGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pictureBoxDefaultGateway, "pictureBoxDefaultGateway")
		Me.pictureBoxDefaultGateway.Name = "pictureBoxDefaultGateway"
		Me.pictureBoxDefaultGateway.TabStop = false
		'
		'textBoxSubnetMask4
		'
		Me.textBoxSubnetMask4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask4.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxSubnetMask4, "textBoxSubnetMask4")
		Me.textBoxSubnetMask4.Name = "textBoxSubnetMask4"
		Me.textBoxSubnetMask4.TabStop = false
		AddHandler Me.textBoxSubnetMask4.KeyPress, AddressOf Me.TextBoxSubnetMask4KeyPress
		'
		'textBoxSubnetMask3
		'
		Me.textBoxSubnetMask3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask3.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxSubnetMask3, "textBoxSubnetMask3")
		Me.textBoxSubnetMask3.Name = "textBoxSubnetMask3"
		Me.textBoxSubnetMask3.TabStop = false
		AddHandler Me.textBoxSubnetMask3.KeyPress, AddressOf Me.TextBoxSubnetMask3KeyPress
		'
		'textBoxSubnetMask2
		'
		Me.textBoxSubnetMask2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask2.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxSubnetMask2, "textBoxSubnetMask2")
		Me.textBoxSubnetMask2.Name = "textBoxSubnetMask2"
		Me.textBoxSubnetMask2.TabStop = false
		AddHandler Me.textBoxSubnetMask2.KeyPress, AddressOf Me.TextBoxSubnetMask2KeyPress
		'
		'textBoxSubnetMask1
		'
		Me.textBoxSubnetMask1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxSubnetMask1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxSubnetMask1, "textBoxSubnetMask1")
		Me.textBoxSubnetMask1.Name = "textBoxSubnetMask1"
		AddHandler Me.textBoxSubnetMask1.KeyPress, AddressOf Me.TextBoxSubnetMask1KeyPress
		'
		'label12
		'
		resources.ApplyResources(Me.label12, "label12")
		Me.label12.BackColor = System.Drawing.SystemColors.Window
		Me.label12.Name = "label12"
		'
		'label13
		'
		resources.ApplyResources(Me.label13, "label13")
		Me.label13.BackColor = System.Drawing.SystemColors.Window
		Me.label13.Name = "label13"
		'
		'label14
		'
		resources.ApplyResources(Me.label14, "label14")
		Me.label14.BackColor = System.Drawing.SystemColors.Window
		Me.label14.Name = "label14"
		'
		'pictureBoxSubnetMask
		'
		Me.pictureBoxSubnetMask.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pictureBoxSubnetMask, "pictureBoxSubnetMask")
		Me.pictureBoxSubnetMask.Name = "pictureBoxSubnetMask"
		Me.pictureBoxSubnetMask.TabStop = false
		'
		'labelWINSServer
		'
		resources.ApplyResources(Me.labelWINSServer, "labelWINSServer")
		Me.labelWINSServer.Name = "labelWINSServer"
		'
		'labelAlternateDNSServer
		'
		resources.ApplyResources(Me.labelAlternateDNSServer, "labelAlternateDNSServer")
		Me.labelAlternateDNSServer.Name = "labelAlternateDNSServer"
		'
		'labelPrimaryDNSServer
		'
		resources.ApplyResources(Me.labelPrimaryDNSServer, "labelPrimaryDNSServer")
		Me.labelPrimaryDNSServer.Name = "labelPrimaryDNSServer"
		'
		'labelDefaultGateway
		'
		resources.ApplyResources(Me.labelDefaultGateway, "labelDefaultGateway")
		Me.labelDefaultGateway.Name = "labelDefaultGateway"
		'
		'labelSubnetMask
		'
		resources.ApplyResources(Me.labelSubnetMask, "labelSubnetMask")
		Me.labelSubnetMask.Name = "labelSubnetMask"
		'
		'textBoxIPAddress4
		'
		Me.textBoxIPAddress4.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress4.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxIPAddress4, "textBoxIPAddress4")
		Me.textBoxIPAddress4.Name = "textBoxIPAddress4"
		Me.textBoxIPAddress4.TabStop = false
		AddHandler Me.textBoxIPAddress4.KeyPress, AddressOf Me.TextBoxIPAddress4KeyPress
		'
		'textBoxIPAddress3
		'
		Me.textBoxIPAddress3.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress3.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxIPAddress3, "textBoxIPAddress3")
		Me.textBoxIPAddress3.Name = "textBoxIPAddress3"
		Me.textBoxIPAddress3.TabStop = false
		AddHandler Me.textBoxIPAddress3.KeyPress, AddressOf Me.TextBoxIPAddress3KeyPress
		'
		'textBoxIPAddress2
		'
		Me.textBoxIPAddress2.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxIPAddress2, "textBoxIPAddress2")
		Me.textBoxIPAddress2.Name = "textBoxIPAddress2"
		Me.textBoxIPAddress2.TabStop = false
		AddHandler Me.textBoxIPAddress2.KeyPress, AddressOf Me.TextBoxIPAddress2KeyPress
		'
		'textBoxIPAddress1
		'
		Me.textBoxIPAddress1.BackColor = System.Drawing.SystemColors.Window
		Me.textBoxIPAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.textBoxIPAddress1, "textBoxIPAddress1")
		Me.textBoxIPAddress1.Name = "textBoxIPAddress1"
		AddHandler Me.textBoxIPAddress1.KeyPress, AddressOf Me.TextBoxIPAddress1KeyPress
		'
		'label9
		'
		resources.ApplyResources(Me.label9, "label9")
		Me.label9.BackColor = System.Drawing.SystemColors.Window
		Me.label9.Name = "label9"
		'
		'label8
		'
		resources.ApplyResources(Me.label8, "label8")
		Me.label8.BackColor = System.Drawing.SystemColors.Window
		Me.label8.Name = "label8"
		'
		'label7
		'
		resources.ApplyResources(Me.label7, "label7")
		Me.label7.BackColor = System.Drawing.SystemColors.Window
		Me.label7.Name = "label7"
		'
		'pictureBoxIPAddress
		'
		Me.pictureBoxIPAddress.BackColor = System.Drawing.SystemColors.Window
		Me.pictureBoxIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		resources.ApplyResources(Me.pictureBoxIPAddress, "pictureBoxIPAddress")
		Me.pictureBoxIPAddress.Name = "pictureBoxIPAddress"
		Me.pictureBoxIPAddress.TabStop = false
		'
		'labelIPAddress
		'
		resources.ApplyResources(Me.labelIPAddress, "labelIPAddress")
		Me.labelIPAddress.Name = "labelIPAddress"
		'
		'tabPageInternet
		'
		Me.tabPageInternet.Controls.Add(Me.groupBoxPleaseNote)
		Me.tabPageInternet.Controls.Add(Me.groupBoxAutoConfigAddress)
		Me.tabPageInternet.Controls.Add(Me.groupBoxWebBrowsers)
		Me.tabPageInternet.Controls.Add(Me.groupBoxProxy)
		Me.tabPageInternet.Controls.Add(Me.groupBoxHomepage)
		resources.ApplyResources(Me.tabPageInternet, "tabPageInternet")
		Me.tabPageInternet.Name = "tabPageInternet"
		Me.tabPageInternet.UseVisualStyleBackColor = true
		'
		'groupBoxPleaseNote
		'
		Me.groupBoxPleaseNote.Controls.Add(Me.labelPleaseNote)
		resources.ApplyResources(Me.groupBoxPleaseNote, "groupBoxPleaseNote")
		Me.groupBoxPleaseNote.Name = "groupBoxPleaseNote"
		Me.groupBoxPleaseNote.TabStop = false
		'
		'labelPleaseNote
		'
		resources.ApplyResources(Me.labelPleaseNote, "labelPleaseNote")
		Me.labelPleaseNote.Name = "labelPleaseNote"
		'
		'groupBoxAutoConfigAddress
		'
		Me.groupBoxAutoConfigAddress.Controls.Add(Me.textBoxAutoConfigAddress)
		resources.ApplyResources(Me.groupBoxAutoConfigAddress, "groupBoxAutoConfigAddress")
		Me.groupBoxAutoConfigAddress.Name = "groupBoxAutoConfigAddress"
		Me.groupBoxAutoConfigAddress.TabStop = false
		'
		'textBoxAutoConfigAddress
		'
		resources.ApplyResources(Me.textBoxAutoConfigAddress, "textBoxAutoConfigAddress")
		Me.textBoxAutoConfigAddress.Name = "textBoxAutoConfigAddress"
		'
		'groupBoxWebBrowsers
		'
		Me.groupBoxWebBrowsers.Controls.Add(Me.checkBoxIE)
		Me.groupBoxWebBrowsers.Controls.Add(Me.checkBoxFirefox)
		resources.ApplyResources(Me.groupBoxWebBrowsers, "groupBoxWebBrowsers")
		Me.groupBoxWebBrowsers.Name = "groupBoxWebBrowsers"
		Me.groupBoxWebBrowsers.TabStop = false
		'
		'checkBoxIE
		'
		resources.ApplyResources(Me.checkBoxIE, "checkBoxIE")
		Me.checkBoxIE.Name = "checkBoxIE"
		Me.checkBoxIE.UseVisualStyleBackColor = true
		'
		'checkBoxFirefox
		'
		resources.ApplyResources(Me.checkBoxFirefox, "checkBoxFirefox")
		Me.checkBoxFirefox.Name = "checkBoxFirefox"
		Me.checkBoxFirefox.UseVisualStyleBackColor = true
		'
		'groupBoxProxy
		'
		Me.groupBoxProxy.Controls.Add(Me.checkBoxBypassProxyForLocalAddresses)
		Me.groupBoxProxy.Controls.Add(Me.textBoxExceptions)
		Me.groupBoxProxy.Controls.Add(Me.textBoxServerAddress)
		Me.groupBoxProxy.Controls.Add(Me.labelExceptions)
		Me.groupBoxProxy.Controls.Add(Me.labelServerAddress)
		Me.groupBoxProxy.Controls.Add(Me.checkBoxUseProxySettings)
		resources.ApplyResources(Me.groupBoxProxy, "groupBoxProxy")
		Me.groupBoxProxy.Name = "groupBoxProxy"
		Me.groupBoxProxy.TabStop = false
		'
		'checkBoxBypassProxyForLocalAddresses
		'
		resources.ApplyResources(Me.checkBoxBypassProxyForLocalAddresses, "checkBoxBypassProxyForLocalAddresses")
		Me.checkBoxBypassProxyForLocalAddresses.Name = "checkBoxBypassProxyForLocalAddresses"
		Me.checkBoxBypassProxyForLocalAddresses.UseVisualStyleBackColor = true
		'
		'textBoxExceptions
		'
		resources.ApplyResources(Me.textBoxExceptions, "textBoxExceptions")
		Me.textBoxExceptions.Name = "textBoxExceptions"
		'
		'textBoxServerAddress
		'
		resources.ApplyResources(Me.textBoxServerAddress, "textBoxServerAddress")
		Me.textBoxServerAddress.Name = "textBoxServerAddress"
		Me.toolTip1.SetToolTip(Me.textBoxServerAddress, resources.GetString("textBoxServerAddress.ToolTip"))
		'
		'labelExceptions
		'
		resources.ApplyResources(Me.labelExceptions, "labelExceptions")
		Me.labelExceptions.Name = "labelExceptions"
		Me.toolTip1.SetToolTip(Me.labelExceptions, resources.GetString("labelExceptions.ToolTip"))
		'
		'labelServerAddress
		'
		resources.ApplyResources(Me.labelServerAddress, "labelServerAddress")
		Me.labelServerAddress.Name = "labelServerAddress"
		'
		'checkBoxUseProxySettings
		'
		resources.ApplyResources(Me.checkBoxUseProxySettings, "checkBoxUseProxySettings")
		Me.checkBoxUseProxySettings.Name = "checkBoxUseProxySettings"
		Me.checkBoxUseProxySettings.UseVisualStyleBackColor = true
		AddHandler Me.checkBoxUseProxySettings.CheckedChanged, AddressOf Me.CheckBoxUseProxySettingsCheckedChanged
		'
		'groupBoxHomepage
		'
		Me.groupBoxHomepage.Controls.Add(Me.labelHomepageNote)
		Me.groupBoxHomepage.Controls.Add(Me.buttonUseBlankHomepage)
		Me.groupBoxHomepage.Controls.Add(Me.textBoxDefaultHomepage)
		resources.ApplyResources(Me.groupBoxHomepage, "groupBoxHomepage")
		Me.groupBoxHomepage.Name = "groupBoxHomepage"
		Me.groupBoxHomepage.TabStop = false
		'
		'labelHomepageNote
		'
		resources.ApplyResources(Me.labelHomepageNote, "labelHomepageNote")
		Me.labelHomepageNote.Name = "labelHomepageNote"
		'
		'buttonUseBlankHomepage
		'
		resources.ApplyResources(Me.buttonUseBlankHomepage, "buttonUseBlankHomepage")
		Me.buttonUseBlankHomepage.Name = "buttonUseBlankHomepage"
		Me.buttonUseBlankHomepage.UseVisualStyleBackColor = true
		AddHandler Me.buttonUseBlankHomepage.Click, AddressOf Me.ButtonUseBlankHomepageClick
		'
		'textBoxDefaultHomepage
		'
		resources.ApplyResources(Me.textBoxDefaultHomepage, "textBoxDefaultHomepage")
		Me.textBoxDefaultHomepage.Name = "textBoxDefaultHomepage"
		'
		'tabPageMappedDrives
		'
		Me.tabPageMappedDrives.Controls.Add(Me.listViewMappedDrives)
		Me.tabPageMappedDrives.Controls.Add(Me.toolStripMappedDrives)
		resources.ApplyResources(Me.tabPageMappedDrives, "tabPageMappedDrives")
		Me.tabPageMappedDrives.Name = "tabPageMappedDrives"
		Me.tabPageMappedDrives.UseVisualStyleBackColor = true
		'
		'listViewMappedDrives
		'
		Me.listViewMappedDrives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderDrive, Me.columnHeaderPath, Me.columnHeaderUsername, Me.columnHeaderPassword})
		resources.ApplyResources(Me.listViewMappedDrives, "listViewMappedDrives")
		Me.listViewMappedDrives.FullRowSelect = true
		Me.listViewMappedDrives.GridLines = true
		Me.listViewMappedDrives.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.listViewMappedDrives.HideSelection = false
		Me.listViewMappedDrives.MultiSelect = false
		Me.listViewMappedDrives.Name = "listViewMappedDrives"
		Me.listViewMappedDrives.SmallImageList = Me.imageListDrives
		Me.listViewMappedDrives.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.listViewMappedDrives.UseCompatibleStateImageBehavior = false
		Me.listViewMappedDrives.View = System.Windows.Forms.View.Details
		'
		'columnHeaderDrive
		'
		resources.ApplyResources(Me.columnHeaderDrive, "columnHeaderDrive")
		'
		'columnHeaderPath
		'
		resources.ApplyResources(Me.columnHeaderPath, "columnHeaderPath")
		'
		'columnHeaderUsername
		'
		resources.ApplyResources(Me.columnHeaderUsername, "columnHeaderUsername")
		'
		'columnHeaderPassword
		'
		resources.ApplyResources(Me.columnHeaderPassword, "columnHeaderPassword")
		'
		'imageListDrives
		'
		Me.imageListDrives.ImageStream = CType(resources.GetObject("imageListDrives.ImageStream"),System.Windows.Forms.ImageListStreamer)
		Me.imageListDrives.TransparentColor = System.Drawing.Color.Transparent
		Me.imageListDrives.Images.SetKeyName(0, "drive_network.png")
		'
		'toolStripMappedDrives
		'
		resources.ApplyResources(Me.toolStripMappedDrives, "toolStripMappedDrives")
		Me.toolStripMappedDrives.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.toolStripMappedDrives.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonAddDrive, Me.toolStripSeparator1, Me.toolStripButtonEditDrive, Me.toolStripButtonRemoveDrive})
		Me.toolStripMappedDrives.Name = "toolStripMappedDrives"
		'
		'toolStripButtonAddDrive
		'
		resources.ApplyResources(Me.toolStripButtonAddDrive, "toolStripButtonAddDrive")
		Me.toolStripButtonAddDrive.Name = "toolStripButtonAddDrive"
		AddHandler Me.toolStripButtonAddDrive.Click, AddressOf Me.ToolStripButtonAddDriveClick
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
		'
		'toolStripButtonEditDrive
		'
		resources.ApplyResources(Me.toolStripButtonEditDrive, "toolStripButtonEditDrive")
		Me.toolStripButtonEditDrive.Name = "toolStripButtonEditDrive"
		AddHandler Me.toolStripButtonEditDrive.Click, AddressOf Me.ToolStripButtonEditDriveClick
		'
		'toolStripButtonRemoveDrive
		'
		resources.ApplyResources(Me.toolStripButtonRemoveDrive, "toolStripButtonRemoveDrive")
		Me.toolStripButtonRemoveDrive.Name = "toolStripButtonRemoveDrive"
		AddHandler Me.toolStripButtonRemoveDrive.Click, AddressOf Me.ToolStripButtonRemoveDriveClick
		'
		'tabPagePrinter
		'
		Me.tabPagePrinter.Controls.Add(Me.groupBoxPrinter)
		resources.ApplyResources(Me.tabPagePrinter, "tabPagePrinter")
		Me.tabPagePrinter.Name = "tabPagePrinter"
		Me.tabPagePrinter.UseVisualStyleBackColor = true
		'
		'groupBoxPrinter
		'
		Me.groupBoxPrinter.Controls.Add(Me.comboBoxPrinters)
		Me.groupBoxPrinter.Controls.Add(Me.buttonGetDefaultPrinter)
		resources.ApplyResources(Me.groupBoxPrinter, "groupBoxPrinter")
		Me.groupBoxPrinter.Name = "groupBoxPrinter"
		Me.groupBoxPrinter.TabStop = false
		'
		'comboBoxPrinters
		'
		Me.comboBoxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		resources.ApplyResources(Me.comboBoxPrinters, "comboBoxPrinters")
		Me.comboBoxPrinters.FormattingEnabled = true
		Me.comboBoxPrinters.Name = "comboBoxPrinters"
		'
		'buttonGetDefaultPrinter
		'
		resources.ApplyResources(Me.buttonGetDefaultPrinter, "buttonGetDefaultPrinter")
		Me.buttonGetDefaultPrinter.Name = "buttonGetDefaultPrinter"
		Me.buttonGetDefaultPrinter.UseVisualStyleBackColor = true
		AddHandler Me.buttonGetDefaultPrinter.Click, AddressOf Me.ButtonGetDefaultPrinterClick
		'
		'tabPageRun
		'
		Me.tabPageRun.Controls.Add(Me.listViewRun)
		Me.tabPageRun.Controls.Add(Me.toolStripRun)
		resources.ApplyResources(Me.tabPageRun, "tabPageRun")
		Me.tabPageRun.Name = "tabPageRun"
		Me.tabPageRun.UseVisualStyleBackColor = true
		'
		'listViewRun
		'
		Me.listViewRun.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeaderRunPath, Me.columnHeaderRunArguments, Me.columnHeaderRunRun, Me.columnHeaderRunUsername, Me.columnHeaderRunPassword, Me.columnHeaderRunDomain})
		resources.ApplyResources(Me.listViewRun, "listViewRun")
		Me.listViewRun.FullRowSelect = true
		Me.listViewRun.GridLines = true
		Me.listViewRun.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
		Me.listViewRun.HideSelection = false
		Me.listViewRun.MultiSelect = false
		Me.listViewRun.Name = "listViewRun"
		Me.listViewRun.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.listViewRun.UseCompatibleStateImageBehavior = false
		Me.listViewRun.View = System.Windows.Forms.View.Details
		'
		'columnHeaderRunPath
		'
		resources.ApplyResources(Me.columnHeaderRunPath, "columnHeaderRunPath")
		'
		'columnHeaderRunArguments
		'
		resources.ApplyResources(Me.columnHeaderRunArguments, "columnHeaderRunArguments")
		'
		'columnHeaderRunRun
		'
		resources.ApplyResources(Me.columnHeaderRunRun, "columnHeaderRunRun")
		'
		'columnHeaderRunUsername
		'
		resources.ApplyResources(Me.columnHeaderRunUsername, "columnHeaderRunUsername")
		'
		'columnHeaderRunPassword
		'
		resources.ApplyResources(Me.columnHeaderRunPassword, "columnHeaderRunPassword")
		'
		'columnHeaderRunDomain
		'
		resources.ApplyResources(Me.columnHeaderRunDomain, "columnHeaderRunDomain")
		'
		'toolStripRun
		'
		resources.ApplyResources(Me.toolStripRun, "toolStripRun")
		Me.toolStripRun.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.toolStripRun.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonAddProgram, Me.toolStripSeparator2, Me.toolStripButtonEditProgram, Me.toolStripButtonRemoveProgram})
		Me.toolStripRun.Name = "toolStripRun"
		'
		'toolStripButtonAddProgram
		'
		resources.ApplyResources(Me.toolStripButtonAddProgram, "toolStripButtonAddProgram")
		Me.toolStripButtonAddProgram.Name = "toolStripButtonAddProgram"
		AddHandler Me.toolStripButtonAddProgram.Click, AddressOf Me.ToolStripButtonAddProgramClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
		'
		'toolStripButtonEditProgram
		'
		resources.ApplyResources(Me.toolStripButtonEditProgram, "toolStripButtonEditProgram")
		Me.toolStripButtonEditProgram.Name = "toolStripButtonEditProgram"
		AddHandler Me.toolStripButtonEditProgram.Click, AddressOf Me.ToolStripButtonEditProgramClick
		'
		'toolStripButtonRemoveProgram
		'
		resources.ApplyResources(Me.toolStripButtonRemoveProgram, "toolStripButtonRemoveProgram")
		Me.toolStripButtonRemoveProgram.Name = "toolStripButtonRemoveProgram"
		AddHandler Me.toolStripButtonRemoveProgram.Click, AddressOf Me.ToolStripButtonRemoveProgramClick
		'
		'tabPageDesktop
		'
		Me.tabPageDesktop.Controls.Add(Me.groupBoxDisplaySettings)
		Me.tabPageDesktop.Controls.Add(Me.groupBoxWallpaper)
		resources.ApplyResources(Me.tabPageDesktop, "tabPageDesktop")
		Me.tabPageDesktop.Name = "tabPageDesktop"
		Me.tabPageDesktop.UseVisualStyleBackColor = true
		'
		'groupBoxDisplaySettings
		'
		Me.groupBoxDisplaySettings.Controls.Add(Me.labelScreenResolution)
		Me.groupBoxDisplaySettings.Controls.Add(Me.buttonGetCurrentDisplaySettings)
		Me.groupBoxDisplaySettings.Controls.Add(Me.comboBoxDisplaySettings)
		resources.ApplyResources(Me.groupBoxDisplaySettings, "groupBoxDisplaySettings")
		Me.groupBoxDisplaySettings.Name = "groupBoxDisplaySettings"
		Me.groupBoxDisplaySettings.TabStop = false
		'
		'labelScreenResolution
		'
		resources.ApplyResources(Me.labelScreenResolution, "labelScreenResolution")
		Me.labelScreenResolution.Name = "labelScreenResolution"
		'
		'buttonGetCurrentDisplaySettings
		'
		Me.buttonGetCurrentDisplaySettings.AutoEllipsis = true
		resources.ApplyResources(Me.buttonGetCurrentDisplaySettings, "buttonGetCurrentDisplaySettings")
		Me.buttonGetCurrentDisplaySettings.Name = "buttonGetCurrentDisplaySettings"
		Me.buttonGetCurrentDisplaySettings.UseVisualStyleBackColor = true
		AddHandler Me.buttonGetCurrentDisplaySettings.Click, AddressOf Me.ButtonGetCurrentDisplaySettingsClick
		'
		'comboBoxDisplaySettings
		'
		Me.comboBoxDisplaySettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		resources.ApplyResources(Me.comboBoxDisplaySettings, "comboBoxDisplaySettings")
		Me.comboBoxDisplaySettings.FormattingEnabled = true
		Me.comboBoxDisplaySettings.Name = "comboBoxDisplaySettings"
		'
		'groupBoxWallpaper
		'
		Me.groupBoxWallpaper.Controls.Add(Me.groupBoxWallpaperPreview)
		Me.groupBoxWallpaper.Controls.Add(Me.buttonResetWallpaper)
		Me.groupBoxWallpaper.Controls.Add(Me.buttonBrowseWallpaper)
		Me.groupBoxWallpaper.Controls.Add(Me.textBoxWallpaperPath)
		resources.ApplyResources(Me.groupBoxWallpaper, "groupBoxWallpaper")
		Me.groupBoxWallpaper.Name = "groupBoxWallpaper"
		Me.groupBoxWallpaper.TabStop = false
		'
		'groupBoxWallpaperPreview
		'
		resources.ApplyResources(Me.groupBoxWallpaperPreview, "groupBoxWallpaperPreview")
		Me.groupBoxWallpaperPreview.Controls.Add(Me.pictureBoxWallpaperPreview)
		Me.groupBoxWallpaperPreview.Name = "groupBoxWallpaperPreview"
		Me.groupBoxWallpaperPreview.TabStop = false
		'
		'pictureBoxWallpaperPreview
		'
		resources.ApplyResources(Me.pictureBoxWallpaperPreview, "pictureBoxWallpaperPreview")
		Me.pictureBoxWallpaperPreview.Name = "pictureBoxWallpaperPreview"
		Me.pictureBoxWallpaperPreview.TabStop = false
		'
		'buttonResetWallpaper
		'
		resources.ApplyResources(Me.buttonResetWallpaper, "buttonResetWallpaper")
		Me.buttonResetWallpaper.Name = "buttonResetWallpaper"
		Me.toolTip1.SetToolTip(Me.buttonResetWallpaper, resources.GetString("buttonResetWallpaper.ToolTip"))
		Me.buttonResetWallpaper.UseVisualStyleBackColor = true
		AddHandler Me.buttonResetWallpaper.Click, AddressOf Me.ButtonResetWallpaperClick
		'
		'buttonBrowseWallpaper
		'
		resources.ApplyResources(Me.buttonBrowseWallpaper, "buttonBrowseWallpaper")
		Me.buttonBrowseWallpaper.Name = "buttonBrowseWallpaper"
		Me.toolTip1.SetToolTip(Me.buttonBrowseWallpaper, resources.GetString("buttonBrowseWallpaper.ToolTip"))
		Me.buttonBrowseWallpaper.UseVisualStyleBackColor = true
		AddHandler Me.buttonBrowseWallpaper.Click, AddressOf Me.ButtonBrowseWallpaperClick
		'
		'textBoxWallpaperPath
		'
		Me.textBoxWallpaperPath.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.textBoxWallpaperPath, "textBoxWallpaperPath")
		Me.textBoxWallpaperPath.Name = "textBoxWallpaperPath"
		Me.textBoxWallpaperPath.ReadOnly = true
		'
		'tabPageWireless
		'
		Me.tabPageWireless.Controls.Add(Me.groupBoxWireless)
		resources.ApplyResources(Me.tabPageWireless, "tabPageWireless")
		Me.tabPageWireless.Name = "tabPageWireless"
		Me.tabPageWireless.UseVisualStyleBackColor = true
		'
		'groupBoxWireless
		'
		Me.groupBoxWireless.Controls.Add(Me.labelSSID)
		Me.groupBoxWireless.Controls.Add(Me.labelSSIDNotes)
		Me.groupBoxWireless.Controls.Add(Me.textBoxAutoActivateSSID)
		resources.ApplyResources(Me.groupBoxWireless, "groupBoxWireless")
		Me.groupBoxWireless.Name = "groupBoxWireless"
		Me.groupBoxWireless.TabStop = false
		'
		'labelSSID
		'
		resources.ApplyResources(Me.labelSSID, "labelSSID")
		Me.labelSSID.Name = "labelSSID"
		'
		'labelSSIDNotes
		'
		resources.ApplyResources(Me.labelSSIDNotes, "labelSSIDNotes")
		Me.labelSSIDNotes.Name = "labelSSIDNotes"
		'
		'textBoxAutoActivateSSID
		'
		resources.ApplyResources(Me.textBoxAutoActivateSSID, "textBoxAutoActivateSSID")
		Me.textBoxAutoActivateSSID.Name = "textBoxAutoActivateSSID"
		'
		'buttonClose
		'
		resources.ApplyResources(Me.buttonClose, "buttonClose")
		Me.buttonClose.Name = "buttonClose"
		Me.buttonClose.UseVisualStyleBackColor = true
		AddHandler Me.buttonClose.Click, AddressOf Me.ButtonCloseClick
		'
		'buttonSave
		'
		resources.ApplyResources(Me.buttonSave, "buttonSave")
		Me.buttonSave.Name = "buttonSave"
		Me.buttonSave.UseVisualStyleBackColor = true
		AddHandler Me.buttonSave.Click, AddressOf Me.ButtonSaveClick
		'
		'labelProfileName
		'
		resources.ApplyResources(Me.labelProfileName, "labelProfileName")
		Me.labelProfileName.Name = "labelProfileName"
		'
		'textBoxProfileName
		'
		resources.ApplyResources(Me.textBoxProfileName, "textBoxProfileName")
		Me.textBoxProfileName.Name = "textBoxProfileName"
		'
		'labelNetworkCard
		'
		resources.ApplyResources(Me.labelNetworkCard, "labelNetworkCard")
		Me.labelNetworkCard.Name = "labelNetworkCard"
		'
		'comboBoxNetworkCards
		'
		Me.comboBoxNetworkCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxNetworkCards.FormattingEnabled = true
		resources.ApplyResources(Me.comboBoxNetworkCards, "comboBoxNetworkCards")
		Me.comboBoxNetworkCards.Name = "comboBoxNetworkCards"
		'
		'progressBar1
		'
		resources.ApplyResources(Me.progressBar1, "progressBar1")
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'labelWorking
		'
		resources.ApplyResources(Me.labelWorking, "labelWorking")
		Me.labelWorking.Name = "labelWorking"
		'
		'ProfileSettings
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.labelWorking)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.comboBoxNetworkCards)
		Me.Controls.Add(Me.labelNetworkCard)
		Me.Controls.Add(Me.textBoxProfileName)
		Me.Controls.Add(Me.labelProfileName)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonClose)
		Me.Controls.Add(Me.tabControl1)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "ProfileSettings"
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
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
	Private textBoxDNSSuffix As System.Windows.Forms.TextBox
	Private labelDNSSuffix As System.Windows.Forms.Label
	Private labelPleaseNote As System.Windows.Forms.Label
	Private groupBoxPleaseNote As System.Windows.Forms.GroupBox
	Private groupBoxWallpaperPreview As System.Windows.Forms.GroupBox
	Private pictureBoxWallpaperPreview As System.Windows.Forms.PictureBox
	Private textBoxAutoConfigAddress As System.Windows.Forms.TextBox
	Private groupBoxAutoConfigAddress As System.Windows.Forms.GroupBox
	Private checkBoxBypassProxyForLocalAddresses As System.Windows.Forms.CheckBox
	Private groupBoxWallpaper As System.Windows.Forms.GroupBox
	Private groupBoxDisplaySettings As System.Windows.Forms.GroupBox
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
	Private groupBoxWebBrowsers As System.Windows.Forms.GroupBox
	Private checkBoxIE As System.Windows.Forms.CheckBox
	Private checkBoxFirefox As System.Windows.Forms.CheckBox
	Private textBoxAutoActivateSSID As System.Windows.Forms.TextBox
	Private buttonGetCurrentDisplaySettings As System.Windows.Forms.Button
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
	Private labelExceptions As System.Windows.Forms.Label
	Private textBoxServerAddress As System.Windows.Forms.TextBox
	Private textBoxExceptions As System.Windows.Forms.TextBox
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
