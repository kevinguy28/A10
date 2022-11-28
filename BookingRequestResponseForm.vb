Public Class BookingRequestResponseForm

    Dim user As String
    Dim scenario As Integer
    Dim homeWindow As HomeForm
    Dim devWindow As DevForm

    Dim bookingEvent As UserCalendarEvent
    Dim response As String
    Dim bookingForm As CalendarCarSelectForm

    Public Sub New(user As String, scenario As Integer, homeWindow As HomeForm, devWindow As DevForm, bookingEvent As UserCalendarEvent, response As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.homeWindow = homeWindow
        Me.devWindow = devWindow
        Me.bookingEvent = bookingEvent
        Me.response = response

        Select Case Me.response
            Case "accept"
                Me.lblPrompt.Text = "This booking request" & vbCrLf & "has been accepted"
                Me.btnConfirm.Visible = True
                Me.btnCancel.Visible = False
                Me.btnCheck.Visible = False
            Case "deny"
                Me.lblPrompt.Text = "This booking request" & vbCrLf & "has been denied"
                Me.btnConfirm.Visible = False
                Me.btnCancel.Visible = True
                Me.btnCheck.Visible = True
        End Select

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub BookingRequestResponseFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Car Rider Booking Request"

        Me.lblUser.Text = "Car Owner:"
        Me.imgProfilePicture.Image = Me.bookingEvent.GetCarOwnerProfilePicture
        Me.lblName.Text = Me.bookingEvent.GetCarOwnerName
        Me.lblCar.Text = Me.bookingEvent.GetColour & " " & Me.bookingEvent.GetCar

        Dim startTime = Format(Me.bookingEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(Me.bookingEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        Me.lblLocation.Text = Me.bookingEvent.GetStartLocation & vbCrLf & Me.bookingEvent.GetEndLocation

    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Me.bookingForm = New CalendarCarSelectForm("rider", Me.scenario, Me.homeWindow, Me.homeWindow, Me.devWindow, Me.bookingEvent.GetStartDate)
        Me.devWindow.SetCurrentRiderForm(Me.bookingForm)
        Me.bookingForm.Show()
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(320, 420)
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