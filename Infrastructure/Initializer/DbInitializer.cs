using System;
using System.Linq;
using Application.Enums;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Initializer
{
    public class DbInitializer:IDbInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            // Role
            if (!_roleManager.RoleExistsAsync(Roles.Admin.ToString()).Result)
            {
                var role = new IdentityRole()
                {
                    Name = Roles.Admin.ToString(),
                };
                _roleManager.CreateAsync(role).GetAwaiter().GetResult();
            }

            if (!_roleManager.RoleExistsAsync(Roles.HeadOfDepartment.ToString()).Result)
            {
                var role = new IdentityRole()
                {
                    Name = Roles.HeadOfDepartment.ToString(),
                };
                _roleManager.CreateAsync(role).GetAwaiter().GetResult();
            }
            if (!_roleManager.RoleExistsAsync(Roles.Member.ToString()).Result)
            {
                var role = new IdentityRole()
                {
                    Name = Roles.Member.ToString(),
                };
                _roleManager.CreateAsync(role).GetAwaiter().GetResult();
            }

            

            if (_userManager.FindByEmailAsync("admin@gmail.com").Result == null)
            {
                var user = new User()
                {
                    Email = "admin@gmail.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    EmailConfirmed = true,
                    UserName = "admin",

                };

                IdentityResult result = _userManager.CreateAsync(user, "Admin@123").GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, Roles.Admin.ToString()).GetAwaiter().GetResult();

                }
            }

            if (_userManager.FindByEmailAsync("HeadOfDepartment@gmail.com").Result == null)
            {
                var user = new User()
                {
                    Email = "HeadOfDepartment@gmail.com",
                    FirstName = "Head",
                    LastName = "Department",
                    EmailConfirmed = true,
                    UserName = "HeadOfDepartment@gmail.com",
                };
                IdentityResult result = _userManager.CreateAsync(user, "Head@123").GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, Roles.HeadOfDepartment.ToString()).GetAwaiter().GetResult();
                }
            }
            if (_userManager.FindByEmailAsync("Member@gmail.com").Result == null)
            {
                var user = new User()
                {
                    Email = "Member@gmail.com",
                    FirstName = "Member",
                    LastName = "Member",
                    EmailConfirmed = true,
                    UserName = "Member@gmail.com",
                };
                IdentityResult result = _userManager.CreateAsync(user, "Member@123").GetAwaiter().GetResult();
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, Roles.Member.ToString()).GetAwaiter().GetResult();
                }
            }

        }


    }
}