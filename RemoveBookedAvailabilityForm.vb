Public Class RemoveBookedAvailabilityForm

    Dim user As String
    Dim scenario
    Dim previousWindow As CalendarSchedulingForm
    Dim devWindow As DevForm
    Dim availability As UserCalendarEvent
    Dim booking As UserCalendarEvent

    Public Sub New(user As String, scenario As Integer, previousWindow As CalendarSchedulingForm, devWindow As DevForm, availability As UserCalendarEvent)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousWindow
        Me.devWindow = devWindow
        Me.availability = availability
        Me.booking = availability.GetBooking()

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)

    End Sub

    Private Sub RemoveAvailabilityBookedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Car Owner Booked Avblty"

        Me.lblUser.Text = "Car Rider:"
        Me.lblName.Text = booking.GetName
        Me.imgProfilePicture.Image = booking.GetProfilePicture
        Me.lblCar.Text = booking.GetColour & " " & Me.booking.GetCar

        Dim startTime = Format(Me.booking.GetStartDate, "ddd d MMM yyyy") & " at " & Format(Me.booking.GetStartDate, "h:mm tt")
        Dim endTime = Format(Me.booking.GetEndDate, "ddd d MMM yyyy") & " at " & Format(Me.booking.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        Me.lblLocation.Text = Me.booking.GetStartLocation & vbCrLf & Me.booking.GetEndLocation

        'Reschedule
        Dim reschedule = Me.devWindow.GetAllAvailabilities(Me.booking.GetStartDate, Me.booking.GetEndDate)
        If reschedule.Count > 1 Then
            Me.lblReschedule.Text = "Can be rescheduled."
        Else
            Me.lblReschedule.Text = "Cannot be rescheduled."
        End If

    End Sub

    ' ------------------------
    ' --- Buttons Clicked ---
    ' ------------------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.devWindow.ClosePopup(Me.user)

        Dim riderHome = Me.devWindow.GetRiderHomeForm
        Dim responseForm = New BookingRequestResponseForm("rider", Me.scenario, riderHome, Me.devWindow, Me.booking, "deny")
        responseForm.lblTitle.Text = "Booking Cancelled"
        responseForm.lblPrompt.Text = "Your booking has been cancelled"
        Me.devWindow.OpenPopup("rider", responseForm)

        Me.previousWindow.ConflictConfirmClicked(Me.availability)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.devWindow.ClosePopup(Me.user)
        Me.previousWindow.ConflictCancelClicked()
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(353, 470)
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
    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class