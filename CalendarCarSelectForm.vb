Imports System.Diagnostics.Contracts
Imports System.Reflection.Metadata.Ecma335

Public Class CalendarCarSelectForm
    Inherits AppForm

    Dim dateStart As Date
    Dim dateEnd As Date

    Dim carAvailability As List(Of UserCalendarEvent)
    Dim itemList As List(Of CarListControl)

    Dim selectedItem As CarListControl
    Dim selectedEvent As UserCalendarEvent

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

        ' Panel
        Me.PopulatePanelView()

        ' Setup
        Me.lblName.Text = ""
        Me.lblCar.Text = ""
        Me.btnBook.BackColor = colourNeutral
        Me.lblTop.BackColor = colourNeutral
        Me.lblLeft.BackColor = colourNeutral
        Me.lblRight.BackColor = colourNeutral

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
        itm.SelectItem()
        Me.selectedItem = itm
        Me.selectedEvent = itm.GetEvent()

        Me.lblPrompt.Visible = True
        Me.imgProfilePicture.Image = Me.selectedEvent.GetProfilePicture()

        Me.lblName.Text = Me.selectedEvent.GetName()
        Me.lblCar.Text = Me.selectedEvent.GetColour & " " & Me.selectedEvent.GetCar()

    End Sub


    '' --- Car ---
    'Dim lblCar As Label

    'Dim lblCarPrompt As Label
    'Dim lstvwSelected As ListView
    'Dim WithEvents btnCarSelect As Button

    'Dim lstvwCar As ListView

    'Private Sub CreateCar()
    '    'Dim lblCar As Label

    '    'Dim lblCarPrompt As Label
    '    'Dim lstvwSelected As ListView
    '    'Dim WithEvents btnCarSelect As Button

    '    'Dim lstvwCar As ListView

    '    ' lblCar
    '    Me.lblCar = New Label()
    '    Me.lblCar.Text = "Car"
    '    Me.lblCar.TextAlign = headingTextAlign
    '    Me.lblCar.Font = headingFont
    '    Me.lblCar.Size = headingSize
    '    Me.lblCar.AutoSize = False
    '    Me.lblCar.Margin = headingPadding
    '    Me.lblCar.BackColor = colourNeutral
    '    Me.lblCar.ForeColor = colourWhite

    '    ' lblCarPrompt
    '    Me.lblCarPrompt = New Label
    '    Me.lblCarPrompt.Text = "Select a car to book:"
    '    Me.lblCarPrompt.Font = bodyFont
    '    Me.lblCarPrompt.AutoSize = True
    '    Me.lblCarPrompt.Margin = leftPadding

    'End Sub


End Class