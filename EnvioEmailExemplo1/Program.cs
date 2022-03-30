using System;
using System.Net.Mail;

namespace EnvioEmailExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do envio de e-mail!");
            try
            {
                MailMessage mm = new MailMessage();
                mm.To.Add("meuemail@gmail.com");
                mm.Subject = "Teste de Envio";
                mm.Body = "Teste de envio de e-mail por aplicação SMTP";
                mm.IsBodyHtml = true;
                mm.From = new MailAddress("suaconta@seudominio.com.br");

                SmtpClient smtp = new SmtpClient("mail.seudominio.com.br");
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("suaconta@seudominio.com.br", "sua_senha");

                smtp.Send(mm);

                Console.WriteLine("Email enviado com sucesso!");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Ocorreu o seguinte erro ao enviar o e-mail:{error.Message}");
            }
        }
    }
}
