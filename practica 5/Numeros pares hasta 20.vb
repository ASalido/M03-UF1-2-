Public Class Numeros_pares_hasta_20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = 0
        Const par As Integer = 2
        Dim res As String = ""
        For i = 0 To 20
            res = res + num.ToString() + Environment.NewLine()
            num = num + par
        Next
        MessageBox.Show(res)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cont As Integer = 0
        Dim res As String = ""
        While cont <> 4
            res = res + cont.ToString() + Environment.NewLine()
            cont = cont + 2
        End While
        MessageBox.Show(res)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cont As Integer = 0
        Dim res As String = ""
        Do
            res = res + cont.ToString() + Environment.NewLine()
            cont = cont + 2
        Loop While cont <= 40
        MessageBox.Show(res)
    End Sub

End Class