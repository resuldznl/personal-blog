using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PersonalBlog.UI.EmailControl
{
    public class Email : IEmail
    {
        private readonly IConfiguration _configuration;

        public Email(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMail()
        {
            string emailaddress = _configuration["EmailInfo:MailAddress"];
            string emailpassword = _configuration["EmailInfo:MailPassword"];
            MailMessage msg = new MailMessage();
            msg.Subject = "Yeni İletişim";
            msg.From = new MailAddress(emailaddress, "Personal Blog");
            msg.To.Add(new MailAddress(emailaddress, "Personal Blog"));
            msg.IsBodyHtml = true;
            msg.Body = "Yeni İletişim Bulunuyor";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential AccountInfo = new NetworkCredential(emailaddress, emailpassword);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = AccountInfo;
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(msg);
        }
    }
}
