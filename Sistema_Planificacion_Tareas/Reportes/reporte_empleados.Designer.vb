<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reporte_empleados))
        Me.PARTICIPANTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sistema_PlanificacionDataSet = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SistemaPlanificacionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PARTICIPANTESTableAdapter = New Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSetTableAdapters.PARTICIPANTESTableAdapter()
        CType(Me.PARTICIPANTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistema_PlanificacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaPlanificacionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PARTICIPANTESBindingSource
        '
        Me.PARTICIPANTESBindingSource.DataMember = "PARTICIPANTES"
        Me.PARTICIPANTESBindingSource.DataSource = Me.Sistema_PlanificacionDataSet
        '
        'Sistema_PlanificacionDataSet
        '
        Me.Sistema_PlanificacionDataSet.DataSetName = "Sistema_PlanificacionDataSet"
        Me.Sistema_PlanificacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PARTICIPANTESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Planificacion_Tareas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(700, 574)
        Me.ReportViewer1.TabIndex = 0
        '
        'SistemaPlanificacionDataSetBindingSource
        '
        Me.SistemaPlanificacionDataSetBindingSource.DataSource = Me.Sistema_PlanificacionDataSet
        Me.SistemaPlanificacionDataSetBindingSource.Position = 0
        '
        'PARTICIPANTESTableAdapter
        '
        Me.PARTICIPANTESTableAdapter.ClearBeforeFill = True
        '
        'reporte_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 574)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reporte_empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Empelados"
        CType(Me.PARTICIPANTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistema_PlanificacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaPlanificacionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SistemaPlanificacionDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sistema_PlanificacionDataSet As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSet
    Friend WithEvents PARTICIPANTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARTICIPANTESTableAdapter As Sistema_Planificacion_Tareas.Sistema_PlanificacionDataSetTableAdapters.PARTICIPANTESTableAdapter
End Class
