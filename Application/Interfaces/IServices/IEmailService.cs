using System.Threading.Tasks;
using Application.DTOs.Email;

namespace Application.Interfaces.IServices
{
    public interface IMailService
    {
        Task SendEmailAsync(SendEmailRequest request);
        void SendEmail(SendEmailRequest request);
    }
}