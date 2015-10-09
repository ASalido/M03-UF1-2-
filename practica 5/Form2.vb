Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n1 As Integer = 1
        Dim n2 As Integer = 2
        Dim res As Integer = 0
        Dim cont As Integer = 0
        Dim cont1 As Integer = 0

        cont = CInt(TextBox1.Text())

        While cont1 <> cont

            If (cont = 0) Then

                res = 0

            ElseIf (cont = 1) Then

                res = 1

            Else

                cont = 2
                res = n1 + n2
                n1 = n2
                n2 = res

            End If

            cont1 = cont1 + 1
            Label1.Text get res.tostring()
        End While
    End Sub
End Class