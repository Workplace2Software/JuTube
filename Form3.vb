Public Class Form3


    Dim num As Integer
    Dim r As New Random()



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            IfoneAd.ShowDialog()
        Else
            genericvideoplay.Show()

        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            IfoneAd.ShowDialog()
        Else
            thisissamsung.Show()

        End If


    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            IfoneAd.ShowDialog()
        Else
            gtasex.Show()

        End If

    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            IfoneAd.ShowDialog()
        Else
            Form4.Show()

        End If
    End Sub
End Class