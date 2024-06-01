using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Prueba.Dto;
using Prueba.Models;

namespace Prueba.Controllers._mail
{
    public class MailController
    {
        public async void SendEmail(Paciente paciente)
        {
            try
            {
                string url = "https://api.mailersend.com/v1/email";
                string AuthToken = "mlsn.8b2536b0d00a573489f0eb333ff843771ccdbe23352ca27bee7a1d7eef3c5848";
                var email_message = new Email
                {
                    from = new From { Email = "info@trial-0r83ql3omdvlzwlj.mlsender.net"},
                    to = new[]
                    {
                        new To { Email = paciente.Correo }
                    },
                    sujeto = "HellofromMailerSend",
                    text = "Greetingsfromtheteam, yougotthismessagethrougthMailSender.",
                    html = "Greetingsfromtheteam, yougotthismessagethrougthMailSender."
                };

                string jsonBody = JsonSerializer.Serialize(email_message);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("ContentType", "application/json");

                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {AuthToken}");

                    StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if(response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Respuesta del servidor: ");
                        Console.WriteLine(responseBody);
                    }
                    else 
                    {
                        Console.WriteLine($"La solicitud falló con el error: {response.StatusCode}");
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
 
        internal void SendEmail()
        {
            SendEmail();
        }
    }
}