<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repor_eventos
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sistema_PlanificacionDataSet = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet()
        Me.PARTICIPANTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PARTICIPANTESTableAdapter = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSetTableAdapters.PARTICIPANTESTableAdapter()
        Me.Sistema_PlanificacionDataSet6 = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet6()
        Me.sp_sel_ListaUsuarios4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_sel_ListaUsuarios4TableAdapter = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet6TableAdapters.sp_sel_ListaUsuarios4TableAdapter()
        CType(Me.Sistema_PlanificacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARTICIPANTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistema_PlanificacionDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_sel_ListaUsuarios4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.sp_sel_ListaUsuarios4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Planificacion_Tareas.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(690, 529)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sistema_PlanificacionDataSet
        '
        Me.Sistema_PlanificacionDataSet.DataSetName = "Sistema_PlanificacionDataSet"
        Me.Sistema_PlanificacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PARTICIPANTESBindingSource
        '
        Me.PARTICIPANTESBindingSource.DataMember = "PARTICIPANTES"
        Me.PARTICIPANTESBindingSource.DataSource = Me.Sistema_PlanificacionDataSet
        '
        'PARTICIPANTESTableAdapter
        '
        Me.PARTICIPANTESTableAdapter.ClearBeforeFill = True
        '
        'Sistema_PlanificacionDataSet6
        '
        Me.Sistema_PlanificacionDataSet6.DataSetName = "Sistema_PlanificacionDataSet6"
        Me.Sistema_PlanificacionDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_sel_ListaUsuarios4BindingSource
        '
        Me.sp_sel_ListaUsuarios4BindingSource.DataMember = "sp_sel_ListaUsuarios4"
        Me.sp_sel_ListaUsuarios4BindingSource.DataSource = Me.Sistema_PlanificacionDataSet6
        '
        'sp_sel_ListaUsuarios4TableAdapter
        '
        Me.sp_sel_ListaUsuarios4TableAdapter.ClearBeforeFill = True
        '
        'repor_eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 529)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "repor_eventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repote Eventos"
        CType(Me.Sistema_PlanificacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARTICIPANTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistema_PlanificacionDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_sel_ListaUsuarios4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PARTICIPANTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema_PlanificacionDataSet As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet
    Friend WithEvents PARTICIPANTESTableAdapter As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSetTableAdapters.PARTICIPANTESTableAdapter
    Friend WithEvents sp_sel_ListaUsuarios4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema_PlanificacionDataSet6 As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet6
    Friend WithEvents sp_sel_ListaUsuarios4TableAdapter As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet6TableAdapters.sp_sel_ListaUsuarios4TableAdapter
End Class
