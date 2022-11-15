<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devWindow
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
        Me.accidentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'accidentButton
        '
        Me.accidentButton.Location = New System.Drawing.Point(12, 12)
        Me.accidentButton.Name = "accidentButton"
        Me.accidentButton.Size = New System.Drawing.Size(75, 23)
        Me.accidentButton.TabIndex = 0
        Me.accidentButton.Text = "Accident"
        Me.accidentButton.UseVisualStyleBackColor = True
        '
        'devWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 489)
        Me.Controls.Add(Me.accidentButton)
        Me.Location = New System.Drawing.Point(1170, 200)
        Me.Name = "devWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "devWindow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents accidentButton As Button
End Class
