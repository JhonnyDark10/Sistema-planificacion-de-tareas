Public Class clientes

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sistema_PlanificacionDataSet1.CONTACTOS' Puede moverla o quitarla según sea necesario.
        Me.CONTACTOSTableAdapter.Fill(Me.Sistema_PlanificacionDataSet1.CONTACTOS)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class