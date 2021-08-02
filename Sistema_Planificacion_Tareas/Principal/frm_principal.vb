Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frm_principal


    Private Sub frm_principal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try

            Dim str_mensage, str_titulo As String
            str_mensage = "El Sistema De Planificación A Sido Cerrado"
            str_titulo = "SISTEMA"
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox(str_mensage, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, str_titulo)
            'If respuesta = MsgBoxResult.Yes Then

            '    e.Cancel = False
            'Else
            '    e.Cancel = True
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New Acceso_Sistema
        form.ShowDialog()
        Timer2.Enabled = True

        llenar_data_participante()

        dgv_fechas.Rows.Add("08:00 - 09:00")
        dgv_fechas.Rows.Add("09:00 - 10:00")
        dgv_fechas.Rows.Add("10:00 - 11:00")
        dgv_fechas.Rows.Add("11:00 - 12:00")
        dgv_fechas.Rows.Add("12:00 - 13:00")
        dgv_fechas.Rows.Add("13:00 - 14:00")
        dgv_fechas.Rows.Add("14:00 - 15:00")
        dgv_fechas.Rows.Add("15:00 - 16:00")
        dgv_fechas.Rows.Add("16:00 - 17:00")

        Dim row As DataGridViewRow = dgv_fechas.Rows(0)
        row.Height = 60
        Dim row1 As DataGridViewRow = dgv_fechas.Rows(1)
        row1.Height = 60
        Dim row2 As DataGridViewRow = dgv_fechas.Rows(2)
        row2.Height = 60
        Dim row3 As DataGridViewRow = dgv_fechas.Rows(3)
        row3.Height = 60
        Dim row4 As DataGridViewRow = dgv_fechas.Rows(4)
        row4.Height = 60
        Dim row5 As DataGridViewRow = dgv_fechas.Rows(5)
        row5.Height = 60
        Dim row6 As DataGridViewRow = dgv_fechas.Rows(6)
        row6.Height = 60
        Dim row7 As DataGridViewRow = dgv_fechas.Rows(7)
        row7.Height = 60
        Dim row8 As DataGridViewRow = dgv_fechas.Rows(8)
        row8.Height = 60




    End Sub


    Private Sub CategoriaEventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaEventosToolStripMenuItem.Click
        frm_categoria_evento.ShowDialog()


    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frm_cliente.ShowDialog()


    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_comision.ShowDialog()


    End Sub

    Private Sub DiasFestivosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frm_dia_festivos.Show()

    End Sub

    Private Sub EstadoCivilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoCivilToolStripMenuItem.Click
        frm_estado_civil.ShowDialog()
    End Sub

    Private Sub NuevoEventoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoEventoToolStripMenuItem.Click
        frm_eventos.ShowDialog()
    End Sub

    Private Sub NuevaIndisponibilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaIndisponibilidadToolStripMenuItem.Click
        frm_evento_indisponibilidad.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frm_empleados.ShowDialog()


    End Sub

    Private Sub MaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialesToolStripMenuItem.Click
        frm_materiales.ShowDialog()


    End Sub

    Private Sub TipoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoClientesToolStripMenuItem.Click
        frm_tipo_cliente.ShowDialog()
    End Sub

    Private Sub TipoEventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoEventosToolStripMenuItem.Click
        frm_tipos_eventos.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

   

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        lbl_hora.Text = "Hora: " & DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frm_eventos.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frm_cliente.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm_Lista_Empleados.ShowDialog()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frm_materiales.ShowDialog()

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        frm_evento_indisponibilidad.ShowDialog()

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        frm_dia_festivos.ShowDialog()

    End Sub

    Private Sub HerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HerramientasToolStripMenuItem.Click

    End Sub

    Private Sub TipoIndisponibilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoIndisponibilidadToolStripMenuItem.Click
        frm_indisponibilidad.ShowDialog()
    End Sub

    Private Sub TipoDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDepartamentoToolStripMenuItem.Click
        frm_comision.ShowDialog()
    End Sub

    Private Sub TipoComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoComisiónToolStripMenuItem.Click
        frm_comisiones.ShowDialog()
    End Sub

    Private Sub cbo_elegir_Click(sender As Object, e As EventArgs) Handles cbo_elegir.Click

    End Sub

    Sub llenar_data_contactos()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select C.DNI_CLIENTE ,C.APELLIDO_PATERNO AS  APELLIDO,C.NOMBRE_CONTACTO AS NOMBRE "
            sql = sql & " From contactos C"
            sql = sql & " WHERE estado_c = 'A' "
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            llena_datos_info.DataSource = dt
            llena_datos_info.RowHeadersVisible = False
            Me.llena_datos_info.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = llena_datos_info.Columns(2)
            row3.Width = 140
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try

    End Sub

    Sub llenar_data_participante()

        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = ""
            sql = sql & "select p.DNI_PARTICIPANTES, p.APELLIDO_PATERNO as APELLIDO,p.NOMBRE"
            sql = sql & " From PARTICIPANTES p"
            sql = sql & " WHERE P.ESTADO_P = 'A' "

            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            llena_datos_info.DataSource = dt
            llena_datos_info.RowHeadersVisible = False
            Me.llena_datos_info.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = llena_datos_info.Columns(2)
            row3.Width = 140
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try


    End Sub

    Sub llenar_data_materiales()

        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select ID_materiales as CODIGO,nombre as NOMBRE,cantidad_M as CANTIDAD from materiales where estado_m = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            llena_datos_info.DataSource = dt
            llena_datos_info.RowHeadersVisible = False
            Me.llena_datos_info.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = llena_datos_info.Columns(2)
            row3.Width = 130
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub



    Private Sub cbo_elegir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_elegir.SelectedIndexChanged
        If (cbo_elegir.Text = "Contactos") Then

            llenar_data_contactos()
        ElseIf (cbo_elegir.Text = "Participantes") Then
            llenar_data_participante()

        ElseIf (cbo_elegir.Text = "Materiales") Then
            llenar_data_materiales()

        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If (cbo_elegir.Text = "Contactos") Then

            filtra_data_contactos()
        ElseIf (cbo_elegir.Text = "Participantes") Then
            filtra_data_participante()

        ElseIf (cbo_elegir.Text = "Materiales") Then
            filtra_data_materiales()

        End If
    End Sub


    Sub filtra_data_contactos()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select C.DNI_CLIENTE ,C.APELLIDO_PATERNO AS  APELLIDO,C.NOMBRE_CONTACTO AS NOMBRE "
            sql = sql & " From contactos C"
            sql = sql & " WHERE c.estado_c = 'A' and (c.NOMBRE_EMPRESA like '" & txt_buscar.Text & "%' or c.apellido_paterno + apellido_materno like'" & txt_buscar.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            llena_datos_info.DataSource = dt
            llena_datos_info.RowHeadersVisible = False
            Me.llena_datos_info.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = llena_datos_info.Columns(2)
            row3.Width = 140


        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub


    Sub filtra_data_participante()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = ""
            sql = sql & "select p.DNI_PARTICIPANTES, p.APELLIDO_PATERNO as APELLIDO,p.NOMBRE"
            sql = sql & " From PARTICIPANTES p"
            sql = sql & " WHERE P.ESTADO_P = 'A' and (p.cedula like '" & txt_buscar.Text & "%' or p.apellido_paterno + p.apellido_materno like'" & txt_buscar.Text & "%')"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            llena_datos_info.DataSource = dt
            llena_datos_info.RowHeadersVisible = False
            Me.llena_datos_info.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = llena_datos_info.Columns(2)
            row3.Width = 140

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Sub filtra_data_materiales()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try

            sql = "select ID_materiales as CODIGO,nombre as NOMBRE,cantidad_M as CANTIDAD from materiales "
            sql = sql & " WHERE estado_m = 'A' and nombre like '" & txt_buscar.Text & "%'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            llena_datos_info.DataSource = dt
            llena_datos_info.RowHeadersVisible = False
            Me.llena_datos_info.Columns(0).Visible = False
            Dim row3 As DataGridViewColumn = llena_datos_info.Columns(2)
            row3.Width = 130
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")

        End Try
    End Sub

    Private Sub EnviarEMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarEMailToolStripMenuItem.Click
        FormEnviarCorreo.ShowDialog()

    End Sub

    Private Sub dgv_fechas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fechas.CellContentClick

    End Sub

    Private Sub dgv_fechas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fechas.CellDoubleClick
        Try
            If e.RowIndex > -1 Then
                frm_eventos.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_fechas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_fechas.CellMouseDoubleClick

    End Sub

    Private Sub ContactosTelefónicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactosTelefónicosToolStripMenuItem.Click
        frm_contactos_telefonicos.ShowDialog()

    End Sub

    Private Sub EventosYTareasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventosYTareasToolStripMenuItem.Click
        frm_empleados_ind_even.ShowDialog()

    End Sub

    Private Sub llena_datos_info_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles llena_datos_info.CellContentClick

    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click
        perfiles.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        usuarios.ShowDialog()

    End Sub

    Private Sub CerrarSeciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSeciónToolStripMenuItem.Click
        tss_usuario.Text = ""
        Acceso_Sistema.Show()
    End Sub

    Private Sub ParticipantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParticipantesToolStripMenuItem.Click
        reporte_empleados.ShowDialog()
    End Sub

    Private Sub ReporteContactosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteContactosToolStripMenuItem.Click
        clientes.ShowDialog()

    End Sub

    Private Sub IndisponibilidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndisponibilidadesToolStripMenuItem.Click
        indisponibilidades.ShowDialog()
    End Sub

    Private Sub EventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventosToolStripMenuItem.Click
        repor_eventos.ShowDialog()
    End Sub

    Private Sub VisitaNuestroSitioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitaNuestroSitioToolStripMenuItem.Click
        Process.Start("https://www.facebook.com/profile.php?id=100023830720225")
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Process.Start("http://www.gadanconcito.gob.ec/")
    End Sub
End Class
