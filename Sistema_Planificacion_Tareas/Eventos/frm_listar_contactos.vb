Imports System.Data.SqlClient

Public Class frm_listar_contactos

    Private Sub frm_listar_contactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select C.DNI_CLIENTE as CODIGO,CEDULA,C.NOMBRE_EMPRESA as EMPRESA, C.NOMBRE_CONTACTO AS NOMBRE, "
            sql = sql & " C.APELLIDO_PATERNO AS  APELLIDO,C.EMAIL"
            sql = sql & " From contactos C"
            sql = sql & " WHERE estado_c = 'A' and c.cedula <> '" & 9999999999 & "'"
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

    Private Sub txt_lista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lista.KeyPress
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

    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select C.DNI_CLIENTE as CODIGO,CEDULA,C.NOMBRE_EMPRESA as EMPRESA, C.NOMBRE_CONTACTO AS NOMBRE, "
            sql = sql & " C.APELLIDO_PATERNO AS  APELLIDO,C.EMAIL"
            sql = sql & " From contactos C"
            sql = sql & " WHERE c.estado_c = 'A' and (c.NOMBRE_EMPRESA like '" & txt_lista.Text & "%' or c.apellido_paterno + apellido_materno like'" & txt_lista.Text & "%')"
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
    Dim int_id_perfil As Integer
    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_cliente.Rows(e.RowIndex).Cells(0).Value
                frm_eventos.txt_cod.Text = int_id_perfil
                frm_modifica_evento.txt_cod.Text = int_id_perfil
                Me.Close()
                If (dgv_cliente.Rows(e.RowIndex).Cells(2).Value) = "" Then


                    frm_eventos.txt_cont.Text = dgv_cliente.Rows(e.RowIndex).Cells(3).Value & " " & dgv_cliente.Rows(e.RowIndex).Cells(4).Value
                    frm_modifica_evento.txt_cont.Text = dgv_cliente.Rows(e.RowIndex).Cells(3).Value & " " & dgv_cliente.Rows(e.RowIndex).Cells(4).Value

                Else
                    frm_eventos.txt_cont.Text = dgv_cliente.Rows(e.RowIndex).Cells(2).Value
                    frm_modifica_evento.txt_cont.Text = dgv_cliente.Rows(e.RowIndex).Cells(2).Value
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    
End Class