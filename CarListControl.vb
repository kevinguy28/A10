Public Class CarListControl
    Dim usrEvent As UserCalendarEvent
    Dim previousForm As CalendarCarSelectForm

    Dim collapsedHeight = 45
    Dim expandedHeight = 185

    Dim colourNeutral = Color.FromArgb(151, 203, 197)
    Dim colourWhite = Color.White
    Dim colourBlack = Color.FromKnownColor(KnownColor.ControlText)

    Public Sub New(usrEvent As UserCalendarEvent, previousForm As CalendarCarSelectForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usrEvent = usrEvent
        Me.previousForm = previousForm

        Me.lblTop.BackColor = colourNeutral

        Me.imgProfile.Image = Me.usrEvent.GetProfilePicture
        Me.imgProfile.SizeMode = PictureBoxSizeMode.StretchImage

        Me.lblName.Text = Me.usrEvent.GetName

        Me.imgRating.Image = Me.usrEvent.GetRatingImg
        Me.imgRating.SizeMode = PictureBoxSizeMode.StretchImage

        Me.lblCar.Text = Me.usrEvent.GetColour() & " " & Me.usrEvent.GetCar()

        Dim startText = Format(Me.usrEvent.GetStartDate, "ddd d MMM yyyy") & " " & Format(Me.usrEvent.GetStartDate, "h:mm tt")
        Dim endText = Format(Me.usrEvent.GetEndDate, "ddd d MMM yyyy") & " " & Format(Me.usrEvent.GetEndDate, "h:mm tt")

        Me.lblAvblty.Text = startText & vbCrLf & endText
    End Sub

    Private Sub CarListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = collapsedHeight
    End Sub

    Private Sub CarListControl_Click(sender As Object, e As EventArgs) Handles _
        Me.Click, lblName.Click, lblCar.Click, lblAvblty.Click, imgProfile.Click, imgRating.Click

        Me.previousForm.ControlClicked(Me)
    End Sub

    Public Function GetEvent()
        Return Me.usrEvent
    End Function

    Public Sub SelectItem()
        Me.Height = expandedHeight
    End Sub

    Public Sub DeselectItem()
        Me.Height = collapsedHeight
    End Sub

    Private Sub MakeBlueWhite()
        Me.BackColor = colourNeutral
        Me.imgProfile.BackColor = colourNeutral
        Me.lblName.BackColor = colourNeutral
        Me.lblName.ForeColor = colourWhite
        Me.lblCar.BackColor = colourNeutral
        Me.lblCar.ForeColor = colourWhite
        Me.lblAvblty.BackColor = colourNeutral
        Me.lblAvblty.ForeColor = colourWhite
        Me.lblAvPrompt.BackColor = colourNeutral
        Me.lblAvPrompt.ForeColor = colourWhite
        Me.lblFromPrompt.BackColor = colourNeutral
        Me.lblFromPrompt.ForeColor = colourWhite
        Me.lblToPrompt.BackColor = colourNeutral
        Me.lblToPrompt.ForeColor = colourWhite
    End Sub

    Private Sub MakeWhiteBlack()
        Me.BackColor = colourWhite
        Me.imgProfile.BackColor = colourWhite
        Me.lblName.BackColor = colourWhite
        Me.lblName.ForeColor = colourBlack
        Me.lblCar.BackColor = colourWhite
        Me.lblCar.ForeColor = colourBlack
        Me.lblAvblty.BackColor = colourWhite
        Me.lblAvblty.ForeColor = colourBlack
        Me.lblAvPrompt.BackColor = colourWhite
        Me.lblAvPrompt.ForeColor = colourBlack
        Me.lblFromPrompt.BackColor = colourWhite
        Me.lblFromPrompt.ForeColor = colourBlack
        Me.lblToPrompt.BackColor = colourWhite
        Me.lblToPrompt.ForeColor = colourBlack
    End Sub

    Private Sub CarListControl_MouseEnter(sender As Object, e As EventArgs) Handles _
        Me.MouseEnter, imgProfile.MouseEnter, imgRating.MouseEnter, lblName.MouseEnter, lblCar.MouseEnter,
        lblAvPrompt.MouseEnter, lblFromPrompt.MouseEnter, lblToPrompt.MouseEnter, lblAvblty.MouseEnter

        Me.MakeBlueWhite()
    End Sub

    Private Sub CarListControl_MouseLeave(sender As Object, e As EventArgs) Handles _
        Me.MouseLeave, imgProfile.MouseLeave, imgRating.MouseLeave, lblName.MouseLeave, lblCar.MouseLeave,
        lblAvPrompt.MouseLeave, lblFromPrompt.MouseLeave, lblToPrompt.MouseLeave, lblAvblty.MouseLeave

        Me.MakeWhiteBlack()
    End Sub
End Class
