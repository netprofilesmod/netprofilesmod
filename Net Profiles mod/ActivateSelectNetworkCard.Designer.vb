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
' Time: 3:15 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class ActivateSelectNetworkCard
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivateSelectNetworkCard))
		Me.comboBoxNetworkCards = New System.Windows.Forms.ComboBox
		Me.labelSelectNetworkCard = New System.Windows.Forms.Label
		Me.buttonCancel = New System.Windows.Forms.Button
		Me.buttonActivate = New System.Windows.Forms.Button
		Me.labelProfileTitle = New System.Windows.Forms.Label
		Me.labelProfile = New System.Windows.Forms.Label
		Me.SuspendLayout
		'
		'comboBoxNetworkCards
		'
		Me.comboBoxNetworkCards.AccessibleDescription = Nothing
		Me.comboBoxNetworkCards.AccessibleName = Nothing
		Me.comboBoxNetworkCards.Anchor = CType(resources.GetObject("comboBoxNetworkCards.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.comboBoxNetworkCards.BackgroundImage = Nothing
		Me.comboBoxNetworkCards.BackgroundImageLayout = CType(resources.GetObject("comboBoxNetworkCards.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.comboBoxNetworkCards.Dock = CType(resources.GetObject("comboBoxNetworkCards.Dock"),System.Windows.Forms.DockStyle)
		Me.comboBoxNetworkCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxNetworkCards.FlatStyle = CType(resources.GetObject("comboBoxNetworkCards.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.comboBoxNetworkCards.Font = Nothing
		Me.comboBoxNetworkCards.FormattingEnabled = true
		Me.comboBoxNetworkCards.ImeMode = CType(resources.GetObject("comboBoxNetworkCards.ImeMode"),System.Windows.Forms.ImeMode)
		Me.comboBoxNetworkCards.IntegralHeight = CType(resources.GetObject("comboBoxNetworkCards.IntegralHeight"),Boolean)
		Me.comboBoxNetworkCards.Location = CType(resources.GetObject("comboBoxNetworkCards.Location"),System.Drawing.Point)
		Me.comboBoxNetworkCards.MaxDropDownItems = CType(resources.GetObject("comboBoxNetworkCards.MaxDropDownItems"),Integer)
		Me.comboBoxNetworkCards.MaxLength = CType(resources.GetObject("comboBoxNetworkCards.MaxLength"),Integer)
		Me.comboBoxNetworkCards.Name = "comboBoxNetworkCards"
		Me.comboBoxNetworkCards.RightToLeft = CType(resources.GetObject("comboBoxNetworkCards.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.comboBoxNetworkCards.Size = CType(resources.GetObject("comboBoxNetworkCards.Size"),System.Drawing.Size)
		Me.comboBoxNetworkCards.TabIndex = CType(resources.GetObject("comboBoxNetworkCards.TabIndex"),Integer)
		'
		'labelSelectNetworkCard
		'
		Me.labelSelectNetworkCard.AccessibleDescription = Nothing
		Me.labelSelectNetworkCard.AccessibleName = Nothing
		Me.labelSelectNetworkCard.Anchor = CType(resources.GetObject("labelSelectNetworkCard.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelSelectNetworkCard.AutoSize = CType(resources.GetObject("labelSelectNetworkCard.AutoSize"),Boolean)
		Me.labelSelectNetworkCard.BackgroundImageLayout = CType(resources.GetObject("labelSelectNetworkCard.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelSelectNetworkCard.Dock = CType(resources.GetObject("labelSelectNetworkCard.Dock"),System.Windows.Forms.DockStyle)
		Me.labelSelectNetworkCard.Font = Nothing
		Me.labelSelectNetworkCard.ImageAlign = CType(resources.GetObject("labelSelectNetworkCard.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelSelectNetworkCard.ImageIndex = CType(resources.GetObject("labelSelectNetworkCard.ImageIndex"),Integer)
		Me.labelSelectNetworkCard.ImageKey = resources.GetString("labelSelectNetworkCard.ImageKey")
		Me.labelSelectNetworkCard.ImeMode = CType(resources.GetObject("labelSelectNetworkCard.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelSelectNetworkCard.Location = CType(resources.GetObject("labelSelectNetworkCard.Location"),System.Drawing.Point)
		Me.labelSelectNetworkCard.Name = "labelSelectNetworkCard"
		Me.labelSelectNetworkCard.RightToLeft = CType(resources.GetObject("labelSelectNetworkCard.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelSelectNetworkCard.Size = CType(resources.GetObject("labelSelectNetworkCard.Size"),System.Drawing.Size)
		Me.labelSelectNetworkCard.TabIndex = CType(resources.GetObject("labelSelectNetworkCard.TabIndex"),Integer)
		Me.labelSelectNetworkCard.Text = resources.GetString("labelSelectNetworkCard.Text")
		Me.labelSelectNetworkCard.TextAlign = CType(resources.GetObject("labelSelectNetworkCard.TextAlign"),System.Drawing.ContentAlignment)
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
		'buttonActivate
		'
		Me.buttonActivate.AccessibleDescription = Nothing
		Me.buttonActivate.AccessibleName = Nothing
		Me.buttonActivate.Anchor = CType(resources.GetObject("buttonActivate.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonActivate.AutoSize = CType(resources.GetObject("buttonActivate.AutoSize"),Boolean)
		Me.buttonActivate.AutoSizeMode = CType(resources.GetObject("buttonActivate.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonActivate.BackgroundImage = Nothing
		Me.buttonActivate.BackgroundImageLayout = CType(resources.GetObject("buttonActivate.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonActivate.Dock = CType(resources.GetObject("buttonActivate.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonActivate.FlatStyle = CType(resources.GetObject("buttonActivate.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonActivate.Font = Nothing
		Me.buttonActivate.Image = CType(resources.GetObject("buttonActivate.Image"),System.Drawing.Image)
		Me.buttonActivate.ImageAlign = CType(resources.GetObject("buttonActivate.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonActivate.ImageIndex = CType(resources.GetObject("buttonActivate.ImageIndex"),Integer)
		Me.buttonActivate.ImageKey = resources.GetString("buttonActivate.ImageKey")
		Me.buttonActivate.ImeMode = CType(resources.GetObject("buttonActivate.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonActivate.Location = CType(resources.GetObject("buttonActivate.Location"),System.Drawing.Point)
		Me.buttonActivate.Name = "buttonActivate"
		Me.buttonActivate.RightToLeft = CType(resources.GetObject("buttonActivate.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonActivate.Size = CType(resources.GetObject("buttonActivate.Size"),System.Drawing.Size)
		Me.buttonActivate.TabIndex = CType(resources.GetObject("buttonActivate.TabIndex"),Integer)
		Me.buttonActivate.Text = resources.GetString("buttonActivate.Text")
		Me.buttonActivate.TextAlign = CType(resources.GetObject("buttonActivate.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonActivate.TextImageRelation = CType(resources.GetObject("buttonActivate.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonActivate.UseVisualStyleBackColor = true
		AddHandler Me.buttonActivate.Click, AddressOf Me.ButtonActivateClick
		'
		'labelProfileTitle
		'
		Me.labelProfileTitle.AccessibleDescription = Nothing
		Me.labelProfileTitle.AccessibleName = Nothing
		Me.labelProfileTitle.Anchor = CType(resources.GetObject("labelProfileTitle.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelProfileTitle.AutoSize = CType(resources.GetObject("labelProfileTitle.AutoSize"),Boolean)
		Me.labelProfileTitle.BackgroundImageLayout = CType(resources.GetObject("labelProfileTitle.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelProfileTitle.Dock = CType(resources.GetObject("labelProfileTitle.Dock"),System.Windows.Forms.DockStyle)
		Me.labelProfileTitle.Font = Nothing
		Me.labelProfileTitle.ImageAlign = CType(resources.GetObject("labelProfileTitle.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelProfileTitle.ImageIndex = CType(resources.GetObject("labelProfileTitle.ImageIndex"),Integer)
		Me.labelProfileTitle.ImageKey = resources.GetString("labelProfileTitle.ImageKey")
		Me.labelProfileTitle.ImeMode = CType(resources.GetObject("labelProfileTitle.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelProfileTitle.Location = CType(resources.GetObject("labelProfileTitle.Location"),System.Drawing.Point)
		Me.labelProfileTitle.Name = "labelProfileTitle"
		Me.labelProfileTitle.RightToLeft = CType(resources.GetObject("labelProfileTitle.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelProfileTitle.Size = CType(resources.GetObject("labelProfileTitle.Size"),System.Drawing.Size)
		Me.labelProfileTitle.TabIndex = CType(resources.GetObject("labelProfileTitle.TabIndex"),Integer)
		Me.labelProfileTitle.Text = resources.GetString("labelProfileTitle.Text")
		Me.labelProfileTitle.TextAlign = CType(resources.GetObject("labelProfileTitle.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelProfile
		'
		Me.labelProfile.AccessibleDescription = Nothing
		Me.labelProfile.AccessibleName = Nothing
		Me.labelProfile.Anchor = CType(resources.GetObject("labelProfile.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelProfile.AutoSize = CType(resources.GetObject("labelProfile.AutoSize"),Boolean)
		Me.labelProfile.BackgroundImageLayout = CType(resources.GetObject("labelProfile.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelProfile.Dock = CType(resources.GetObject("labelProfile.Dock"),System.Windows.Forms.DockStyle)
		Me.labelProfile.Font = CType(resources.GetObject("labelProfile.Font"),System.Drawing.Font)
		Me.labelProfile.ImageAlign = CType(resources.GetObject("labelProfile.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelProfile.ImageIndex = CType(resources.GetObject("labelProfile.ImageIndex"),Integer)
		Me.labelProfile.ImageKey = resources.GetString("labelProfile.ImageKey")
		Me.labelProfile.ImeMode = CType(resources.GetObject("labelProfile.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelProfile.Location = CType(resources.GetObject("labelProfile.Location"),System.Drawing.Point)
		Me.labelProfile.Name = "labelProfile"
		Me.labelProfile.RightToLeft = CType(resources.GetObject("labelProfile.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelProfile.Size = CType(resources.GetObject("labelProfile.Size"),System.Drawing.Size)
		Me.labelProfile.TabIndex = CType(resources.GetObject("labelProfile.TabIndex"),Integer)
		Me.labelProfile.TextAlign = CType(resources.GetObject("labelProfile.TextAlign"),System.Drawing.ContentAlignment)
		'
		'ActivateSelectNetworkCard
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
		Me.Controls.Add(Me.labelProfile)
		Me.Controls.Add(Me.labelProfileTitle)
		Me.Controls.Add(Me.buttonActivate)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.comboBoxNetworkCards)
		Me.Controls.Add(Me.labelSelectNetworkCard)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = Nothing
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "ActivateSelectNetworkCard"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		AddHandler Load, AddressOf Me.ActivateSelectNetworkCardLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelSelectNetworkCard As System.Windows.Forms.Label
	Private labelProfileTitle As System.Windows.Forms.Label
	Private buttonActivate As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
	Private labelProfile As System.Windows.Forms.Label
	Private comboBoxNetworkCards As System.Windows.Forms.ComboBox
End Class
