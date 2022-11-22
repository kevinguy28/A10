Public Class CalendarConfirmForm

    ' Parents
    Dim bookingForm As CalendarCarSelectForm
    Dim schedulingForm As CalendarSchedulingForm

    Dim user As String
    Dim devWindow As DevForm
    Dim usrEvent As UserCalendarEvent

    Public Sub New(usrEvent As UserCalendarEvent, user As String, devWindow As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.user = user
        Me.devWindow = devWindow
    End Sub

    Private Sub CalendarCarConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.lblTitle.Text = "Scheduling"
                Me.lblPrompt.Text = "Are you sure you want to" & vbCrLf & "change the availability?"
                Me.imgProfilePicture.Image = usrEvent.GetProfilePicture
                Me.lblName.Text = usrEvent.GetName
            Case "rider"
                Me.lblTitle.Text = "Booking Request"
                Me.lblPrompt.Text = "Are you sure you" & vbCrLf & "want to book this ride?"
                Me.imgProfilePicture.Image = usrEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = usrEvent.GetCarOwnerName
        End Select

        Me.lblCar.Text = usrEvent.GetColour & " " & Me.usrEvent.GetCar

        Dim startTime = Format(usrEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(usrEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(usrEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(usrEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime
    End Sub

    Public Sub SetBookingForm(bookingForm As CalendarCarSelectForm)
        Me.bookingForm = bookingForm
    End Sub

    Public Sub SetSchedulingForm(schedulingForm As CalendarSchedulingForm)
        Me.schedulingForm = schedulingForm
    End Sub

    ' ------------------------
    ' --- Buttons Clicked ---
    ' ------------------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If bookingForm IsNot Nothing Then
            Me.bookingForm.ConfirmClicked()
        ElseIf schedulingForm IsNot Nothing Then
            Me.schedulingForm.ConfirmClicked()
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        If bookingForm IsNot Nothing Then
            Me.bookingForm.CancelClicked()
        ElseIf schedulingForm IsNot Nothing Then
            Me.schedulingForm.CancelClicked()
        End If
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub CalendarCarConfirmForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(320, 346)
    End Sub

    Private Sub CalendarCarConfirmForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim x = 0
        Dim y = 0
        If bookingForm IsNot Nothing Then
            x = Me.bookingForm.Location.X + ((Me.bookingForm.Width / 2) - (Me.Width / 2))
            y = Me.bookingForm.Location.Y + ((Me.bookingForm.Height / 2) - (Me.Height / 2))
        ElseIf schedulingForm IsNot Nothing Then
            x = Me.schedulingForm.Location.X + ((Me.schedulingForm.Width / 2) - (Me.Width / 2))
            y = Me.schedulingForm.Location.Y + ((Me.schedulingForm.Height / 2) - (Me.Height / 2))
        End If
        Me.Location = New Size(x, y)
    End Sub

    ' ----------------
    ' --- On Close ---
    ' ----------------
    Private Sub CalendarCarConfirmForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.devWindow.ClosePopup(Me.user)
    End Sub

End Class