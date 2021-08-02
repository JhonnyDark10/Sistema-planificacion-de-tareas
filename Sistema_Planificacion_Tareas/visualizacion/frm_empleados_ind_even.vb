Imports System.Data.SqlClient

Public Class frm_empleados_ind_even

    Private Sub frm_empleados_ind_even_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        llenar_participantes()
    End Sub

   Sub llenar_participantes()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT dni_participantes, nombre + ' ' +apellido_paterno as nombres from participantes where estado_p = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_p.DisplayMember = "nombres"
            cbo_p.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub cbo_p_Click(sender As Object, e As EventArgs) Handles cbo_p.Click
        While (dgv_ind.RowCount > 1)
            dgv_ind.Rows.Remove(dgv_ind.CurrentRow)
        End While

    End Sub

    Private Sub cbo_p_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_p.SelectedIndexChanged
       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        llenar_indisponibilidad()
    End Sub

    Sub llenar_indisponibilidad()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & " select ip.dni_indisponibilidad_p,p.CEDULA ,i.descripcion as TIPO,ip.FECHA_INICIO AS 'FECHA INICIO' ,ip.FECHA_FIN AS 'FECHA FIN',ip.DESCRIPCION  from "
            sql = sql & " PARTICIPANTES p"
            sql = sql & " inner join INDISPONIBILIDAD_PARTICIPANTE ip"
            sql = sql & " on p.DNI_PARTICIPANTES = ip.FK_PARTICIPANTE "
            sql = sql & " inner join INDISPONIBILIDAD i "
            sql = sql & " on ip.FK_INDISPONIBILIDAD = i.DNI_INDISPONIBILIDAD "
            sql = sql & " where ip.ESTADO_I = 'A' and ip.FK_PARTICIPANTE = " & cbo_p.SelectedValue

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_ind.DataSource = dt
            dgv_ind.RowHeadersVisible = False
            Me.dgv_ind.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_ind.Columns(5)
            row3.Width = 230
            llenar_eventos()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub
    Sub llenar_eventos()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""

            sql = sql & " select ep.id_eventos_participantes,p.cedula AS CEDULA,te.descripcion,"
            sql = sql & " e.FECHA_INICIO,e.FECHA_FIN,e.DESCRIPCION from "
            sql = sql & " PARTICIPANTES p"
            sql = sql & " inner join EVENTOS_PARTICIPANTES ep"
            sql = sql & " on p.DNI_PARTICIPANTES = ep.FK_DNI_PARTICIPANTES"
            sql = sql & " inner join EVENTOS e "
            sql = sql & " on ep.FK_DNI_EVENTOS2 = e.ID_EVENTO"
            sql = sql & " inner join tipo_evento te"
            sql = sql & " on e.fk_dni_tipo_evento = te.id_tipo_evento"
            sql = sql & " where ep.ESTADO_E_P = 'A' and  ep.FK_DNI_PARTICIPANTES  = " & cbo_p.SelectedValue


            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_even.DataSource = dt
            dgv_even.RowHeadersVisible = False
            Me.dgv_even.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_even.Columns(5)
            row3.Width = 230
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Dim int_indisponibilidad As Integer
    Private Sub dgv_ind_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ind.CellClick
        Try
            If e.RowIndex > -1 Then
                int_indisponibilidad = dgv_ind.Rows(e.RowIndex).Cells(0).Value
                txt_modif.Text = int_indisponibilidad
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_ind_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ind.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Try
            sql = "UPDATE indisponibilidad_participante SET estado_i ='I' WHERE DNI_INDISPONIBILIDAD_P= " & int_indisponibilidad
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Actividad Marcada como Realizada", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            llenar_indisponibilidad()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_modifica_indisponibilidad2.ShowDialog()
        llenar_indisponibilidad()
    End Sub

    Dim int_eventos_a As Integer
    Private Sub dgv_even_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_even.CellClick
        Try
            If e.RowIndex > -1 Then
                int_eventos_a = dgv_even.Rows(e.RowIndex).Cells(0).Value
                txt_modifevento.Text = int_eventos_a
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sql As String
        Try
            sql = "UPDATE eventos_participantes SET estado_e_p = 'I' WHERE id_eventos_participantes = " & txt_modifevento.Text
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Actividad Marcada como Realizada", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            llenar_indisponibilidad()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frm_modifica_evento.ShowDialog()
        llenar_eventos()

    End Sub

    Private Sub dgv_even_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_even.CellContentClick

    End Sub
End Class