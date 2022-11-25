Public Class thisissamsung

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub thisissamsung_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
  

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub AxVLCPlugin21_Enter(sender As System.Object, e As System.EventArgs) Handles AxVLCPlugin21.Enter
        AxVLCPlugin21.playlist.add("file:///C:\JuTube\Videos\This is sam sung.3gp")
    End Sub
End Class