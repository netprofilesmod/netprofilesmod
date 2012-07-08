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
Partial Class About
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.labelVersion = New System.Windows.Forms.Label()
		Me.labelCopyright = New System.Windows.Forms.Label()
		Me.buttonOK = New System.Windows.Forms.Button()
		Me.linkLabelHomepage = New System.Windows.Forms.LinkLabel()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		resources.ApplyResources(Me.pictureBox1, "pictureBox1")
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.TabStop = false
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'labelVersion
		'
		resources.ApplyResources(Me.labelVersion, "labelVersion")
		Me.labelVersion.Name = "labelVersion"
		'
		'labelCopyright
		'
		resources.ApplyResources(Me.labelCopyright, "labelCopyright")
		Me.labelCopyright.Name = "labelCopyright"
		'
		'buttonOK
		'
		resources.ApplyResources(Me.buttonOK, "buttonOK")
		Me.buttonOK.Name = "buttonOK"
		Me.buttonOK.UseVisualStyleBackColor = true
		'
		'linkLabelHomepage
		'
		resources.ApplyResources(Me.linkLabelHomepage, "linkLabelHomepage")
		Me.linkLabelHomepage.Name = "linkLabelHomepage"
		Me.linkLabelHomepage.TabStop = true
		'
		'About
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.linkLabelHomepage)
		Me.Controls.Add(Me.buttonOK)
		Me.Controls.Add(Me.labelCopyright)
		Me.Controls.Add(Me.labelVersion)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "About"
		Me.ShowInTaskbar = false
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
    End Sub
	Private labelVersion As System.Windows.Forms.Label
	Private labelCopyright As System.Windows.Forms.Label
	Private WithEvents linkLabelHomepage As System.Windows.Forms.LinkLabel
	Private WithEvents buttonOK As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
