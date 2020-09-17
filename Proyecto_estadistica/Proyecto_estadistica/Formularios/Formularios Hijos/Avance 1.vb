Imports System.Globalization
Public Class Avance_1

    Dim Muestra As Integer
    Dim datomaximo As Double
    Dim datominimo As Double
    Dim count As Integer
    Dim contador As Integer = 1
    Dim Funcion As New Funciones
    Dim Interv As Double
    Dim condicion As Boolean = False




    Sub RellenarDatagreid()




        Dim temp As Double
        Dim datom As Double = datominimo
        Dim marca As Double
        Dim frecuencia As Integer
        Dim F_acumulada As Integer
        Dim frecuencia_R As Double
        Dim porcentaje As Double
        For i = 0 To Interv - 1
            temp = Math.Round(datom + Label10.Text, 3)

            'Calculo de la marca de clase
            marca = Math.Round((datom + temp) / 2, 3)
            'Calculo de la frecuencia de un numero

            'Funcion.Buscarfrecuencia(ListBox7, temp, datom, frecuencia)

            For j = 0 To ListBox7.Items.Count - 1
                If (ListBox7.Items.Item(j)) >= datom Then
                    If (ListBox7.Items.Item(j)) < temp Then

                        frecuencia = frecuencia + 1
                    ElseIf i = Interv - 1 Then
                        frecuencia = frecuencia + 1

                    End If
                End If
            Next



            F_acumulada = F_acumulada + frecuencia
            frecuencia_R = Math.Round(frecuencia / Muestra, 3)
            porcentaje = Math.Round(frecuencia_R * 100, 3)

            BunifuDataGridView1.Rows.Add(datom.ToString + " - " + temp.ToString, marca.ToString, frecuencia.ToString, F_acumulada.ToString, frecuencia_R.ToString, "% " + porcentaje.ToString)
            frecuencia = 0
            datom = temp

        Next


        media()
        mediana()


        'BunifuDataGridView1.Rows(0).Cells(2).Value = "prueba3"
        'BunifuDataGridView1.Rows(0).Cells(3).Value = "prueba4"
        'BunifuDataGridView1.Rows(0).Cells(4).Value = "prueba5"
        ' BunifuDataGridView1.Rows(0).Cells(5).Value = "prueba6"


    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim verificacion As String = ""
        If BunifuMetroTextbox1.Text.ToString <> "" Then
            If BunifuMetroTextbox1.Text > 0 Then

                BunifuMetroTextbox1.Enabled = False

                Muestra = BunifuMetroTextbox1.Text
                BunifuButton1.Enabled = False
                BunifuButton2.Enabled = True
                BunifuMetroTextbox2.Enabled = True

            Else
                MsgBox("El campo contiene un valor Nulo Verifique", MsgBoxStyle.Information, "ATENCION")
                BunifuMetroTextbox1.Text = Nothing
                BunifuMetroTextbox1.Focus()
            End If
        Else
            BunifuMetroTextbox1.Focus()
            MsgBox("El campo esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
        End If


    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        If BunifuMetroTextbox2.Text.ToString <> "" Then
            If BunifuMetroTextbox2.Text > 0 Then

                If condicion = False Then

                    ListBox7.Items.Add(BunifuMetroTextbox2.Text)
                End If




                If ListBox7.Items.Count = Muestra Then
                    BunifuButton4.Enabled = True
                    BunifuMetroTextbox2.Enabled = False

                    'llamando la funcion de ordenar
                    Funcion.Ordenar_Listbox(ListBox7)

                    datominimo = ListBox7.Items(0).ToString
                    count = ListBox7.Items.Count - 1
                    datomaximo = ListBox7.Items(count).ToString
                    Rango.Text = datomaximo - datominimo

                    'Funcion para saber el intervalo , es recomendable que el numero sea impar
                    If BunifuCheckBox2.Checked = True Then
                        If BunifuMetroTextbox3.Text <> "" Then
                            If BunifuMetroTextbox3.Text > 0 Then
                                Interv = BunifuMetroTextbox3.Text
                            Else
                                MsgBox("El campo del INTERVALO esta vacio, se tomara el intervalo seguna la ''FORMULA DE STRUGLES'' ", MsgBoxStyle.Information, "ATENCION")
                                GoTo ETIQUETA
                            End If

                        Else
                            MsgBox("El campo del INTERVALO esta vacio, se tomara el intervalo seguna la ''FORMULA DE STRUGLES'' ", MsgBoxStyle.Information, "ATENCION")
                            GoTo ETIQUETA
                        End If
                    Else
ETIQUETA:
                        Interv = Math.Round(1 + 3.322 * Math.Log(Muestra, 10)).ToString
                        Label4.Text = Interv Mod 2
                        If Label4.Text = 0 Then
                            Label4.Text = Interv + 1
                        Else
                            Label4.Text = Interv
                        End If
                        Interv = Label4.Text
                    End If

                    'AMPLITUD 
                    If BunifuCheckBox1.Checked = True Then
                        Dim temporal As Double

                        temporal = Math.Round(Rango.Text / Interv, 3)
                        Label10.Text = Math.Round(temporal + 0.5)
                        If Label10.Text < 1 Then
                            Label10.Text = 1
                        End If
                    Else
                        Label10.Text = Math.Round(Rango.Text / Interv, 3)
                    End If



                    RellenarDatagreid()
                    Label4.Text = Interv
                End If
                BunifuMetroTextbox2.Text = ""
                'contador = contador + 1


            Else
                MsgBox("El campo 'DATOS' contiene un valor Nulo Verifique", MsgBoxStyle.Information, "ATENCION")
                BunifuMetroTextbox2.Text = Nothing
                BunifuMetroTextbox2.Focus()
            End If
        Else
            BunifuMetroTextbox2.Focus()
            MsgBox("El campo esta vacio Verifique", MsgBoxStyle.Information, "ATENCION")
        End If

    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            BunifuButton1.PerformClick()

        End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub BunifuMetroTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            BunifuButton2.PerformClick()

        End If


        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
           AndAlso (Not e.KeyChar = "." Or BunifuMetroTextbox2.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        BunifuDataGridView1.Rows.Clear()
        ListBox7.Items.Clear()
        Rango.Text = ""
        Label4.Text = ""
        Label10.Text = ""
        Label15.Text = ""
        Label17.Text = ""
        Label19.Text = ""
        BunifuButton4.Enabled = False
        BunifuMetroTextbox1.Text = Nothing
        BunifuMetroTextbox2.Text = Nothing
        BunifuMetroTextbox3.Text = Nothing

        BunifuMetroTextbox1.Enabled = True
        BunifuButton1.Enabled = True
        contador = 0
        BunifuMetroTextbox2.Enabled = False

        condicion = False

    End Sub


    Sub media()
        Dim valor1 As Double
        Dim valor2 As Double
        Dim media As Double
        For Each row As DataGridViewRow In Me.BunifuDataGridView1.Rows
            valor1 = row.Cells(1).Value
            valor2 = row.Cells(2).Value
            media = media + (valor1 * valor2)

        Next
        media = Math.Round(media / Muestra, 3)
        Label15.Text = media.ToString
    End Sub



    Sub mediana()
        Dim valor1 As String
        Dim valor2 As Double
        Dim valor3 As Double
        Dim mediana As Double
        Dim Calcular_n As Double
        Dim auxiliar As Integer = 1
        Dim indice As Integer
        Dim valor_anterior As Integer
        Dim valor_anterior_f As Integer
        Dim tempo As Integer
        Dim moda As Double
        Dim limite As Double




        Calcular_n = Muestra / 2

        For Each row As DataGridViewRow In Me.BunifuDataGridView1.Rows

            'limite
            valor3 = row.Cells(3).Value
            valor1 = row.Cells(0).Value
            valor2 = row.Cells(2).Value

            If valor3 >= Calcular_n Then

                If auxiliar = 1 Then
                    indice = row.Index


                    valor1 = Microsoft.VisualBasic.Left(valor1, 5)
                    Dim palabra As String = valor1
                    Dim Lista() As String = palabra.Split("-")
                    valor1 = Lista(0)

                    mediana = Calcular_n - valor_anterior
                    mediana = mediana / valor2
                    mediana = mediana * Label10.Text
                    mediana = Math.Round(mediana + valor1, 3)
                    Label17.Text = mediana
                    limite = valor1
                    tempo = valor_anterior_f

                ElseIf auxiliar = 2 Then

                    tempo = valor_anterior_f - tempo
                    moda = tempo + (valor_anterior_f - valor2)
                    moda = tempo / moda
                    moda = moda * Label10.Text
                    moda = Math.Round(moda + limite, 4)
                    Label19.Text = moda
                End If

                auxiliar = auxiliar + 1




            End If



            valor_anterior_f = row.Cells(2).Value
            valor_anterior = row.Cells(3).Value




        Next

    End Sub



    Sub extrear(ByVal cadena As String)

        'Creamos una función publica que se encargue de extraer solo números



    End Sub

    Private Sub Avance_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BunifuCheckBox2_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox2.CheckedChanged
        If BunifuCheckBox2.Checked = True Then
            BunifuMetroTextbox3.Enabled = True
        Else
            BunifuMetroTextbox3.Text = Nothing
            BunifuMetroTextbox3.Enabled = False
        End If
    End Sub

    Private Sub BunifuMetroTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox3.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        BunifuDataGridView1.Rows.Clear()
        Rango.Text = ""
        Label4.Text = ""
        Label10.Text = ""
        Label15.Text = ""
        Label17.Text = ""
        Label19.Text = ""
        BunifuCheckBox2.Checked = True
        contador = 0
        condicion = True

        Try
etiquet:
            BunifuMetroTextbox3.Text = InputBox("Introduzca el nuevo intervalo", "Actualizar Intervalo")
            BunifuMetroTextbox2.Text = 1
            If BunifuMetroTextbox3.Text > 0 Then
                Interv = BunifuMetroTextbox3.Text
                BunifuButton2.PerformClick()
            Else
                GoTo etiquet
            End If


        Catch ex As Exception
            BunifuMetroTextbox3.Text = Nothing
            MsgBox("Debe ingresar un dato valido", MsgBoxStyle.Critical, "INFORMACION")
            GoTo etiquet
        End Try

        BunifuMetroTextbox2.Text = Nothing

    End Sub

    Private Sub BunifuMetroTextbox1_MouseHover(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.MouseHover
        ttinfo.SetToolTip(BunifuMetroTextbox1, "Ingrese aqui solo Numeros Enteros")
        ttinfo.ToolTipTitle = "Informaciòn"
        ttinfo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BunifuCheckBox2_MouseHover(sender As Object, e As EventArgs) Handles BunifuCheckBox2.MouseHover
        ttinfo.SetToolTip(BunifuCheckBox2, "Activar el intervalo")
        ttinfo.ToolTipTitle = "Informaciòn"
        ttinfo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BunifuCheckBox1_MouseHover(sender As Object, e As EventArgs) Handles BunifuCheckBox1.MouseHover
        ttinfo.SetToolTip(BunifuCheckBox1, "Marcar antes de ingresar datos")
        ttinfo.ToolTipTitle = "Informaciòn"
        ttinfo.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class