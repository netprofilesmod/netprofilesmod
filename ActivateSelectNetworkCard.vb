'
' Created by SharpDevelop.
' User: DMilner
' Date: 2/1/2007
' Time: 3:15 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Partial Class ActivateSelectNetworkCard
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonActivateClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Visible = False
		Call MainForm.ApplyProfile(MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text, "normal", Me.comboBoxNetworkCards.SelectedValue.ToString)
		Me.Dispose
	End Sub
	
	Sub ActivateSelectNetworkCardLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.labelProfile.Text = MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(0).Text
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

		Me.Text = root.SelectSingleNode("/Language/ActivateSelectNetworkCard/WindowTitle").InnerText
		Me.labelProfileTitle.Text = root.SelectSingleNode("/Language/ActivateSelectNetworkCard/labelProfileTitle").InnerText
		Me.labelSelectNetworkCard.Text = root.SelectSingleNode("/Language/ActivateSelectNetworkCard/labelSelectNetworkCard").InnerText
		Me.buttonActivate.Text = root.SelectSingleNode("/Language/ActivateSelectNetworkCard/buttonActivate").InnerText
		Me.buttonCancel.Text = root.SelectSingleNode("/Language/ActivateSelectNetworkCard/buttonCancel").InnerText
	End Sub
End Class
