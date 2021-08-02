Imports System.Data.SqlClient

Public Class frm_eventos

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frm_eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbo_recursos_a.Enabled = False
        cbo_participantes.Enabled = False
        llenar_evento()
        llenar_tipo_evento()
        txt_cod.Text = ""
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
            gbo_recursos_a.Enabled = False

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

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String

        If (rb_solo.Checked = False And rb_varios.Checked = False) Then
            Exit Sub
        End If

        If (rb_solo.Checked = True And cbo_participantes.Text = "") Then
            MessageBox.Show("Debe llenar participante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


       

        If (cbo_eventos.Text = "" Or cbo_tipo_evento.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                
                sql = "INSERT INTO EVENTOS(FK_DNI_TIPO_EVENTO,FK_CATEGORIA_EVENTO,FK_CLIENTE,HORA_INICIO,HORA_FIN,FECHA_INICIO,FECHA_FIN,DESCRIPCION,ESTADO_E) VALUES ("
                sql = sql & cbo_eventos.SelectedValue & ", "
                sql = sql & cbo_tipo_evento.SelectedValue & ", "
                sql = sql & txt_cod.Text & ", "
                sql = sql & "'" & dtp_hora_inicio.Text & "', "
                sql = sql & "'" & dtp_hora_fin.Text & "', "
                sql = sql & "'" & dtp_inicio_fecha.Text & "', "
                sql = sql & "'" & dtp_fin_fecha.Text & "', "
                sql = sql & "'" & txt_descripcion.Text & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                Dim codigo As Integer

                '----PARA OBTENER EL ULTIMO ID DEL  ALMACENADO-------

                sql = "SELECT MAX(id_evento) as codigo FROM eventos "
                Dim re As SqlDataReader
                Dim con As New SqlCommand(sql, mycon)

                Dim dt As New DataTable
                re = con.ExecuteReader()
                dt.Load(re)

                If dt.Rows.Count > 0 Then
                    codigo = dt.Rows(0)("codigo")
                End If
                re.Close()

                '-----------------------------------------------------

                guardar_participantes_eventos(codigo)

                MessageBox.Show(" Evento Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                txt_descripcion.Text = ""
                ch_recordatorio.Checked = False
                txt_cod.Text = ""
                txt_cont.Text = ""
                rb_solo.Checked = False
                rb_varios.Checked = False
                dgv_lista2.Rows.Clear()

                

            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub




    Sub guardar_participantes_eventos(c As Integer)

        Dim sql As String

        If (rb_solo.Checked = True) Then
            Try
                sql = ""
                sql = "INSERT INTO eventos_participantes(fk_dni_participantes, fk_dni_eventos2,ESTADO_e_p) VALUES ("
                sql = sql & cbo_participantes.SelectedValue & ", "
                sql = sql & c & ", "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

               
            Catch ex As Exception
                MessageBox.Show("No es Posible Registrar participante unico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
        Else
            If rb_varios.Checked = True Then
                Try
                    Dim Codigo As Integer
                    For Each row As DataGridViewRow In Me.dgv_lista2.Rows
                        'obtenemos el valor de la columna en la variable declarada
                        Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer
                        sql = ""
                        sql = "INSERT INTO eventos_participantes(fk_dni_participantes, fk_dni_eventos2,ESTADO_e_p) VALUES ("
                        sql = sql & Codigo & ", "
                        sql = sql & c & ", "
                        sql = sql & "'A" & "')"
                        Dim com As New SqlCommand(sql, mycon)
                        Dim x As Integer
                        x = com.ExecuteNonQuery
                    Next

                   
                Catch ex As Exception
                    MessageBox.Show("No es Posible Registrar varios participantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End Try
            End If
        End If
       

    End Sub

    Private Sub rb_varios_CheckedChanged(sender As Object, e As EventArgs) Handles rb_varios.CheckedChanged
        If rb_varios.Checked = True Then
            gbo_recursos_a.Enabled = True
            llenar_participante()
        Else
            gbo_recursos_a.Enabled = False
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
            dgv_lista1.DataSource = dt
            dgv_lista1.RowHeadersVisible = False
            Me.dgv_lista1.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_lista1.Columns(1)
            row3.Width = 260

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub txt_lista_TextChanged(sender As Object, e As EventArgs) Handles txt_lista.TextChanged
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = "SELECT dni_participantes,nombre + ' '+ apellido_paterno + ' '+ APELLIDO_MATERNO as Nombres from participantes where estado_p = 'A'"
            sql = sql & " and (nombre + ' '+ apellido_paterno + ' '+ APELLIDO_MATERNO like '" & txt_lista.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dgv_lista1.DataSource = dt
            dgv_lista1.RowHeadersVisible = False
            Me.dgv_lista1.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = dgv_lista1.Columns(1)
            row3.Width = 260
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub dgv_lista1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista1.CellContentClick

    End Sub

    Dim int_id_perfil As Integer
    Dim nombres As String
    Private Sub dgv_lista1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_lista1.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil = dgv_lista1.Rows(e.RowIndex).Cells(0).Value
                nombres = dgv_lista1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_mover_Click(sender As Object, e As EventArgs) Handles btn_mover.Click
       
        Try

            dgv_lista2.Rows.Add(int_id_perfil, nombres)
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub


    Private Sub dgv_lista2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista2.CellContentClick

    End Sub

    Dim int_id_perfil2 As Integer
    Private Sub dgv_lista2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_lista2.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                int_id_perfil2 = dgv_lista1.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click

        Try
            Dim fil As Integer
            fil = dgv_lista2.CurrentRow.Index
            dgv_lista2.Rows.RemoveAt(fil)
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
End Class