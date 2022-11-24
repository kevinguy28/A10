Imports System.Diagnostics.Contracts
Imports System.Reflection.Metadata.Ecma335
Imports System.Threading

Public Class CalendarCarSelectForm
    Inherits AppForm

    Dim dateStart As Date
    Dim dateEnd As Date

    Dim carAvailability As List(Of UserCalendarEvent)
    Dim itemList As List(Of CarListControl)

    Dim avbltyExists = False

    Dim selectedItem As CarListControl
    Dim selectedEvent As UserCalendarEvent

    Dim bookingEvent As UserCalendarEvent
    Dim previousEvent As UserCalendarEvent

    ' Children
    Dim confirmForm As CalendarConfirmForm
    Dim requestForm As BookingRequestForm
    Dim responseForm As BookingRequestResponseForm

    Dim colourNeutral = Color.FromArgb(151, 203, 197)

    ' Shake
    Dim shaking = False

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, HomeForm As HomeForm, DevForm As DevForm, dateStart As Date, dateEnd As Date, Optional previousEvent As UserCalendarEvent = Nothing)

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
        Me.dateEnd = dateEnd
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
        Dim endTime = Format(dateEnd, "ddd d MMM yyyy") & " at " & Format(dateEnd, "h:mm tt")
        Me.lblTime.Text = startTime & vbCrLf & endTime

        ' Availability
        Me.carAvailability = Me.devWindow.GetAllAvailabilities(Me.dateStart, Me.dateEnd)
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
                                                dateStart, dateEnd)
        Me.bookingEvent.OwnerFound(Me.selectedEvent.GetName, Me.selectedEvent.GetProfilePicture)

        Me.confirmForm = New CalendarConfirmForm(Me.bookingEvent, Me.user, Me.devWindow)
        Me.confirmForm.SetBookingForm(Me)

        Me.devWindow.OpenPopup(Me.user, Me.confirmForm)
    End Sub

    Public Sub ConfirmClicked()
        ' Remove previous booking if there
        If Me.previousEvent IsNot Nothing Then
            Me.devWindow.RemoveBooking(Me.previousEvent)
        End If

        'Check for conflict
        Dim err = Me.devWindow.CheckRiderBookingConflict(Me.bookingEvent.GetStartDate, Me.bookingEvent.GetEndDate)

        ' If error
        If (err) And (Me.shaking = False) Then
            Me.lblError.Visible = True
            Me.lblError.BringToFront()
            Me.lblError.Text = "You already have a booking at this time"
            Me.lblError.Location = New Point((Me.Width / 2) - (Me.lblError.Width / 2) - 18, Me.lblError.Top)
            Me.shaking = True
            Dim t1 As Thread = New Thread(New ThreadStart(AddressOf Me.ShakeErrorMessage))
            t1.Start()
            Exit Sub
        End If

        Me.Close()
        Me.homeWindow.Show()
        Me.SetCurrentForm(Me.homeWindow)

        ' Send request to Owner
        If Me.bookingEvent.GetCarOwnerName = "Jane Doe" Then
            Me.requestForm = New BookingRequestForm("owner", Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent)
            Me.devWindow.OpenPopup("owner", Me.requestForm)
        Else
            Me.responseForm = New BookingRequestResponseForm(Me.user, Me.scenario, Me.homeWindow, Me.devWindow, Me.bookingEvent, "accept")
            Me.devWindow.OpenPopup(Me.user, Me.responseForm)
        End If

        Me.homeWindow.CloseAllChildren()
    End Sub

    Public Sub CancelClicked()

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.confirmForm IsNot Nothing) Then
            Me.confirmForm.Dispose()
        End If
    End Sub

    ' -------------
    ' --- Shake ---
    ' -------------

    Private Sub ShakeErrorMessage()
        Dim shakeArr() = {1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1}

        ' Shake
        For fullShake As Integer = 0 To 3
            For moveIndex As Integer = 0 To shakeArr.Length() - 1
                'Move
                If lblError.InvokeRequired Then lblError.Invoke(Sub() lblError.Left += shakeArr(moveIndex)) _
                Else lblError.Left += shakeArr(moveIndex)

                'Wait
                If lblError.InvokeRequired Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
                Else Me.lblError.Refresh()
                Threading.Thread.Sleep(10)
            Next
        Next

        ' Pause
        For pause As Integer = 0 To 150
            'Wait
            If lblError.InvokeRequired Then lblError.Invoke(Sub() Me.lblError.Refresh()) _
            Else Me.lblError.Refresh()
            Threading.Thread.Sleep(10)
        Next

        Me.shaking = False
        If lblError.InvokeRequired Then lblError.Invoke(Sub() Me.lblError.Visible = False) _
        Else Me.lblError.Visible = False
    End Sub

End Class