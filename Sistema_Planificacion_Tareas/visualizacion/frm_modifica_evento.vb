Imports System.Data.SqlClient
Public Class frm_modifica_evento

    Private Sub frm_modifica_evento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox3.Visible = False


        cbo_participantes.Enabled = False
        llenar_evento()
        llenar_tipo_evento()

        recuperardatos()

    End Sub
    Public jhonny As Integer
    Sub recuperardatos()
        Dim dr1 As SqlDataReader
        Dim sql As String

        Try

            sql = ""
            sql = sql & " select e.fk_dni_tipo_evento,e.fk_categoria_evento,e.fk_cliente,ep.id_eventos_participantes,p.cedula AS CEDULA,"
            sql = sql & " e.id_evento,e.FECHA_INICIO,e.FECHA_FIN,e.DESCRIPCION,ct.direccion,ct.apellido_paterno from "
            sql = sql & " PARTICIPANTES p"
            sql = sql & " inner join EVENTOS_PARTICIPANTES ep"
            sql = sql & " on p.DNI_PARTICIPANTES = ep.FK_DNI_PARTICIPANTES"
            sql = sql & " inner join EVENTOS e "
            sql = sql & " on ep.FK_DNI_EVENTOS2 = e.ID_EVENTO"
            sql = sql & " inner join contactos ct "
            sql = sql & " on e.FK_cliente = ct.dni_cliente"
            sql = sql & " where ep.ESTADO_E_P = 'A' and  ep.id_eventos_participantes  = " & frm_empleados_ind_even.txt_modifevento.Text


            Dim com1 As New SqlCommand(sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    cbo_eventos.SelectedValue = dr1("fk_dni_tipo_evento")
                    cbo_tipo_evento.SelectedValue = dr1("fk_categoria_evento")
                    If (dr1("fk_cliente") = 2) Then
                        ch_sinc.Checked = True
                    Else
                        ch_sinc.Checked = False
                    End If
                    txt_cod.Text = dr1("fk_cliente")
                    jhonny = dr1("id_evento")
                    dtp_inicio_fecha.Text = dr1("fecha_inicio")
                    dtp_fin_fecha.Text = dr1("fecha_fin")

                    txt_descripcion.Text = dr1("descripcion")
                    txt_cont.Text = dr1("direccion")
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

   


    Sub llenar_tipo_evento()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from CATEGORIA_EVENTOS where estado_c_e = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipo_evento.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
    Sub llenar_evento()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from tipo_evento where estado_m = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_eventos.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub


    Private Sub rb_solo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_solo.CheckedChanged
        If rb_solo.Checked = True Then
            cbo_participantes.Enabled = True
            llenar_participantes()


        Else
            cbo_participantes.Enabled = False
        End If
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
            cbo_participantes.DisplayMember = "nombres"
            cbo_participantes.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        frm_listar_contactos.ShowDialog()
    End Sub

    Private Sub cbo_participantes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_participantes.SelectedIndexChanged
    End Sub



    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub rb_varios_CheckedChanged(sender As Object, e As EventArgs) Handles rb_varios.CheckedChanged
        If rb_varios.Checked = True Then

            llenar_participante()
        Else

        End If
    End Sub

    Private Sub rb_varios_Click(sender As Object, e As EventArgs) Handles rb_varios.Click

    End Sub


    Sub llenar_participante()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = "SELECT dni_participantes,nombre + ' '+ apellido_paterno + ' '+ APELLIDO_MATERNO as Nombres from participantes where estado_p = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            'dgv_lista1.DataSource = dt
            'dgv_lista1.RowHeadersVisible = False
            'Me.dgv_lista1.Columns(0).Visible = False
            'Dim row3 As DataGridViewColumn = dgv_lista1.Columns(1)
            'row3.Width = 260

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    'Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs)
    '    Dim sql As String
    '    Dim dr As SqlDataReader
    '    Dim dt As New DataTable
    '    Try

    '        sql = ""
    '        sql = "SELECT dni_participantes,nombre + ' '+ apellido_paterno + ' '+ APELLIDO_MATERNO as Nombres from participantes where estado_p = 'A'"
    '        sql = sql & " and (nombre + ' '+ apellido_paterno + ' '+ APELLIDO_MATERNO like '" & txt_lista.Text & "%')"
    '        Dim com As New SqlCommand(sql, mycon)
    '        dr = com.ExecuteReader
    '        dt.Load(dr)
    '        'dgv_lista1.DataSource = dt
    '        'dgv_lista1.RowHeadersVisible = False
    '        'Me.dgv_lista1.Columns(0).Visible = False
    '        'Dim row3 As DataGridViewColumn = dgv_lista1.Columns(1)
    '        'row3.Width = 260
    '    Catch ex As Exception
    '        MsgBox("Error al conectar con la BD " & ex.Message)
    '    Finally
    '        '  MsgBox("No se puede.....!!!")

    '    End Try
    'End Sub

    Private Sub dgv_lista1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Dim int_id_perfil As Integer
    Dim nombres As String
    Private Sub dgv_lista1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex > -1 Then
                'int_id_perfil = dgv_lista1.Rows(e.RowIndex).Cells(0).Value
                'nombres = dgv_lista1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_mover_Click(sender As Object, e As EventArgs)

        Try

            'dgv_lista2.Rows.Add(int_id_perfil, nombres)
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub


    Private Sub dgv_lista2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Dim int_id_perfil2 As Integer
    Private Sub dgv_lista2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex > -1 Then
                'int_id_perfil2 = dgv_lista1.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs)

        Try
            Dim fil As Integer
            'fil = dgv_lista2.CurrentRow.Index
            'dgv_lista2.Rows.RemoveAt(fil)
        Catch ex As Exception
            MsgBox("Error  " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub txt_cont_TextChanged(sender As Object, e As EventArgs) Handles txt_cont.TextChanged
        If txt_cont.Text = "" Then
            txt_cod.Text = ""
        End If
    End Sub


    Private Sub ch_sinc_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ch_sinc_CheckedChanged_1(sender As Object, e As EventArgs) Handles ch_sinc.CheckedChanged
        If ch_sinc.Checked = True Then
            txt_cont.Text = ""
            txt_cont.Enabled = False

            txt_cod.Text = 2
        Else
            txt_cont.Enabled = True

        End If
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click

        modifica_eventos()

        Me.Close()

    End Sub

    Sub modifica_eventos()
        Dim sql As String
        Try
            sql = "UPDATE eventos SET fk_cliente= " & txt_cod.Text & ",fk_dni_tipo_evento =" & cbo_eventos.SelectedValue & ",fk_categoria_evento = " & cbo_tipo_evento.SelectedValue & ",fk_cliente = " & txt_cod.Text & ",hora_inicio='" & dtp_hora_inicio.Text & "',hora_fin = '" & dtp_hora_fin.Text & "',fecha_inicio = '" & dtp_inicio_fecha.Text & "',fecha_fin = '" & dtp_fin_fecha.Text & "',descripcion =' " & txt_descripcion.Text & "' WHERE id_evento = " & jhonny
            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
          
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    
    
End Class