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
' User: Urs Geissbühler
' Date: 02.12.2012
' Time: 19:18
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports AppModule.Globals

Public Module ProfileWriter
	Function SaveProfile(SourceFile As String, TargetFile As String, OldLocation As String) As Boolean
		Try
			Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
			If osInfo.Version.Major < 6 Then
				' On XP try to save the profile without raising a Run As dialog
				' This will fail if the user is not an administrator
				FileopSaveProfile(SourceFile, TargetFile, OldLocation)
				Return True
			Else
				' On Vista or newer, with UAC enabled, prevent writing the profile to the VirtualStore
				Throw New Exception()
			End If
		Catch
			Try
				' Using the elevated process for saving the profile ensures write access to the profiles folder
				Return ElevatedProcess("move """ & SourceFile & """ """ & TargetFile & """ """ & OldLocation & """")
			Catch
				Return False
			End Try
		End Try
	End Function
	
	Function RemoveProfile(TargetFile As String) As Boolean
		Try
			Dim osInfo As System.OperatingSystem = System.Environment.OSVersion
			If osInfo.Version.Major < 6 Then
				' On XP try to delete the profile without raising a Run As dialog
				FileopDelete(TargetFile)
				Return True
			Else
				' On Vista or newer, with UAC enabled, deleting the profile would fail
				Throw New Exception()
			End If
		Catch	
			Try
				' Using the elevated process for saving the profile ensures write access to the profiles folder
				ElevatedProcess("delete """ & TargetFile & """")
				Return True
			Catch
				Return False
			End Try
		End Try
	End Function
	
	Function ElevatedProcess(Arguments As String) As Boolean
		' Starts an elevated copy of the current process with command line parameters for write access to the
		' protected profiles folder
		Dim FileOpsProcess As New Process()
		' Path of current executable
		FileOpsProcess.StartInfo.FileName = System.Reflection.Assembly.GetEntryAssembly().Location
		FileOpsProcess.StartInfo.Arguments = "profileops " & Arguments
		' Start the process elevated
		FileOpsProcess.StartInfo.Verb = "runas"
		FileOpsProcess.Start()
		Return FileOpsProcess.WaitForExit(5000)
		'TODO: Return the exit code, raise an exception if WaitForExit() returns False
	End Function
	
	Sub FileopSaveProfile(SourceFile As String, TargetFile As String, OldLocation As String)
		Dim Target() As String = TargetFile.Split(CChar("\"))
		Dim TargetFolder As String = Target(Target.Length - 2)
		' Make sure the subfolder named after the MAC address exists
		If Not System.IO.Directory.Exists(ProfilesFolder + "\" + TargetFolder)  Then
			MkDir(ProfilesFolder + "\" + TargetFolder)
		End If
		' Just moving the profile would keep the write permissions for the user and allow him to modify the profile
		' without administrator permissions, therfore it's copied from the temp folder and then deleted
		System.IO.File.Copy(SourceFile, TargetFile, True)
		System.IO.File.Delete(SourceFile)
		If OldLocation.Length
			System.IO.File.Delete(OldLocation)
		End If
	End Sub
	
	Sub FileopDelete(TargetFile As String)
		System.IO.File.Delete(TargetFile)
	End Sub	
End Module
