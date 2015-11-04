Public Class ejercicio___2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())
        If n1 Mod n2 = 0 Then
            MessageBox.Show("El numero es divisor")
        Else
            MessageBox.Show("El numero no es divisor")
        End If
        ' mod es un comando para saber si el numero n1 es divisor de n2
    End Sub
End Class