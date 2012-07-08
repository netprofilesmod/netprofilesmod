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
' Time: 4:09 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class RunPrograms
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RunPrograms))
		Me.labelPath = New System.Windows.Forms.Label
		Me.textBoxPath = New System.Windows.Forms.TextBox
		Me.textBoxArguments = New System.Windows.Forms.TextBox
		Me.labelArgs = New System.Windows.Forms.Label
		Me.buttonBrowseFiles = New System.Windows.Forms.Button
		Me.buttonCancel = New System.Windows.Forms.Button
		Me.buttonAdd = New System.Windows.Forms.Button
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
		Me.labelRun = New System.Windows.Forms.Label
		Me.comboBoxRun = New System.Windows.Forms.ComboBox
		Me.groupBoxCredentials = New System.Windows.Forms.GroupBox
		Me.textBoxDomain = New System.Windows.Forms.TextBox
		Me.textBoxPassword = New System.Windows.Forms.TextBox
		Me.textBoxUsername = New System.Windows.Forms.TextBox
		Me.labelDomain = New System.Windows.Forms.Label
		Me.labelPassword = New System.Windows.Forms.Label
		Me.labelUsername = New System.Windows.Forms.Label
		Me.groupBoxCredentials.SuspendLayout
		Me.SuspendLayout
		'
		'labelPath
		'
		Me.labelPath.AccessibleDescription = Nothing
		Me.labelPath.AccessibleName = Nothing
		Me.labelPath.Anchor = CType(resources.GetObject("labelPath.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelPath.AutoSize = CType(resources.GetObject("labelPath.AutoSize"),Boolean)
		Me.labelPath.BackgroundImageLayout = CType(resources.GetObject("labelPath.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelPath.Dock = CType(resources.GetObject("labelPath.Dock"),System.Windows.Forms.DockStyle)
		Me.labelPath.Font = Nothing
		Me.labelPath.ImageAlign = CType(resources.GetObject("labelPath.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelPath.ImageIndex = CType(resources.GetObject("labelPath.ImageIndex"),Integer)
		Me.labelPath.ImageKey = resources.GetString("labelPath.ImageKey")
		Me.labelPath.ImeMode = CType(resources.GetObject("labelPath.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelPath.Location = CType(resources.GetObject("labelPath.Location"),System.Drawing.Point)
		Me.labelPath.Name = "labelPath"
		Me.labelPath.RightToLeft = CType(resources.GetObject("labelPath.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelPath.Size = CType(resources.GetObject("labelPath.Size"),System.Drawing.Size)
		Me.labelPath.TabIndex = CType(resources.GetObject("labelPath.TabIndex"),Integer)
		Me.labelPath.Text = resources.GetString("labelPath.Text")
		Me.labelPath.TextAlign = CType(resources.GetObject("labelPath.TextAlign"),System.Drawing.ContentAlignment)
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
		'textBoxArguments
		'
		Me.textBoxArguments.AccessibleDescription = Nothing
		Me.textBoxArguments.AccessibleName = Nothing
		Me.textBoxArguments.Anchor = CType(resources.GetObject("textBoxArguments.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxArguments.BackgroundImage = Nothing
		Me.textBoxArguments.BackgroundImageLayout = CType(resources.GetObject("textBoxArguments.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxArguments.Dock = CType(resources.GetObject("textBoxArguments.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxArguments.Font = Nothing
		Me.textBoxArguments.ImeMode = CType(resources.GetObject("textBoxArguments.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxArguments.Location = CType(resources.GetObject("textBoxArguments.Location"),System.Drawing.Point)
		Me.textBoxArguments.MaxLength = CType(resources.GetObject("textBoxArguments.MaxLength"),Integer)
		Me.textBoxArguments.Multiline = CType(resources.GetObject("textBoxArguments.Multiline"),Boolean)
		Me.textBoxArguments.Name = "textBoxArguments"
		Me.textBoxArguments.PasswordChar = CType(resources.GetObject("textBoxArguments.PasswordChar"),Char)
		Me.textBoxArguments.RightToLeft = CType(resources.GetObject("textBoxArguments.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxArguments.ScrollBars = CType(resources.GetObject("textBoxArguments.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxArguments.Size = CType(resources.GetObject("textBoxArguments.Size"),System.Drawing.Size)
		Me.textBoxArguments.TabIndex = CType(resources.GetObject("textBoxArguments.TabIndex"),Integer)
		Me.textBoxArguments.TextAlign = CType(resources.GetObject("textBoxArguments.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.textBoxArguments.WordWrap = CType(resources.GetObject("textBoxArguments.WordWrap"),Boolean)
		'
		'labelArgs
		'
		Me.labelArgs.AccessibleDescription = Nothing
		Me.labelArgs.AccessibleName = Nothing
		Me.labelArgs.Anchor = CType(resources.GetObject("labelArgs.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelArgs.AutoSize = CType(resources.GetObject("labelArgs.AutoSize"),Boolean)
		Me.labelArgs.BackgroundImageLayout = CType(resources.GetObject("labelArgs.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelArgs.Dock = CType(resources.GetObject("labelArgs.Dock"),System.Windows.Forms.DockStyle)
		Me.labelArgs.Font = Nothing
		Me.labelArgs.ImageAlign = CType(resources.GetObject("labelArgs.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelArgs.ImageIndex = CType(resources.GetObject("labelArgs.ImageIndex"),Integer)
		Me.labelArgs.ImageKey = resources.GetString("labelArgs.ImageKey")
		Me.labelArgs.ImeMode = CType(resources.GetObject("labelArgs.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelArgs.Location = CType(resources.GetObject("labelArgs.Location"),System.Drawing.Point)
		Me.labelArgs.Name = "labelArgs"
		Me.labelArgs.RightToLeft = CType(resources.GetObject("labelArgs.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelArgs.Size = CType(resources.GetObject("labelArgs.Size"),System.Drawing.Size)
		Me.labelArgs.TabIndex = CType(resources.GetObject("labelArgs.TabIndex"),Integer)
		Me.labelArgs.Text = resources.GetString("labelArgs.Text")
		Me.labelArgs.TextAlign = CType(resources.GetObject("labelArgs.TextAlign"),System.Drawing.ContentAlignment)
		'
		'buttonBrowseFiles
		'
		Me.buttonBrowseFiles.AccessibleDescription = Nothing
		Me.buttonBrowseFiles.AccessibleName = Nothing
		Me.buttonBrowseFiles.Anchor = CType(resources.GetObject("buttonBrowseFiles.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonBrowseFiles.AutoSize = CType(resources.GetObject("buttonBrowseFiles.AutoSize"),Boolean)
		Me.buttonBrowseFiles.AutoSizeMode = CType(resources.GetObject("buttonBrowseFiles.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonBrowseFiles.BackgroundImage = Nothing
		Me.buttonBrowseFiles.BackgroundImageLayout = CType(resources.GetObject("buttonBrowseFiles.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonBrowseFiles.Dock = CType(resources.GetObject("buttonBrowseFiles.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonBrowseFiles.FlatStyle = CType(resources.GetObject("buttonBrowseFiles.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonBrowseFiles.Font = Nothing
		Me.buttonBrowseFiles.Image = CType(resources.GetObject("buttonBrowseFiles.Image"),System.Drawing.Image)
		Me.buttonBrowseFiles.ImageAlign = CType(resources.GetObject("buttonBrowseFiles.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonBrowseFiles.ImageIndex = CType(resources.GetObject("buttonBrowseFiles.ImageIndex"),Integer)
		Me.buttonBrowseFiles.ImageKey = resources.GetString("buttonBrowseFiles.ImageKey")
		Me.buttonBrowseFiles.ImeMode = CType(resources.GetObject("buttonBrowseFiles.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonBrowseFiles.Location = CType(resources.GetObject("buttonBrowseFiles.Location"),System.Drawing.Point)
		Me.buttonBrowseFiles.Name = "buttonBrowseFiles"
		Me.buttonBrowseFiles.RightToLeft = CType(resources.GetObject("buttonBrowseFiles.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonBrowseFiles.Size = CType(resources.GetObject("buttonBrowseFiles.Size"),System.Drawing.Size)
		Me.buttonBrowseFiles.TabIndex = CType(resources.GetObject("buttonBrowseFiles.TabIndex"),Integer)
		Me.buttonBrowseFiles.TextAlign = CType(resources.GetObject("buttonBrowseFiles.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonBrowseFiles.TextImageRelation = CType(resources.GetObject("buttonBrowseFiles.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonBrowseFiles.UseVisualStyleBackColor = true
		AddHandler Me.buttonBrowseFiles.Click, AddressOf Me.ButtonBrowseFilesClick
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
		'buttonAdd
		'
		Me.buttonAdd.AccessibleDescription = Nothing
		Me.buttonAdd.AccessibleName = Nothing
		Me.buttonAdd.Anchor = CType(resources.GetObject("buttonAdd.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonAdd.AutoSize = CType(resources.GetObject("buttonAdd.AutoSize"),Boolean)
		Me.buttonAdd.AutoSizeMode = CType(resources.GetObject("buttonAdd.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonAdd.BackgroundImage = Nothing
		Me.buttonAdd.BackgroundImageLayout = CType(resources.GetObject("buttonAdd.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonAdd.Dock = CType(resources.GetObject("buttonAdd.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonAdd.FlatStyle = CType(resources.GetObject("buttonAdd.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonAdd.Font = Nothing
		Me.buttonAdd.Image = CType(resources.GetObject("buttonAdd.Image"),System.Drawing.Image)
		Me.buttonAdd.ImageAlign = CType(resources.GetObject("buttonAdd.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonAdd.ImageIndex = CType(resources.GetObject("buttonAdd.ImageIndex"),Integer)
		Me.buttonAdd.ImageKey = resources.GetString("buttonAdd.ImageKey")
		Me.buttonAdd.ImeMode = CType(resources.GetObject("buttonAdd.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonAdd.Location = CType(resources.GetObject("buttonAdd.Location"),System.Drawing.Point)
		Me.buttonAdd.Name = "buttonAdd"
		Me.buttonAdd.RightToLeft = CType(resources.GetObject("buttonAdd.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonAdd.Size = CType(resources.GetObject("buttonAdd.Size"),System.Drawing.Size)
		Me.buttonAdd.TabIndex = CType(resources.GetObject("buttonAdd.TabIndex"),Integer)
		Me.buttonAdd.Text = resources.GetString("buttonAdd.Text")
		Me.buttonAdd.TextAlign = CType(resources.GetObject("buttonAdd.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonAdd.TextImageRelation = CType(resources.GetObject("buttonAdd.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonAdd.UseVisualStyleBackColor = true
		AddHandler Me.buttonAdd.Click, AddressOf Me.ButtonAddClick
		'
		'openFileDialog1
		'
		Me.openFileDialog1.FileName = "openFileDialog1"
		Me.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter")
		Me.openFileDialog1.Title = resources.GetString("openFileDialog1.Title")
		'
		'labelRun
		'
		Me.labelRun.AccessibleDescription = Nothing
		Me.labelRun.AccessibleName = Nothing
		Me.labelRun.Anchor = CType(resources.GetObject("labelRun.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelRun.AutoSize = CType(resources.GetObject("labelRun.AutoSize"),Boolean)
		Me.labelRun.BackgroundImageLayout = CType(resources.GetObject("labelRun.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelRun.Dock = CType(resources.GetObject("labelRun.Dock"),System.Windows.Forms.DockStyle)
		Me.labelRun.Font = Nothing
		Me.labelRun.ImageAlign = CType(resources.GetObject("labelRun.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelRun.ImageIndex = CType(resources.GetObject("labelRun.ImageIndex"),Integer)
		Me.labelRun.ImageKey = resources.GetString("labelRun.ImageKey")
		Me.labelRun.ImeMode = CType(resources.GetObject("labelRun.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelRun.Location = CType(resources.GetObject("labelRun.Location"),System.Drawing.Point)
		Me.labelRun.Name = "labelRun"
		Me.labelRun.RightToLeft = CType(resources.GetObject("labelRun.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelRun.Size = CType(resources.GetObject("labelRun.Size"),System.Drawing.Size)
		Me.labelRun.TabIndex = CType(resources.GetObject("labelRun.TabIndex"),Integer)
		Me.labelRun.Text = resources.GetString("labelRun.Text")
		Me.labelRun.TextAlign = CType(resources.GetObject("labelRun.TextAlign"),System.Drawing.ContentAlignment)
		'
		'comboBoxRun
		'
		Me.comboBoxRun.AccessibleDescription = Nothing
		Me.comboBoxRun.AccessibleName = Nothing
		Me.comboBoxRun.Anchor = CType(resources.GetObject("comboBoxRun.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxRun.BackgroundImage = Nothing
		Me.comboBoxRun.BackgroundImageLayout = CType(resources.GetObject("comboBoxRun.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxRun.Dock = CType(resources.GetObject("comboBoxRun.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxRun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxRun.FlatStyle = CType(resources.GetObject("comboBoxRun.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxRun.Font = Nothing
		Me.comboBoxRun.FormattingEnabled = true
		Me.comboBoxRun.ImeMode = CType(resources.GetObject("comboBoxRun.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxRun.IntegralHeight = CType(resources.GetObject("comboBoxRun.IntegralHeight"),Boolean)
		Me.comboBoxRun.Items.AddRange(New Object() {resources.GetString("comboBoxRun.Items"), resources.GetString("comboBoxRun.Items1"), resources.GetString("comboBoxRun.Items2"), resources.GetString("comboBoxRun.Items3")})
		Me.comboBoxRun.Location = CType(resources.GetObject("comboBoxRun.Location"),System.Drawing.Point)
		Me.comboBoxRun.MaxDropDownItems = CType(resources.GetObject("comboBoxRun.MaxDropDownItems"),Integer)
		Me.comboBoxRun.MaxLength = CType(resources.GetObject("comboBoxRun.MaxLength"),Integer)
		Me.comboBoxRun.Name = "comboBoxRun"
		Me.comboBoxRun.RightToLeft = CType(resources.GetObject("comboBoxRun.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxRun.Size = CType(resources.GetObject("comboBoxRun.Size"),System.Drawing.Size)
		Me.comboBoxRun.TabIndex = CType(resources.GetObject("comboBoxRun.TabIndex"),Integer)
		'
		'groupBoxCredentials
		'
		Me.groupBoxCredentials.AccessibleDescription = Nothing
		Me.groupBoxCredentials.AccessibleName = Nothing
		Me.groupBoxCredentials.Anchor = CType(resources.GetObject("groupBoxCredentials.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.groupBoxCredentials.AutoSize = CType(resources.GetObject("groupBoxCredentials.AutoSize"),Boolean)
		Me.groupBoxCredentials.AutoSizeMode = CType(resources.GetObject("groupBoxCredentials.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.groupBoxCredentials.BackgroundImage = Nothing
		Me.groupBoxCredentials.BackgroundImageLayout = CType(resources.GetObject("groupBoxCredentials.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.groupBoxCredentials.Controls.Add(Me.textBoxDomain)
		Me.groupBoxCredentials.Controls.Add(Me.textBoxPassword)
		Me.groupBoxCredentials.Controls.Add(Me.textBoxUsername)
		Me.groupBoxCredentials.Controls.Add(Me.labelDomain)
		Me.groupBoxCredentials.Controls.Add(Me.labelPassword)
		Me.groupBoxCredentials.Controls.Add(Me.labelUsername)
		Me.groupBoxCredentials.Dock = CType(resources.GetObject("groupBoxCredentials.Dock"),System.Windows.Forms.DockStyle)
		Me.groupBoxCredentials.Font = Nothing
		Me.groupBoxCredentials.ImeMode = CType(resources.GetObject("groupBoxCredentials.ImeMode"),System.Windows.Forms.ImeMode)
		Me.groupBoxCredentials.Location = CType(resources.GetObject("groupBoxCredentials.Location"),System.Drawing.Point)
		Me.groupBoxCredentials.Name = "groupBoxCredentials"
		Me.groupBoxCredentials.RightToLeft = CType(resources.GetObject("groupBoxCredentials.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.groupBoxCredentials.Size = CType(resources.GetObject("groupBoxCredentials.Size"),System.Drawing.Size)
		Me.groupBoxCredentials.TabIndex = CType(resources.GetObject("groupBoxCredentials.TabIndex"),Integer)
		Me.groupBoxCredentials.TabStop = false
		Me.groupBoxCredentials.Text = resources.GetString("groupBoxCredentials.Text")
		'
		'textBoxDomain
		'
		Me.textBoxDomain.AccessibleDescription = Nothing
		Me.textBoxDomain.AccessibleName = Nothing
		Me.textBoxDomain.Anchor = CType(resources.GetObject("textBoxDomain.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.textBoxDomain.BackgroundImage = Nothing
		Me.textBoxDomain.BackgroundImageLayout = CType(resources.GetObject("textBoxDomain.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.textBoxDomain.Dock = CType(resources.GetObject("textBoxDomain.Dock"),System.Windows.Forms.DockStyle)
		Me.textBoxDomain.Font = Nothing
		Me.textBoxDomain.ImeMode = CType(resources.GetObject("textBoxDomain.ImeMode"),System.Windows.Forms.ImeMode)
		Me.textBoxDomain.Location = CType(resources.GetObject("textBoxDomain.Location"),System.Drawing.Point)
		Me.textBoxDomain.MaxLength = CType(resources.GetObject("textBoxDomain.MaxLength"),Integer)
		Me.textBoxDomain.Multiline = CType(resources.GetObject("textBoxDomain.Multiline"),Boolean)
		Me.textBoxDomain.Name = "textBoxDomain"
		Me.textBoxDomain.PasswordChar = CType(resources.GetObject("textBoxDomain.PasswordChar"),Char)
		Me.textBoxDomain.RightToLeft = CType(resources.GetObject("textBoxDomain.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.textBoxDomain.ScrollBars = CType(resources.GetObject("textBoxDomain.ScrollBars"),System.Windows.Forms.ScrollBars)
		Me.textBoxDomain.Size = CType(resources.GetObject("textBoxDomain.Size"),System.Drawing.Size)
		Me.textBoxDomain.TabIndex = CType(resources.GetObject("textBoxDomain.TabIndex"),Integer)
		Me.textBoxDomain.TextAlign = CType(resources.GetObject("textBoxDomain.TextAlign"),System.Windows.Forms.HorizontalAlignment)
		Me.textBoxDomain.WordWrap = CType(resources.GetObject("textBoxDomain.WordWrap"),Boolean)
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
		'labelDomain
		'
		Me.labelDomain.AccessibleDescription = Nothing
		Me.labelDomain.AccessibleName = Nothing
		Me.labelDomain.Anchor = CType(resources.GetObject("labelDomain.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelDomain.AutoSize = CType(resources.GetObject("labelDomain.AutoSize"),Boolean)
		Me.labelDomain.BackgroundImageLayout = CType(resources.GetObject("labelDomain.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelDomain.Dock = CType(resources.GetObject("labelDomain.Dock"),System.Windows.Forms.DockStyle)
		Me.labelDomain.Font = Nothing
		Me.labelDomain.ImageAlign = CType(resources.GetObject("labelDomain.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelDomain.ImageIndex = CType(resources.GetObject("labelDomain.ImageIndex"),Integer)
		Me.labelDomain.ImageKey = resources.GetString("labelDomain.ImageKey")
		Me.labelDomain.ImeMode = CType(resources.GetObject("labelDomain.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelDomain.Location = CType(resources.GetObject("labelDomain.Location"),System.Drawing.Point)
		Me.labelDomain.Name = "labelDomain"
		Me.labelDomain.RightToLeft = CType(resources.GetObject("labelDomain.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelDomain.Size = CType(resources.GetObject("labelDomain.Size"),System.Drawing.Size)
		Me.labelDomain.TabIndex = CType(resources.GetObject("labelDomain.TabIndex"),Integer)
		Me.labelDomain.Text = resources.GetString("labelDomain.Text")
		Me.labelDomain.TextAlign = CType(resources.GetObject("labelDomain.TextAlign"),System.Drawing.ContentAlignment)
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
		'RunPrograms
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
		Me.Controls.Add(Me.groupBoxCredentials)
		Me.Controls.Add(Me.comboBoxRun)
		Me.Controls.Add(Me.labelRun)
		Me.Controls.Add(Me.buttonAdd)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonBrowseFiles)
		Me.Controls.Add(Me.textBoxArguments)
		Me.Controls.Add(Me.labelArgs)
		Me.Controls.Add(Me.textBoxPath)
		Me.Controls.Add(Me.labelPath)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = Nothing
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "RunPrograms"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.ShowIcon = false
		Me.ShowInTaskbar = false
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		AddHandler Load, AddressOf Me.RunProgramsLoad
		Me.groupBoxCredentials.ResumeLayout(false)
		Me.groupBoxCredentials.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelPath As System.Windows.Forms.Label
	Private labelArgs As System.Windows.Forms.Label
	Private labelRun As System.Windows.Forms.Label
	Private groupBoxCredentials As System.Windows.Forms.GroupBox
	Private labelDomain As System.Windows.Forms.Label
	Private labelPassword As System.Windows.Forms.Label
	Private labelUsername As System.Windows.Forms.Label
	Private textBoxUsername As System.Windows.Forms.TextBox
	Private textBoxPassword As System.Windows.Forms.TextBox
	Private textBoxDomain As System.Windows.Forms.TextBox
	Private comboBoxRun As System.Windows.Forms.ComboBox
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private buttonBrowseFiles As System.Windows.Forms.Button
	Private textBoxArguments As System.Windows.Forms.TextBox
	Private textBoxPath As System.Windows.Forms.TextBox
	Private buttonAdd As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
End Class
