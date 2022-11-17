<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccidentNotification
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
        Me.lblAccident1 = New System.Windows.Forms.Label()
        Me.denyButton = New System.Windows.Forms.Button()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAccident2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAccident1
        '
        Me.lblAccident1.AutoSize = True
        Me.lblAccident1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAccident1.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccident1.Location = New System.Drawing.Point(102, 181)
        Me.lblAccident1.Name = "lblAccident1"
        Me.lblAccident1.Size = New System.Drawing.Size(263, 46)
        Me.lblAccident1.TabIndex = 7
        Me.lblAccident1.Text = "An accident has"
        '
        'denyButton
        '
        Me.denyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.denyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.denyButton.Location = New System.Drawing.Point(268, 388)
        Me.denyButton.Name = "denyButton"
        Me.denyButton.Size = New System.Drawing.Size(132, 95)
        Me.denyButton.TabIndex = 6
        Me.denyButton.Text = "Deny Emergency"
        Me.denyButton.UseVisualStyleBackColor = False
        '
        'confirmButton
        '
        Me.confirmButton.BackColor = System.Drawing.Color.Red
        Me.confirmButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.confirmButton.Location = New System.Drawing.Point(67, 388)
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
        Me.Label1.Location = New System.Drawing.Point(138, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Emergency"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblAccident2
        '
        Me.lblAccident2.AutoSize = True
        Me.lblAccident2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAccident2.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccident2.Location = New System.Drawing.Point(109, 227)
        Me.lblAccident2.Name = "lblAccident2"
        Me.lblAccident2.Size = New System.Drawing.Size(249, 46)
        Me.lblAccident2.TabIndex = 9
        Me.lblAccident2.Text = "been detected!"
        '
        'AccidentNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(466, 952)
        Me.Controls.Add(Me.lblAccident2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents lblAccident2 As Label
End Class
