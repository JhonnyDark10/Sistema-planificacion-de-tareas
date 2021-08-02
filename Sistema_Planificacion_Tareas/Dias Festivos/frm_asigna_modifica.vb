Imports System.Data.SqlClient

Public Class frm_asigna_modifica

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim sql As String
        Try
            sql = "UPDATE diaS_festivos SET fecha_pedido ='" & dtp_dia.Value.Date & "', descripcion = '" & txt_descripcion.Text & "' WHERE id_dias_festivos = " & txt_asig.Text

            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" ACTUALIZADA", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frm_asigna_dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_asig.Text = frm_dia_festivos.txt_m.Text
        llenar_datos()
    End Sub

    Sub llenar_datos()
        Dim dr1 As SqlDataReader
        Dim sql As String
        Try

            sql = "SELECT id_dias_festivos,FECHA_PEDIDO,DESCRIPCION,estado_f"
            sql = sql & " from dias_festivos WHERE id_dias_festivos =" & txt_asig.Text
            Dim com1 As New SqlCommand(Sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    dtp_dia.Text = dr1("FECHA_PEDIDO")
                    txt_descripcion.Text = dr1("DESCRIPCION")

                End While
            Else
                MsgBox("Contacto no se encuentra registrado....Registre")
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
End Class