<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationForm
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
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(55, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(375, 86)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(125, 672)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(235, 65)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription.Location = New System.Drawing.Point(62, 197)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(361, 274)
        Me.lblDescription.TabIndex = 15
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnApprove.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnApprove.FlatAppearance.BorderSize = 0
        Me.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(98, 538)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(116, 83)
        Me.btnApprove.TabIndex = 16
        Me.btnApprove.Text = "Confirm"
        Me.btnApprove.UseVisualStyleBackColor = False
        Me.btnApprove.Visible = False
        '
        'btnDeny
        '
        Me.btnDeny.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeny.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnDeny.FlatAppearance.BorderSize = 0
        Me.btnDeny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnDeny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeny.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeny.ForeColor = System.Drawing.Color.White
        Me.btnDeny.Location = New System.Drawing.Point(270, 538)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(116, 83)
        Me.btnDeny.TabIndex = 17
        Me.btnDeny.Text = "Cancel"
        Me.btnDeny.UseVisualStyleBackColor = False
        Me.btnDeny.Visible = False
        '
        'NotificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "NotificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NotificationForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnDeny As Button
End Class
