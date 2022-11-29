Public Class CalendarRouteForm
    Inherits AppForm

    Dim bookingEvent As UserCalendarEvent
    Dim previousBooking As UserCalendarEvent

    Dim stopNum As Integer

    ' Children
    Dim confirmForm As CalendarConfirmForm
    Dim requestForm As BookingRequestForm
    Dim responseForm As BookingRequestResponseForm
    Public Sub New(user As String, scenario As Integer, previousWindow As AppForm, homeWindow As HomeForm, devWindow As DevForm, startDate As Date, bookingEvent As UserCalendarEvent, Optional previousBooking As UserCalendarEvent = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousWindow
        Me.homeWindow = homeWindow
        Me.devWindow = devWindow

        Me.stopNum = 0

        ' Booking
        Me.bookingEvent = bookingEvent
        Me.previousBooking = previousBooking
    End Sub

    Private Sub CalendarRouteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Select Route"
            Case "rider"
                Me.Text = "Car Rider Select Route"
        End Select

        ' Add Title and Home button
        Me.SetBackground()
        Me.CreateTitleLabel("Select Route")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        ' Book Button
        If Me.user = "owner" Then
            Me.btnBook.Text = "Recall Car"
        End If

        Me.cmbxStart.Text = Me.bookingEvent.GetStartLocation
        Me.cmbxEnd.Text = Me.bookingEvent.GetEndLocation

        Me.StopOneVisible(False)
        Me.StopTwoVisible(False)

    End Sub

    ' -----------------
    ' --- Functions ---
    ' -----------------

    Public Sub ConfirmClicked()
        ' Remove previous booking if there
        If Me.previousBooking IsNot Nothing Then
            Me.devWindow.RemoveBooking(Me.previousBooking)
        End If

        Me.Hide()
        Me.homeWindow.Show()
        Me.SetCurrentForm(Me.homeWindow)

        ' Send request to Owner
        If Me.bookingEvent.GetCarOwnerName = "Jane Doe" Then
            Me.requestForm = New BookingRequestForm("owner", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent, Me.GetStopsArr)
            Me.devWindow.OpenPopup("owner", Me.requestForm)
        Else
            Me.responseForm = New BookingRequestResponseForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent, "accept")
            Me.devWindow.OpenPopup(Me.user, Me.responseForm)
            'Add booking
            Me.devWindow.AddBooking(Me.bookingEvent)
        End If

        Me.homeWindow.CloseAllChildren()
    End Sub

    Public Sub CancelClicked()

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.confirmForm IsNot Nothing) Then
            Me.confirmForm.Dispose()
        End If

        If (Me.requestForm IsNot Nothing) Then
            Me.requestForm.Dispose()
        End If

        If (Me.responseForm IsNot Nothing) Then
            Me.responseForm.Dispose()
        End If
    End Sub

    Private Sub StopOneVisible(visible As Boolean)
        Me.imgStopOne.Visible = visible
        Me.lblStopOne.Visible = visible
        Me.cmbxStopOne.Visible = visible
    End Sub

    Private Sub StopTwoVisible(visible As Boolean)
        Me.imgStopTwo.Visible = visible
        Me.lblStopTwo.Visible = visible
        Me.cmbxStopTwo.Visible = visible
    End Sub

    Private Sub ChangeStopNumber(change As Integer)
        Me.stopNum += change

        Select Case Me.stopNum
            Case 0
                Me.StopOneVisible(False)
                Me.StopTwoVisible(False)
                Me.imgPlus.Enabled = True
            Case 1
                Me.StopOneVisible(True)
                Me.StopTwoVisible(False)
                Me.imgPlus.Enabled = True
            Case 2
                Me.StopOneVisible(True)
                Me.StopTwoVisible(True)
                Me.imgPlus.Enabled = False
        End Select
    End Sub

    Private Function GetStopsArr() As String()
        Dim stopArr() As String
        stopArr = New String() {Me.cmbxStopOne.Text, Me.cmbxStopTwo.Text}
        Return stopArr
    End Function

    ' --------------
    ' --- Button ---
    ' --------------
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Me.bookingEvent.SetLocations(Me.cmbxStart.Text, Me.cmbxEnd.Text)
        Dim eta = Me.devWindow.GetETA(Me.cmbxStart.Text, Me.cmbxEnd.Text)
        Me.bookingEvent.SetEndDate(Me.bookingEvent.GetStartDate.AddMinutes(eta))

        Me.confirmForm = New CalendarConfirmForm(Me.bookingEvent, Me.user, Me.devWindow, Me.GetStopsArr())
        Me.confirmForm.SetBookingForm(Me)

        Me.devWindow.OpenPopup(Me.user, Me.confirmForm)
    End Sub

    ' -----------------
    ' --- Locations ---
    ' -----------------

    Private Sub cmbx_TextChanged(sender As Object, e As EventArgs) Handles cmbxStart.TextChanged, cmbxEnd.TextChanged
        If Me.cmbxStart.Text <> "" And Me.cmbxEnd.Text <> "" Then
            Me.btnBook.Enabled = True
            Me.txtEta.Text = Me.devWindow.GetETA(Me.cmbxStart.Text, Me.cmbxEnd.Text) & " minutes"
            Me.txtPrice.Text = "$" & Me.devWindow.GetCost(Me.cmbxStart.Text, Me.cmbxEnd.Text)
        End If
    End Sub

    ' ------------
    ' --- Plus ---
    ' ------------

    Private Sub imgPlus_Click(sender As Object, e As EventArgs) Handles imgPlus.Click
        Me.ChangeStopNumber(1)
    End Sub

    Private Sub imgPlus_MouseEnter(sender As Object, e As EventArgs) Handles imgPlus.MouseEnter
        Me.imgPlus.Image = My.Resources.Plus___Hover
    End Sub

    Private Sub imgPlus_MouseLeave(sender As Object, e As EventArgs) Handles imgPlus.MouseLeave
        Me.imgPlus.Image = My.Resources.Plus
    End Sub

    ' -------------
    ' --- Minus ---
    ' -------------

    Private Sub imgStop_Click(sender As Object, e As EventArgs) Handles imgStopOne.Click, imgStopTwo.Click
        Dim currImg As PictureBox = CType(sender, PictureBox)

        If (currImg Is imgStopOne) And (imgStopTwo.Visible = True) Then
            cmbxStopOne.Text = cmbxStopTwo.Text
            cmbxStopTwo.SelectedItem = Nothing
        ElseIf (currImg Is imgStopOne) And (imgStopTwo.Visible = False) Then
            cmbxStopOne.SelectedItem = Nothing
        ElseIf currImg Is imgStopTwo Then
            cmbxStopTwo.SelectedItem = Nothing
        End If

        Me.ChangeStopNumber(-1)
    End Sub

    Private Sub imgStop_MouseEnter(sender As Object, e As EventArgs) Handles imgStopOne.MouseEnter, imgStopTwo.MouseEnter
        CType(sender, PictureBox).Image = My.Resources.Minus___Hover
    End Sub

    Private Sub imgStop_MouseLeave(sender As Object, e As EventArgs) Handles imgStopOne.MouseLeave, imgStopTwo.MouseLeave
        CType(sender, PictureBox).Image = My.Resources.Minus
    End Sub


End Class