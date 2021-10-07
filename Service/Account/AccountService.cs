using Application.DTOs.Account;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Account
{
    public class AccountService : IAccountService
    {
        public Task<int> CreateAccount(CreateAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAccountByFile(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAccountRange(List<CreateAccountRequest> requests)
        {
            throw new NotImplementedException();
        }

        public Task<List<CreateAccountRequest>> GetModelFromFile(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
