Public Class suma_numeros_impares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        For cont = 0 To 100
            If cont Mod 2 <> 0 Then
                num = num + cont
            End If
        Next
        MessageBox.Show(num.ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num As Integer = 0
        Dim cont As Integer = 0
        While cont <= 100
            If cont Mod 2 <> 0 Then
                num = num + cont
            End If
            cont = cont + 1
        End While
        MessageBox.Show(num.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Integer = 0
        Dim cont As Integer = 0
        Do
            If cont Mod 2 <> 0 Then
                num = num + cont
            End If
            cont = cont + 1
        Loop While cont <= 100
        MessageBox.Show(num.ToString())
    End Sub
End Class