<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarDayForm
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
        Me.usrctrlDay = New A10.CalendarDayControl()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usrctrlDay
        '
        Me.usrctrlDay.AutoScroll = True
        Me.usrctrlDay.BackColor = System.Drawing.Color.White
        Me.usrctrlDay.Location = New System.Drawing.Point(60, 273)
        Me.usrctrlDay.Margin = New System.Windows.Forms.Padding(2)
        Me.usrctrlDay.Name = "usrctrlDay"
        Me.usrctrlDay.Size = New System.Drawing.Size(359, 400)
        Me.usrctrlDay.TabIndex = 4
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.White
        Me.lblDay.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDay.Location = New System.Drawing.Point(47, 197)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(390, 45)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CalendarDayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.usrctrlDay)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CalendarDayForm"
        Me.Text = "CalendarDayForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usrctrlDay As CalendarDayControl
    Friend WithEvents lblDay As Label
End Class
