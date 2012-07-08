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
Option Strict Off
Option Explicit On
Module Encryption
	Public Function SubstitutionEncode(ByVal PlainText As String) As String
		'encodes plaintext by using a simple substitution cipher.
		Dim s As String = ""
		Dim i, j As Integer
		Const InText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkl" & "mnopqrstuvwxyz0123456789 .,?!"
		Const OUTCODE As String = "Kv iFyaehOVGpM.HfT60StRDBZ3XUmWdCo" & "P8u2,cqIwj!J9sbLnQ?EAlz7rk41xg5NY"
		For i = 1 To Len(PlainText)
			j = InStr(InText, Mid(PlainText, i, 1))
			If j Then
				s = s & Mid(OUTCODE, j, 1)
			Else
				s = s & Mid(PlainText, i, 1)
			End If
		Next i
		SubstitutionEncode = s
	End Function
	
	Public Function SubstitutionDecode(ByVal CodeText As String) As String
		'Decodes codetext by using a simple substitution cipher.
		Dim s As String = ""
		Dim i, j As Integer
		Const OUTTEXT As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkl" & "mnopqrstuvwxyz0123456789 .,?!"
		Const INCODE As String = "Kv iFyaehOVGpM.HfT60StRDBZ3XUmWdCo" & "P8u2,cqIwj!J9sbLnQ?EAlz7rk41xg5NY"
		For i = 1 To Len(CodeText)
			j = InStr(INCODE, Mid(CodeText, i, 1))
			If j Then
				s = s & Mid(OUTTEXT, j, 1)
			Else
				s = s & Mid(CodeText, i, 1)
			End If
		Next i
		SubstitutionDecode = s
	End Function
End Module
