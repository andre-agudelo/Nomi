using System.Net.Mail;
using Entity;
using System;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;

        public Email()
        {
            smtp = new SmtpClient();
        }

        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("mremix04@gmail.com",
            "manchestercity1");

        }
        private void ConfigurarEmail(Empleado empleado)
        {
            email = new MailMessage();
            email.To.Add(empleado.Email);
            email.From = new MailAddress("anyambolano@unicesar.edu.co");
            email.Subject = "Andrés Camilo Agudelo Naranjo, registro"
            + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {empleado.PrimerNombre }</b> <br " +
            $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;

            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmail(Empleado empleado)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(empleado);
                smtp.Send(email);

                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        private void ConfigurarEmailDocumento()
        {
            string path = @"C:/Users/andre/OneDrive/Escritorio/DocumentoPDF.pdf";
            email = new MailMessage();
            email.To.Add("ceduerose02@gmail.com");
            email.From = new MailAddress("mremix04@gmail.com");
            email.Subject = "Andrés Camilo Agudelo Naranjo, PDF"
            + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sra Annya</b> <br " +
            $" > ";
            email.Attachments.Add(new Attachment(path));
            email.IsBodyHtml = true;

            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmailDocumento()
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmailDocumento();
                smtp.Send(email);

                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }
    }
}