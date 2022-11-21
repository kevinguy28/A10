<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RouteForm
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
        Me.pbRoute = New System.Windows.Forms.PictureBox()
        CType(Me.pbRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRoute
        '
        Me.pbRoute.Location = New System.Drawing.Point(24, 169)
        Me.pbRoute.Name = "pbRoute"
        Me.pbRoute.Size = New System.Drawing.Size(436, 286)
        Me.pbRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRoute.TabIndex = 0
        Me.pbRoute.TabStop = False
        '
        'RouteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.pbRoute)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RouteForm"
        Me.Text = "RouteForm"
        CType(Me.pbRoute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbRoute As PictureBox
End Class
