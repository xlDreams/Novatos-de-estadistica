<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avance_1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Avance_1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Etiqueta1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.pictureBox2)
        Me.Panel1.Controls.Add(Me.Etiqueta1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 35)
        Me.Panel1.TabIndex = 1
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(329, 3)
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
        Me.Etiqueta1.Location = New System.Drawing.Point(366, 5)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(192, 21)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Proyecto de Estadistica"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(11, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(79, 173)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(96, 52)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(79, 173)
        Me.ListBox2.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(181, 52)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(79, 173)
        Me.ListBox3.TabIndex = 4
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(266, 52)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(79, 173)
        Me.ListBox4.TabIndex = 5
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(351, 52)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(79, 173)
        Me.ListBox5.TabIndex = 6
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(436, 52)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(79, 173)
        Me.ListBox6.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.ListBox6)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox5)
        Me.GroupBox1.Controls.Add(Me.ListBox3)
        Me.GroupBox1.Controls.Add(Me.ListBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 231)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.LightCoral
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(109, 80)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.MaxLength = 32667
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(192, 35)
        Me.BunifuMetroTextbox1.TabIndex = 9
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Intervalo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "M"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "f"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "F"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "fr"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(466, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "f%"
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.Location = New System.Drawing.Point(12, 196)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(55, 225)
        Me.ListBox7.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Muestra"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.LightCoral
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(109, 123)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.MaxLength = 32667
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(192, 35)
        Me.BunifuMetroTextbox2.TabIndex = 15
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Datos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Lista de datos"
        '
        'Avance_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Avance_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avance_1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents Etiqueta1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
