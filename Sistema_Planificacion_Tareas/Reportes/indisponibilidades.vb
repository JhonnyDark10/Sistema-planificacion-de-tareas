Public Class indisponibilidades

    Private Sub indisponibilidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistema_PlanificacionDataSet5.sp_sel_ListaUsuarios3' Puede moverla o quitarla según sea necesario.
        Me.sp_sel_ListaUsuarios3TableAdapter.Fill(Me.Sistema_PlanificacionDataSet5.sp_sel_ListaUsuarios3)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class