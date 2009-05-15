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
		Me.pictureBox1 = New System.Windows.Forms.PictureBox
		Me.label1 = New System.Windows.Forms.Label
		Me.labelVersion = New System.Windows.Forms.Label
		Me.labelCopyright = New System.Windows.Forms.Label
		Me.buttonOK = New System.Windows.Forms.Button
		Me.linkLabelHomepage = New System.Windows.Forms.LinkLabel
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
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
		'label1
		'
		Me.label1.AccessibleDescription = Nothing
		Me.label1.AccessibleName = Nothing
		Me.label1.Anchor = CType(resources.GetObject("label1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.label1.AutoSize = CType(resources.GetObject("label1.AutoSize"),Boolean)
		Me.label1.BackgroundImageLayout = CType(resources.GetObject("label1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.label1.Dock = CType(resources.GetObject("label1.Dock"),System.Windows.Forms.DockStyle)
		Me.label1.Font = CType(resources.GetObject("label1.Font"),System.Drawing.Font)
		Me.label1.ImageAlign = CType(resources.GetObject("label1.ImageAlign"),System.Drawing.ContentAlignment)
		Me.label1.ImageIndex = CType(resources.GetObject("label1.ImageIndex"),Integer)
		Me.label1.ImageKey = resources.GetString("label1.ImageKey")
		Me.label1.ImeMode = CType(resources.GetObject("label1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.label1.Location = CType(resources.GetObject("label1.Location"),System.Drawing.Point)
		Me.label1.Name = "label1"
		Me.label1.RightToLeft = CType(resources.GetObject("label1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.label1.Size = CType(resources.GetObject("label1.Size"),System.Drawing.Size)
		Me.label1.TabIndex = CType(resources.GetObject("label1.TabIndex"),Integer)
		Me.label1.Text = resources.GetString("label1.Text")
		Me.label1.TextAlign = CType(resources.GetObject("label1.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelVersion
		'
		Me.labelVersion.AccessibleDescription = Nothing
		Me.labelVersion.AccessibleName = Nothing
		Me.labelVersion.Anchor = CType(resources.GetObject("labelVersion.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelVersion.AutoSize = CType(resources.GetObject("labelVersion.AutoSize"),Boolean)
		Me.labelVersion.BackgroundImageLayout = CType(resources.GetObject("labelVersion.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelVersion.Dock = CType(resources.GetObject("labelVersion.Dock"),System.Windows.Forms.DockStyle)
		Me.labelVersion.Font = Nothing
		Me.labelVersion.ImageAlign = CType(resources.GetObject("labelVersion.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelVersion.ImageIndex = CType(resources.GetObject("labelVersion.ImageIndex"),Integer)
		Me.labelVersion.ImageKey = resources.GetString("labelVersion.ImageKey")
		Me.labelVersion.ImeMode = CType(resources.GetObject("labelVersion.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelVersion.Location = CType(resources.GetObject("labelVersion.Location"),System.Drawing.Point)
		Me.labelVersion.Name = "labelVersion"
		Me.labelVersion.RightToLeft = CType(resources.GetObject("labelVersion.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelVersion.Size = CType(resources.GetObject("labelVersion.Size"),System.Drawing.Size)
		Me.labelVersion.TabIndex = CType(resources.GetObject("labelVersion.TabIndex"),Integer)
		Me.labelVersion.Text = resources.GetString("labelVersion.Text")
		Me.labelVersion.TextAlign = CType(resources.GetObject("labelVersion.TextAlign"),System.Drawing.ContentAlignment)
		'
		'labelCopyright
		'
		Me.labelCopyright.AccessibleDescription = Nothing
		Me.labelCopyright.AccessibleName = Nothing
		Me.labelCopyright.Anchor = CType(resources.GetObject("labelCopyright.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelCopyright.AutoSize = CType(resources.GetObject("labelCopyright.AutoSize"),Boolean)
		Me.labelCopyright.BackgroundImageLayout = CType(resources.GetObject("labelCopyright.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelCopyright.Dock = CType(resources.GetObject("labelCopyright.Dock"),System.Windows.Forms.DockStyle)
		Me.labelCopyright.Font = Nothing
		Me.labelCopyright.ImageAlign = CType(resources.GetObject("labelCopyright.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelCopyright.ImageIndex = CType(resources.GetObject("labelCopyright.ImageIndex"),Integer)
		Me.labelCopyright.ImageKey = resources.GetString("labelCopyright.ImageKey")
		Me.labelCopyright.ImeMode = CType(resources.GetObject("labelCopyright.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelCopyright.Location = CType(resources.GetObject("labelCopyright.Location"),System.Drawing.Point)
		Me.labelCopyright.Name = "labelCopyright"
		Me.labelCopyright.RightToLeft = CType(resources.GetObject("labelCopyright.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelCopyright.Size = CType(resources.GetObject("labelCopyright.Size"),System.Drawing.Size)
		Me.labelCopyright.TabIndex = CType(resources.GetObject("labelCopyright.TabIndex"),Integer)
		Me.labelCopyright.Text = resources.GetString("labelCopyright.Text")
		Me.labelCopyright.TextAlign = CType(resources.GetObject("labelCopyright.TextAlign"),System.Drawing.ContentAlignment)
		'
		'buttonOK
		'
		Me.buttonOK.AccessibleDescription = Nothing
		Me.buttonOK.AccessibleName = Nothing
		Me.buttonOK.Anchor = CType(resources.GetObject("buttonOK.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.buttonOK.AutoSize = CType(resources.GetObject("buttonOK.AutoSize"),Boolean)
		Me.buttonOK.AutoSizeMode = CType(resources.GetObject("buttonOK.AutoSizeMode"),System.Windows.Forms.AutoSizeMode)
		Me.buttonOK.BackgroundImage = Nothing
		Me.buttonOK.BackgroundImageLayout = CType(resources.GetObject("buttonOK.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.buttonOK.Dock = CType(resources.GetObject("buttonOK.Dock"),System.Windows.Forms.DockStyle)
		Me.buttonOK.FlatStyle = CType(resources.GetObject("buttonOK.FlatStyle"),System.Windows.Forms.FlatStyle)
		Me.buttonOK.Font = Nothing
		Me.buttonOK.ImageAlign = CType(resources.GetObject("buttonOK.ImageAlign"),System.Drawing.ContentAlignment)
		Me.buttonOK.ImageIndex = CType(resources.GetObject("buttonOK.ImageIndex"),Integer)
		Me.buttonOK.ImageKey = resources.GetString("buttonOK.ImageKey")
		Me.buttonOK.ImeMode = CType(resources.GetObject("buttonOK.ImeMode"),System.Windows.Forms.ImeMode)
		Me.buttonOK.Location = CType(resources.GetObject("buttonOK.Location"),System.Drawing.Point)
		Me.buttonOK.Name = "buttonOK"
		Me.buttonOK.RightToLeft = CType(resources.GetObject("buttonOK.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.buttonOK.Size = CType(resources.GetObject("buttonOK.Size"),System.Drawing.Size)
		Me.buttonOK.TabIndex = CType(resources.GetObject("buttonOK.TabIndex"),Integer)
		Me.buttonOK.Text = resources.GetString("buttonOK.Text")
		Me.buttonOK.TextAlign = CType(resources.GetObject("buttonOK.TextAlign"),System.Drawing.ContentAlignment)
		Me.buttonOK.TextImageRelation = CType(resources.GetObject("buttonOK.TextImageRelation"),System.Windows.Forms.TextImageRelation)
		Me.buttonOK.UseVisualStyleBackColor = true
		AddHandler Me.buttonOK.Click, AddressOf Me.ButtonOKClick
		'
		'linkLabelHomepage
		'
		Me.linkLabelHomepage.AccessibleDescription = Nothing
		Me.linkLabelHomepage.AccessibleName = Nothing
		Me.linkLabelHomepage.Anchor = CType(resources.GetObject("linkLabelHomepage.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.linkLabelHomepage.AutoSize = CType(resources.GetObject("linkLabelHomepage.AutoSize"),Boolean)
		Me.linkLabelHomepage.BackgroundImageLayout = CType(resources.GetObject("linkLabelHomepage.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.linkLabelHomepage.Dock = CType(resources.GetObject("linkLabelHomepage.Dock"),System.Windows.Forms.DockStyle)
		Me.linkLabelHomepage.Font = Nothing
		Me.linkLabelHomepage.ImageAlign = CType(resources.GetObject("linkLabelHomepage.ImageAlign"),System.Drawing.ContentAlignment)
		Me.linkLabelHomepage.ImageIndex = CType(resources.GetObject("linkLabelHomepage.ImageIndex"),Integer)
		Me.linkLabelHomepage.ImageKey = resources.GetString("linkLabelHomepage.ImageKey")
		Me.linkLabelHomepage.ImeMode = CType(resources.GetObject("linkLabelHomepage.ImeMode"),System.Windows.Forms.ImeMode)
		Me.linkLabelHomepage.Location = CType(resources.GetObject("linkLabelHomepage.Location"),System.Drawing.Point)
		Me.linkLabelHomepage.Name = "linkLabelHomepage"
		Me.linkLabelHomepage.RightToLeft = CType(resources.GetObject("linkLabelHomepage.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.linkLabelHomepage.Size = CType(resources.GetObject("linkLabelHomepage.Size"),System.Drawing.Size)
		Me.linkLabelHomepage.TabIndex = CType(resources.GetObject("linkLabelHomepage.TabIndex"),Integer)
		Me.linkLabelHomepage.TabStop = true
		Me.linkLabelHomepage.Text = resources.GetString("linkLabelHomepage.Text")
		Me.linkLabelHomepage.TextAlign = CType(resources.GetObject("linkLabelHomepage.TextAlign"),System.Drawing.ContentAlignment)
		AddHandler Me.linkLabelHomepage.LinkClicked, AddressOf Me.LinkLabelHomepageLinkClicked
		'
		'About
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
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.linkLabelHomepage)
		Me.Controls.Add(Me.buttonOK)
		Me.Controls.Add(Me.labelCopyright)
		Me.Controls.Add(Me.labelVersion)
		Me.Controls.Add(Me.label1)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = Nothing
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"),System.Drawing.Size)
		Me.Name = "About"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.ShowInTaskbar = false
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
		AddHandler Load, AddressOf Me.AboutLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelVersion As System.Windows.Forms.Label
	Private labelCopyright As System.Windows.Forms.Label
	Private linkLabelHomepage As System.Windows.Forms.LinkLabel
	Private buttonOK As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
