Public Class LowBatteryNotificationForm
    Dim user As String
    Shared scenario As Integer
    Shared devWindow As DevForm

    Shared bookingEvent As UserCalendarEvent
    Shared riderContinue As Boolean = False
    Shared riderDone As Boolean = False
    Shared ownerDone As Boolean = False

    ' Battery Is Low
    Shared riderNotification As LowBatteryNotificationForm  ' Continue or end ride?
    Shared ownerNotification As LowBatteryNotificationForm  ' Wait for rider's response

    ' Select Your Station
    Shared stationForm As ChooseStationForm '[Rider: Rider chose Continue] [Owner: Rider chose End Ride]

    ' Response Form
    Shared riderResponse As LowBatteryResponseForm '[Rider Selected Continue: Car has been rerouted to...] [Rider Selected End Ride: Please exit the vehicle]
    Shared ownerResponse As LowBatteryResponseForm '[Rider Selected Continue: Rider chose to continue. Car has been rerouted to...] [Rider Selected End Ride: Car has been rerouted to...]


    Public Sub New(user As String, scenario As Integer, devWindow As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        If LowBatteryNotificationForm.scenario = 0 Then LowBatteryNotificationForm.scenario = scenario
        If LowBatteryNotificationForm.devWindow Is Nothing Then LowBatteryNotificationForm.devWindow = devWindow

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)

        Select Case Me.user
            Case "owner"
                LowBatteryNotificationForm.ownerNotification = Me
            Case "rider"
                LowBatteryNotificationForm.riderNotification = Me
        End Select
    End Sub

    Private Sub LowBatteryNotificationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Booking
        If LowBatteryNotificationForm.bookingEvent Is Nothing Then bookingEvent = devWindow.GetCurrentBooking()

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Low Battery"
                Me.lblTitle.Text = "Battery Low"
                Me.lblPrompt.Text = "The car battery is running low." & vbCrLf & "Please wait for the rider's response."
                Me.lblUser.Text = "Car Rider:"

                'Booking
                Me.imgProfilePicture.Image = bookingEvent.GetProfilePicture
                Me.lblName.Text = bookingEvent.GetName

                'Buttons
                Me.btnContinue.Visible = False
                Me.btnEnd.Visible = False
                Me.btnOk.Visible = True
            Case "rider"
                Me.Text = "Car Rider Low Battery"
                Me.lblTitle.Text = "Battery Low"
                Me.lblPrompt.Text = "The car battery is running low." & vbCrLf & "What would you like to do?"
                Me.lblUser.Text = "Car Owner:"

                'Booking
                Me.imgProfilePicture.Image = bookingEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = bookingEvent.GetCarOwnerName

                'Buttons
                Me.btnContinue.Visible = True
                Me.btnEnd.Visible = True
                Me.btnOk.Visible = False
        End Select

        'Booking
        Me.lblCar.Text = bookingEvent.GetColour & " " & bookingEvent.GetCar

        Dim startTime = Format(bookingEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(bookingEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(bookingEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(bookingEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime
    End Sub

    Public Shared Sub CloseAllForms()
        If (riderDone) AndAlso (ownerDone) Then

            'Batter is low
            If (LowBatteryNotificationForm.riderNotification IsNot Nothing) Then
                LowBatteryNotificationForm.riderNotification.Dispose()
                LowBatteryNotificationForm.riderNotification = Nothing
            End If

            If (LowBatteryNotificationForm.ownerNotification IsNot Nothing) Then
                LowBatteryNotificationForm.ownerNotification.Dispose()
                LowBatteryNotificationForm.ownerNotification = Nothing
            End If

            ' Select your station
            If (LowBatteryNotificationForm.stationForm IsNot Nothing) Then
                LowBatteryNotificationForm.stationForm.Dispose()
                LowBatteryNotificationForm.stationForm = Nothing
            End If

            ' Response Form
            If (LowBatteryNotificationForm.riderResponse IsNot Nothing) Then
                LowBatteryNotificationForm.riderResponse.Dispose()
                LowBatteryNotificationForm.riderResponse = Nothing
            End If

            If (LowBatteryNotificationForm.ownerResponse IsNot Nothing) Then
                LowBatteryNotificationForm.ownerResponse.Dispose()
                LowBatteryNotificationForm.ownerResponse = Nothing
            End If

            scenario = 0
            devWindow = Nothing

            bookingEvent = Nothing
            riderContinue = False
            riderDone = False
            ownerDone = False

        End If
    End Sub

    Public Shared Sub SetRiderDone()
        LowBatteryNotificationForm.riderDone = True
    End Sub

    Public Shared Sub SetOwnerDone()
        LowBatteryNotificationForm.ownerDone = True
    End Sub

    Private Sub CreateStationForm()
        Select Case LowBatteryNotificationForm.riderContinue
            Case True
                LowBatteryNotificationForm.stationForm = New ChooseStationForm("rider", scenario, devWindow)
                stationForm.lblPrompt.Text = "Please choose a station to reroute to. Your bill will be adjusted accordingly."
                devWindow.OpenPopup("rider", LowBatteryNotificationForm.stationForm)
            Case False
                LowBatteryNotificationForm.ownerNotification.Close()
                LowBatteryNotificationForm.stationForm = New ChooseStationForm("owner", scenario, devWindow)
                stationForm.lblPrompt.Text = "The rider has ended their ride. Choose a station to send your car to for a refuel."
                devWindow.OpenPopup("owner", LowBatteryNotificationForm.stationForm)
        End Select
    End Sub

    Shared Sub CreateResponseForm(exitRideForm As Boolean, Optional stationName As String = "")
        ' Make Rider Exit Vehicle Notification
        If exitRideForm Then
            'Rider
            LowBatteryNotificationForm.riderResponse = New LowBatteryResponseForm("rider", scenario, devWindow)
            LowBatteryNotificationForm.riderResponse.lblTitle.Text = "Exit Vehicle"
            LowBatteryNotificationForm.riderResponse.lblPrompt.Text = "You have chosen to leave car." & vbCrLf & "Please exit the vehicle."
            devWindow.OpenPopup("rider", LowBatteryNotificationForm.riderResponse)
            Exit Sub
        End If

        ' Make Rerouted Notifications
        LowBatteryNotificationForm.ownerNotification.Close()
        LowBatteryNotificationForm.riderNotification.Close()
        LowBatteryNotificationForm.stationForm.Close()
        Select Case riderContinue
            Case True
                'Owner
                LowBatteryNotificationForm.ownerResponse = New LowBatteryResponseForm("owner", scenario, devWindow)
                Dim lblPrompt = LowBatteryNotificationForm.ownerResponse.lblPrompt
                lblPrompt.Text = "The rider has chosen to continue the ride." & vbCrLf & lblPrompt.Text & stationName
                devWindow.OpenPopup("owner", LowBatteryNotificationForm.ownerResponse)

                'Rider
                LowBatteryNotificationForm.riderResponse = New LowBatteryResponseForm("rider", scenario, devWindow)
                lblPrompt = LowBatteryNotificationForm.riderResponse.lblPrompt
                lblPrompt.Text = lblPrompt.Text & stationName
                devWindow.OpenPopup("rider", LowBatteryNotificationForm.riderResponse)
            Case False
                'Owner
                LowBatteryNotificationForm.ownerResponse = New LowBatteryResponseForm("owner", scenario, devWindow)
                Dim lblPrompt = LowBatteryNotificationForm.ownerResponse.lblPrompt
                lblPrompt.Text = lblPrompt.Text & stationName
                devWindow.OpenPopup("owner", LowBatteryNotificationForm.ownerResponse)
        End Select

    End Sub

    ' ---------------
    ' --- Buttons ---
    ' ---------------
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
        LowBatteryNotificationForm.riderContinue = False
        Me.CreateStationForm()
        LowBatteryNotificationForm.CreateResponseForm(True)
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Close()
        LowBatteryNotificationForm.riderContinue = True
        Me.CreateStationForm()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(380, 450)
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
        LowBatteryNotificationForm.CloseAllForms()
    End Sub

End Class