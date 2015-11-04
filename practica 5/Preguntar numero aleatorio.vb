Public Class Preguntar_numero_aleatorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var As Integer = 0
        Dim num As Integer = 0
        Dim int As Integer = 3
        Dim res As Integer = 0
        While (int <> 0 Or res <> 1)
            num = InputBox("Introduce un numero - te quedan " + int.ToString() + " intentos")
            If num = var Then
                res = 1
            End If
            int = int - 1
        End While
        If res = 1 Then
            MessageBox.Show("El numero introducido es correcto")
        Else
            MessageBox.Show("Te has quedado sin intentos")
        End If
        'a= rnd()*780 
        'a= 120+a
    End Sub
    'Const var as integer = 7 la palabra CONST es para describir una constante.


End Class