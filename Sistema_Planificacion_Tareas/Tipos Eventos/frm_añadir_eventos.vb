Imports System.Data.SqlClient

Public Class frm_añadir_eventos

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim sql As String
        If (txt_datos.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_datos.BackColor = Color.Red
        Else
            Try
                sql = "INSERT INTO tipo_evento(DESCRIPCION, ESTADO_m) VALUES ("
                sql = sql & "'" & Trim(txt_datos.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_datos.Text = ""
                txt_datos.BackColor = Color.White
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
        End If
    End Sub

    Private Sub frm_añadir_eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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