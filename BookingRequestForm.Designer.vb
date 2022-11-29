<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingRequestForm
    Inherits System.Windows.Forms.Form

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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.imgRating = New System.Windows.Forms.PictureBox()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.lblEndPrompt = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStopsPrompt = New System.Windows.Forms.Label()
        Me.lblStops = New System.Windows.Forms.Label()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(275, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Booking Request"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(78, 137)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 30)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgProfilePicture
        '
        Me.imgProfilePicture.BackColor = System.Drawing.SystemColors.Control
        Me.imgProfilePicture.Location = New System.Drawing.Point(12, 137)
        Me.imgProfilePicture.Name = "imgProfilePicture"
        Me.imgProfilePicture.Size = New System.Drawing.Size(60, 60)
        Me.imgProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProfilePicture.TabIndex = 12
        Me.imgProfilePicture.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(12, 54)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(275, 50)
        Me.lblPrompt.TabIndex = 15
        Me.lblPrompt.Text = "lblPrompt"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgRating
        '
        Me.imgRating.Location = New System.Drawing.Point(82, 170)
        Me.imgRating.Name = "imgRating"
        Me.imgRating.Size = New System.Drawing.Size(157, 28)
        Me.imgRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRating.TabIndex = 16
        Me.imgRating.TabStop = False
        '
        'lblFromPrompt
        '
        Me.lblFromPrompt.AutoSize = True
        Me.lblFromPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFromPrompt.Location = New System.Drawing.Point(31, 201)
        Me.lblFromPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromPrompt.Name = "lblFromPrompt"
        Me.lblFromPrompt.Size = New System.Drawing.Size(47, 21)
        Me.lblFromPrompt.TabIndex = 19
        Me.lblFromPrompt.Text = "from:"
        '
        'lblToPrompt
        '
        Me.lblToPrompt.AutoSize = True
        Me.lblToPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToPrompt.Location = New System.Drawing.Point(51, 222)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(27, 21)
        Me.lblToPrompt.TabIndex = 18
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(78, 201)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(226, 42)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "lblTime"
        '
        'btnDeny
        '
        Me.btnDeny.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDeny.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeny.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnDeny.FlatAppearance.BorderSize = 0
        Me.btnDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeny.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeny.ForeColor = System.Drawing.Color.White
        Me.btnDeny.Location = New System.Drawing.Point(212, 409)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(100, 40)
        Me.btnDeny.TabIndex = 22
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = False
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAccept.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(12, 409)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(100, 40)
        Me.btnAccept.TabIndex = 21
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.Location = New System.Drawing.Point(12, 104)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(79, 30)
        Me.lblUser.TabIndex = 36
        Me.lblUser.Text = "lblUser"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartPrompt
        '
        Me.lblStartPrompt.AutoSize = True
        Me.lblStartPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartPrompt.Location = New System.Drawing.Point(34, 243)
        Me.lblStartPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStartPrompt.Name = "lblStartPrompt"
        Me.lblStartPrompt.Size = New System.Drawing.Size(44, 21)
        Me.lblStartPrompt.TabIndex = 60
        Me.lblStartPrompt.Text = "start:"
        '
        'lblEndPrompt
        '
        Me.lblEndPrompt.AutoSize = True
        Me.lblEndPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndPrompt.Location = New System.Drawing.Point(39, 264)
        Me.lblEndPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEndPrompt.Name = "lblEndPrompt"
        Me.lblEndPrompt.Size = New System.Drawing.Size(39, 21)
        Me.lblEndPrompt.TabIndex = 59
        Me.lblEndPrompt.Text = "end:"
        '
        'lblLocation
        '
        Me.lblLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocation.BackColor = System.Drawing.SystemColors.Control
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLocation.Location = New System.Drawing.Point(78, 243)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(246, 42)
        Me.lblLocation.TabIndex = 58
        Me.lblLocation.Text = "lblLocation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toronto Metropolitan University"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(31, 336)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(273, 30)
        Me.lblPrice.TabIndex = 57
        Me.lblPrice.Text = "lblPrice"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStopsPrompt
        '
        Me.lblStopsPrompt.AutoSize = True
        Me.lblStopsPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStopsPrompt.Location = New System.Drawing.Point(32, 285)
        Me.lblStopsPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStopsPrompt.Name = "lblStopsPrompt"
        Me.lblStopsPrompt.Size = New System.Drawing.Size(50, 21)
        Me.lblStopsPrompt.TabIndex = 67
        Me.lblStopsPrompt.Text = "stops:"
        '
        'lblStops
        '
        Me.lblStops.BackColor = System.Drawing.SystemColors.Control
        Me.lblStops.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStops.Location = New System.Drawing.Point(82, 285)
        Me.lblStops.Name = "lblStops"
        Me.lblStops.Size = New System.Drawing.Size(242, 42)
        Me.lblStops.TabIndex = 66
        Me.lblStops.Text = "lblStops" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toronto Metropolitan University"
        '
        'BookingRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 461)
        Me.Controls.Add(Me.lblStopsPrompt)
        Me.Controls.Add(Me.lblStops)
        Me.Controls.Add(Me.lblStartPrompt)
        Me.Controls.Add(Me.lblEndPrompt)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.imgRating)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfilePicture)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "BookingRequestForm"
        Me.Text = "Car Owner Booking Request"
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents imgProfilePicture As PictureBox
    Friend WithEvents lblPrompt As Label
    Friend WithEvents imgRating As PictureBox
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnDeny As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents lblEndPrompt As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStopsPrompt As Label
    Friend WithEvents lblStops As Label
End Class
