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
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoActivate))
		Me.labelTitle = New System.Windows.Forms.Label
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.progressBar1 = New System.Windows.Forms.ProgressBar
		Me.labelStatus = New System.Windows.Forms.Label
		Me.pictureBox1 = New System.Windows.Forms.PictureBox
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'labelTitle
		'
		Me.labelTitle.AccessibleDescription = Nothing
		Me.labelTitle.AccessibleName = Nothing
		Me.labelTitle.Anchor = CType(resources.GetObject("labelTitle.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelTitle.AutoSize = CType(resources.GetObject("labelTitle.AutoSize"),Boolean)
		Me.labelTitle.BackgroundImageLayout = CType(resources.GetObject("labelTitle.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelTitle.Dock = CType(resources.GetObject("labelTitle.Dock"),System.Windows.Forms.DockStyle)
		Me.labelTitle.Font = CType(resources.GetObject("labelTitle.Font"),System.Drawing.Font)
		'Me.labelTitle.ImageAlign = CType(resources.GetObject("labelTitle.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelTitle.ImageIndex = CType(resources.GetObject("labelTitle.ImageIndex"),Integer)
		Me.labelTitle.ImageKey = resources.GetString("labelTitle.ImageKey")
		Me.labelTitle.ImeMode = CType(resources.GetObject("labelTitle.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelTitle.Location = CType(resources.GetObject("labelTitle.Location"),System.Drawing.Point)
		Me.labelTitle.Name = "labelTitle"
		Me.labelTitle.Padding = CType(resources.GetObject("labelTitle.Padding"),System.Windows.Forms.Padding)
		Me.labelTitle.RightToLeft = CType(resources.GetObject("labelTitle.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelTitle.Size = CType(resources.GetObject("labelTitle.Size"),System.Drawing.Size)
		Me.labelTitle.TabIndex = CType(resources.GetObject("labelTitle.TabIndex"),Integer)
		Me.labelTitle.Text = resources.GetString("labelTitle.Text")
		Me.labelTitle.TextAlign = CType(resources.GetObject("labelTitle.TextAlign"),System.Drawing.ContentAlignment)
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'progressBar1
		'
		Me.progressBar1.AccessibleDescription = Nothing
		Me.progressBar1.AccessibleName = Nothing
		Me.progressBar1.Anchor = CType(resources.GetObject("progressBar1.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.progressBar1.BackgroundImage = Nothing
		Me.progressBar1.BackgroundImageLayout = CType(resources.GetObject("progressBar1.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.progressBar1.Dock = CType(resources.GetObject("progressBar1.Dock"),System.Windows.Forms.DockStyle)
		Me.progressBar1.Font = Nothing
		Me.progressBar1.ImeMode = CType(resources.GetObject("progressBar1.ImeMode"),System.Windows.Forms.ImeMode)
		Me.progressBar1.Location = CType(resources.GetObject("progressBar1.Location"),System.Drawing.Point)
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.RightToLeft = CType(resources.GetObject("progressBar1.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.progressBar1.RightToLeftLayout = CType(resources.GetObject("progressBar1.RightToLeftLayout"),Boolean)
		Me.progressBar1.Size = CType(resources.GetObject("progressBar1.Size"),System.Drawing.Size)
		Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		Me.progressBar1.TabIndex = CType(resources.GetObject("progressBar1.TabIndex"),Integer)
		'
		'labelStatus
		'
		Me.labelStatus.AccessibleDescription = Nothing
		Me.labelStatus.AccessibleName = Nothing
		Me.labelStatus.Anchor = CType(resources.GetObject("labelStatus.Anchor"),System.Windows.Forms.AnchorStyles)
		Me.labelStatus.AutoSize = CType(resources.GetObject("labelStatus.AutoSize"),Boolean)
		Me.labelStatus.BackgroundImageLayout = CType(resources.GetObject("labelStatus.BackgroundImageLayout"),System.Windows.Forms.ImageLayout)
		Me.labelStatus.Dock = CType(resources.GetObject("labelStatus.Dock"),System.Windows.Forms.DockStyle)
		Me.labelStatus.Font = Nothing
		'Me.labelStatus.ImageAlign = CType(resources.GetObject("labelStatus.ImageAlign"),System.Drawing.ContentAlignment)
		Me.labelStatus.ImageIndex = CType(resources.GetObject("labelStatus.ImageIndex"),Integer)
		Me.labelStatus.ImageKey = resources.GetString("labelStatus.ImageKey")
		Me.labelStatus.ImeMode = CType(resources.GetObject("labelStatus.ImeMode"),System.Windows.Forms.ImeMode)
		Me.labelStatus.Location = CType(resources.GetObject("labelStatus.Location"),System.Drawing.Point)
		Me.labelStatus.Name = "labelStatus"
		Me.labelStatus.Padding = CType(resources.GetObject("labelStatus.Padding"),System.Windows.Forms.Padding)
		Me.labelStatus.RightToLeft = CType(resources.GetObject("labelStatus.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.labelStatus.Size = CType(resources.GetObject("labelStatus.Size"),System.Drawing.Size)
		Me.labelStatus.TabIndex = CType(resources.GetObject("labelStatus.TabIndex"),Integer)
		Me.labelStatus.Text = resources.GetString("labelStatus.Text")
		Me.labelStatus.TextAlign = CType(resources.GetObject("labelStatus.TextAlign"),System.Drawing.ContentAlignment)
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
		'AutoActivate
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
		Me.ControlBox = false
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.labelStatus)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.labelTitle)
		Me.Font = Nothing
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.ImeMode = CType(resources.GetObject("$this.ImeMode"),System.Windows.Forms.ImeMode)
		Me.Location = CType(resources.GetObject("$this.Location"),System.Drawing.Point)
		Me.MaximizeBox = false
		Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"),System.Drawing.Size)
		Me.MinimizeBox = false
		Me.Name = "AutoActivate"
		Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"),System.Windows.Forms.RightToLeft)
		Me.RightToLeftLayout = CType(resources.GetObject("$this.RightToLeftLayout"),Boolean)
		Me.ShowInTaskbar = false
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = CType(resources.GetObject("$this.StartPosition"),System.Windows.Forms.FormStartPosition)
		Me.Text = resources.GetString("$this.Text")
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
