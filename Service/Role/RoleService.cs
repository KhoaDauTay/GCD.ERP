using Application.DTOs.Account;
using Application.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Email;
using Application.DTOs.Role;
using Application.Enums;
using Domain.Entities;
using ExcelDataReader;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Service.Role
{
    public class RoleService : IRoleService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
       
        // private readonly JWTSettings _jwtSettings;
        public RoleService(UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager, 
           
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            // _jwtSettings = jwtSettings.Value;
           
        }

        public async Task<List<RoleVm>> GetAllAsync()
        {
            var query = _context.Roles;
            var data = await query.Select(x => new RoleVm()
            {
                Id = x.Id,
                Description = x.Name,
            }).ToListAsync();
            return data;
        }
    }
}
