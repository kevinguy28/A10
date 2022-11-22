<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccidentNotification
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
        Me.lblAccident = New System.Windows.Forms.Label()
        Me.denyButton = New System.Windows.Forms.Button()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAccident
        '
        Me.lblAccident.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccident.BackColor = System.Drawing.SystemColors.Control
        Me.lblAccident.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAccident.Location = New System.Drawing.Point(12, 55)
        Me.lblAccident.Name = "lblAccident"
        Me.lblAccident.Size = New System.Drawing.Size(280, 50)
        Me.lblAccident.TabIndex = 7
        Me.lblAccident.Text = "An accident has " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "been detected!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblAccident.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'denyButton
        '
        Me.denyButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.denyButton.FlatAppearance.BorderSize = 0
        Me.denyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.denyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.denyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.denyButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.denyButton.ForeColor = System.Drawing.Color.White
        Me.denyButton.Location = New System.Drawing.Point(177, 140)
        Me.denyButton.Name = "denyButton"
        Me.denyButton.Size = New System.Drawing.Size(115, 59)
        Me.denyButton.TabIndex = 6
        Me.denyButton.Text = "Deny Emergency"
        Me.denyButton.UseVisualStyleBackColor = False
        '
        'confirmButton
        '
        Me.confirmButton.BackColor = System.Drawing.Color.IndianRed
        Me.confirmButton.FlatAppearance.BorderSize = 0
        Me.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.confirmButton.ForeColor = System.Drawing.Color.White
        Me.confirmButton.Location = New System.Drawing.Point(12, 140)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(115, 59)
        Me.confirmButton.TabIndex = 5
        Me.confirmButton.Text = "Confirm Emergency"
        Me.confirmButton.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 46)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Emergency"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnConfirm.Location = New System.Drawing.Point(63, 152)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(179, 35)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'AccidentNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(304, 211)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAccident)
        Me.Controls.Add(Me.denyButton)
        Me.Controls.Add(Me.confirmButton)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(685, 200)
        Me.Name = "AccidentNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Accident Notification"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAccident As Label
    Friend WithEvents denyButton As Button
    Friend WithEvents confirmButton As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnConfirm As Button
End Class
