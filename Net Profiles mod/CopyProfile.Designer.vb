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
' Date: 8/16/2007
' Time: 4:23 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class CopyProfile
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyProfile))
		Me.labelProfile = New System.Windows.Forms.Label
		Me.labelNewProfile = New System.Windows.Forms.Label
		Me.labelCopyThisProfile = New System.Windows.Forms.Label
		Me.textBoxNewName = New System.Windows.Forms.TextBox
		Me.labelSelectNetworkCard = New System.Windows.Forms.Label
		Me.comboBoxNetworkCards = New System.Windows.Forms.ComboBox
		Me.buttonCopy = New System.Windows.Forms.Button
		Me.buttonCancel = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'labelProfile
		'
		Me.labelProfile.AutoSize = true
		Me.labelProfile.Location = New System.Drawing.Point(12, 9)
		Me.labelProfile.Name = "labelProfile"
		Me.labelProfile.Size = New System.Drawing.Size(39, 13)
		Me.labelProfile.TabIndex = 0
		Me.labelProfile.Text = "Profile:"
		'
		'labelNewProfile
		'
		Me.labelNewProfile.AutoSize = true
		Me.labelNewProfile.Location = New System.Drawing.Point(12, 44)
		Me.labelNewProfile.Name = "labelNewProfile"
		Me.labelNewProfile.Size = New System.Drawing.Size(63, 13)
		Me.labelNewProfile.TabIndex = 1
		Me.labelNewProfile.Text = "New Name:"
		'
		'labelCopyThisProfile
		'
		Me.labelCopyThisProfile.AutoSize = true
		Me.labelCopyThisProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelCopyThisProfile.Location = New System.Drawing.Point(12, 22)
		Me.labelCopyThisProfile.Name = "labelCopyThisProfile"
		Me.labelCopyThisProfile.Size = New System.Drawing.Size(0, 13)
		Me.labelCopyThisProfile.TabIndex = 2
		'
		'textBoxNewName
		'
		Me.textBoxNewName.Location = New System.Drawing.Point(12, 60)
		Me.textBoxNewName.Name = "textBoxNewName"
		Me.textBoxNewName.Size = New System.Drawing.Size(248, 20)
		Me.textBoxNewName.TabIndex = 3
		'
		'labelSelectNetworkCard
		'
		Me.labelSelectNetworkCard.AutoSize = true
		Me.labelSelectNetworkCard.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.labelSelectNetworkCard.Location = New System.Drawing.Point(12, 83)
		Me.labelSelectNetworkCard.Name = "labelSelectNetworkCard"
		Me.labelSelectNetworkCard.Size = New System.Drawing.Size(118, 13)
		Me.labelSelectNetworkCard.TabIndex = 8
		Me.labelSelectNetworkCard.Text = "Select A Network Card:"
		'
		'comboBoxNetworkCards
		'
		Me.comboBoxNetworkCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxNetworkCards.FormattingEnabled = true
		Me.comboBoxNetworkCards.Location = New System.Drawing.Point(12, 99)
		Me.comboBoxNetworkCards.Name = "comboBoxNetworkCards"
		Me.comboBoxNetworkCards.Size = New System.Drawing.Size(248, 21)
		Me.comboBoxNetworkCards.TabIndex = 9
		'
		'buttonCopy
		'
		Me.buttonCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.buttonCopy.Image = CType(resources.GetObject("buttonCopy.Image"),System.Drawing.Image)
		Me.buttonCopy.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.buttonCopy.Location = New System.Drawing.Point(106, 133)
		Me.buttonCopy.Name = "buttonCopy"
		Me.buttonCopy.Size = New System.Drawing.Size(75, 25)
		Me.buttonCopy.TabIndex = 12
		Me.buttonCopy.Text = "Copy"
		Me.buttonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.buttonCopy.UseVisualStyleBackColor = true
		AddHandler Me.buttonCopy.Click, AddressOf Me.ButtonCopyClick
		'
		'buttonCancel
		'
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.Image = CType(resources.GetObject("buttonCancel.Image"),System.Drawing.Image)
		Me.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.buttonCancel.Location = New System.Drawing.Point(187, 133)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 25)
		Me.buttonCancel.TabIndex = 11
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.buttonCancel.UseVisualStyleBackColor = true
		AddHandler Me.buttonCancel.Click, AddressOf Me.ButtonCancelClick
		'
		'CopyProfile
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(274, 170)
		Me.Controls.Add(Me.buttonCopy)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.comboBoxNetworkCards)
		Me.Controls.Add(Me.labelSelectNetworkCard)
		Me.Controls.Add(Me.textBoxNewName)
		Me.Controls.Add(Me.labelCopyThisProfile)
		Me.Controls.Add(Me.labelNewProfile)
		Me.Controls.Add(Me.labelProfile)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = false
		Me.MaximumSize = New System.Drawing.Size(280, 195)
		Me.MinimizeBox = false
		Me.MinimumSize = New System.Drawing.Size(280, 195)
		Me.Name = "CopyProfile"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Copy Profile"
		AddHandler Load, AddressOf Me.CopyProfileLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBoxNewName As System.Windows.Forms.TextBox
	Private labelProfile As System.Windows.Forms.Label
	Private labelNewProfile As System.Windows.Forms.Label
	Private buttonCancel As System.Windows.Forms.Button
	Private buttonCopy As System.Windows.Forms.Button
	Private comboBoxNetworkCards As System.Windows.Forms.ComboBox
	Private labelSelectNetworkCard As System.Windows.Forms.Label
	Private labelCopyThisProfile As System.Windows.Forms.Label
End Class
