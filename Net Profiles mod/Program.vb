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
' Date: 1/25/2007
' Time: 10:49 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

'TODO: Replace Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports AppModule.Globals

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = False ' MySettings are not supported in SharpDevelop.
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
		End Sub

		Protected Overrides Sub OnRun()
			Try
				Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
				If CommandLineArgs.Count > 0 Then
					If CommandLineArgs(0) = "profileops" Then
						' If started with the parameter profileops, the application is started with administrator rights
						' for modifiying profiles in the ProgramData folder, without showing the GUI
						If CommandLineArgs(1) = "move" Then
							FileopSaveProfile(CommandLineArgs(2), CommandLineArgs(3))
						ElseIf CommandLineArgs(1) = "delete" Then
							FileopDelete(CommandLineArgs(2))
						End If
						'TODO: Return an exit code
					Else
						MyBase.OnRun()
					End If
				Else
					MyBase.OnRun()
				End If
			Catch ex As Exception
				MessageBox.Show(ex.ToString, ProgramName, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub	
	End Class
End Namespace
