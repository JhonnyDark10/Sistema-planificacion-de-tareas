Imports System.Data.SqlClient

Public Class frm_modifica_indisponibilidad

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub frm_modifica_indisponibilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub frm_datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
       Dim sql As String
        Try
            sql = "UPDATE indisponibilidad SET DESCRIPCION ='" & txt_indis.Text & "' WHERE DNI_INDISPONIBILIDAD = " & frm_indisponibilidad.txt_c.Text

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
End Class