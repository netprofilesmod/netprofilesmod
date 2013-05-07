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
' Date: 1/31/2007
' Time: 3:50 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class AutoActivate
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoActivate))
		Me.labelTitle = New System.Windows.Forms.Label()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.progressBar1 = New System.Windows.Forms.ProgressBar()
		Me.labelStatus = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'labelTitle
		'
		resources.ApplyResources(Me.labelTitle, "labelTitle")
		Me.labelTitle.Name = "labelTitle"
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'progressBar1
		'
		resources.ApplyResources(Me.progressBar1, "progressBar1")
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		'
		'labelStatus
		'
		resources.ApplyResources(Me.labelStatus, "labelStatus")
		Me.labelStatus.Name = "labelStatus"
		'
		'pictureBox1
		'
		resources.ApplyResources(Me.pictureBox1, "pictureBox1")
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.TabStop = false
		'
		'AutoActivate
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = false
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.labelStatus)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.labelTitle)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "AutoActivate"
		Me.ShowInTaskbar = false
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.TopMost = true
		AddHandler Load, AddressOf Me.AutoActivateLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private labelTitle As System.Windows.Forms.Label
	Public labelStatus As System.Windows.Forms.Label
	Private progressBar1 As System.Windows.Forms.ProgressBar
	Private timer1 As System.Windows.Forms.Timer
End Class
