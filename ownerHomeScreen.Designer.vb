<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ownerHomeScreen
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
        Me.currentRideLabel = New System.Windows.Forms.Label()
        Me.currentRidePicBox = New System.Windows.Forms.PictureBox()
        Me.myCarLabel = New System.Windows.Forms.Label()
        Me.scheduleLabel = New System.Windows.Forms.Label()
        Me.myCarPicBox = New System.Windows.Forms.PictureBox()
        Me.schedulePicBox = New System.Windows.Forms.PictureBox()
        Me.kuberLogo = New System.Windows.Forms.PictureBox()
        Me.batteryPicBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chatPicBox = New System.Windows.Forms.PictureBox()
        Me.chatLabel = New System.Windows.Forms.Label()
        Me.tmrAccident = New System.Windows.Forms.Timer(Me.components)
        CType(Me.currentRidePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myCarPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kuberLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batteryPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chatPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentRideLabel
        '
        Me.currentRideLabel.AutoSize = True
        Me.currentRideLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.currentRideLabel.Location = New System.Drawing.Point(77, 252)
        Me.currentRideLabel.Name = "currentRideLabel"
        Me.currentRideLabel.Size = New System.Drawing.Size(103, 13)
        Me.currentRideLabel.TabIndex = 14
        Me.currentRideLabel.Text = "Current Ride"
        '
        'currentRidePicBox
        '
        Me.currentRidePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentRidePicBox.Image = Global.A10.My.Resources.Resources.path
        Me.currentRidePicBox.Location = New System.Drawing.Point(77, 269)
        Me.currentRidePicBox.Name = "currentRidePicBox"
        Me.currentRidePicBox.Size = New System.Drawing.Size(84, 90)
        Me.currentRidePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.currentRidePicBox.TabIndex = 13
        Me.currentRidePicBox.TabStop = False
        '
        'myCarLabel
        '
        Me.myCarLabel.AutoSize = True
        Me.myCarLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.myCarLabel.Location = New System.Drawing.Point(208, 127)
        Me.myCarLabel.Name = "myCarLabel"
        Me.myCarLabel.Size = New System.Drawing.Size(55, 13)
        Me.myCarLabel.TabIndex = 12
        Me.myCarLabel.Text = "My Car"
        '
        'scheduleLabel
        '
        Me.scheduleLabel.AutoSize = True
        Me.scheduleLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.scheduleLabel.Location = New System.Drawing.Point(77, 127)
        Me.scheduleLabel.Name = "scheduleLabel"
        Me.scheduleLabel.Size = New System.Drawing.Size(71, 13)
        Me.scheduleLabel.TabIndex = 11
        Me.scheduleLabel.Text = "Schedule"
        '
        'myCarPicBox
        '
        Me.myCarPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myCarPicBox.Image = Global.A10.My.Resources.Resources.car1
        Me.myCarPicBox.Location = New System.Drawing.Point(208, 143)
        Me.myCarPicBox.Name = "myCarPicBox"
        Me.myCarPicBox.Size = New System.Drawing.Size(84, 90)
        Me.myCarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.myCarPicBox.TabIndex = 10
        Me.myCarPicBox.TabStop = False
        '
        'schedulePicBox
        '
        Me.schedulePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.schedulePicBox.Image = Global.A10.My.Resources.Resources.Calender
        Me.schedulePicBox.Location = New System.Drawing.Point(77, 143)
        Me.schedulePicBox.Name = "schedulePicBox"
        Me.schedulePicBox.Size = New System.Drawing.Size(84, 90)
        Me.schedulePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.schedulePicBox.TabIndex = 9
        Me.schedulePicBox.TabStop = False
        '
        'kuberLogo
        '
        Me.kuberLogo.Image = Global.A10.My.Resources.Resources.kuber
        Me.kuberLogo.Location = New System.Drawing.Point(134, 54)
        Me.kuberLogo.Name = "kuberLogo"
        Me.kuberLogo.Size = New System.Drawing.Size(100, 50)
        Me.kuberLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.kuberLogo.TabIndex = 8
        Me.kuberLogo.TabStop = False
        '
        'batteryPicBox
        '
        Me.batteryPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.batteryPicBox.Image = Global.A10.My.Resources.Resources.battery
        Me.batteryPicBox.Location = New System.Drawing.Point(77, 391)
        Me.batteryPicBox.Name = "batteryPicBox"
        Me.batteryPicBox.Size = New System.Drawing.Size(84, 90)
        Me.batteryPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.batteryPicBox.TabIndex = 23
        Me.batteryPicBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(77, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Car Battery"
        '
        'chatPicBox
        '
        Me.chatPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chatPicBox.Image = Global.A10.My.Resources.Resources.chat
        Me.chatPicBox.Location = New System.Drawing.Point(208, 269)
        Me.chatPicBox.Name = "chatPicBox"
        Me.chatPicBox.Size = New System.Drawing.Size(84, 90)
        Me.chatPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.chatPicBox.TabIndex = 25
        Me.chatPicBox.TabStop = False
        '
        'chatLabel
        '
        Me.chatLabel.AutoSize = True
        Me.chatLabel.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chatLabel.Location = New System.Drawing.Point(212, 253)
        Me.chatLabel.Name = "chatLabel"
        Me.chatLabel.Size = New System.Drawing.Size(39, 13)
        Me.chatLabel.TabIndex = 26
        Me.chatLabel.Text = "Chat"
        '
        'ownerHomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.phone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(369, 629)
        Me.Controls.Add(Me.chatLabel)
        Me.Controls.Add(Me.chatPicBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.batteryPicBox)
        Me.Controls.Add(Me.currentRideLabel)
        Me.Controls.Add(Me.currentRidePicBox)
        Me.Controls.Add(Me.myCarLabel)
        Me.Controls.Add(Me.scheduleLabel)
        Me.Controls.Add(Me.myCarPicBox)
        Me.Controls.Add(Me.schedulePicBox)
        Me.Controls.Add(Me.kuberLogo)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "ownerHomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Home Screen (Owner)"
        CType(Me.currentRidePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myCarPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kuberLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batteryPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chatPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents currentRideLabel As Label
    Friend WithEvents currentRidePicBox As PictureBox
    Friend WithEvents myCarLabel As Label
    Friend WithEvents scheduleLabel As Label
    Friend WithEvents myCarPicBox As PictureBox
    Friend WithEvents schedulePicBox As PictureBox
    Friend WithEvents kuberLogo As PictureBox
    Friend WithEvents batteryPicBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chatPicBox As PictureBox
    Friend WithEvents chatLabel As Label
    Friend WithEvents tmrAccident As Timer
End Class
