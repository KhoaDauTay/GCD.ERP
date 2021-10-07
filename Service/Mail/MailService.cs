using Application.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Email;

namespace Service.Mail
{
    public class MailService:IMailService
    {
        public Task SendEmailAsync(SendEmailRequest request)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(SendEmailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
