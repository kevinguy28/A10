Public Class LowBatteryResponseForm
    Dim user As String
    Dim scenario As Integer
    Dim devWindow As DevForm

    Dim bookingEvent As UserCalendarEvent

    Public Sub New(user As String, scenario As Integer, devWindow As DevForm)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.devWindow = devWindow

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)

        Me.lblTitle.Text = "Car Rerouted"
        Me.lblPrompt.Text = "The car has been rerouted to: " & vbCrLf
    End Sub

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Booking
        Me.bookingEvent = Me.devWindow.GetCurrentBooking()

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Rerouted"
                Me.lblUser.Text = "Car Rider:"

                'Booking
                Me.imgProfilePicture.Image = bookingEvent.GetProfilePicture
                Me.lblName.Text = bookingEvent.GetName
            Case "rider"
                Me.Text = "Car Rider Car Rerouted"
                Me.lblUser.Text = "Car Owner:"

                'Booking
                Me.imgProfilePicture.Image = bookingEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = bookingEvent.GetCarOwnerName
        End Select

        'Booking
        Me.lblCar.Text = bookingEvent.GetColour & " " & bookingEvent.GetCar

        Dim startTime = Format(bookingEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(bookingEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(bookingEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(bookingEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime
    End Sub

    ' --------------
    ' --- Button ---
    ' --------------

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(396, 390)
    End Sub

    Private Sub Form_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim x = 0
        Dim y = 0
        If Me.user = "rider" Then
            x = DevForm.GetRiderLocation.X + ((DevForm.GetFormWidth / 2) - (Me.Width / 2))
            y = DevForm.GetRiderLocation.Y + ((DevForm.GetFormHeight / 2) - (Me.Height / 2))
        ElseIf Me.user = "owner" Then
            x = DevForm.GetOwnerLocation.X + ((DevForm.GetFormWidth / 2) - (Me.Width / 2))
            y = DevForm.GetOwnerLocation.Y + ((DevForm.GetFormHeight / 2) - (Me.Height / 2))
        End If
        Me.Location = New Size(x, y)
    End Sub

    ' ----------------
    ' --- On Close ---
    ' ----------------
    Private Sub CalendarCarConfirmForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.devWindow.ClosePopup(Me.user)
        Select Case Me.user
            Case "owner"
                LowBatteryNotificationForm.SetOwnerDone()
            Case "rider"
                LowBatteryNotificationForm.SetRiderDone()
        End Select
        LowBatteryNotificationForm.CloseAllForms()
    End Sub

End Class