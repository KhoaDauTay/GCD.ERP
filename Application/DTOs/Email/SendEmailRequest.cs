using System.Collections.Generic;

namespace Application.DTOs.Email
{
    public class SendEmailRequest
    {
        
        public string From { get; set; }
        public List<string> To { get; set; }
        public string Subject { get; set; }
        public  string Body { get; set; }
        
    }
}