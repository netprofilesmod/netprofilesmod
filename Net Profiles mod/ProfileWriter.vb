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
Public Module ProfileWriter
	Function SaveProfile(SourceFile As String, TargetFile As String) As Boolean
		Try
			Return ElevatedProcess("move """ & SourceFile & """ """ & TargetFile & """")
		Catch
			Return False
		End Try
	End Function
	
	Function RemoveProfile(TargetFile As String) As Boolean
		Try
			ElevatedProcess("delete """ & TargetFile & """")
			Return True
		Catch
			Return False
		End Try
	End Function
	
	Function ElevatedProcess(Arguments As String) As Boolean
		Dim FileOpsProcess As New Process()
		FileOpsProcess.StartInfo.FileName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe"
		FileOpsProcess.StartInfo.Arguments = "profileops " & Arguments
		' Start an elevated process
		FileOpsProcess.StartInfo.Verb = "runas"
		FileOpsProcess.Start()
		Return FileOpsProcess.WaitForExit(5000)
		'TODO: Return the exit code, raise an exception if WaitForExit() returns False
	End Function
End Module
