<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Etiqueta1 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Boton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Novatostexto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.bunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bunifuImageButton2)
        Me.Panel1.Controls.Add(Me.pictureBox2)
        Me.Panel1.Controls.Add(Me.Etiqueta1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 42)
        Me.Panel1.TabIndex = 0
        '
        'bunifuImageButton2
        '
        Me.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuImageButton2.Image = CType(resources.GetObject("bunifuImageButton2.Image"), System.Drawing.Image)
        Me.bunifuImageButton2.ImageActive = Nothing
        Me.bunifuImageButton2.Location = New System.Drawing.Point(881, 6)
        Me.bunifuImageButton2.Name = "bunifuImageButton2"
        Me.bunifuImageButton2.Size = New System.Drawing.Size(32, 33)
        Me.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bunifuImageButton2.TabIndex = 5
        Me.bunifuImageButton2.TabStop = False
        Me.bunifuImageButton2.Zoom = 10
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(12, 8)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(24, 25)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 4
        Me.pictureBox2.TabStop = False
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Etiqueta1.ForeColor = System.Drawing.Color.White
        Me.Etiqueta1.Location = New System.Drawing.Point(47, 9)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(192, 21)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Proyecto de Estadistica"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Boton1
        '
        Me.Boton1.Active = False
        Me.Boton1.Activecolor = System.Drawing.Color.SteelBlue
        Me.Boton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Boton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton1.BorderRadius = 0
        Me.Boton1.ButtonText = "Primer avance"
        Me.Boton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Boton1.DisabledColor = System.Drawing.Color.Gray
        Me.Boton1.Iconcolor = System.Drawing.Color.Transparent
        Me.Boton1.Iconimage = CType(resources.GetObject("Boton1.Iconimage"), System.Drawing.Image)
        Me.Boton1.Iconimage_right = Nothing
        Me.Boton1.Iconimage_right_Selected = Nothing
        Me.Boton1.Iconimage_Selected = Nothing
        Me.Boton1.IconMarginLeft = 0
        Me.Boton1.IconMarginRight = 0
        Me.Boton1.IconRightVisible = True
        Me.Boton1.IconRightZoom = 0R
        Me.Boton1.IconVisible = True
        Me.Boton1.IconZoom = 120.0R
        Me.Boton1.IsTab = False
        Me.Boton1.Location = New System.Drawing.Point(51, 71)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.Boton1.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.Boton1.OnHoverTextColor = System.Drawing.Color.White
        Me.Boton1.selected = False
        Me.Boton1.Size = New System.Drawing.Size(241, 48)
        Me.Boton1.TabIndex = 1
        Me.Boton1.Text = "Primer avance"
        Me.Boton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton1.Textcolor = System.Drawing.Color.White
        Me.Boton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panel6
        '
        Me.panel6.BackColor = System.Drawing.Color.LightSlateGray
        Me.panel6.Location = New System.Drawing.Point(124, 140)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(750, 3)
        Me.panel6.TabIndex = 14
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Controls.Add(Me.Novatostexto)
        Me.PanelContenedor.Location = New System.Drawing.Point(12, 166)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(901, 310)
        Me.PanelContenedor.TabIndex = 15
        '
        'Novatostexto
        '
        Me.Novatostexto.AutoSize = True
        Me.Novatostexto.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Novatostexto.ForeColor = System.Drawing.Color.White
        Me.Novatostexto.Location = New System.Drawing.Point(315, 234)
        Me.Novatostexto.Name = "Novatostexto"
        Me.Novatostexto.Size = New System.Drawing.Size(283, 30)
        Me.Novatostexto.TabIndex = 6
        Me.Novatostexto.Text = "Novatos de Estadistica"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(320, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.panel6)
        Me.Controls.Add(Me.Boton1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecto de estadistica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Etiqueta1 As Label
    Friend WithEvents Boton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents bunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents panel6 As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Novatostexto As Label
End Class
