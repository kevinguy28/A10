<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TripOngoingForm
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
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.lblEndPrompt = New System.Windows.Forms.Label()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.Control
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLocation.Location = New System.Drawing.Point(56, 194)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(239, 42)
        Me.lblLocation.TabIndex = 50
        Me.lblLocation.Text = "lblLocation"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.Location = New System.Drawing.Point(12, 56)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(79, 30)
        Me.lblUser.TabIndex = 49
        Me.lblUser.Text = "lblUser"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(102, 326)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 40)
        Me.btnOk.TabIndex = 47
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(15, 273)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(275, 50)
        Me.lblPrompt.TabIndex = 46
        Me.lblPrompt.Text = "This ride is currently ongoing and cannot be changed."
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromPrompt
        '
        Me.lblFromPrompt.AutoSize = True
        Me.lblFromPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFromPrompt.Location = New System.Drawing.Point(9, 152)
        Me.lblFromPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromPrompt.Name = "lblFromPrompt"
        Me.lblFromPrompt.Size = New System.Drawing.Size(47, 21)
        Me.lblFromPrompt.TabIndex = 45
        Me.lblFromPrompt.Text = "from:"
        '
        'lblToPrompt
        '
        Me.lblToPrompt.AutoSize = True
        Me.lblToPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToPrompt.Location = New System.Drawing.Point(29, 173)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(27, 21)
        Me.lblToPrompt.TabIndex = 44
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(56, 152)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(239, 42)
        Me.lblTime.TabIndex = 43
        Me.lblTime.Text = "lblTime"
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.SystemColors.Control
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(78, 119)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(217, 30)
        Me.lblCar.TabIndex = 42
        Me.lblCar.Text = "lblCar"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(78, 89)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 30)
        Me.lblName.TabIndex = 41
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgProfilePicture
        '
        Me.imgProfilePicture.BackColor = System.Drawing.SystemColors.Control
        Me.imgProfilePicture.Location = New System.Drawing.Point(12, 89)
        Me.imgProfilePicture.Name = "imgProfilePicture"
        Me.imgProfilePicture.Size = New System.Drawing.Size(60, 60)
        Me.imgProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProfilePicture.TabIndex = 40
        Me.imgProfilePicture.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(275, 45)
        Me.lblTitle.TabIndex = 39
        Me.lblTitle.Text = "Trip Ongoing"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStartPrompt
        '
        Me.lblStartPrompt.AutoSize = True
        Me.lblStartPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartPrompt.Location = New System.Drawing.Point(12, 194)
        Me.lblStartPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStartPrompt.Name = "lblStartPrompt"
        Me.lblStartPrompt.Size = New System.Drawing.Size(44, 21)
        Me.lblStartPrompt.TabIndex = 53
        Me.lblStartPrompt.Text = "start:"
        '
        'lblEndPrompt
        '
        Me.lblEndPrompt.AutoSize = True
        Me.lblEndPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndPrompt.Location = New System.Drawing.Point(17, 215)
        Me.lblEndPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEndPrompt.Name = "lblEndPrompt"
        Me.lblEndPrompt.Size = New System.Drawing.Size(39, 21)
        Me.lblEndPrompt.TabIndex = 52
        Me.lblEndPrompt.Text = "end:"
        '
        'TripOngoingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 376)
        Me.Controls.Add(Me.lblStartPrompt)
        Me.Controls.Add(Me.lblEndPrompt)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfilePicture)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "TripOngoingForm"
        Me.Text = "TripOngoingForm"
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLocation As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblName As Label
    Friend WithEvents imgProfilePicture As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents lblEndPrompt As Label
End Class
