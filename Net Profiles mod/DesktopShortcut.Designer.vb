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
' Date: 2/1/2007
' Time: 8:52 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class DesktopShortcut
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesktopShortcut))
		Me.textBoxShortcut = New System.Windows.Forms.TextBox
		Me.groupBoxLegend = New System.Windows.Forms.GroupBox
		Me.label8 = New System.Windows.Forms.Label
		Me.label7 = New System.Windows.Forms.Label
		Me.label6 = New System.Windows.Forms.Label
		Me.label5 = New System.Windows.Forms.Label
		Me.labelVar4 = New System.Windows.Forms.Label
		Me.labelVar3 = New System.Windows.Forms.Label
		Me.labelVar2 = New System.Windows.Forms.Label
		Me.labelVar1 = New System.Windows.Forms.Label
		Me.buttonCancel = New System.Windows.Forms.Button
		Me.buttonSave = New System.Windows.Forms.Button
		Me.buttonRestoreDefaults = New System.Windows.Forms.Button
		Me.groupBoxLegend.SuspendLayout
		Me.SuspendLayout
		'
		'textBoxShortcut
		'
		Me.textBoxShortcut.AccessibleDescription = Nothing
		Me.textBoxShortcut.AccessibleName = Nothing
		Me.textBoxShortcut.Anchor = CType(resources.GetObject("textBoxShortcut.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxShortcut.BackgroundImage = Nothing
		Me.textBoxShortcut.BackgroundImageLayout = CType(resources.GetObject("textBoxShortcut.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxShortcut.Dock = CType(resources.GetObject("textBoxShortcut.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxShortcut.Font = Nothing
		Me.textBoxShortcut.ImeMode = CType(resources.GetObject("textBoxShortcut.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxShortcut.Location = CType(resources.GetObject("textBoxShortcut.Location"),System.Drawing.Point)
		Me.textBoxShortcut.MaxLength = CType(resources.GetObject("textBoxShortcut.MaxLength"),Integer)
		Me.textBoxShortcut.Multiline = CType(resources.GetObject("textBoxShortcut.Multiline"),Boolean)
		Me.textBoxShortcut.Name = "textBoxShortcut"
		Me.textBoxShortcut.PasswordChar = CType(resources.GetObject("textBoxShortcut.PasswordChar"),Char)
		Me.textBoxShortcut.RightToLeft = CType(resources.GetObject("textBoxShortcut.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxShortcut.ScrollBars = CType(resources.GetObject("textBoxShortcut.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxShortcut.Size = CType(resources.GetObject("textBoxShortcut.Size"),System.Drawing.Size)
		Me.textBoxShortcut.TabIndex = CType(resources.GetObject("textBoxShortcut.TabIndex"),Integer)
		Me.textBoxShortcut.TextAlign = CType(resources.GetObject("textBoxShortcut.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.textBoxShortcut.WordWrap = CType(resources.GetObject("textBoxShortcut.WordWrap"),Boolean)
		'
		'groupBoxLegend
		'
		Me.groupBoxLegend.AccessibleDescription = Nothing
		Me.groupBoxLegend.AccessibleName = Nothing
		Me.groupBoxLegend.Anchor = CType(resources.GetObject("groupBoxLegend.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxLegend.AutoSize = CType(resources.GetObject("groupBoxLegend.AutoSize"),Boolean)
		Me.groupBoxLegend.AutoSizeMode = CType(resources.GetObject("groupBoxLegend.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxLegend.BackgroundImage = Nothing
		Me.groupBoxLegend.BackgroundImageLayout = CType(resources.GetObject("groupBoxLegend.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxLegend.Controls.Add(Me.label8)
		Me.groupBoxLegend.Controls.Add(Me.label7)
		Me.groupBoxLegend.Controls.Add(Me.label6)
		Me.groupBoxLegend.Controls.Add(Me.label5)
		Me.groupBoxLegend.Controls.Add(Me.labelVar4)
		Me.groupBoxLegend.Controls.Add(Me.labelVar3)
		Me.groupBoxLegend.Controls.Add(Me.labelVar2)
		Me.groupBoxLegend.Controls.Add(Me.labelVar1)
		Me.groupBoxLegend.Dock = CType(resources.GetObject("groupBoxLegend.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxLegend.Font = Nothing
		Me.groupBoxLegend.ImeMode = CType(resources.GetObject("groupBoxLegend.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxLegend.Location = CType(resources.GetObject("groupBoxLegend.Location"),System.Drawing.Point)
		Me.groupBoxLegend.Name = "groupBoxLegend"
		Me.groupBoxLegend.RightToLeft = CType(resources.GetObject("groupBoxLegend.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxLegend.Size = CType(resources.GetObject("groupBoxLegend.Size"),System.Drawing.Size)
		Me.groupBoxLegend.TabIndex = CType(resources.GetObject("groupBoxLegend.TabIndex"),Integer)
		Me.groupBoxLegend.TabStop = false
		Me.groupBoxLegend.Text = resources.GetString("groupBoxLegend.Text")
		'
		'label8
		'
		Me.label8.AccessibleDescription = Nothing
		Me.label8.AccessibleName = Nothing
		Me.label8.Anchor = CType(resources.GetObject("label8.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label8.AutoSize = CType(resources.GetObject("label8.AutoSize"),Boolean)
		Me.label8.BackgroundImageLayout = CType(resources.GetObject("label8.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label8.Dock = CType(resources.GetObject("label8.Dock"),System.Windows.Forms.DockStyle)
		Me.label8.Font = Nothing
		Me.label8.ImageAlign = CType(resources.GetObject("label8.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label8.ImageIndex = CType(resources.GetObject("label8.ImageIndex"),Integer)
		Me.label8.ImageKey = resources.GetString("label8.ImageKey")
		Me.label8.ImeMode = CType(resources.GetObject("label8.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label8.Location = CType(resources.GetObject("label8.Location"),System.Drawing.Point)
		Me.label8.Name = "label8"
		Me.label8.RightToLeft = CType(resources.GetObject("label8.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label8.Size = CType(resources.GetObject("label8.Size"),System.Drawing.Size)
		Me.label8.TabIndex = CType(resources.GetObject("label8.TabIndex"),Integer)
		Me.label8.Text = resources.GetString("label8.Text")
		Me.label8.TextAlign = CType(resources.GetObject("label8.TextAlign"),System.Drawing.ContentAlignment)
		'
		'label7
		'
		Me.label7.AccessibleDescription = Nothing
		Me.label7.AccessibleName = Nothing
		Me.label7.Anchor = CType(resources.GetObject("label7.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label7.AutoSize = CType(resources.GetObject("label7.AutoSize"),Boolean)
		Me.label7.BackgroundImageLayout = CType(resources.GetObject("label7.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label7.Dock = CType(resources.GetObject("label7.Dock"),System.Windows.Forms.DockStyle)
		Me.label7.Font = Nothing
		Me.label7.ImageAlign = CType(resources.GetObject("label7.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label7.ImageIndex = CType(resources.GetObject("label7.ImageIndex"),Integer)
		Me.label7.ImageKey = resources.GetString("label7.ImageKey")
		Me.label7.ImeMode = CType(resources.GetObject("label7.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label7.Location = CType(resources.GetObject("label7.Location"),System.Drawing.Point)
		Me.label7.Name = "label7"
		Me.label7.RightToLeft = CType(resources.GetObject("label7.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label7.Size = CType(resources.GetObject("label7.Size"),System.Drawing.Size)
		Me.label7.TabIndex = CType(resources.GetObject("label7.TabIndex"),Integer)
		Me.label7.Text = resources.GetString("label7.Text")
		Me.label7.TextAlign = CType(resources.GetObject("label7.TextAlign"),System.Drawing.ContentAlignment)
		'
		'label6
		'
		Me.label6.AccessibleDescription = Nothing
		Me.label6.AccessibleName = Nothing
		Me.label6.Anchor = CType(resources.GetObject("label6.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label6.AutoSize = CType(resources.GetObject("label6.AutoSize"),Boolean)
		Me.label6.BackgroundImageLayout = CType(resources.GetObject("label6.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label6.Dock = CType(resources.GetObject("label6.Dock"),System.Windows.Forms.DockStyle)
		Me.label6.Font = Nothing
		Me.label6.ImageAlign = CType(resources.GetObject("label6.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label6.ImageIndex = CType(resources.GetObject("label6.ImageIndex"),Integer)
		Me.label6.ImageKey = resources.GetString("label6.ImageKey")
		Me.label6.ImeMode = CType(resources.GetObject("label6.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label6.Location = CType(resources.GetObject("label6.Location"),System.Drawing.Point)
		Me.label6.Name = "label6"
		Me.label6.RightToLeft = CType(resources.GetObject("label6.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label6.Size = CType(resources.GetObject("label6.Size"),System.Drawing.Size)
		Me.label6.TabIndex = CType(resources.GetObject("label6.TabIndex"),Integer)
		Me.label6.Text = resources.GetString("label6.Text")
		Me.label6.TextAlign = CType(resources.GetObject("label6.TextAlign"),System.Drawing.ContentAlignment)
		'
		'label5
		'
		Me.label5.AccessibleDescription = Nothing
		Me.label5.AccessibleName = Nothing
		Me.label5.Anchor = CType(resources.GetObject("label5.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label5.AutoSize = CType(resources.GetObject("label5.AutoSize"),Boolean)
		Me.label5.BackgroundImageLayout = CType(resources.GetObject("label5.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label5.Dock = CType(resources.GetObject("label5.Dock"),System.Windows.Forms.DockStyle)
		Me.label5.Font = Nothing
		Me.label5.ImageAlign = CType(resources.GetObject("label5.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label5.ImageIndex = CType(resources.GetObject("label5.ImageIndex"),Integer)
		Me.label5.ImageKey = resources.GetString("label5.ImageKey")
		Me.label5.ImeMode = CType(resources.GetObject("label5.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label5.Location = CType(resources.GetObject("label5.Location"),System.Drawing.Point)
		Me.label5.Name = "label5"
		Me.label5.RightToLeft = CType(resources.GetObject("label5.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label5.Size = CType(resources.GetObject("label5.Size"),System.Drawing.Size)
		Me.label5.TabIndex = CType(resources.GetObject("label5.TabIndex"),Integer)
		Me.label5.Text = resources.GetString("label5.Text")
		Me.label5.TextAlign = CType(resources.GetObject("label5.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelVar4
		'
		Me.labelVar4.AccessibleDescription = Nothing
		Me.labelVar4.AccessibleName = Nothing
		Me.labelVar4.Anchor = CType(resources.GetObject("labelVar4.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelVar4.AutoSize = CType(resources.GetObject("labelVar4.AutoSize"),Boolean)
		Me.labelVar4.BackgroundImageLayout = CType(resources.GetObject("labelVar4.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelVar4.Dock = CType(resources.GetObject("labelVar4.Dock"),System.Windows.Forms.DockStyle)
		Me.labelVar4.Font = Nothing
		Me.labelVar4.ImageAlign = CType(resources.GetObject("labelVar4.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelVar4.ImageIndex = CType(resources.GetObject("labelVar4.ImageIndex"),Integer)
		Me.labelVar4.ImageKey = resources.GetString("labelVar4.ImageKey")
		Me.labelVar4.ImeMode = CType(resources.GetObject("labelVar4.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelVar4.Location = CType(resources.GetObject("labelVar4.Location"),System.Drawing.Point)
		Me.labelVar4.Name = "labelVar4"
		Me.labelVar4.RightToLeft = CType(resources.GetObject("labelVar4.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelVar4.Size = CType(resources.GetObject("labelVar4.Size"),System.Drawing.Size)
		Me.labelVar4.TabIndex = CType(resources.GetObject("labelVar4.TabIndex"),Integer)
		Me.labelVar4.Text = resources.GetString("labelVar4.Text")
		Me.labelVar4.TextAlign = CType(resources.GetObject("labelVar4.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelVar3
		'
		Me.labelVar3.AccessibleDescription = Nothing
		Me.labelVar3.AccessibleName = Nothing
		Me.labelVar3.Anchor = CType(resources.GetObject("labelVar3.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelVar3.AutoSize = CType(resources.GetObject("labelVar3.AutoSize"),Boolean)
		Me.labelVar3.BackgroundImageLayout = CType(resources.GetObject("labelVar3.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelVar3.Dock = CType(resources.GetObject("labelVar3.Dock"),System.Windows.Forms.DockStyle)
		Me.labelVar3.Font = Nothing
		Me.labelVar3.ImageAlign = CType(resources.GetObject("labelVar3.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelVar3.ImageIndex = CType(resources.GetObject("labelVar3.ImageIndex"),Integer)
		Me.labelVar3.ImageKey = resources.GetString("labelVar3.ImageKey")
		Me.labelVar3.ImeMode = CType(resources.GetObject("labelVar3.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelVar3.Location = CType(resources.GetObject("labelVar3.Location"),System.Drawing.Point)
		Me.labelVar3.Name = "labelVar3"
		Me.labelVar3.RightToLeft = CType(resources.GetObject("labelVar3.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelVar3.Size = CType(resources.GetObject("labelVar3.Size"),System.Drawing.Size)
		Me.labelVar3.TabIndex = CType(resources.GetObject("labelVar3.TabIndex"),Integer)
		Me.labelVar3.Text = resources.GetString("labelVar3.Text")
		Me.labelVar3.TextAlign = CType(resources.GetObject("labelVar3.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelVar2
		'
		Me.labelVar2.AccessibleDescription = Nothing
		Me.labelVar2.AccessibleName = Nothing
		Me.labelVar2.Anchor = CType(resources.GetObject("labelVar2.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelVar2.AutoSize = CType(resources.GetObject("labelVar2.AutoSize"),Boolean)
		Me.labelVar2.BackgroundImageLayout = CType(resources.GetObject("labelVar2.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelVar2.Dock = CType(resources.GetObject("labelVar2.Dock"),System.Windows.Forms.DockStyle)
		Me.labelVar2.Font = Nothing
		Me.labelVar2.ImageAlign = CType(resources.GetObject("labelVar2.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelVar2.ImageIndex = CType(resources.GetObject("labelVar2.ImageIndex"),Integer)
		Me.labelVar2.ImageKey = resources.GetString("labelVar2.ImageKey")
		Me.labelVar2.ImeMode = CType(resources.GetObject("labelVar2.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelVar2.Location = CType(resources.GetObject("labelVar2.Location"),System.Drawing.Point)
		Me.labelVar2.Name = "labelVar2"
		Me.labelVar2.RightToLeft = CType(resources.GetObject("labelVar2.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelVar2.Size = CType(resources.GetObject("labelVar2.Size"),System.Drawing.Size)
		Me.labelVar2.TabIndex = CType(resources.GetObject("labelVar2.TabIndex"),Integer)
		Me.labelVar2.Text = resources.GetString("labelVar2.Text")
		Me.labelVar2.TextAlign = CType(resources.GetObject("labelVar2.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelVar1
		'
		Me.labelVar1.AccessibleDescription = Nothing
		Me.labelVar1.AccessibleName = Nothing
		Me.labelVar1.Anchor = CType(resources.GetObject("labelVar1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelVar1.AutoSize = CType(resources.GetObject("labelVar1.AutoSize"),Boolean)
		Me.labelVar1.BackgroundImageLayout = CType(resources.GetObject("labelVar1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelVar1.Dock = CType(resources.GetObject("labelVar1.Dock"),System.Windows.Forms.DockStyle)
		Me.labelVar1.Font = Nothing
		Me.labelVar1.ImageAlign = CType(resources.GetObject("labelVar1.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelVar1.ImageIndex = CType(resources.GetObject("labelVar1.ImageIndex"),Integer)
		Me.labelVar1.ImageKey = resources.GetString("labelVar1.ImageKey")
		Me.labelVar1.ImeMode = CType(resources.GetObject("labelVar1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelVar1.Location = CType(resources.GetObject("labelVar1.Location"),System.Drawing.Point)
		Me.labelVar1.Name = "labelVar1"
		Me.labelVar1.RightToLeft = CType(resources.GetObject("labelVar1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelVar1.Size = CType(resources.GetObject("labelVar1.Size"),System.Drawing.Size)
		Me.labelVar1.TabIndex = CType(resources.GetObject("labelVar1.TabIndex"),Integer)
		Me.labelVar1.Text = resources.GetString("labelVar1.Text")
		Me.labelVar1.TextAlign = CType(resources.GetObject("labelVar1.TextAlign"),System.Drawing.ContentAlignment)
		'
		'buttonCancel
		'
		Me.buttonCancel.AccessibleDescription = Nothing
		Me.buttonCancel.AccessibleName = Nothing
		Me.buttonCancel.Anchor = CType(resources.GetObject("buttonCancel.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.AutoSize = CType(resources.GetObject("buttonCancel.AutoSize"),Boolean)
		Me.buttonCancel.AutoSizeMode = CType(resources.GetObject("buttonCancel.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonCancel.BackgroundImage = Nothing
		Me.buttonCancel.BackgroundImageLayout = CType(resources.GetObject("buttonCancel.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonCancel.Dock = CType(resources.GetObject("buttonCancel.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonCancel.FlatStyle = CType(resources.GetObject("buttonCancel.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonCancel.Font = Nothing
		Me.buttonCancel.Image = CType(resources.GetObject("buttonCancel.Image"),System.Drawing.Image)
		Me.buttonCancel.ImageAlign = CType(resources.GetObject("buttonCancel.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonCancel.ImageIndex = CType(resources.GetObject("buttonCancel.ImageIndex"),Integer)
		Me.buttonCancel.ImageKey = resources.GetString("buttonCancel.ImageKey")
		Me.buttonCancel.ImeMode = CType(resources.GetObject("buttonCancel.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonCancel.Location = CType(resources.GetObject("buttonCancel.Location"),System.Drawing.Point)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.RightToLeft = CType(resources.GetObject("buttonCancel.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonCancel.Size = CType(resources.GetObject("buttonCancel.Size"),System.Drawing.Size)
		Me.buttonCancel.TabIndex = CType(resources.GetObject("buttonCancel.TabIndex"),Integer)
		Me.buttonCancel.Text = resources.GetString("buttonCancel.Text")
		Me.buttonCancel.TextAlign = CType(resources.GetObject("buttonCancel.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonCancel.TextImageRelation = CType(resources.GetObject("buttonCancel.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonCancel.UseVisualStyleBackColor = true
		AddHandler Me.buttonCancel.Click, AddressOf Me.ButtonCancelClick
		'
		'buttonSave
		'
		Me.buttonSave.AccessibleDescription = Nothing
		Me.buttonSave.AccessibleName = Nothing
		Me.buttonSave.Anchor = CType(resources.GetObject("buttonSave.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonSave.AutoSize = CType(resources.GetObject("buttonSave.AutoSize"),Boolean)
		Me.buttonSave.AutoSizeMode = CType(resources.GetObject("buttonSave.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonSave.BackgroundImage = Nothing
		Me.buttonSave.BackgroundImageLayout = CType(resources.GetObject("buttonSave.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonSave.Dock = CType(resources.GetObject("buttonSave.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonSave.FlatStyle = CType(resources.GetObject("buttonSave.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonSave.Font = Nothing
		Me.buttonSave.Image = CType(resources.GetObject("buttonSave.Image"),System.Drawing.Image)
		Me.buttonSave.ImageAlign = CType(resources.GetObject("buttonSave.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonSave.ImageIndex = CType(resources.GetObject("buttonSave.ImageIndex"),Integer)
		Me.buttonSave.ImageKey = resources.GetString("buttonSave.ImageKey")
		Me.buttonSave.ImeMode = CType(resources.GetObject("buttonSave.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonSave.Location = CType(resources.GetObject("buttonSave.Location"),System.Drawing.Point)
		Me.buttonSave.Name = "buttonSave"
		Me.buttonSave.RightToLeft = CType(resources.GetObject("buttonSave.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonSave.Size = CType(resources.GetObject("buttonSave.Size"),System.Drawing.Size)
		Me.buttonSave.TabIndex = CType(resources.GetObject("buttonSave.TabIndex"),Integer)
		Me.buttonSave.Text = resources.GetString("buttonSave.Text")
		Me.buttonSave.TextAlign = CType(resources.GetObject("buttonSave.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonSave.TextImageRelation = CType(resources.GetObject("buttonSave.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonSave.UseVisualStyleBackColor = true
		AddHandler Me.buttonSave.Click, AddressOf Me.ButtonSaveClick
		'
		'buttonRestoreDefaults
		'
		Me.buttonRestoreDefaults.AccessibleDescription = Nothing
		Me.buttonRestoreDefaults.AccessibleName = Nothing
		Me.buttonRestoreDefaults.Anchor = CType(resources.GetObject("buttonRestoreDefaults.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonRestoreDefaults.AutoSize = CType(resources.GetObject("buttonRestoreDefaults.AutoSize"),Boolean)
		Me.buttonRestoreDefaults.AutoSizeMode = CType(resources.GetObject("buttonRestoreDefaults.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonRestoreDefaults.BackgroundImage = Nothing
		Me.buttonRestoreDefaults.BackgroundImageLayout = CType(resources.GetObject("buttonRestoreDefaults.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonRestoreDefaults.Dock = CType(resources.GetObject("buttonRestoreDefaults.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonRestoreDefaults.FlatStyle = CType(resources.GetObject("buttonRestoreDefaults.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonRestoreDefaults.Font = Nothing
		Me.buttonRestoreDefaults.Image = CType(resources.GetObject("buttonRestoreDefaults.Image"),System.Drawing.Image)
		Me.buttonRestoreDefaults.ImageAlign = CType(resources.GetObject("buttonRestoreDefaults.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonRestoreDefaults.ImageIndex = CType(resources.GetObject("buttonRestoreDefaults.ImageIndex"),Integer)
		Me.buttonRestoreDefaults.ImageKey = resources.GetString("buttonRestoreDefaults.ImageKey")
		Me.buttonRestoreDefaults.ImeMode = CType(resources.GetObject("buttonRestoreDefaults.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonRestoreDefaults.Location = CType(resources.GetObject("buttonRestoreDefaults.Location"),System.Drawing.Point)
		Me.buttonRestoreDefaults.Name = "buttonRestoreDefaults"
		Me.buttonRestoreDefaults.RightToLeft = CType(resources.GetObject("buttonRestoreDefaults.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonRestoreDefaults.Size = CType(resources.GetObject("buttonRestoreDefaults.Size"),System.Drawing.Size)
		Me.buttonRestoreDefaults.TabIndex = CType(resources.GetObject("buttonRestoreDefaults.TabIndex"),Integer)
		Me.buttonRestoreDefaults.Text = resources.GetString("buttonRestoreDefaults.Text")
		Me.buttonRestoreDefaults.TextAlign = CType(resources.GetObject("buttonRestoreDefaults.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonRestoreDefaults.TextImageRelation = CType(resources.GetObject("buttonRestoreDefaults.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonRestoreDefaults.UseVisualStyleBackColor = true
		AddHandler Me.buttonRestoreDefaults.Click, AddressOf Me.ButtonRestoreDefaultsClick
		'
		'DesktopShortcut
		'
		Me.AccessibleDescription = Nothing
		Me.AccessibleName = Nothing
		Me.AutoScaleDimensions = CType(resources.GetObject("$this.AutoScaleDimensions"),System.Drawing.SizeF)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"),Boolean)
		Me.AutoSize = CType(resources.GetObject("$this.AutoSize"),Boolean)
		Me.AutoSizeMode = CType(resources.GetObject("$this.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.BackgroundImage = Nothing
		Me.BackgroundImageLayout = CType(resources.GetObject("$this.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.ClientSize = CType(resources.GetObject("$this.ClientSize"),System.Drawing.Size)
		Me.Controls.Add(Me.buttonRestoreDefaults)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.groupBoxLegend)
		Me.Controls.Add(Me.textBoxShortcut)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = Nothing
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "DesktopShortcut"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		AddHandler Load, AddressOf Me.DesktopShortcutLoad
		Me.groupBoxLegend.ResumeLayout(false)
		Me.groupBoxLegend.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private groupBoxLegend As System.Windows.Forms.GroupBox
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private labelVar4 As System.Windows.Forms.Label
	Private labelVar3 As System.Windows.Forms.Label
	Private labelVar2 As System.Windows.Forms.Label
	Private labelVar1 As System.Windows.Forms.Label
	Private textBoxShortcut As System.Windows.Forms.TextBox
	Private buttonRestoreDefaults As System.Windows.Forms.Button
	Private buttonSave As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
End Class
