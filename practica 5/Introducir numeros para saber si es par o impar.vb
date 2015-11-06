Public Class Introducir_numeros_para_saber_si_es_par_o_impar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        For i = 0 To 9
            num = InputBox("Introduce el numero")
            If num Mod 2 = 0 Then
                MessageBox.Show("El numero introducido es PAR")
            Else
                MessageBox.Show("El numero introducido es IMPAR")
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer = 0
        Dim par As String = ""
        Dim impar As String = ""
        Dim cont As Integer = 0
        Dim cont1 As Integer = 0
        For i = 0 To 9
            num = InputBox("Introduce el numero")
            If num Mod 2 = 0 Then
                par = par + " " + num.ToString()
                cont = cont + 1
            Else
                impar = impar + ", " + num.ToString()
                cont1 = cont1 + 1
            End If
        Next
        MessageBox.Show("Numeros pares introducidos " + par + " que son un total de " + cont.ToString() + " numeros pares" + Environment.NewLine() + "Numeros impares introducidos " + impar + " que son un total de " + cont1.ToString() + " numeros impares")
    End Sub
End Class