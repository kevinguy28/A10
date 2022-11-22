Imports System.Text

Public Class CarForm
    Inherits AppForm

    ' Children
    Dim carFeatures As CarFeatureForm
    Dim carMedia As CarMediaForm
    Dim carDiagnostic As CarDiagnosticForm

    ' Notifications
    Public ownerAccidentNotification As AccidentNotification
    Public riderAccidentNotification As AccidentNotification

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
        'Rider Accident Notification
        Me.riderAccidentNotification = New AccidentNotification("rider", Me.scenario, Me.devWindow, True)
        Me.devWindow.OpenPopup("rider", Me.riderAccidentNotification)
    End Sub

    ' --------------------
    ' --- Car Features ---
    ' --------------------
    Private Sub btnCarFeatures_Click(sender As Object, e As EventArgs) Handles btnCarFeatures.Click
        ' car features form opens up here
        'Me.carFeatures = New CarFeaturesForm
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
End Class