Imports System.Data.SqlClient

Public Class frm_dia_festivos

    Private Sub frm_dia_festivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_dias.RowHeadersVisible = False


        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select id_dias_festivos as CODIGO,fecha_pedido as FECHA,DESCRIPCION  from dias_festivos where estado_f = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_dias.DataSource = dt
            Me.dgv_dias.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_dias.Columns(2)
            row3.Width = 340

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frm_asigna_dia.ShowDialog()
        llenar_data_grip()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub




    Dim int_id_perfil As Integer
    Private Sub dgv_dias_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
       
    End Sub

    'Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
    '    txt_m.Text = int_id_perfil
    '    frm_asigna_modifica.ShowDialog()
    '    llenar_data_grip()
    'End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE dias_festivos SET ESTADO_f ='I' WHERE ID_dias_festivos= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery

            MessageBox.Show("  ELIMINADO", "ELIMINACION", MessageBoxButtons.OK, MessageBoxIcon.Information)

            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = "select id_dias_festivos as CODIGO,fecha_pedido as FECHA,DESCRIPCION  from dias_festivos "
            sql = sql & " WHERE estado_F = 'A' and (DESCRIPCION like '" & TextBox1.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_dias.DataSource = dt
            Me.dgv_dias.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_dias.Columns(2)
            row3.Width = 340



        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub dgv_dias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dias.CellClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_dias.Rows(e.RowIndex).Cells(0).Value
                txt_m.Text = int_id_perfil

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_dias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dias.CellContentClick

    End Sub

    Private Sub dgv_dias_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dias.CellContentDoubleClick


    End Sub

    Private Sub dgv_dias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dias.CellDoubleClick

        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_dias.Rows(e.RowIndex).Cells(0).Value
                txt_m.Text = int_id_perfil
                frm_asigna_modifica.ShowDialog()
                llenar_data_grip()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class