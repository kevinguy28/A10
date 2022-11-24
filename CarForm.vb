Imports System.ComponentModel
Imports System.Text

Public Class CarForm
    Inherits AppForm

    ' Children
    Dim carFeatures As CarFeatureForm
    Dim carMedia As CarMediaForm
    Dim carDiagnostic As CarDiagnosticForm

    ' Notifications
    Dim riderAccidentNotification As AccidentNotification


    ' Current Booking
    Dim bookingEvent As UserCalendarEvent

    ' Error Shake
    Dim WithEvents backgroundWorker As BackgroundWorker

    Public Sub New(user As String, scenario As Integer, previousForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'App Form
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = previousForm
        Me.devWindow = devForm
    End Sub

    Private Sub CarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.user = "owner" Then
            Me.Text = "Car Owner Car"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Car"
        End If

        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Car")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)

        ' Booking
        Me.devWindow.SetCurrentBooking()
        Me.bookingEvent = Me.devWindow.GetCurrentBooking()

        ' Disable if no booking
        If Me.bookingEvent Is Nothing Then
            Select Case Me.user
                Case "owner"
                    Me.btnStop.Enabled = False
                    Me.btnEmergency.Enabled = False
                Case "rider"
                    Me.btnStop.Enabled = False
                    Me.btnEmergency.Enabled = False
                    Me.btnCarFeatures.Enabled = False
                    Me.btnCarMedia.Enabled = False
                    Me.btnDiagnostic.Enabled = False
            End Select
        End If

        ' Background Worker
        Me.backgroundWorker = New BackgroundWorker()
    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.carFeatures IsNot Nothing) Then
            Me.carFeatures.CloseAllForms()
        End If

        If (Me.carMedia IsNot Nothing) Then
            Me.carMedia.CloseAllForms()
        End If

        If (Me.carDiagnostic IsNot Nothing) Then
            Me.carDiagnostic.CloseAllForms()
        End If
    End Sub

    ' -----------------
    ' --- Emergency ---
    ' -----------------
    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        If Me.bookingEvent Is Nothing Then
            Select Case Me.user
                Case "owner"
                    Me.ShakeErrorMessage("You need to accept a booking request")
                Case "rider"
                    Me.ShakeErrorMessage("You need to add a booking")
            End Select
            Exit Sub
        End If
        Me.riderAccidentNotification = New AccidentNotification("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderAccidentNotification)
    End Sub

    '------------
    '--- Stop ---
    '------------

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If Me.bookingEvent Is Nothing Then
            Select Case Me.user
                Case "owner"
                    Me.ShakeErrorMessage("You need to accept a booking request")
                Case "rider"
                    Me.ShakeErrorMessage("You need to add a booking")
            End Select
            Exit Sub
        End If
        Dim riderNotification As New CarStopForm("owner", Me.scenario, Me.homeWindow, Me.devWindow)
        riderNotification.Show()
        riderNotification.changeTitle("Confirm")
        riderNotification.changeDescription("Are you sure you want to stop the vehicle?")
        riderNotification.makeBtnVisible()
    End Sub

    ' --------------------
    ' --- Car Features ---
    ' --------------------
    Private Sub btnCarFeatures_Click(sender As Object, e As EventArgs) Handles btnCarFeatures.Click
        ' car features form opens up here
        Me.carFeatures = New CarFeatureForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow)
        Me.Hide()
        carFeatures.Show()
        Me.SetCurrentForm(Me.carFeatures)
    End Sub

    Private Sub btnCarFeatures_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCarFeatures.MouseDown
        btnCarFeatures.BackgroundImage = My.Resources.fan_press
    End Sub

    Private Sub btnCarFeatures_MouseEnter(sender As Object, e As EventArgs) Handles btnCarFeatures.MouseEnter
        btnCarFeatures.BackgroundImage = My.Resources.fan_hover
    End Sub

    Private Sub btnCarFeatures_MouseLeave(sender As Object, e As EventArgs) Handles btnCarFeatures.MouseLeave
        btnCarFeatures.BackgroundImage = My.Resources.fan_neutral

    End Sub

    '-----------------
    '--- Car Media ---
    '-----------------

    Private Sub btnCarMedia_Click(sender As Object, e As EventArgs) Handles btnCarMedia.Click
        btnCarMedia.BackgroundImage = My.Resources.car_media_press
        'Me.carMedia = New CarMediaForm
        Me.carMedia = New CarMediaForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow)
        Me.carMedia.Show()
        Me.Hide()
        Me.SetCurrentForm(Me.carMedia)
    End Sub

    Private Sub btnCarMedia_MouseEnter(sender As Object, e As EventArgs) Handles btnCarMedia.MouseEnter
        btnCarMedia.BackgroundImage = My.Resources.car_media_hover

    End Sub

    Private Sub btnCarMedia_MouseLeave(sender As Object, e As EventArgs) Handles btnCarMedia.MouseLeave
        btnCarMedia.BackgroundImage = My.Resources.car_media_neutral

    End Sub

    '------------------
    '--- Diagnostic ---
    '------------------

    Private Sub btnDiagnostic_Click(sender As Object, e As EventArgs) Handles btnDiagnostic.Click
        Me.Hide()
        Me.carDiagnostic = New CarDiagnosticForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow)
        Me.carDiagnostic.Show()
        Me.SetCurrentForm(Me.carDiagnostic)
    End Sub

    Private Sub btnDiagnostic_MouseEnter(sender As Object, e As EventArgs) Handles btnDiagnostic.MouseEnter
        btnDiagnostic.BackgroundImage = My.Resources.diagnostic4
    End Sub

    Private Sub btnDiagnostic_MouseLeave(sender As Object, e As EventArgs) Handles btnDiagnostic.MouseLeave
        btnDiagnostic.BackgroundImage = My.Resources.diagnostic3
    End Sub

    ' -------------
    ' --- Shake ---
    ' -------------

    Private Sub ShakeErrorMessage(errorText As String)
        Me.lblError.Text = errorText
        Me.lblError.Visible = True
        Me.lblError.BringToFront()
        Me.lblError.Location = New Point((Me.Width / 2) - (Me.lblError.Width / 2) - 18, Me.lblError.Top)
        If Me.backgroundWorker.IsBusy() = False Then
            Me.backgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker.DoWork
        Dim shakeArr() = {1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1}

        ' Shake
        For fullShake As Integer = 0 To 3
            For moveIndex As Integer = 0 To shakeArr.Length() - 1
                'Move
                lblError.Left += shakeArr(moveIndex)

                'Wait
                Me.lblError.Refresh()
                Threading.Thread.Sleep(10)
            Next
        Next

        ' Pause
        For pause As Integer = 0 To 150
            'Wait
            Me.lblError.Refresh()
            Threading.Thread.Sleep(10)
        Next

        Me.lblError.Visible = False
    End Sub

End Class