using Application.DTOs.Email;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailRequestsController : ControllerBase
    {
        private readonly IMailService _mailService;

        public SendEmailRequestsController(IMailService mailService)
        {
            _mailService = mailService;
        }

        // POST api/<SendEmailRequestsController>
        [HttpPost]
        public IActionResult Post([FromBody] SendEmailRequest mail)
        {
            _mailService.SendEmail(mail);
            return Ok();
        }

     

      
    }
}
