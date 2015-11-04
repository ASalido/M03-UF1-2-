Public Class ejercicio_7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer = 0
        num = CInt(TextBox1.Text())
        If num > 0 And num < 8 Then
            If num = 1 Then
                MessageBox.Show("Lunes")
            ElseIf num = 2
                MessageBox.Show("Martes")
            ElseIf num = 3
                MessageBox.Show("Miercoles")
            ElseIf num = 4
                MessageBox.Show("Jueves")
            ElseIf num = 5
                MessageBox.Show("Viernes")
            ElseIf num = 6
                MessageBox.Show("Sabado")
            ElseIf num = 7
                MessageBox.Show("Domingo")
            End If
        End If
    End Sub
End Class