<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.kuberLogo = New System.Windows.Forms.PictureBox()
        CType(Me.kuberLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kuberLogo
        '
        Me.kuberLogo.Image = Global.A10.My.Resources.Resources.kuber
        Me.kuberLogo.Location = New System.Drawing.Point(164, 63)
        Me.kuberLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kuberLogo.Name = "kuberLogo"
        Me.kuberLogo.Size = New System.Drawing.Size(150, 100)
        Me.kuberLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kuberLogo.TabIndex = 9
        Me.kuberLogo.TabStop = False
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(478, 944)
        Me.Controls.Add(Me.kuberLogo)
        Me.DoubleBuffered = True
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        CType(Me.kuberLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents kuberLogo As PictureBox
End Class
