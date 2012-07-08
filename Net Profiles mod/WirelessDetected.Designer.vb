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
' Date: 2/8/2007
' Time: 8:30 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class WirelessDetected
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WirelessDetected))
		Me.labelSSID = New System.Windows.Forms.Label
		Me.labelProfile = New System.Windows.Forms.Label
		Me.buttonNo = New System.Windows.Forms.Button
		Me.buttonYes = New System.Windows.Forms.Button
		Me.pictureBox1 = New System.Windows.Forms.PictureBox
		Me.labelConnectedTo = New System.Windows.Forms.Label
		Me.labelActivate = New System.Windows.Forms.Label
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'labelSSID
		'
		Me.labelSSID.AccessibleDescription = Nothing
		Me.labelSSID.AccessibleName = Nothing
		Me.labelSSID.Anchor = CType(resources.GetObject("labelSSID.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelSSID.AutoEllipsis = true
		Me.labelSSID.AutoSize = CType(resources.GetObject("labelSSID.AutoSize"),Boolean)
		Me.labelSSID.BackgroundImageLayout = CType(resources.GetObject("labelSSID.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelSSID.Dock = CType(resources.GetObject("labelSSID.Dock"),System.Windows.Forms.DockStyle)
		Me.labelSSID.Font = CType(resources.GetObject("labelSSID.Font"),System.Drawing.Font)
		Me.labelSSID.ImageAlign = CType(resources.GetObject("labelSSID.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelSSID.ImageIndex = CType(resources.GetObject("labelSSID.ImageIndex"),Integer)
		Me.labelSSID.ImageKey = resources.GetString("labelSSID.ImageKey")
		Me.labelSSID.ImeMode = CType(resources.GetObject("labelSSID.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelSSID.Location = CType(resources.GetObject("labelSSID.Location"),System.Drawing.Point)
		Me.labelSSID.Name = "labelSSID"
		Me.labelSSID.RightToLeft = CType(resources.GetObject("labelSSID.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelSSID.Size = CType(resources.GetObject("labelSSID.Size"),System.Drawing.Size)
		Me.labelSSID.TabIndex = CType(resources.GetObject("labelSSID.TabIndex"),Integer)
		Me.labelSSID.TextAlign = CType(resources.GetObject("labelSSID.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelProfile
		'
		Me.labelProfile.AccessibleDescription = Nothing
		Me.labelProfile.AccessibleName = Nothing
		Me.labelProfile.Anchor = CType(resources.GetObject("labelProfile.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelProfile.AutoEllipsis = true
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
		'buttonNo
		'
		Me.buttonNo.AccessibleDescription = Nothing
		Me.buttonNo.AccessibleName = Nothing
		Me.buttonNo.Anchor = CType(resources.GetObject("buttonNo.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonNo.AutoSize = CType(resources.GetObject("buttonNo.AutoSize"),Boolean)
		Me.buttonNo.AutoSizeMode = CType(resources.GetObject("buttonNo.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonNo.BackgroundImage = Nothing
		Me.buttonNo.BackgroundImageLayout = CType(resources.GetObject("buttonNo.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonNo.Dock = CType(resources.GetObject("buttonNo.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonNo.FlatStyle = CType(resources.GetObject("buttonNo.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonNo.Font = Nothing
		Me.buttonNo.Image = CType(resources.GetObject("buttonNo.Image"),System.Drawing.Image)
		Me.buttonNo.ImageAlign = CType(resources.GetObject("buttonNo.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonNo.ImageIndex = CType(resources.GetObject("buttonNo.ImageIndex"),Integer)
		Me.buttonNo.ImageKey = resources.GetString("buttonNo.ImageKey")
		Me.buttonNo.ImeMode = CType(resources.GetObject("buttonNo.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonNo.Location = CType(resources.GetObject("buttonNo.Location"),System.Drawing.Point)
		Me.buttonNo.Name = "buttonNo"
		Me.buttonNo.RightToLeft = CType(resources.GetObject("buttonNo.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonNo.Size = CType(resources.GetObject("buttonNo.Size"),System.Drawing.Size)
		Me.buttonNo.TabIndex = CType(resources.GetObject("buttonNo.TabIndex"),Integer)
		Me.buttonNo.Text = resources.GetString("buttonNo.Text")
		Me.buttonNo.TextAlign = CType(resources.GetObject("buttonNo.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonNo.TextImageRelation = CType(resources.GetObject("buttonNo.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonNo.UseVisualStyleBackColor = true
		AddHandler Me.buttonNo.Click, AddressOf Me.ButtonNoClick
		'
		'buttonYes
		'
		Me.buttonYes.AccessibleDescription = Nothing
		Me.buttonYes.AccessibleName = Nothing
		Me.buttonYes.Anchor = CType(resources.GetObject("buttonYes.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonYes.AutoSize = CType(resources.GetObject("buttonYes.AutoSize"),Boolean)
		Me.buttonYes.AutoSizeMode = CType(resources.GetObject("buttonYes.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonYes.BackgroundImage = Nothing
		Me.buttonYes.BackgroundImageLayout = CType(resources.GetObject("buttonYes.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonYes.Dock = CType(resources.GetObject("buttonYes.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonYes.FlatStyle = CType(resources.GetObject("buttonYes.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonYes.Font = Nothing
		Me.buttonYes.Image = CType(resources.GetObject("buttonYes.Image"),System.Drawing.Image)
		Me.buttonYes.ImageAlign = CType(resources.GetObject("buttonYes.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonYes.ImageIndex = CType(resources.GetObject("buttonYes.ImageIndex"),Integer)
		Me.buttonYes.ImageKey = resources.GetString("buttonYes.ImageKey")
		Me.buttonYes.ImeMode = CType(resources.GetObject("buttonYes.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonYes.Location = CType(resources.GetObject("buttonYes.Location"),System.Drawing.Point)
		Me.buttonYes.Name = "buttonYes"
		Me.buttonYes.RightToLeft = CType(resources.GetObject("buttonYes.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonYes.Size = CType(resources.GetObject("buttonYes.Size"),System.Drawing.Size)
		Me.buttonYes.TabIndex = CType(resources.GetObject("buttonYes.TabIndex"),Integer)
		Me.buttonYes.Text = resources.GetString("buttonYes.Text")
		Me.buttonYes.TextAlign = CType(resources.GetObject("buttonYes.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonYes.TextImageRelation = CType(resources.GetObject("buttonYes.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonYes.UseVisualStyleBackColor = true
		AddHandler Me.buttonYes.Click, AddressOf Me.ButtonYesClick
		'
		'pictureBox1
		'
		Me.pictureBox1.AccessibleDescription = Nothing
		Me.pictureBox1.AccessibleName = Nothing
		Me.pictureBox1.Anchor = CType(resources.GetObject("pictureBox1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.pictureBox1.BackgroundImage = Nothing
		Me.pictureBox1.BackgroundImageLayout = CType(resources.GetObject("pictureBox1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.pictureBox1.Dock = CType(resources.GetObject("pictureBox1.Dock"),System.Windows.Forms.DockStyle)
		Me.pictureBox1.Font = Nothing
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.ImageLocation = Nothing
		Me.pictureBox1.ImeMode = CType(resources.GetObject("pictureBox1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.pictureBox1.Location = CType(resources.GetObject("pictureBox1.Location"),System.Drawing.Point)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.RightToLeft = CType(resources.GetObject("pictureBox1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.pictureBox1.Size = CType(resources.GetObject("pictureBox1.Size"),System.Drawing.Size)
		Me.pictureBox1.SizeMode = CType(resources.GetObject("pictureBox1.SizeMode"),System.Windows.Forms.PictureBoxSizeMode)
		Me.pictureBox1.TabIndex = CType(resources.GetObject("pictureBox1.TabIndex"),Integer)
		Me.pictureBox1.TabStop = false
		Me.pictureBox1.WaitOnLoad = CType(resources.GetObject("pictureBox1.WaitOnLoad"),Boolean)
		'
		'labelConnectedTo
		'
		Me.labelConnectedTo.AccessibleDescription = Nothing
		Me.labelConnectedTo.AccessibleName = Nothing
		Me.labelConnectedTo.Anchor = CType(resources.GetObject("labelConnectedTo.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelConnectedTo.AutoSize = CType(resources.GetObject("labelConnectedTo.AutoSize"),Boolean)
		Me.labelConnectedTo.BackgroundImageLayout = CType(resources.GetObject("labelConnectedTo.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelConnectedTo.Dock = CType(resources.GetObject("labelConnectedTo.Dock"),System.Windows.Forms.DockStyle)
		Me.labelConnectedTo.Font = Nothing
		Me.labelConnectedTo.ImageAlign = CType(resources.GetObject("labelConnectedTo.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelConnectedTo.ImageIndex = CType(resources.GetObject("labelConnectedTo.ImageIndex"),Integer)
		Me.labelConnectedTo.ImageKey = resources.GetString("labelConnectedTo.ImageKey")
		Me.labelConnectedTo.ImeMode = CType(resources.GetObject("labelConnectedTo.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelConnectedTo.Location = CType(resources.GetObject("labelConnectedTo.Location"),System.Drawing.Point)
		Me.labelConnectedTo.Name = "labelConnectedTo"
		Me.labelConnectedTo.RightToLeft = CType(resources.GetObject("labelConnectedTo.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelConnectedTo.Size = CType(resources.GetObject("labelConnectedTo.Size"),System.Drawing.Size)
		Me.labelConnectedTo.TabIndex = CType(resources.GetObject("labelConnectedTo.TabIndex"),Integer)
		Me.labelConnectedTo.Text = resources.GetString("labelConnectedTo.Text")
		Me.labelConnectedTo.TextAlign = CType(resources.GetObject("labelConnectedTo.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelActivate
		'
		Me.labelActivate.AccessibleDescription = Nothing
		Me.labelActivate.AccessibleName = Nothing
		Me.labelActivate.Anchor = CType(resources.GetObject("labelActivate.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelActivate.AutoSize = CType(resources.GetObject("labelActivate.AutoSize"),Boolean)
		Me.labelActivate.BackgroundImageLayout = CType(resources.GetObject("labelActivate.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelActivate.Dock = CType(resources.GetObject("labelActivate.Dock"),System.Windows.Forms.DockStyle)
		Me.labelActivate.Font = Nothing
		Me.labelActivate.ImageAlign = CType(resources.GetObject("labelActivate.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelActivate.ImageIndex = CType(resources.GetObject("labelActivate.ImageIndex"),Integer)
		Me.labelActivate.ImageKey = resources.GetString("labelActivate.ImageKey")
		Me.labelActivate.ImeMode = CType(resources.GetObject("labelActivate.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelActivate.Location = CType(resources.GetObject("labelActivate.Location"),System.Drawing.Point)
		Me.labelActivate.Name = "labelActivate"
		Me.labelActivate.RightToLeft = CType(resources.GetObject("labelActivate.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelActivate.Size = CType(resources.GetObject("labelActivate.Size"),System.Drawing.Size)
		Me.labelActivate.TabIndex = CType(resources.GetObject("labelActivate.TabIndex"),Integer)
		Me.labelActivate.Text = resources.GetString("labelActivate.Text")
		Me.labelActivate.TextAlign = CType(resources.GetObject("labelActivate.TextAlign"),System.Drawing.ContentAlignment)
		'
		'WirelessDetected
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
		Me.Controls.Add(Me.labelActivate)
		Me.Controls.Add(Me.labelConnectedTo)
		Me.Controls.Add(Me.labelProfile)
		Me.Controls.Add(Me.labelSSID)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.buttonYes)
		Me.Controls.Add(Me.buttonNo)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "WirelessDetected"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		Me.TopMost = true
		AddHandler Load, AddressOf Me.WirelessDetectedLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelConnectedTo As System.Windows.Forms.Label
	Private labelActivate As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private buttonYes As System.Windows.Forms.Button
	Private buttonNo As System.Windows.Forms.Button
	Public labelProfile As System.Windows.Forms.Label
	Public labelSSID As System.Windows.Forms.Label
End Class
