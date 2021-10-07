using System.Threading.Tasks;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
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

        
        [HttpPost("createaccountbyfile")]
        [Consumes("multipart/form-data")]
        public async  Task<IActionResult> CreateAccountByFile(IFormFile file)
        {
            var result = await _accountService.CreateAccountByFile(file);
            return Ok();
        }
    }
}