Imports System.IO

Public Class HomeForm
    Dim user As String
    Dim scenario As Integer
    Dim otherForm As Form
    Dim previousForm As DevForm

    Dim calendarForm As CalendarForm
    Dim carForm As CarForm
    Dim routeForm As RouteForm
    Dim chatForm As ChatForm

    Public Sub New(user As String, scenario As Integer, previousForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousForm = DevForm

        If Me.user = "owner" Then
            Me.Text = "Car Owner Home"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Home"
        End If

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Location
        Me.SetLocation()

        ' Profile
        If Me.user = "owner" Then
            Me.imgAvatar.Image = My.Resources.OwnerProfile
            Me.lblName.Text = "Jane Doe"
        ElseIf Me.user = "rider" Then
            Me.imgAvatar.Image = My.Resources.RiderProfile
            Me.lblName.Text = "John Smith"
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

    Public Sub closeChildrenForm()

        If (Me.calendarForm IsNot Nothing) Then
            Me.calendarForm.Close()
            Me.calendarForm = Nothing
        End If

        If (Me.carForm IsNot Nothing) Then
            Me.carForm.Close()
            Me.carForm = Nothing
        End If

        If (Me.routeForm IsNot Nothing) Then
            Me.routeForm.Close()
            Me.routeForm = Nothing
        End If

        If (Me.chatForm IsNot Nothing) Then
            Me.chatForm.Close()
            Me.chatForm = Nothing
        End If

    End Sub

    Private Sub SetCurrentForm(form As Form)
        If (user = "owner") Then
            Me.previousForm.SetCurrentOwnerForm(form)
        ElseIf (user = "rider") Then
            Me.previousForm.SetCurrentRiderForm(form)
        End If
    End Sub

    ' ----------------
    ' --- Location ---
    ' ----------------
    Private Sub HomeForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Me.SetLocation()
    End Sub

    Private Sub SetLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.Width / 2
        Dim halfHome = Me.Width / 2

        If Me.user = "owner" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfHome
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "rider" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfHome
            Me.Location = New Point(x, 0)
        End If
    End Sub

    ' --------------------
    ' --- Button Click ---
    ' --------------------
    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        Me.calendarForm = New CalendarForm(Me.user, Me.scenario, Me, Me.previousForm)
        Me.Hide()
        Me.calendarForm.Show()
        Me.SetCurrentForm(Me.calendarForm)
    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        Me.carForm = New CarForm(Me.user, Me.scenario, Me, Me.previousForm)
        Me.Hide()
        Me.carForm.Show()
        Me.SetCurrentForm(Me.carForm)
    End Sub

    Private Sub btnRoute_Click(sender As Object, e As EventArgs) Handles btnRoute.Click
        Me.routeForm = New RouteForm(Me.user, Me.scenario, Me, Me.previousForm)
        Me.Hide()
        Me.routeForm.Show()
        Me.SetCurrentForm(Me.routeForm)
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        Me.chatForm = New ChatForm(Me.user, Me.scenario, Me, Me.previousForm)
        Me.Hide()
        Me.chatForm.Show()
        Me.SetCurrentForm(Me.chatForm)
    End Sub

    ' --------------------
    ' --- Button Hover ---
    ' --------------------
    Private Sub btnCalendar_MouseEnter(sender As Object, e As EventArgs) Handles btnCalendar.MouseEnter
        Me.btnCalendar.BackgroundImage = My.Resources.Calendar___Hover
    End Sub

    Private Sub btnCalendar_MouseLeave(sender As Object, e As EventArgs) Handles btnCalendar.MouseLeave
        Me.btnCalendar.BackgroundImage = My.Resources.Calendar
    End Sub

    Private Sub btnCar_MouseEnter(sender As Object, e As EventArgs) Handles btnCar.MouseEnter
        Me.btnCar.BackgroundImage = My.Resources.Car___Hover
    End Sub

    Private Sub btnCar_MouseLeave(sender As Object, e As EventArgs) Handles btnCar.MouseLeave
        Me.btnCar.BackgroundImage = My.Resources.Car
    End Sub

    Private Sub btnRoute_MouseEnter(sender As Object, e As EventArgs) Handles btnRoute.MouseEnter
        Me.btnRoute.BackgroundImage = My.Resources.Map___Hover
    End Sub

    Private Sub btnRoute_MouseLeave(sender As Object, e As EventArgs) Handles btnRoute.MouseLeave
        Me.btnRoute.BackgroundImage = My.Resources.Map
    End Sub

    Private Sub btnChat_MouseEnter(sender As Object, e As EventArgs) Handles btnChat.MouseEnter
        Me.btnChat.BackgroundImage = My.Resources.Chat___Hover
    End Sub

    Private Sub btnChat_MouseLeave(sender As Object, e As EventArgs) Handles btnChat.MouseLeave
        Me.btnChat.BackgroundImage = My.Resources.Chat
    End Sub

    ' --------------------
    ' --- Button Press ---
    ' --------------------
    Private Sub btnCalendar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCalendar.MouseDown
        Me.btnCalendar.BackgroundImage = My.Resources.Calendar___Press
    End Sub

    Private Sub btnCalendar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCalendar.MouseUp
        Me.btnCalendar.BackgroundImage = My.Resources.Calendar___Hover
    End Sub

    Private Sub btnCar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCar.MouseDown
        Me.btnCar.BackgroundImage = My.Resources.Car___Press
    End Sub

    Private Sub btnCar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCar.MouseUp
        Me.btnCar.BackgroundImage = My.Resources.Car___Hover
    End Sub

    Private Sub btnRoute_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRoute.MouseDown
        Me.btnRoute.BackgroundImage = My.Resources.Map___Press
    End Sub

    Private Sub btnRoute_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRoute.MouseUp
        Me.btnRoute.BackgroundImage = My.Resources.Map___Hover
    End Sub

    Private Sub btnChat_MouseDown(sender As Object, e As MouseEventArgs) Handles btnChat.MouseDown
        Me.btnChat.BackgroundImage = My.Resources.Chat___Press
    End Sub

    Private Sub btnChat_MouseUp(sender As Object, e As MouseEventArgs) Handles btnChat.MouseUp
        Me.btnChat.BackgroundImage = My.Resources.Chat___Hover
    End Sub

End Class