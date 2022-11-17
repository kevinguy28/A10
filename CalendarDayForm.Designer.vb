<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarDayForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.usrctrlDay = New A10.CalendarDayControl()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(38, 77)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 64)
        Me.lblTitle.TabIndex = 1
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
        Me.btnHome.TabIndex = 2
        Me.btnHome.TabStop = False
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.A10.My.Resources.Resources.ArrowBack
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(38, 809)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.TabIndex = 3
        Me.btnBack.TabStop = False
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'usrctrlDay
        '
        Me.usrctrlDay.AutoScroll = True
        Me.usrctrlDay.BackColor = System.Drawing.Color.White
        Me.usrctrlDay.Location = New System.Drawing.Point(60, 273)
        Me.usrctrlDay.Name = "usrctrlDay"
        Me.usrctrlDay.Size = New System.Drawing.Size(359, 400)
        Me.usrctrlDay.TabIndex = 4
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.White
        Me.lblDay.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDay.Location = New System.Drawing.Point(38, 197)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(390, 45)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnPlus.TabIndex = 7
        Me.btnPlus.TabStop = False
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'CalendarDayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(478, 944)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.usrctrlDay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "CalendarDayForm"
        Me.Text = "CalendarDayForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents usrctrlDay As CalendarDayControl
    Friend WithEvents lblDay As Label
    Friend WithEvents btnPlus As Button
End Class
