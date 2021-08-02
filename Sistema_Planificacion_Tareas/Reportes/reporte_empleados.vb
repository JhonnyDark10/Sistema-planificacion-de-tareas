Public Class reporte_empleados

    Private Sub reporte_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistema_PlanificacionDataSet.PARTICIPANTES' Puede moverla o quitarla según sea necesario.
        Me.PARTICIPANTESTableAdapter.Fill(Me.Sistema_PlanificacionDataSet.PARTICIPANTES)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class