<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarSchedulingControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblEndRight = New System.Windows.Forms.Label()
        Me.lblStartRight = New System.Windows.Forms.Label()
        Me.lblEndLeft = New System.Windows.Forms.Label()
        Me.lblStartLeft = New System.Windows.Forms.Label()
        Me.tmrMouseHold = New System.Windows.Forms.Timer(Me.components)
        Me.flPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblRepeatLeft = New System.Windows.Forms.Label()
        Me.lblRepeatRight = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEndRight
        '
        Me.lblEndRight.BackColor = System.Drawing.Color.DarkGray
        Me.lblEndRight.Location = New System.Drawing.Point(15, 60)
        Me.lblEndRight.Name = "lblEndRight"
        Me.lblEndRight.Size = New System.Drawing.Size(5, 50)
        Me.lblEndRight.TabIndex = 2
        Me.lblEndRight.Text = "  "
        '
        'lblStartRight
        '
        Me.lblStartRight.BackColor = System.Drawing.Color.DarkGray
        Me.lblStartRight.Location = New System.Drawing.Point(15, 3)
        Me.lblStartRight.Name = "lblStartRight"
        Me.lblStartRight.Size = New System.Drawing.Size(5, 50)
        Me.lblStartRight.TabIndex = 1
        Me.lblStartRight.Text = "  "
        '
        'lblEndLeft
        '
        Me.lblEndLeft.BackColor = System.Drawing.Color.DarkGray
        Me.lblEndLeft.Location = New System.Drawing.Point(3, 60)
        Me.lblEndLeft.Name = "lblEndLeft"
        Me.lblEndLeft.Size = New System.Drawing.Size(5, 50)
        Me.lblEndLeft.TabIndex = 3
        Me.lblEndLeft.Text = "  "
        '
        'lblStartLeft
        '
        Me.lblStartLeft.BackColor = System.Drawing.Color.DarkGray
        Me.lblStartLeft.Location = New System.Drawing.Point(3, 3)
        Me.lblStartLeft.Name = "lblStartLeft"
        Me.lblStartLeft.Size = New System.Drawing.Size(5, 50)
        Me.lblStartLeft.TabIndex = 0
        Me.lblStartLeft.Text = "  "
        '
        'tmrMouseHold
        '
        Me.tmrMouseHold.Interval = 10
        '
        'flPanel
        '
        Me.flPanel.Location = New System.Drawing.Point(310, 0)
        Me.flPanel.Name = "flPanel"
        Me.flPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.flPanel.Size = New System.Drawing.Size(100, 100)
        Me.flPanel.TabIndex = 7
        '
        'lblRepeatLeft
        '
        Me.lblRepeatLeft.BackColor = System.Drawing.Color.DarkGray
        Me.lblRepeatLeft.Location = New System.Drawing.Point(3, 119)
        Me.lblRepeatLeft.Name = "lblRepeatLeft"
        Me.lblRepeatLeft.Size = New System.Drawing.Size(5, 50)
        Me.lblRepeatLeft.TabIndex = 9
        Me.lblRepeatLeft.Text = "  "
        '
        'lblRepeatRight
        '
        Me.lblRepeatRight.BackColor = System.Drawing.Color.DarkGray
        Me.lblRepeatRight.Location = New System.Drawing.Point(15, 119)
        Me.lblRepeatRight.Name = "lblRepeatRight"
        Me.lblRepeatRight.Size = New System.Drawing.Size(5, 50)
        Me.lblRepeatRight.TabIndex = 8
        Me.lblRepeatRight.Text = "  "
        '
        'CalendarSchedulingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblRepeatLeft)
        Me.Controls.Add(Me.lblRepeatRight)
        Me.Controls.Add(Me.flPanel)
        Me.Controls.Add(Me.lblStartLeft)
        Me.Controls.Add(Me.lblEndLeft)
        Me.Controls.Add(Me.lblStartRight)
        Me.Controls.Add(Me.lblEndRight)
        Me.MaximumSize = New System.Drawing.Size(410, 632)
        Me.Name = "CalendarSchedulingControl"
        Me.Size = New System.Drawing.Size(410, 632)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEndRight As Label
    Friend WithEvents lblStartRight As Label
    Friend WithEvents lblEndLeft As Label
    Friend WithEvents lblStartLeft As Label
    Friend WithEvents tmrMouseHold As Timer
    Friend WithEvents flPanel As FlowLayoutPanel
    Friend WithEvents lblRepeatLeft As Label
    Friend WithEvents lblRepeatRight As Label
End Class
