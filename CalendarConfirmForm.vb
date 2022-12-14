Public Class CalendarConfirmForm

    ' Parents
    Dim bookingForm As CalendarRouteForm
    Dim schedulingForm As CalendarSchedulingForm

    Dim user As String
    Dim devWindow As DevForm
    Dim usrEvent As UserCalendarEvent

    Dim repeat As String = ""
    Dim repeatTime As Date = Nothing

    Dim stopArr() As String = Nothing

    Public Sub New(usrEvent As UserCalendarEvent, user As String, devWindow As DevForm, Optional repeat As String = "", Optional repeatTime As Date = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.user = user
        Me.devWindow = devWindow

        Me.repeat = repeat
        Me.repeatTime = repeatTime

        Me.CalendarCarConfirmForm_Resize(Nothing, Nothing)
        Me.CalendarCarConfirmForm_LocationChanged(Nothing, Nothing)
    End Sub

    Public Sub New(usrEvent As UserCalendarEvent, user As String, devWindow As DevForm, Optional stopArr() As String = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.user = user
        Me.devWindow = devWindow

        Me.stopArr = stopArr

        Me.CalendarCarConfirmForm_Resize(Nothing, Nothing)
        Me.CalendarCarConfirmForm_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub CalendarCarConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Confirm Avblty"
                Me.lblTitle.Text = "Scheduling"
                Me.lblPrompt.Text = "Are you sure you want to" & vbCrLf & "change the availability?"
                Me.imgProfilePicture.Image = usrEvent.GetProfilePicture
                Me.lblName.Text = usrEvent.GetName
                Me.lblStopsPrompt.Visible = False
                Me.lblStops.Visible = False

            Case "rider"
                Me.Text = "Car Rider Confirm Booking"
                Me.lblTitle.Text = "Booking"
                Me.lblPrompt.Text = "Are you sure you" & vbCrLf & "want to book this ride?"
                Me.imgProfilePicture.Image = usrEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = usrEvent.GetCarOwnerName
        End Select

        Me.lblUser.Text = "Car Owner:"
        Me.lblCar.Text = usrEvent.GetColour & " " & Me.usrEvent.GetCar

        ' Time
        Dim startTime = Format(usrEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(usrEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(usrEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(usrEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        ' Location
        Me.lblLocation.Text = Me.usrEvent.GetStartLocation & vbCrLf & Me.usrEvent.GetEndLocation

        ' Stops
        Me.lblStops.Text = ""
        If Me.stopArr IsNot Nothing Then
            If (stopArr(0) = "") AndAlso (stopArr(1) = "") Then
                lblStops.Text = "None"
            Else
                lblStops.Text += Me.stopArr(0)
                lblStops.Text += vbCrLf
                lblStops.Text += Me.stopArr(1)
            End If
        End If

        ' Repeat
        Select Case Me.user
            Case "owner"
                If Me.repeat <> "" AndAlso Me.repeat <> "Never" Then
                    Me.lblRepeat.Text = Me.repeat & " until " & Format(Me.repeatTime, "dddd d MMMM yyyy")
                Else
                    Me.lblRepeat.Text = ""
                End If
            Case "rider"
                Me.lblRepeat.Text = "Price: $" & Me.devWindow.GetCost(Me.usrEvent.GetStartLocation, Me.usrEvent.GetEndLocation)
        End Select
    End Sub

    Public Sub SetBookingForm(bookingForm As CalendarRouteForm)
        Me.bookingForm = bookingForm
    End Sub

    Public Sub SetSchedulingForm(schedulingForm As CalendarSchedulingForm)
        Me.schedulingForm = schedulingForm
    End Sub

    ' ------------------------
    ' --- Buttons Clicked ---
    ' ------------------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        If bookingForm IsNot Nothing Then
            Me.bookingForm.ConfirmClicked()
        ElseIf schedulingForm IsNot Nothing Then
            Me.schedulingForm.ConfirmClicked()
        End If
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
        Me.Size = New Size(320, 500)
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
        Me.Dispose()
    End Sub

End Class