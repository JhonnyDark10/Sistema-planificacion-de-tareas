Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration

Public Class frm_estado_civil

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub frm_estado_civil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_data_grip()
    End Sub


    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select ID_ESTADO_CIVIL as CODIGO,DESCRIPCION as Registros from estado_civil where estado_e_c = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_estado.DataSource = dt
            dgv_estado.RowHeadersVisible = False
            Me.dgv_estado.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_estado.Columns(1)
            row3.Width = 205
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        If (txt_ingresa_datos.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.BackColor = Color.Red
        Else
            Try
                sql = "INSERT INTO ESTADO_CIVIL(DESCRIPCION, ESTADO_E_C) VALUES ("
                sql = sql & "'" & Trim(txt_ingresa_datos.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_ingresa_datos.Text = ""
                txt_ingresa_datos.BackColor = Color.White
                llenar_data_grip()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim sql As String
        Try
            sql = "UPDATE ESTADO_CIVIL SET DESCRIPCION ='" & txt_ingresa_datos.Text & "' WHERE ID_ESTADO_CIVIL= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Actualizada", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Dim int_id_perfil As Integer

    Private Sub dgv_estado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estado.CellContentClick

    End Sub

    Private Sub dgv_estado_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_estado.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_estado.Rows(e.RowIndex).Cells(0).Value
                txt_ingresa_datos.Text = dgv_estado.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim sql As String
        Try
            sql = "UPDATE ESTADO_CIVIL SET ESTADO_E_C ='I' WHERE ID_ESTADO_CIVIL= " & int_id_perfil
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_ingresa_datos.Text = ""
            llenar_data_grip()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_ingresa_datos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ingresa_datos.KeyPress
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

    Private Sub txt_ingresa_datos_TextChanged(sender As Object, e As EventArgs) Handles txt_ingresa_datos.TextChanged

    End Sub
End Class