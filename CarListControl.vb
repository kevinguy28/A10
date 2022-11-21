Public Class CarListControl
    Dim usrEvent As UserCalendarEvent
    Dim previousForm As CalendarCarSelectForm

    Dim expanded = False
    Dim collapsedHeight = 50
    Dim expandedHeight = 171

    Dim colourNeutral = Color.FromArgb(151, 203, 197)
    Dim colourBlack = Color.FromKnownColor(KnownColor.ControlText)

    Public Sub New(usrEvent As UserCalendarEvent, previousForm As CalendarCarSelectForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.previousForm = previousForm

        Me.imgProfile.Image = Me.usrEvent.GetProfilePicture
        Me.imgProfile.SizeMode = PictureBoxSizeMode.StretchImage

        Me.lblName.Text = Me.usrEvent.GetName

        Me.imgRating.Image = Me.usrEvent.GetRatingImg
        Me.imgRating.SizeMode = PictureBoxSizeMode.StretchImage

        Me.lblCar.Text = Me.usrEvent.GetColour() & " " & Me.usrEvent.GetCar()

        Dim startText = Format(Me.usrEvent.GetStartDate, "dddd d MMMM yyyy") & " at " & Format(Me.usrEvent.GetStartDate, "h:mm tt")
        Dim endText = Format(Me.usrEvent.GetEndDate, "dddd d MMMM yyyy") & " at " & Format(Me.usrEvent.GetEndDate, "h:mm tt")

        Me.lblAvblty.Text = "Available from " & vbCrLf & startText & vbCrLf & " to " & vbCrLf & endText
    End Sub

    Private Sub CarListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = collapsedHeight
    End Sub

    Private Sub CarListControl_Click(sender As Object, e As EventArgs) Handles _
        Me.Click, lblName.Click, lblCar.Click, lblAvblty.Click, imgProfile.Click, imgRating.Click

    End Sub

    Private Sub imgArrow_Click(sender As Object, e As EventArgs) Handles imgArrow.Click
        If expanded Then
            expanded = False
            Me.Height = collapsedHeight
        Else
            expanded = True
            Me.Height = expandedHeight
        End If
    End Sub

    Public Sub SelectItem()
        Me.lblName.ForeColor = colourNeutral
        Me.lblCar.ForeColor = colourNeutral
        Me.lblAvblty.ForeColor = colourNeutral
    End Sub

    Public Sub DeselectItem()
        Me.lblName.ForeColor = colourBlack
        Me.lblCar.ForeColor = colourBlack
        Me.lblAvblty.ForeColor = colourBlack
    End Sub

    Private Sub imgArrow_MouseEnter(sender As Object, e As EventArgs) Handles imgArrow.MouseEnter
        Me.imgArrow.Image = My.Resources.ArrowDown___Hover
    End Sub

    Private Sub imgArrow_MouseLeave(sender As Object, e As EventArgs) Handles imgArrow.MouseLeave
        Me.imgArrow.Image = My.Resources.ArrowDown
    End Sub

End Class
