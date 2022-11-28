Imports System.ComponentModel
Imports System.Diagnostics.Contracts
Imports System.Reflection.Metadata.Ecma335
Imports System.Threading

Public Class CalendarCarSelectForm
    Inherits AppForm

    Dim dateStart As Date

    Dim carAvailability As List(Of UserCalendarEvent)
    Dim itemList As List(Of CarListControl)

    Dim avbltyExists = False

    Dim selectedItem As CarListControl
    Dim selectedEvent As UserCalendarEvent

    Dim bookingEvent As UserCalendarEvent
    Dim previousEvent As UserCalendarEvent

    ' Children
    'Dim confirmForm As CalendarConfirmForm
    'Dim requestForm As BookingRequestForm
    'Dim responseForm As BookingRequestResponseForm
    Dim routeWindow As RouteForm

    Dim colourNeutral = Color.FromArgb(151, 203, 197)

    ' Error Shake
    Dim WithEvents backgroundWorker As BackgroundWorker

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, HomeForm As HomeForm, DevForm As DevForm, dateStart As Date, Optional previousEvent As UserCalendarEvent = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = HomeForm
        Me.devWindow = DevForm

        ' Previous Event
        Me.previousEvent = previousEvent

        ' Date
        Me.dateStart = dateStart
    End Sub

    Private Sub CalendarCarSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.user
            Case "owner"
                Me.Text = "Car Owner Car Selection"
            Case "rider"
                Me.Text = "Car Rider Car Selection"
        End Select

        ' Add Title, Home, Plus and Back buttons
        Me.SetBackground()
        Me.CreateTitleLabel("Select Your Ride")
        Me.CreateHomeButton()
        Me.CreateBackButton()
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)

        Dim startTime = Format(dateStart, "ddd d MMM yyyy") & " at " & Format(dateStart, "h:mm tt")
        Dim endTime = Format(dateStart.AddMinutes(10), "ddd d MMM yyyy") & " at " & Format(dateStart.AddMinutes(10), "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        ' Availability
        Me.carAvailability = Me.devWindow.GetAllAvailabilities(Me.dateStart, Me.dateStart.AddMinutes(10))
        If Me.carAvailability.Count <> 0 Then
            Me.avbltyExists = True
        End If

        ' Panel
        If avbltyExists Then
            Me.PopulatePanelView()
        Else
            Me.lblNoAvblty.Top = Me.flPanel.Top + 10
            Me.lblNoAvblty.Visible = True
        End If

        ' Setup
        Me.lblName.Text = ""
        Me.lblCar.Text = ""
        Me.lblTop.Visible = False
        Me.lblLeft.Visible = False
        Me.lblRight.Visible = False
        Me.lblBottom.Visible = False
        Me.btnBook.BackColor = colourNeutral
        Me.lblTop.BackColor = colourNeutral
        Me.lblLeft.BackColor = colourNeutral
        Me.lblRight.BackColor = colourNeutral
        Me.lblBottom.BackColor = colourNeutral

        ' Background Worker
        Me.backgroundWorker = New BackgroundWorker()

    End Sub

    Private Sub PopulatePanelView()

        Me.itemList = New List(Of CarListControl)

        For Each carAvblty As UserCalendarEvent In Me.carAvailability
            Dim itm As CarListControl
            itm = New CarListControl(carAvblty, Me)
            Me.itemList.Add(itm)
            Me.flPanel.Controls.Add(itm)
        Next

    End Sub

    Public Sub ControlClicked(itm As CarListControl)
        For Each ctrl As CarListControl In Me.itemList
            ctrl.DeselectItem()
        Next
        'Make controls visable
        Me.btnBook.Enabled = True
        Me.lblTop.Visible = True
        Me.lblLeft.Visible = True
        Me.lblRight.Visible = True
        Me.lblBottom.Visible = True

        itm.SelectItem()
        Me.selectedItem = itm
        Me.selectedEvent = itm.GetEvent()

        Me.imgProfilePicture.Image = Me.selectedEvent.GetProfilePicture()

        Me.lblName.Text = Me.selectedEvent.GetName()
        Me.lblCar.Text = Me.selectedEvent.GetColour & " " & Me.selectedEvent.GetCar()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Me.bookingEvent = New UserCalendarEvent(My.Resources.RiderProfile, "John Smith", "rider",
                                                Me.selectedEvent.GetCar, Me.selectedEvent.GetColour, Me.selectedEvent.GetRatingInt,
                                                Me.dateStart, Me.dateStart.AddMinutes(10))

        Me.bookingEvent.OwnerFound(Me.selectedEvent.GetName, Me.selectedEvent.GetProfilePicture)

        'Check for conflict
        Dim err = Me.devWindow.CheckRiderBookingConflict(Me.bookingEvent.GetStartDate, Me.bookingEvent.GetEndDate)

        'If error
        If (err) Then
            Me.ShakeErrorMessage("You already have a booking at this time")
            Exit Sub
        End If

        Me.routeWindow = New RouteForm(Me.user, Me.scenario, Me, Me.homeWindow, Me.devWindow, Me.dateStart, Me.bookingEvent, Me.previousEvent)
        Me.Hide()
        Me.SetCurrentForm(Me.routeWindow)
        Me.routeWindow.Show()
    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.routeWindow IsNot Nothing) Then
            Me.routeWindow.Dispose()
        End If
    End Sub

    ' -------------
    ' --- Shake ---
    ' -------------
    Private Sub ShakeErrorMessage(errorText As String)
        Me.lblError.Text = errorText
        Me.lblError.Visible = True
        Me.lblError.BringToFront()
        If Me.backgroundWorker.IsBusy() = False Then
            Me.lblError.Location = New Point((Me.Width / 2) - (Me.lblError.Width / 2) - 18, Me.lblError.Top)
            Me.backgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker.DoWork
        Dim shakeArr() = {1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1}

        Try
            ' Shake
            For fullShake As Integer = 0 To 3
                For moveIndex As Integer = 0 To shakeArr.Length() - 1
                    'Move
                    If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() lblError.Left += shakeArr(moveIndex)) _
                    Else lblError.Left += shakeArr(moveIndex)

                    'Wait
                    If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                    Else Me.lblError.Refresh()
                    Threading.Thread.Sleep(10)
                Next
            Next

            ' Pause
            For pause As Integer = 0 To 150
                'Wait
                If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                Else Me.lblError.Refresh()
                Threading.Thread.Sleep(10)
            Next

            If (Not lblError.IsDisposed) AndAlso (lblError.InvokeRequired) Then lblError.Invoke(Sub() Me.lblError.Visible = False) _
            Else Me.lblError.Visible = False
        Catch ex As Exception
        End Try

    End Sub

End Class