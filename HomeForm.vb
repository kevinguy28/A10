Imports System.IO

Public Class HomeForm
    Dim user As String
    Dim scenario As Integer
    Dim otherForm As Form

    Public Sub New(user As String, scenario As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario

        If Me.user = "owner" Then
            Me.Text = "Car Owner Home"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Home"
        End If

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Location
        If Me.user = "owner" Then
            Me.Location = New Point(Me.Width * 0.25, 0)
        ElseIf Me.user = "rider" Then
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - (Me.Width * 1.25), 0)
        End If

        ' Calendar and Car
        If Me.user = "owner" Then
            Me.lblCalendar.Text = "Schedule"
            Me.lblCar.Text = "My Car"
        ElseIf Me.user = "rider" Then
            Me.lblCalendar.Text = "Booking"
            Me.lblCar.Text = "My Ride"
        End If

    End Sub

    Public Sub addOtherForm(otherForm As Form)
        Me.otherForm = otherForm
    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click

    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click

    End Sub

    Private Sub btnRoute_Click(sender As Object, e As EventArgs) Handles btnRoute.Click

    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click

    End Sub
End Class