<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarMediaForm
    Inherits AppForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSpeakers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolumeDown = New System.Windows.Forms.Button()
        Me.btnVolumeUp = New System.Windows.Forms.Button()
        Me.lblVolumeNumber = New System.Windows.Forms.Label()
        Me.btnSpeakersToggle = New System.Windows.Forms.Button()
        Me.btnConnectPhone = New System.Windows.Forms.Button()
        Me.tmrSync = New System.Windows.Forms.Timer(Me.components)
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.pbPlay = New System.Windows.Forms.PictureBox()
        Me.pbPause = New System.Windows.Forms.PictureBox()
        Me.lblSongTitle = New System.Windows.Forms.Label()
        Me.lblSongStatus = New System.Windows.Forms.Label()
        CType(Me.pbPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpeakers
        '
        Me.lblSpeakers.AutoSize = True
        Me.lblSpeakers.BackColor = System.Drawing.Color.White
        Me.lblSpeakers.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSpeakers.Location = New System.Drawing.Point(72, 289)
        Me.lblSpeakers.Name = "lblSpeakers"
        Me.lblSpeakers.Size = New System.Drawing.Size(112, 32)
        Me.lblSpeakers.TabIndex = 0
        Me.lblSpeakers.Text = "Speakers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(72, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Volume"
        '
        'btnVolumeDown
        '
        Me.btnVolumeDown.BackColor = System.Drawing.Color.White
        Me.btnVolumeDown.BackgroundImage = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.btnVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolumeDown.FlatAppearance.BorderSize = 0
        Me.btnVolumeDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnVolumeDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnVolumeDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnVolumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolumeDown.Location = New System.Drawing.Point(246, 371)
        Me.btnVolumeDown.Name = "btnVolumeDown"
        Me.btnVolumeDown.Size = New System.Drawing.Size(50, 50)
        Me.btnVolumeDown.TabIndex = 2
        Me.btnVolumeDown.UseVisualStyleBackColor = True
        '
        'btnVolumeUp
        '
        Me.btnVolumeUp.BackColor = System.Drawing.Color.White
        Me.btnVolumeUp.BackgroundImage = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.btnVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolumeUp.FlatAppearance.BorderSize = 0
        Me.btnVolumeUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnVolumeUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnVolumeUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnVolumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolumeUp.Location = New System.Drawing.Point(356, 371)
        Me.btnVolumeUp.Name = "btnVolumeUp"
        Me.btnVolumeUp.Size = New System.Drawing.Size(50, 50)
        Me.btnVolumeUp.TabIndex = 3
        Me.btnVolumeUp.UseVisualStyleBackColor = True
        '
        'lblVolumeNumber
        '
        Me.lblVolumeNumber.BackColor = System.Drawing.Color.White
        Me.lblVolumeNumber.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVolumeNumber.Location = New System.Drawing.Point(302, 371)
        Me.lblVolumeNumber.Name = "lblVolumeNumber"
        Me.lblVolumeNumber.Size = New System.Drawing.Size(48, 46)
        Me.lblVolumeNumber.TabIndex = 4
        Me.lblVolumeNumber.Text = "1"
        Me.lblVolumeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSpeakersToggle
        '
        Me.btnSpeakersToggle.BackColor = System.Drawing.Color.White
        Me.btnSpeakersToggle.BackgroundImage = Global.A10.My.Resources.Resources.toggle_off
        Me.btnSpeakersToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSpeakersToggle.FlatAppearance.BorderSize = 0
        Me.btnSpeakersToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnSpeakersToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSpeakersToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSpeakersToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeakersToggle.Location = New System.Drawing.Point(310, 265)
        Me.btnSpeakersToggle.Name = "btnSpeakersToggle"
        Me.btnSpeakersToggle.Size = New System.Drawing.Size(96, 78)
        Me.btnSpeakersToggle.TabIndex = 5
        Me.btnSpeakersToggle.Tag = "1"
        Me.btnSpeakersToggle.UseVisualStyleBackColor = True
        '
        'btnConnectPhone
        '
        Me.btnConnectPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnConnectPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnConnectPhone.FlatAppearance.BorderSize = 0
        Me.btnConnectPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnConnectPhone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnConnectPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnectPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConnectPhone.Location = New System.Drawing.Point(125, 463)
        Me.btnConnectPhone.Name = "btnConnectPhone"
        Me.btnConnectPhone.Size = New System.Drawing.Size(234, 60)
        Me.btnConnectPhone.TabIndex = 6
        Me.btnConnectPhone.Tag = "0"
        Me.btnConnectPhone.Text = "Connect Phone"
        Me.btnConnectPhone.UseVisualStyleBackColor = False
        '
        'tmrSync
        '
        '
        'lblConnected
        '
        Me.lblConnected.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnected.BackColor = System.Drawing.Color.Transparent
        Me.lblConnected.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConnected.Location = New System.Drawing.Point(82, 544)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(320, 31)
        Me.lblConnected.TabIndex = 7
        Me.lblConnected.Text = "iPhone X Connected"
        Me.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblConnected.Visible = False
        '
        'pbPlay
        '
        Me.pbPlay.BackColor = System.Drawing.Color.Transparent
        Me.pbPlay.Image = Global.A10.My.Resources.Resources.play
        Me.pbPlay.Location = New System.Drawing.Point(113, 589)
        Me.pbPlay.Name = "pbPlay"
        Me.pbPlay.Size = New System.Drawing.Size(54, 51)
        Me.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPlay.TabIndex = 10
        Me.pbPlay.TabStop = False
        Me.pbPlay.Visible = False
        '
        'pbPause
        '
        Me.pbPause.BackColor = System.Drawing.Color.Transparent
        Me.pbPause.Image = Global.A10.My.Resources.Resources.pause
        Me.pbPause.Location = New System.Drawing.Point(310, 589)
        Me.pbPause.Name = "pbPause"
        Me.pbPause.Size = New System.Drawing.Size(54, 51)
        Me.pbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPause.TabIndex = 11
        Me.pbPause.TabStop = False
        Me.pbPause.Visible = False
        '
        'lblSongTitle
        '
        Me.lblSongTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSongTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSongTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSongTitle.Location = New System.Drawing.Point(49, 654)
        Me.lblSongTitle.Name = "lblSongTitle"
        Me.lblSongTitle.Size = New System.Drawing.Size(386, 52)
        Me.lblSongTitle.TabIndex = 12
        Me.lblSongTitle.Text = "BTS - House Of Cards"
        Me.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSongTitle.Visible = False
        '
        'lblSongStatus
        '
        Me.lblSongStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSongStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblSongStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSongStatus.Location = New System.Drawing.Point(192, 600)
        Me.lblSongStatus.Name = "lblSongStatus"
        Me.lblSongStatus.Size = New System.Drawing.Size(100, 28)
        Me.lblSongStatus.TabIndex = 13
        Me.lblSongStatus.Text = "Paused"
        Me.lblSongStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSongStatus.Visible = False
        '
        'CarMediaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblSongStatus)
        Me.Controls.Add(Me.lblSongTitle)
        Me.Controls.Add(Me.pbPause)
        Me.Controls.Add(Me.pbPlay)
        Me.Controls.Add(Me.lblConnected)
        Me.Controls.Add(Me.btnVolumeUp)
        Me.Controls.Add(Me.btnConnectPhone)
        Me.Controls.Add(Me.btnSpeakersToggle)
        Me.Controls.Add(Me.lblVolumeNumber)
        Me.Controls.Add(Me.btnVolumeDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSpeakers)
        Me.DoubleBuffered = True
        Me.Name = "CarMediaForm"
        Me.Text = "CarMediaForm"
        CType(Me.pbPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpeakers As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolumeDown As Button
    Friend WithEvents btnVolumeUp As Button
    Friend WithEvents lblVolumeNumber As Label
    Friend WithEvents btnSpeakersToggle As Button
    Friend WithEvents btnConnectPhone As Button
    Friend WithEvents tmrSync As Timer
    Friend WithEvents lblConnected As Label
    Friend WithEvents pbPlay As PictureBox
    Friend WithEvents pbPause As PictureBox
    Friend WithEvents lblSongTitle As Label
    Friend WithEvents lblSongStatus As Label
End Class
