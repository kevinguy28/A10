<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmergencyForm
    'Inherits System.Windows.Forms.Form
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
        Me.lblDiagnostic = New System.Windows.Forms.Label()
        Me.lblCarMedia = New System.Windows.Forms.Label()
        Me.lblAccident = New System.Windows.Forms.Label()
        Me.btnTechProblem = New System.Windows.Forms.Button()
        Me.btnIntrusion = New System.Windows.Forms.Button()
        Me.btnAccident = New System.Windows.Forms.Button()
        Me.lblStop_Expel = New System.Windows.Forms.Label()
        Me.btnStop_Expel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDiagnostic
        '
        Me.lblDiagnostic.BackColor = System.Drawing.Color.White
        Me.lblDiagnostic.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDiagnostic.Location = New System.Drawing.Point(60, 492)
        Me.lblDiagnostic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiagnostic.Name = "lblDiagnostic"
        Me.lblDiagnostic.Size = New System.Drawing.Size(188, 38)
        Me.lblDiagnostic.TabIndex = 31
        Me.lblDiagnostic.Text = "Tech Problem"
        Me.lblDiagnostic.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCarMedia
        '
        Me.lblCarMedia.BackColor = System.Drawing.Color.White
        Me.lblCarMedia.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCarMedia.Location = New System.Drawing.Point(260, 277)
        Me.lblCarMedia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarMedia.Name = "lblCarMedia"
        Me.lblCarMedia.Size = New System.Drawing.Size(150, 38)
        Me.lblCarMedia.TabIndex = 30
        Me.lblCarMedia.Text = "Intrusion"
        Me.lblCarMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAccident
        '
        Me.lblAccident.BackColor = System.Drawing.Color.White
        Me.lblAccident.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccident.Location = New System.Drawing.Point(74, 277)
        Me.lblAccident.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccident.Name = "lblAccident"
        Me.lblAccident.Size = New System.Drawing.Size(150, 38)
        Me.lblAccident.TabIndex = 29
        Me.lblAccident.Text = "Accident"
        Me.lblAccident.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTechProblem
        '
        Me.btnTechProblem.BackColor = System.Drawing.Color.White
        Me.btnTechProblem.BackgroundImage = Global.A10.My.Resources.Resources.techproblem_neutral
        Me.btnTechProblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTechProblem.FlatAppearance.BorderSize = 0
        Me.btnTechProblem.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnTechProblem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTechProblem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTechProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTechProblem.Location = New System.Drawing.Point(74, 533)
        Me.btnTechProblem.Name = "btnTechProblem"
        Me.btnTechProblem.Size = New System.Drawing.Size(150, 150)
        Me.btnTechProblem.TabIndex = 28
        Me.btnTechProblem.TabStop = False
        Me.btnTechProblem.UseVisualStyleBackColor = True
        '
        'btnIntrusion
        '
        Me.btnIntrusion.BackColor = System.Drawing.Color.White
        Me.btnIntrusion.BackgroundImage = Global.A10.My.Resources.Resources.intrusion_neutral
        Me.btnIntrusion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIntrusion.FlatAppearance.BorderSize = 0
        Me.btnIntrusion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnIntrusion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnIntrusion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnIntrusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntrusion.Location = New System.Drawing.Point(260, 317)
        Me.btnIntrusion.Name = "btnIntrusion"
        Me.btnIntrusion.Size = New System.Drawing.Size(150, 150)
        Me.btnIntrusion.TabIndex = 27
        Me.btnIntrusion.TabStop = False
        Me.btnIntrusion.UseVisualStyleBackColor = True
        '
        'btnAccident
        '
        Me.btnAccident.BackColor = System.Drawing.Color.White
        Me.btnAccident.BackgroundImage = Global.A10.My.Resources.Resources.accident_neutral
        Me.btnAccident.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAccident.FlatAppearance.BorderSize = 0
        Me.btnAccident.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAccident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAccident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAccident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccident.Location = New System.Drawing.Point(74, 317)
        Me.btnAccident.Name = "btnAccident"
        Me.btnAccident.Size = New System.Drawing.Size(150, 150)
        Me.btnAccident.TabIndex = 26
        Me.btnAccident.TabStop = False
        Me.btnAccident.UseVisualStyleBackColor = True
        '
        'lblStop_Expel
        '
        Me.lblStop_Expel.BackColor = System.Drawing.Color.White
        Me.lblStop_Expel.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStop_Expel.Location = New System.Drawing.Point(252, 492)
        Me.lblStop_Expel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStop_Expel.Name = "lblStop_Expel"
        Me.lblStop_Expel.Size = New System.Drawing.Size(179, 38)
        Me.lblStop_Expel.TabIndex = 33
        Me.lblStop_Expel.Text = "Request Stop"
        Me.lblStop_Expel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnStop_Expel
        '
        Me.btnStop_Expel.BackColor = System.Drawing.Color.White
        Me.btnStop_Expel.BackgroundImage = Global.A10.My.Resources.Resources.expelrider_neutral
        Me.btnStop_Expel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStop_Expel.FlatAppearance.BorderSize = 0
        Me.btnStop_Expel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnStop_Expel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnStop_Expel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnStop_Expel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop_Expel.Location = New System.Drawing.Point(260, 533)
        Me.btnStop_Expel.Name = "btnStop_Expel"
        Me.btnStop_Expel.Size = New System.Drawing.Size(150, 150)
        Me.btnStop_Expel.TabIndex = 32
        Me.btnStop_Expel.TabStop = False
        Me.btnStop_Expel.UseVisualStyleBackColor = True
        '
        'EmergencyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.lblStop_Expel)
        Me.Controls.Add(Me.btnStop_Expel)
        Me.Controls.Add(Me.lblDiagnostic)
        Me.Controls.Add(Me.lblCarMedia)
        Me.Controls.Add(Me.lblAccident)
        Me.Controls.Add(Me.btnTechProblem)
        Me.Controls.Add(Me.btnIntrusion)
        Me.Controls.Add(Me.btnAccident)
        Me.DoubleBuffered = True
        Me.Name = "EmergencyForm"
        Me.Text = "EmergencyForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDiagnostic As Label
    Friend WithEvents lblCarMedia As Label
    Friend WithEvents lblAccident As Label
    Friend WithEvents btnTechProblem As Button
    Friend WithEvents btnIntrusion As Button
    Friend WithEvents btnAccident As Button
    Friend WithEvents lblStop_Expel As Label
    Friend WithEvents btnStop_Expel As Button
End Class
