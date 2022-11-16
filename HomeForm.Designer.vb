<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.btnChat = New System.Windows.Forms.Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.A10.My.Resources.Resources.kuber
        Me.imgLogo.Location = New System.Drawing.Point(164, 63)
        Me.imgLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(150, 100)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 9
        Me.imgLogo.TabStop = False
        '
        'btnCalendar
        '
        Me.btnCalendar.BackgroundImage = Global.A10.My.Resources.Resources.Calendar
        Me.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalendar.FlatAppearance.BorderSize = 0
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.Location = New System.Drawing.Point(71, 239)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(150, 150)
        Me.btnCalendar.TabIndex = 10
        Me.btnCalendar.UseVisualStyleBackColor = True
        '
        'btnCar
        '
        Me.btnCar.BackgroundImage = Global.A10.My.Resources.Resources.Car
        Me.btnCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCar.FlatAppearance.BorderSize = 0
        Me.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCar.Location = New System.Drawing.Point(257, 239)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(150, 150)
        Me.btnCar.TabIndex = 11
        Me.btnCar.UseVisualStyleBackColor = True
        '
        'btnMap
        '
        Me.btnMap.BackgroundImage = Global.A10.My.Resources.Resources.Map
        Me.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMap.FlatAppearance.BorderSize = 0
        Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMap.Location = New System.Drawing.Point(71, 425)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(150, 150)
        Me.btnMap.TabIndex = 12
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'btnChat
        '
        Me.btnChat.BackgroundImage = Global.A10.My.Resources.Resources.chat
        Me.btnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Location = New System.Drawing.Point(257, 425)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(150, 150)
        Me.btnChat.TabIndex = 13
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(478, 944)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnMap)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.btnCalendar)
        Me.Controls.Add(Me.imgLogo)
        Me.DoubleBuffered = True
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnCar As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents btnChat As Button
End Class
