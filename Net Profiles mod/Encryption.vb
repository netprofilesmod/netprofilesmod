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
