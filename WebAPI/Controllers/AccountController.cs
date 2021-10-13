using System.Threading.Tasks;
using Application.DTOs.Account;
using Application.Enums;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMailService _mailService;
        
        public AccountController(IAccountService accountService,
            IMailService mailService)
        {
            _accountService = accountService;
            _mailService = mailService;
        }

        
        [HttpPost("import-file")]
        [Consumes("multipart/form-data")]
        [Authorize(Roles="Admin")]
        public async  Task<IActionResult> CreateAccountByFile(IFormFile file)
        {
            var result = await _accountService.CreateAccountByFile(file);
            return Ok();
        }
        
        [HttpPost("account")]
        [Authorize(Roles = "Admin")]
        public async  Task<IActionResult> CreateAccount(CreateAccountRequest request)
        {
            var result = await _accountService.CreateAccount(request);
            return Ok();
        }
    }
}