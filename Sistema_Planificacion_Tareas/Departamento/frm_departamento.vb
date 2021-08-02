Imports System.Data.SqlClient

Public Class frm_comision

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frm_datos_departamento.ShowDialog()
        llenar_data_grip()
    End Sub



    Dim int_id_perfil As Integer

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub frm_departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select dni_departamento as CODIGO,nombre as Nombre,DESCRIPCION as Descripcion from departamento where estado_d = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_departemento.DataSource = dt
            dgv_departemento.RowHeadersVisible = False
            Me.dgv_departemento.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_departemento.Columns(2)
            row3.Width = 360
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        txt_depar.text = int_id_perfil
        frm_datos_modifica.ShowDialog()
        llenar_data_grip()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE departamento SET ESTADO_d ='I' WHERE dni_departamento= " & int_id_perfil
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

    Private Sub dgv_departemento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_departemento.CellContentClick

    End Sub


    Private Sub dgv_departemento_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_departemento.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_departemento.Rows(e.RowIndex).Cells(0).Value
                frm_datos_modifica.txt_nombre.Text = dgv_departemento.Rows(e.RowIndex).Cells(1).Value
                frm_datos_modifica.txt_descripcion.Text = dgv_departemento.Rows(e.RowIndex).Cells(2).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class