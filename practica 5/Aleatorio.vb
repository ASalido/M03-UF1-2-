Public Class Aleatorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim res As New Random

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())

        TextBox3.Text = res.Next(n1, n2 + 1)
    End Sub
End Class