﻿Imports System.Threading

Public Class DevForm

    Dim ownerWindow As HomeForm
    Dim riderWindow As HomeForm

    Dim currentOwnerForm As AppForm
    Dim currentRiderForm As AppForm

    Dim ownerScheduleList As List(Of UserCalendarEvent)

    Private Sub DevForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.CreateOwnerSchedules()
    End Sub

    Private Sub btnScenario_Click(sender As Object, e As EventArgs) Handles _
        btnScenarioOne.Click, btnScenarioTwo.Click,
        btnScenarioThree.Click, btnScenarioFour.Click,
        btnScenarioFive.Click, btnScenarioSix.Click

        ' If other windows are open, close them
        If (ownerWindow IsNot Nothing) Or (riderWindow IsNot Nothing) Then
            Me.ownerWindow.CloseAllForms()
            Me.riderWindow.CloseAllForms()
        End If

        ' Open new windows
        Me.ownerWindow = New HomeForm("owner", CType(sender, Button).Tag, Me)
        Me.riderWindow = New HomeForm("rider", CType(sender, Button).Tag, Me)
        Me.ownerWindow.addOtherForm(riderWindow)
        Me.riderWindow.addOtherForm(ownerWindow)
        Me.ownerWindow.Show()
        Me.riderWindow.Show()
    End Sub

    Public Sub SetCurrentOwnerForm(form As AppForm)
        Me.currentOwnerForm = form
    End Sub

    Public Sub SetCurrentRiderForm(form As AppForm)
        Me.currentRiderForm = form
    End Sub

    Public Shared Function GetFormWidth() As Integer
        Return 500
    End Function

    Public Shared Function GetFormHeight() As Integer
        Return 1000
    End Function

    Public Shared Function GetDevWidth() As Integer
        Return DevForm.Width
    End Function

    ' ----------------------------
    ' --- Booking / Scheduling ---
    ' ----------------------------

    Private Sub CreateOwnerSchedules()
        Dim startDate = New Date(2022, 11, 26, 11, 0, 0)
        Dim endDate = New Date(2022, 11, 26, 12, 0, 0)

        Dim ownerOne = New UserCalendarEvent(My.Resources.RandomProfileOne, "Eric Holme", "owner", "Hyundai Ioniq 6", "Red", 2, startDate, endDate)
        Dim ownerTwo = New UserCalendarEvent(My.Resources.RandomProfileTwo, "Nessa Whitney", "owner", "Tesla Model 3", "Black", 4, startDate, endDate)
        Dim ownerThr = New UserCalendarEvent(My.Resources.RandomProfileThree, "Monica Penner", "owner", "Chevrolet Bolt EV", "Grey", 5, startDate, endDate)
        Dim ownerFou = New UserCalendarEvent(My.Resources.RandomProfileFour, "Robert Kitchens", "owner", "Ford Mustang Mach-E", "White", 3, startDate, endDate)

        Me.ownerScheduleList = New List(Of UserCalendarEvent)()
        Me.ownerScheduleList.Add(ownerOne)
        Me.ownerScheduleList.Add(ownerTwo)
        Me.ownerScheduleList.Add(ownerThr)
        Me.ownerScheduleList.Add(ownerFou)
    End Sub

    Public Function AddSchedule(profilePicture As Image, userName As String, userType As String, carName As String, carColour As String, userRating As Integer, startDate As Date, endDate As Date)
        Dim newStart = startDate
        Dim newEnd = endDate
        Dim conflict = False

        ' Check if already exists
        For Each cldrEvent As UserCalendarEvent In Me.ownerScheduleList

            ' If user has schedule
            If cldrEvent.GetName() = userName Then

                Dim oldStart = cldrEvent.GetStartDate()
                Dim oldEnd = cldrEvent.GetEndDate()
                Dim oldCar = cldrEvent.GetCar()

                ' New | ⬛⬛⬛⬛   |
                ' Old |   ⬛⬛⬛⬛ |
                'newEnd later then oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newEnd, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) AndAlso (oldCar = carName) Then

                    conflict = True
                    Exit For
                End If


                ' New |   ⬛⬛⬛⬛ |
                ' Old | ⬛⬛⬛⬛   |
                'newStart later than oldStart
                'newStart earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newStart, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If

                ' New |  ⬛⬛  |
                ' Old | ⬛⬛⬛⬛ |
                'newStart earlier than oldStart
                'newEnd earlier than oldEnd
                If Me.EarlierThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If

                ' New | ⬛⬛⬛⬛ |
                ' Old |  ⬛⬛  |
                'newStart later than oldStart
                'newEnd earlier than oldEnd
                If Me.LaterThan(newStart, oldStart) AndAlso Me.EarlierThan(newEnd, oldEnd) AndAlso (oldCar = carName) Then
                    conflict = True
                    Exit For
                End If
            End If
        Next

        If conflict Then
            Return False
            Exit Function
        End If

        ' No conflict
        Dim newOwner = New UserCalendarEvent(profilePicture, userName, userType, carName, carColour, userRating, startDate, endDate)
        Me.ownerScheduleList.Add(newOwner)
        Return True

    End Function

    Private Function EarlierThan(dateOne As Date, dateTwo As Date)
        Return (dateOne.CompareTo(dateTwo) <= 0)
    End Function

    Private Function LaterThan(dateOne As Date, dateTwo As Date)
        Return (dateOne.CompareTo(dateTwo) >= 0)
    End Function

    ' --------------
    ' --- Popups ---
    ' --------------
    Public Sub OpenPopup(user As String, popup As Form)
        Select Case user
            Case "owner"
                currentOwnerForm.CreateDimOverlay()
                currentOwnerForm.DimScreen()
            Case "rider"
                currentRiderForm.CreateDimOverlay()
                currentRiderForm.DimScreen()
        End Select
        popup.Show()
        popup.TopMost = True
    End Sub

    Public Sub ClosePopup(user As String)
        Select Case user
            Case "owner"
                currentOwnerForm.UnDimScreen()
            Case "rider"
                currentRiderForm.UnDimScreen()
        End Select
    End Sub

End Class