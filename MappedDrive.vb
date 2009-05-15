'
' Created by SharpDevelop.
' User: DMilner
' Date: 1/29/2007
' Time: 10:20 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Partial Class MappedDrive
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
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
					If Globals.CreatingNewMappedDrive.Equals(True) Then
						AlreadyMapped = True
					End If
				End If
			Next lvi
			If AlreadyMapped = True Then
				'MessageBox.Show("This drive letter is already mapped in this profile.", "Mapped Drive")
				MessageBox.Show(Me.AlreadyMapped_Messagebox, Me.Text)
				Me.comboBoxDrives.Focus
			Else
				If Globals.CreatingNewMappedDrive = True Then
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
					If lvi.Text.Substring(0,1) = Chr(CInt(DriveNum)) And Globals.CreatingNewMappedDrive = True Then
						driveIs = " [" & Me.DriveUsed & "]"
					End If
				Next lvi
			Else
				If Globals.CreatingNewMappedDrive.Equals(False) And ProfileSettings.listViewMappedDrives.SelectedItems.Count > 0 Then
					If ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(0).Text.Substring(0,1) <> Chr(CInt(DriveNum)) Then
						driveIs = " [" & Me.DriveUsed & "]"
					End If
				Else
					driveIs = " [" & Me.DriveUsed & "]"
				End If
			End If
			Me.comboBoxDrives.Items.Add(Chr(CInt(DriveNum)) & ":" & driveIs)
		Next
		
		If Globals.CreatingNewMappedDrive = False Then
			Me.comboBoxDrives.SelectedIndex = Me.comboBoxDrives.FindStringExact(ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(0).Text)
			Me.textBoxPath.Text = ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(1).Text
			Me.textBoxUsername.Text = SubstitutionDecode(ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(2).Text)
			Me.textBoxPassword.Text = SubstitutionDecode(ProfileSettings.listViewMappedDrives.SelectedItems.Item(0).SubItems.Item(3).Text)
			'Me.buttonSave.Text = "Save"
		End If
	End Sub
	
	Public Sub LoadLanguage()
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.Text = root.SelectSingleNode("/Language/MappedDrive/WindowTitle").InnerText
		Me.labelUsername.Text = root.SelectSingleNode("/Language/MappedDrive/labelUsername").InnerText
		Me.labelPassword.Text = root.SelectSingleNode("/Language/MappedDrive/labelPassword").InnerText
		Me.labelNote.Text = root.SelectSingleNode("/Language/MappedDrive/labelNote").InnerText
		If Globals.CreatingNewMappedDrive = False Then
			Me.buttonSave.Text = root.SelectSingleNode("/Language/MappedDrive/buttonSave").InnerText
		Else
			Me.buttonSave.Text = root.SelectSingleNode("/Language/MappedDrive/buttonAdd").InnerText
		End If
		Me.buttonCancel.Text = root.SelectSingleNode("/Language/MappedDrive/buttonCancel").InnerText
		Me.AlreadyMapped_Messagebox = root.SelectSingleNode("/Language/MappedDrive/AlreadyMapped-Messagebox").InnerText
		Me.DriveUsed = root.SelectSingleNode("/Language/MappedDrive/DriveUsed").InnerText
		Globals.BrowseNetworkShare_Title = root.SelectSingleNode("/Language/Misc/BrowseNetworkShare-Title").InnerText
	End Sub
	
	Sub ButtonBrowseClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim MappedPath As String
		MappedPath = GetBrowseNetworkShare(Me.Handle.ToInt32, True, True)
		If MappedPath <> "" Then
			Me.textBoxPath.Text = MappedPath
		End If
	End Sub
End Class
