Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim n3 As Integer = 0
        Dim res As Integer = 0

        n1 = CInt(TextBox1.Text())
        n2 = CInt(TextBox2.Text())
        n3 = CInt(TextBox3.Text())

        If (n1 < n2) Then
            If (n1 < n3) Then
                res = n1
            Else
                res = n3
            End If
        Else
            If (n2 < n3) Then
                res = n2

            Else
                res = n3
            End If
        End If
        TextBox4.Text = res
    End Sub
    ' resolucion optimizada
    '{if (n1<n2) and (n1<n3)
    '   res=n1
    'elseif (n2<n1) and (n2<n3)
    '   res=n2
    'else
    '   res=n3}
End Class