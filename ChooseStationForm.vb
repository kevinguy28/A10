﻿Imports System.Security.Authentication.ExtendedProtection

Public Class ChooseStationForm
    Dim user As String
    Dim scenario As Integer
    Dim otherForm As HomeForm
    Public Sub New(user As String, scenario As Integer, otherForm As HomeForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user : Me.scenario = scenario : Me.otherForm = otherForm
    End Sub

    Public Sub setLocation()
        Dim fullScreen = Screen.PrimaryScreen.WorkingArea.Width
        Dim halfScreen = fullScreen / 2
        Dim halfDev = DevForm.GetDevWidth() / 2
        Dim halfForm = DevForm.GetFormWidth() / 2

        If Me.user = "rider" Then
            Dim x = ((halfScreen - halfDev) / 2) - halfForm
            Me.Location = New Point(x, 0)

        ElseIf Me.user = "owner" Then
            Dim x = (fullScreen - ((halfScreen - halfDev) / 2)) - halfForm
            Me.Location = New Point(x, 0)
        End If
    End Sub

    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rb1.CheckedChanged, rb2.CheckedChanged, rb3.CheckedChanged, rb4.CheckedChanged, rb5.CheckedChanged, rb6.CheckedChanged
        If DirectCast(sender, RadioButton).Checked = True Then
            DirectCast(sender, RadioButton).BackColor = Color.Green
            Me.lblStationAddress.Text = DirectCast(sender, RadioButton).Tag
        Else
            DirectCast(sender, RadioButton).BackColor = Color.Red
        End If
    End Sub

    Private Sub ChooseStationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblStationAddress.Text = rb1.Text
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub rb1_Click(sender As Object, e As EventArgs) Handles rb1.Click
        Me.pbMap.Image = My.Resources.the_map_rb1
    End Sub

    Private Sub rb2_Click(sender As Object, e As EventArgs) Handles rb2.Click
        Me.pbMap.Image = My.Resources.the_map_rb2
    End Sub
    Private Sub rb3_Click(sender As Object, e As EventArgs) Handles rb3.Click
        Me.pbMap.Image = My.Resources.the_map_rb3
    End Sub

    Private Sub rb4_Click(sender As Object, e As EventArgs) Handles rb4.Click
        Me.pbMap.Image = My.Resources.the_map_rb4
    End Sub

    Private Sub rb5_Click(sender As Object, e As EventArgs) Handles rb5.Click
        Me.pbMap.Image = My.Resources.the_map_rb5
    End Sub

    Private Sub rb6_Click(sender As Object, e As EventArgs) Handles rb6.Click
        Me.pbMap.Image = My.Resources.the_map_rb6
    End Sub
End Class