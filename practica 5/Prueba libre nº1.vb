Public Class Prueba_libre_nº1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entra As String = ""
        Dim vocal As String = "aeiou"
        Dim conso As String = "bcdfghjklmnñpqrstvwxyz"
        Dim num As String = "0123456789"
        Dim cont As Integer = 0
        Dim salida As String = ""

        entra = TextBox1.Text()

        For i = 1 To vocal.Length()
            For j = 1 To entra.Length()
                If Mid(entra, j, 1) = Mid(vocal, i, 1) Then
                    cont = cont + 1
                End If

            Next
            If cont > 0 Then
                salida = salida + ("De la letra - " + Mid(vocal, i, 1) + " - tenemos " + cont.ToString() + " letras " + Environment.NewLine)
                cont = 0
            End If
        Next

        For i = 1 To conso.Length()
            For j = 1 To entra.Length()
                If Mid(entra, j, 1) = Mid(conso, i, 1) Then
                    cont = cont + 1
                End If

            Next
            If cont > 0 Then
                salida = salida + ("De la letra - " + Mid(conso, i, 1) + " - tenemos " + cont.ToString() + " letras " + Environment.NewLine)
                cont = 0
            End If

        Next

        For i = 1 To num.Length()
            For j = 1 To entra.Length()
                If Mid(entra, j, 1) = Mid(num, i, 1) Then
                    cont = cont + 1
                End If

            Next
            If cont > 0 Then
                salida = salida + ("De numero - " + Mid(num, i, 1) + " - tenemos " + cont.ToString() + " numeros " + Environment.NewLine)
                cont = 0
            End If
        Next

        MessageBox.Show(salida)

    End Sub
End Class