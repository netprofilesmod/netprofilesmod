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
Imports System.IO
Imports AppModule.Globals

Public Partial Class CopyProfile
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
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
		Dim lang As SetLanguage = New SetLanguage("/Language/CopyProfile/")
		
		lang.SetText(Me.Text, "WindowTitle")
		lang.SetText(Me.labelProfile.Text, "labelProfile")
		lang.SetText(Me.labelNewProfile.Text, "labelNewProfile")
		lang.SetText(Me.labelSelectNetworkCard.Text, "labelSelectNetworkCard")
		lang.SetText(Me.buttonCopy.Text, "buttonCopy")
		lang.SetText(Me.buttonCancel.Text, "buttonCancel")
		
		lang = New SetLanguage("/Language/ProfileSettings/")
		
		lang.SetText(Me.ProfileName_Messagebox, "ProfileName-Messagebox")
	End Sub
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonCopyClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.textBoxNewName.Text.Trim.Length = 0 Then
        	MessageBox.Show(Me.ProfileName_Messagebox, ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        	Me.textBoxNewName.Focus()
        	Exit Sub
        End If
        
		Dim TargetFile As String = ProfilesFolder & "\" & Me.comboBoxNetworkCards.SelectedValue.ToString.Replace(":", "-") & "\" & System.Guid.NewGuid.ToString & ".ini"
		Dim ThisINIFile As String = Path.GetTempFileName()
		
		Dim fFile1 As New FileInfo(MainForm.listViewProfiles.SelectedItems.Item(0).SubItems.Item(3).Text)
		fFile1.CopyTo(ThisINIFile, True)
		
		INIWrite(ThisINIFile, "General", "Name", Me.textBoxNewName.Text.Trim)
		
		If SaveProfile(ThisINIFile, TargetFile, "") Then
			'Me.Visible = False
			'Me.Opacity = "0"
			Me.Opacity = 0
			Application.DoEvents()
			Call MainForm.RefreshProfiles()
			'Me.Dispose
			Me.Close
			Me.Refresh
		End If
	End Sub
End Class
