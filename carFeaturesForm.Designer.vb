<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarFeaturesForm
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
        Me.btnToggleWindows = New System.Windows.Forms.Button()
        Me.lblCarFeatures = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenTrunk = New System.Windows.Forms.Button()
        Me.lblInsideTemp = New System.Windows.Forms.Label()
        Me.lblInsideTempValue = New System.Windows.Forms.Label()
        Me.lblFanStrength = New System.Windows.Forms.Label()
        Me.btnFanStrengthDown = New System.Windows.Forms.Button()
        Me.btnFanStrengthUp = New System.Windows.Forms.Button()
        Me.lblFanStrengthNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAirIntakeDown = New System.Windows.Forms.Button()
        Me.btnAirIntakeUp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnToggleWindows
        '
        Me.btnToggleWindows.BackgroundImage = Global.A10.My.Resources.Resources.toggle_off
        Me.btnToggleWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnToggleWindows.Location = New System.Drawing.Point(296, 205)
        Me.btnToggleWindows.Name = "btnToggleWindows"
        Me.btnToggleWindows.Size = New System.Drawing.Size(96, 78)
        Me.btnToggleWindows.TabIndex = 0
        Me.btnToggleWindows.UseVisualStyleBackColor = True
        '
        'lblCarFeatures
        '
        Me.lblCarFeatures.AutoSize = True
        Me.lblCarFeatures.BackColor = System.Drawing.Color.White
        Me.lblCarFeatures.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarFeatures.Location = New System.Drawing.Point(93, 84)
        Me.lblCarFeatures.Name = "lblCarFeatures"
        Me.lblCarFeatures.Size = New System.Drawing.Size(299, 65)
        Me.lblCarFeatures.TabIndex = 1
        Me.lblCarFeatures.Text = "Car Features"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Open Windows"
        '
        'btnOpenTrunk
        '
        Me.btnOpenTrunk.Location = New System.Drawing.Point(134, 709)
        Me.btnOpenTrunk.Name = "btnOpenTrunk"
        Me.btnOpenTrunk.Size = New System.Drawing.Size(191, 65)
        Me.btnOpenTrunk.TabIndex = 3
        Me.btnOpenTrunk.Text = "Open Trunk"
        Me.btnOpenTrunk.UseVisualStyleBackColor = True
        '
        'lblInsideTemp
        '
        Me.lblInsideTemp.AutoSize = True
        Me.lblInsideTemp.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInsideTemp.Location = New System.Drawing.Point(67, 641)
        Me.lblInsideTemp.Name = "lblInsideTemp"
        Me.lblInsideTemp.Size = New System.Drawing.Size(231, 32)
        Me.lblInsideTemp.TabIndex = 4
        Me.lblInsideTemp.Text = "Inside Temperature: "
        '
        'lblInsideTempValue
        '
        Me.lblInsideTempValue.AutoSize = True
        Me.lblInsideTempValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInsideTempValue.Location = New System.Drawing.Point(351, 641)
        Me.lblInsideTempValue.Name = "lblInsideTempValue"
        Me.lblInsideTempValue.Size = New System.Drawing.Size(40, 32)
        Me.lblInsideTempValue.TabIndex = 5
        Me.lblInsideTempValue.Text = "12"
        '
        'lblFanStrength
        '
        Me.lblFanStrength.AutoSize = True
        Me.lblFanStrength.BackColor = System.Drawing.Color.White
        Me.lblFanStrength.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFanStrength.Location = New System.Drawing.Point(67, 337)
        Me.lblFanStrength.Name = "lblFanStrength"
        Me.lblFanStrength.Size = New System.Drawing.Size(153, 32)
        Me.lblFanStrength.TabIndex = 6
        Me.lblFanStrength.Text = "Fan Strength"
        '
        'btnFanStrengthDown
        '
        Me.btnFanStrengthDown.BackgroundImage = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.btnFanStrengthDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFanStrengthDown.Location = New System.Drawing.Point(296, 337)
        Me.btnFanStrengthDown.Name = "btnFanStrengthDown"
        Me.btnFanStrengthDown.Size = New System.Drawing.Size(50, 50)
        Me.btnFanStrengthDown.TabIndex = 7
        Me.btnFanStrengthDown.UseVisualStyleBackColor = True
        '
        'btnFanStrengthUp
        '
        Me.btnFanStrengthUp.BackgroundImage = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.btnFanStrengthUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFanStrengthUp.Location = New System.Drawing.Point(390, 337)
        Me.btnFanStrengthUp.Name = "btnFanStrengthUp"
        Me.btnFanStrengthUp.Size = New System.Drawing.Size(50, 50)
        Me.btnFanStrengthUp.TabIndex = 8
        Me.btnFanStrengthUp.UseVisualStyleBackColor = True
        '
        'lblFanStrengthNumber
        '
        Me.lblFanStrengthNumber.AutoSize = True
        Me.lblFanStrengthNumber.BackColor = System.Drawing.Color.White
        Me.lblFanStrengthNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFanStrengthNumber.Location = New System.Drawing.Point(352, 341)
        Me.lblFanStrengthNumber.Name = "lblFanStrengthNumber"
        Me.lblFanStrengthNumber.Size = New System.Drawing.Size(24, 32)
        Me.lblFanStrengthNumber.TabIndex = 9
        Me.lblFanStrengthNumber.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(67, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Air Intake"
        '
        'btnAirIntakeDown
        '
        Me.btnAirIntakeDown.BackgroundImage = Global.A10.My.Resources.Resources.arrow_down_neutral
        Me.btnAirIntakeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAirIntakeDown.Location = New System.Drawing.Point(296, 432)
        Me.btnAirIntakeDown.Name = "btnAirIntakeDown"
        Me.btnAirIntakeDown.Size = New System.Drawing.Size(50, 50)
        Me.btnAirIntakeDown.TabIndex = 11
        Me.btnAirIntakeDown.Text = "Button1"
        Me.btnAirIntakeDown.UseVisualStyleBackColor = True
        '
        'btnAirIntakeUp
        '
        Me.btnAirIntakeUp.BackgroundImage = Global.A10.My.Resources.Resources.arrow_up_neutral
        Me.btnAirIntakeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAirIntakeUp.Location = New System.Drawing.Point(390, 432)
        Me.btnAirIntakeUp.Name = "btnAirIntakeUp"
        Me.btnAirIntakeUp.Size = New System.Drawing.Size(50, 50)
        Me.btnAirIntakeUp.TabIndex = 12
        Me.btnAirIntakeUp.Text = "Button2"
        Me.btnAirIntakeUp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(352, 436)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "1"
        '
        'CarFeaturesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.Label3)
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
        Me.Controls.Add(Me.lblCarFeatures)
        Me.Controls.Add(Me.btnToggleWindows)
        Me.DoubleBuffered = True
        Me.Name = "CarFeaturesForm"
        Me.Text = "carFeaturesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToggleWindows As Button
    Friend WithEvents lblCarFeatures As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenTrunk As Button
    Friend WithEvents lblInsideTemp As Label
    Friend WithEvents lblInsideTempValue As Label
    Friend WithEvents lblFanStrength As Label
    Friend WithEvents btnFanStrengthDown As Button
    Friend WithEvents btnFanStrengthUp As Button
    Friend WithEvents lblFanStrengthNumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAirIntakeDown As Button
    Friend WithEvents btnAirIntakeUp As Button
    Friend WithEvents Label3 As Label
End Class
