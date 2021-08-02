Imports System.Data.SqlClient

Public Class frm_modifica_cliente

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub frm_modifica_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_codigo_client.Text = frm_cliente.txt_cli_asig.Text
        cargar_combo()
        llenar_datos()
    End Sub

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Sub cargar_combo()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from tipo_cliente where estado_t_c = 'A'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_categoria_cliente.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
    Sub llenar_datos()
        Dim dr1 As SqlDataReader
        Dim sql As String
        Try

            sql = "SELECT c.dni_cliente,C.FK_ID_TIPO_CLIENTE,C.CEDULA,C.NOMBRE_EMPRESA,C.NOMBRE_CONTACTO,"
            sql = sql & " C.APELLIDO_PATERNO,C.APELLIDO_MATERNO,C.DIRECCION,C.CIUDAD,C.EMAIL,C.TELEFONO,C.celular,"
            sql = sql & " C.FAX,C.PAGINA_WEB,C.ESTADO_C from contactos C INNER JOIN TIPO_CLIENTE T_C ON C.FK_ID_TIPO_CLIENTE = T_C.ID_TIPO_CLIENTE WHERE C.DNI_CLIENTE =" & txt_codigo_client.Text
            Dim com1 As New SqlCommand(Sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    cbo_categoria_cliente.SelectedValue = dr1("FK_ID_TIPO_CLIENTE")
                    txt_nombre_empresa.Text = dr1("NOMBRE_EMPRESA")
                    txt_cedula_cliente.Text = dr1("CEDULA")
                    txt_nombre_cliente.Text = dr1("NOMBRE_CONTACTO")
                    txt_apellido1_cliente.Text = dr1("APELLIDO_PATERNO")
                    txt_apelldio2_cliente.Text = dr1("APELLIDO_MATERNO")
                    txt_direccion_cliente.Text = dr1("DIRECCION")
                    cbo_ciudad.Text = dr1("CIUDAD")
                    txt_email_cliente.Text = dr1("EMAIL")
                    txt_celular.Text = dr1("celular")
                    txt_telefono_cliente.Text = dr1("TELEFONO")
                    txt_fax.Text = dr1("fax")
                    txt_web.Text = dr1("PAGINA_WEB")
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




    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String
        Try
            If ValidateEmail(txt_email_cliente.Text) = True Then
            Else
                MessageBox.Show("Formato de correo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            sql = "UPDATE contactos SET FK_ID_TIPO_CLIENTE =" & cbo_categoria_cliente.SelectedValue & ", CEDULA = '" & txt_cedula_cliente.Text & "',"
            sql = sql & " NOMBRE_EMPRESA = '" & txt_nombre_empresa.Text & "',NOMBRE_CONTACTO = ' " & txt_nombre_cliente.Text & "',"
            sql = sql & "APELLIDO_PATERNO='" & txt_apellido1_cliente.Text & "', APELLIDO_MATERNO ='" & txt_apelldio2_cliente.Text & "',"
            sql = sql & "DIRECCION='" & txt_direccion_cliente.Text & "',CIUDAD='" & cbo_ciudad.Text & "',EMAIL='" & txt_email_cliente.Text & "',"
            sql = sql & "TELEFONO='" & txt_telefono_cliente.Text & "',celular='" & txt_celular.Text & "',"
            sql = sql & "FAX='" & txt_fax.Text & "',PAGINA_WEB='" & txt_web.Text & "', estado_c = 'A'"
            sql = sql & " WHERE dni_cliente = " & txt_codigo_client.Text

            Dim com As New SqlCommand(sql, mycon)
            Dim x As Integer
            x = com.ExecuteNonQuery
            MessageBox.Show(" Contacto Actualizado", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub txt_nombre_empresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_empresa.KeyPress
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

    Private Sub txt_nombre_empresa_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_empresa.TextChanged

    End Sub

    Private Sub txt_nombre_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_cliente.KeyPress
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

    Private Sub txt_nombre_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_cliente.TextChanged

    End Sub

    Private Sub txt_apellido1_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido1_cliente.KeyPress
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

    Private Sub txt_apellido1_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido1_cliente.TextChanged

    End Sub

    Private Sub txt_apelldio2_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apelldio2_cliente.KeyPress
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

    Private Sub txt_apelldio2_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_apelldio2_cliente.TextChanged

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

    Private Sub txt_celular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_celular.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_celular.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_celular.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_celular.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_celular.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_celular_TextChanged(sender As Object, e As EventArgs) Handles txt_celular.TextChanged

    End Sub
End Class