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

Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	Module Program
		
		Class AppMain
			Inherits WindowsFormsApplicationBase
			
			Public Sub New()
				MyBase.New(AuthenticationMode.Windows)
				Me.IsSingleInstance = False
				Me.SaveMySettingsOnExit = False
				Me.MainForm = My.Forms.MainForm
				Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
			End Sub
		End Class
		
		
		' For using Sub Main, Windows Forms entry points has to be marked with StaThread
		<STAThread()> _
		Sub Main()
			' Only in Main() it's early enough to set the unhandled exception mode to catch all exceptions.
			' Main() is only used if NetProfilesMod.My.Program is set as startup object in project options.
			
			System.Windows.Forms.Application.EnableVisualStyles()
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)
			
			' Set the unhandled exception mode to handle all Windows Forms errors by the application.
			' Otherwise some exceptions (for example in MainFormLoad()) are not catched if running with the debugger
			' attached, but a .NET Framework exception dialog will be shown if run without the debugger.
			System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
			
			If Not Debugger.IsAttached Then
				' Adding an event handler for handling non-UI thread exceptions to prevent displaying the message
				' "Net Profiles mod has stopped working" that delivers no information about the source of the problem
				' for the user.
				AddHandler System.AppDomain.CurrentDomain.UnhandledException, AddressOf UnhandledExceptionHandler
				
				' Add an event handler for handling UI thread exceptions (for example raised in MainFormLoad())
				AddHandler System.Windows.Forms.Application.ThreadException, AddressOf ThreadExceptionHandler
			End If
			
			Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
			If CommandLineArgs.Count > 0 Then
				If CommandLineArgs(0) = "profileops" Then
					' If started with the parameter profileops, the application is started with administrator rights
					' for modifiying profiles in the ProgramData folder, without showing the GUI
					If CommandLineArgs(1) = "move" Then
						FileopSaveProfile(CommandLineArgs(2), CommandLineArgs(3), CommandLineArgs(4))
					ElseIf CommandLineArgs(1) = "delete" Then
						FileopDelete(CommandLineArgs(2))
					End If
					'TODO: Return an exit code
					Exit Sub
				End If
			End If
			
			Dim app As New AppMain()
			app.Run(New String(0) {})
		End Sub
		
		Sub UnhandledExceptionHandler(ByVal sender As Object, ByVal e As System.UnhandledExceptionEventArgs)
			ShowException(e.ExceptionObject.ToString(), "Non-UI Thread Exception")
			End
		End Sub
		
		Sub ThreadExceptionHandler(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
			ShowException(e.Exception.ToString(), "UI Thread Exception")
			End
		End Sub
	End Module
End Namespace
