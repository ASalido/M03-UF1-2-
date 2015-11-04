Public Class practica_if
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim num3 As Integer = 0
        Dim min As Integer = 0
        Dim med As Integer = 0
        Dim max As Integer = 0

        num1 = CInt(TextBox1.Text())
        num2 = CInt(TextBox2.Text())
        num3 = CInt(TextBox3.Text())

        If num1 < num2 And num1 < num3 Then
            min = num1
            If num2 < num3 Then
                med = num2
                max = num3
            Else
                med = num3
                max = num2
            End If
        ElseIf num2 < num3 And num2 < num1
            min = num2
            If num1 < num3 Then
                med = num1
                max = num3
            Else
                med = num3
                max = num1
            End If
        Else
            min = num3
            If num1 < num2 Then
                med = num1
                max = num2
            Else
                med = num2
                max = num1
            End If
        End If
        Label1.Text = min.ToString() + "-" + med.ToString() + "-" + max.ToString()

        'if (num1 < num2 and num2< num3)
        '   label1.text = num1 + num2 + num3
        'elseif (num1 < num2 and num3< num2)
        '   label1.text = num1 + num3 +num2
        'elseif (num2 < num1 and num1 < num3)
        '   label1.text = num2 + num1 + num3 = (label1.text = min + med + max)
        '..................................
        ' la ultima opcion se debera poner un else.
        ' se pueden usar todos los elseif que se deseen ademas de que ya de esta manera optimizas el programa ya creado arriba.
    End Sub
End Class