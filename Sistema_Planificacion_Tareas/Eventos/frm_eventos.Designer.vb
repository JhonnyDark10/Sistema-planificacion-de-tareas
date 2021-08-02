<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_eventos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_eventos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ch_sinc = New System.Windows.Forms.CheckBox()
        Me.cbo_eventos = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_hora_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtp_inicio_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_fin_fecha = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtp_hora_fin = New System.Windows.Forms.DateTimePicker()
        Me.ch_recordatorio = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.rb_varios = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rb_solo = New System.Windows.Forms.RadioButton()
        Me.cbo_participantes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_tipo_evento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cont = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbo_recursos_a = New System.Windows.Forms.GroupBox()
        Me.dgv_lista2 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_lista1 = New System.Windows.Forms.DataGridView()
        Me.txt_lista = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btn_mover = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_añadir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbo_recursos_a.SuspendLayout()
        CType(Me.dgv_lista2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_lista1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_descripcion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(668, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ch_sinc)
        Me.GroupBox4.Controls.Add(Me.cbo_eventos)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbo_tipo_evento)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.btn_buscar)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_cont)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 288)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        '
        'ch_sinc
        '
        Me.ch_sinc.AutoSize = True
        Me.ch_sinc.Location = New System.Drawing.Point(435, 65)
        Me.ch_sinc.Name = "ch_sinc"
        Me.ch_sinc.Size = New System.Drawing.Size(87, 17)
        Me.ch_sinc.TabIndex = 71
        Me.ch_sinc.Text = "Sin Contacto"
        Me.ch_sinc.UseVisualStyleBackColor = True
        '
        'cbo_eventos
        '
        Me.cbo_eventos.DisplayMember = "DESCRIPCION"
        Me.cbo_eventos.FormattingEnabled = True
        Me.cbo_eventos.Location = New System.Drawing.Point(86, 18)
        Me.cbo_eventos.Name = "cbo_eventos"
        Me.cbo_eventos.Size = New System.Drawing.Size(224, 21)
        Me.cbo_eventos.TabIndex = 1
        Me.cbo_eventos.ValueMember = "ID_TIPO_EVENTO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_hora_inicio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtp_inicio_fecha)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtp_fin_fecha)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.dtp_hora_fin)
        Me.GroupBox2.Controls.Add(Me.ch_recordatorio)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 100)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempo"
        '
        'dtp_hora_inicio
        '
        Me.dtp_hora_inicio.CustomFormat = "hh:mm"
        Me.dtp_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora_inicio.Location = New System.Drawing.Point(258, 29)
        Me.dtp_hora_inicio.Name = "dtp_hora_inicio"
        Me.dtp_hora_inicio.ShowUpDown = True
        Me.dtp_hora_inicio.Size = New System.Drawing.Size(62, 20)
        Me.dtp_hora_inicio.TabIndex = 14
        Me.dtp_hora_inicio.Value = New Date(2017, 11, 18, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha y Hora de Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha y Hora de Fin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(329, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label11, "Campo Obligatorio")
        '
        'dtp_inicio_fecha
        '
        Me.dtp_inicio_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_inicio_fecha.Location = New System.Drawing.Point(158, 29)
        Me.dtp_inicio_fecha.Name = "dtp_inicio_fecha"
        Me.dtp_inicio_fecha.Size = New System.Drawing.Size(94, 20)
        Me.dtp_inicio_fecha.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(329, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label10, "Campo Obligatorio")
        '
        'dtp_fin_fecha
        '
        Me.dtp_fin_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fin_fecha.Location = New System.Drawing.Point(158, 64)
        Me.dtp_fin_fecha.Name = "dtp_fin_fecha"
        Me.dtp_fin_fecha.Size = New System.Drawing.Size(94, 20)
        Me.dtp_fin_fecha.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Planificacion_Tareas.My.Resources.Resources.Map_Marker_Push_Pin_1_Right_Pink_icon
        Me.PictureBox1.Location = New System.Drawing.Point(550, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 59)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'dtp_hora_fin
        '
        Me.dtp_hora_fin.CustomFormat = "hh:mm"
        Me.dtp_hora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora_fin.Location = New System.Drawing.Point(258, 64)
        Me.dtp_hora_fin.Name = "dtp_hora_fin"
        Me.dtp_hora_fin.ShowUpDown = True
        Me.dtp_hora_fin.Size = New System.Drawing.Size(62, 20)
        Me.dtp_hora_fin.TabIndex = 15
        Me.dtp_hora_fin.Value = New Date(2017, 11, 18, 0, 0, 0, 0)
        '
        'ch_recordatorio
        '
        Me.ch_recordatorio.AutoSize = True
        Me.ch_recordatorio.Location = New System.Drawing.Point(457, 48)
        Me.ch_recordatorio.Name = "ch_recordatorio"
        Me.ch_recordatorio.Size = New System.Drawing.Size(87, 30)
        Me.ch_recordatorio.TabIndex = 17
        Me.ch_recordatorio.Text = "Recordatorio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   E-Mail"
        Me.ch_recordatorio.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_cod)
        Me.GroupBox3.Controls.Add(Me.rb_varios)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rb_solo)
        Me.GroupBox3.Controls.Add(Me.cbo_participantes)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(604, 74)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Asignación de Recursos"
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(168, 14)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod.TabIndex = 65
        Me.txt_cod.Visible = False
        '
        'rb_varios
        '
        Me.rb_varios.AutoSize = True
        Me.rb_varios.Location = New System.Drawing.Point(415, 45)
        Me.rb_varios.Name = "rb_varios"
        Me.rb_varios.Size = New System.Drawing.Size(54, 17)
        Me.rb_varios.TabIndex = 8
        Me.rb_varios.TabStop = True
        Me.rb_varios.Text = "Varios"
        Me.rb_varios.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Participantes"
        '
        'rb_solo
        '
        Me.rb_solo.AutoSize = True
        Me.rb_solo.Location = New System.Drawing.Point(39, 46)
        Me.rb_solo.Name = "rb_solo"
        Me.rb_solo.Size = New System.Drawing.Size(70, 17)
        Me.rb_solo.TabIndex = 7
        Me.rb_solo.TabStop = True
        Me.rb_solo.Text = "Solo uno "
        Me.rb_solo.UseVisualStyleBackColor = True
        '
        'cbo_participantes
        '
        Me.cbo_participantes.DisplayMember = "nombre"
        Me.cbo_participantes.FormattingEnabled = True
        Me.cbo_participantes.Location = New System.Drawing.Point(112, 45)
        Me.cbo_participantes.Name = "cbo_participantes"
        Me.cbo_participantes.Size = New System.Drawing.Size(208, 21)
        Me.cbo_participantes.TabIndex = 9
        Me.cbo_participantes.ValueMember = "dni_participantes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eventos"
        '
        'cbo_tipo_evento
        '
        Me.cbo_tipo_evento.DisplayMember = "descripcion"
        Me.cbo_tipo_evento.FormattingEnabled = True
        Me.cbo_tipo_evento.Location = New System.Drawing.Point(432, 19)
        Me.cbo_tipo_evento.Name = "cbo_tipo_evento"
        Me.cbo_tipo_evento.Size = New System.Drawing.Size(154, 21)
        Me.cbo_tipo_evento.TabIndex = 2
        Me.cbo_tipo_evento.ValueMember = "id_categoria_eventos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contactos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(595, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label9, "Campo Obligatorio")
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(322, 59)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(73, 28)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(318, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label20, "Campo Obligatorio")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Asignación"
        '
        'txt_cont
        '
        Me.txt_cont.Location = New System.Drawing.Point(86, 64)
        Me.txt_cont.Name = "txt_cont"
        Me.txt_cont.Size = New System.Drawing.Size(224, 20)
        Me.txt_cont.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(94, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label12, "Campo Obligatorio")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Descripción:"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(30, 331)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(616, 144)
        Me.txt_descripcion.TabIndex = 16
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 507)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbo_recursos_a)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(668, 481)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Recursos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbo_recursos_a
        '
        Me.gbo_recursos_a.Controls.Add(Me.dgv_lista2)
        Me.gbo_recursos_a.Controls.Add(Me.dgv_lista1)
        Me.gbo_recursos_a.Controls.Add(Me.txt_lista)
        Me.gbo_recursos_a.Controls.Add(Me.Label7)
        Me.gbo_recursos_a.Controls.Add(Me.btn_regresar)
        Me.gbo_recursos_a.Controls.Add(Me.btn_mover)
        Me.gbo_recursos_a.Location = New System.Drawing.Point(20, 25)
        Me.gbo_recursos_a.Name = "gbo_recursos_a"
        Me.gbo_recursos_a.Size = New System.Drawing.Size(633, 434)
        Me.gbo_recursos_a.TabIndex = 20
        Me.gbo_recursos_a.TabStop = False
        Me.gbo_recursos_a.Text = "Escoger"
        '
        'dgv_lista2
        '
        Me.dgv_lista2.AllowUserToAddRows = False
        Me.dgv_lista2.AllowUserToDeleteRows = False
        Me.dgv_lista2.AllowUserToResizeColumns = False
        Me.dgv_lista2.AllowUserToResizeRows = False
        Me.dgv_lista2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_lista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre})
        Me.dgv_lista2.Location = New System.Drawing.Point(359, 89)
        Me.dgv_lista2.Name = "dgv_lista2"
        Me.dgv_lista2.ReadOnly = True
        Me.dgv_lista2.RowHeadersVisible = False
        Me.dgv_lista2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista2.ShowEditingIcon = False
        Me.dgv_lista2.ShowRowErrors = False
        Me.dgv_lista2.Size = New System.Drawing.Size(250, 316)
        Me.dgv_lista2.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 246
        '
        'dgv_lista1
        '
        Me.dgv_lista1.AllowUserToAddRows = False
        Me.dgv_lista1.AllowUserToDeleteRows = False
        Me.dgv_lista1.AllowUserToResizeColumns = False
        Me.dgv_lista1.AllowUserToResizeRows = False
        Me.dgv_lista1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_lista1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_lista1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista1.Location = New System.Drawing.Point(25, 89)
        Me.dgv_lista1.Name = "dgv_lista1"
        Me.dgv_lista1.ReadOnly = True
        Me.dgv_lista1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista1.ShowEditingIcon = False
        Me.dgv_lista1.ShowRowErrors = False
        Me.dgv_lista1.Size = New System.Drawing.Size(250, 316)
        Me.dgv_lista1.TabIndex = 9
        '
        'txt_lista
        '
        Me.txt_lista.Location = New System.Drawing.Point(49, 42)
        Me.txt_lista.Name = "txt_lista"
        Me.txt_lista.Size = New System.Drawing.Size(226, 20)
        Me.txt_lista.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtro"
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(304, 258)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(30, 23)
        Me.btn_regresar.TabIndex = 5
        Me.btn_regresar.Text = "<"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btn_mover
        '
        Me.btn_mover.Location = New System.Drawing.Point(304, 225)
        Me.btn_mover.Name = "btn_mover"
        Me.btn_mover.Size = New System.Drawing.Size(30, 23)
        Me.btn_mover.TabIndex = 3
        Me.btn_mover.Text = ">"
        Me.btn_mover.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_añadir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 525)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 41)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(558, 12)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(88, 23)
        Me.btn_cancelar.TabIndex = 29
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_añadir
        '
        Me.btn_añadir.Location = New System.Drawing.Point(447, 12)
        Me.btn_añadir.Name = "btn_añadir"
        Me.btn_añadir.Size = New System.Drawing.Size(96, 23)
        Me.btn_añadir.TabIndex = 28
        Me.btn_añadir.Text = "Aceptar"
        Me.btn_añadir.UseVisualStyleBackColor = True
        '
        'frm_eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 571)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_eventos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbo_recursos_a.ResumeLayout(False)
        Me.gbo_recursos_a.PerformLayout()
        CType(Me.dgv_lista2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_lista1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_evento As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_eventos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents dtp_fin_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_inicio_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_participantes As System.Windows.Forms.ComboBox
    Friend WithEvents rb_varios As System.Windows.Forms.RadioButton
    Friend WithEvents rb_solo As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ch_recordatorio As System.Windows.Forms.CheckBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtp_hora_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_hora_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_regresar As System.Windows.Forms.Button
    Friend WithEvents btn_mover As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_añadir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cont As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents gbo_recursos_a As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lista As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_lista1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_lista2 As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ch_sinc As System.Windows.Forms.CheckBox
End Class
