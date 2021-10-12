using System.Threading.Tasks;
using Application.Enums;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class RoleController : Controller
    {
        // GET
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        
        
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Role()
        {
            var data = await _roleService.GetAllAsync();
            return Ok(data);
        }
    }
}