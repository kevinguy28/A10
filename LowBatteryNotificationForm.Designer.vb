<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LowBatteryNotificationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbLowBattery = New System.Windows.Forms.PictureBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.pbLowBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLowBattery
        '
        Me.pbLowBattery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbLowBattery.BackColor = System.Drawing.Color.Transparent
        Me.pbLowBattery.Image = Global.A10.My.Resources.Resources.LowBattery
        Me.pbLowBattery.Location = New System.Drawing.Point(132, 249)
        Me.pbLowBattery.Name = "pbLowBattery"
        Me.pbLowBattery.Size = New System.Drawing.Size(100, 50)
        Me.pbLowBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLowBattery.TabIndex = 22
        Me.pbLowBattery.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(9, 306)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(346, 50)
        Me.lblPrompt.TabIndex = 54
        Me.lblPrompt.Text = "lblPrompt"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblFromPrompt
        '
        Me.lblFromPrompt.AutoSize = True
        Me.lblFromPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFromPrompt.Location = New System.Drawing.Point(9, 150)
        Me.lblFromPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromPrompt.Name = "lblFromPrompt"
        Me.lblFromPrompt.Size = New System.Drawing.Size(47, 21)
        Me.lblFromPrompt.TabIndex = 53
        Me.lblFromPrompt.Text = "from:"
        '
        'lblToPrompt
        '
        Me.lblToPrompt.AutoSize = True
        Me.lblToPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToPrompt.Location = New System.Drawing.Point(29, 171)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(27, 21)
        Me.lblToPrompt.TabIndex = 52
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(56, 150)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(299, 42)
        Me.lblTime.TabIndex = 51
        Me.lblTime.Text = "lblTime"
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.SystemColors.Control
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(78, 117)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(274, 30)
        Me.lblCar.TabIndex = 50
        Me.lblCar.Text = "lblCar"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(78, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 30)
        Me.lblName.TabIndex = 49
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgProfilePicture
        '
        Me.imgProfilePicture.BackColor = System.Drawing.SystemColors.Control
        Me.imgProfilePicture.Location = New System.Drawing.Point(12, 87)
        Me.imgProfilePicture.Name = "imgProfilePicture"
        Me.imgProfilePicture.Size = New System.Drawing.Size(60, 60)
        Me.imgProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProfilePicture.TabIndex = 48
        Me.imgProfilePicture.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.Location = New System.Drawing.Point(12, 54)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(79, 30)
        Me.lblUser.TabIndex = 47
        Me.lblUser.Text = "lblUser"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(132, 359)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 40)
        Me.btnOk.TabIndex = 46
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEnd.BackColor = System.Drawing.Color.IndianRed
        Me.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEnd.ForeColor = System.Drawing.Color.White
        Me.btnEnd.Location = New System.Drawing.Point(210, 359)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(142, 40)
        Me.btnEnd.TabIndex = 45
        Me.btnEnd.Text = "End Ride"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnContinue.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(12, 359)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(142, 40)
        Me.btnContinue.TabIndex = 44
        Me.btnContinue.Text = "Continue Ride"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(340, 45)
        Me.lblTitle.TabIndex = 43
        Me.lblTitle.Text = "lblTitle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LowBatteryNotificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(364, 411)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfilePicture)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbLowBattery)
        Me.DoubleBuffered = True
        Me.Name = "LowBatteryNotificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LowBatteryNotificationForm"
        CType(Me.pbLowBattery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLowBattery As PictureBox
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblName As Label
    Friend WithEvents imgProfilePicture As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblTitle As Label
End Class
