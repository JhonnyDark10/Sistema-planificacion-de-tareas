Imports System.Data.SqlClient

Public Class frm_tipos_eventos

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frm_añadir_eventos.ShowDialog()
        llenar_data_grip()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        txt_cod.Text = int_id_perfil
        frm_modifica_eventos.ShowDialog()

        llenar_data_grip()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub frm_tipos_eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select ID_tipo_evento as CODIGO,DESCRIPCION as Registros from tipo_evento where estado_m = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_eventos.DataSource = dt
            dgv_eventos.DataSource = dt
            dgv_eventos.RowHeadersVisible = False
            Me.dgv_eventos.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_eventos.Columns(1)
            row3.Width = 323
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub dgv_eventos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eventos.CellContentClick

    End Sub


    Dim int_id_perfil As Integer
    Private Sub dgv_eventos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_eventos.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_eventos.Rows(e.RowIndex).Cells(0).Value
                frm_modifica_eventos.txt_datos.Text = dgv_eventos.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE tipo_evento SET ESTADO_m ='I' WHERE ID_tipo_evento= " & int_id_perfil
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
End Class