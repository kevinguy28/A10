Public Class HomeForm
    Inherits AppForm

    ' Sibling
    Public otherForm As HomeForm

    ' Children
    Dim calendarForm As CalendarForm
    Dim carForm As CarForm
    Dim routeForm As RouteForm
    Dim chatForm As ChatForm
    Dim routeBackgroundImage As Bitmap

    Public Sub New(user As String, scenario As Integer, devForm As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.devWindow = devForm

        If Me.user = "owner" Then
            Me.Text = "Car Owner Home"
        ElseIf Me.user = "rider" Then
            Me.Text = "Car Rider Home"
        End If

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        If Me.scenario = 4 And Me.user = "rider" Then
            Dim riderLowBatteryNotification As New LowBatteryNotificationForm(Me.user, Me.scenario, Me) : riderLowBatteryNotification.setLocation()
            Me.Hide()
            riderLowBatteryNotification.TopMost = True : riderLowBatteryNotification.Show()
        End If

        If Me.scenario = 4 And Me.user = "owner" Then
            Dim ownerLowBatteryNotification As New LowBatteryNotificationForm(Me.user, Me.scenario, Me) : ownerLowBatteryNotification.setLocation()
            Me.Hide() : ownerLowBatteryNotification.btnConfirm.Visible = True : ownerLowBatteryNotification.btnEnd.Visible = False : ownerLowBatteryNotification.btnContinue.Visible = False
            ownerLowBatteryNotification.lblDescription.Text = "The car battery is running low. Please wait for the riders response!"
            ownerLowBatteryNotification.TopMost = True : ownerLowBatteryNotification.Show()
        End If

    End Sub

    Public Sub addOtherForm(otherForm As HomeForm)
        Me.otherForm = otherForm
    End Sub

    Public Overrides Sub CloseAllChildren()

        If (Me.calendarForm IsNot Nothing) Then
            Me.calendarForm.CloseAllForms()
        End If

        If (Me.carForm IsNot Nothing) Then
            Me.carForm.CloseAllForms()
        End If

        If (Me.routeForm IsNot Nothing) Then
            Me.routeForm.CloseAllForms()
        End If

        If (Me.chatForm IsNot Nothing) Then
            Me.chatForm.CloseAllForms()
        End If

    End Sub

    ' --------------------
    ' --- Button Click ---
    ' --------------------
    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        Me.calendarForm = New CalendarForm(Me.user, Me.scenario, Me, Me.devWindow)
        Me.Hide()
        Me.calendarForm.Show()
        Me.SetCurrentForm(Me.calendarForm)
    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        Me.carForm = New CarForm(Me.user, Me.scenario, Me, Me.devWindow)
        Me.Hide()
        Me.carForm.Show()
        Me.SetCurrentForm(Me.carForm)
    End Sub

    Private Sub btnRoute_Click(sender As Object, e As EventArgs) Handles btnRoute.Click
        Me.routeForm = New RouteForm(Me.user, Me.scenario, Me, Me.devWindow)
        Me.Hide()
        Me.routeForm.pbRoute.Image = routeBackgroundImage
        Me.routeForm.Show()
        Me.SetCurrentForm(Me.routeForm)
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        Me.chatForm = New ChatForm(Me.user, Me.scenario, Me, Me.devWindow)
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

    ' Relates to scenario 4, updatiung route background image

    Public Sub changeMap(theImage As Bitmap)
        Me.routeBackgroundImage = theImage
    End Sub
End Class