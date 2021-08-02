Imports System.Data.SqlClient

Public Class frm_materiales

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frm_añadir_materiales.ShowDialog()
        llenar_data_grip()

    End Sub

    Private Sub frm_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select ID_materiales as CODIGO,nombre as NOMBRE,cantidad_M as CANTIDAD,DESCRIPCION AS DESCRIPCION from materiales where estado_m = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_dias.DataSource = dt
            dgv_dias.DataSource = dt
            dgv_dias.RowHeadersVisible = False
            Me.dgv_dias.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_dias.Columns(3)
            row3.Width = 450
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil As Integer
    Private Sub dgv_dias_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_dias.Rows(e.RowIndex).Cells(0).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs)
        frm_añadir_modifica.ShowDialog()
        llenar_data_grip()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE materiales SET ESTADO_m ='I' WHERE id_materiales= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Recurso material eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)


            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try

    End Sub



    Private Sub txt_listam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_listam.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_listam.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select ID_materiales as CODIGO,nombre as NOMBRE,cantidad_M as CANTIDAD,DESCRIPCION AS DESCRIPCION"
            sql = sql & " From materiales "
            sql = sql & " WHERE estado_m = 'A' and nombre like '" & txt_listam.Text & "%'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_dias.DataSource = dt
            dgv_dias.RowHeadersVisible = False
            Me.dgv_dias.Columns(0).Visible = False
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
                txt_materiales.Text = int_id_perfil
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Private Sub dgv_dias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dias.CellContentClick

    End Sub

    Private Sub dgv_dias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dias.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_dias.Rows(e.RowIndex).Cells(0).Value
                txt_materiales.Text = int_id_perfil
                frm_añadir_modifica.ShowDialog()
                llenar_data_grip()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class