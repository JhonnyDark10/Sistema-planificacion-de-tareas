<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empleados))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbo_datos_cliente = New System.Windows.Forms.GroupBox()
        Me.cbo_comi = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbo_ciudad = New System.Windows.Forms.ComboBox()
        Me.cbo_estado_c = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbo_depar = New System.Windows.Forms.ComboBox()
        Me.txt_Celular = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cedula_cliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefono_cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_email_cliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_apelldio2_cliente = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_apellido1_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbo_dias_se = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Num_sabados_fin = New System.Windows.Forms.DateTimePicker()
        Me.a1 = New System.Windows.Forms.Label()
        Me.a2 = New System.Windows.Forms.Label()
        Me.a3 = New System.Windows.Forms.Label()
        Me.a4 = New System.Windows.Forms.Label()
        Me.a5 = New System.Windows.Forms.Label()
        Me.a6 = New System.Windows.Forms.Label()
        Me.a7 = New System.Windows.Forms.Label()
        Me.Num_lunes_ini = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Num_martes_ini = New System.Windows.Forms.DateTimePicker()
        Me.Num_domingos_fin = New System.Windows.Forms.DateTimePicker()
        Me.Num_miercoles_ini = New System.Windows.Forms.DateTimePicker()
        Me.Num_jueves_ini = New System.Windows.Forms.DateTimePicker()
        Me.Num_viernes_fin = New System.Windows.Forms.DateTimePicker()
        Me.Num_viernes_ini = New System.Windows.Forms.DateTimePicker()
        Me.Num_jueves_fin = New System.Windows.Forms.DateTimePicker()
        Me.Num_sabado_ini = New System.Windows.Forms.DateTimePicker()
        Me.Num_miercoles_fin = New System.Windows.Forms.DateTimePicker()
        Me.Num_domingo_ini = New System.Windows.Forms.DateTimePicker()
        Me.Num_martes_fin = New System.Windows.Forms.DateTimePicker()
        Me.Num_lunes_fin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_domingos = New System.Windows.Forms.TextBox()
        Me.txt_sabados = New System.Windows.Forms.TextBox()
        Me.txt_viernes = New System.Windows.Forms.TextBox()
        Me.txt_jueves = New System.Windows.Forms.TextBox()
        Me.txt_miercoles = New System.Windows.Forms.TextBox()
        Me.txt_martes = New System.Windows.Forms.TextBox()
        Me.txt_lunes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ochomas7 = New System.Windows.Forms.DateTimePicker()
        Me.ochomas6 = New System.Windows.Forms.DateTimePicker()
        Me.ochomas5 = New System.Windows.Forms.DateTimePicker()
        Me.ochomas4 = New System.Windows.Forms.DateTimePicker()
        Me.ochomas3 = New System.Windows.Forms.DateTimePicker()
        Me.ochomas2 = New System.Windows.Forms.DateTimePicker()
        Me.ochomas1 = New System.Windows.Forms.DateTimePicker()
        Me.ocho = New System.Windows.Forms.DateTimePicker()
        Me.ch_lunes = New System.Windows.Forms.CheckBox()
        Me.ch_domingos = New System.Windows.Forms.CheckBox()
        Me.ch_sabados = New System.Windows.Forms.CheckBox()
        Me.ch_viernes = New System.Windows.Forms.CheckBox()
        Me.ch_jueves = New System.Windows.Forms.CheckBox()
        Me.ch_miercoles = New System.Windows.Forms.CheckBox()
        Me.ch_martes = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_espacio = New System.Windows.Forms.RadioButton()
        Me.rb_horas = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbo_datos_cliente.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbo_dias_se.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(649, 412)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.gbo_datos_cliente)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(641, 386)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        '
        'gbo_datos_cliente
        '
        Me.gbo_datos_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbo_datos_cliente.Controls.Add(Me.cbo_comi)
        Me.gbo_datos_cliente.Controls.Add(Me.Label24)
        Me.gbo_datos_cliente.Controls.Add(Me.Label20)
        Me.gbo_datos_cliente.Controls.Add(Me.PictureBox1)
        Me.gbo_datos_cliente.Controls.Add(Me.Label13)
        Me.gbo_datos_cliente.Controls.Add(Me.cbo_ciudad)
        Me.gbo_datos_cliente.Controls.Add(Me.cbo_estado_c)
        Me.gbo_datos_cliente.Controls.Add(Me.Label1)
        Me.gbo_datos_cliente.Controls.Add(Me.Label25)
        Me.gbo_datos_cliente.Controls.Add(Me.Label23)
        Me.gbo_datos_cliente.Controls.Add(Me.Label2)
        Me.gbo_datos_cliente.Controls.Add(Me.Label22)
        Me.gbo_datos_cliente.Controls.Add(Me.cbo_depar)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_Celular)
        Me.gbo_datos_cliente.Controls.Add(Me.Label12)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_descripcion)
        Me.gbo_datos_cliente.Controls.Add(Me.Label3)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_cedula_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label21)
        Me.gbo_datos_cliente.Controls.Add(Me.Label17)
        Me.gbo_datos_cliente.Controls.Add(Me.Label16)
        Me.gbo_datos_cliente.Controls.Add(Me.Label15)
        Me.gbo_datos_cliente.Controls.Add(Me.Label4)
        Me.gbo_datos_cliente.Controls.Add(Me.Label5)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_telefono_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label6)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_email_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label7)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_direccion_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label8)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_apelldio2_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label26)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_apellido1_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_nombre_cliente)
        Me.gbo_datos_cliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbo_datos_cliente.Location = New System.Drawing.Point(6, 6)
        Me.gbo_datos_cliente.Name = "gbo_datos_cliente"
        Me.gbo_datos_cliente.Size = New System.Drawing.Size(621, 374)
        Me.gbo_datos_cliente.TabIndex = 28
        Me.gbo_datos_cliente.TabStop = False
        '
        'cbo_comi
        '
        Me.cbo_comi.DisplayMember = "DESCRIPCION"
        Me.cbo_comi.FormattingEnabled = True
        Me.cbo_comi.Location = New System.Drawing.Point(108, 102)
        Me.cbo_comi.Name = "cbo_comi"
        Me.cbo_comi.Size = New System.Drawing.Size(153, 22)
        Me.cbo_comi.TabIndex = 2
        Me.cbo_comi.ValueMember = "ID_COMISIONES"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 14)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Comisión"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(492, 305)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(313, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Ciudad:"
        '
        'cbo_ciudad
        '
        Me.cbo_ciudad.FormattingEnabled = True
        Me.cbo_ciudad.Items.AddRange(New Object() {"Santa Elena", "Guayaquil", "Cuenca", "Manabi", "Esmeraldas", "Los Rios", "El oro", "Otros"})
        Me.cbo_ciudad.Location = New System.Drawing.Point(384, 229)
        Me.cbo_ciudad.Name = "cbo_ciudad"
        Me.cbo_ciudad.Size = New System.Drawing.Size(121, 22)
        Me.cbo_ciudad.TabIndex = 11
        '
        'cbo_estado_c
        '
        Me.cbo_estado_c.DisplayMember = "descripcion"
        Me.cbo_estado_c.FormattingEnabled = True
        Me.cbo_estado_c.Location = New System.Drawing.Point(383, 102)
        Me.cbo_estado_c.Name = "cbo_estado_c"
        Me.cbo_estado_c.Size = New System.Drawing.Size(121, 22)
        Me.cbo_estado_c.TabIndex = 8
        Me.cbo_estado_c.ValueMember = "ID_ESTADO_CIVIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(595, 268)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 20)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(596, 186)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 20)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado Civil:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(268, 268)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 20)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "*"
        '
        'cbo_depar
        '
        Me.cbo_depar.DisplayMember = "nombre"
        Me.cbo_depar.FormattingEnabled = True
        Me.cbo_depar.Location = New System.Drawing.Point(108, 57)
        Me.cbo_depar.Name = "cbo_depar"
        Me.cbo_depar.Size = New System.Drawing.Size(153, 22)
        Me.cbo_depar.TabIndex = 1
        Me.cbo_depar.ValueMember = "DNI_DEPARTAMENTO"
        '
        'txt_Celular
        '
        Me.txt_Celular.Location = New System.Drawing.Point(383, 307)
        Me.txt_Celular.MaxLength = 10
        Me.txt_Celular.Name = "txt_Celular"
        Me.txt_Celular.Size = New System.Drawing.Size(103, 20)
        Me.txt_Celular.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(316, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Celular:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion.Location = New System.Drawing.Point(384, 147)
        Me.txt_descripcion.MaxLength = 50
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(206, 20)
        Me.txt_descripcion.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(312, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Descripción:"
        '
        'txt_cedula_cliente
        '
        Me.txt_cedula_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cedula_cliente.Location = New System.Drawing.Point(108, 149)
        Me.txt_cedula_cliente.MaxLength = 10
        Me.txt_cedula_cliente.Name = "txt_cedula_cliente"
        Me.txt_cedula_cliente.Size = New System.Drawing.Size(153, 20)
        Me.txt_cedula_cliente.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(17, 151)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Cedula:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(268, 227)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(268, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(268, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombres:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Apellido Materno:"
        '
        'txt_telefono_cliente
        '
        Me.txt_telefono_cliente.Location = New System.Drawing.Point(108, 307)
        Me.txt_telefono_cliente.MaxLength = 10
        Me.txt_telefono_cliente.Name = "txt_telefono_cliente"
        Me.txt_telefono_cliente.Size = New System.Drawing.Size(103, 20)
        Me.txt_telefono_cliente.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Apellido Paterno:"
        '
        'txt_email_cliente
        '
        Me.txt_email_cliente.Location = New System.Drawing.Point(383, 270)
        Me.txt_email_cliente.MaxLength = 30
        Me.txt_email_cliente.Name = "txt_email_cliente"
        Me.txt_email_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_email_cliente.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(313, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Direccion:"
        '
        'txt_direccion_cliente
        '
        Me.txt_direccion_cliente.Location = New System.Drawing.Point(384, 188)
        Me.txt_direccion_cliente.MaxLength = 50
        Me.txt_direccion_cliente.Name = "txt_direccion_cliente"
        Me.txt_direccion_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_direccion_cliente.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(315, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email:"
        '
        'txt_apelldio2_cliente
        '
        Me.txt_apelldio2_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apelldio2_cliente.Location = New System.Drawing.Point(108, 270)
        Me.txt_apelldio2_cliente.MaxLength = 20
        Me.txt_apelldio2_cliente.Name = "txt_apelldio2_cliente"
        Me.txt_apelldio2_cliente.Size = New System.Drawing.Size(153, 20)
        Me.txt_apelldio2_cliente.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(14, 315)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Telefono:"
        '
        'txt_apellido1_cliente
        '
        Me.txt_apellido1_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido1_cliente.Location = New System.Drawing.Point(108, 229)
        Me.txt_apellido1_cliente.MaxLength = 20
        Me.txt_apellido1_cliente.Name = "txt_apellido1_cliente"
        Me.txt_apellido1_cliente.Size = New System.Drawing.Size(153, 20)
        Me.txt_apellido1_cliente.TabIndex = 5
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(108, 188)
        Me.txt_nombre_cliente.MaxLength = 20
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(153, 20)
        Me.txt_nombre_cliente.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.gbo_dias_se)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(641, 386)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Horarios"
        '
        'gbo_dias_se
        '
        Me.gbo_dias_se.Controls.Add(Me.GroupBox4)
        Me.gbo_dias_se.Controls.Add(Me.GroupBox3)
        Me.gbo_dias_se.Controls.Add(Me.ochomas7)
        Me.gbo_dias_se.Controls.Add(Me.ochomas6)
        Me.gbo_dias_se.Controls.Add(Me.ochomas5)
        Me.gbo_dias_se.Controls.Add(Me.ochomas4)
        Me.gbo_dias_se.Controls.Add(Me.ochomas3)
        Me.gbo_dias_se.Controls.Add(Me.ochomas2)
        Me.gbo_dias_se.Controls.Add(Me.ochomas1)
        Me.gbo_dias_se.Controls.Add(Me.ocho)
        Me.gbo_dias_se.Controls.Add(Me.ch_lunes)
        Me.gbo_dias_se.Controls.Add(Me.ch_domingos)
        Me.gbo_dias_se.Controls.Add(Me.ch_sabados)
        Me.gbo_dias_se.Controls.Add(Me.ch_viernes)
        Me.gbo_dias_se.Controls.Add(Me.ch_jueves)
        Me.gbo_dias_se.Controls.Add(Me.ch_miercoles)
        Me.gbo_dias_se.Controls.Add(Me.ch_martes)
        Me.gbo_dias_se.Location = New System.Drawing.Point(22, 87)
        Me.gbo_dias_se.Name = "gbo_dias_se"
        Me.gbo_dias_se.Size = New System.Drawing.Size(601, 272)
        Me.gbo_dias_se.TabIndex = 34
        Me.gbo_dias_se.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Num_sabados_fin)
        Me.GroupBox4.Controls.Add(Me.a1)
        Me.GroupBox4.Controls.Add(Me.a2)
        Me.GroupBox4.Controls.Add(Me.a3)
        Me.GroupBox4.Controls.Add(Me.a4)
        Me.GroupBox4.Controls.Add(Me.a5)
        Me.GroupBox4.Controls.Add(Me.a6)
        Me.GroupBox4.Controls.Add(Me.a7)
        Me.GroupBox4.Controls.Add(Me.Num_lunes_ini)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Num_martes_ini)
        Me.GroupBox4.Controls.Add(Me.Num_domingos_fin)
        Me.GroupBox4.Controls.Add(Me.Num_miercoles_ini)
        Me.GroupBox4.Controls.Add(Me.Num_jueves_ini)
        Me.GroupBox4.Controls.Add(Me.Num_viernes_fin)
        Me.GroupBox4.Controls.Add(Me.Num_viernes_ini)
        Me.GroupBox4.Controls.Add(Me.Num_jueves_fin)
        Me.GroupBox4.Controls.Add(Me.Num_sabado_ini)
        Me.GroupBox4.Controls.Add(Me.Num_miercoles_fin)
        Me.GroupBox4.Controls.Add(Me.Num_domingo_ini)
        Me.GroupBox4.Controls.Add(Me.Num_martes_fin)
        Me.GroupBox4.Controls.Add(Me.Num_lunes_fin)
        Me.GroupBox4.Location = New System.Drawing.Point(342, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(253, 228)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        '
        'Num_sabados_fin
        '
        Me.Num_sabados_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_sabados_fin.Location = New System.Drawing.Point(153, 169)
        Me.Num_sabados_fin.Name = "Num_sabados_fin"
        Me.Num_sabados_fin.ShowUpDown = True
        Me.Num_sabados_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_sabados_fin.TabIndex = 48
        Me.Num_sabados_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'a1
        '
        Me.a1.AutoSize = True
        Me.a1.Location = New System.Drawing.Point(115, 27)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(13, 13)
        Me.a1.TabIndex = 17
        Me.a1.Text = "a"
        '
        'a2
        '
        Me.a2.AutoSize = True
        Me.a2.Location = New System.Drawing.Point(115, 55)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(13, 13)
        Me.a2.TabIndex = 20
        Me.a2.Text = "a"
        '
        'a3
        '
        Me.a3.AutoSize = True
        Me.a3.Location = New System.Drawing.Point(115, 85)
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(13, 13)
        Me.a3.TabIndex = 23
        Me.a3.Text = "a"
        '
        'a4
        '
        Me.a4.AutoSize = True
        Me.a4.Location = New System.Drawing.Point(115, 113)
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(13, 13)
        Me.a4.TabIndex = 26
        Me.a4.Text = "a"
        '
        'a5
        '
        Me.a5.AutoSize = True
        Me.a5.Location = New System.Drawing.Point(115, 143)
        Me.a5.Name = "a5"
        Me.a5.Size = New System.Drawing.Size(13, 13)
        Me.a5.TabIndex = 29
        Me.a5.Text = "a"
        '
        'a6
        '
        Me.a6.AutoSize = True
        Me.a6.Location = New System.Drawing.Point(115, 174)
        Me.a6.Name = "a6"
        Me.a6.Size = New System.Drawing.Size(13, 13)
        Me.a6.TabIndex = 32
        Me.a6.Text = "a"
        '
        'a7
        '
        Me.a7.AutoSize = True
        Me.a7.Location = New System.Drawing.Point(115, 206)
        Me.a7.Name = "a7"
        Me.a7.Size = New System.Drawing.Size(13, 13)
        Me.a7.TabIndex = 35
        Me.a7.Text = "a"
        '
        'Num_lunes_ini
        '
        Me.Num_lunes_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_lunes_ini.Location = New System.Drawing.Point(30, 24)
        Me.Num_lunes_ini.Name = "Num_lunes_ini"
        Me.Num_lunes_ini.ShowUpDown = True
        Me.Num_lunes_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_lunes_ini.TabIndex = 36
        Me.Num_lunes_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Definidas por Usuario"
        '
        'Num_martes_ini
        '
        Me.Num_martes_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_martes_ini.Location = New System.Drawing.Point(30, 52)
        Me.Num_martes_ini.Name = "Num_martes_ini"
        Me.Num_martes_ini.ShowUpDown = True
        Me.Num_martes_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_martes_ini.TabIndex = 37
        Me.Num_martes_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_domingos_fin
        '
        Me.Num_domingos_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_domingos_fin.Location = New System.Drawing.Point(153, 200)
        Me.Num_domingos_fin.Name = "Num_domingos_fin"
        Me.Num_domingos_fin.ShowUpDown = True
        Me.Num_domingos_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_domingos_fin.TabIndex = 49
        Me.Num_domingos_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_miercoles_ini
        '
        Me.Num_miercoles_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_miercoles_ini.Location = New System.Drawing.Point(30, 82)
        Me.Num_miercoles_ini.Name = "Num_miercoles_ini"
        Me.Num_miercoles_ini.ShowUpDown = True
        Me.Num_miercoles_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_miercoles_ini.TabIndex = 38
        Me.Num_miercoles_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_jueves_ini
        '
        Me.Num_jueves_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_jueves_ini.Location = New System.Drawing.Point(30, 109)
        Me.Num_jueves_ini.Name = "Num_jueves_ini"
        Me.Num_jueves_ini.ShowUpDown = True
        Me.Num_jueves_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_jueves_ini.TabIndex = 39
        Me.Num_jueves_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_viernes_fin
        '
        Me.Num_viernes_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_viernes_fin.Location = New System.Drawing.Point(153, 138)
        Me.Num_viernes_fin.Name = "Num_viernes_fin"
        Me.Num_viernes_fin.ShowUpDown = True
        Me.Num_viernes_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_viernes_fin.TabIndex = 47
        Me.Num_viernes_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_viernes_ini
        '
        Me.Num_viernes_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_viernes_ini.Location = New System.Drawing.Point(30, 139)
        Me.Num_viernes_ini.Name = "Num_viernes_ini"
        Me.Num_viernes_ini.ShowUpDown = True
        Me.Num_viernes_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_viernes_ini.TabIndex = 40
        Me.Num_viernes_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_jueves_fin
        '
        Me.Num_jueves_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_jueves_fin.Location = New System.Drawing.Point(153, 108)
        Me.Num_jueves_fin.Name = "Num_jueves_fin"
        Me.Num_jueves_fin.ShowUpDown = True
        Me.Num_jueves_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_jueves_fin.TabIndex = 46
        Me.Num_jueves_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_sabado_ini
        '
        Me.Num_sabado_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_sabado_ini.Location = New System.Drawing.Point(30, 170)
        Me.Num_sabado_ini.Name = "Num_sabado_ini"
        Me.Num_sabado_ini.ShowUpDown = True
        Me.Num_sabado_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_sabado_ini.TabIndex = 41
        Me.Num_sabado_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_miercoles_fin
        '
        Me.Num_miercoles_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_miercoles_fin.Location = New System.Drawing.Point(153, 81)
        Me.Num_miercoles_fin.Name = "Num_miercoles_fin"
        Me.Num_miercoles_fin.ShowUpDown = True
        Me.Num_miercoles_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_miercoles_fin.TabIndex = 45
        Me.Num_miercoles_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_domingo_ini
        '
        Me.Num_domingo_ini.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_domingo_ini.Location = New System.Drawing.Point(30, 201)
        Me.Num_domingo_ini.Name = "Num_domingo_ini"
        Me.Num_domingo_ini.ShowUpDown = True
        Me.Num_domingo_ini.Size = New System.Drawing.Size(66, 20)
        Me.Num_domingo_ini.TabIndex = 42
        Me.Num_domingo_ini.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_martes_fin
        '
        Me.Num_martes_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_martes_fin.Location = New System.Drawing.Point(153, 51)
        Me.Num_martes_fin.Name = "Num_martes_fin"
        Me.Num_martes_fin.ShowUpDown = True
        Me.Num_martes_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_martes_fin.TabIndex = 44
        Me.Num_martes_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'Num_lunes_fin
        '
        Me.Num_lunes_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Num_lunes_fin.Location = New System.Drawing.Point(153, 23)
        Me.Num_lunes_fin.Name = "Num_lunes_fin"
        Me.Num_lunes_fin.ShowUpDown = True
        Me.Num_lunes_fin.Size = New System.Drawing.Size(66, 20)
        Me.Num_lunes_fin.TabIndex = 43
        Me.Num_lunes_fin.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_domingos)
        Me.GroupBox3.Controls.Add(Me.txt_sabados)
        Me.GroupBox3.Controls.Add(Me.txt_viernes)
        Me.GroupBox3.Controls.Add(Me.txt_jueves)
        Me.GroupBox3.Controls.Add(Me.txt_miercoles)
        Me.GroupBox3.Controls.Add(Me.txt_martes)
        Me.GroupBox3.Controls.Add(Me.txt_lunes)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(125, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 228)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        '
        'txt_domingos
        '
        Me.txt_domingos.Location = New System.Drawing.Point(98, 195)
        Me.txt_domingos.Name = "txt_domingos"
        Me.txt_domingos.Size = New System.Drawing.Size(33, 20)
        Me.txt_domingos.TabIndex = 14
        '
        'txt_sabados
        '
        Me.txt_sabados.Location = New System.Drawing.Point(98, 163)
        Me.txt_sabados.Name = "txt_sabados"
        Me.txt_sabados.Size = New System.Drawing.Size(33, 20)
        Me.txt_sabados.TabIndex = 12
        '
        'txt_viernes
        '
        Me.txt_viernes.Location = New System.Drawing.Point(98, 132)
        Me.txt_viernes.Name = "txt_viernes"
        Me.txt_viernes.Size = New System.Drawing.Size(33, 20)
        Me.txt_viernes.TabIndex = 11
        '
        'txt_jueves
        '
        Me.txt_jueves.Location = New System.Drawing.Point(98, 103)
        Me.txt_jueves.Name = "txt_jueves"
        Me.txt_jueves.Size = New System.Drawing.Size(33, 20)
        Me.txt_jueves.TabIndex = 10
        '
        'txt_miercoles
        '
        Me.txt_miercoles.Location = New System.Drawing.Point(98, 74)
        Me.txt_miercoles.Name = "txt_miercoles"
        Me.txt_miercoles.Size = New System.Drawing.Size(33, 20)
        Me.txt_miercoles.TabIndex = 9
        '
        'txt_martes
        '
        Me.txt_martes.Location = New System.Drawing.Point(98, 44)
        Me.txt_martes.Name = "txt_martes"
        Me.txt_martes.Size = New System.Drawing.Size(33, 20)
        Me.txt_martes.TabIndex = 8
        '
        'txt_lunes
        '
        Me.txt_lunes.Location = New System.Drawing.Point(98, 18)
        Me.txt_lunes.Name = "txt_lunes"
        Me.txt_lunes.Size = New System.Drawing.Size(33, 20)
        Me.txt_lunes.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Desde 8:00 am "
        '
        'ochomas7
        '
        Me.ochomas7.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas7.Location = New System.Drawing.Point(270, 207)
        Me.ochomas7.Name = "ochomas7"
        Me.ochomas7.ShowUpDown = True
        Me.ochomas7.Size = New System.Drawing.Size(66, 20)
        Me.ochomas7.TabIndex = 58
        Me.ochomas7.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ochomas6
        '
        Me.ochomas6.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas6.Location = New System.Drawing.Point(270, 178)
        Me.ochomas6.Name = "ochomas6"
        Me.ochomas6.ShowUpDown = True
        Me.ochomas6.Size = New System.Drawing.Size(66, 20)
        Me.ochomas6.TabIndex = 57
        Me.ochomas6.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ochomas5
        '
        Me.ochomas5.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas5.Location = New System.Drawing.Point(270, 152)
        Me.ochomas5.Name = "ochomas5"
        Me.ochomas5.ShowUpDown = True
        Me.ochomas5.Size = New System.Drawing.Size(66, 20)
        Me.ochomas5.TabIndex = 56
        Me.ochomas5.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ochomas4
        '
        Me.ochomas4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas4.Location = New System.Drawing.Point(267, 126)
        Me.ochomas4.Name = "ochomas4"
        Me.ochomas4.ShowUpDown = True
        Me.ochomas4.Size = New System.Drawing.Size(66, 20)
        Me.ochomas4.TabIndex = 55
        Me.ochomas4.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ochomas3
        '
        Me.ochomas3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas3.Location = New System.Drawing.Point(270, 91)
        Me.ochomas3.Name = "ochomas3"
        Me.ochomas3.ShowUpDown = True
        Me.ochomas3.Size = New System.Drawing.Size(66, 20)
        Me.ochomas3.TabIndex = 54
        Me.ochomas3.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ochomas2
        '
        Me.ochomas2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas2.Location = New System.Drawing.Point(270, 61)
        Me.ochomas2.Name = "ochomas2"
        Me.ochomas2.ShowUpDown = True
        Me.ochomas2.Size = New System.Drawing.Size(66, 20)
        Me.ochomas2.TabIndex = 53
        Me.ochomas2.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ochomas1
        '
        Me.ochomas1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ochomas1.Location = New System.Drawing.Point(270, 30)
        Me.ochomas1.Name = "ochomas1"
        Me.ochomas1.ShowUpDown = True
        Me.ochomas1.Size = New System.Drawing.Size(66, 20)
        Me.ochomas1.TabIndex = 52
        Me.ochomas1.Value = New Date(2017, 11, 16, 0, 0, 0, 0)
        '
        'ocho
        '
        Me.ocho.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ocho.Location = New System.Drawing.Point(148, 126)
        Me.ocho.Name = "ocho"
        Me.ocho.ShowUpDown = True
        Me.ocho.Size = New System.Drawing.Size(66, 20)
        Me.ocho.TabIndex = 37
        Me.ocho.Value = New Date(2017, 11, 16, 8, 0, 0, 0)
        '
        'ch_lunes
        '
        Me.ch_lunes.AutoSize = True
        Me.ch_lunes.Location = New System.Drawing.Point(17, 28)
        Me.ch_lunes.Name = "ch_lunes"
        Me.ch_lunes.Size = New System.Drawing.Size(55, 17)
        Me.ch_lunes.TabIndex = 0
        Me.ch_lunes.Text = "Lunes"
        Me.ch_lunes.UseVisualStyleBackColor = True
        '
        'ch_domingos
        '
        Me.ch_domingos.AutoSize = True
        Me.ch_domingos.Location = New System.Drawing.Point(17, 208)
        Me.ch_domingos.Name = "ch_domingos"
        Me.ch_domingos.Size = New System.Drawing.Size(73, 17)
        Me.ch_domingos.TabIndex = 1
        Me.ch_domingos.Text = "Domingos"
        Me.ch_domingos.UseVisualStyleBackColor = True
        '
        'ch_sabados
        '
        Me.ch_sabados.AutoSize = True
        Me.ch_sabados.Location = New System.Drawing.Point(17, 179)
        Me.ch_sabados.Name = "ch_sabados"
        Me.ch_sabados.Size = New System.Drawing.Size(68, 17)
        Me.ch_sabados.TabIndex = 2
        Me.ch_sabados.Text = "Sabados"
        Me.ch_sabados.UseVisualStyleBackColor = True
        '
        'ch_viernes
        '
        Me.ch_viernes.AutoSize = True
        Me.ch_viernes.Location = New System.Drawing.Point(17, 145)
        Me.ch_viernes.Name = "ch_viernes"
        Me.ch_viernes.Size = New System.Drawing.Size(61, 17)
        Me.ch_viernes.TabIndex = 3
        Me.ch_viernes.Text = "Viernes"
        Me.ch_viernes.UseVisualStyleBackColor = True
        '
        'ch_jueves
        '
        Me.ch_jueves.AutoSize = True
        Me.ch_jueves.Location = New System.Drawing.Point(17, 116)
        Me.ch_jueves.Name = "ch_jueves"
        Me.ch_jueves.Size = New System.Drawing.Size(60, 17)
        Me.ch_jueves.TabIndex = 4
        Me.ch_jueves.Text = "Jueves"
        Me.ch_jueves.UseVisualStyleBackColor = True
        '
        'ch_miercoles
        '
        Me.ch_miercoles.AutoSize = True
        Me.ch_miercoles.Location = New System.Drawing.Point(17, 87)
        Me.ch_miercoles.Name = "ch_miercoles"
        Me.ch_miercoles.Size = New System.Drawing.Size(71, 17)
        Me.ch_miercoles.TabIndex = 5
        Me.ch_miercoles.Text = "Miercoles"
        Me.ch_miercoles.UseVisualStyleBackColor = True
        '
        'ch_martes
        '
        Me.ch_martes.AutoSize = True
        Me.ch_martes.Location = New System.Drawing.Point(17, 57)
        Me.ch_martes.Name = "ch_martes"
        Me.ch_martes.Size = New System.Drawing.Size(58, 17)
        Me.ch_martes.TabIndex = 6
        Me.ch_martes.Text = "Martes"
        Me.ch_martes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_espacio)
        Me.GroupBox2.Controls.Add(Me.rb_horas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 64)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'rb_espacio
        '
        Me.rb_espacio.AutoSize = True
        Me.rb_espacio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_espacio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_espacio.Location = New System.Drawing.Point(370, 31)
        Me.rb_espacio.Name = "rb_espacio"
        Me.rb_espacio.Size = New System.Drawing.Size(120, 18)
        Me.rb_espacio.TabIndex = 38
        Me.rb_espacio.TabStop = True
        Me.rb_espacio.Text = "Espacio De  Horas"
        Me.rb_espacio.UseVisualStyleBackColor = True
        '
        'rb_horas
        '
        Me.rb_horas.AutoSize = True
        Me.rb_horas.BackColor = System.Drawing.Color.Transparent
        Me.rb_horas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_horas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_horas.Location = New System.Drawing.Point(221, 31)
        Me.rb_horas.Name = "rb_horas"
        Me.rb_horas.Size = New System.Drawing.Size(116, 18)
        Me.rb_horas.TabIndex = 37
        Me.rb_horas.TabStop = True
        Me.rb_horas.Text = "Número De Horas"
        Me.rb_horas.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Definir la Capacidad de Trabajo"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(528, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(421, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Aceptar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 417)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 47)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Planificacion_Tareas.My.Resources.Resources.UserAdd_40960
        Me.PictureBox1.Location = New System.Drawing.Point(537, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 54)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'frm_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(663, 479)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_empleados"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Participantes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbo_datos_cliente.ResumeLayout(False)
        Me.gbo_datos_cliente.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gbo_dias_se.ResumeLayout(False)
        Me.gbo_dias_se.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cbo_estado_c As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_depar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbo_datos_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_Celular As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_email_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_apelldio2_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido1_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_domingos As System.Windows.Forms.TextBox
    Friend WithEvents txt_sabados As System.Windows.Forms.TextBox
    Friend WithEvents txt_viernes As System.Windows.Forms.TextBox
    Friend WithEvents txt_jueves As System.Windows.Forms.TextBox
    Friend WithEvents txt_miercoles As System.Windows.Forms.TextBox
    Friend WithEvents txt_martes As System.Windows.Forms.TextBox
    Friend WithEvents txt_lunes As System.Windows.Forms.TextBox
    Friend WithEvents ch_martes As System.Windows.Forms.CheckBox
    Friend WithEvents ch_miercoles As System.Windows.Forms.CheckBox
    Friend WithEvents ch_jueves As System.Windows.Forms.CheckBox
    Friend WithEvents ch_viernes As System.Windows.Forms.CheckBox
    Friend WithEvents ch_sabados As System.Windows.Forms.CheckBox
    Friend WithEvents ch_domingos As System.Windows.Forms.CheckBox
    Friend WithEvents ch_lunes As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_dias_se As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbo_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbo_comi As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rb_espacio As System.Windows.Forms.RadioButton
    Friend WithEvents rb_horas As System.Windows.Forms.RadioButton
    Friend WithEvents a6 As System.Windows.Forms.Label
    Friend WithEvents a5 As System.Windows.Forms.Label
    Friend WithEvents a4 As System.Windows.Forms.Label
    Friend WithEvents a3 As System.Windows.Forms.Label
    Friend WithEvents a2 As System.Windows.Forms.Label
    Friend WithEvents a1 As System.Windows.Forms.Label
    Friend WithEvents a7 As System.Windows.Forms.Label
    Friend WithEvents Num_lunes_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_domingo_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_sabado_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_viernes_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_jueves_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_miercoles_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_martes_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_domingos_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_sabados_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_viernes_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_jueves_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_miercoles_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_martes_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Num_lunes_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ocho As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas7 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ochomas2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
