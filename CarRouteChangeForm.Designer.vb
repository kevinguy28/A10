<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRouteChangeForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFromPrompt = New System.Windows.Forms.Label()
        Me.lblToPrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.imgProfilePicture = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStartPrompt = New System.Windows.Forms.Label()
        Me.lblEndPrompt = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(318, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Your Car Is Moving"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFromPrompt
        '
        Me.lblFromPrompt.AutoSize = True
        Me.lblFromPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFromPrompt.Location = New System.Drawing.Point(9, 120)
        Me.lblFromPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromPrompt.Name = "lblFromPrompt"
        Me.lblFromPrompt.Size = New System.Drawing.Size(47, 21)
        Me.lblFromPrompt.TabIndex = 20
        Me.lblFromPrompt.Text = "from:"
        '
        'lblToPrompt
        '
        Me.lblToPrompt.AutoSize = True
        Me.lblToPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblToPrompt.Location = New System.Drawing.Point(29, 141)
        Me.lblToPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToPrompt.Name = "lblToPrompt"
        Me.lblToPrompt.Size = New System.Drawing.Size(27, 21)
        Me.lblToPrompt.TabIndex = 19
        Me.lblToPrompt.Text = "to:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(56, 120)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(239, 42)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "lblTime"
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.SystemColors.Control
        Me.lblCar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCar.Location = New System.Drawing.Point(78, 87)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(217, 30)
        Me.lblCar.TabIndex = 17
        Me.lblCar.Text = "lblCar"
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(78, 57)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 30)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgProfilePicture
        '
        Me.imgProfilePicture.BackColor = System.Drawing.SystemColors.Control
        Me.imgProfilePicture.Location = New System.Drawing.Point(12, 57)
        Me.imgProfilePicture.Name = "imgProfilePicture"
        Me.imgProfilePicture.Size = New System.Drawing.Size(60, 60)
        Me.imgProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProfilePicture.TabIndex = 15
        Me.imgProfilePicture.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(230, 399)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(9, 399)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 40)
        Me.btnConfirm.TabIndex = 22
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(12, 346)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(318, 50)
        Me.lblPrompt.TabIndex = 21
        Me.lblPrompt.Text = "Are you sure you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "want to book this ride?"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(121, 399)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 40)
        Me.btnOk.TabIndex = 24
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblRoute
        '
        Me.lblRoute.BackColor = System.Drawing.SystemColors.Control
        Me.lblRoute.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRoute.Location = New System.Drawing.Point(9, 190)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(318, 30)
        Me.lblRoute.TabIndex = 27
        Me.lblRoute.Text = "Route"
        Me.lblRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(9, 277)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(318, 30)
        Me.lblPrice.TabIndex = 28
        Me.lblPrice.Text = "lblPrice"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartPrompt
        '
        Me.lblStartPrompt.AutoSize = True
        Me.lblStartPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStartPrompt.Location = New System.Drawing.Point(12, 220)
        Me.lblStartPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStartPrompt.Name = "lblStartPrompt"
        Me.lblStartPrompt.Size = New System.Drawing.Size(44, 21)
        Me.lblStartPrompt.TabIndex = 56
        Me.lblStartPrompt.Text = "start:"
        '
        'lblEndPrompt
        '
        Me.lblEndPrompt.AutoSize = True
        Me.lblEndPrompt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndPrompt.Location = New System.Drawing.Point(17, 241)
        Me.lblEndPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEndPrompt.Name = "lblEndPrompt"
        Me.lblEndPrompt.Size = New System.Drawing.Size(39, 21)
        Me.lblEndPrompt.TabIndex = 55
        Me.lblEndPrompt.Text = "end:"
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.Control
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLocation.Location = New System.Drawing.Point(56, 220)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(274, 42)
        Me.lblLocation.TabIndex = 54
        Me.lblLocation.Text = "lblLocation"
        '
        'CarRouteChangeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 451)
        Me.Controls.Add(Me.lblStartPrompt)
        Me.Controls.Add(Me.lblEndPrompt)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblRoute)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblFromPrompt)
        Me.Controls.Add(Me.lblToPrompt)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.imgProfilePicture)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "CarRouteChangeForm"
        Me.Text = "CarRouteChangeFormvb"
        CType(Me.imgProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFromPrompt As Label
    Friend WithEvents lblToPrompt As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblName As Label
    Friend WithEvents imgProfilePicture As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lblRoute As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStartPrompt As Label
    Friend WithEvents lblEndPrompt As Label
    Friend WithEvents lblLocation As Label
End Class
