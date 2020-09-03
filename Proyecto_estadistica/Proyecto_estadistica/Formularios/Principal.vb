Public Class Principal








    Private Sub Abrirform(ByVal formhijo As Object)
        If (Me.PanelContenedor.Controls.Count > 0) Then
            Me.PanelContenedor.Controls.RemoveAt(0)
            Dim fh As Form = TryCast(formhijo, Form)
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()
        End If
    End Sub
    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Novatostexto.Visible = False
        Abrirform(Avance_1)

    End Sub

    Private Sub bunifuImageButton2_Click(sender As Object, e As EventArgs) Handles bunifuImageButton2.Click
        Me.Close()

    End Sub


End Class
