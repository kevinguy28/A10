<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatForm
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
        Me.components = New System.ComponentModel.Container()
        Me.txtChatMessage = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tmrCheckChat = New System.Windows.Forms.Timer(Me.components)
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblChat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtChatMessage
        '
        Me.txtChatMessage.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtChatMessage.Location = New System.Drawing.Point(39, 724)
        Me.txtChatMessage.Name = "txtChatMessage"
        Me.txtChatMessage.Size = New System.Drawing.Size(407, 32)
        Me.txtChatMessage.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.Location = New System.Drawing.Point(166, 762)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(152, 35)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tmrCheckChat
        '
        '
        'imgList
        '
        Me.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgList.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblChat
        '
        Me.lblChat.BackColor = System.Drawing.Color.White
        Me.lblChat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChat.Location = New System.Drawing.Point(39, 190)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Size = New System.Drawing.Size(407, 531)
        Me.lblChat.TabIndex = 3
        Me.lblChat.Text = "Label1"
        '
        'ChatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblChat)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtChatMessage)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChatForm"
        Me.Text = "ChatForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChatMessage As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents tmrCheckChat As Timer
    Friend WithEvents imgList As ImageList
    Friend WithEvents lblChat As Label
End Class
