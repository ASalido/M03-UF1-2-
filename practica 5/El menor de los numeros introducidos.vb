Public Class El_menor_de_los_numeros_introducidos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Dim num1 As Integer

        For i = 0 To 9
            num = InputBox("Introduce el numero")
            If (i = 0) Then
                num1 = num
            ElseIf (num < num1)
                num1 = num
            End If
        Next
        MessageBox.Show("El numero mas pequeño introducido es " + num1.ToString())
    End Sub
    'menor = inputbox ("")
    'For cont = 0 to 8
    '   num = inputbox ("")
    '   If num < menor 
    '       menor = num
    '   EndIf
    'Next
    'Messagebox.show (menor.tostring)
End Class