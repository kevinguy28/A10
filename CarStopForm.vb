Imports System.Buffers

Public Class CarStopForm
    Dim user As String
    Dim scenario As Integer
    Dim homeWindow As HomeForm
    Dim devWindow As DevForm

    Dim bookingEvent As UserCalendarEvent
    Public Sub New(user As String, scenario As Integer, homeWindow As HomeForm, devWindow As DevForm)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.scenario = scenario
        Me.homeWindow = homeWindow
        Me.devWindow = devWindow

        Me.bookingEvent = Me.devWindow.GetCurrentBooking()

        Me.Form_Resize(Nothing, Nothing)
        Me.Form_LocationChanged(Nothing, Nothing)
    End Sub

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Booking
        Me.bookingEvent = Me.devWindow.GetCurrentBooking()

        Select Case Me.user
            Case "owner"
                'Labels
                Me.Text = "Car Owner Car Stopped"
                Me.lblTitle.Text = "Your Car Has Stopped"
                Me.lblPrompt.Text = "Your car has stopped." & vbCrLf & "Contact the rider for more information."
                Me.lblUser.Text = "Car Rider:"

                'Booking
                Me.imgProfilePicture.Image = bookingEvent.GetProfilePicture
                Me.lblName.Text = bookingEvent.GetName

                'Buttons
                Me.btnConfirm.Visible = False
                Me.btnCancel.Visible = False
                Me.btnOk.Visible = True

            Case "rider"
                'Labels
                Me.Text = "Car Rider Stop Confirm"
                Me.lblTitle.Text = "Emergency Stop"
                Me.lblPrompt.Text = "Are you sure you" & vbCrLf & "want to stop the car?"
                Me.lblUser.Text = "Car Owner:"

                'Booking
                Me.imgProfilePicture.Image = bookingEvent.GetCarOwnerProfilePicture
                Me.lblName.Text = bookingEvent.GetCarOwnerName

                'Buttons
                Me.btnConfirm.Visible = True
                Me.btnCancel.Visible = True
                Me.btnOk.Visible = False
        End Select

        'Booking
        Me.lblCar.Text = Me.bookingEvent.GetColour & " " & Me.bookingEvent.GetCar

        Dim startTime = Format(Me.bookingEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(Me.bookingEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

    End Sub

    Public Sub changeTitle(title As String)
        Me.lblTitle.Text = title
    End Sub

    Public Sub changeDescription(description As String)
        Me.lblDescription.Text = description
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Me.bookingEvent.GetCarOwnerName = "Jane Doe" Then
            Dim ownerForm As New CarStopForm("owner", Me.scenario, Me.homeWindow, Me.devWindow)
            Me.devWindow.OpenPopup("owner", ownerForm)
        End If
        Me.Close()
    End Sub

    Public Sub makeBtnVisible()
        Me.btnConfirm.Visible = True
        Me.btnCancel.Visible = True
        Me.btnConfirm.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(380, 378)
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