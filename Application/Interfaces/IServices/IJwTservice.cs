using System.Threading.Tasks;
using Application.Models;
using Domain.Entities;

namespace Application.Interfaces.IServices
{
    public interface IJwTservice
    {
        Task<string> RegisterAsync(Register model);
        Task<Authentication> GetTokenAsync(Login model);
        Task<Authentication> RefreshTokenAsync(string token);
        bool RevokeToken(string token);
        User GetById(string id);
    }
}