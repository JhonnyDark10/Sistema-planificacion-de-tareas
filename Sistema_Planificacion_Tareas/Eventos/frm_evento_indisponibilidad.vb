Imports System.Data.SqlClient

Public Class frm_evento_indisponibilidad

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub frm_evento_indisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_tipo_evento()

    End Sub


    Sub llenar_tipo_evento()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from indisponibilidad where estado_i = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipos.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        frm_listar.showdialog()

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        If (txt_descripcion.Text = "" And txt_buscar.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO INDISPONIBILIDAD_PARTICIPANTE(FK_INDISPONIBILIDAD,FK_PARTICIPANTE, FECHA_INICIO,FECHA_FIN,HORA_INICIO,HORA_FIN,DESCRIPCION,ESTADO_I) VALUES ("
                sql = sql & cbo_tipos.SelectedValue & ", "
                sql = sql & Val(txt_cod1.Text) & ", "
                sql = sql & "'" & dtp_inicio_fecha.Text & "', "
                sql = sql & "'" & dtp_fin_fecha.Text & "', "
                sql = sql & "'" & dtp_hora_inicio.Text & "', "
                sql = sql & "'" & dtp_hora_fin.Text & "', "
                sql = sql & "'" & txt_descripcion.Text & "', "
                sql = sql & "'A" & "')"

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show("INDISPONIBILIDAD ALMACENADA", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                txt_descripcion.Text = ""
                txt_buscar.Text = ""
                txt_cod1.Text = ""
                ch_recordatorio.Checked = False

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub

End Class