'
' Created by SharpDevelop.
' User: DMilner
' Date: 2/1/2007
' Time: 8:52 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Partial Class DesktopShortcut
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Dim DefaultShortcutText As String
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonRestoreDefaultsClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.textBoxShortcut.Text = MainForm.ShortcutConfigDefault
	End Sub
	
	Sub DesktopShortcutLoad(ByVal sender As Object, ByVal e As EventArgs)
		Dim ShortcutConfig As String = INIRead(ProgramINIFile,"General","DesktopShortcutConfig", "")
		If ShortcutConfig.Trim.Length > 0 Then
			If ShortcutConfig = "Activate %2 on %1" Then
				Me.textBoxShortcut.Text = MainForm.ShortcutConfigDefault
			Else
				Me.textBoxShortcut.Text = ShortcutConfig.Trim
			End If
		Else
			Me.ButtonRestoreDefaultsClick(sender, e)
		End If
		
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.Text = root.SelectSingleNode("/Language/DesktopShortcut/WindowTitle").InnerText
		Me.groupBoxLegend.Text = root.SelectSingleNode("/Language/DesktopShortcut/groupBoxLegend").InnerText
		Me.labelVar1.Text = root.SelectSingleNode("/Language/DesktopShortcut/labelVar1").InnerText
		Me.labelVar2.Text = root.SelectSingleNode("/Language/DesktopShortcut/labelVar2").InnerText
		Me.labelVar3.Text = root.SelectSingleNode("/Language/DesktopShortcut/labelVar3").InnerText
		Me.labelVar4.Text = root.SelectSingleNode("/Language/DesktopShortcut/labelVar4").InnerText
		Me.buttonRestoreDefaults.Text = root.SelectSingleNode("/Language/DesktopShortcut/buttonRestoreDefaults").InnerText
		Me.buttonSave.Text = root.SelectSingleNode("/Language/DesktopShortcut/buttonSave").InnerText
		Me.buttonCancel.Text = root.SelectSingleNode("/Language/DesktopShortcut/buttonCancel").InnerText
	End Sub
	
	Sub ButtonSaveClick(ByVal sender As Object, ByVal e As EventArgs)
		INIWrite(ProgramINIFile, "General", "DesktopShortcutConfig", Me.textBoxShortcut.Text.Trim)
		Me.Dispose
	End Sub
End Class
