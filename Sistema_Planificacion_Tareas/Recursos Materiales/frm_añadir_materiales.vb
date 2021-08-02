Imports System.Data.SqlClient

Public Class frm_añadir_materiales

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        If (txt_nombre.Text = "") Or (txt_descripcion.Text = "") Or (txt_descripcion.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO materiales(nombre,cantidad_m,descripcion, ESTADO_m) VALUES ("
                sql = sql & "'" & Trim(txt_nombre.Text) & "', "
                sql = sql & nd_cantidad.Text & ", "
                sql = sql & "'" & Trim(txt_descripcion.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Recurso material Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                txt_nombre.Text = ""
                txt_descripcion.Text = ""
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Private Sub frm_añadir_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
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

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub
End Class