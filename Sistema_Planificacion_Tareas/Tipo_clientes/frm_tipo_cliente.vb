Imports System.Data.SqlClient

Public Class frm_tipo_cliente

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        If (txt_datos.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_datos.BackColor = Color.Red

        Else
            Try
                sql = "INSERT INTO tipo_cliente(DESCRIPCION, ESTADO_t_C) VALUES ("
                sql = sql & "'" & Trim(txt_datos.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_datos.Text = ""
                txt_datos.BackColor = Color.White
                llenar_data_grip()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
        End If
    End Sub

    Private Sub frm_tipo_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select  id_tipo_cliente as CODIGO,DESCRIPCION as Registros from TIPO_CLIENTE where estado_t_c = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_departamento.DataSource = dt

            dgv_departamento.RowHeadersVisible = False
            Me.dgv_departamento.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_departamento.Columns(1)
            row3.Width = 205
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub



    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim sql As String
        Try
            sql = "UPDATE tipo_cliente SET DESCRIPCION ='" & txt_datos.Text & "' WHERE ID_tipo_cliente= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Actualizada", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txt_datos.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Dim int_id_perfil As Integer
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE tipo_cliente SET ESTADO_t_C ='I' WHERE ID_tipo_cliente= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txt_datos.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub


    Private Sub dgv_departamento_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_departamento.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_departamento.Rows(e.RowIndex).Cells(0).Value
                txt_datos.Text = dgv_departamento.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_datos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_datos.KeyPress
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

    Private Sub txt_datos_TextChanged(sender As Object, e As EventArgs) Handles txt_datos.TextChanged

    End Sub

  
End Class