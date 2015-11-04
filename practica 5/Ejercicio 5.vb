Public Class Ejercicio_5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota As Double = 0
        nota = CInt(TextBox1.Text())
        If nota >= 0 And nota < 5 Then
            Label2.Text = "S    Suspendido"
        ElseIf nota >= 5 And nota < 6.5
            Label2.Text = "A    Aprobado"
        ElseIf nota >= 6.5 And nota < 8.5
            Label2.Text = "N     Notable"
        ElseIf nota >= 8.5 And nota < 9.75
            Label2.Text = "E     Excelente"
        Else
            Label2.Text = "MATRICULA"
        End If
    End Sub
End Class