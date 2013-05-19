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
' Time: 8:52 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports AppModule.Globals

Public Partial Class DesktopShortcut
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
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
		Dim lang As SetLanguage = New SetLanguage("/Language/DesktopShortcut/")
		
		lang.SetText(Me.Text, "WindowTitle")
		lang.SetText(Me.groupBoxLegend.Text, "groupBoxLegend")
		lang.SetText(Me.labelVar1.Text, "labelVar1")
		lang.SetText(Me.labelVar2.Text, "labelVar2")
		lang.SetText(Me.labelVar3.Text, "labelVar3")
		lang.SetText(Me.labelVar4.Text, "labelVar4")
		lang.SetText(Me.buttonRestoreDefaults.Text, "buttonRestoreDefaults")
		lang.SetText(Me.buttonSave.Text, "buttonSave")
		lang.SetText(Me.buttonCancel.Text, "buttonCancel")
	End Sub
	
	Sub ButtonSaveClick(ByVal sender As Object, ByVal e As EventArgs)
		INIWrite(ProgramINIFile, "General", "DesktopShortcutConfig", Me.textBoxShortcut.Text.Trim)
		Me.Dispose
	End Sub
End Class
