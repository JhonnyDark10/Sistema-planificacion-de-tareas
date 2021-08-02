Imports System.Data.SqlClient

Public Class frm_modifica_indisponibilidad2

    Private Sub frm_modifica_indisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo()
        llenar_datos()

    End Sub

    Sub cargar_combo()
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
    Sub llenar_datos()
        Dim dr1 As SqlDataReader
        Dim sql As String
        Try

            sql = "SELECT fk_indisponibilidad,fk_participante,fecha_inicio,fecha_fin,hora_inicio,hora_fin,descripcion"
            sql = sql & " from INDISPONIBILIDAD_PARTICIPANTE WHERE dni_indisponibilidad_p =" & frm_empleados_ind_even.txt_modif.Text
            Dim com1 As New SqlCommand(sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    cbo_tipos.SelectedValue = dr1("fk_indisponibilidad")
                    txt_cod1.Text = dr1("fk_participante")
                    dtp_inicio_fecha.Text = dr1("fecha_inicio")
                    dtp_fin_fecha.Text = dr1("fecha_fin")
                    
                    txt_descripcion.Text = dr1("descripcion")
                End While
            Else
                MsgBox(" no se encuentra registrado....Registre")
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try


    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        frm_listar.ShowDialog()


    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        Try
            sql = "UPDATE indisponibilidad_participante SET fk_indisponibilidad = " & cbo_tipos.SelectedValue & ", fk_participante = " & txt_cod1.Text & ",fecha_inicio = '" & dtp_inicio_fecha.Text & "',fecha_fin ='" & dtp_fin_fecha.Text & "',hora_inicio='" & dtp_hora_inicio.Text & "',hora_fin='" & dtp_hora_fin.Text & "',descripcion='" & txt_descripcion.Text & "' WHERE DNI_INDISPONIBILIDAD_P= " & frm_empleados_ind_even.txt_modif.Text
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Actividad Marcada como Realizada", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
End Class