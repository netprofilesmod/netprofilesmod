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
''
' Created by SharpDevelop.
' User: Urs Geissbühler
' Date: 09.12.2012
' Time: 21:43
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Xml
Imports System.Globalization
Imports System.Threading

Public Class SetLanguage
	Private root As XmlElement
	Private prefix As String
	
	Public Sub New(prefix As String)
		Thread.CurrentThread.CurrentCulture = New CultureInfo(CurrentLang, False)
		Dim xDoc As New XmlDocument
		xDoc.Load(CurrentLangPath)
		
		Me.prefix = prefix
		Me.root = xDoc.DocumentElement
	End Sub
	
	Public Sub SetText(ByRef control As String, ByVal node As String)
		Try
			control = Me.root.SelectSingleNode(Me.prefix & node).InnerText
		Catch
			' The text remains unchanged if the translation is missing
		End Try
	End Sub
	
	Public Sub SetText(ByRef control As String, ByVal node As String, ByVal oldValue As String, ByVal newValue As String)
		Try
			control = Me.root.SelectSingleNode(Me.prefix & node).InnerText.Replace(oldValue, newValue)
		Catch
			' The text remains unchanged if the translation is missing
		End Try
	End Sub
	
	Public Sub SetToolTip(toolTip As ToolTip, control As Control, node As String)
		Try
			toolTip.SetToolTip(control, root.SelectSingleNode(Me.prefix & node).InnerText)
		Catch
			' The tool tip will not be created or changed if the translation is missing
		End Try
	End Sub
	
	Public Sub SetToolTip(toolTip As ToolTip, control As Control, node As String, ByVal oldValue As String, ByVal newValue As String)
		Try
			toolTip.SetToolTip(control, root.SelectSingleNode(Me.prefix & node).InnerText.Replace(oldValue, newValue))
		Catch
			' The tool tip will not be created or changed if the translation is missing
		End Try
	End Sub
	
	Public Function GetText(node As String, defaultText As String) As String
		Try
			Return root.SelectSingleNode(Me.prefix & node).InnerText
		Catch
			' The default is returned if the translation is missing
			Return defaultText
		End Try
	End Function
End Class
