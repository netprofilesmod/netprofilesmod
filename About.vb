'
' Created by SharpDevelop.
' User: Daniel Milner
' Date: 2/8/2007
' Time: 4:33 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Diagnostics.Process
Imports System.Xml
Imports System.Globalization
Imports System.Threading


Public Partial Class About

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()

        '
        ' TODO : Add constructor code after InitializeComponents
        ''
    End Sub

    Sub ButtonOKClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        Me.Dispose()
    End Sub

    Sub AboutLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call LoadLanguage()
    End Sub

    Public Sub LoadLanguage()
        Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)

        Dim xDoc As New XmlDocument
        xDoc.Load(Globals.CurrentLangPath)
        Dim root As XmlElement = xDoc.DocumentElement

        Me.Text = root.SelectSingleNode("/Language/About/WindowTitle").InnerText.Replace("%1", Globals.ProgramName)
        Me.buttonOK.Text = root.SelectSingleNode("/Language/About/buttonOK").InnerText
    End Sub

    Private Sub linkLabelHomepage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabelHomepage.LinkClicked
        Start("http://code.google.com/p/netprofiles/")
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
