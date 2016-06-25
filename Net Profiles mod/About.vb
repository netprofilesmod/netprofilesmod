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
' User: Daniel Milner
' Date: 2/8/2007
' Time: 4:33 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Diagnostics.Process
Imports AppModule.Globals

Public Partial Class About

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()
        
        labelVersion.Text = "Version " & ProgramVersion
    End Sub

    Sub ButtonOKClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        Me.Dispose()
    End Sub

    Sub AboutLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call LoadLanguage()
    End Sub

    Public Sub LoadLanguage()
        Dim lang As SetLanguage = New SetLanguage("/Language/About/")

        lang.SetText(Me.Text, "WindowTitle", "%1", ProgramName)
        lang.SetText(Me.buttonOK.Text, "buttonOK")
    End Sub

    Private Sub linkLabelHomepage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabelHomepage.LinkClicked
        Start("https://github.com/netprofilesmod/netprofilesmod")
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
