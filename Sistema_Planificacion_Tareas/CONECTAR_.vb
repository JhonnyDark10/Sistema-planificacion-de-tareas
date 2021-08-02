Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration

Module CONECTAR_
    Public mycon As New SqlConnection

    Function conectar_base() As Boolean
        conectar_base = False
        Try
            mycon.ConnectionString = "server=BARCELONA\JHONNY;database=Sistema_Planificacion;Integrated Security=True;"
            mycon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error en el Módulo de conexión")
        End Try
        conectar_base = True
        Return conectar_base
    End Function


    Sub main()

        If conectar_base() = False Then
            MsgBox(" No se pudo conectar con la Base de Datos")
        Else
            frm_principal.ShowDialog()
        End If
    End Sub
End Module
