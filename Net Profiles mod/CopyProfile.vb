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
        	MessageBox.Show(Me.ProfileName_Messagebox, Globals.ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
