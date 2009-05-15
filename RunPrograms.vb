'
' Created by SharpDevelop.
' User: DMilner
' Date: 2/1/2007
' Time: 4:09 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Partial Class RunPrograms
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
	
	Sub ButtonAddClick(ByVal sender As Object, ByVal e As EventArgs)
		If Me.textBoxPath.Text.Trim <> "" Then
			If Globals.CreatingNewRunCommand = True Then
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
		If Globals.CreatingNewRunCommand = False Then
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
		Thread.CurrentThread.CurrentCulture = New CultureInfo(Globals.CurrentLang, False)
		
		Dim xDoc As New XmlDocument
		xDoc.Load(Globals.CurrentLangPath)
		Dim root As XmlElement = xDoc.DocumentElement

		Me.Text = root.SelectSingleNode("/Language/RunPrograms/WindowTitle").InnerText
		Me.labelPath.Text = root.SelectSingleNode("/Language/RunPrograms/labelPath").InnerText
		Me.labelArgs.Text = root.SelectSingleNode("/Language/RunPrograms/labelArgs").InnerText
		Me.labelRun.Text = root.SelectSingleNode("/Language/RunPrograms/labelRun").InnerText
		Me.groupBoxCredentials.Text = root.SelectSingleNode("/Language/RunPrograms/groupBoxCredentials").InnerText
		Me.labelUsername.Text = root.SelectSingleNode("/Language/RunPrograms/labelUsername").InnerText
		Me.labelPassword.Text = root.SelectSingleNode("/Language/RunPrograms/labelPassword").InnerText
		Me.labelDomain.Text = root.SelectSingleNode("/Language/RunPrograms/labelDomain").InnerText
		If Globals.CreatingNewRunCommand = False Then
			Me.buttonAdd.Text = root.SelectSingleNode("/Language/RunPrograms/buttonSave").InnerText
		Else
			Me.buttonAdd.Text = root.SelectSingleNode("/Language/RunPrograms/buttonAdd").InnerText
		End If
		Me.buttonCancel.Text = root.SelectSingleNode("/Language/RunPrograms/buttonCancel").InnerText
		
		Dim RunBoxList As New ArrayList()
		RunBoxList.Add(New DictionaryEntry("Normal", root.SelectSingleNode("/Language/RunPrograms/RunText-Normal").InnerText))
		RunBoxList.Add(New DictionaryEntry("Minimized", root.SelectSingleNode("/Language/RunPrograms/RunText-Minimized").InnerText))
		RunBoxList.Add(New DictionaryEntry("Maximized", root.SelectSingleNode("/Language/RunPrograms/RunText-Maximized").InnerText))
		RunBoxList.Add(New DictionaryEntry("Hidden", root.SelectSingleNode("/Language/RunPrograms/RunText-Hidden").InnerText))
		Me.comboBoxRun.DataSource = RunBoxList
		Me.comboBoxRun.DisplayMember = "Value"
		Me.comboBoxRun.ValueMember = "Key"
		
		If Globals.CreatingNewRunCommand = False Then
			Select Case ProfileSettings.listViewRun.SelectedItems.Item(0).SubItems.Item(2).Text
				Case "Normal":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(root.SelectSingleNode("/Language/RunPrograms/RunText-Normal").InnerText)
				Case "Minimized":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(root.SelectSingleNode("/Language/RunPrograms/RunText-Minimized").InnerText)
				Case "Maximized":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(root.SelectSingleNode("/Language/RunPrograms/RunText-Maximized").InnerText)
				Case "Hidden":
					Me.comboBoxRun.SelectedIndex = Me.comboBoxRun.FindStringExact(root.SelectSingleNode("/Language/RunPrograms/RunText-Hidden").InnerText)
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
