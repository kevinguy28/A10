Public Class CarRecallForm

    Dim user As String
    Dim scenario As Integer
    Dim homeWindow As HomeForm
    Dim devWindow As DevForm

    Dim bookingEvent As UserCalendarEvent

    Dim cancelBooking As ExitCarForm
    Dim riderRebook As RescheduleNotification

    Public Sub New(user As String, scenario As Integer, homeWindow As HomeForm, devWindow As DevForm, bookingEvent As UserCalendarEvent)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.homeWindow = homeWindow
        Me.devWindow = devWindow
        Me.bookingEvent = bookingEvent

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub CarRecallForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Recall"
                Me.lblTitle.Text = "Car Recall"
                Me.lblUser.Text = "Car Rider:"
                Me.lblPrompt.Text = "Are you sure you" & vbCrLf & "want to recall your car?"
                Me.imgProfilePicture.Image = bookingEvent.GetProfilePicture
                Me.lblName.Text = bookingEvent.GetName

                Me.btnConfirm.Visible = True
                Me.btnCancel.Visible = True
                Me.btnOk.Visible = False
            Case "rider"
                Me.Text = "Car Rider Car Recall"
                Me.lblTitle.Text = "Car Recall"
                Me.lblUser.Text = "Car Owner:"
                Me.lblPrompt.Text = "Your ride has been recalled." & vbCrLf & "Please exit the vehicle."
                Me.imgProfilePicture.Image = bookingEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = bookingEvent.GetCarOwnerName

                Me.btnConfirm.Visible = False
                Me.btnCancel.Visible = False
                Me.btnOk.Visible = True
        End Select

        Me.lblCar.Text = Me.bookingEvent.GetColour & " " & Me.bookingEvent.GetCar

        Dim startTime = Format(Me.bookingEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(Me.bookingEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime
    End Sub

    ' ---------------
    ' --- Buttons ---
    ' ---------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim ownerConfirmForm = New CarRecallForm("rider", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
        Me.Close()
        Me.devWindow.OpenPopup("rider", ownerConfirmForm)

        ' Return to home
        Me.homeWindow.Show()
        Me.devWindow.SetCurrentOwnerForm(Me.homeWindow)
        Me.homeWindow.CloseAllChildren()

        Me.cancelBooking = New ExitCarForm(Me.user, Me.scenario, Me.devWindow)
        Me.cancelBooking.lblMessage.Text = "All bookings have been canceled!"
        Me.devWindow.OpenPopup("owner", Me.cancelBooking)

        Me.riderRebook = New RescheduleNotification("rider", Me.scenario, Me.devWindow, Me.homeWindow)
        Me.riderRebook.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(358, 375)
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