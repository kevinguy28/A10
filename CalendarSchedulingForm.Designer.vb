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
        Me.lblTopBar = New System.Windows.Forms.Label()
        Me.lblBotBar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'schedulingctrl
        '
        Me.schedulingctrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.schedulingctrl.AutoScroll = True
        Me.schedulingctrl.BackColor = System.Drawing.Color.White
        Me.schedulingctrl.Location = New System.Drawing.Point(24, 172)
        Me.schedulingctrl.MaximumSize = New System.Drawing.Size(410, 631)
        Me.schedulingctrl.MinimumSize = New System.Drawing.Size(435, 631)
        Me.schedulingctrl.Name = "schedulingctrl"
        Me.schedulingctrl.Size = New System.Drawing.Size(435, 631)
        Me.schedulingctrl.TabIndex = 5
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.IndianRed
        Me.lblError.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblError.ForeColor = System.Drawing.Color.White
        Me.lblError.Location = New System.Drawing.Point(195, 768)
        Me.lblError.Margin = New System.Windows.Forms.Padding(0)
        Me.lblError.Name = "lblError"
        Me.lblError.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblError.Size = New System.Drawing.Size(95, 25)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "lblError"
        Me.lblError.Visible = False
        '
        'lblTopBar
        '
        Me.lblTopBar.BackColor = System.Drawing.Color.White
        Me.lblTopBar.Location = New System.Drawing.Point(24, 172)
        Me.lblTopBar.Name = "lblTopBar"
        Me.lblTopBar.Size = New System.Drawing.Size(435, 10)
        Me.lblTopBar.TabIndex = 7
        '
        'lblBotBar
        '
        Me.lblBotBar.BackColor = System.Drawing.Color.White
        Me.lblBotBar.Location = New System.Drawing.Point(24, 793)
        Me.lblBotBar.Name = "lblBotBar"
        Me.lblBotBar.Size = New System.Drawing.Size(435, 10)
        Me.lblBotBar.TabIndex = 8
        '
        'CalendarSchedulingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblBotBar)
        Me.Controls.Add(Me.lblTopBar)
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
    Friend WithEvents lblTopBar As Label
    Friend WithEvents lblBotBar As Label
End Class
