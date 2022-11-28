<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarFeatureForm
    'Inherits System.Windows.Forms.Form
    Inherits AppForm
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
        Me.lblAirIntakeNumber = New System.Windows.Forms.Label()
        Me.btnAirIntakeUp = New System.Windows.Forms.Button()
        Me.btnAirIntakeDown = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFanStrengthNumber = New System.Windows.Forms.Label()
        Me.btnFanStrengthUp = New System.Windows.Forms.Button()
        Me.btnFanStrengthDown = New System.Windows.Forms.Button()
        Me.lblFanStrength = New System.Windows.Forms.Label()
        Me.lblInsideTempValue = New System.Windows.Forms.Label()
        Me.lblInsideTemp = New System.Windows.Forms.Label()
        Me.btnOpenTrunk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnToggleWindows = New System.Windows.Forms.Button()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.pbCar = New System.Windows.Forms.PictureBox()
        CType(Me.pbCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAirIntakeNumber
        '
        Me.lblAirIntakeNumber.AutoSize = True
        Me.lblAirIntakeNumber.BackColor = System.Drawing.Color.White
        Me.lblAirIntakeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAirIntakeNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAirIntakeNumber.Location = New System.Drawing.Point(325, 352)
        Me.lblAirIntakeNumber.Name = "lblAirIntakeNumber"
        Me.lblAirIntakeNumber.Size = New System.Drawing.Size(32, 43)
        Me.lblAirIntakeNumber.TabIndex = 28
        Me.lblAirIntakeNumber.Tag = "1"
        Me.lblAirIntakeNumber.Text = "1"
        '
        'btnAirIntakeUp
        '
        Me.btnAirIntakeUp.BackColor = System.Drawing.Color.White
        Me.btnAirIntakeUp.BackgroundImage = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.btnAirIntakeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAirIntakeUp.FlatAppearance.BorderSize = 0
        Me.btnAirIntakeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAirIntakeUp.Location = New System.Drawing.Point(375, 348)
        Me.btnAirIntakeUp.Name = "btnAirIntakeUp"
        Me.btnAirIntakeUp.Size = New System.Drawing.Size(50, 50)
        Me.btnAirIntakeUp.TabIndex = 27
        Me.btnAirIntakeUp.TabStop = False
        Me.btnAirIntakeUp.UseVisualStyleBackColor = False
        '
        'btnAirIntakeDown
        '
        Me.btnAirIntakeDown.BackColor = System.Drawing.Color.White
        Me.btnAirIntakeDown.BackgroundImage = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.btnAirIntakeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAirIntakeDown.FlatAppearance.BorderSize = 0
        Me.btnAirIntakeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAirIntakeDown.Location = New System.Drawing.Point(259, 348)
        Me.btnAirIntakeDown.Name = "btnAirIntakeDown"
        Me.btnAirIntakeDown.Size = New System.Drawing.Size(50, 50)
        Me.btnAirIntakeDown.TabIndex = 26
        Me.btnAirIntakeDown.TabStop = False
        Me.btnAirIntakeDown.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(60, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Air Intake"
        '
        'lblFanStrengthNumber
        '
        Me.lblFanStrengthNumber.AutoSize = True
        Me.lblFanStrengthNumber.BackColor = System.Drawing.Color.White
        Me.lblFanStrengthNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFanStrengthNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFanStrengthNumber.Location = New System.Drawing.Point(326, 256)
        Me.lblFanStrengthNumber.Name = "lblFanStrengthNumber"
        Me.lblFanStrengthNumber.Size = New System.Drawing.Size(32, 43)
        Me.lblFanStrengthNumber.TabIndex = 24
        Me.lblFanStrengthNumber.Tag = "1"
        Me.lblFanStrengthNumber.Text = "1"
        '
        'btnFanStrengthUp
        '
        Me.btnFanStrengthUp.BackColor = System.Drawing.Color.White
        Me.btnFanStrengthUp.BackgroundImage = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.btnFanStrengthUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFanStrengthUp.FlatAppearance.BorderSize = 0
        Me.btnFanStrengthUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFanStrengthUp.Location = New System.Drawing.Point(373, 253)
        Me.btnFanStrengthUp.Name = "btnFanStrengthUp"
        Me.btnFanStrengthUp.Size = New System.Drawing.Size(50, 50)
        Me.btnFanStrengthUp.TabIndex = 23
        Me.btnFanStrengthUp.TabStop = False
        Me.btnFanStrengthUp.UseVisualStyleBackColor = False
        '
        'btnFanStrengthDown
        '
        Me.btnFanStrengthDown.BackColor = System.Drawing.Color.White
        Me.btnFanStrengthDown.BackgroundImage = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.btnFanStrengthDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFanStrengthDown.FlatAppearance.BorderSize = 0
        Me.btnFanStrengthDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFanStrengthDown.Location = New System.Drawing.Point(260, 253)
        Me.btnFanStrengthDown.Name = "btnFanStrengthDown"
        Me.btnFanStrengthDown.Size = New System.Drawing.Size(50, 50)
        Me.btnFanStrengthDown.TabIndex = 22
        Me.btnFanStrengthDown.TabStop = False
        Me.btnFanStrengthDown.UseVisualStyleBackColor = False
        '
        'lblFanStrength
        '
        Me.lblFanStrength.AutoSize = True
        Me.lblFanStrength.BackColor = System.Drawing.Color.White
        Me.lblFanStrength.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFanStrength.Location = New System.Drawing.Point(61, 253)
        Me.lblFanStrength.Name = "lblFanStrength"
        Me.lblFanStrength.Size = New System.Drawing.Size(153, 32)
        Me.lblFanStrength.TabIndex = 21
        Me.lblFanStrength.Text = "Fan Strength"
        '
        'lblInsideTempValue
        '
        Me.lblInsideTempValue.AutoSize = True
        Me.lblInsideTempValue.BackColor = System.Drawing.Color.White
        Me.lblInsideTempValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInsideTempValue.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInsideTempValue.Location = New System.Drawing.Point(325, 414)
        Me.lblInsideTempValue.Name = "lblInsideTempValue"
        Me.lblInsideTempValue.Size = New System.Drawing.Size(49, 43)
        Me.lblInsideTempValue.TabIndex = 20
        Me.lblInsideTempValue.Text = "12"
        '
        'lblInsideTemp
        '
        Me.lblInsideTemp.AutoSize = True
        Me.lblInsideTemp.BackColor = System.Drawing.Color.White
        Me.lblInsideTemp.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInsideTemp.Location = New System.Drawing.Point(61, 420)
        Me.lblInsideTemp.Name = "lblInsideTemp"
        Me.lblInsideTemp.Size = New System.Drawing.Size(237, 32)
        Me.lblInsideTemp.TabIndex = 19
        Me.lblInsideTemp.Text = "Inside Temperature: "
        '
        'btnOpenTrunk
        '
        Me.btnOpenTrunk.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenTrunk.Location = New System.Drawing.Point(61, 471)
        Me.btnOpenTrunk.Name = "btnOpenTrunk"
        Me.btnOpenTrunk.Size = New System.Drawing.Size(222, 65)
        Me.btnOpenTrunk.TabIndex = 18
        Me.btnOpenTrunk.Text = "Open Trunk"
        Me.btnOpenTrunk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(61, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Open Windows"
        '
        'btnToggleWindows
        '
        Me.btnToggleWindows.BackColor = System.Drawing.Color.White
        Me.btnToggleWindows.BackgroundImage = Global.A10.My.Resources.Resources.toggle_off
        Me.btnToggleWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnToggleWindows.FlatAppearance.BorderSize = 0
        Me.btnToggleWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleWindows.Location = New System.Drawing.Point(311, 176)
        Me.btnToggleWindows.Name = "btnToggleWindows"
        Me.btnToggleWindows.Size = New System.Drawing.Size(96, 78)
        Me.btnToggleWindows.TabIndex = 15
        Me.btnToggleWindows.TabStop = False
        Me.btnToggleWindows.UseVisualStyleBackColor = True
        '
        'tmrUpdate
        '
        '
        'btnCamera
        '
        Me.btnCamera.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCamera.Location = New System.Drawing.Point(60, 560)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(222, 65)
        Me.btnCamera.TabIndex = 29
        Me.btnCamera.Text = "View Cameras"
        Me.btnCamera.UseVisualStyleBackColor = True
        '
        'pbCar
        '
        Me.pbCar.Image = Global.A10.My.Resources.Resources.trunk_close
        Me.pbCar.Location = New System.Drawing.Point(302, 460)
        Me.pbCar.Name = "pbCar"
        Me.pbCar.Size = New System.Drawing.Size(145, 78)
        Me.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbCar.TabIndex = 30
        Me.pbCar.TabStop = False
        '
        'CarFeatureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.pbCar)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.lblAirIntakeNumber)
        Me.Controls.Add(Me.btnAirIntakeUp)
        Me.Controls.Add(Me.btnAirIntakeDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFanStrengthNumber)
        Me.Controls.Add(Me.btnFanStrengthUp)
        Me.Controls.Add(Me.btnFanStrengthDown)
        Me.Controls.Add(Me.lblFanStrength)
        Me.Controls.Add(Me.lblInsideTempValue)
        Me.Controls.Add(Me.lblInsideTemp)
        Me.Controls.Add(Me.btnOpenTrunk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnToggleWindows)
        Me.DoubleBuffered = True
        Me.Name = "CarFeatureForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "w"
        CType(Me.pbCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAirIntakeNumber As Label
    Friend WithEvents btnAirIntakeUp As Button
    Friend WithEvents btnAirIntakeDown As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFanStrengthNumber As Label
    Friend WithEvents btnFanStrengthUp As Button
    Friend WithEvents btnFanStrengthDown As Button
    Friend WithEvents lblFanStrength As Label
    Friend WithEvents lblInsideTempValue As Label
    Friend WithEvents lblInsideTemp As Label
    Friend WithEvents btnOpenTrunk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToggleWindows As Button
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents btnCamera As Button
    Friend WithEvents pbCar As PictureBox
End Class
