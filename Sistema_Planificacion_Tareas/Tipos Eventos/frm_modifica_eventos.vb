Imports System.Data.SqlClient

Public Class frm_modifica_eventos


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
         Dim sql As String
        Try
            sql = "UPDATE TIPO_EVENTO SET DESCRIPCION ='" & txt_datos.Text & "' WHERE ID_TIPO_EVENTO = " & frm_tipos_eventos.txt_cod.Text
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Categoria Actualizada", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frm_modifica_eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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