Imports System.Data.SqlClient

Public Class frm_empleados

    Private Sub frm_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cedula_cliente.Text = ""
        txt_nombre_cliente.Text = ""
        txt_apellido1_cliente.Text = ""
        txt_apelldio2_cliente.Text = ""
        txt_direccion_cliente.Text = ""
        txt_email_cliente.Text = "example@hotmail.com"
        txt_telefono_cliente.Text = ""
        txt_Celular.Text = ""
        txt_descripcion.Text = ""
        txt_direccion_cliente.Text = ""

        gbo_dias_se.Enabled = False

        cargar_departamentos()
        cargar_estado_civil()
        cargar_comisiones()
        esconder()
    End Sub

    Sub esconder()
        txt_lunes.Visible = False
        txt_martes.Visible = False
        txt_miercoles.Visible = False
        txt_jueves.Visible = False
        txt_viernes.Visible = False
        txt_sabados.Visible = False
        txt_domingos.Visible = False

        Num_domingo_ini.Visible = False
        Num_domingos_fin.Visible = False
        Num_jueves_fin.Visible = False
        Num_jueves_ini.Visible = False
        Num_lunes_fin.Visible = False
        Num_lunes_ini.Visible = False
        Num_martes_fin.Visible = False
        Num_martes_ini.Visible = False
        Num_miercoles_fin.Visible = False
        Num_miercoles_ini.Visible = False
        Num_sabado_ini.Visible = False
        Num_sabados_fin.Visible = False
        Num_viernes_ini.Visible = False
        Num_viernes_fin.Visible = False

        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        a4.Visible = False
        a5.Visible = False
        a6.Visible = False
        a7.Visible = False

    End Sub
    Sub cargar_comisiones()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from comisiones where estado_c = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_comi.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Sub cargar_departamentos()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from departamento where estado_d = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_depar.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Sub cargar_estado_civil()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from estado_civil where estado_e_c = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_estado_c.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub txt_cedula_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula_cliente.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula_cliente.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_cliente.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula_cliente.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_cliente.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub


    Private Sub txt_cedula_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula_cliente.TextChanged

    End Sub

    Private Sub txt_telefono_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono_cliente.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_telefono_cliente.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_cliente.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_telefono_cliente.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_cliente.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_telefono_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_telefono_cliente.TextChanged

    End Sub

    Private Sub txt_Celular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Celular.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_Celular.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_Celular.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_Celular.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_Celular.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_Celular_TextChanged(sender As Object, e As EventArgs) Handles txt_Celular.TextChanged

    End Sub

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String

        ' retorna true o false   
        If ValidateEmail(txt_email_cliente.Text) = True Then
        Else
            MessageBox.Show("Formato de correo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If (gbo_dias_se.Enabled = False) Then
            MessageBox.Show("Debe Asignar Hhorario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If (txt_Celular.Text = "" Or txt_direccion_cliente.Text = "" Or txt_email_cliente.Text = "" Or txt_cedula_cliente.Text = "" Or txt_nombre_cliente.Text = "" Or txt_apellido1_cliente.Text = "" Or txt_apelldio2_cliente.Text = "") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                sql = ""
                sql = "INSERT INTO PARTICIPANTES(FK_ID_DEPARTAMENTO,FK_ID_ESTADO_CIVIL,CEDULA,NOMBRE,"
                sql = sql & " APELLIDO_PATERNO,APELLIDO_MATERNO,DIRECCION,TELEFONO,celular,"
                sql = sql & "  EMAIL,DESCRIPCION,CIUDAD,ESTADO_P)  VALUES("
                sql = sql & Val(cbo_depar.SelectedValue) & ", "
                sql = sql & Val(cbo_estado_c.SelectedValue) & ", "
                sql = sql & "'" & txt_cedula_cliente.Text & "',"
                sql = sql & "'" & txt_nombre_cliente.Text & "',"
                sql = sql & "'" & txt_apellido1_cliente.Text & "',"
                sql = sql & "'" & txt_apelldio2_cliente.Text & "',"
                sql = sql & "'" & txt_direccion_cliente.Text & "',"
                sql = sql & "'" & txt_telefono_cliente.Text & "',"
                sql = sql & "'" & txt_Celular.Text & "',"
                sql = sql & "'" & txt_email_cliente.Text & "',"
                sql = sql & "'" & txt_descripcion.Text & "',"
                sql = sql & "'" & cbo_ciudad.Text & "',"
                sql = sql & "'A" & "')"

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery


                Dim codigo As Integer

                '----PARA OBTENER EL ULTIMO ID DEL CLIENTE ALMACENADO-------

                sql = "SELECT MAX(dni_participantes) as codigo FROM participantes "
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
                If (cbo_comi.Text = "") Then
                    MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    Try
                        sql = ""
                        sql = "INSERT INTO comisiones_participantes(fk_comisiones,fk_participantes,"
                        sql = sql & "DESCRIPCION,ESTADO_c_P)  VALUES("
                        sql = sql & Val(cbo_comi.SelectedValue) & ", "
                        sql = sql & codigo & ", "
                        sql = sql & "'------',"
                        sql = sql & "'A" & "')"

                        Dim com1 As New SqlCommand(sql, mycon)
                        Dim x1 As Integer
                        x1 = com1.ExecuteNonQuery

                        asignar_horario_participantes(codigo)

                    Catch ex As Exception

                    End Try

                End If


                MessageBox.Show(" Participante Almacenada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txt_nombre.Text = ""

                Me.Close()

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub

    Sub asignar_horario_participantes(c As Integer)
        Dim Sql As String

        '-------------------- lunes-----------------------------------------

        If (ch_lunes.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas1.Text = ocho.Value.AddHours(txt_lunes.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 100 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas1.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 100 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_lunes_ini.Text & "',"
                Sql = Sql & "'" & Num_lunes_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If

        '------------------------------ martes -----------------------------
        If (ch_martes.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas2.Text = ocho.Value.AddHours(txt_martes.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 101 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas2.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 101 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_martes_ini.Text & "',"
                Sql = Sql & "'" & Num_martes_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If

        '----------------------miercoles --------------------
        If (ch_miercoles.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas3.Text = ocho.Value.AddHours(txt_miercoles.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 102 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas3.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 102 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_miercoles_ini.Text & "',"
                Sql = Sql & "'" & Num_miercoles_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If


        ' --------------------- jueves ---------------------

        If (ch_jueves.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas4.Text = ocho.Value.AddHours(txt_jueves.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 103 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas4.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 103 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_jueves_ini.Text & "',"
                Sql = Sql & "'" & Num_jueves_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If


        '---------------------- viernes -----------------
        If (ch_viernes.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas5.Text = ocho.Value.AddHours(txt_viernes.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 104 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas5.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 104 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_viernes_ini.Text & "',"
                Sql = Sql & "'" & Num_viernes_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If


        ' ----------------- sabado -------------------

        If (ch_sabados.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas6.Text = ocho.Value.AddHours(txt_sabados.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 105 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas6.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 105 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_sabado_ini.Text & "',"
                Sql = Sql & "'" & Num_sabados_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If
        ' ------------------- domingo ----------------
        If (ch_domingos.Checked = True) Then
            If (rb_horas.Checked = True) Then

                ochomas7.Text = ocho.Value.AddHours(txt_domingos.Text).ToString()
                'guardo x horas
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 106 & ", "
                Sql = Sql & "'" & ocho.Text & "',"
                Sql = Sql & "'" & ochomas7.Text & "',"
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            Else
                'guardo x espacios
                Sql = ""
                Sql = "INSERT INTO asignar_horarios(fk_dni_empleados,fk_dni_horarios,hora_inicio_numero,hora_fin_numero,"
                Sql = Sql & "horas_inicio_espacio,horas_fin_espacio,ESTADO_h)  VALUES("
                Sql = Sql & c & ", "
                Sql = Sql & 106 & ", "
                Sql = Sql & "'',"
                Sql = Sql & "'',"
                Sql = Sql & "'" & Num_domingo_ini.Text & "',"
                Sql = Sql & "'" & Num_domingos_fin.Text & "',"
                Sql = Sql & "'A" & "')"

                Dim com3 As New SqlCommand(Sql, mycon)
                Dim x3 As Integer
                x3 = com3.ExecuteNonQuery
            End If
        End If


       
    End Sub




    Private Sub ch_lunes_CheckedChanged(sender As Object, e As EventArgs) Handles ch_lunes.CheckedChanged



    End Sub

    Private Sub ch_lunes_Click(sender As Object, e As EventArgs) Handles ch_lunes.Click
        If (ch_lunes.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_lunes.Visible = True
                Num_lunes_ini.Visible = False
                Num_lunes_fin.Visible = False
                a1.Visible = False
            Else
                Num_lunes_ini.Visible = True
                Num_lunes_fin.Visible = True
                a1.Visible = True
                txt_lunes.Visible = False
            End If
        Else
            txt_lunes.Visible = False
            Num_lunes_ini.Visible = False
            Num_lunes_fin.Visible = False
            a1.Visible = False
        End If
    End Sub

    Private Sub rb_horas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_horas.CheckedChanged

    End Sub

    Private Sub rb_horas_Click(sender As Object, e As EventArgs) Handles rb_horas.Click
        gbo_dias_se.Enabled = True

        If rb_horas.Checked = True Then
            ch_lunes.Checked = False
            ch_martes.Checked = False
            ch_miercoles.Checked = False
            ch_jueves.Checked = False
            ch_viernes.Checked = False
            ch_sabados.Checked = False
            ch_domingos.Checked = False
            esconder()
        End If
    End Sub

    Private Sub rb_espacio_CheckedChanged(sender As Object, e As EventArgs) Handles rb_espacio.CheckedChanged

    End Sub

    Private Sub rb_espacio_Click(sender As Object, e As EventArgs) Handles rb_espacio.Click
        gbo_dias_se.Enabled = True

        If rb_espacio.Checked = True Then
            ch_lunes.Checked = False
            ch_martes.Checked = False
            ch_miercoles.Checked = False
            ch_jueves.Checked = False
            ch_viernes.Checked = False
            ch_sabados.Checked = False
            ch_domingos.Checked = False
            esconder()
        End If
    End Sub

    Private Sub ch_martes_CheckedChanged(sender As Object, e As EventArgs) Handles ch_martes.CheckedChanged

    End Sub

    Private Sub ch_martes_Click(sender As Object, e As EventArgs) Handles ch_martes.Click
        If (ch_martes.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_martes.Visible = True
                Num_martes_ini.Visible = False
                Num_martes_fin.Visible = False
                a2.Visible = False
            Else
                Num_martes_ini.Visible = True
                Num_martes_fin.Visible = True
                a2.Visible = True
                txt_martes.Visible = False
            End If
        Else
            txt_martes.Visible = False
            Num_martes_ini.Visible = False
            Num_martes_fin.Visible = False
            a2.Visible = False
        End If
    End Sub

    Private Sub ch_miercoles_CheckedChanged(sender As Object, e As EventArgs) Handles ch_miercoles.CheckedChanged

    End Sub

    Private Sub ch_miercoles_Click(sender As Object, e As EventArgs) Handles ch_miercoles.Click
        If (ch_miercoles.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_miercoles.Visible = True
                Num_miercoles_ini.Visible = False
                Num_miercoles_fin.Visible = False
                a3.Visible = False
            Else
                Num_miercoles_ini.Visible = True
                Num_miercoles_fin.Visible = True
                a3.Visible = True
                txt_miercoles.Visible = False
            End If
        Else
            Num_miercoles_ini.Visible = False
            Num_miercoles_fin.Visible = False
            a3.Visible = False
            txt_miercoles.Visible = False
        End If

    End Sub

    Private Sub ch_jueves_CheckedChanged(sender As Object, e As EventArgs) Handles ch_jueves.CheckedChanged

    End Sub

    Private Sub ch_jueves_Click(sender As Object, e As EventArgs) Handles ch_jueves.Click
        If (ch_jueves.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_jueves.Visible = True
                Num_jueves_ini.Visible = False
                Num_jueves_fin.Visible = False
                a4.Visible = False
            Else
                Num_jueves_ini.Visible = True
                Num_jueves_fin.Visible = True
                a4.Visible = True
                txt_jueves.Visible = False
            End If
        Else
            Num_jueves_ini.Visible = False
            Num_jueves_fin.Visible = False
            a4.Visible = False
            txt_jueves.Visible = False
        End If

    End Sub

    Private Sub ch_viernes_CheckedChanged(sender As Object, e As EventArgs) Handles ch_viernes.CheckedChanged

    End Sub

    Private Sub ch_viernes_Click(sender As Object, e As EventArgs) Handles ch_viernes.Click
        If (ch_viernes.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_viernes.Visible = True
                Num_viernes_ini.Visible = False
                Num_viernes_fin.Visible = False
                a5.Visible = False
            Else
                Num_viernes_ini.Visible = True
                Num_viernes_fin.Visible = True
                a5.Visible = True
                txt_viernes.Visible = False
            End If
        Else
            Num_viernes_ini.Visible = False
            Num_viernes_fin.Visible = False
            a5.Visible = False
            txt_viernes.Visible = False
        End If
    End Sub

    Private Sub ch_sabados_CheckedChanged(sender As Object, e As EventArgs) Handles ch_sabados.CheckedChanged

    End Sub

    Private Sub ch_sabados_Click(sender As Object, e As EventArgs) Handles ch_sabados.Click
        If (ch_sabados.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_sabados.Visible = True
                Num_sabado_ini.Visible = False
                Num_sabados_fin.Visible = False
                a6.Visible = False
            Else
                Num_sabado_ini.Visible = True
                Num_sabados_fin.Visible = True
                a6.Visible = True
                txt_sabados.Visible = False
            End If
        Else
            Num_sabado_ini.Visible = False
            Num_sabados_fin.Visible = False
            a6.Visible = False
            txt_sabados.Visible = False
        End If
    End Sub

    Private Sub ch_domingos_CheckedChanged(sender As Object, e As EventArgs) Handles ch_domingos.CheckedChanged

    End Sub

    Private Sub ch_domingos_Click(sender As Object, e As EventArgs) Handles ch_domingos.Click

        If (ch_domingos.Checked = True) Then
            If (rb_horas.Checked = True) Then
                txt_domingos.Visible = True
                Num_domingo_ini.Visible = False
                Num_domingos_fin.Visible = False
                a7.Visible = False
            Else
                Num_domingo_ini.Visible = True
                Num_domingos_fin.Visible = True
                a7.Visible = True
                txt_domingos.Visible = False
            End If
        Else
            Num_domingo_ini.Visible = False
            Num_domingos_fin.Visible = False
            a7.Visible = False
            txt_domingos.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub txt_lunes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lunes.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_lunes.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_lunes.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_lunes.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_lunes.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_lunes_TextChanged(sender As Object, e As EventArgs) Handles txt_lunes.TextChanged

    End Sub

    Private Sub txt_martes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_martes.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_martes.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_martes.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_martes.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_martes.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_martes_TextChanged(sender As Object, e As EventArgs) Handles txt_martes.TextChanged

    End Sub

    Private Sub txt_miercoles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_miercoles.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_miercoles.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_miercoles.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_miercoles.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_miercoles.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_miercoles_TextChanged(sender As Object, e As EventArgs) Handles txt_miercoles.TextChanged

    End Sub

    Private Sub txt_jueves_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jueves.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_jueves.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_jueves.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_jueves.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_jueves.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_jueves_TextChanged(sender As Object, e As EventArgs) Handles txt_jueves.TextChanged

    End Sub

    Private Sub txt_viernes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_viernes.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_viernes.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_viernes.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_viernes.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_viernes.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_viernes_TextChanged(sender As Object, e As EventArgs) Handles txt_viernes.TextChanged

    End Sub

    Private Sub txt_sabados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sabados.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_sabados.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_sabados.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_sabados.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_sabados.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_sabados_TextChanged(sender As Object, e As EventArgs) Handles txt_sabados.TextChanged

    End Sub

    Private Sub txt_domingos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_domingos.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_domingos.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_domingos.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_domingos.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_domingos.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_domingos_TextChanged(sender As Object, e As EventArgs) Handles txt_domingos.TextChanged

    End Sub
End Class