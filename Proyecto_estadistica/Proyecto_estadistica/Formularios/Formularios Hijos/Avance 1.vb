Public Class Avance_1

    Dim Muestra As Integer
    Dim datos As Double
    Dim contador As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BunifuMetroTextbox1.Enabled = False
        Muestra = BunifuMetroTextbox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If contador = Muestra Then
            BunifuMetroTextbox2.Enabled = False
        Else

            ListBox7.Items.Add(BunifuMetroTextbox2.Text)

        End If
        contador = contador + 1

        BunifuMetroTextbox2.Text = ""
    End Sub
End Class