Public Class CarDiagnosticForm
    Inherits AppForm

    'Notification
    Dim callForm As CallForm
    Dim cancelBooking As ExitCarForm
    Dim riderRebook As RescheduleNotification

    Public Sub New(user As String, Scenario As Integer, previousForm As AppForm, homeForm As HomeForm, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = Scenario
        Me.previousWindow = previousForm
        Me.homeWindow = homeForm
        Me.devWindow = devForm
    End Sub
    Private Sub CarDiagnosticForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Me.scenario = 4 Then
            Me.pbBattery.Image = My.Resources.LowBattery
        End If

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Diagnostic"
            Case "rider"
                Me.Text = "Car Rider Car Diagnostic"
        End Select

        Me.SetLocation()
        Me.SetBackground()
        Me.CreateTitleLabel("Diagnostic")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        For i As Integer = 0 To 6
            If (Me.scenario = 2 Or Me.devWindow.GetCarCondition = 0) And (i = 0 Or i = 1 Or i = 3) Then
                Me.lbDiagnostic.Items(i) = Me.lbDiagnostic.Items(i) + "Damaged"
            Else
                Me.lbDiagnostic.Items(i) = Me.lbDiagnostic.Items(i) + "Good"
            End If
        Next
    End Sub

    Private Sub btnTow_Click(sender As Object, e As EventArgs) Handles btnTow.Click

        ' Call Form (Owner)

        Me.callForm = New CallForm(Me.user, Me.scenario, Me.devWindow)
        Me.devWindow.OpenPopup(Me.user, Me.callForm)

        ' Removes current bookings (Owner)
        'Dim availability = Me.devWindow.GetCurrentSchedule()
        'Me.devWindow.RemoveAvailability(availability)

        Me.cancelBooking = New ExitCarForm(Me.user, Me.scenario, Me.devWindow)
        Me.cancelBooking.lblMessage.Text = "All bookings have been canceled!"
        Me.devWindow.OpenPopup("owner", Me.cancelBooking)

        Me.riderRebook = New RescheduleNotification("rider", Me.scenario, Me.devWindow, Me.homeWindow)
        Me.riderRebook.Show()
    End Sub
End Class