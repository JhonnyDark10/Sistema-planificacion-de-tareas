Public Class FormEnviarCorreo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient

        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential("jhonny_dark10@outlook.com", "barcelonasc1994")
        _SMTP.Host = "smtp-mail.outlook.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(Me.txtPara.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
        _Message.From = New System.Net.Mail.MailAddress("jhonny_dark10@outlook.com", "JHONNYDARK10", System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = Me.txtAsunto.Text.ToString 'Sujeto del e-mail
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = Me.txtMensaje.Text.ToString 'contenido del mail
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        _Message.IsBodyHtml = False

        'ENVIO
        Try
            _SMTP.Send(_Message)
            MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
            txtAsunto.Text = ""
            txtMensaje.Text = ""
            txtPara.Text = ""
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub FormEnviarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAsunto.Text = ""
        txtMensaje.Text = ""
        txtPara.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        frm_lista.ShowDialog()

    End Sub
End Class