Imports System.Data.SqlClient

Public Class frm_cliente

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        frm_datos_cliente.ShowDialog()
        llenar_data_grip()
    End Sub

    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select C.DNI_CLIENTE as CODIGO,CEDULA ,T.DESCRIPCION AS TIPO , C.NOMBRE_EMPRESA as EMPRESA, C.NOMBRE_CONTACTO AS NOMBRE, "
            sql = sql & " C.APELLIDO_PATERNO AS  APELLIDO, C.DIRECCION,C.EMAIL,TELEFONO"
            sql = sql & " From contactos C"
            sql = sql & " INNER JOIN TIPO_CLIENTE T"
            sql = sql & " ON C.FK_ID_TIPO_CLIENTE  = T.ID_TIPO_CLIENTE"
            sql = sql & " WHERE estado_c = 'A' and cedula <> '" & 9999999999 & "'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False
           

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Dim int_id_perfil As Integer

    Private Sub dgv_cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
                txt_cli_asig.Text = int_id_perfil
                frm_modifica_cliente.ShowDialog()
                llenar_data_grip()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Try
            sql = "UPDATE contactos SET ESTADO_c ='I' WHERE dni_cliente= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show("  Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lista.KeyPress
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            
                sql = ""
                sql = sql & "select C.DNI_CLIENTE as CODIGO,CEDULA ,T.DESCRIPCION AS TIPO , C.NOMBRE_EMPRESA as EMPRESA, C.NOMBRE_CONTACTO AS NOMBRE, "
                sql = sql & " C.APELLIDO_PATERNO AS  APELLIDO, C.DIRECCION,C.EMAIL,TELEFONO,c.estado_c"
                sql = sql & " From contactos C"
                sql = sql & " INNER JOIN TIPO_CLIENTE T"
                sql = sql & " ON C.FK_ID_TIPO_CLIENTE  = T.ID_TIPO_CLIENTE"
            sql = sql & " WHERE c.estado_c = 'A' and cedula <> '" & 9999999999 & "'and (c.NOMBRE_EMPRESA like '" & txt_lista.Text & "%' or c.apellido_paterno + apellido_materno like'" & txt_lista.Text & "%')"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                dt.Load(dr)
                dgv_cliente.DataSource = dt
                dgv_cliente.RowHeadersVisible = False
                Me.dgv_cliente.Columns(0).Visible = False



        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub dgv_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick

    End Sub
End Class