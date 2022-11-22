<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationForm
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
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(55, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(375, 86)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.Location = New System.Drawing.Point(125, 672)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(235, 65)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription.Location = New System.Drawing.Point(62, 197)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(361, 439)
        Me.lblDescription.TabIndex = 15
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "NotificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NotificationForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblDescription As Label
End Class
