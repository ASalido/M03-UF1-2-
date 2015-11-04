Public Class tabla_multiplicar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mul1 As Integer = 0
        Dim res As Integer = 0
        Dim cont As Integer = 0
        Dim pan As String = ""

        mul1 = CInt(TextBox1.Text())
        For cont = 0 To 10
            res = mul1 * cont
            pan = pan + mul1.ToString() + " x " + cont.ToString() + " = " + res.ToString() + Environment.NewLine
        Next
        MessageBox.Show(pan)
    End Sub
End Class