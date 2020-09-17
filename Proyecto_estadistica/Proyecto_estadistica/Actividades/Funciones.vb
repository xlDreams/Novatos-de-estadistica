Public Class Funciones
    Sub Ordenar_Listbox(ByVal Listbox7 As ListBox)
        ' Metodo de burbuja es esta wea xD
        Dim Auxiliar As Double

        For k = 0 To 1
            For i = 0 To Listbox7.Items.Count - 1
                For j = 0 To Listbox7.Items.Count - 1
                    If (Listbox7.Items.Item(j) > Listbox7.Items.Item(i)) Then
                        Auxiliar = Listbox7.Items.Item(j)
                        Listbox7.Items.Item(j) = Listbox7.Items.Item(i)
                        Listbox7.Items.Item(i) = Auxiliar
                    End If
                Next
            Next
        Next






    End Sub



End Class
