<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modifica_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_modifica_cliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_añadir = New System.Windows.Forms.Button()
        Me.gbo_datos_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_codigo_client = New System.Windows.Forms.TextBox()
        Me.gbo_a = New System.Windows.Forms.GroupBox()
        Me.txt_nombre_empresa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_b = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_apellido1_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txt_apelldio2_cliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cedula_cliente = New System.Windows.Forms.TextBox()
        Me.gbo_c = New System.Windows.Forms.GroupBox()
        Me.cbo_ciudad = New System.Windows.Forms.ComboBox()
        Me.txt_email_cliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.txt_telefono_cliente = New System.Windows.Forms.TextBox()
        Me.txt_web = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_fax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbo_categoria_cliente = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbo_datos_cliente.SuspendLayout()
        Me.gbo_a.SuspendLayout()
        Me.gbo_b.SuspendLayout()
        Me.gbo_c.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_añadir)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 456)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 41)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(397, 12)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(88, 23)
        Me.btn_cancelar.TabIndex = 15
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_añadir
        '
        Me.btn_añadir.Location = New System.Drawing.Point(286, 12)
        Me.btn_añadir.Name = "btn_añadir"
        Me.btn_añadir.Size = New System.Drawing.Size(96, 23)
        Me.btn_añadir.TabIndex = 14
        Me.btn_añadir.Text = "Aceptar"
        Me.btn_añadir.UseVisualStyleBackColor = True
        '
        'gbo_datos_cliente
        '
        Me.gbo_datos_cliente.Controls.Add(Me.txt_codigo_client)
        Me.gbo_datos_cliente.Controls.Add(Me.gbo_a)
        Me.gbo_datos_cliente.Controls.Add(Me.gbo_b)
        Me.gbo_datos_cliente.Controls.Add(Me.gbo_c)
        Me.gbo_datos_cliente.Controls.Add(Me.PictureBox1)
        Me.gbo_datos_cliente.Controls.Add(Me.Label20)
        Me.gbo_datos_cliente.Controls.Add(Me.cbo_categoria_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label9)
        Me.gbo_datos_cliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbo_datos_cliente.Location = New System.Drawing.Point(8, 10)
        Me.gbo_datos_cliente.Name = "gbo_datos_cliente"
        Me.gbo_datos_cliente.Size = New System.Drawing.Size(507, 443)
        Me.gbo_datos_cliente.TabIndex = 63
        Me.gbo_datos_cliente.TabStop = False
        Me.gbo_datos_cliente.Text = "Datos"
        '
        'txt_codigo_client
        '
        Me.txt_codigo_client.Location = New System.Drawing.Point(420, 232)
        Me.txt_codigo_client.Name = "txt_codigo_client"
        Me.txt_codigo_client.Size = New System.Drawing.Size(65, 20)
        Me.txt_codigo_client.TabIndex = 66
        Me.txt_codigo_client.Visible = False
        '
        'gbo_a
        '
        Me.gbo_a.Controls.Add(Me.txt_nombre_empresa)
        Me.gbo_a.Controls.Add(Me.Label14)
        Me.gbo_a.Controls.Add(Me.Label3)
        Me.gbo_a.Location = New System.Drawing.Point(9, 65)
        Me.gbo_a.Name = "gbo_a"
        Me.gbo_a.Size = New System.Drawing.Size(398, 40)
        Me.gbo_a.TabIndex = 63
        Me.gbo_a.TabStop = False
        '
        'txt_nombre_empresa
        '
        Me.txt_nombre_empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_empresa.Location = New System.Drawing.Point(177, 14)
        Me.txt_nombre_empresa.MaxLength = 50
        Me.txt_nombre_empresa.Name = "txt_nombre_empresa"
        Me.txt_nombre_empresa.Size = New System.Drawing.Size(176, 20)
        Me.txt_nombre_empresa.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(362, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Nombre Empresa u Organización"
        '
        'gbo_b
        '
        Me.gbo_b.Controls.Add(Me.Label8)
        Me.gbo_b.Controls.Add(Me.txt_apellido1_cliente)
        Me.gbo_b.Controls.Add(Me.txt_nombre_cliente)
        Me.gbo_b.Controls.Add(Me.txt_apelldio2_cliente)
        Me.gbo_b.Controls.Add(Me.Label4)
        Me.gbo_b.Controls.Add(Me.Label2)
        Me.gbo_b.Controls.Add(Me.Label1)
        Me.gbo_b.Controls.Add(Me.Label15)
        Me.gbo_b.Controls.Add(Me.Label16)
        Me.gbo_b.Controls.Add(Me.Label21)
        Me.gbo_b.Controls.Add(Me.txt_cedula_cliente)
        Me.gbo_b.Location = New System.Drawing.Point(9, 111)
        Me.gbo_b.Name = "gbo_b"
        Me.gbo_b.Size = New System.Drawing.Size(398, 121)
        Me.gbo_b.TabIndex = 64
        Me.gbo_b.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(360, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "*"
        '
        'txt_apellido1_cliente
        '
        Me.txt_apellido1_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido1_cliente.Location = New System.Drawing.Point(177, 57)
        Me.txt_apellido1_cliente.MaxLength = 40
        Me.txt_apellido1_cliente.Name = "txt_apellido1_cliente"
        Me.txt_apellido1_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_apellido1_cliente.TabIndex = 5
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(177, 32)
        Me.txt_nombre_cliente.MaxLength = 40
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_nombre_cliente.TabIndex = 4
        '
        'txt_apelldio2_cliente
        '
        Me.txt_apelldio2_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apelldio2_cliente.Location = New System.Drawing.Point(177, 83)
        Me.txt_apelldio2_cliente.MaxLength = 40
        Me.txt_apelldio2_cliente.Name = "txt_apelldio2_cliente"
        Me.txt_apelldio2_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_apelldio2_cliente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Apellido Materno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(362, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(361, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(32, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Cedula"
        '
        'txt_cedula_cliente
        '
        Me.txt_cedula_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cedula_cliente.Location = New System.Drawing.Point(177, 7)
        Me.txt_cedula_cliente.MaxLength = 10
        Me.txt_cedula_cliente.Name = "txt_cedula_cliente"
        Me.txt_cedula_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_cedula_cliente.TabIndex = 3
        '
        'gbo_c
        '
        Me.gbo_c.Controls.Add(Me.cbo_ciudad)
        Me.gbo_c.Controls.Add(Me.txt_email_cliente)
        Me.gbo_c.Controls.Add(Me.Label7)
        Me.gbo_c.Controls.Add(Me.Label25)
        Me.gbo_c.Controls.Add(Me.Label6)
        Me.gbo_c.Controls.Add(Me.Label23)
        Me.gbo_c.Controls.Add(Me.txt_direccion_cliente)
        Me.gbo_c.Controls.Add(Me.Label18)
        Me.gbo_c.Controls.Add(Me.Label5)
        Me.gbo_c.Controls.Add(Me.txt_celular)
        Me.gbo_c.Controls.Add(Me.txt_telefono_cliente)
        Me.gbo_c.Controls.Add(Me.txt_web)
        Me.gbo_c.Controls.Add(Me.Label17)
        Me.gbo_c.Controls.Add(Me.Label12)
        Me.gbo_c.Controls.Add(Me.Label11)
        Me.gbo_c.Controls.Add(Me.txt_fax)
        Me.gbo_c.Controls.Add(Me.Label10)
        Me.gbo_c.Location = New System.Drawing.Point(6, 232)
        Me.gbo_c.Name = "gbo_c"
        Me.gbo_c.Size = New System.Drawing.Size(401, 198)
        Me.gbo_c.TabIndex = 65
        Me.gbo_c.TabStop = False
        '
        'cbo_ciudad
        '
        Me.cbo_ciudad.FormattingEnabled = True
        Me.cbo_ciudad.Items.AddRange(New Object() {"Santa Elena", "Guayaquil", "Cuenca", "Quito", "Manabi", "Los Rios", "El Oro", "Esmeraldas", "Otros"})
        Me.cbo_ciudad.Location = New System.Drawing.Point(177, 89)
        Me.cbo_ciudad.Name = "cbo_ciudad"
        Me.cbo_ciudad.Size = New System.Drawing.Size(121, 22)
        Me.cbo_ciudad.TabIndex = 10
        '
        'txt_email_cliente
        '
        Me.txt_email_cliente.Location = New System.Drawing.Point(177, 117)
        Me.txt_email_cliente.MaxLength = 50
        Me.txt_email_cliente.Name = "txt_email_cliente"
        Me.txt_email_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_email_cliente.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Telefono"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(362, 115)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 20)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(34, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(362, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 20)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "*"
        '
        'txt_direccion_cliente
        '
        Me.txt_direccion_cliente.Location = New System.Drawing.Point(177, 63)
        Me.txt_direccion_cliente.MaxLength = 100
        Me.txt_direccion_cliente.Name = "txt_direccion_cliente"
        Me.txt_direccion_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_direccion_cliente.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(32, 92)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(33, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Direccion"
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(177, 38)
        Me.txt_celular.MaxLength = 10
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(128, 20)
        Me.txt_celular.TabIndex = 8
        '
        'txt_telefono_cliente
        '
        Me.txt_telefono_cliente.Location = New System.Drawing.Point(177, 12)
        Me.txt_telefono_cliente.MaxLength = 10
        Me.txt_telefono_cliente.Name = "txt_telefono_cliente"
        Me.txt_telefono_cliente.Size = New System.Drawing.Size(128, 20)
        Me.txt_telefono_cliente.TabIndex = 7
        '
        'txt_web
        '
        Me.txt_web.Location = New System.Drawing.Point(178, 167)
        Me.txt_web.MaxLength = 100
        Me.txt_web.Name = "txt_web"
        Me.txt_web.Size = New System.Drawing.Size(175, 20)
        Me.txt_web.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(361, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(33, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Celular"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(34, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Pagina web"
        '
        'txt_fax
        '
        Me.txt_fax.Location = New System.Drawing.Point(178, 144)
        Me.txt_fax.MaxLength = 40
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(120, 20)
        Me.txt_fax.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(34, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Fax"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Sistema_Planificacion_Tareas.My.Resources.Resources.Office_Client_Male_Light_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(424, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 85)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(323, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "*"
        '
        'cbo_categoria_cliente
        '
        Me.cbo_categoria_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_categoria_cliente.DisplayMember = "DESCRIPCION"
        Me.cbo_categoria_cliente.FormattingEnabled = True
        Me.cbo_categoria_cliente.Location = New System.Drawing.Point(185, 25)
        Me.cbo_categoria_cliente.Name = "cbo_categoria_cliente"
        Me.cbo_categoria_cliente.Size = New System.Drawing.Size(127, 22)
        Me.cbo_categoria_cliente.TabIndex = 1
        Me.cbo_categoria_cliente.ValueMember = "ID_TIPO_CLIENTE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(40, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Categoria"
        '
        'frm_modifica_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_datos_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_modifica_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbo_datos_cliente.ResumeLayout(False)
        Me.gbo_datos_cliente.PerformLayout()
        Me.gbo_a.ResumeLayout(False)
        Me.gbo_a.PerformLayout()
        Me.gbo_b.ResumeLayout(False)
        Me.gbo_b.PerformLayout()
        Me.gbo_c.ResumeLayout(False)
        Me.gbo_c.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_añadir As System.Windows.Forms.Button
    Friend WithEvents gbo_datos_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_a As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre_empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbo_b As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido1_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_apelldio2_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_cliente As System.Windows.Forms.TextBox
    Friend WithEvents gbo_c As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_email_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_web As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbo_categoria_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_client As System.Windows.Forms.TextBox
End Class
