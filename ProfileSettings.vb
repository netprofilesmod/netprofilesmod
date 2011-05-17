'
' Created by SharpDevelop.
' User: Daniel Milner
' Date: 1/26/2007
' Time: 10:18 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Management
Imports System.Drawing.Printing
Imports Microsoft.Win32
Imports System.Xml
Imports System.Globalization
Imports System.Threading
Imports System.IO

Public Partial Class ProfileSettings
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Public ClearFirefox_Messagebox_1 As String
	Public ClearFirefox_Messagebox_2 As String
	Public openFileDialogWallpaper_Title As String
	Public openFileDialogWallpaper_Filter As String
	Public labelWorking_NetworkCards As String
	Public labelWorking_Profile As String
	Public labelWorking_Printer As String
	Public ProfileName_Messagebox As String
	
	Sub ButtonCloseClick(ByVal sender As Object, ByVal e As EventArgs)
		'Me.Dispose
		Me.Close
		'Me.Refresh
	End Sub
	
	Sub ProfileSettingsLoad(ByVal sender As Object, ByVal e As EventArgs)
        Me.Opacity = Double.MaxValue
		Me.progressBar1.Visible = True
		Me.labelWorking.Visible = True
		Me.timer1.Enabled = True
		If My.Computer.Info.OSFullName.Contains("Vista") Then
			Me.tabControl1.TabPages.Item(6).Enabled = False
			Me.labelWirelessVista.Visible = True
		Else
			Me.tabControl1.TabPages.Item(6).Enabled = True
			Me.labelWirelessVista.Visible = False
		End If
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.Text = root.SelectSingleNode("/Language/ProfileSettings/WindowTitle").InnerText
		Me.labelProfileName.Text = root.SelectSingleNode("/Language/ProfileSettings/labelProfileName").InnerText
		Me.labelNetworkCard.Text = root.SelectSingleNode("/Language/ProfileSettings/labelNetworkCard").InnerText
		Me.tabPageIPSettings.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPageIPSettings").InnerText
		Me.tabPageInternet.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPageInternet").InnerText
		Me.tabPageMappedDrives.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPageMappedDrives").InnerText
		Me.tabPagePrinter.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPagePrinter").InnerText
		Me.tabPageRun.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPageRun").InnerText
		Me.tabPageDesktop.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPageDesktop").InnerText
		Me.tabPageWireless.Text = root.SelectSingleNode("/Language/ProfileSettings/tabPageWireless").InnerText
		Me.checkBoxDHCP.Text = root.SelectSingleNode("/Language/ProfileSettings/checkBoxDHCP").InnerText
		Me.labelIPAddress.Text = root.SelectSingleNode("/Language/ProfileSettings/labelIPAddress").InnerText
		Me.labelSubnetMask.Text = root.SelectSingleNode("/Language/ProfileSettings/labelSubnetMask").InnerText
		Me.labelDefaultGateway.Text = root.SelectSingleNode("/Language/ProfileSettings/labelDefaultGateway").InnerText
		Me.labelPrimaryDNSServer.Text = root.SelectSingleNode("/Language/ProfileSettings/labelPrimaryDNSServer").InnerText
		Me.labelAlternateDNSServer.Text = root.SelectSingleNode("/Language/ProfileSettings/labelAlternateDNSServer").InnerText
		Me.labelWINSServer.Text = root.SelectSingleNode("/Language/ProfileSettings/labelWINSServer").InnerText
		Me.buttonGetCurrentIPSettings.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonGetCurrentIPSettings").InnerText
		Me.groupBoxProxy.Text = "    " & root.SelectSingleNode("/Language/ProfileSettings/groupBoxProxy").InnerText
		Me.labelServerAddress.Text = root.SelectSingleNode("/Language/ProfileSettings/labelServerAddress").InnerText
		Me.labelPort.Text = root.SelectSingleNode("/Language/ProfileSettings/labelPort").InnerText
		Me.groupBoxHomepage.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxHomepage").InnerText
		Me.buttonUseBlankHomepage.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonUseBlankHomepage").InnerText
		Me.labelHomepageNote.Text = root.SelectSingleNode("/Language/ProfileSettings/labelHomepageNote").InnerText
		Me.groupBoxWebBrowsers.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxWebBrowsers").InnerText
		Me.buttonClearFirefox.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonClearFirefox").InnerText
		Me.toolTip1.SetToolTip(Me.buttonClearFirefox, root.SelectSingleNode("/Language/ProfileSettings/buttonClearFirefox-ToolTip").InnerText)
		Me.checkBoxIE.Text = root.SelectSingleNode("/Language/ProfileSettings/checkBoxIE").InnerText
		Me.checkBoxFirefox.Text = root.SelectSingleNode("/Language/ProfileSettings/checkBoxFirefox").InnerText
		Me.checkBoxOpera.Text = root.SelectSingleNode("/Language/ProfileSettings/checkBoxOpera").InnerText
		Me.groupBoxPleaseNote.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxPleaseNote").InnerText
		Me.labelPleaseNote.Text = root.SelectSingleNode("/Language/ProfileSettings/labelPleaseNote").InnerText
		Me.ClearFirefox_Messagebox_1 = root.SelectSingleNode("/Language/ProfileSettings/ClearFirefox-Messagebox-1").InnerText
		Me.ClearFirefox_Messagebox_2 = root.SelectSingleNode("/Language/ProfileSettings/ClearFirefox-Messagebox-2").InnerText
		Me.toolStripButtonAddDrive.Text = root.SelectSingleNode("/Language/ProfileSettings/toolStripButtonAddDrive").InnerText
		Me.toolStripButtonEditDrive.Text = root.SelectSingleNode("/Language/ProfileSettings/toolStripButtonEditDrive").InnerText
		Me.toolStripButtonRemoveDrive.Text = root.SelectSingleNode("/Language/ProfileSettings/toolStripButtonRemoveDrive").InnerText
		Me.groupBoxPrinter.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxPrinter").InnerText
		Me.buttonGetDefaultPrinter.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonGetDefaultPrinter").InnerText
		Me.toolStripButtonAddProgram.Text = root.SelectSingleNode("/Language/ProfileSettings/toolStripButtonAddProgram").InnerText
		Me.toolStripButtonEditProgram.Text = root.SelectSingleNode("/Language/ProfileSettings/toolStripButtonEditProgram").InnerText
		Me.toolStripButtonRemoveProgram.Text = root.SelectSingleNode("/Language/ProfileSettings/toolStripButtonRemoveProgram").InnerText
		Me.groupBoxWallpaper.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxWallpaper").InnerText
		Me.groupBoxWallpaperPreview.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxWallpaperPreview").InnerText
		Me.toolTip1.SetToolTip(Me.buttonBrowseWallpaper, root.SelectSingleNode("/Language/ProfileSettings/buttonBrowseWallpaper-ToolTip").InnerText)
		Me.openFileDialogWallpaper_Title = root.SelectSingleNode("/Language/ProfileSettings/openFileDialogWallpaper-Title").InnerText
		Me.openFileDialogWallpaper_Filter = root.SelectSingleNode("/Language/ProfileSettings/openFileDialogWallpaper-Filter").InnerText
		Me.toolTip1.SetToolTip(Me.buttonResetWallpaper, root.SelectSingleNode("/Language/ProfileSettings/buttonResetWallpaper-ToolTip").InnerText)
		Me.groupBoxDisplaySettings.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxDisplaySettings").InnerText
		Me.labelScreenResolution.Text = root.SelectSingleNode("/Language/ProfileSettings/labelScreenResolution").InnerText
		Me.labelColorQuality.Text = root.SelectSingleNode("/Language/ProfileSettings/labelColorQuality").InnerText
		Me.buttonGetCurrentDisplaySettings.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonGetCurrentDisplaySettings").InnerText
		Me.groupBoxWireless.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxWireless").InnerText
		Me.labelSSID.Text = root.SelectSingleNode("/Language/ProfileSettings/labelSSID").InnerText
		Me.labelSSIDNotes.Text = root.SelectSingleNode("/Language/ProfileSettings/labelSSIDNotes").InnerText
		Me.labelWirelessVista.Text = root.SelectSingleNode("/Language/ProfileSettings/labelWirelessVista").InnerText
		Me.buttonSave.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonSave").InnerText
		Me.buttonClose.Text = root.SelectSingleNode("/Language/ProfileSettings/buttonClose").InnerText
		Me.labelWorking_NetworkCards = root.SelectSingleNode("/Language/ProfileSettings/labelWorking-NetworkCards").InnerText
		Me.labelWorking_Profile = root.SelectSingleNode("/Language/ProfileSettings/labelWorking-Profile").InnerText
		Me.labelWorking_Printer = root.SelectSingleNode("/Language/ProfileSettings/labelWorking-Printer").InnerText
		Me.ProfileName_Messagebox = root.SelectSingleNode("/Language/ProfileSettings/ProfileName-Messagebox").InnerText
		Me.checkBoxBypassProxyForLocalAddresses.Text = root.SelectSingleNode("/Language/ProfileSettings/checkBoxBypassProxy").InnerText
		Me.groupBoxAutoConfigAddress.Text = root.SelectSingleNode("/Language/ProfileSettings/groupBoxAutoConfigAddress").InnerText
	End Sub
	
	Public Sub PopulateNetworkCards()		
		Try
			Me.labelWorking.Text = Me.labelWorking_NetworkCards
			Application.DoEvents()
			Me.comboBoxNetworkCards.DataSource = NetworkCardList
			Me.comboBoxNetworkCards.DisplayMember = "Value"
			Me.comboBoxNetworkCards.ValueMember = "Key"
			
            Catch err As ManagementException
                'Nothing
		End Try
	End Sub
	
	Sub ButtonSaveClick(ByVal sender As Object, ByVal e As EventArgs)
        If Me.textBoxProfileName.Text.Trim.Length = 0 Then
        	MessageBox.Show(Me.ProfileName_Messagebox, "Net Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
        	Me.textBoxProfileName.Focus()
        	Exit Sub
        End If
        
        If Dir(My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-"), FileAttribute.Directory) = "" Then
			MkDir((My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-")))
		End If
        
        Dim ThisINIFile As String
        If Globals.CreatingNewProfile = True Then
        	ThisINIFile = My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-") & "\" & System.Guid.NewGuid.ToString & ".ini"
        Else
        	ThisINIFile = My.Application.Info.DirectoryPath & "\profiles\" & MainForm.listViewProfiles.SelectedItems.Item(0).Group.Name.ToString & "\" & MainForm.listViewProfiles.SelectedItems(0).SubItems(2).Text
        End If
        
        '*** SAVE PROFILE NAME ***
        INIWrite(ThisINIFile, "General", "Name", Me.textBoxProfileName.Text.Trim)
        
        '*** SAVE IP ADDRESS ***
        Dim IPAddressEntry as String
        If Me.textBoxIPAddress1.Text = "" Or Me.textBoxIPAddress2.Text = "" Or Me.textBoxIPAddress3.Text = "" Or Me.textBoxIPAddress4.Text = "" Then
        	IPAddressEntry = ""
        Else
        	IPAddressEntry = Me.textBoxIPAddress1.Text & "." & Me.textBoxIPAddress2.Text & "." & Me.textBoxIPAddress3.Text & "." & Me.textBoxIPAddress4.Text
        End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "IP Address", IPAddressEntry)

        '*** SAVE SUBNET MASK ***
        Dim SubnetMaskEntry as String
        If Me.textBoxSubnetMask1.Text = "" Or Me.textBoxSubnetMask2.Text = "" Or Me.textBoxSubnetMask3.Text = "" Or Me.textBoxSubnetMask4.Text = "" Then
        	SubnetMaskEntry = ""
        Else
        	SubnetMaskEntry = Me.textBoxSubnetMask1.Text & "." & Me.textBoxSubnetMask2.Text & "." & Me.textBoxSubnetMask3.Text & "." & Me.textBoxSubnetMask4.Text
        End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "Subnet Mask", SubnetMaskEntry)
        
        '*** SAVE DEFAULT GATEWAY ***
        Dim DefaultGatewayEntry as String
        If Me.textBoxDefaultGateway1.Text = "" Or Me.textBoxDefaultGateway2.Text = "" Or Me.textBoxDefaultGateway3.Text = "" Or Me.textBoxDefaultGateway4.Text = "" Then
        	DefaultGatewayEntry = ""
        Else
        	DefaultGatewayEntry = Me.textBoxDefaultGateway1.Text & "." & Me.textBoxDefaultGateway2.Text & "." & Me.textBoxDefaultGateway3.Text & "." & Me.textBoxDefaultGateway4.Text
        End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "Default Gateway", DefaultGatewayEntry)
        
        '*** SAVE PRIMARY DNS SERVER ***
        Dim PrimaryDNSServerEntry as String
        If Me.textBoxPrimaryDNSServer1.Text = "" Or Me.textBoxPrimaryDNSServer2.Text = "" Or Me.textBoxPrimaryDNSServer3.Text = "" Or Me.textBoxPrimaryDNSServer4.Text = "" Then
        	PrimaryDNSServerEntry = ""
        Else
        	PrimaryDNSServerEntry = Me.textBoxPrimaryDNSServer1.Text & "." & Me.textBoxPrimaryDNSServer2.Text & "." & Me.textBoxPrimaryDNSServer3.Text & "." & Me.textBoxPrimaryDNSServer4.Text
        End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "DNS Server", PrimaryDNSServerEntry)
        
        '*** SAVE ALTERNATE DNS SERVER ***
        Dim AlternateDNSServerEntry as String
        If Me.textBoxAlternateDNSServer1.Text = "" Or Me.textBoxAlternateDNSServer2.Text = "" Or Me.textBoxAlternateDNSServer3.Text = "" Or Me.textBoxAlternateDNSServer4.Text = "" Then
        	AlternateDNSServerEntry = ""
        Else
        	AlternateDNSServerEntry = Me.textBoxAlternateDNSServer1.Text & "." & Me.textBoxAlternateDNSServer2.Text & "." & Me.textBoxAlternateDNSServer3.Text & "." & Me.textBoxAlternateDNSServer4.Text
        End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "Alternate DNS Server", AlternateDNSServerEntry)
        
        '*** SAVE WINS SERVER ***
        Dim WINSServerEntry as String
        If Me.textBoxWINSServer1.Text = "" Or Me.textBoxWINSServer2.Text = "" Or Me.textBoxWINSServer3.Text = "" Or Me.textBoxWINSServer4.Text = "" Then
        	WINSServerEntry = ""
        Else
        	WINSServerEntry = Me.textBoxWINSServer1.Text & "." & Me.textBoxWINSServer2.Text & "." & Me.textBoxWINSServer3.Text & "." & Me.textBoxWINSServer4.Text
        End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "WINS Server", WINSServerEntry)
        
        '*** SAVE DHCP ***
        Dim DHCPEntry As String = Me.checkBoxDHCP.Checked.ToString
        If DHCPEntry = "False" Then
        	DHCPEntry = "0"
        Else
        	DHCPEntry = "1"
		End If
        INIWrite(ThisINIFile, "TCP/IP Settings", "DHCP", DHCPEntry)
        
        '*** SAVE MAPPED DRIVES ***
        INIDelete(ThisINIFile, "Mapped Drives")
        Dim lvi As ListViewItem
        For Each lvi In Me.listViewMappedDrives.Items
			INIWrite(ThisINIFile, "Mapped Drives", lvi.SubItems.Item(0).Text.Substring(0,2), lvi.SubItems.Item(1).Text & "|" & lvi.SubItems.Item(2).Text & "|" & lvi.SubItems.Item(3).Text)
		Next lvi
		'*** END SAVE MAPPED DRIVES ***
		
		INIWrite(ThisINIFile, "Printer", "Default", Me.comboBoxPrinters.Text)
		
		'*** SAVE INTERNET SETTINGS ***
		Dim UseProxyEntry As String = Me.checkBoxUseProxySettings.Checked.ToString
        If UseProxyEntry = "False" Then
        	UseProxyEntry = "0"
        Else
        	UseProxyEntry = "1"
		End If
		
		INIWrite(ThisINIFile, "Internet Settings", "UseProxySettings", UseProxyEntry)
		INIWrite(ThisINIFile, "Internet Settings", "ProxyServerAddress", Me.textBoxServerAddress.Text.Trim)
		INIWrite(ThisINIFile, "Internet Settings", "ProxyServerPort", Me.textBoxPort.Text.Trim)
		INIWrite(ThisINIFile, "Internet Settings", "DefaultHomepage", Me.textBoxDefaultHomepage.Text.Trim)
		INIWrite(ThisINIFile, "Internet Settings", "InternetExplorer", Me.checkBoxIE.Checked.ToString)
		INIWrite(ThisINIFile, "Internet Settings", "Firefox", Me.checkBoxFirefox.Checked.ToString)
		INIWrite(ThisINIFile, "Internet Settings", "Opera", Me.checkBoxOpera.Checked.ToString)
		INIWrite(ThisINIFile, "Internet Settings", "ProxyBypass", Me.checkBoxBypassProxyForLocalAddresses.Checked.ToString)
		INIWrite(ThisINIFile, "Internet Settings", "AutoConfigAddress", Me.textBoxAutoConfigAddress.Text.Trim)
		
		'*** SAVE RUN PROGRAMS ***
		INIDelete(ThisINIFile, "Run")
        Dim lvi2 As ListViewItem
        Dim RunNumber As Integer = 0
        Dim RunKey As String
        Dim RunValue As String
        For Each lvi2 In Me.listViewRun.Items
			RunKey = "Run" & RunNumber.ToString
			RunValue = lvi2.SubItems.Item(0).Text & "||" & lvi2.SubItems.Item(1).Text & "||" & lvi2.SubItems.Item(2).Text & "||" & lvi2.SubItems.Item(3).Text & "||" & lvi2.SubItems.Item(4).Text & "||" & lvi2.SubItems.Item(5).Text
			INIWrite(ThisINIFile, "Run", RunKey, RunValue)
			RunNumber = RunNumber + 1
		Next lvi2
		'*** END SAVE RUN PROGRAMS ***
		
		'*** SAVE WALLPAPER ***
		INIWrite(ThisINIFile, "Desktop", "Wallpaper", Me.textBoxWallpaperPath.Text.Trim)
		'*** END SAVE WALLPAPER ***
		
		'*** SAVE DISPLAY SETTINGS ***
		INIWrite(ThisINIFile, "Desktop", "ScreenResolution", Me.comboBoxDisplaySettings.Text)
		INIWrite(ThisINIFile, "Desktop", "ColorQuality", Me.comboBoxDisplayColors.Text)
		'*** END SAVE DISPLAY SETTINGS ***
		
		'*** SAVE WIRELESS SETTINGS ***
		INIWrite(ThisINIFile, "Wireless", "AutoActivateSSID", Me.textBoxAutoActivateSSID.Text.Trim)
		'*** END SAVE WIRELESS SETTINGS ***
		
		If MainForm.listViewProfiles.SelectedItems.Count > 0 And Globals.CreatingNewProfile = False Then
			If Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":","-") <> MainForm.listViewProfiles.SelectedItems.Item(0).Group.Name.ToString Then
        		System.IO.File.Move(ThisINIFile,My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-") & "\" & System.Guid.NewGuid.ToString & ".ini")
        	End If
        End If
        
        'Me.Hide
        'Me.Visible = False
        Me.Opacity = Double.MinValue
        Application.DoEvents()
        Call MainForm.RefreshProfiles()
        'Me.Dispose
        Me.Close
        Me.Refresh
	End Sub
	
	Public Sub ValidateIPBoxes(ByVal sender As Object, ByVal KeyAscii As Short, ByVal NextField As Object, ByVal PrevField As Object, ByVal e As KeyPressEventArgs, ByVal JumpForward As Boolean, ByVal JumpBack As Boolean)
		Const Numbers As String = "0123456789"
		If KeyAscii <> 46 And KeyAscii <> 8 Then
			If InStr(Numbers, Chr(KeyAscii)) = 0 Then
				KeyAscii = 0
				GoTo EventExitSub
            ElseIf CBool(sender.Text.Length = 2 And sender.SelectionLength <> 2 And JumpForward = True) Then
                NextField.Focus()
                NextField.SelectAll()
			End If
        ElseIf CBool(KeyAscii = 46 And JumpForward = True And sender.Text.Length > 0) Then
            KeyAscii = 0
            NextField.Focus()
		ElseIf KeyAscii = 46 Then
			KeyAscii = 0
        ElseIf CBool(KeyAscii = 8 And (sender.Text.Length = 1 Or sender.Text.Length = 0 Or sender.Text.Length = sender.SelectedText.Length) And JumpBack = True) Then
            PrevField.Focus()
            'PrevField.Select(PrevField.Text.Length,1)
            PrevField.SelectAll()
		End If
		
		EventExitSub:
			e.KeyChar = Chr(KeyAscii)
			If KeyAscii = 0 Then
				e.Handled = True
			End If
	End Sub
	
	Sub TextBoxIPAddress1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxIPAddress2, Me.textBoxIPAddress1, e, True, False)
	End Sub	

	Sub TextBoxIPAddress2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxIPAddress3, Me.textBoxIPAddress1, e, True, True)
	End Sub
	
	Sub TextBoxIPAddress3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxIPAddress4, Me.textBoxIPAddress2, e, True, True)
	End Sub
	
	Sub TextBoxIPAddress4KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxIPAddress4, Me.textBoxIPAddress3, e, False, True)
	End Sub
	
	Sub TextBoxSubnetMask1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxSubnetMask2, Me.textBoxSubnetMask1, e, True, False)
	End Sub
	
	Sub TextBoxSubnetMask2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxSubnetMask3, Me.textBoxSubnetMask1, e, True, True)
	End Sub
	
	Sub TextBoxSubnetMask3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxSubnetMask4, Me.textBoxSubnetMask2, e, True, True)
	End Sub
	
	Sub TextBoxSubnetMask4KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxSubnetMask4, Me.textBoxSubnetMask3, e, False, True)
	End Sub
	
	Sub TextBoxDefaultGateway1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxDefaultGateway2, Me.textBoxDefaultGateway1, e, True, False)
	End Sub
	
	Sub TextBoxDefaultGateway2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxDefaultGateway3, Me.textBoxDefaultGateway1, e, True, True)
	End Sub
	
	Sub TextBoxDefaultGateway3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxDefaultGateway4, Me.textBoxDefaultGateway2, e, True, True)
	End Sub
	
	Sub TextBoxDefaultGateway4KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxDefaultGateway4, Me.textBoxDefaultGateway3, e, False, True)
	End Sub
	
	Sub TextBoxPrimaryDNSServer1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxPrimaryDNSServer2, Me.textBoxPrimaryDNSServer1, e, True, False)
	End Sub
	
	Sub TextBoxPrimaryDNSServer2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxPrimaryDNSServer3, Me.textBoxPrimaryDNSServer1, e, True, True)
	End Sub
	
	Sub TextBoxPrimaryDNSServer3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxPrimaryDNSServer4, Me.textBoxPrimaryDNSServer2, e, True, True)
	End Sub
	
	Sub TextBoxPrimaryDNSServer4KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxPrimaryDNSServer4, Me.textBoxPrimaryDNSServer3, e, False, True)
	End Sub
	
	Sub TextBoxAlternateDNSServer1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxAlternateDNSServer2, Me.textBoxAlternateDNSServer1, e, True, False)
	End Sub
	
	Sub TextBoxAlternateDNSServer2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxAlternateDNSServer3, Me.textBoxAlternateDNSServer1, e, True, True)
	End Sub
	
	Sub TextBoxAlternateDNSServer3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxAlternateDNSServer4, Me.textBoxAlternateDNSServer2, e, True, True)
	End Sub
	
	Sub TextBoxAlternateDNSServer4KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxAlternateDNSServer4, Me.textBoxAlternateDNSServer3, e, False, True)
	End Sub
	
	Sub TextBoxWINSServer1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxWINSServer2, Me.textBoxWINSServer1, e, True, False)
	End Sub
	
	Sub TextBoxWINSServer2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxWINSServer3, Me.textBoxWINSServer1, e, True, True)
	End Sub
	
	Sub TextBoxWINSServer3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxWINSServer4, Me.textBoxWINSServer2, e, True, True)
	End Sub
	
	Sub TextBoxWINSServer4KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		Call Me.ValidateIPBoxes(sender, KeyAscii, Me.textBoxWINSServer4, Me.textBoxWINSServer3, e, False, True)
	End Sub
	
	Sub Timer1Tick(ByVal sender As Object, ByVal e As EventArgs)
		Me.timer1.Enabled = False
		Call PopulateNetworkCards
		
		Me.progressBar1.Visible = True
		Me.progressBar1.Enabled = True
		Me.labelWorking.Text = Me.labelWorking_Printer
		Application.DoEvents()
		Me.comboBoxPrinters.Items.Add("")
		Dim pkInstalledPrinters As String
    	For Each pkInstalledPrinters In _
        	PrinterSettings.InstalledPrinters
        	Me.comboBoxPrinters.Items.Add(pkInstalledPrinters)
    	Next pkInstalledPrinters
		
		Me.labelWorking.Text = Me.labelWorking_Profile
		Application.DoEvents()
		Call ResolutionsToComboBox()
		Call BPPToComboBox()
		
		If Globals.CreatingNewProfile = False Then
			Dim TheINIFile As String = MainForm.listViewProfiles.SelectedItems(0).SubItems(3).Text
			
			Application.DoEvents()
			Me.textBoxProfileName.Text = INIRead(TheINIFile,"General","Name", "[No Name]")
			
			'*** LOAD IP SETTINGS ***
			Dim IPAddress As String = INIRead(TheINIFile,"TCP/IP Settings","IP Address", "")
			Application.DoEvents()
            Dim IPAddressParts() As String = IPAddress.Split(CChar("."))
			Application.DoEvents()
			If IPAddressParts.GetUpperBound(0) = 3 Then
				Me.textBoxIPAddress1.Text = IPAddressParts(0).ToString
				Application.DoEvents()
				Me.textBoxIPAddress2.Text = IPAddressParts(1).ToString
				Application.DoEvents()
				Me.textBoxIPAddress3.Text = IPAddressParts(2).ToString
				Application.DoEvents()
				Me.textBoxIPAddress4.Text = IPAddressParts(3).ToString
			End If
			Application.DoEvents()
			
			Dim SubnetMask As String = INIRead(TheINIFile,"TCP/IP Settings","Subnet Mask", "")
			Application.DoEvents()
            Dim SubnetMaskParts() As String = SubnetMask.Split(CChar("."))
			Application.DoEvents()
			If SubnetMaskParts.GetUpperBound(0) = 3 Then
				Me.textBoxSubnetMask1.Text = SubnetMaskParts(0).ToString
				Application.DoEvents()
				Me.textBoxSubnetMask2.Text = SubnetMaskParts(1).ToString
				Application.DoEvents()
				Me.textBoxSubnetMask3.Text = SubnetMaskParts(2).ToString
				Application.DoEvents()
				Me.textBoxSubnetMask4.Text = SubnetMaskParts(3).ToString
			End If
			Application.DoEvents()
			
			Dim DefaultGateway As String = INIRead(TheINIFile,"TCP/IP Settings","Default Gateway", "")
			Application.DoEvents()
            Dim DefaultGatewayParts() As String = DefaultGateway.Split(CChar("."))
			Application.DoEvents()
			If DefaultGatewayParts.GetUpperBound(0) = 3 Then
				Me.textBoxDefaultGateway1.Text = DefaultGatewayParts(0).ToString
				Application.DoEvents()
				Me.textBoxDefaultGateway2.Text = DefaultGatewayParts(1).ToString
				Application.DoEvents()
				Me.textBoxDefaultGateway3.Text = DefaultGatewayParts(2).ToString
				Application.DoEvents()
				Me.textBoxDefaultGateway4.Text = DefaultGatewayParts(3).ToString
			End If
			Application.DoEvents()
			
			Dim PrimaryDNSServer As String = INIRead(TheINIFile,"TCP/IP Settings","DNS Server", "")
			Application.DoEvents()
            Dim PrimaryDNSServerParts() As String = PrimaryDNSServer.Split(CChar("."))
			Application.DoEvents()
			If PrimaryDNSServerParts.GetUpperBound(0) = 3 Then
				Me.textBoxPrimaryDNSServer1.Text = PrimaryDNSServerParts(0).ToString
				Application.DoEvents()
				Me.textBoxPrimaryDNSServer2.Text = PrimaryDNSServerParts(1).ToString
				Application.DoEvents()
				Me.textBoxPrimaryDNSServer3.Text = PrimaryDNSServerParts(2).ToString
				Application.DoEvents()
				Me.textBoxPrimaryDNSServer4.Text = PrimaryDNSServerParts(3).ToString
			End If
			Application.DoEvents()
			
			Dim AlternateDNSServer As String = INIRead(TheINIFile,"TCP/IP Settings","Alternate DNS Server", "")
			Application.DoEvents()
            Dim AlternateDNSServerParts() As String = AlternateDNSServer.Split(CChar("."))
			Application.DoEvents()
			If AlternateDNSServerParts.GetUpperBound(0) = 3 Then
				Me.textBoxAlternateDNSServer1.Text = AlternateDNSServerParts(0).ToString
				Application.DoEvents()
				Me.textBoxAlternateDNSServer2.Text = AlternateDNSServerParts(1).ToString
				Application.DoEvents()
				Me.textBoxAlternateDNSServer3.Text = AlternateDNSServerParts(2).ToString
				Application.DoEvents()
				Me.textBoxAlternateDNSServer4.Text = AlternateDNSServerParts(3).ToString
			End If
			Application.DoEvents()
			
			Dim WINSServer As String = INIRead(TheINIFile,"TCP/IP Settings","WINS Server", "")
			Application.DoEvents()
            Dim WINSServerParts() As String = WINSServer.Split(CChar("."))
			Application.DoEvents()
			If WINSServerParts.GetUpperBound(0) = 3 Then
				Me.textBoxWINSServer1.Text = WINSServerParts(0).ToString
				Application.DoEvents()
				Me.textBoxWINSServer2.Text = WINSServerParts(1).ToString
				Application.DoEvents()
				Me.textBoxWINSServer3.Text = WINSServerParts(2).ToString
				Application.DoEvents()
				Me.textBoxWINSServer4.Text = WINSServerParts(3).ToString
			End If
			Application.DoEvents()
			
			Dim DHCP As String = INIRead(TheINIFile,"TCP/IP Settings","DHCP", "0")
			Application.DoEvents()
			If DHCP = "1" Then
				Me.checkBoxDHCP.Checked = True
				Application.DoEvents()
				Me.EnableDisableIPSettings(False)
			Else
				Me.checkBoxDHCP.Checked = False
				Application.DoEvents()
				Me.EnableDisableIPSettings(True)
			End If
			Application.DoEvents()
			'*** END LOAD IP SETTINGS ***
			
			Me.comboBoxNetworkCards.SelectedIndex = Me.comboBoxNetworkCards.FindStringExact(MainForm.listViewProfiles.SelectedItems.Item(0).Group.ToString)
			Application.DoEvents()
			
			Dim iniText As String
			Dim iniArray() As String
			iniText = INIRead(TheINIFile, "Mapped Drives")
			iniText = iniText.Replace(ControlChars.NullChar, "|")
			iniText = Trim(iniText)
            iniArray = iniText.Split(CChar("|"))
			Dim iniArray2() As String
			Dim X As Integer
			For X = iniArray.GetLowerBound(0) To (iniArray.GetUpperBound(0) - 1)
                iniArray2 = INIRead(TheINIFile, "Mapped Drives", iniArray(X), "").Split(CChar("|"))
				Dim itmx As ListViewItem
				itmx = Me.listViewMappedDrives.Items.Add(iniArray(X))
				itmx.SubItems.Add(iniArray2(0))
				itmx.SubItems.Add(iniArray2(1))
				itmx.SubItems.Add(iniArray2(2))
				itmx.ImageIndex = 0
			Next X
			
			Application.DoEvents()
			Me.comboBoxPrinters.SelectedIndex = Me.comboBoxPrinters.FindStringExact(INIRead(TheINIFile,"Printer", "Default", ""))
			
			Application.DoEvents()
			Me.textBoxAutoConfigAddress.Text = INIRead(TheINIFile, "Internet Settings", "AutoConfigAddress", "")
			
			Dim UseProxy As String = INIRead(TheINIFile, "Internet Settings", "UseProxySettings", "0")
			If UseProxy = "1" Then
				Me.checkBoxUseProxySettings.Checked = True
				Application.DoEvents()
				Me.EnableDisableProxySettings(True)
			Else
				Me.checkBoxUseProxySettings.Checked = False
				Application.DoEvents()
				Me.EnableDisableProxySettings(False)
			End If
			Application.DoEvents()
			Me.textBoxServerAddress.Text = INIRead(TheINIFile,"Internet Settings", "ProxyServerAddress", "")
			Application.DoEvents()
			Me.textBoxPort.Text = INIRead(TheINIFile,"Internet Settings", "ProxyServerPort", "")
			Application.DoEvents()
			Me.textBoxDefaultHomepage.Text = INIRead(TheINIFile,"Internet Settings", "DefaultHomepage", "")
			Application.DoEvents()
            Me.checkBoxIE.Checked = CBool(INIRead(TheINIFile, "Internet Settings", "InternetExplorer", "False"))
			Application.DoEvents()
            Me.checkBoxFirefox.Checked = CBool(INIRead(TheINIFile, "Internet Settings", "Firefox", "False"))
			Application.DoEvents()
            Me.checkBoxOpera.Checked = CBool(INIRead(TheINIFile, "Internet Settings", "Opera", "False"))
			Application.DoEvents()
            Me.checkBoxBypassProxyForLocalAddresses.Checked = CBool(INIRead(TheINIFile, "Internet Settings", "ProxyBypass", "False"))
			
			Dim iniTextRun As String
			Dim iniRunArray() As String
			iniTextRun = INIRead(TheINIFile, "Run")
			iniTextRun = iniTextRun.Replace(ControlChars.NullChar, "|")
			iniTextRun = Trim(iniTextRun)
            iniRunArray = iniTextRun.Split(CChar("|"))
			Dim iniRunArray2() As String
			Dim XRun As Integer
			For XRun = iniRunArray.GetLowerBound(0) To (iniRunArray.GetUpperBound(0) - 1)
				iniRunArray2 = Microsoft.VisualBasic.Strings.Split(INIRead(TheINIFile,"Run", iniRunArray(XRun), ""), "||")
				Dim itmxRun As ListViewItem
				itmxRun = Me.listViewRun.Items.Add(iniRunArray2(0))
				itmxRun.SubItems.Add(iniRunArray2(1))
				itmxRun.SubItems.Add(iniRunArray2(2))
				itmxRun.SubItems.Add(iniRunArray2(3))
				itmxRun.SubItems.Add(iniRunArray2(4))
				itmxRun.SubItems.Add(iniRunArray2(5))
			Next XRun
			
			Application.DoEvents()
			Me.textBoxWallpaperPath.Text = INIRead(TheINIFile,"Desktop", "Wallpaper", "")
			If Me.textBoxWallpaperPath.Text.Length > 4 Then
				Dim f As New IO.FileInfo(Me.textBoxWallpaperPath.Text)
        		If f.Exists = True Then
					Me.pictureBoxWallpaperPreview.Image = Image.FromFile(Me.textBoxWallpaperPath.Text)
				End If
			End If
			
			Application.DoEvents()
			Me.comboBoxDisplaySettings.Text = INIRead(TheINIFile, "Desktop", "ScreenResolution", "")
			Me.comboBoxDisplayColors.Text = INIRead(TheINIFile, "Desktop", "ColorQuality", "")
			
			Application.DoEvents()
			Me.textBoxAutoActivateSSID.Text = INIRead(TheINIFile, "Wireless", "AutoActivateSSID", "")
			
		End If
		
		Me.progressBar1.Visible = False
		Me.progressBar1.Enabled = False
		Me.labelWorking.Visible = False
	End Sub
	
	Sub CheckBoxDHCPCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim DHCPStatus As Boolean
		If Me.checkBoxDHCP.Checked = True Then
			DHCPStatus = False
		Else
			DHCPStatus = True
		End If
		
		Call EnableDisableIPSettings(DHCPStatus)
	End Sub
	
	Public Sub EnableDisableIPSettings(ByVal DHCPStatus As Boolean)
		Me.labelIPAddress.Enabled = DHCPStatus
		Me.pictureBoxIPAddress.Enabled = DHCPStatus
		Me.textBoxIPAddress1.Enabled = DHCPStatus
		Me.textBoxIPAddress2.Enabled = DHCPStatus
		Me.textBoxIPAddress3.Enabled = DHCPStatus
		Me.textBoxIPAddress4.Enabled = DHCPStatus
		
		Me.labelSubnetMask.Enabled = DHCPStatus
		Me.pictureBoxSubnetMask.Enabled = DHCPStatus
		Me.textBoxSubnetMask1.Enabled = DHCPStatus
		Me.textBoxSubnetMask2.Enabled = DHCPStatus
		Me.textBoxSubnetMask3.Enabled = DHCPStatus
		Me.textBoxSubnetMask4.Enabled = DHCPStatus
		
		Me.labelDefaultGateway.Enabled = DHCPStatus
		Me.pictureBoxDefaultGateway.Enabled = DHCPStatus
		Me.textBoxDefaultGateway1.Enabled = DHCPStatus
		Me.textBoxDefaultGateway2.Enabled = DHCPStatus
		Me.textBoxDefaultGateway3.Enabled = DHCPStatus
		Me.textBoxDefaultGateway4.Enabled = DHCPStatus
		
		Me.labelPrimaryDNSServer.Enabled = DHCPStatus
		Me.pictureBoxPrimaryDNSServer.Enabled = DHCPStatus
		Me.textBoxPrimaryDNSServer1.Enabled = DHCPStatus
		Me.textBoxPrimaryDNSServer2.Enabled = DHCPStatus
		Me.textBoxPrimaryDNSServer3.Enabled = DHCPStatus
		Me.textBoxPrimaryDNSServer4.Enabled = DHCPStatus
		
		Me.labelAlternateDNSServer.Enabled = DHCPStatus
		Me.pictureBoxAlternateDNSServer.Enabled = DHCPStatus
		Me.textBoxAlternateDNSServer1.Enabled = DHCPStatus
		Me.textBoxAlternateDNSServer2.Enabled = DHCPStatus
		Me.textBoxAlternateDNSServer3.Enabled = DHCPStatus
		Me.textBoxAlternateDNSServer4.Enabled = DHCPStatus
		
		Me.labelWINSServer.Enabled = DHCPStatus
		Me.pictureBoxWINSServer.Enabled = DHCPStatus
		Me.textBoxWINSServer1.Enabled = DHCPStatus
		Me.textBoxWINSServer2.Enabled = DHCPStatus
		Me.textBoxWINSServer3.Enabled = DHCPStatus
		Me.textBoxWINSServer4.Enabled = DHCPStatus
	End Sub
	
	Sub ToolStripButtonAddDriveClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.CreatingNewMappedDrive = True
		MappedDrive.ShowDialog
	End Sub
	
	Sub ToolStripButtonRemoveDriveClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewMappedDrives.SelectedItems.Count = 1 Then
			Me.listViewMappedDrives.SelectedItems.Item(0).Remove
		End If
	End Sub
	
	Sub ToolStripButtonEditDriveClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewMappedDrives.SelectedItems.Count = 1 Then
			Globals.CreatingNewMappedDrive = False
			MappedDrive.ShowDialog
		End If
	End Sub
	
	Sub ButtonUseCurrentHomepageClick(ByVal sender As Object, ByVal e As EventArgs)
		' open the registry key
    	Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main")

    	If rk Is Nothing Then
      		'Console.WriteLine("The registry key does not exist")
    	Else
      		Try
        		' read and display the value
                Dim startPage As String = CStr(rk.GetValue("Start Page"))
        		Me.textBoxDefaultHomepage.Text = startPage
      		Finally
        		' cleanup
        		rk.Close()
      		End Try
    	End If
	End Sub
	
	Sub ButtonUseBlankHomepageClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.textBoxDefaultHomepage.Text = "about:blank"
	End Sub
	
	Sub CheckBoxUseProxySettingsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Call Me.EnableDisableProxySettings(Me.checkBoxUseProxySettings.Checked)
	End Sub
	
	Public Sub EnableDisableProxySettings(ByVal UseProxyStatus As Boolean)
		Me.labelServerAddress.Enabled = UseProxyStatus
		Me.textBoxServerAddress.Enabled = UseProxyStatus
		Me.labelPort.Enabled = UseProxyStatus
		Me.textBoxPort.Enabled = UseProxyStatus
		Me.checkBoxBypassProxyForLocalAddresses.Enabled = UseProxyStatus
	End Sub
	
	Sub ButtonGetCurrentIPSettingsClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim CurrentIPSettings As String = GetCurrentIPSettings(Me.comboBoxNetworkCards.SelectedValue.ToString)
        Dim CurrentIPSettingsArray() As String = CurrentIPSettings.Split(CChar("|"))
		
		If CurrentIPSettingsArray(0).ToString = "True" Then
			Me.checkBoxDHCP.Checked = True
		Else
			Me.checkBoxDHCP.Checked = False
		End If
		
		If CurrentIPSettingsArray(1).Length > 0 Then
            Dim CurrentIPAddress() As String = CurrentIPSettingsArray(1).Split(CChar("."))
			Me.textBoxIPAddress1.Text = CurrentIPAddress(0)
			Me.textBoxIPAddress2.Text = CurrentIPAddress(1)
			Me.textBoxIPAddress3.Text = CurrentIPAddress(2)
			Me.textBoxIPAddress4.Text = CurrentIPAddress(3)
		Else
			Me.textBoxIPAddress1.Text = ""
			Me.textBoxIPAddress2.Text = ""
			Me.textBoxIPAddress3.Text = ""
			Me.textBoxIPAddress4.Text = ""
		End If
		
		If CurrentIPSettingsArray(2).Length > 0 Then
            Dim CurrentSubnetMask() As String = CurrentIPSettingsArray(2).Split(CChar("."))
			Me.textBoxSubnetMask1.Text = CurrentSubnetMask(0)
			Me.textBoxSubnetMask2.Text = CurrentSubnetMask(1)
			Me.textBoxSubnetMask3.Text = CurrentSubnetMask(2)
			Me.textBoxSubnetMask4.Text = CurrentSubnetMask(3)
		Else
			Me.textBoxSubnetMask1.Text = ""
			Me.textBoxSubnetMask2.Text = ""
			Me.textBoxSubnetMask3.Text = ""
			Me.textBoxSubnetMask4.Text = ""
		End If
		
		If CurrentIPSettingsArray(3).Length > 0 Then
            Dim CurrentDefaultGateway() As String = CurrentIPSettingsArray(3).Split(CChar("."))
			Me.textBoxDefaultGateway1.Text = CurrentDefaultGateway(0)
			Me.textBoxDefaultGateway2.Text = CurrentDefaultGateway(1)
			Me.textBoxDefaultGateway3.Text = CurrentDefaultGateway(2)
			Me.textBoxDefaultGateway4.Text = CurrentDefaultGateway(3)
		Else
			Me.textBoxDefaultGateway1.Text = ""
			Me.textBoxDefaultGateway2.Text = ""
			Me.textBoxDefaultGateway3.Text = ""
			Me.textBoxDefaultGateway4.Text = ""
		End If
		
		If CurrentIPSettingsArray(4).Length > 0 Then
            Dim CurrentDNSServerArray() As String = CurrentIPSettingsArray(4).Split(CChar(","))
			If CurrentDNSServerArray.GetUpperBound(0) > 0 Or CurrentDNSServerArray.GetUpperBound(0) = 0 Then
                Dim CurrentPrimaryDNSServer() As String = CurrentDNSServerArray(0).Split(CChar("."))
				Me.textBoxPrimaryDNSServer1.Text = CurrentPrimaryDNSServer(0)
				Me.textBoxPrimaryDNSServer2.Text = CurrentPrimaryDNSServer(1)
				Me.textBoxPrimaryDNSServer3.Text = CurrentPrimaryDNSServer(2)
				Me.textBoxPrimaryDNSServer4.Text = CurrentPrimaryDNSServer(3)
			Else
				Me.textBoxPrimaryDNSServer1.Text = ""
				Me.textBoxPrimaryDNSServer2.Text = ""
				Me.textBoxPrimaryDNSServer3.Text = ""
				Me.textBoxPrimaryDNSServer4.Text = ""
			End If
			If CurrentDNSServerArray.GetUpperBound(0) > 0 Then
                Dim CurrentAlternateDNSServer() As String = CurrentDNSServerArray(1).Split(CChar("."))
				Me.textBoxAlternateDNSServer1.Text = CurrentAlternateDNSServer(0)
				Me.textBoxAlternateDNSServer2.Text = CurrentAlternateDNSServer(1)
				Me.textBoxAlternateDNSServer3.Text = CurrentAlternateDNSServer(2)
				Me.textBoxAlternateDNSServer4.Text = CurrentAlternateDNSServer(3)
			Else
				Me.textBoxAlternateDNSServer1.Text = ""
				Me.textBoxAlternateDNSServer2.Text = ""
				Me.textBoxAlternateDNSServer3.Text = ""
				Me.textBoxAlternateDNSServer4.Text = ""
			End If
		Else
			Me.textBoxPrimaryDNSServer1.Text = ""
			Me.textBoxPrimaryDNSServer2.Text = ""
			Me.textBoxPrimaryDNSServer3.Text = ""
			Me.textBoxPrimaryDNSServer4.Text = ""
			
			Me.textBoxAlternateDNSServer1.Text = ""
			Me.textBoxAlternateDNSServer2.Text = ""
			Me.textBoxAlternateDNSServer3.Text = ""
			Me.textBoxAlternateDNSServer4.Text = ""
		End If
		
		If CurrentIPSettingsArray(5).Length > 0 Then
            Dim CurrentWINSServer() As String = CurrentIPSettingsArray(5).Split(CChar("."))
			Me.textBoxWINSServer1.Text = CurrentWINSServer(0)
			Me.textBoxWINSServer2.Text = CurrentWINSServer(1)
			Me.textBoxWINSServer3.Text = CurrentWINSServer(2)
			Me.textBoxWINSServer4.Text = CurrentWINSServer(3)
		Else
			Me.textBoxWINSServer1.Text = ""
			Me.textBoxWINSServer2.Text = ""
			Me.textBoxWINSServer3.Text = ""
			Me.textBoxWINSServer4.Text = ""
		End If
	End Sub
	
	Sub ButtonGetCurrentServerAddressSettingsClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim regKey As RegistryKey
		regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings\", True)
        Dim ProxyEnable As String = CStr(regKey.GetValue("ProxyEnable", 0))
		If ProxyEnable = "0" Then
			Me.checkBoxUseProxySettings.Checked = False
		Else
			Me.checkBoxUseProxySettings.Checked = True
		End If
        Dim ProxyAddress As String = CStr(regKey.GetValue("ProxyServer", ""))
		If ProxyAddress.Contains(":") Then
            Dim ProxyAddressArray() As String = ProxyAddress.Split(CChar(":"))
			Me.textBoxServerAddress.Text = ProxyAddressArray(0)
			Me.textBoxPort.Text = ProxyAddressArray(1)
		Else
			Me.textBoxServerAddress.Text = ProxyAddress
		End If
	End Sub
	
	Sub ButtonGetDefaultPrinterClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.comboBoxPrinters.SelectedIndex = Me.comboBoxPrinters.FindStringExact(GetDefaultPrinter())
	End Sub
	
	Sub ToolStripButtonAddProgramClick(ByVal sender As Object, ByVal e As EventArgs)
		Globals.CreatingNewRunCommand = True
		RunPrograms.ShowDialog
	End Sub
	
	Sub ToolStripButtonEditProgramClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewRun.SelectedItems.Count = 1 Then
			Globals.CreatingNewRunCommand = False
			RunPrograms.ShowDialog
		End If
	End Sub
	
	Sub ToolStripButtonRemoveProgramClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.listViewRun.SelectedItems.Count = 1 Then
			Me.listViewRun.SelectedItems.Item(0).Remove
		End If
	End Sub
	
	Sub ButtonBrowseWallpaperClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.openFileDialogWallpaper.Filter = Me.openFileDialogWallpaper_Filter & " (*.bmp, *.gif, *.jpg)|*.bmp;*.gif;*.jpg"
		Me.openFileDialogWallpaper.Title = Me.openFileDialogWallpaper_Title
		Me.openFileDialogWallpaper.CheckFileExists() = True
        Me.openFileDialogWallpaper.CheckPathExists = True
        Me.openFileDialogWallpaper.ValidateNames = True
        Me.openFileDialogWallpaper.DereferenceLinks = True
        Me.openFileDialogWallpaper.InitialDirectory = INIRead(Globals.ProgramINIFile, "Program", "LastWallpaperDir", My.Computer.FileSystem.SpecialDirectories.MyPictures)
		If Me.openFileDialogWallpaper.ShowDialog = DialogResult.OK Then
			Me.textBoxWallpaperPath.Text = Me.openFileDialogWallpaper.FileName
			Me.pictureBoxWallpaperPreview.Image = Image.FromFile(Me.openFileDialogWallpaper.FileName)
			INIWrite(Globals.ProgramINIFile, "Program", "LastWallpaperDir", Me.openFileDialogWallpaper.FileName.Substring(0, Me.openFileDialogWallpaper.FileName.LastIndexOf("\") + 1))
		End If
	End Sub
	
	Sub ButtonResetWallpaperClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.textBoxWallpaperPath.Text = ""
		Me.pictureBoxWallpaperPreview.Image = Nothing
	End Sub
	
	Sub ButtonGetCurrentDisplaySettingsClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.comboBoxDisplaySettings.Text = cScreen.CurrentResolution
		Me.comboBoxDisplayColors.Text = cScreen.CurrentBPP.ToString
	End Sub
	
	Sub ButtonClearFirefoxClick(ByVal sender As Object, ByVal e As EventArgs)
		Call DeleteFirefoxSettings()
		MessageBox.Show(Me.ClearFirefox_Messagebox_1 & vbCrLf & vbCrLf & Me.ClearFirefox_Messagebox_2, "Net Profiles - Firefox")
	End Sub
	
	Sub ProfileSettingsFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
		'*** GENERAL ***
		Me.textBoxProfileName.Text = ""
		Me.comboBoxNetworkCards.SelectedIndex = 0
		Me.comboBoxNetworkCards.DataSource = Nothing
		Me.tabControl1.SelectedIndex = 0
		'*** IP SETTINGS ***
		Me.checkBoxDHCP.Checked = False
		Me.textBoxIPAddress1.Text = ""
		Me.textBoxIPAddress2.Text = ""
		Me.textBoxIPAddress3.Text = ""
		Me.textBoxIPAddress4.Text = ""
		Me.textBoxSubnetMask1.Text = ""
		Me.textBoxSubnetMask2.Text = ""
		Me.textBoxSubnetMask3.Text = ""
		Me.textBoxSubnetMask4.Text = ""
		Me.textBoxDefaultGateway1.Text = ""
		Me.textBoxDefaultGateway2.Text = ""
		Me.textBoxDefaultGateway3.Text = ""
		Me.textBoxDefaultGateway4.Text = ""
		Me.textBoxPrimaryDNSServer1.Text = ""
		Me.textBoxPrimaryDNSServer2.Text = ""
		Me.textBoxPrimaryDNSServer3.Text = ""
		Me.textBoxPrimaryDNSServer4.Text = ""
		Me.textBoxAlternateDNSServer1.Text = ""
		Me.textBoxAlternateDNSServer2.Text = ""
		Me.textBoxAlternateDNSServer3.Text = ""
		Me.textBoxAlternateDNSServer4.Text = ""
		Me.textBoxWINSServer1.Text = ""
		Me.textBoxWINSServer2.Text = ""
		Me.textBoxWINSServer3.Text = ""
		Me.textBoxWINSServer4.Text = ""
		'*** INTERNET ***
		Me.checkBoxUseProxySettings.Checked = False
		Me.textBoxServerAddress.Text = ""
		Me.textBoxPort.Text = ""
		Me.checkBoxBypassProxyForLocalAddresses.Checked = False
		Me.textBoxAutoConfigAddress.Text = ""
		Me.textBoxDefaultHomepage.Text = ""
		Me.checkBoxIE.Checked = False
		Me.checkBoxFirefox.Checked = False
		Me.checkBoxOpera.Checked = False
		'*** MAPPED DRIVES ***
		Me.listViewMappedDrives.Items.Clear
		'*** PRINTER ***
		Me.comboBoxPrinters.Items.Clear
		'*** RUN ***
		Me.listViewRun.Items.Clear
		'*** DESKTOP ***
		Me.comboBoxDisplaySettings.Items.Clear
		Me.comboBoxDisplayColors.Items.Clear
		Me.textBoxWallpaperPath.Text = ""
		Me.pictureBoxWallpaperPreview.Image = Nothing
		'*** WIRELESS ***
		Me.textBoxAutoActivateSSID.Text = ""
	End Sub
End Class
