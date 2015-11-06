Public Class Sumar_numeros_de_un_intervalo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Dim num1 As Integer = 0
        Dim res As Integer = 0
        num = InputBox("Introduce el primer numero")
        num1 = InputBox("Introduce el segundo numero")
        If num1 < num Then
            res = num1
            num1 = num
            num = res
            res = 0
        End If
        num = num + 1
        num1 = num1 - 1
        For i = num To num1
            res = res + num
            num = num + 1
        Next
        MessageBox.Show("La suma de los numeros es " + res.ToString())
    End Sub
End Class