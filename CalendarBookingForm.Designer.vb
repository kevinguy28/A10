﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarBookingForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.usrctrlBooking = New A10.CalendarBookingControl()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(41, 77)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 65)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Booking"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'usrctrlBooking
        '
        Me.usrctrlBooking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usrctrlBooking.AutoScroll = True
        Me.usrctrlBooking.BackColor = System.Drawing.Color.White
        Me.usrctrlBooking.Location = New System.Drawing.Point(24, 172)
        Me.usrctrlBooking.MaximumSize = New System.Drawing.Size(410, 632)
        Me.usrctrlBooking.MinimumSize = New System.Drawing.Size(435, 632)
        Me.usrctrlBooking.Name = "usrctrlBooking"
        Me.usrctrlBooking.Size = New System.Drawing.Size(435, 632)
        Me.usrctrlBooking.TabIndex = 5
        '
        'CalendarBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A10.My.Resources.Resources.Phone___Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 961)
        Me.Controls.Add(Me.usrctrlBooking)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "CalendarBookingForm"
        Me.Text = "CalendarBookingForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents usrctrlBooking As CalendarBookingControl
End Class