using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs.Account;
using Microsoft.AspNetCore.Http;

namespace Application.Interfaces.IServices
{
    public interface IAccountService
    {
        Task<int> CreateAccount(CreateAccountRequest request);
        
        Task<int> CreateAccountRange(List<CreateAccountRequest> requests);
        Task<int> CreateAccountByFile(IFormFile file);
        Task<List<CreateAccountRequest>> GetModelFromFile(IFormFile file);
    }
}