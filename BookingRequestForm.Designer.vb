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
        Me.lblName.Location = New System.Drawing.Point(78, 107)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 30)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgProfilePicture
        '
        Me.imgProfilePicture.BackColor = System.Drawing.SystemColors.Control
        Me.imgProfilePicture.Location = New System.Drawing.Point(12, 107)
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
        Me.imgRating.Location = New System.Drawing.Point(82, 140)
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
        Me.lblFromPrompt.Location = New System.Drawing.Point(31, 171)
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
        Me.lblToPrompt.Location = New System.Drawing.Point(51, 192)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(27, 21)
        Me.lblToPrompt.TabIndex = 18
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(78, 171)
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
        Me.btnDeny.Location = New System.Drawing.Point(192, 269)
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
        Me.btnAccept.Location = New System.Drawing.Point(12, 269)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(100, 40)
        Me.btnAccept.TabIndex = 21
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'BookingRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 321)
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
End Class
