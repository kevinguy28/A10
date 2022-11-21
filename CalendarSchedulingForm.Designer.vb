<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarSchedulingForm
    Inherits AppForm

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
        Me.schedulingctrl = New A10.CalendarSchedulingControl()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'schedulingctrl
        '
        Me.schedulingctrl.AutoScroll = True
        Me.schedulingctrl.BackColor = System.Drawing.Color.White
        Me.schedulingctrl.Location = New System.Drawing.Point(36, 172)
        Me.schedulingctrl.MaximumSize = New System.Drawing.Size(410, 632)
        Me.schedulingctrl.Name = "schedulingctrl"
        Me.schedulingctrl.Size = New System.Drawing.Size(410, 632)
        Me.schedulingctrl.TabIndex = 0
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.IndianRed
        Me.lblError.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblError.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblError.Location = New System.Drawing.Point(226, 763)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(54, 25)
        Me.lblError.TabIndex = 1
        Me.lblError.Text = "Error"
        Me.lblError.Visible = False
        '
        'CalendarSchedulingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.schedulingctrl)
        Me.DoubleBuffered = True
        Me.Name = "CalendarSchedulingForm"
        Me.Text = "CalendarSchedulingForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents schedulingctrl As CalendarSchedulingControl
    Friend WithEvents lblError As Label
End Class
