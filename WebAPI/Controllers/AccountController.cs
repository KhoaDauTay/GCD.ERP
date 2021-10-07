using System.Threading.Tasks;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
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
        public IActionResult Index()
        {
            return Ok();
        }
        
        [HttpPost("createaccountbyfile")]
        public async  Task<IActionResult> CreateAccountByFile(IFormFile file)
        {
            var result = await _accountService.CreateAccountByFile(file);
            return Ok();
        }
    }
}