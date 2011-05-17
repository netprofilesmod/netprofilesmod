'
' Created by SharpDevelop.
' User: DMilner
' Date: 8/16/2007
' Time: 4:23 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Xml
Imports System.Globalization
Imports System.Threading
Imports System.IO

Public Partial Class CopyProfile
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Public ProfileName_Messagebox As String
	
	Sub CopyProfileLoad(ByVal sender As Object, ByVal e As EventArgs)
        'Me.Opacity = "1"
        Me.Opacity = 1
		Me.labelCopyThisProfile.Text = MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(0).Text
		Me.textBoxNewName.Text = "Copy of " & Me.labelCopyThisProfile.Text
		Me.comboBoxNetworkCards.DataSource = NetworkCardList
		Me.comboBoxNetworkCards.DisplayMember = "Value"
		Me.comboBoxNetworkCards.ValueMember = "Key"
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.Text = root.SelectSingleNode("/Language/CopyProfile/WindowTitle").InnerText
		Me.labelProfile.Text = root.SelectSingleNode("/Language/CopyProfile/labelProfile").InnerText
		Me.labelNewProfile.Text = root.SelectSingleNode("/Language/CopyProfile/labelNewProfile").InnerText
		Me.labelSelectNetworkCard.Text = root.SelectSingleNode("/Language/CopyProfile/labelSelectNetworkCard").InnerText
		Me.buttonCopy.Text = root.SelectSingleNode("/Language/CopyProfile/buttonCopy").InnerText
		Me.buttonCancel.Text = root.SelectSingleNode("/Language/CopyProfile/buttonCancel").InnerText
		Me.ProfileName_Messagebox = root.SelectSingleNode("/Language/ProfileSettings/ProfileName-Messagebox").InnerText
	End Sub
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonCopyClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.textBoxNewName.Text.Trim.Length = 0 Then
        	'MessageBox.Show("Please enter a name for this profile.", "Net Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
        	MessageBox.Show(Me.ProfileName_Messagebox, "Net Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
        	Me.textBoxNewName.Focus()
        	Exit Sub
        End If
        
        If Dir(My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-"), FileAttribute.Directory) = "" Then
			MkDir((My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-")))
		End If
		
		Dim ThisINIFile As String = My.Application.Info.DirectoryPath & "\profiles\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-") & "\" & System.Guid.NewGuid.ToString & ".ini"
		
		Dim fFile1 As New FileInfo(MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text)
		fFile1.CopyTo(ThisINIFile, True)
		
		INIWrite(ThisINIFile, "General", "Name", Me.textBoxNewName.Text.Trim)
		
		'Me.Visible = False
        'Me.Opacity = "0"
        Me.Opacity = 0
        Application.DoEvents()
        Call MainForm.RefreshProfiles()
        'Me.Dispose
        Me.Close
        Me.Refresh
	End Sub
End Class
