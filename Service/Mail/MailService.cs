using Application.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Email;
using Domain.Settings;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;

namespace Service.Mail
{
    public class MailService:IMailService
    {

        public MailSetting _mailSetting { get; }


        public MailService(IOptions<MailSetting> mailSetting)
        {
            _mailSetting = mailSetting.Value;
        }

        public Task SendEmailAsync(SendEmailRequest request)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(SendEmailRequest request)
        {

            InternetAddressList list = new InternetAddressList();

            foreach (var address in request.To)
            {
                list.Add(MailboxAddress.Parse(address));
            }

            // create message
            var mail = new MimeMessage();

            // create message
            mail.From.Add(MailboxAddress.Parse(_mailSetting.Sender));
            mail.To.AddRange(list);
            mail.Subject = request.Subject;
            mail.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            // send email
            SmtpClient smtp = new SmtpClient();
            smtp.Connect(_mailSetting.SmtpHost, _mailSetting.SmtpPort, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSetting.SmtpUser, _mailSetting.SmtpPass);
            smtp.Send(mail);
            smtp.Disconnect(true);
        }
    }
}
