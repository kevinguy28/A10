<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalendarBookingControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.flPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblStartRight = New System.Windows.Forms.Label()
        Me.lblStartLeft = New System.Windows.Forms.Label()
        Me.tmrMouseHold = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'flPanel
        '
        Me.flPanel.Location = New System.Drawing.Point(310, 0)
        Me.flPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.flPanel.Name = "flPanel"
        Me.flPanel.Size = New System.Drawing.Size(100, 100)
        Me.flPanel.TabIndex = 7
        '
        'lblStartRight
        '
        Me.lblStartRight.BackColor = System.Drawing.Color.DarkGray
        Me.lblStartRight.Location = New System.Drawing.Point(15, 3)
        Me.lblStartRight.Name = "lblStartRight"
        Me.lblStartRight.Size = New System.Drawing.Size(5, 50)
        Me.lblStartRight.TabIndex = 1
        '
        'lblStartLeft
        '
        Me.lblStartLeft.BackColor = System.Drawing.Color.DarkGray
        Me.lblStartLeft.Location = New System.Drawing.Point(3, 3)
        Me.lblStartLeft.Name = "lblStartLeft"
        Me.lblStartLeft.Size = New System.Drawing.Size(5, 50)
        Me.lblStartLeft.TabIndex = 0
        '
        'tmrMouseHold
        '
        Me.tmrMouseHold.Interval = 10
        '
        'CalendarBookingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblStartRight)
        Me.Controls.Add(Me.lblStartLeft)
        Me.Controls.Add(Me.flPanel)
        Me.Name = "CalendarBookingControl"
        Me.Size = New System.Drawing.Size(410, 632)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flPanel As FlowLayoutPanel
    Friend WithEvents lblStartLeft As Label
    Friend WithEvents lblStartRight As Label
    Friend WithEvents tmrMouseHold As Timer
End Class
