Public Class Ejercicio_8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Integer = 0
        nota = CInt(TextBox1.Text)
        Select Case nota
            Case 0 To 4
                MessageBox.Show("S")
            Case 5 To 6
                MessageBox.Show("A")
            Case 7 To 8
                MessageBox.Show("N")
            Case 9
                MessageBox.Show("E")
            Case 10
                MessageBox.Show("M")
        End Select
    End Sub
End Class