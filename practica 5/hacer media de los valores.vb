Public Class hacer_media_de_los_valores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Double = 0
        Dim cont As Integer = 0
        Dim res As Double = 0
        For cont = 0 To 9
            num = InputBox("Introduce la nota que quieras ")
            res = res + num
        Next
        res = res / 10
        MessageBox.Show("la media de las notas introducidas es: " + Environment.NewLine() + res.ToString())
    End Sub
End Class
