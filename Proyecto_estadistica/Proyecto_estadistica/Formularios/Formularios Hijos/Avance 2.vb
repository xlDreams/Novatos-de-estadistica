Public Class Avance_2

    Dim Funcion As New Funciones

    Dim n As Double
    Dim n_result As Double
    Dim x As Double
    Dim x_result As Double
    Dim p As Double
    Dim binomial As Double
    Dim q As Double
    Dim D_binomial As Double
    Dim suma As Double
    Dim boleano As Boolean = True
    Dim temporal As Double
    Dim cont As Integer = 0
    Dim rango As String

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click



        rango = T_experimento.Text - T_exitos.Text

        If T_experimento.Text.ToString <> "" Then

            If T_exitos.Text.ToString <> "" Then

                If P_ocurra.Text.ToString <> "" Then







                    suma = 0
                    BunifuCircleProgressbar1.Value = P_ocurra.Text

                    If ComboBox1.Text = "Igual    ( = )" Then

                        coeficiente()
                        Resultado.Text = D_binomial

                        'llamando funcion datagridview
                        cont = 0
                        BunifuDataGridView1.Rows.Clear()
                        BunifuDataGridView1.Columns.Clear()
                        rellenar_Datagridcolumna(T_exitos.Text)
                        rellenar_Datagridfila(Resultado.Text)




                    ElseIf ComboBox1.Text = "Mayor ( > )" Then
                        boleano = False
                        x = T_exitos.Text
                        n = T_experimento.Text
                        'requerimiento de llenado data grid 0000
                        cont = 0
                        BunifuDataGridView1.Rows.Clear()
                        BunifuDataGridView1.Columns.Clear()
                        '00000

                        For i = x To n

                            x = x + 1
                            If x <= n Then

                                coeficiente()
                                suma = suma + D_binomial

                                'requerimiento de llenado data grid 0000
                                rellenar_Datagridcolumna(x)
                                rellenar_Datagridfila(D_binomial)

                            End If




                        Next

                        Resultado.Text = suma
                        boleano = True
                        If rango > 6 Then
                            BunifuDataGridView1.Rows.Clear()
                            BunifuDataGridView1.Columns.Clear()
                            MsgBox("El rango es superior a 6 numeros, no se mostraran datos en la tabla. Esto no afectara el resultado final", MsgBoxStyle.Information, "ATENCION")

                        End If

                    ElseIf ComboBox1.Text = "Igual y mayor ( =>)" Then


                        boleano = False
                        x = T_exitos.Text
                        n = T_experimento.Text
                        'requerimiento de llenado data grid 0000
                        cont = 0
                        BunifuDataGridView1.Rows.Clear()
                        BunifuDataGridView1.Columns.Clear()
                        '00000

                        For i = x To n


                            coeficiente()
                            suma = suma + D_binomial

                            'requerimiento de llenado data grid 0000
                            rellenar_Datagridcolumna(x)
                            rellenar_Datagridfila(D_binomial)


                            x = x + 1

                        Next

                        Resultado.Text = suma
                        boleano = True


                        If rango > 6 Then
                            BunifuDataGridView1.Rows.Clear()
                            BunifuDataGridView1.Columns.Clear()
                            MsgBox("El rango es superior a 6 numeros, no se mostraran datos en la tabla. Esto no afectara el resultado final", MsgBoxStyle.Information, "ATENCION")

                        End If

                    ElseIf ComboBox1.Text = "Menor ( < )" Then


                        boleano = False
                        x = T_exitos.Text
                        n = T_experimento.Text
                        temporal = x
                        'requerimiento de llenado data grid 0000
                        cont = 0
                        BunifuDataGridView1.Rows.Clear()
                        BunifuDataGridView1.Columns.Clear()
                        '00000

                        If x = 0 Then
                            boleano = True
                            coeficiente()
                            Resultado.Text = D_binomial
                            rellenar_Datagridcolumna(x)
                            rellenar_Datagridfila(D_binomial)
                        Else

                            For i = 0 To temporal - 1

                                x = i
                                coeficiente()
                                suma = suma + D_binomial
                                rellenar_Datagridcolumna(x)
                                rellenar_Datagridfila(D_binomial)
                            Next


                            Resultado.Text = suma
                            boleano = True

                        End If


                        If rango > 6 Then
                            BunifuDataGridView1.Rows.Clear()
                            BunifuDataGridView1.Columns.Clear()
                            MsgBox("El rango es superior a 6 numeros, no se mostraran datos en la tabla. Esto no afectara el resultado final", MsgBoxStyle.Information, "ATENCION")

                        End If



                    ElseIf ComboBox1.Text = "Igual y menor ( =< )" Then




                        boleano = False
                        x = T_exitos.Text
                        n = T_experimento.Text
                        temporal = x

                        'requerimiento de llenado data grid 0000
                        cont = 0
                        BunifuDataGridView1.Rows.Clear()
                        BunifuDataGridView1.Columns.Clear()
                        '00000



                        If x = 0 Then
                            boleano = True
                            coeficiente()
                            Resultado.Text = D_binomial

                            rellenar_Datagridcolumna(x)
                            rellenar_Datagridfila(D_binomial)
                        Else

                            For i = 0 To temporal

                                x = i
                                coeficiente()
                                suma = suma + D_binomial


                                rellenar_Datagridcolumna(x)
                                rellenar_Datagridfila(D_binomial)
                            Next


                            Resultado.Text = suma
                            boleano = True

                        End If

                        If rango > 6 Then
                            BunifuDataGridView1.Rows.Clear()
                            BunifuDataGridView1.Columns.Clear()
                            MsgBox("El rango es superior a 6 numeros, no se mostraran datos en la tabla. Esto no afectara el resultado final", MsgBoxStyle.Information, "ATENCION")

                        End If


                    End If








                Else
                    MsgBox("El campo ( p ) esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
                    P_ocurra.Focus()


                End If


            Else
                MsgBox("El campo ( x ) esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
                T_exitos.Focus()

            End If

        Else
            MsgBox("El campo ( n ) esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
            T_experimento.Focus()


        End If








    End Sub

    Sub coeficiente()
        'probabilidad de que ocurra
        If BunifuRadioButton2.Checked = True Then
            If p > 1 Then

                p = P_ocurra.Text / 100
                q = ((100 - P_ocurra.Text) / 100)
            End If
            BunifuCircleProgressbar1.Value = P_ocurra.Text * 100

        Else
            p = P_ocurra.Text / 100
            q = ((100 - P_ocurra.Text) / 100)
        End If



        q = Math.Abs(q)




        'Coeficiente Binomial 
        'Primera parte del algoritmo "suma factorial"

        n = T_experimento.Text

        If boleano = True Then
            x = T_exitos.Text
        End If


        Funcion.n_factorial(n)
        n_result = Funcion.retorno
        Funcion.n_factorial(x)
        x_result = Funcion.retorno
        Funcion.n_factorial(n - x)
        binomial = n_result / (x_result * (Funcion.retorno))

        'resultado finaal del proceso
        D_binomial = binomial * (p ^ x * (q ^ (n - x)))
        D_binomial = Math.Round(D_binomial, 5)



    End Sub

    Sub rellenar_Datagridcolumna(columna As String)

        Try
            ' 


            Dim col As New DataGridViewTextBoxColumn

            col.Name = columna
            If cont = 0 Then
                BunifuDataGridView1.Columns.Add(0, "x")

            End If



            BunifuDataGridView1.Columns.Add(col)



        Catch ex As Exception

        End Try



    End Sub

    Sub rellenar_Datagridfila(fila As String)

        Try
            If cont = 0 Then
                BunifuDataGridView1.Rows.Add("fx", fila)

            Else
                BunifuDataGridView1.Rows(0).Cells(cont + 1).Value = fila

            End If


            cont = cont + 1
        Catch ex As Exception

        End Try



    End Sub



    Private Sub Avance_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 2


        Try

            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-Es")
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Catch ex As Exception
            MsgBox("Error con la region , verifiquela o contacte con el desarrollador", MsgBoxStyle.Exclamation, "INFORMACION")
        End Try


    End Sub

    Private Sub T_experimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_experimento.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub T_exitos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_exitos.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub P_ocurra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P_ocurra.KeyPress


        If BunifuRadioButton1.Checked = True Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        ElseIf BunifuRadioButton2.Checked = True Then

            If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
               AndAlso (Not e.KeyChar = "." Or P_ocurra.Text.Contains(".")) Then
                e.Handled = True
            End If

        End If


    End Sub
End Class