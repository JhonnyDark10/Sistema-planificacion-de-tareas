Imports System.Data.SqlClient

Public Class frm_asigna_dia

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim sql As String
        If (txt_descripcion.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO dias_festivos(fecha_pedido,DESCRIPCION, ESTADO_f) VALUES ("
                sql = sql & "'" & dtp_dia.Value.Date & "', "
                sql = sql & "'" & Trim(txt_descripcion.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" ALMACENADA", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                txt_descripcion.Text = ""
                ck_anos.Checked = False

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub
End Class