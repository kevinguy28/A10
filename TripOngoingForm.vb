Public Class TripOngoingForm

    Dim user As String
    Dim scenario
    Dim previousWindow As CalendarSchedulingForm
    Dim devWindow As DevForm
    Dim userEvent As UserCalendarEvent

    Public Sub New(user As String, scenario As Integer, previousWindow As CalendarSchedulingForm, devWindow As DevForm, userEvent As UserCalendarEvent)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousWindow
        Me.devWindow = devWindow
        Me.userEvent = userEvent

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub TripOngoingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim otherEvent As UserCalendarEvent

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Ongoing Trip"
                Me.lblUser.Text = "Car Rider:"
                otherEvent = Me.userEvent.GetBooking
            Case "rider"
                Me.Text = "Car Rider Ongoing Trip"
                Me.lblUser.Text = "Car Owner:"
                otherEvent = Me.userEvent.GetAvailability
        End Select

        Me.lblName.Text = otherEvent.GetName
        Me.imgProfilePicture.Image = otherEvent.GetProfilePicture
        Me.lblCar.Text = otherEvent.GetColour & " " & otherEvent.GetCar

        Dim startTime = Format(otherEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(otherEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(otherEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(otherEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        Me.lblLocation.Text = otherEvent.GetStartLocation & vbCrLf & otherEvent.GetEndLocation
    End Sub

    ' ------------------------
    ' --- Buttons Clicked ---
    ' ------------------------

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.previousWindow.ConflictCancelClicked()
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(320, 450)
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
        Me.devWindow.ClosePopup(Me.user)
        Me.Dispose()
    End Sub
End Class