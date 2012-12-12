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
' Date: 2/1/2007
' Time: 4:09 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports AppModule.Globals

Public Partial Class RunPrograms
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Sub ButtonCancelClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.Dispose
	End Sub
	
	Sub ButtonAddClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.textBoxPath.Text.Trim <> "" Then
			If CreatingNewRunCommand = True Then
				Dim itmx As ListViewItem = ProfileSettings.listViewRun.Items.Add(Me.textBoxPath.Text.Trim)
				itmx.SubItems.Add(Me.textBoxArguments.Text.Trim)
				itmx.SubItems.Add(Me.comboBoxRun.SelectedValue.ToString)
				itmx.SubItems.Add(SubstitutionEncode(Me.textBoxUsername.Text.Trim))
				itmx.SubItems.Add(SubstitutionEncode(Me.textBoxPassword.Text.Trim))
				itmx.SubItems.Add(SubstitutionEncode(me.textBoxDomain.Text.Trim))
			Else
				ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(0).Text = Me.textBoxPath.Text.Trim
				ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(1).Text = Me.textBoxArguments.Text.Trim
				ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(2).Text = Me.comboBoxRun.SelectedValue.ToString
				ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(3).Text = SubstitutionEncode(Me.textBoxUsername.Text.Trim)
				ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(4).Text = SubstitutionEncode(Me.textBoxPassword.Text.Trim)
				ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(5).Text = SubstitutionEncode(Me.textBoxDomain.Text.Trim)
			End If
			Me.Dispose
		End If
	End Sub
	
	Sub RunProgramsLoad(ByVal sender As Object, ByVal e As EventArgs)
		If CreatingNewRunCommand = False Then
			Me.textBoxPath.Text = ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(0).Text
			Me.textBoxArguments.Text = ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(1).Text
			'Me.comboBoxRun.SelectedItem = ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(2).Text
			Me.textBoxUsername.Text = SubstitutionDecode(ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(3).Text)
			Me.textBoxPassword.Text = SubstitutionDecode(ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(4).Text)
			Me.textBoxDomain.Text = SubstitutionDecode(ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(5).Text)
			Me.buttonAdd.Text = "Save"
		Else
			Me.comboBoxRun.SelectedIndex = 0
		End If
		
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Dim lang As SetLanguage = New SetLanguage("/Language/RunPrograms/")
		
		lang.SetText(Me.Text, "WindowTitle")
		lang.SetText(Me.labelPath.Text, "labelPath")
		lang.SetText(Me.labelArgs.Text, "labelArgs")
		lang.SetText(Me.labelRun.Text, "labelRun")
		lang.SetText(Me.groupBoxCredentials.Text, "groupBoxCredentials")
		lang.SetText(Me.labelUsername.Text, "labelUsername")
		lang.SetText(Me.labelPassword.Text, "labelPassword")
		lang.SetText(Me.labelDomain.Text, "labelDomain")
		If CreatingNewRunCommand = False Then
			lang.SetText(Me.buttonAdd.Text, "buttonSave")
		Else
			lang.SetText(Me.buttonAdd.Text, "buttonAdd")
		End If
		lang.SetText(Me.buttonCancel.Text, "buttonCancel")
		
		Dim RunBoxList As New ArrayList()
		RunBoxList.Add(New DictionaryEntry("Normal", lang.getText("RunText-Normal", "Normal")))
		RunBoxList.Add(New DictionaryEntry("Minimized", lang.getText("RunText-Minimized", "Minimized")))
		RunBoxList.Add(New DictionaryEntry("Maximized", lang.getText("RunText-Maximized", "Maximized")))
		RunBoxList.Add(New DictionaryEntry("Hidden", lang.getText("RunText-Hidden", "Hidden")))
		Me.comboBoxRun.DataSource = RunBoxList
		Me.comboBoxRun.DisplayMember = "Value"
		Me.comboBoxRun.ValueMember = "Key"
		
		If CreatingNewRunCommand = False Then
			Select Case ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(2).Text
				Case "Normal":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(lang.getText("RunText-Normal", "Normal"))
				Case "Minimized":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(lang.getText("RunText-Minimized", "Minimized"))
				Case "Maximized":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(lang.getText("RunText-Maximized", "Maximized"))
				Case "Hidden":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(lang.getText("RunText-Hidden","Hidden"))
			End Select
		End If
	End Sub
	
	Sub ButtonBrowseFilesClick(ByVal sender As Object, ByVal e As EventArgs)
		Me.openFileDialog1.FileName = ""
		Me.openFileDialog1.InitialDirectory = INIRead(Globals.ProgramINIFile, "Program", "LastAddProgramDir", My.Computer.FileSystem.SpecialDirectories.Desktop)
		If Me.openFileDialog1.ShowDialog() = DialogResult.OK Then
			Me.textBoxPath.Text = Me.openFileDialog1.FileName
			INIWrite(Globals.ProgramINIFile, "Program", "LastAddProgramDir", Me.openFileDialog1.FileName.Substring(0, Me.openFileDialog1.FileName.LastIndexOf("\") + 1))
		End If
	End Sub
End Class
