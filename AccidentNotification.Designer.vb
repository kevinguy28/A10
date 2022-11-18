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
        Me.lblAccident1 = New System.Windows.Forms.Label()
        Me.denyButton = New System.Windows.Forms.Button()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAccident2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAccident1
        '
        Me.lblAccident1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccident1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAccident1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccident1.Location = New System.Drawing.Point(37, 185)
        Me.lblAccident1.Name = "lblAccident1"
        Me.lblAccident1.Size = New System.Drawing.Size(411, 46)
        Me.lblAccident1.TabIndex = 7
        Me.lblAccident1.Text = "An accident has"
        Me.lblAccident1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'denyButton
        '
        Me.denyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.denyButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.denyButton.Location = New System.Drawing.Point(277, 388)
        Me.denyButton.Name = "denyButton"
        Me.denyButton.Size = New System.Drawing.Size(132, 95)
        Me.denyButton.TabIndex = 6
        Me.denyButton.Text = "Deny Emergency"
        Me.denyButton.UseVisualStyleBackColor = False
        '
        'confirmButton
        '
        Me.confirmButton.BackColor = System.Drawing.Color.Red
        Me.confirmButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.confirmButton.Location = New System.Drawing.Point(76, 388)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(132, 95)
        Me.confirmButton.TabIndex = 5
        Me.confirmButton.Text = "Confirm Emergency"
        Me.confirmButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(109, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 46)
        Me.Label1.TabIndex = 4
        '
        'lblAccident2
        '
        Me.lblAccident2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccident2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAccident2.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccident2.Location = New System.Drawing.Point(109, 231)
        Me.lblAccident2.Name = "lblAccident2"
        Me.lblAccident2.Size = New System.Drawing.Size(267, 46)
        Me.lblAccident2.TabIndex = 9
        Me.lblAccident2.Text = "been detected!"
        Me.lblAccident2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(41, 78)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 65)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Emergency"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.A10.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(205, 810)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 75)
        Me.btnHome.TabIndex = 11
        Me.btnHome.TabStop = False
        Me.btnHome.UseVisualStyleBackColor = True
        Me.btnHome.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.Location = New System.Drawing.Point(153, 591)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(179, 57)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'AccidentNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAccident2)
        Me.Controls.Add(Me.lblAccident1)
        Me.Controls.Add(Me.denyButton)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(685, 200)
        Me.Name = "AccidentNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AccidentNotification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAccident1 As Label
    Friend WithEvents denyButton As Button
    Friend WithEvents confirmButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAccident2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnConfirm As Button
End Class
