'
' Created by SharpDevelop.
' User: DMilner
' Date: 2/8/2007
' Time: 8:30 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Partial Class WirelessDetected
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub ButtonNoClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonYesClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Hide
		AutoActivate.Show
		Me.Dispose
	End Sub
	
	Sub WirelessDetectedLoad(ByVal sender As Object, ByVal e As EventArgs)
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.Text = Globals.ProgramName & " - " & root.SelectSingleNode("/Language/WirelessDetected/WindowTitle").InnerText
		Me.labelConnectedTo.Text = root.SelectSingleNode("/Language/WirelessDetected/labelConnectedTo").InnerText
		Me.labelActivate.Text = root.SelectSingleNode("/Language/WirelessDetected/labelActivate").InnerText
		Me.buttonYes.Text = root.SelectSingleNode("/Language/WirelessDetected/buttonYes").InnerText
		Me.buttonNo.Text = root.SelectSingleNode("/Language/WirelessDetected/buttonNo").InnerText
	End Sub
End Class
