Imports System.Threading

Public Class BookingRequestForm

    Dim user As String
    Dim scenario As Integer
    Dim homeWindow As HomeForm
    Dim devWindow As DevForm

    Dim bookingEvent As UserCalendarEvent
    Dim responseForm As BookingRequestResponseForm

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

    Private Sub BookingRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.lblPrice.Text = ""

        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner"
                Me.lblPrice.Text += "Earnings: $"
            Case "rider"
                Me.Text = "Car Rider"
                Me.lblPrice.Text += "Price: $"
        End Select

        Me.lblPrompt.Text = "This user wants to book your" & vbCrLf & Me.bookingEvent.GetColour & " " & Me.bookingEvent.GetCar
        Me.lblUser.Text = "Car Rider:"
        Me.imgProfilePicture.Image = Me.bookingEvent.GetProfilePicture()
        Me.lblName.Text = Me.bookingEvent.GetName
        Me.imgRating.Image = Me.bookingEvent.GetRatingImg

        Dim startTime = Format(Me.bookingEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(Me.bookingEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(Me.bookingEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        Me.lblLocation.Text = Me.bookingEvent.GetStartLocation & vbCrLf & Me.bookingEvent.GetEndLocation

        Me.lblPrice.Text += "" & Me.devWindow.GetCost(Me.bookingEvent.GetStartLocation, Me.bookingEvent.GetEndLocation)
    End Sub

    ' ----------------
    ' --- Buttons ---
    ' ----------------

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Me.responseForm = New BookingRequestResponseForm("rider", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent, "accept")
        Me.devWindow.OpenPopup("rider", Me.responseForm)

        'Add booking
        Me.devWindow.AddBooking(Me.bookingEvent)

        Me.Close()
    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        Me.responseForm = New BookingRequestResponseForm("rider", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent, "deny")
        Me.devWindow.OpenPopup("rider", Me.responseForm)

        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(340, 470)
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