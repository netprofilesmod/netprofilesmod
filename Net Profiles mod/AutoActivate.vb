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
' Date: 1/31/2007
' Time: 3:50 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports AppModule.Globals

Public Partial Class AutoActivate
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	Public ProfileName As String
    Public NetworkCardName As String
	
	Sub AutoActivateLoad(ByVal sender As Object, ByVal e As EventArgs)
		'TODO: Replace Microsoft.VisualBasic
		If Microsoft.VisualBasic.Command.Length > 0 Then
			Globals.INIAutoLoad = ProfilesFolder & "\" & commandArray(1) & "\" & commandArray(2)
		Else
			If MainForm.Visible.Equals(False) Then
				Globals.RunFromTaskTray = True
				MainForm.Hide
				MainForm.ShowInTaskbar = False
				MainForm.Visible = True
			End If
		End If
        Dim TheMACAddress() As String = StrReverse(Globals.INIAutoLoad).Split(CChar("\"))
		Dim UseThisMACAddress As String = StrReverse(TheMACAddress(1))
		ProfileName = INIRead(Globals.INIAutoLoad, "General", "Name", "[No Name]")
		NetworkCardName = GetInterfaceName(UseThisMACAddress)
		Me.labelTitle.Text = "Activating " & ProfileName & " on " & NetworkCardName & "..."
		Me.timer1.Enabled = True
		
		Call LoadLanguage
	End Sub
	
	Public Sub LoadLanguage()
		Dim lang As SetLanguage = New SetLanguage("/Language/AutoActivate/")
		
		lang.SetText(Me.labelTitle.Text, "labelTitle")
		Try
			Me.labelTitle.Text = Me.labelTitle.Text.Replace("%1", ProfileName).Replace("%2", NetworkCardName)
		Catch
		End Try
	End Sub
	
	Sub Timer1Tick(ByVal sender As Object, ByVal e As EventArgs)
		Me.timer1.Enabled = False
		MainForm.ApplyProfile(Globals.INIAutoLoad, "auto")
		Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
		If CommandLineArgs.Count > 0 Then
			' The program will close after the backgrundworker has applied the profile
			Globals.OKToCloseProgram = True
		Else
			If Globals.RunFromTaskTray.Equals(True) Then
				Globals.RunFromTaskTray = False
				MainForm.Visible = False
			End If
			Me.Dispose
		End If
	End Sub
End Class
