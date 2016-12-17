using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace _04_Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            SmtpClient client = new SmtpClient();
            client.Host = appSettings["SMTPServer"];
            client.Port = Convert.ToInt32(appSettings["SMTPPort"]);
            client.EnableSsl = Convert.ToBoolean(appSettings["SMTPUseSsl"]);
            client.Credentials = new NetworkCredential(appSettings["SMTPUser"], appSettings["SMTPPassword"]);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(appSettings["SMTPUser"]);
            mail.To.Add(new MailAddress("to@example.com"));
            mail.Subject = "Subject";
            mail.Body = "Body";

            client.Send(mail);

            client.Dispose();
        }
    }
}
