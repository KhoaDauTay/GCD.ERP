using System.Collections.Generic;

namespace Application.DTOs.Account
{
    public class CreateAccountRequest
    {
        public string Email { get; set; }
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public List<string> Roles { get; set; }
    }
}