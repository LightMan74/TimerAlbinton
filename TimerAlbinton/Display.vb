﻿Imports System.ComponentModel

Public Class Display
    Public coro As Integer = 2

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        coro = 2
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coro = 1
        Label1.ForeColor = Color.Turquoise
    End Sub

    Private Sub Display_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Label1.Width = Me.Width - 17
            Label1.Height = Me.Height - 37
        ElseIf Me.FormBorderStyle = FormBorderStyle.None Then
            Label1.Width = Me.Width
            Label1.Height = Me.Height
        End If
    End Sub

    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Label1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub COLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLORToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Label1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub HIDEBARREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HIDEBARREToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub SHOWBARREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHOWBARREToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Private Sub TOPMOSTONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOPMOSTONToolStripMenuItem.Click
        Me.TopMost = True
    End Sub

    Private Sub TOPMOStOFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOPMOStOFFToolStripMenuItem.Click
        Me.TopMost = False
    End Sub
End Class