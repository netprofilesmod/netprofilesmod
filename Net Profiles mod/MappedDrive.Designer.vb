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
' Date: 1/29/2007
' Time: 10:20 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MappedDrive
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MappedDrive))
		Me.comboBoxDrives = New System.Windows.Forms.ComboBox
		Me.textBoxPath = New System.Windows.Forms.TextBox
		Me.buttonBrowse = New System.Windows.Forms.Button
		Me.labelUsername = New System.Windows.Forms.Label
		Me.labelPassword = New System.Windows.Forms.Label
		Me.textBoxUsername = New System.Windows.Forms.TextBox
		Me.textBoxPassword = New System.Windows.Forms.TextBox
		Me.buttonCancel = New System.Windows.Forms.Button
		Me.buttonSave = New System.Windows.Forms.Button
		Me.labelNote = New System.Windows.Forms.Label
		Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
		Me.SuspendLayout
		'
		'comboBoxDrives
		'
		Me.comboBoxDrives.AccessibleDescription = Nothing
		Me.comboBoxDrives.AccessibleName = Nothing
		Me.comboBoxDrives.Anchor = CType(resources.GetObject("comboBoxDrives.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxDrives.BackgroundImage = Nothing
		Me.comboBoxDrives.BackgroundImageLayout = CType(resources.GetObject("comboBoxDrives.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxDrives.Dock = CType(resources.GetObject("comboBoxDrives.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxDrives.FlatStyle = CType(resources.GetObject("comboBoxDrives.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxDrives.Font = Nothing
		Me.comboBoxDrives.FormattingEnabled = true
		Me.comboBoxDrives.ImeMode = CType(resources.GetObject("comboBoxDrives.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxDrives.IntegralHeight = CType(resources.GetObject("comboBoxDrives.IntegralHeight"),Boolean)
		Me.comboBoxDrives.Location = CType(resources.GetObject("comboBoxDrives.Location"),System.Drawing.Point)
		Me.comboBoxDrives.MaxDropDownItems = CType(resources.GetObject("comboBoxDrives.MaxDropDownItems"),Integer)
		Me.comboBoxDrives.MaxLength = CType(resources.GetObject("comboBoxDrives.MaxLength"),Integer)
		Me.comboBoxDrives.Name = "comboBoxDrives"
		Me.comboBoxDrives.RightToLeft = CType(resources.GetObject("comboBoxDrives.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxDrives.Size = CType(resources.GetObject("comboBoxDrives.Size"),System.Drawing.Size)
		Me.comboBoxDrives.TabIndex = CType(resources.GetObject("comboBoxDrives.TabIndex"),Integer)
		'
		'textBoxPath
		'
		Me.textBoxPath.AccessibleDescription = Nothing
		Me.textBoxPath.AccessibleName = Nothing
		Me.textBoxPath.Anchor = CType(resources.GetObject("textBoxPath.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPath.BackgroundImage = Nothing
		Me.textBoxPath.BackgroundImageLayout = CType(resources.GetObject("textBoxPath.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPath.Dock = CType(resources.GetObject("textBoxPath.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPath.Font = Nothing
		Me.textBoxPath.ImeMode = CType(resources.GetObject("textBoxPath.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPath.Location = CType(resources.GetObject("textBoxPath.Location"),System.Drawing.Point)
		Me.textBoxPath.MaxLength = CType(resources.GetObject("textBoxPath.MaxLength"),Integer)
		Me.textBoxPath.Multiline = CType(resources.GetObject("textBoxPath.Multiline"),Boolean)
		Me.textBoxPath.Name = "textBoxPath"
		Me.textBoxPath.PasswordChar = CType(resources.GetObject("textBoxPath.PasswordChar"),Char)
		Me.textBoxPath.RightToLeft = CType(resources.GetObject("textBoxPath.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPath.ScrollBars = CType(resources.GetObject("textBoxPath.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPath.Size = CType(resources.GetObject("textBoxPath.Size"),System.Drawing.Size)
		Me.textBoxPath.TabIndex = CType(resources.GetObject("textBoxPath.TabIndex"),Integer)
		Me.textBoxPath.TextAlign = CType(resources.GetObject("textBoxPath.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.textBoxPath.WordWrap = CType(resources.GetObject("textBoxPath.WordWrap"),Boolean)
		'
		'buttonBrowse
		'
		Me.buttonBrowse.AccessibleDescription = Nothing
		Me.buttonBrowse.AccessibleName = Nothing
		Me.buttonBrowse.Anchor = CType(resources.GetObject("buttonBrowse.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonBrowse.AutoSize = CType(resources.GetObject("buttonBrowse.AutoSize"),Boolean)
		Me.buttonBrowse.AutoSizeMode = CType(resources.GetObject("buttonBrowse.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonBrowse.BackgroundImage = Nothing
		Me.buttonBrowse.BackgroundImageLayout = CType(resources.GetObject("buttonBrowse.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonBrowse.Dock = CType(resources.GetObject("buttonBrowse.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonBrowse.FlatStyle = CType(resources.GetObject("buttonBrowse.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonBrowse.Font = Nothing
		Me.buttonBrowse.Image = CType(resources.GetObject("buttonBrowse.Image"),System.Drawing.Image)
		Me.buttonBrowse.ImageAlign = CType(resources.GetObject("buttonBrowse.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonBrowse.ImageIndex = CType(resources.GetObject("buttonBrowse.ImageIndex"),Integer)
		Me.buttonBrowse.ImageKey = resources.GetString("buttonBrowse.ImageKey")
		Me.buttonBrowse.ImeMode = CType(resources.GetObject("buttonBrowse.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonBrowse.Location = CType(resources.GetObject("buttonBrowse.Location"),System.Drawing.Point)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.RightToLeft = CType(resources.GetObject("buttonBrowse.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonBrowse.Size = CType(resources.GetObject("buttonBrowse.Size"),System.Drawing.Size)
		Me.buttonBrowse.TabIndex = CType(resources.GetObject("buttonBrowse.TabIndex"),Integer)
		Me.buttonBrowse.TextAlign = CType(resources.GetObject("buttonBrowse.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonBrowse.TextImageRelation = CType(resources.GetObject("buttonBrowse.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonBrowse.UseVisualStyleBackColor = true
		AddHandler Me.buttonBrowse.Click, AddressOf Me.ButtonBrowseClick
		'
		'labelUsername
		'
		Me.labelUsername.AccessibleDescription = Nothing
		Me.labelUsername.AccessibleName = Nothing
		Me.labelUsername.Anchor = CType(resources.GetObject("labelUsername.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelUsername.AutoSize = CType(resources.GetObject("labelUsername.AutoSize"),Boolean)
		Me.labelUsername.BackgroundImageLayout = CType(resources.GetObject("labelUsername.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelUsername.Dock = CType(resources.GetObject("labelUsername.Dock"),System.Windows.Forms.DockStyle)
		Me.labelUsername.Font = Nothing
		Me.labelUsername.ImageAlign = CType(resources.GetObject("labelUsername.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelUsername.ImageIndex = CType(resources.GetObject("labelUsername.ImageIndex"),Integer)
		Me.labelUsername.ImageKey = resources.GetString("labelUsername.ImageKey")
		Me.labelUsername.ImeMode = CType(resources.GetObject("labelUsername.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelUsername.Location = CType(resources.GetObject("labelUsername.Location"),System.Drawing.Point)
		Me.labelUsername.Name = "labelUsername"
		Me.labelUsername.RightToLeft = CType(resources.GetObject("labelUsername.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelUsername.Size = CType(resources.GetObject("labelUsername.Size"),System.Drawing.Size)
		Me.labelUsername.TabIndex = CType(resources.GetObject("labelUsername.TabIndex"),Integer)
		Me.labelUsername.Text = resources.GetString("labelUsername.Text")
		Me.labelUsername.TextAlign = CType(resources.GetObject("labelUsername.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelPassword
		'
		Me.labelPassword.AccessibleDescription = Nothing
		Me.labelPassword.AccessibleName = Nothing
		Me.labelPassword.Anchor = CType(resources.GetObject("labelPassword.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelPassword.AutoSize = CType(resources.GetObject("labelPassword.AutoSize"),Boolean)
		Me.labelPassword.BackgroundImageLayout = CType(resources.GetObject("labelPassword.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelPassword.Dock = CType(resources.GetObject("labelPassword.Dock"),System.Windows.Forms.DockStyle)
		Me.labelPassword.Font = Nothing
		Me.labelPassword.ImageAlign = CType(resources.GetObject("labelPassword.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelPassword.ImageIndex = CType(resources.GetObject("labelPassword.ImageIndex"),Integer)
		Me.labelPassword.ImageKey = resources.GetString("labelPassword.ImageKey")
		Me.labelPassword.ImeMode = CType(resources.GetObject("labelPassword.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelPassword.Location = CType(resources.GetObject("labelPassword.Location"),System.Drawing.Point)
		Me.labelPassword.Name = "labelPassword"
		Me.labelPassword.RightToLeft = CType(resources.GetObject("labelPassword.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelPassword.Size = CType(resources.GetObject("labelPassword.Size"),System.Drawing.Size)
		Me.labelPassword.TabIndex = CType(resources.GetObject("labelPassword.TabIndex"),Integer)
		Me.labelPassword.Text = resources.GetString("labelPassword.Text")
		Me.labelPassword.TextAlign = CType(resources.GetObject("labelPassword.TextAlign"),System.Drawing.ContentAlignment)
		'
		'textBoxUsername
		'
		Me.textBoxUsername.AccessibleDescription = Nothing
		Me.textBoxUsername.AccessibleName = Nothing
		Me.textBoxUsername.Anchor = CType(resources.GetObject("textBoxUsername.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxUsername.BackgroundImage = Nothing
		Me.textBoxUsername.BackgroundImageLayout = CType(resources.GetObject("textBoxUsername.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxUsername.Dock = CType(resources.GetObject("textBoxUsername.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxUsername.Font = Nothing
		Me.textBoxUsername.ImeMode = CType(resources.GetObject("textBoxUsername.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxUsername.Location = CType(resources.GetObject("textBoxUsername.Location"),System.Drawing.Point)
		Me.textBoxUsername.MaxLength = CType(resources.GetObject("textBoxUsername.MaxLength"),Integer)
		Me.textBoxUsername.Multiline = CType(resources.GetObject("textBoxUsername.Multiline"),Boolean)
		Me.textBoxUsername.Name = "textBoxUsername"
		Me.textBoxUsername.PasswordChar = CType(resources.GetObject("textBoxUsername.PasswordChar"),Char)
		Me.textBoxUsername.RightToLeft = CType(resources.GetObject("textBoxUsername.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxUsername.ScrollBars = CType(resources.GetObject("textBoxUsername.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxUsername.Size = CType(resources.GetObject("textBoxUsername.Size"),System.Drawing.Size)
		Me.textBoxUsername.TabIndex = CType(resources.GetObject("textBoxUsername.TabIndex"),Integer)
		Me.textBoxUsername.TextAlign = CType(resources.GetObject("textBoxUsername.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.textBoxUsername.WordWrap = CType(resources.GetObject("textBoxUsername.WordWrap"),Boolean)
		'
		'textBoxPassword
		'
		Me.textBoxPassword.AccessibleDescription = Nothing
		Me.textBoxPassword.AccessibleName = Nothing
		Me.textBoxPassword.Anchor = CType(resources.GetObject("textBoxPassword.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxPassword.BackgroundImage = Nothing
		Me.textBoxPassword.BackgroundImageLayout = CType(resources.GetObject("textBoxPassword.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxPassword.Dock = CType(resources.GetObject("textBoxPassword.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxPassword.Font = Nothing
		Me.textBoxPassword.ImeMode = CType(resources.GetObject("textBoxPassword.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxPassword.Location = CType(resources.GetObject("textBoxPassword.Location"),System.Drawing.Point)
		Me.textBoxPassword.MaxLength = CType(resources.GetObject("textBoxPassword.MaxLength"),Integer)
		Me.textBoxPassword.Multiline = CType(resources.GetObject("textBoxPassword.Multiline"),Boolean)
		Me.textBoxPassword.Name = "textBoxPassword"
		Me.textBoxPassword.PasswordChar = CType(resources.GetObject("textBoxPassword.PasswordChar"),Char)
		Me.textBoxPassword.RightToLeft = CType(resources.GetObject("textBoxPassword.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxPassword.ScrollBars = CType(resources.GetObject("textBoxPassword.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxPassword.Size = CType(resources.GetObject("textBoxPassword.Size"),System.Drawing.Size)
		Me.textBoxPassword.TabIndex = CType(resources.GetObject("textBoxPassword.TabIndex"),Integer)
		Me.textBoxPassword.TextAlign = CType(resources.GetObject("textBoxPassword.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.textBoxPassword.UseSystemPasswordChar = true
		Me.textBoxPassword.WordWrap = CType(resources.GetObject("textBoxPassword.WordWrap"),Boolean)
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
		'labelNote
		'
		Me.labelNote.AccessibleDescription = Nothing
		Me.labelNote.AccessibleName = Nothing
		Me.labelNote.Anchor = CType(resources.GetObject("labelNote.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelNote.AutoSize = CType(resources.GetObject("labelNote.AutoSize"),Boolean)
		Me.labelNote.BackgroundImageLayout = CType(resources.GetObject("labelNote.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelNote.Dock = CType(resources.GetObject("labelNote.Dock"),System.Windows.Forms.DockStyle)
		Me.labelNote.Font = CType(resources.GetObject("labelNote.Font"),System.Drawing.Font)
		Me.labelNote.ImageAlign = CType(resources.GetObject("labelNote.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelNote.ImageIndex = CType(resources.GetObject("labelNote.ImageIndex"),Integer)
		Me.labelNote.ImageKey = resources.GetString("labelNote.ImageKey")
		Me.labelNote.ImeMode = CType(resources.GetObject("labelNote.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelNote.Location = CType(resources.GetObject("labelNote.Location"),System.Drawing.Point)
		Me.labelNote.Name = "labelNote"
		Me.labelNote.RightToLeft = CType(resources.GetObject("labelNote.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelNote.Size = CType(resources.GetObject("labelNote.Size"),System.Drawing.Size)
		Me.labelNote.TabIndex = CType(resources.GetObject("labelNote.TabIndex"),Integer)
		Me.labelNote.Text = resources.GetString("labelNote.Text")
		Me.labelNote.TextAlign = CType(resources.GetObject("labelNote.TextAlign"),System.Drawing.ContentAlignment)
		'
		'folderBrowserDialog1
		'
		Me.folderBrowserDialog1.Description = resources.GetString("folderBrowserDialog1.Description")
		Me.folderBrowserDialog1.SelectedPath = resources.GetString("folderBrowserDialog1.SelectedPath")
		'
		'MappedDrive
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
		Me.Controls.Add(Me.labelNote)
		Me.Controls.Add(Me.buttonSave)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.textBoxPassword)
		Me.Controls.Add(Me.textBoxUsername)
		Me.Controls.Add(Me.labelPassword)
		Me.Controls.Add(Me.labelUsername)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.textBoxPath)
		Me.Controls.Add(Me.comboBoxDrives)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = Nothing
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "MappedDrive"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		AddHandler Load, AddressOf Me.MappedDriveLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelUsername As System.Windows.Forms.Label
	Private labelPassword As System.Windows.Forms.Label
	Private labelNote As System.Windows.Forms.Label
	Private textBoxUsername As System.Windows.Forms.TextBox
	Private textBoxPassword As System.Windows.Forms.TextBox
	Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	Private textBoxPath As System.Windows.Forms.TextBox
	Private buttonBrowse As System.Windows.Forms.Button
	Private comboBoxDrives As System.Windows.Forms.ComboBox
	Private buttonSave As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
End Class
