Imports System.Data.SqlClient
Public Class frm_modifica_empleado

    Private Sub frm_modifica_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        traer_datos_empleado()
        cargar_departamentos()
        cargar_estado_civil()
        cargar_comisiones()
    End Sub

    Sub traer_datos_empleado()



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



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class