<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class indisponibilidades
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sp_sel_ListaUsuarios3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sistema_PlanificacionDataSet5 = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet5()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sp_sel_ListaUsuarios3TableAdapter = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet5TableAdapters.sp_sel_ListaUsuarios3TableAdapter()
        CType(Me.sp_sel_ListaUsuarios3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistema_PlanificacionDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_sel_ListaUsuarios3BindingSource
        '
        Me.sp_sel_ListaUsuarios3BindingSource.DataMember = "sp_sel_ListaUsuarios3"
        Me.sp_sel_ListaUsuarios3BindingSource.DataSource = Me.Sistema_PlanificacionDataSet5
        '
        'Sistema_PlanificacionDataSet5
        '
        Me.Sistema_PlanificacionDataSet5.DataSetName = "Sistema_PlanificacionDataSet5"
        Me.Sistema_PlanificacionDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.sp_sel_ListaUsuarios3BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Planificacion_Tareas.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(692, 572)
        Me.ReportViewer1.TabIndex = 0
        '
        'sp_sel_ListaUsuarios3TableAdapter
        '
        Me.sp_sel_ListaUsuarios3TableAdapter.ClearBeforeFill = True
        '
        'indisponibilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 572)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "indisponibilidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "indisponibilidades"
        CType(Me.sp_sel_ListaUsuarios3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistema_PlanificacionDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_sel_ListaUsuarios3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema_PlanificacionDataSet5 As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet5
    Friend WithEvents sp_sel_ListaUsuarios3TableAdapter As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet5TableAdapters.sp_sel_ListaUsuarios3TableAdapter
End Class
