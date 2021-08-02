Imports System.Data.SqlClient

Public Class frm_datos_cliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub


    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String

        ' retorna true o false   
        If ValidateEmail(txt_email_cliente.Text) = True Then
        Else
            MessageBox.Show("Formato de correo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If ((cbo_categoria_cliente.Text = "empresa" And txt_nombre_empresa.Text = "") Or
            (txt_celular.Text = "" Or txt_direccion_cliente.Text = "" Or txt_email_cliente.Text = "")) Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                sql = "INSERT INTO CONTACTOS(FK_ID_TIPO_CLIENTE,CEDULA,NOMBRE_EMPRESA,NOMBRE_CONTACTO,"
                sql = sql & " APELLIDO_PATERNO,APELLIDO_MATERNO,DIRECCION,CIUDAD,EMAIL,TELEFONO,celular,"
                sql = sql & "  FAX,PAGINA_WEB,ESTADO_C)  VALUES("
                sql = sql & Val(cbo_categoria_cliente.SelectedValue) & ", "
                sql = sql & "'" & txt_cedula_cliente.Text & "',"
                sql = sql & "'" & txt_nombre_empresa.Text & "',"
                sql = sql & "'" & txt_nombre_cliente.Text & "',"
                sql = sql & "'" & txt_apellido1_cliente.Text & "',"
                sql = sql & "'" & txt_apelldio2_cliente.Text & "',"
                sql = sql & "'" & txt_direccion_cliente.Text & "',"
                sql = sql & "'" & cbo_ciudad.Text & "',"
                sql = sql & "'" & txt_email_cliente.Text & "',"
                sql = sql & "'" & txt_telefono_cliente.Text & "',"
                sql = sql & "'" & txt_celular.Text & "',"
                sql = sql & "'" & txt_fax.Text & "',"
                sql = sql & "'" & txt_web.Text & "',"
                sql = sql & "'A" & "')"

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Contacto Almacenado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txt_nombre.Text = ""

                Me.Close()

            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub frm_datos_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_combo()
        txt_cedula_cliente.Text = ""
        txt_nombre_empresa.Text = ""
        txt_nombre_cliente.Text = ""
        txt_apellido1_cliente.Text = ""
        txt_apelldio2_cliente.Text = ""
        txt_direccion_cliente.Text = ""
        txt_email_cliente.Text = ""
        txt_telefono_cliente.Text = ""
        txt_celular.Text = ""
        txt_fax.Text = ""
        txt_web.Text = ""
        txt_email_cliente.Text = "example@hotmail.com"
        gbo_a.Enabled = False
        gbo_b.Enabled = False


    End Sub

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


    Private Sub cbo_categoria_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_categoria_cliente.SelectedIndexChanged
        If (cbo_categoria_cliente.Text = "Empresa") Then
            gbo_a.Enabled = True
        Else
            gbo_a.Enabled = False
            gbo_b.Enabled = True
        End If
    End Sub

    Private Sub txt_web_TextChanged(sender As Object, e As EventArgs) Handles txt_web.TextChanged

    End Sub

    Private Sub txt_nombre_empresa_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_empresa.TextChanged

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

    Private Sub txt_email_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_email_cliente.TextChanged

    End Sub

    Private Sub txt_fax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fax.KeyPress

    End Sub

    Private Sub txt_fax_TextChanged(sender As Object, e As EventArgs) Handles txt_fax.TextChanged

    End Sub
End Class