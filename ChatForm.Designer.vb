<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatForm
    Inherits AppForm

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
        Me.btnDim = New System.Windows.Forms.Button()
        Me.btnUndim = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDim
        '
        Me.btnDim.Location = New System.Drawing.Point(205, 434)
        Me.btnDim.Name = "btnDim"
        Me.btnDim.Size = New System.Drawing.Size(75, 23)
        Me.btnDim.TabIndex = 1
        Me.btnDim.Text = "Dim"
        Me.btnDim.UseVisualStyleBackColor = True
        '
        'btnUndim
        '
        Me.btnUndim.Location = New System.Drawing.Point(205, 503)
        Me.btnUndim.Name = "btnUndim"
        Me.btnUndim.Size = New System.Drawing.Size(75, 23)
        Me.btnUndim.TabIndex = 2
        Me.btnUndim.Text = "Undim"
        Me.btnUndim.UseVisualStyleBackColor = True
        '
        'ChatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnUndim)
        Me.Controls.Add(Me.btnDim)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChatForm"
        Me.Text = "ChatForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDim As Button
    Friend WithEvents btnUndim As Button
End Class
