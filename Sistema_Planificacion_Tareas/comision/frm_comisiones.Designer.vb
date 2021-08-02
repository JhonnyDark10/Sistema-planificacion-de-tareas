<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comisiones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_comisiones))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_añadir = New System.Windows.Forms.Button()
        Me.dgv_2 = New System.Windows.Forms.GroupBox()
        Me.txt_comision = New System.Windows.Forms.TextBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_comision = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.dgv_2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_comision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_modificar)
        Me.GroupBox2.Controls.Add(Me.btn_añadir)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 389)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 57)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(309, 19)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(96, 23)
        Me.btn_eliminar.TabIndex = 46
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(204, 19)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(96, 23)
        Me.btn_modificar.TabIndex = 45
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_añadir
        '
        Me.btn_añadir.Location = New System.Drawing.Point(93, 19)
        Me.btn_añadir.Name = "btn_añadir"
        Me.btn_añadir.Size = New System.Drawing.Size(96, 23)
        Me.btn_añadir.TabIndex = 44
        Me.btn_añadir.Text = "Añadir"
        Me.btn_añadir.UseVisualStyleBackColor = True
        '
        'dgv_2
        '
        Me.dgv_2.Controls.Add(Me.txt_comision)
        Me.dgv_2.Controls.Add(Me.btn_cerrar)
        Me.dgv_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_2.Location = New System.Drawing.Point(11, 444)
        Me.dgv_2.Name = "dgv_2"
        Me.dgv_2.Size = New System.Drawing.Size(496, 46)
        Me.dgv_2.TabIndex = 6
        Me.dgv_2.TabStop = False
        '
        'txt_comision
        '
        Me.txt_comision.Location = New System.Drawing.Point(130, 17)
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Size = New System.Drawing.Size(100, 20)
        Me.txt_comision.TabIndex = 47
        Me.txt_comision.Visible = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(378, 15)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 23)
        Me.btn_cerrar.TabIndex = 46
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_comision)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 382)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'dgv_comision
        '
        Me.dgv_comision.AllowUserToAddRows = False
        Me.dgv_comision.AllowUserToDeleteRows = False
        Me.dgv_comision.AllowUserToResizeColumns = False
        Me.dgv_comision.AllowUserToResizeRows = False
        Me.dgv_comision.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_comision.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_comision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_comision.Location = New System.Drawing.Point(95, 19)
        Me.dgv_comision.MultiSelect = False
        Me.dgv_comision.Name = "dgv_comision"
        Me.dgv_comision.ReadOnly = True
        Me.dgv_comision.RowHeadersVisible = False
        Me.dgv_comision.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dgv_comision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_comision.Size = New System.Drawing.Size(310, 347)
        Me.dgv_comision.TabIndex = 46
        '
        'frm_comisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_comisiones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comisión"
        Me.GroupBox2.ResumeLayout(False)
        Me.dgv_2.ResumeLayout(False)
        Me.dgv_2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_comision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_añadir As System.Windows.Forms.Button
    Friend WithEvents dgv_2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_comision As System.Windows.Forms.DataGridView
End Class
