<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalendarForm
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
        Me.usrctrlMonth = New A10.CalendarMonthControl()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.imgArrowRight = New System.Windows.Forms.PictureBox()
        Me.imgArrowLeft = New System.Windows.Forms.PictureBox()
        CType(Me.imgArrowRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArrowLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usrctrlMonth
        '
        Me.usrctrlMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.usrctrlMonth.Location = New System.Drawing.Point(44, 269)
        Me.usrctrlMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.usrctrlMonth.Name = "usrctrlMonth"
        Me.usrctrlMonth.Size = New System.Drawing.Size(390, 405)
        Me.usrctrlMonth.TabIndex = 3
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.White
        Me.lblMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMonth.Location = New System.Drawing.Point(47, 197)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(390, 45)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgArrowRight
        '
        Me.imgArrowRight.Image = Global.A10.My.Resources.Resources.ArrowRight
        Me.imgArrowRight.Location = New System.Drawing.Point(392, 197)
        Me.imgArrowRight.Name = "imgArrowRight"
        Me.imgArrowRight.Size = New System.Drawing.Size(45, 45)
        Me.imgArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArrowRight.TabIndex = 5
        Me.imgArrowRight.TabStop = False
        '
        'imgArrowLeft
        '
        Me.imgArrowLeft.Image = Global.A10.My.Resources.Resources.ArrowLeft
        Me.imgArrowLeft.Location = New System.Drawing.Point(47, 197)
        Me.imgArrowLeft.Name = "imgArrowLeft"
        Me.imgArrowLeft.Size = New System.Drawing.Size(45, 45)
        Me.imgArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArrowLeft.TabIndex = 6
        Me.imgArrowLeft.TabStop = False
        '
        'CalendarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.imgArrowLeft)
        Me.Controls.Add(Me.imgArrowRight)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.usrctrlMonth)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CalendarForm"
        Me.Text = "CalendarForm"
        CType(Me.imgArrowRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArrowLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usrctrlMonth As CalendarMonthControl
    Friend WithEvents lblMonth As Label
    Friend WithEvents imgArrowRight As PictureBox
    Friend WithEvents imgArrowLeft As PictureBox
End Class