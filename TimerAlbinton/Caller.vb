Imports System.IO
Public Class Caller

    Private Sub CHKListsolutions_MouseClick(sender As Object, e As MouseEventArgs) Handles CheckedListBox1.MouseClick
        Dim idx, sidx As Integer
        sidx = CheckedListBox1.SelectedIndex
        For idx = 0 To CheckedListBox1.Items.Count - 1
            If idx <> sidx Then
                CheckedListBox1.SetItemChecked(idx, False)
            Else
                CheckedListBox1.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Caller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 120
            cb1cm.Items.Add(i)
            cb2cm.Items.Add(i)
            If i > 59 Then
            Else
                cb1cs.Items.Add(i)
                cb2cs.Items.Add(i)
            End If
        Next
        Timer1.Interval = 50
        'Timer1.Start()

    End Sub


    Public caller As String()


    Public Sub setsoundcalle()
        Timer.pausevlcstart()
        Button3.Enabled = True
        If CheckedListBox1.SelectedIndex <> -1 Then

            Dim splitcaller As String = CheckedListBox1.SelectedItem
            caller = splitcaller.Split("*")

            If File.Exists(".\Caller\" & "SE PREPARE.wav") Then
                Label2.Text = "SE PREPARE"
                My.Computer.Audio.Play(".\Caller\" & "SE PREPARE.wav", AudioPlayMode.WaitToComplete)
            End If

            For i = 0 To caller.Length - 1
                If File.Exists(".\Caller\" & caller(i) & ".wav") Then
                    Label2.Text = caller(i)
                    My.Computer.Audio.Play(".\Caller\" & caller(i) & ".wav", AudioPlayMode.WaitToComplete)
                End If
            Next

        End If
        Button3.Enabled = False
        Timer.pausevlcstart()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckedListBox1.Visible = True
        RichTextBox1.Visible = False
        Label3.Text = "Cocher l'appel voulu"
        CheckedListBox1.Items.Clear()
        For Each line In RichTextBox1.Lines
            CheckedListBox1.Items.Add(line)
        Next
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim idx As Integer

        For idx = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(idx) = True Then

                'Label1.Text = "CURRENT : " & CheckedListBox1.SelectedItem
                RichTextBox2.Text = CheckedListBox1.SelectedItem
                RichTextBox2.Text = RichTextBox2.Text.Replace("*", vbLf)

            End If
        Next

    End Sub

    Private Sub Check1c_CheckedChanged(sender As Object, e As EventArgs) Handles Check1c.CheckedChanged
        If Check1c.Checked = True Then
            cb1cm.Enabled = False
            cb1cs.Enabled = False
            Timer.firstcaller(0) = cb1cm.SelectedItem
            Timer.firstcaller(1) = cb1cs.SelectedItem
        Else
            cb1cm.Enabled = True
            cb1cs.Enabled = True
            Timer.firstcaller(0) = 0
            Timer.firstcaller(1) = 0
        End If
    End Sub

    Private Sub Check2c_CheckedChanged(sender As Object, e As EventArgs) Handles Check2c.CheckedChanged
        If Check2c.Checked = True Then
            cb2cm.Enabled = False
            cb2cs.Enabled = False
            Timer.secondecaller(0) = cb2cm.SelectedItem
            Timer.secondecaller(1) = cb2cs.SelectedItem
        Else
            cb1cm.Enabled = True
            cb2cs.Enabled = True
            Timer.secondecaller(0) = 0
            Timer.secondecaller(1) = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckedListBox1.Visible = False
        RichTextBox1.Visible = True
        Label3.Text = "Ajouter a la liste"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Timer.thread.IsAlive = True Then
            Timer.thread.Abort()
        End If
        If Timer.thread2.IsAlive = True Then
            Timer.thread2.Abort()
        End If
        If Timer.thread3.IsAlive = True Then
            Timer.thread3.Abort()
        End If
    End Sub
End Class