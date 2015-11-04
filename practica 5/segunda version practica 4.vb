Public Class segunda_version_practica_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim carac As String = ""
        Dim con As Integer = 0
        carac = TextBox1.Text
        con = InStr("aeioubcdfghjklmnñpqrstvwxyz", carac)
        If con >= 1 And con <= 5 Then
            MessageBox.Show("Es una vocal")
        ElseIf con >= 6
            MessageBox.Show("Es una consonante")
        Else
            MessageBox.Show("ERROR no es ni vocal ni consonante")
        End If
    End Sub
End Class