Public Class Ejercicio__3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim n3 As Integer = 0
        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())
        n3 = CInt(TextBox3.Text())

        If n1 < n2 And n1 < n3 Then
            If n2 < n3 Then
                MessageBox.Show("minimo " + n1.ToString() + " , maximo " + n3.ToString())
            Else
                MessageBox.Show("minimo " + n1.ToString() + " , maximo " + n2.ToString())
            End If
        ElseIf n2 < n1 And n2 < n3 Then
            If n1 < n3 Then
                MessageBox.Show("minimo " + n2.ToString() + " , maximo " + n3.ToString())
            Else
                MessageBox.Show("minimo " + n2.ToString() + " , maximo " + n1.ToString())
            End If
        Else
            If n2 < n1 Then
                MessageBox.Show("minimo " + n3.ToString() + " , maximo " + n1.ToString())
            Else
                MessageBox.Show("minimo " + n3.ToString() + " , maximo " + n2.ToString())
            End If
        End If
    End Sub
End Class