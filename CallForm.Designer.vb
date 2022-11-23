<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallForm
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
        Me.components = New System.ComponentModel.Container()
        Me.imgEndCall = New System.Windows.Forms.PictureBox()
        Me.imgNoCall = New System.Windows.Forms.PictureBox()
        Me.imgCall = New System.Windows.Forms.PictureBox()
        Me.tmrCall = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.cmbxCompany = New System.Windows.Forms.ComboBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.imgEndCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNoCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgEndCall
        '
        Me.imgEndCall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgEndCall.BackColor = System.Drawing.Color.Transparent
        Me.imgEndCall.Image = Global.A10.My.Resources.Resources.endCall
        Me.imgEndCall.Location = New System.Drawing.Point(161, 298)
        Me.imgEndCall.Name = "imgEndCall"
        Me.imgEndCall.Size = New System.Drawing.Size(73, 84)
        Me.imgEndCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgEndCall.TabIndex = 20
        Me.imgEndCall.TabStop = False
        Me.imgEndCall.Visible = False
        '
        'imgNoCall
        '
        Me.imgNoCall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgNoCall.BackColor = System.Drawing.Color.Transparent
        Me.imgNoCall.Image = Global.A10.My.Resources.Resources.nocall
        Me.imgNoCall.Location = New System.Drawing.Point(309, 298)
        Me.imgNoCall.Name = "imgNoCall"
        Me.imgNoCall.Size = New System.Drawing.Size(73, 84)
        Me.imgNoCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNoCall.TabIndex = 19
        Me.imgNoCall.TabStop = False
        '
        'imgCall
        '
        Me.imgCall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgCall.BackColor = System.Drawing.Color.Transparent
        Me.imgCall.Enabled = False
        Me.imgCall.Image = Global.A10.My.Resources.Resources._call
        Me.imgCall.Location = New System.Drawing.Point(12, 298)
        Me.imgCall.Name = "imgCall"
        Me.imgCall.Size = New System.Drawing.Size(73, 84)
        Me.imgCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCall.TabIndex = 18
        Me.imgCall.TabStop = False
        '
        'tmrCall
        '
        Me.tmrCall.Interval = 1000
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(9, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(376, 47)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "Call For A Tow"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(9, 56)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(376, 30)
        Me.lblPrompt.TabIndex = 23
        Me.lblPrompt.Text = "Choose a company to call:"
        '
        'cmbxCompany
        '
        Me.cmbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCompany.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbxCompany.FormattingEnabled = True
        Me.cmbxCompany.Items.AddRange(New Object() {"Towing Toronto", "GPA Tow Truck", "PK Towing", "Yak Towing"})
        Me.cmbxCompany.Location = New System.Drawing.Point(12, 89)
        Me.cmbxCompany.Name = "cmbxCompany"
        Me.cmbxCompany.Size = New System.Drawing.Size(373, 33)
        Me.cmbxCompany.TabIndex = 24
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMessage.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblMessage.Location = New System.Drawing.Point(112, 134)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(270, 153)
        Me.lblMessage.TabIndex = 26
        Me.lblMessage.Text = "lblMessage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblName.Location = New System.Drawing.Point(12, 134)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 153)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "John Smith:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CallForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(394, 394)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cmbxCompany)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.imgEndCall)
        Me.Controls.Add(Me.imgNoCall)
        Me.Controls.Add(Me.imgCall)
        Me.DoubleBuffered = True
        Me.Name = "CallForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CallForm"
        CType(Me.imgEndCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNoCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgEndCall As PictureBox
    Friend WithEvents imgNoCall As PictureBox
    Friend WithEvents imgCall As PictureBox
    Friend WithEvents tmrCall As Timer
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents cmbxCompany As ComboBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblName As Label
End Class
