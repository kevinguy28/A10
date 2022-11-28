<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarModifyForm
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.lblEndPrompt = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(9, 301)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(346, 50)
        Me.lblPrompt.TabIndex = 55
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
        Me.lblFromPrompt.TabIndex = 54
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
        Me.lblToPrompt.TabIndex = 53
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(56, 150)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(299, 42)
        Me.lblTime.TabIndex = 52
        Me.lblTime.Text = "lblTime"
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.SystemColors.Control
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(78, 117)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(274, 30)
        Me.lblCar.TabIndex = 51
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
        Me.lblName.TabIndex = 50
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
        Me.imgProfilePicture.TabIndex = 49
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
        Me.lblUser.TabIndex = 48
        Me.lblUser.Text = "lblUser"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(132, 409)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(252, 354)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 40)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(12, 354)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 40)
        Me.btnEdit.TabIndex = 45
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(340, 45)
        Me.lblTitle.TabIndex = 44
        Me.lblTitle.Text = "lblTitle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription.Location = New System.Drawing.Point(45, -241)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(191, 52)
        Me.lblDescription.TabIndex = 43
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRate
        '
        Me.btnRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnRate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnRate.FlatAppearance.BorderSize = 0
        Me.btnRate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnRate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRate.ForeColor = System.Drawing.Color.White
        Me.btnRate.Location = New System.Drawing.Point(252, 77)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(100, 40)
        Me.btnRate.TabIndex = 56
        Me.btnRate.Text = "Rate"
        Me.btnRate.UseVisualStyleBackColor = False
        '
        'lblStartPrompt
        '
        Me.lblStartPrompt.AutoSize = True
        Me.lblStartPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartPrompt.Location = New System.Drawing.Point(12, 192)
        Me.lblStartPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStartPrompt.Name = "lblStartPrompt"
        Me.lblStartPrompt.Size = New System.Drawing.Size(44, 21)
        Me.lblStartPrompt.TabIndex = 64
        Me.lblStartPrompt.Text = "start:"
        '
        'lblEndPrompt
        '
        Me.lblEndPrompt.AutoSize = True
        Me.lblEndPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndPrompt.Location = New System.Drawing.Point(17, 213)
        Me.lblEndPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEndPrompt.Name = "lblEndPrompt"
        Me.lblEndPrompt.Size = New System.Drawing.Size(39, 21)
        Me.lblEndPrompt.TabIndex = 63
        Me.lblEndPrompt.Text = "end:"
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.Control
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLocation.Location = New System.Drawing.Point(56, 192)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(296, 42)
        Me.lblLocation.TabIndex = 62
        Me.lblLocation.Text = "lblLocation"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(9, 249)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(343, 30)
        Me.lblPrice.TabIndex = 61
        Me.lblPrice.Text = "lblPrice"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalendarModifyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 461)
        Me.Controls.Add(Me.lblStartPrompt)
        Me.Controls.Add(Me.lblEndPrompt)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnRate)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfilePicture)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDescription)
        Me.Name = "CalendarModifyForm"
        Me.Text = "CalendarModify"
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblName As Label
    Friend WithEvents imgProfilePicture As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnRate As Button
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents lblEndPrompt As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblPrice As Label
End Class
