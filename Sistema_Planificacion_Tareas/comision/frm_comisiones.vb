Imports System.Data.SqlClient

Public Class frm_comisiones

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub
    Dim int_id_perfil As Integer
    Private Sub frm_comisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub
    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select id_comisiones as CODIGO,DESCRIPCION as Descripcion from comisiones where estado_c = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_comision.DataSource = dt
            dgv_comision.RowHeadersVisible = False
            Me.dgv_comision.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_comision.Columns(1)
            row3.Width = 315
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub dgv_comision_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_comision.CellContentClick

    End Sub

    Private Sub dgv_comision_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_comision.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_comision.Rows(e.RowIndex).Cells(0).Value
                frm_modifica_c.txt_datos.Text = dgv_comision.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE comisiones SET ESTADO_c ='I' WHERE id_comisiones= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frm_datos_c.ShowDialog()
        llenar_data_grip()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        txt_comision.Text = int_id_perfil
        frm_modifica_c.ShowDialog()
        llenar_data_grip()

    End Sub
End Class