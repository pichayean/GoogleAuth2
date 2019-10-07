using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GoogleAuth2.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("pichayeanyensiri@gmail.com", "Ld4t5555")
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress("pichayeanyensiri@gmail.com")
            };
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            return client.SendMailAsync(mailMessage);


            //var fromAddress = new MailAddress("pichayeanyensiri@gmail.com", "Hello message");
            //var toAddress = new MailAddress(email, email);
            //const string fromPassword = "Ld4t5555";

            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
            //};
            //await smtp.SendMailAsync(new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = message
            //});
        }


        //public Task SendEmailAsync(string email, string subject, string htmlMessage)
        //{
        //    var client = new SmtpClient("smtp.gmail.com", 587)
        //    {
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential("pichayeanyensiri@gmail.com", "Ld4t5555")
        //    };
        //    var mailMessage = new MailMessage
        //    {
        //        From = new MailAddress("account-security-noreply@yourdomain.com")
        //    };
        //    mailMessage.To.Add(email);
        //    mailMessage.Subject = subject;
        //    mailMessage.Body = htmlMessage;
        //    return client.SendMailAsync(mailMessage);
        //}
    }
}
