Public Class Ejercicio_9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim año As Integer = 0
        Dim mes As Integer = 0
        mes = CInt(TextBox1.Text())
        año = CInt(TextBox2.Text())
        Select Case mes
            Case 1
                MessageBox.Show("ENERO" + Environment.NewLine + "31")
            Case 2
                If año Mod 100 = 0 And año Mod 400 <> 0 Or año Mod 100 <> 0 And año Mod 400 = 0 Then
                    MessageBox.Show("FEBRERO" + Environment.NewLine + "29" + Environment.NewLine + "No es un año BISIESTO")
                ElseIf año Mod 4 = 0
                    MessageBox.Show("FEBRERO" + Environment.NewLine + "29" + Environment.NewLine + "Es un año BISIESTO")
                Else
                    MessageBox.Show("FEBRERO" + Environment.NewLine + "28" + Environment.NewLine + "No es un año BISIESTO")
                End If
            Case 3
                MessageBox.Show("MARZO" + Environment.NewLine + "31")
            Case 4
                MessageBox.Show("ABRIL" + Environment.NewLine + "30")
            Case 5
                MessageBox.Show("MAYO" + Environment.NewLine + "31")
            Case 6
                MessageBox.Show("JUNIO" + Environment.NewLine + "30")
            Case 7
                MessageBox.Show("JULIO" + Environment.NewLine + "31")
            Case 8
                MessageBox.Show("AGOSTO" + Environment.NewLine + "31")
            Case 9
                MessageBox.Show("SEPTIEMBRE" + Environment.NewLine + "30")
            Case 10
                MessageBox.Show("OCTUBRE" + Environment.NewLine + "31")
            Case 11
                MessageBox.Show("NOVIEMBRE" + Environment.NewLine + "30")
            Case 12
                MessageBox.Show("DICIEMBRE" + Environment.NewLine + "31")
        End Select
    End Sub
End Class