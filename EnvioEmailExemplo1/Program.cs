using System;
using System.Net.Mail;

namespace EnvioEmailExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do envio de e-mail!");

            var para = "email_destinatario";
            var meuEmail = "meu_email";
            var senhaMeuEmail = "senha_meu_email";
            var porta = 587;
            var enderecoSMTP = "endereco_smtp";

            try
            {
                MailMessage mm = new MailMessage();
                mm.To.Add(para);
                mm.Subject = "Teste de Envio";
                mm.Body = "Teste de envio de e-mail por aplicação SMTP";
                mm.IsBodyHtml = true;
                mm.From = new MailAddress(meuEmail);

                SmtpClient smtp = new SmtpClient(enderecoSMTP);
                smtp.Port = porta;
                smtp.Credentials = new System.Net.NetworkCredential(meuEmail, senhaMeuEmail);

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
