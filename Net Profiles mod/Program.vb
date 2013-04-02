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
	Module Program
		 ' For using Sub Main, Windows Forms entry points has to be marked with StaThread
		<STAThread()> _
		Sub Main()
			' Main() is only used if NetProfilesMod.My.Program is set as startup object in project options.
			' Only in Main() it's early enough to set the unhandled exception.
			
			' The unhandled exception mode is set to handle all exceptions by the application.
			System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
			
			If Not Debugger.IsAttached Then
				' Adding an event handler for handling non-UI thread exceptions to prevent displaying the message
				' "Net Profiles mod has stopped working" that delivers no information about the source of the problem
				' for the user.
				AddHandler System.AppDomain.CurrentDomain.UnhandledException, AddressOf MyUnhandledExceptionHandler
			End If
			' All other exceptions will should be displayed with detailed informations by the .NET Framework Exceptions
			' dialog and don't need a handler
			
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
					System.Windows.Forms.Application.EnableVisualStyles()
					System.Windows.Forms.Application.Run(New MainForm)
				End If
			Else
				System.Windows.Forms.Application.EnableVisualStyles()
				System.Windows.Forms.Application.Run(New MainForm)
			End If
		End Sub
		
		Sub MyUnhandledExceptionHandler(ByVal sender As Object, ByVal e As System.UnhandledExceptionEventArgs)
			MessageBox.Show(e.ExceptionObject.ToString(), "Non-UI Thread Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			End
		End Sub
		
		Sub MyThreadExceptionHandler(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
			MessageBox.Show(e.Exception.ToString(), "UI Thread Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			End
		End Sub
	End Module
	
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = False ' MySettings are not supported in SharpDevelop.
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
	End Class
End Namespace
