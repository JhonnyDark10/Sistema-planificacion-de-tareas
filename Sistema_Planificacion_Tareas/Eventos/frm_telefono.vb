Imports System
Imports System.IO.Ports
Imports System.Threading
Public Class frm_telefono



    Private Sub frm_telefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
    End Sub

    Sub GetSerialPortNames()
        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cboPuertos.Items.Add(sp)
        Next
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub


    Sub enviarSMS(ByVal numero As String, ByVal mensaje As String, ByVal puerto As String)
        Dim serialport As SerialPort
        Try
            serialport = New SerialPort()
            With serialport
                .PortName = puerto  ' Puerto de comunicaciones COM1, COM2…
                .BaudRate = 9600    ' velocidad del puerto
                .Parity = Parity.None   ' Paridad
                .StopBits = StopBits.One  ' Bit de para
                .DataBits = 8   ' Bits de datos
                If .IsOpen = False Then  ' Si el puerto no esta abierto
                    .Open() ' Abrir el puerto
                End If
                .Write("ATZ0" & vbCr)
                .WriteLine("AT+CMGF=1" & vbCr) ' Configurando envio de SMS modo texto
                Thread.Sleep(1000) ' Esperar 1 segundo
                .Write("AT+CMGS=" & Chr(34) & numero & Chr(34) & vbCr)  ' Numero al que se envia el SMS
                .Write(mensaje & Chr(26) & vbCr)
                Thread.Sleep(1000) ' Esperar 1 segundo
                .Close()
                MsgBox("Mensaje enviado")
            End With
        Catch Ex As IO.IOException
            Console.WriteLine(Ex.Message)
        End Try
    End Sub



    Private Sub bntEnviar_Click(sender As Object, e As EventArgs) Handles bntEnviar.Click
        enviarSMS(txtnumero.Text, txtmensaje.Text, cboPuertos.Text)
    End Sub
End Class