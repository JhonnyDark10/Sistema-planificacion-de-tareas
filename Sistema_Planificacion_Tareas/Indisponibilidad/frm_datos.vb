Imports System.Data.SqlClient

Public Class frm_datos

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub frm_datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim sql As String
        If (txt_indis.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_indis.BackColor = Color.Red
        Else
            Try
                sql = "INSERT INTO indisponibilidad(DESCRIPCION, ESTADO_i) VALUES ("
                sql = sql & "'" & Trim(txt_indis.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Categoria Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_indis.Text = ""
                txt_indis.BackColor = Color.White
                Me.Close()
            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txt_indis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_indis.KeyPress
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

    Private Sub txt_indis_TextChanged(sender As Object, e As EventArgs) Handles txt_indis.TextChanged

    End Sub
End Class