Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtKata.Text = "A" Then
            txtTerjemahan.Text = "诶	 (ēi)"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtKata.Text = "诶 (ēi)" Then
            txtTerjemahan.Text = "A"

        End If
    End Sub
End Class
