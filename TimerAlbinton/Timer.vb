Imports System.IO
Public Class Timer
    Dim resetmin As Integer
    Dim resetsec As Integer
    Public rightAlign As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
        'Me.TopMost = True
        'Caller.Show()
        rightAlign = Label1.Left + Label1.Width
        For i = 0 To 120
            cbxminutes.Items.Add(i)
            cbxminutes2.Items.Add(i)
            If i > 59 Then
            Else
                cbysecondes2.Items.Add(i)
            End If
        Next
        cb8min.Checked = False
        cb10min.Checked = False
        cb12min.Checked = False
        cbxmin.Checked = False
        cbxminutes.Enabled = False
        cbxminysec.Checked = False
        cbxminutes2.Enabled = False
        cbysecondes2.Enabled = False
        Label1.Text = "00"


        lstart.ForeColor = Color.Red
        l1m.ForeColor = Color.Red
        lstop.ForeColor = Color.Red

        Timer2.Interval = 1000
        Timer2.Start()
    End Sub

    Private Sub cb8min_CheckedChanged(sender As Object, e As EventArgs) Handles cb8min.CheckedChanged
        If cb8min.Checked = True Then
            Label1.Text = "08"
            Label3.Text = "00"
            cb10min.Checked = False
            cb12min.Checked = False
            cbxmin.Checked = False
            cbxminutes.Enabled = False
            cbxminysec.Checked = False
            cbxminutes2.Enabled = False
            cbysecondes2.Enabled = False
        ElseIf cb8min.Checked = False And cb10min.Checked = False And cb12min.Checked = False And cbxmin.Checked = False And cbxminysec.Checked = False Then
            Label1.Text = "00"
            Label3.Text = "00"
        End If
    End Sub

    Private Sub cb10min_CheckedChanged(sender As Object, e As EventArgs) Handles cb10min.CheckedChanged
        If cb10min.Checked = True Then
            Label1.Text = "10"
            Label3.Text = "00"
            cb8min.Checked = False
            cb12min.Checked = False
            cbxmin.Checked = False
            cbxminutes.Enabled = False
            cbxminysec.Checked = False
            cbxminutes2.Enabled = False
            cbysecondes2.Enabled = False
        ElseIf cb8min.Checked = False And cb10min.Checked = False And cb12min.Checked = False And cbxmin.Checked = False And cbxminysec.Checked = False Then
            Label1.Text = "00"
            Label3.Text = "00"
        End If
    End Sub

    Private Sub cb12min_CheckedChanged(sender As Object, e As EventArgs) Handles cb12min.CheckedChanged
        If cb12min.Checked = True Then
            Label1.Text = "12"
            Label3.Text = "00"
            cb10min.Checked = False
            cb8min.Checked = False
            cbxmin.Checked = False
            cbxminutes.Enabled = False
            cbxminysec.Checked = False
            cbxminutes2.Enabled = False
            cbysecondes2.Enabled = False
        ElseIf cb8min.Checked = False And cb10min.Checked = False And cb12min.Checked = False And cbxmin.Checked = False And cbxminysec.Checked = False Then
            Label1.Text = "0"
            Label3.Text = "00"
        End If
    End Sub

    Private Sub cbxmin_CheckedChanged(sender As Object, e As EventArgs) Handles cbxmin.CheckedChanged
        If cbxmin.Checked = True Then
            If cbxminutes.Text = "Minutes..." Then
                Label1.Text = "X"
            Else
                Label1.Text = cbxminutes.Text
            End If
            Label3.Text = "00"
            cb10min.Checked = False
            cb12min.Checked = False
            cb8min.Checked = False
            cbxminutes.Enabled = True
            cbxminysec.Checked = False
            cbxminutes2.Enabled = False
            cbysecondes2.Enabled = False
        ElseIf cb8min.Checked = False And cb10min.Checked = False And cb12min.Checked = False And cbxmin.Checked = False And cbxminysec.Checked = False Then
            Label1.Text = "00"
            Label3.Text = "00"
            cbxminutes.Enabled = False
        Else

        End If
    End Sub

    Private Sub cbxminysec_CheckedChanged(sender As Object, e As EventArgs) Handles cbxminysec.CheckedChanged
        If cbxminysec.Checked = True Then
            If cbxminutes2.Text = "Minutes..." Then
                Label1.Text = "X"
            Else
                Label1.Text = cbxminutes2.Text
            End If
            If cbysecondes2.Text = "Secondes..." Then
                Label3.Text = "Y"
            Else
                Label3.Text = cbysecondes2.Text
            End If

            cb10min.Checked = False
            cb12min.Checked = False
            cbxmin.Checked = False
            cbxminutes.Enabled = False
            cb8min.Checked = False
            cbxminutes2.Enabled = True
            cbysecondes2.Enabled = True
        ElseIf cb8min.Checked = False And cb10min.Checked = False And cb12min.Checked = False And cbxmin.Checked = False And cbxminysec.Checked = False Then
            Label1.Text = "00"
            Label3.Text = "00"
            cbxminutes2.Enabled = False
            cbysecondes2.Enabled = False
        Else

        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxminutes2.SelectedIndexChanged
        Label1.Text = cbxminutes2.SelectedItem
    End Sub

    Private Sub cbxminutes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxminutes.SelectedIndexChanged
        Label1.Text = cbxminutes.SelectedItem
    End Sub

    Private Sub cbysecondes2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbysecondes2.SelectedIndexChanged
        Label3.Text = cbysecondes2.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim min As Integer = Label1.Text
        Dim sec As Integer = Label3.Text
        If min = 0 And sec = 0 Then
            breset.PerformClick()
        End If

        If Label1.Text = "X" Then
            Label1.Text = "00"
        End If
        If Label3.Text = "Y" Then
            Label3.Text = "00"
        End If
        Timer1.Interval = 1000
        Timer1.Start()
        Label1.ForeColor = Color.Green
        Label2.ForeColor = Color.Green
        Label3.ForeColor = Color.Green
        Display.Label1.ForeColor = Color.Green

        If lstart.ForeColor = Color.Green Then
            pausevlcstart()
            My.Computer.Audio.Play(My.Resources.start, AudioPlayMode.WaitToComplete)
            pausevlcstart()
        End If

        cb8min.Enabled = False
        cb10min.Enabled = False
        cb12min.Enabled = False
        cbxmin.Enabled = False
        cbxminutes.Enabled = False
        cbxminysec.Enabled = False
        cbxminutes2.Enabled = False
        cbysecondes2.Enabled = False

        resetmin = Label1.Text
        resetsec = Label3.Text
        Button1.Enabled = False
        breset.Enabled = False
        Button3.Enabled = True
        Label4.Text = Label1.Text & " : " & Label3.Text
        Display.ProgressBar1.Maximum = ((resetmin * 60) + resetsec) / 2
        Display.ProgressBar2.Maximum = ((resetmin * 60) + resetsec) / 2
        Display.ProgressBar1.Value = 0
        Display.ProgressBar2.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles breset.Click
        Label1.Text = resetmin
        Label3.Text = resetsec
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As String = MsgBox("Ete vous sur de vouloir arreter le timer ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            Timer1.Stop()
            Label1.ForeColor = Color.Blue
            Label2.ForeColor = Color.Blue
            Label3.ForeColor = Color.Blue
            Display.Label1.ForeColor = Color.Turquoise
            If lstop.ForeColor = Color.Green Then
                pausevlcstart()
                My.Computer.Audio.Play(My.Resources._stop, AudioPlayMode.WaitToComplete)
                pausevlcstart()
            End If
            cb8min.Enabled = True
            cb10min.Enabled = True
            cb12min.Enabled = True
            cbxmin.Enabled = True
            cbxminutes.Enabled = True
            cbxminysec.Enabled = True
            cbxminutes2.Enabled = True
            cbysecondes2.Enabled = True

            Button1.Enabled = True
            breset.Enabled = True
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim min As Integer = Label1.Text
        Dim sec As Integer = Label3.Text
        'Dim reste As Integer = Label4.Text
        Label1.Left = rightAlign - Label1.Width
        If min = 0 And sec = 0 Then
            Timer1.Stop()
            Label1.ForeColor = Color.Blue
            Label2.ForeColor = Color.Blue
            Label3.ForeColor = Color.Blue
            Display.Label1.ForeColor = Color.Turquoise
            cb8min.Enabled = True
            cb10min.Enabled = True
            cb12min.Enabled = True
            cbxmin.Enabled = True
            If cbxmin.Checked = True Then
                cbxminutes.Enabled = True
            End If
            cbxminysec.Enabled = True
            If cbxminysec.Checked = True Then
                cbxminutes2.Enabled = True
                cbysecondes2.Enabled = True
            End If
            'play son

            If lstop.ForeColor = Color.Green Then
                pausevlcstart()
                My.Computer.Audio.Play(My.Resources._stop, AudioPlayMode.WaitToComplete)
                pausevlcstart()
            End If

            Button1.Enabled = True
            breset.Enabled = True
            Button3.Enabled = False
            Me.TopMost = True
            Me.TopMost = False
            'MsgBox("Temps ecoulée !!!")

            If Caller.checklc.Checked = True Then
                thread3 = New System.Threading.Thread(AddressOf Caller.setsoundcalle)
                thread3.Start()
            End If

        Else
            If sec = 0 Then
                min = min - 1
                sec = sec + 59
            Else
                sec = sec - 1
            End If
            Label1.Text = min
            Label3.Text = sec

            Dim secstotal As Integer = min * 60 + sec
            Dim resetsecstotal As Integer = resetmin * 60 + resetsec
            If secstotal >= Math.Round(resetsecstotal / 2) Then
                Display.ProgressBar1.Value = (resetsecstotal - secstotal)
            ElseIf secstotal < Math.Round(resetsecstotal / 2) Then
                Display.ProgressBar2.Value = (resetsecstotal / 2 - secstotal)
            Else

            End If

            If secstotal = Math.Round(resetsecstotal / 2) Then 'If sec = 0 And min = 1 Then
                    'Label1.ForeColor = Color.Red
                    'Label2.ForeColor = Color.Red
                    'Label3.ForeColor = Color.Red
                    'Display.Label1.ForeColor = Color.Red

                    If l1m.ForeColor = Color.Green Then
                        pausevlcstart()
                        My.Computer.Audio.Play(My.Resources._1minute, AudioPlayMode.WaitToComplete)
                        pausevlcstart()
                    End If

                    'Caller.setsoundcalle()

                End If

                If sec = firstcaller(1) And min = firstcaller(0) And Caller.Check1c.Checked = True Then
                    'Caller.setsoundcalle()
                    thread = New System.Threading.Thread(AddressOf Caller.setsoundcalle)
                    thread.Start()
                End If

                If sec = secondecaller(1) And min = secondecaller(0) And Caller.Check2c.Checked = True Then
                    'Caller.setsoundcalle()
                    thread2 = New System.Threading.Thread(AddressOf Caller.setsoundcalle)
                    thread2.Start()
                End If

            End If
            Display.Label1.Text = "TEMPS RESTANT" & vbLf & min & " : " & sec
    End Sub
    'str(Minutes, Secondes)
    Public firstcaller(1) As Integer
    Public secondecaller(1) As Integer
    Public thread As System.Threading.Thread
    Public thread2 As System.Threading.Thread
    Public thread3 As System.Threading.Thread
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label13.Text = Date.Now
    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lstart.Click
        Dim i As String = MsgBox("Ete vous sur de vouloir jouer ce son ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then

            My.Computer.Audio.Play(My.Resources.start, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lstop.Click
        Dim i As String = MsgBox("Ete vous sur de vouloir jouer ce son ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then

            My.Computer.Audio.Play(My.Resources._stop, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles l1m.Click
        Dim i As String = MsgBox("Ete vous sur de vouloir jouer ce son ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then

            My.Computer.Audio.Play(My.Resources._1minute, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Display.coro = 2 Then
            Display.Show()
        ElseIf Display.coro = 1 Then
            Display.Close()
        End If
        If Heure.coro = 2 Then
            Heure.Show()
        ElseIf Heure.coro = 1 Then
            Heure.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Caller.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim i As String = MsgBox("voulez vous activer le son Start ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            lstart.ForeColor = Color.Green
        Else
            lstart.ForeColor = Color.Red
        End If
        i = MsgBox("voulez vous activer le son Middel time ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            l1m.ForeColor = Color.Green
        Else
            l1m.ForeColor = Color.Red
        End If
        i = MsgBox("voulez vous activer le son Stop ?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            lstop.ForeColor = Color.Green
        Else
            lstop.ForeColor = Color.Red
        End If
    End Sub

    Public Sub pausevlcstart()
        If Not File.Exists(".\pausevlcstart.exe") Then
            Dim FileName As String = IO.Path.Combine(Application.StartupPath, "pausevlcstart.exe")
            Dim BytesToWrite() As Byte = My.Resources.pausevlcstart
            Dim FileStream As New System.IO.FileStream(FileName, System.IO.FileMode.OpenOrCreate)
            Dim BinaryWriter As New System.IO.BinaryWriter(FileStream)
            BinaryWriter.Write(BytesToWrite)
            BinaryWriter.Close()
            FileStream.Close()
            Process.Start(FileName).WaitForExit()
            File.Delete(".\pausevlcstart.exe")
        End If

        If File.Exists(".\pausevlcstart.exe") Then
            File.Delete(".\pausevlcstart.exe")
        End If

    End Sub
End Class
