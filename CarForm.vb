Imports System.Text

Public Class CarForm
    Inherits AppForm

    ' Children
    ' Emergency
    Public ownerAccidentNotification As AccidentNotification
    Public riderAccidentNotification As AccidentNotification
    ' Car Diagnostic
    Dim carDiagnostic As CarDiagnosticForm
    '
    Dim carFeatures As CarFeaturesForm
    Dim carMedia As CarMediaForm


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
        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Car")
        Me.CreateHomeButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
    End Sub

    ' -----------------
    ' --- Emergency ---
    ' -----------------
    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        'Rider Accident Notification
        Me.riderAccidentNotification = New AccidentNotification("rider", 2, Me.devWindow, Me) : Me.Hide()
        Me.riderAccidentNotification.Show() : Me.riderAccidentNotification.Location = New Point(riderAccidentNotification.SetLocation(), 0)
        ' Owner Accident Notification
        Me.ownerAccidentNotification = New AccidentNotification("owner", 2, Me.devWindow, Me)
        Me.ownerAccidentNotification.Show() : Me.ownerAccidentNotification.Location = New Point(ownerAccidentNotification.SetLocation(), 0)
        Me.ownerAccidentNotification.confirmButton.Hide() : Me.ownerAccidentNotification.denyButton.Hide()
        Me.ownerAccidentNotification.btnConfirm.Visible = True
    End Sub

    ' --------------------
    ' --- Car Features ---
    ' --------------------
    Private Sub btnCarFeatures_Click(sender As Object, e As EventArgs) Handles btnCarFeatures.Click
        ' car features form opens up here
        carFeatures = New CarFeaturesForm
        Me.Hide()
        carFeatures.Show()


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

    '-------------------
    '-----Car Media-----
    '-------------------

    Private Sub btnCarMedia_Click(sender As Object, e As EventArgs) Handles btnCarMedia.Click
        btnCarMedia.BackgroundImage = My.Resources.car_media_press
        Me.carMedia = New CarMediaForm
        Me.carMedia.Show()
        Me.Hide()
    End Sub

    Private Sub btnCarMedia_MouseEnter(sender As Object, e As EventArgs) Handles btnCarMedia.MouseEnter
        btnCarMedia.BackgroundImage = My.Resources.car_media_hover

    End Sub

    Private Sub btnCarMedia_MouseLeave(sender As Object, e As EventArgs) Handles btnCarMedia.MouseLeave
        btnCarMedia.BackgroundImage = My.Resources.car_media_neutral

    End Sub

    Private Sub btnDiagnostic_Click(sender As Object, e As EventArgs) Handles btnDiagnostic.Click
        Me.Hide()
        Me.carDiagnostic = New CarDiagnosticForm("owner", 2, Me, Me.homeWindow, Me.devWindow)
        Me.carDiagnostic.Show()
        Me.SetCurrentForm(Me.carDiagnostic)
    End Sub
End Class