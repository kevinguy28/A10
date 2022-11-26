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
    Dim riderIntrusionNotification As IntrusionAlertForm
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
            Me.btnStop.Visible = False
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
        Me.bookingEvent = Me.devWindow.GetCurrentBooking()

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

    Private Function DisabledClick(disableOwner As Boolean)
        If Me.bookingEvent Is Nothing Then
            Select Case Me.user
                Case "owner"
                    If disableOwner Then Me.ShakeErrorMessage("You need to accept a booking request") : Return True
                Case "rider"
                    Me.ShakeErrorMessage("You need to add a booking")
                    Return True
            End Select
        End If
        Return False
    End Function

    ' -----------------
    ' --- Emergency ---
    ' -----------------
    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        If Me.DisabledClick(True) Then Exit Sub
        Me.riderAccidentNotification = New AccidentNotification("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderAccidentNotification)

        'If Me.DisabledClick(True) Then Exit Sub
        'Me.riderIntrusionNotification = New IntrusionAlertForm("rider", Me.scenario, Me.devWindow, True)
        'Me.devWindow.OpenPopup("rider", Me.riderIntrusionNotification)
    End Sub

    '------------
    '--- Stop ---
    '------------
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If Me.DisabledClick(True) Then Exit Sub
        Dim riderNotification As New CarStopForm("rider", Me.scenario, Me.homeWindow, Me.devWindow)
        Me.devWindow.OpenPopup(Me.user, riderNotification)
    End Sub

    ' --------------------
    ' --- Car Features ---
    ' --------------------
    Private Sub btnCarFeatures_Click(sender As Object, e As EventArgs) Handles btnCarFeatures.Click
        If Me.DisabledClick(False) Then Exit Sub
        Me.carFeatures = New CarFeatureForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow)
        Me.Hide()
        carFeatures.Show()
        Me.SetCurrentForm(Me.carFeatures)
    End Sub

    Private Sub btnCarFeatures_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCarFeatures.MouseDown
        btnCarFeatures.BackgroundImage = My.Resources.fan_press
    End Sub

    Private Sub btnCarFeatures_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCarFeatures.MouseUp
        btnCarFeatures.BackgroundImage = My.Resources.fan_hover
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
        If Me.DisabledClick(False) Then Exit Sub
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

    Private Sub btnCarMedia_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCarMedia.MouseDown
        btnCarMedia.BackgroundImage = My.Resources.car_media_press
    End Sub

    Private Sub btnCarMedia_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCarMedia.MouseUp
        btnCarMedia.BackgroundImage = My.Resources.car_media_hover
    End Sub

    '------------------
    '--- Diagnostic ---
    '------------------

    Private Sub btnDiagnostic_Click(sender As Object, e As EventArgs) Handles btnDiagnostic.Click
        If Me.DisabledClick(False) Then Exit Sub
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
        If Me.backgroundWorker.IsBusy() = False Then
            Me.lblError.Location = New Point((Me.Width / 2) - (Me.lblError.Width / 2) - 18, Me.lblError.Top)
            Me.backgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker.DoWork
        Dim shakeArr() = {1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1}

        Try
            ' Shake
            For fullShake As Integer = 0 To 3
                For moveIndex As Integer = 0 To shakeArr.Length() - 1
                    'Move
                    If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() lblError.Left += shakeArr(moveIndex)) _
                    Else lblError.Left += shakeArr(moveIndex)

                    'Wait
                    If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                    Else Me.lblError.Refresh()
                    Threading.Thread.Sleep(10)
                Next
            Next

            ' Pause
            For pause As Integer = 0 To 150
                'Wait
                If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                Else Me.lblError.Refresh()
                Threading.Thread.Sleep(10)
            Next

            If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Visible = False) _
            Else Me.lblError.Visible = False
        Catch ex As Exception
        End Try

    End Sub

End Class