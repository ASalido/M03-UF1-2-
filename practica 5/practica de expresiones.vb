Public Class practica_de_expresiones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ex As Boolean
        Dim a As Boolean = False
        Dim b As Boolean = True
        ex = Not (2 < 6 Or b)
        MessageBox.Show(ex)
    End Sub
End Class