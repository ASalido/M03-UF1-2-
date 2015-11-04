Public Class Ejercico__4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consonantes As String = "bcdfghjklmnñpqrstvwxyz"
        Dim vocal As String = "aeiou"
        Dim carac As String = ""
        Dim selec As Integer = 0
        carac = TextBox1.Text()

        For i = 1 To consonantes.Length()
            If Mid(consonantes, i, 1) = carac Then
                selec = 1
            End If
        Next
        For i = 1 To vocal.Length()
            If Mid(vocal, i, 1) = carac Then
                selec = 2
            End If
        Next
        If selec = 1 Then
            MessageBox.Show("La letra introducida es consonante")
        ElseIf selec = 2
            MessageBox.Show("La letra introducida es vocal")
        Else
            MessageBox.Show("ERROR la letra introducida no es ni vocal ni consonante")
        End If

        'dim letra as string ="" 
        'dim posicion as integer=0
        'posicion = instr ("aeioubcdfghjklmnñpqrstvwxyz",letra) "instr te da la posicion de letra en la cadena de caracteres."
        ' if ((posicion >0 and posicion <6) = vocal)
        ' elseif ((posicion > 5 and posicion < 24) = consonante)
        ' else "es error"

    End Sub
End Class