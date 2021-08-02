Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class Acceso_Sistema
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Public valida_a As Integer
    Private Sub BTN_ACEPTAR_INICIO_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR_INICIO.Click
        valida_a = 0
        Dim ACCESO_C As Boolean
        Dim ACCESO_C1 As Boolean

        If (txt_usuario_acceso.Text = "" And txt_contraseña_acceso.Text = "") Then
            MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                sql = "SELECT * FROM seg_usuarios u INNER JOIN seg_perfil p ON u.per_id = p.per_id  WHERE p.per_nombre ='" & "admin" & "' and u.usu_estado = 'A'"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                If dr.HasRows Then
                    While dr.Read

                        If (dr("usu_usuario") = Trim(txt_usuario_acceso.Text) And dr("usu_clave") = Trim(txt_contraseña_acceso.Text)) Then
                            ACCESO_C = True
                            Exit While
                        Else
                            ACCESO_C = False
                        End If
                    End While
                End If
                dr.Close()

                If ACCESO_C = True Then
                    frm_principal.Opacity = 100%
                    frm_principal.Enabled = True
                    frm_principal.MainMenuStrip.Enabled = True
                    frm_principal.tss_usuario.Text = " Usuario:   " & txt_usuario_acceso.Text
                    frm_principal.tss_fecha.Text = "     Fecha:   " & DateTime.Now.ToString("dd/MM/yyyy")
                    permitir_todo()
                    MsgBox("Acceso Permitido Como Administrador", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Sistema")
                    valida_a = 1
                    Me.Close()
                    Exit Sub
                End If
            Catch ex As Exception
            End Try
        End If


        If (txt_usuario_acceso.Text = "1" And txt_contraseña_acceso.Text = "") Or (txt_usuario_acceso.Text = "") Or (txt_contraseña_acceso.Text = "") Then
            MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                sql = "SELECT * FROM seg_usuarios u INNER JOIN seg_perfil p ON u.per_id = p.per_id  WHERE p.per_nombre ='" & "planificador" & "' and u.usu_estado = 'A' "
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                If dr.HasRows Then
                    While dr.Read

                        If (dr("usu_usuario") = Trim(txt_usuario_acceso.Text) And dr("usu_clave") = Trim(txt_contraseña_acceso.Text)) Then
                            ACCESO_C = True
                            Exit While
                        Else
                            ACCESO_C = False
                        End If
                    End While
                End If
                dr.Close()

                If ACCESO_C = True Then
                    frm_principal.Opacity = 100%
                    frm_principal.Enabled = True
                    MsgBox("Acceso Permitido Como Planificador", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Sistema")
                    valida_a = 1
                    permitir_menu()
                    frm_principal.tss_usuario.Text = txt_usuario_acceso.Text
                    Me.Close()
                Else
                    '****************************
                    sql = "SELECT * FROM seg_usuarios u INNER JOIN seg_perfil p ON u.per_id = p.per_id  WHERE p.per_nombre ='" & "gerente" & "' and u.usu_estado = 'A'"
                    Dim com11 As New SqlCommand(sql, mycon)
                    dr = com11.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            If (dr("usu_usuario") = Trim(txt_usuario_acceso.Text) And dr("usu_clave") = Trim(txt_contraseña_acceso.Text)) Then
                                ACCESO_C1 = True
                                Exit While
                            Else
                                ACCESO_C1 = False
                            End If
                        End While
                    End If
                    dr.Close()
                    '****************************
                    If ACCESO_C1 Then
                        frm_principal.Opacity = 100%
                        frm_principal.Enabled = True
                        MsgBox("Acceso Permitido Como Gerente", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Sistema")
                        valida_a = 1
                        permitir_menu1()
                        frm_principal.tss_usuario.Text = txt_usuario_acceso.Text
                        Me.Close()
                    Else
                        MessageBox.Show("ERROR EN EL ACCESO DATOS ERRONES", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txt_usuario_acceso.Text = ""
                        txt_contraseña_acceso.Text = ""

                    End If

                End If
            Catch ex As Exception
                MsgBox("Error al conectar con la BD " & ex.Message)
            End Try

        End If
    End Sub


    Private Sub permitir_todo()
        frm_principal.CategoriasToolStripMenuItem.Visible = True
        frm_principal.ReportesToolStripMenuItem.Visible = True
        frm_principal.AdministraciónToolStripMenuItem.Visible = True
        frm_principal.DatosToolStripMenuItem.Visible = True
        frm_principal.ArchivoToolStripMenuItem.Visible = True
        frm_principal.VisualizaciónToolStripMenuItem.Visible = True
        frm_principal.HerramientasToolStripMenuItem.Visible = True
        frm_principal.AccionToolStripMenuItem.Visible = True
    End Sub

    Private Sub permitir_menu()
        frm_principal.CategoriasToolStripMenuItem.Visible = False
        frm_principal.ReportesToolStripMenuItem.Visible = False
        frm_principal.AdministraciónToolStripMenuItem.Visible = False

        frm_principal.DatosToolStripMenuItem.Visible = True
        frm_principal.ArchivoToolStripMenuItem.Visible = True
        frm_principal.VisualizaciónToolStripMenuItem.Visible = True
        frm_principal.HerramientasToolStripMenuItem.Visible = True
        frm_principal.AccionToolStripMenuItem.Visible = True

    End Sub

    Private Sub permitir_menu1()

        frm_principal.CategoriasToolStripMenuItem.Visible = False
        frm_principal.AdministraciónToolStripMenuItem.Visible = False
        frm_principal.DatosToolStripMenuItem.Visible = False
        frm_principal.AccionToolStripMenuItem.Visible = False
        frm_principal.ReportesToolStripMenuItem.Visible = True
        frm_principal.ArchivoToolStripMenuItem.Visible = True
        frm_principal.VisualizaciónToolStripMenuItem.Visible = True
        frm_principal.HerramientasToolStripMenuItem.Visible = True


    End Sub

    Private Sub BTN_CANCELAR_INICIO_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR_INICIO.Click
        frm_principal.Enabled = True
        Dim msg, title As String
        Dim response As MsgBoxResult
        msg = "Realmente desea salir del Sistema?"   'Define mensaje.
        title = "SISTEMA"  'Define título.
        response = MsgBox(msg, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, title)
        If response = MsgBoxResult.Yes Then
            valida_a = 1
            frm_principal.Close()
            Me.Close()
        End If

    End Sub

    Private Sub Acceso_Sistema_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If (valida_a = 1) Then

        Else
            Try
                Dim str_mensage, str_titulo As String
                str_mensage = "Realmente desea salir del Sistema?"
                str_titulo = "SISTEMA..."
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox(str_mensage, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo)
                If respuesta = MsgBoxResult.Yes Then
                    frm_principal.Close()

                    e.Cancel = False
                Else
                    e.Cancel = True
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        
    End Sub

    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_principal.Opacity = 85%
        frm_principal.Enabled = False
        frm_principal.Show()
        Me.txt_usuario_acceso.Focus()
    End Sub

 

    
End Class