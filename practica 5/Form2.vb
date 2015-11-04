Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 1
        Dim n2 As Integer = 0
        Dim res As Integer = 0
        Dim cont As Integer = 0
        Dim sal As String = ""

        cont = CInt(TextBox1.Text())
        For cont = 0 To cont
            res = n1 + n2
            n1 = n2
            n2 = res
            sal = sal + res.ToString() + " , "
        Next
        MessageBox.Show(sal)
    End Sub
End Class