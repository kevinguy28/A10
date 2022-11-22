Public Class CarRouteChangeForm

    Dim user As String
    Dim scenario As Integer
    Dim homeWindow As HomeForm
    Dim devWindow As DevForm

    Dim bookingEvent As UserCalendarEvent

    Public Sub New(user As String, scenario As Integer, homeWindow As HomeForm, devWindow As DevForm, bookingEvent As UserCalendarEvent)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.homeWindow = homeWindow
        Me.devWindow = devWindow
        Me.bookingEvent = bookingEvent
    End Sub

    Private Sub CarRouteChangeFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Route Change"
                Me.lblTitle.Text = "Your Car Is Moving"
                Me.lblPrompt.Text = "Your car's rider" & vbCrLf & "has changed their route."
                Me.imgProfilePicture.Image = bookingEvent.GetProfilePicture
                Me.lblName.Text = bookingEvent.GetName
                Me.lblPrice.Text = "Earnings: $11"

                Me.btnConfirm.Visible = False
                Me.btnCancel.Visible = False
                Me.btnOk.Visible = True
            Case "rider"
                Me.Text = "Car Rider Route change"
                Me.lblTitle.Text = "Route Confirmation"
                Me.lblPrompt.Text = "Are you sure you" & vbCrLf & "want to set this route?"
                Me.imgProfilePicture.Image = bookingEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = bookingEvent.GetCarOwnerName
                Me.lblPrice.Text = "Cost: $11"

                Me.btnConfirm.Visible = True
                Me.btnCancel.Visible = True
                Me.btnOk.Visible = False
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
        Dim ownerConfirmForm = New CarRouteChangeForm("owner", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
        Me.Close()
        Me.devWindow.OpenPopup("owner", ownerConfirmForm)
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

    Private Sub CalendarCarConfirmForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(358, 504)
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