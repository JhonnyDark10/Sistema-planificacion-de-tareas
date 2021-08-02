Imports System.Data.SqlClient

Public Class frm_contactos_telefonicos

    Private Sub frm_contactos_telefonicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select DNI_PARTICIPANTES,"
            sql = sql & "NOMBRE,APELLIDO_PATERNO + ' ' + APELLIDO_MATERNO as APELLIDOS, "
            sql = sql & "celular AS CELULAR, TELEFONO"
            sql = sql & " From PARTICIPANTES "
            sql = sql & " WHERE ESTADO_P = 'A' "

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_f.DataSource = dt
            dgv_f.RowHeadersVisible = False
            Me.dgv_f.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_f.Columns(2)
            row3.Width = 120

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_b.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select DNI_PARTICIPANTES,"
            sql = sql & "NOMBRE,APELLIDO_PATERNO + ' ' + APELLIDO_MATERNO as APELLIDOS, "
            sql = sql & "celular AS CELULAR, TELEFONO"
            sql = sql & " From PARTICIPANTES "
            sql = sql & " WHERE ESTADO_P = 'A' and apellido_paterno + ' ' + apellido_materno like'" & txt_b.Text & "%'"

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_f.DataSource = dt
            dgv_f.RowHeadersVisible = False
            Me.dgv_f.Columns(0).Visible = False


        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub







End Class