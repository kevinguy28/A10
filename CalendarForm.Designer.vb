<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalendarForm
    Inherits System.Windows.Forms.Form

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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.usrctrlMonth = New A10.CalendarMonthControl()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.imgArrowRight = New System.Windows.Forms.PictureBox()
        Me.imgArrowLeft = New System.Windows.Forms.PictureBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        CType(Me.imgArrowRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArrowLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(38, 77)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 64)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Calendar"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.A10.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(202, 797)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 75)
        Me.btnHome.TabIndex = 1
        Me.btnHome.TabStop = False
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'usrctrlMonth
        '
        Me.usrctrlMonth.Location = New System.Drawing.Point(44, 269)
        Me.usrctrlMonth.Name = "usrctrlMonth"
        Me.usrctrlMonth.Size = New System.Drawing.Size(390, 405)
        Me.usrctrlMonth.TabIndex = 3
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.White
        Me.lblMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMonth.Location = New System.Drawing.Point(44, 197)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(390, 45)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgArrowRight
        '
        Me.imgArrowRight.Image = Global.A10.My.Resources.Resources.ArrowRight
        Me.imgArrowRight.Location = New System.Drawing.Point(389, 197)
        Me.imgArrowRight.Name = "imgArrowRight"
        Me.imgArrowRight.Size = New System.Drawing.Size(45, 45)
        Me.imgArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArrowRight.TabIndex = 5
        Me.imgArrowRight.TabStop = False
        '
        'imgArrowLeft
        '
        Me.imgArrowLeft.Image = Global.A10.My.Resources.Resources.ArrowLeft
        Me.imgArrowLeft.Location = New System.Drawing.Point(44, 197)
        Me.imgArrowLeft.Name = "imgArrowLeft"
        Me.imgArrowLeft.Size = New System.Drawing.Size(45, 45)
        Me.imgArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArrowLeft.TabIndex = 6
        Me.imgArrowLeft.TabStop = False
        '
        'btnPlus
        '
        Me.btnPlus.BackgroundImage = Global.A10.My.Resources.Resources.Plus
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlus.FlatAppearance.BorderSize = 0
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Location = New System.Drawing.Point(353, 694)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 75)
        Me.btnPlus.TabIndex = 8
        Me.btnPlus.TabStop = False
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'CalendarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(478, 944)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.imgArrowLeft)
        Me.Controls.Add(Me.imgArrowRight)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.usrctrlMonth)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "CalendarForm"
        Me.Text = "CalendarForm"
        CType(Me.imgArrowRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArrowLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents usrctrlMonth As CalendarMonthControl
    Friend WithEvents lblMonth As Label
    Friend WithEvents imgArrowRight As PictureBox
    Friend WithEvents imgArrowLeft As PictureBox
    Friend WithEvents btnPlus As Button
End Class
