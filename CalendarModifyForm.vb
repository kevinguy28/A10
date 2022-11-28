Public Class CalendarModifyForm

    Dim user As String
    Dim scenario As Integer
    Dim dayWindow As CalendarDayForm
    Dim devWindow As DevForm

    Dim userEvent As UserCalendarEvent

    Public Sub New(user As String, scenario As Integer, dayWindow As CalendarDayForm, devWindow As DevForm, userEvent As UserCalendarEvent)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.dayWindow = dayWindow
        Me.devWindow = devWindow
        Me.userEvent = userEvent

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub CalendarModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.lblPrice.Text = ""

        Select Case Me.user
            Case "owner"
                'Labels
                Me.Text = "Car Owner Modify Schedule"
                Me.lblTitle.Text = "Modify Schedule"
                Me.lblPrompt.Text = "How do you want to" & vbCrLf & "modify your schedule?"

                ' If availability is booked
                If Me.userEvent.GetCarRiderName Is Nothing Then
                    Me.lblUser.Text = "Car Owner:"

                    'Booking
                    Me.imgProfilePicture.Image = userEvent.GetProfilePicture
                    Me.lblName.Text = userEvent.GetName
                    Me.btnRate.Visible = False
                Else
                    Me.lblUser.Text = "Car Rider:"

                    'Booking
                    Me.imgProfilePicture.Image = userEvent.GetCarRiderProfilePicture
                    Me.lblName.Text = userEvent.GetCarRiderName
                    Me.lblPrice.Text = "Earnings: $" & Me.devWindow.GetCost(Me.userEvent.GetStartLocation, Me.userEvent.GetEndLocation)
                End If

            Case "rider"
                'Labels
                Me.Text = "Car Rider Modify Booking"
                Me.lblTitle.Text = "Modify Booking"
                Me.lblPrompt.Text = "How do you want to" & vbCrLf & "modify your booking?"
                Me.lblUser.Text = "Car Owner:"

                'Booking
                Me.imgProfilePicture.Image = userEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = userEvent.GetCarOwnerName
                Me.lblPrice.Text = "Price: $" & Me.devWindow.GetCost(Me.userEvent.GetStartLocation, Me.userEvent.GetEndLocation)
        End Select

        'Booking / Schedule
        Me.lblCar.Text = Me.userEvent.GetColour & " " & Me.userEvent.GetCar

        Dim startTime = Format(Me.userEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(Me.userEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(Me.userEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(Me.userEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        Me.lblLocation.Text = Me.userEvent.GetStartLocation & vbCrLf & Me.userEvent.GetEndLocation

    End Sub

    ' ---------------
    ' --- Buttons ---
    ' ---------------

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Close()
        Me.dayWindow.TimeSlotClicked(userEvent.GetStartDate, Me.userEvent)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Close()
        Select Case Me.user
            Case "owner"
                Me.devWindow.RemoveAvailability(Me.userEvent)
            Case "rider"
                Me.devWindow.RemoveBooking(Me.userEvent)
        End Select
        Me.dayWindow.RefreshDayControl()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(380, 500)
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
        Me.Dispose()
    End Sub

End Class