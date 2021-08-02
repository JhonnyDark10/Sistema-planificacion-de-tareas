Imports System.Data.SqlClient

Public Class frm_añadir_modifica

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Dim sql As String

        If (txt_nombre.Text = "" Or txt_descripcion.Text = " ") Then
            MessageBox.Show("Debe llenar las campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                sql = "UPDATE materiales SET nombre ='" & txt_nombre.Text & "', descripcion = '" & txt_descripcion.Text & "',cantidad_m=" & nd_cantidad.Value & " WHERE id_materiales= " & frm_materiales.txt_materiales.Text

                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MessageBox.Show(" Recurso material Modificado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            End Try
        End If
       
    End Sub

    Private Sub frm_añadir_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_asige.Text = frm_materiales.txt_materiales.Text
        llenar_datos()
    End Sub
    Sub llenar_datos()
        Dim dr1 As SqlDataReader
        Dim sql As String
        Try

            sql = "SELECT id_materiales,nombre,cantidad_m,descripcion"
            sql = sql & " from materiales WHERE id_materiales =" & txt_asige.Text
            Dim com1 As New SqlCommand(Sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    txt_nombre.Text = dr1("nombre")
                    txt_descripcion.Text = dr1("descripcion")
                    nd_cantidad.Text = dr1("cantidad_m")
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
    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
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

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub
End Class