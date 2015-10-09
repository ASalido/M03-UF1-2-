Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim res As Integer = 0

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())

        If (n1 < n2) Then
            res = n1
        Else
            res = n2
        End If
        TextBox3.Text = res.ToString()
    End Sub

    Private Sub Button1_DoubleClick(sender As Object, e As EventArgs) Handles Button1.DoubleClick
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim res As Integer = 0

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())

        If (n1 < n2) Then
            res = n2
        Else
            res = n1
        End If
        TextBox3.Text = res.ToString()
    End Sub
End Class
