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
' Time: 1:47 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Option Strict On

Public Module INIFiles
	#Region "API Calls"
	' standard API declarations for INI access
	' changing only "As Long" to "As Int32" (As Integer would work also)
	Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
		Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
		ByVal lpKeyName As String, ByVal lpString As String, _
		ByVal lpFileName As String) As Int32

	Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
		Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
		ByVal lpKeyName As String, ByVal lpDefault As String, _
		ByVal lpReturnedString As String, ByVal nSize As Int32, _
		ByVal lpFileName As String) As Int32
	#End Region

    Public Function INIRead(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String, ByVal DefaultValue As String) As String
        ' primary version of call gets single value given all parameters
        Dim n As Int32
        Dim sData As String
        sData = Space$(1024) ' allocate some room
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
         sData, sData.Length, INIPath)
        If n > 0 Then ' return whatever it gave us
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
        End If
    End Function

#Region "INIRead Overloads"
    Public Function INIRead(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String) As String
        ' overload 1 assumes zero-length default
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    Public Function INIRead(ByVal INIPath As String, ByVal SectionName As String) As String
        ' overload 2 returns all keys in a given section of the given file
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    Public Function INIRead(ByVal INIPath As String) As String
        ' overload 3 returns all section names given just path
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function
#End Region

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, ByVal KeyName As String) ' delete single line from section
        Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        ' delete section from INI file
        Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    End Sub
End Module
