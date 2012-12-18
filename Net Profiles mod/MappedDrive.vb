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
' Date: 1/29/2007
' Time: 10:20 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports AppModule.Globals

Public Partial Class MappedDrive
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Public AlreadyMapped_Messagebox As String
	Public DriveUsed As String
	
	Private Declare Function GetDriveType Lib "kernel32"  Alias "GetDriveTypeA"(ByVal nDrive As String) As Integer
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonSaveClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.comboBoxDrives.Text <> "" And Me.textBoxPath.Text.Trim <> "" Then
			Dim AlreadyMapped As Boolean = False
			Dim lvi As ListViewItem
			For Each lvi In ProfileSettings.listViewMappedDrives.Items
				If lvi.Text.Substring(0,1) = Me.comboBoxDrives.Text.Substring(0,1) Then
					If ProfileSettings.listViewMappedDrives.SelectedItems.Count > 0 Then
						If ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(0).Text <> Me.comboBoxDrives.Text.Substring(0,2) Then
							AlreadyMapped = True
						End If
					End If
					If CreatingNewMappedDrive.Equals(True) Then
						AlreadyMapped = True
					End If
				End If
			Next lvi
			If AlreadyMapped = True Then
				'MessageBox.Show("This drive letter is already mapped in this profile.", "Mapped Drive")
				MessageBox.Show(Me.AlreadyMapped_Messagebox, Me.Text)
				Me.comboBoxDrives.Focus
			Else
				If CreatingNewMappedDrive = True Then
					Dim itmx As ListViewItem = ProfileSettings.listViewMappedDrives.Items.Add(Me.comboBoxDrives.Text.Substring(0, 2))
					itmx.SubItems.Add(Me.textBoxPath.Text.Trim)
					itmx.SubItems.Add(SubstitutionEncode(Me.textBoxUsername.Text.Trim))
					itmx.SubItems.Add(SubstitutionEncode(Me.textBoxPassword.Text.Trim))
					itmx.ImageIndex = 0
				Else
					ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(0).Text = Me.comboBoxDrives.Text.Substring(0, 2)
					ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(1).Text = Me.textBoxPath.Text.Trim
					ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(2).Text = SubstitutionEncode(Me.textBoxUsername.Text.Trim)
					ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(3).Text = SubstitutionEncode(Me.textBoxPassword.Text.Trim)
				End If
				Me.Dispose
			End If
		End If
	End Sub
	
	Sub MappedDriveLoad(ByVal sender As Object, ByVal e As EventArgs)
		Call LoadLanguage
		Dim i As Object
		Dim DriveNum As String
		DriveNum = CStr(64)
		Dim driveIs As String = ""
		Dim lvi As ListViewItem
		For i = 0 To 25
			DriveNum = CStr(CDbl(DriveNum) + 1)
			If GetDriveType(Chr(CInt(DriveNum)) & ":\") = 1 Then
				driveIs = ""
				For Each lvi In ProfileSettings.listViewMappedDrives.Items
					If lvi.Text.Substring(0,1) = Chr(CInt(DriveNum)) And CreatingNewMappedDrive = True Then
						driveIs = " [" & Me.DriveUsed & "]"
					End If
				Next lvi
			Else
				If CreatingNewMappedDrive.Equals(False) And ProfileSettings.listViewMappedDrives.SelectedItems.Count > 0 Then
					If ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(0).Text.Substring(0,1) <> Chr(CInt(DriveNum)) Then
						driveIs = " [" & Me.DriveUsed & "]"
					End If
				Else
					driveIs = " [" & Me.DriveUsed & "]"
				End If
			End If
			Me.comboBoxDrives.Items.Add(Chr(CInt(DriveNum)) & ":" & driveIs)
		Next
		
		If CreatingNewMappedDrive = False Then
			Me.comboBoxDrives.SelectedIndex = Me.comboBoxDrives.FindStringExact(ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(0).Text)
			Me.textBoxPath.Text = ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(1).Text
			Me.textBoxUsername.Text = SubstitutionDecode(ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(2).Text)
			Me.textBoxPassword.Text = SubstitutionDecode(ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(3).Text)
			'Me.buttonSave.Text = "Save"
		End If
	End Sub
	
	Public Sub LoadLanguage()
		Dim lang As SetLanguage = New SetLanguage("/Language/MappedDrive/")
		
		lang.SetText(Me.Text, "WindowTitle")
		lang.SetText(Me.labelUsername.Text, "labelUsername")
		lang.SetText(Me.labelPassword.Text, "labelPassword")
		lang.SetText(Me.labelNote.Text, "labelNote")
		If CreatingNewMappedDrive = False Then
			lang.SetText(Me.buttonSave.Text, "buttonSave")
		Else
			lang.SetText(Me.buttonSave.Text, "buttonAdd")
		End If
		lang.SetText(Me.buttonCancel.Text, "buttonCancel")
		lang.SetText(Me.AlreadyMapped_Messagebox, "AlreadyMapped-Messagebox")
		lang.SetText(Me.DriveUsed, "DriveUsed")
		
		lang = New SetLanguage("/Language/Misc/")
		
		lang.SetText(Globals.BrowseNetworkShare_Title, "BrowseNetworkShare-Title")
	End Sub
	
	Sub ButtonBrowseClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim MappedPath As String
		Dim objFolderDialog As New FolderBrowserDialog()
		MappedPath = GetNetworkFolders(objFolderDialog)
		If MappedPath <> "" Then
			Me.textBoxPath.Text = MappedPath
		End If
	End Sub
End Class
