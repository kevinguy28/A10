Imports System.Diagnostics.Contracts
Imports System.Reflection.Metadata.Ecma335

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

    ' Children
    Dim confirmForm As CalendarCarConfirmForm

    Dim colourNeutral = Color.FromArgb(151, 203, 197)

    Public Sub New(user As String, scenario As Integer, previousForm As AppForm, HomeForm As HomeForm, DevForm As DevForm, dateStart As Date, dateEnd As Date)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' AppForm
        Me.user = user
        Me.scenario = scenario
        Me.previousWindow = previousForm
        Me.homeWindow = HomeForm
        Me.devWindow = DevForm

        ' Date
        Me.dateStart = dateStart
        Me.dateEnd = dateEnd
    End Sub

    Private Sub CalendarCarSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.carAvailability = Me.devWindow.GetAvailability(Me.dateStart, Me.dateEnd)
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
        If Not avbltyExists Then
            Me.lblTop.Visible = False
            Me.lblLeft.Visible = False
            Me.lblRight.Visible = False
            Me.lblBottom.Visible = False
        End If
        Me.lblName.Text = ""
        Me.lblCar.Text = ""
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
        Me.btnBook.Enabled = True
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

        Me.confirmForm = New CalendarCarConfirmForm(Me.bookingEvent, Me, Me.user, Me.devWindow)

        Me.devWindow.OpenPopup(Me.user, Me.confirmForm)
    End Sub

    Public Sub ConfirmClicked()
        Me.devWindow.AddBooking(Me.bookingEvent.GetProfilePicture, Me.bookingEvent.GetName, Me.bookingEvent.GetUserType,
                                Me.bookingEvent.GetCar, Me.bookingEvent.GetColour, Me.bookingEvent.GetRatingInt,
                                Me.bookingEvent.GetStartDate, Me.bookingEvent.GetEndDate,
                                Me.bookingEvent.GetCarOwnerName, Me.bookingEvent.GetCarOwnerProfilePicture)
        Me.Close()
        Me.homeWindow.Show()
        Me.SetCurrentForm(Me.homeWindow)
        Me.homeWindow.CloseAllChildren()
    End Sub

    Public Sub CancelClicked()

    End Sub

    Public Overrides Sub CloseAllChildren()
        If (Me.confirmForm IsNot Nothing) Then
            Me.confirmForm.Dispose()
        End If
    End Sub
End Class