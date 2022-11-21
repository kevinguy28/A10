Public Class CalendarCarConfirmForm

    Dim usrEvent As UserCalendarEvent
    Dim previousForm As CalendarCarSelectForm

    Dim user As String
    Dim devWindow As DevForm

    Public Sub New(usrEvent As UserCalendarEvent, previousForm As CalendarCarSelectForm, user As String, devWindow As DevForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.previousForm = previousForm
        'Me.Parent = previousForm
        Me.user = user
        Me.devWindow = devWindow
    End Sub

    Private Sub CalendarCarConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.imgProfilePicture.Image = usrEvent.GetCarOwnerProfilePicture
        Me.lblName.Text = usrEvent.GetCarOwnerName
        Me.lblCar.Text = usrEvent.GetColour & " " & Me.usrEvent.GetCar

        Dim startTime = Format(usrEvent.GetStartDate, "ddd d MMM yyyy") & " at " & Format(usrEvent.GetStartDate, "h:mm tt")
        Dim endTime = Format(usrEvent.GetEndDate, "ddd d MMM yyyy") & " at " & Format(usrEvent.GetEndDate, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime
    End Sub

    ' ------------------------
    ' --- Buttons Clicked ---
    ' ------------------------

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.previousForm.ConfirmClicked()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.previousForm.CancelClicked()
        Me.Close()
    End Sub

    ' -------------------------
    ' --- Size and Location ---
    ' -------------------------

    Private Sub CalendarCarConfirmForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(350, 346)
    End Sub

    Private Sub CalendarCarConfirmForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim x = Me.previousForm.Location.X + ((Me.previousForm.Width / 2) - (Me.Width / 2))
        Dim y = Me.previousForm.Location.Y + ((Me.previousForm.Height / 2) - (Me.Height / 2))
        Me.Location = New Size(x, y)
    End Sub

    ' ----------------
    ' --- On Close ---
    ' ----------------
    Private Sub CalendarCarConfirmForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.devWindow.ClosePopup(Me.user)
    End Sub

End Class