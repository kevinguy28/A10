<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LowBatteryNotificationForm
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
        Me.pbLowBattery = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLowBattery = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        CType(Me.pbLowBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLowBattery
        '
        Me.pbLowBattery.BackColor = System.Drawing.Color.Transparent
        Me.pbLowBattery.Image = Global.A10.My.Resources.Resources.low_battery
        Me.pbLowBattery.Location = New System.Drawing.Point(141, 326)
        Me.pbLowBattery.Name = "pbLowBattery"
        Me.pbLowBattery.Size = New System.Drawing.Size(202, 109)
        Me.pbLowBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLowBattery.TabIndex = 22
        Me.pbLowBattery.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.IndianRed
        Me.btnEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEnd.Location = New System.Drawing.Point(262, 477)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(142, 87)
        Me.btnEnd.TabIndex = 21
        Me.btnEnd.Text = "End ride"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnContinue.Location = New System.Drawing.Point(80, 477)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(142, 87)
        Me.btnContinue.TabIndex = 20
        Me.btnContinue.Text = "Continue Ride"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(38, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 95)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "The car battery is running low. What would you like to do?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowBattery
        '
        Me.lblLowBattery.AutoSize = True
        Me.lblLowBattery.BackColor = System.Drawing.Color.Transparent
        Me.lblLowBattery.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLowBattery.ForeColor = System.Drawing.Color.Black
        Me.lblLowBattery.Location = New System.Drawing.Point(44, 79)
        Me.lblLowBattery.Name = "lblLowBattery"
        Me.lblLowBattery.Size = New System.Drawing.Size(385, 46)
        Me.lblLowBattery.TabIndex = 18
        Me.lblLowBattery.Text = "Car Battery Notification"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.Location = New System.Drawing.Point(153, 657)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(179, 57)
        Me.btnConfirm.TabIndex = 24
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'LowBatteryNotificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.pbLowBattery)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLowBattery)
        Me.DoubleBuffered = True
        Me.Name = "LowBatteryNotificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LowBatteryNotificationForm"
        CType(Me.pbLowBattery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLowBattery As PictureBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLowBattery As Label
    Friend WithEvents btnConfirm As Button
End Class
