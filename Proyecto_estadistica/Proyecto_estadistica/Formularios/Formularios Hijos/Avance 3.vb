Public Class Avance_3

    Dim S_Muestral As Double
    Dim alfa As Double
    Dim resultado_positivo As Double
    Dim resultado_negativo As Double
    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        BunifuCircleProgressbar1.Value = TrackBar1.Value
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click



        If M_muestral.Text.ToString <> "" Then

            If D_poblacional.Text.ToString <> "" Then

                If N_datos.Text.ToString <> "" Then

                    Panel6.Visible = True
                    Panel7.Visible = True
                    Panel8.Visible = True
                    Grafica.Visible = True


                    S_Muestral = D_poblacional.Text / (Math.Sqrt(N_datos.Text))
                    alfa = (100 - TrackBar1.Value) / 100

                    alfa = Math.Round(alfa / 2, 4)
                    Label10.Text = ((100 - TrackBar1.Value) / 2).ToString + " % "
                    Label12.Text = ((100 - TrackBar1.Value) / 2).ToString + " % "

                    Label6.Text = alfa.ToString
                    Dim result As Double = Grafica.DataManipulator.Statistics.InverseNormalDistribution(alfa)
                    alfa = result
                    alfa = Math.Abs(alfa)
                    alfa = Math.Round(alfa, 4)
                    TextBox1.Text = alfa
                    resultado_negativo = M_muestral.Text - alfa * S_Muestral
                    resultado_positivo = M_muestral.Text + alfa * S_Muestral
                    resultado_negativo = Math.Round(resultado_negativo, 2)
                    resultado_positivo = Math.Round(resultado_positivo, 2)

                    Label13.Text = (TrackBar1.Value).ToString + " % "
                    Resultado.Text = resultado_negativo.ToString + " , " + resultado_positivo.ToString

                Else
                    MsgBox("El campo CANTIDAD DE DATOS ( N ) esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
                    N_datos.Focus()

                End If

            Else
                MsgBox("El campo DESVIACION POBLACIONAL ( σ ) esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
                D_poblacional.Focus()
            End If

        Else
            MsgBox("El campo MEDIA MUESTRAL ( X ) esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
            M_muestral.Focus()

        End If





    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick
        Temporizador.Stop()
        Grafica.Series("Chartlineas").Points.AddXY("0", 0.5)
        Grafica.Series("Chartlineas").Points.AddXY("1", 0.5)
        Grafica.Series("Chartlineas").Points.AddXY("2", 3)
        Grafica.Series("Chartlineas").Points.AddXY("3", 5)
        Grafica.Series("Chartlineas").Points.AddXY("4", 10)
        Grafica.Series("Chartlineas").Points.AddXY("5", 15)
        Grafica.Series("Chartlineas").Points.AddXY("6", 20)
        Grafica.Series("Chartlineas").Points.AddXY("7", 25)
        Grafica.Series("Chartlineas").Points.AddXY("8", 30)
        Grafica.Series("Chartlineas").Points.AddXY("9", 35)
        Grafica.Series("Chartlineas").Points.AddXY("10", 35)
        Grafica.Series("Chartlineas").Points.AddXY("11", 30)
        Grafica.Series("Chartlineas").Points.AddXY("12", 25)
        Grafica.Series("Chartlineas").Points.AddXY("13", 20)
        Grafica.Series("Chartlineas").Points.AddXY("14", 15)
        Grafica.Series("Chartlineas").Points.AddXY("15", 10)
        Grafica.Series("Chartlineas").Points.AddXY("16", 5)
        Grafica.Series("Chartlineas").Points.AddXY("17", 3)
        Grafica.Series("Chartlineas").Points.AddXY("18", 0.5)
        Grafica.Series("Chartlineas").Points.AddXY("19", 0.5)


    End Sub

    Private Sub M_muestral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles M_muestral.KeyPress
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
           AndAlso (Not e.KeyChar = "." Or M_muestral.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub N_datos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_datos.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub D_poblacional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles D_poblacional.KeyPress
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
         AndAlso (Not e.KeyChar = "." Or M_muestral.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Avance_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = 90
    End Sub
End Class