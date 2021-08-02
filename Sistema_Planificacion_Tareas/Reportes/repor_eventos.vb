Public Class repor_eventos

    Private Sub repor_eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistema_PlanificacionDataSet6.sp_sel_ListaUsuarios4' Puede moverla o quitarla según sea necesario.
        Me.sp_sel_ListaUsuarios4TableAdapter.Fill(Me.Sistema_PlanificacionDataSet6.sp_sel_ListaUsuarios4)
        'TODO: esta línea de código carga datos en la tabla 'Sistema_PlanificacionDataSet.PARTICIPANTES' Puede moverla o quitarla según sea necesario.
        Me.PARTICIPANTESTableAdapter.Fill(Me.Sistema_PlanificacionDataSet.PARTICIPANTES)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class