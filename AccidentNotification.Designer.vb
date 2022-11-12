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
        Me.accidentLabel = New System.Windows.Forms.Label()
        Me.denyButton = New System.Windows.Forms.Button()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'accidentLabel
        '
        Me.accidentLabel.AutoSize = True
        Me.accidentLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.accidentLabel.Location = New System.Drawing.Point(61, 133)
        Me.accidentLabel.Name = "accidentLabel"
        Me.accidentLabel.Size = New System.Drawing.Size(247, 13)
        Me.accidentLabel.TabIndex = 7
        Me.accidentLabel.Text = "An accident has been detected!"
        '
        'denyButton
        '
        Me.denyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.denyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.denyButton.Location = New System.Drawing.Point(202, 187)
        Me.denyButton.Name = "denyButton"
        Me.denyButton.Size = New System.Drawing.Size(86, 68)
        Me.denyButton.TabIndex = 6
        Me.denyButton.Text = "Deny Emergency"
        Me.denyButton.UseVisualStyleBackColor = False
        '
        'confirmButton
        '
        Me.confirmButton.BackColor = System.Drawing.Color.Red
        Me.confirmButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.confirmButton.Location = New System.Drawing.Point(81, 187)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(86, 68)
        Me.confirmButton.TabIndex = 5
        Me.confirmButton.Text = "Confirm Emergency"
        Me.confirmButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(111, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Emergency"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AccidentNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(369, 629)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.accidentLabel)
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

    Friend WithEvents accidentLabel As Label
    Friend WithEvents denyButton As Button
    Friend WithEvents confirmButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
