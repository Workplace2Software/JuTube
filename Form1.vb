Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Jutube Please press load and then when progress bar shows maximum and music ends press load again to loaf into JuTube. Please keep watch for the ads and pleas watch so we make money and can take down Evil Mr Youtube -Barry Workplace")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("Warning Error: When program progress bar shoe 100%. please press load again. Thanky ou")
        Timer1.Enabled = True
        My.Computer.Audio.Play(My.Resources.jutube, AudioPlayMode.Background)

        If ProgressBar1.Value = 110 Then
            If Not ProgressBar1.Value = 110 Then
                Print("123")
            End If
            Form2.Show()
            Me.Hide()
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("we havent made this yet", _
    "warning")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("The Dev Codes is awesome.", _
    "Important Message")
    End Sub
End Class
