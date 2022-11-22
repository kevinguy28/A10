<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmergencyContactForm
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
        Me.components = New System.ComponentModel.Container()
        Me.imgEndCall = New System.Windows.Forms.PictureBox()
        Me.imgNoCall = New System.Windows.Forms.PictureBox()
        Me.imgCall = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.tmrCall = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgEndCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNoCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgEndCall
        '
        Me.imgEndCall.Image = Global.A10.My.Resources.Resources.endCall
        Me.imgEndCall.Location = New System.Drawing.Point(161, 215)
        Me.imgEndCall.Name = "imgEndCall"
        Me.imgEndCall.Size = New System.Drawing.Size(73, 84)
        Me.imgEndCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgEndCall.TabIndex = 17
        Me.imgEndCall.TabStop = False
        Me.imgEndCall.Visible = False
        '
        'imgNoCall
        '
        Me.imgNoCall.Image = Global.A10.My.Resources.Resources.nocall
        Me.imgNoCall.Location = New System.Drawing.Point(309, 215)
        Me.imgNoCall.Name = "imgNoCall"
        Me.imgNoCall.Size = New System.Drawing.Size(73, 84)
        Me.imgNoCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNoCall.TabIndex = 16
        Me.imgNoCall.TabStop = False
        '
        'imgCall
        '
        Me.imgCall.Image = Global.A10.My.Resources.Resources._call
        Me.imgCall.Location = New System.Drawing.Point(12, 215)
        Me.imgCall.Name = "imgCall"
        Me.imgCall.Size = New System.Drawing.Size(73, 84)
        Me.imgCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCall.TabIndex = 15
        Me.imgCall.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblName.Location = New System.Drawing.Point(12, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 153)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "John Smith:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(1, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(392, 47)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Call Emergency Services?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMessage.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMessage.Location = New System.Drawing.Point(112, 56)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(270, 153)
        Me.lblMessage.TabIndex = 18
        Me.lblMessage.Text = "lblMessage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5"
        '
        'tmrCall
        '
        Me.tmrCall.Interval = 1000
        '
        'EmergencyContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(394, 311)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.imgEndCall)
        Me.Controls.Add(Me.imgNoCall)
        Me.Controls.Add(Me.imgCall)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "EmergencyContactForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "EmergencyContactForm"
        CType(Me.imgEndCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNoCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgEndCall As PictureBox
    Friend WithEvents imgNoCall As PictureBox
    Friend WithEvents imgCall As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents tmrCall As Timer
End Class
