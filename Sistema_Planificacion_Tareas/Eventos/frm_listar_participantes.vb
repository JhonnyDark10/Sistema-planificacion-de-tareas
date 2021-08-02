Imports System.Data.SqlClient

Public Class frm_listar

    Private Sub frm_listar_participantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select DNI_PARTICIPANTES,CEDULA ,"
            sql = sql & "NOMBRE, APELLIDO_PATERNO + ' ' + apellido_materno as APELLIDO"
            sql = sql & " From PARTICIPANTES "
            sql = sql & " WHERE ESTADO_P = 'A' "
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_cliente.Columns(3)
            row3.Width = 200
            Dim row4 As DataGridViewColumn = dgv_cliente.Columns(2)
            row3.Width = 300
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

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
            sql = sql & "select DNI_PARTICIPANTES,CEDULA ,"
            sql = sql & "NOMBRE, APELLIDO_PATERNO as APELLIDO"
            sql = sql & " From PARTICIPANTES "
            sql = sql & " WHERE ESTADO_P = 'A' and NOMBRE like '" & txt_lista.Text & "%' or APELLIDO_PATERNO + ' ' + apellido_materno like'" & txt_lista.Text & "%'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_cliente.DataSource = dt
            dgv_cliente.RowHeadersVisible = False
            Me.dgv_cliente.Columns(0).Visible = False

            Dim row3 As DataGridViewColumn = dgv_cliente.Columns(3)
            row3.Width = 200
            Dim row4 As DataGridViewColumn = dgv_cliente.Columns(2)
            row3.Width = 300

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
                frm_evento_indisponibilidad.txt_cod1.Text = int_id_perfil
                Me.Close()
                frm_evento_indisponibilidad.txt_buscar.Text = dgv_cliente.Rows(e.RowIndex).Cells(2).Value & " " & dgv_cliente.Rows(e.RowIndex).Cells(3).Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class