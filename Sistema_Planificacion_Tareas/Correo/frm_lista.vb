Imports System.Data.SqlClient

Public Class frm_lista

    Private Sub frm_lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select DNI_PARTICIPANTES,"
            sql = sql & "NOMBRE, APELLIDO_PATERNO as APELLIDO, email"
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

    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select DNI_PARTICIPANTES,"
            sql = sql & "NOMBRE, APELLIDO_PATERNO as APELLIDO, email"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub dgv_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick

    End Sub


    Private Sub dgv_cliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellDoubleClick
        Try
            If e.RowIndex > -1 Then

                FormEnviarCorreo.txtPara.Text = dgv_cliente.Rows(e.RowIndex).Cells(3).Value

                Me.Close()
               
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class