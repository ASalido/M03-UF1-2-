Public Class Ejercicio_6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        num = CInt(TextBox1.Text)
        Select Case num
            Case 1
                Label1.Text = "Lunes"
            Case 2
                Label1.Text = "Martes"
            Case 3
                Label1.Text = "Miercoles"
            Case 4
                Label1.Text = "Jueves"
            Case 5
                Label1.Text = "Viernes"
            Case 6
                Label1.Text = "Sabado"
            Case 7
                Label1.Text = "Domingo"
        End Select
    End Sub
End Class