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
using Application.Enums;
using Domain.Entities;
using ExcelDataReader;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Service.Account
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMailService _mailService;


     
        // private readonly JWTSettings _jwtSettings;
        public AccountService(UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager, 
            // IOptions<JWTSettings> jwtSettings,
            IMailService mailService,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            // _jwtSettings = jwtSettings.Value;
            _mailService = mailService;
        }
        public async Task<int> CreateAccount(CreateAccountRequest request)
        {
            if (_userManager.FindByEmailAsync(request.Email).Result == null)
            {
                var user = new User()
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    UserName = request.Email,
                    EmailConfirmed = true,
                    NormalizedUserName = request.Email.ToUpper(),
                    NormalizedEmail = request.Email.ToUpper(),
                    PhoneNumberConfirmed = true,

                };

                var password = GenerateRandomPassword();
                IdentityResult createResult = await _userManager.CreateAsync(user, password);
                // var assignRoleResult = await _userManager.AddToRoleAsync(user, Roles.Basic.ToString());
                
                // Assign Role
                if (request.Roles == null)
                {
                    var assignRoleResult = await _userManager.AddToRoleAsync(user, Roles.Member.ToString());
                }
                else
                {
                    foreach (var role in request.Roles)
                    {
                        var assignRoleResult = await _userManager.AddToRoleAsync(user, role);
                    }
                }
                
                // Send Account
                var sendMailRequest = new SendEmailRequest()
                {

                    To = new List<string>() { user.Email },
                    Subject = "Account for Greenwich Club Developer",
                    Body = $@"<html>
                      <body>
                      <p>Dear {user.FullName},</p>
                      <p>Thank you for your application. You have been selected as a member of GCD.</p>
                      <p>Here is your account for GCD App.</p>
                      <ul>
                            <li>Username: {user.Email}</li>
                            <li>Password: {password}</li>
                      </ul>
                      <p>Sincerely,<br>GCD</br></p>
                      </body>
                      </html>
                     ",
                };
               await _mailService.SendEmailAsync(sendMailRequest);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> CreateAccountByFile(IFormFile file)
        {
            var requests = GetModelFromFile(file);
            var createResult = await CreateAccountRange(requests);
            return 1;
        }

        public async Task<int> CreateAccountRange(List<CreateAccountRequest> requests)
        {
            foreach (var request in requests)
            {
                if (request != null)
                {
                    await CreateAccount(request);
                }
                    
            }
            return 1;
        }

        public List<CreateAccountRequest> GetModelFromFile(IFormFile file)
        {
            var requests = new List<CreateAccountRequest>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
             using ( var reader = ExcelReaderFactory.CreateReader(file.OpenReadStream()))
            {
                do
                {
                    while (reader.Read())
                    {
                        var request = new CreateAccountRequest()
                        {
                            Email = reader.GetValue(0).ToString(),
                            StudentId = reader.GetValue(1).ToString(),
                            FullName= reader.GetValue(2).ToString(),
                        };
                        requests.Add(request);
                       
                    }
                } while (reader.NextResult());

               
            }

            requests.Remove(requests[0]);
            return requests;
        }

        public Task<int> AssignRoleAsync(string userId, string roleId)
        {
            throw new NotImplementedException();
        }

        private string GenerateRandomPassword()
        {
            var passwordOptions = new PasswordOptions()
            {
                RequiredLength = 8,
                RequiredUniqueChars = 4,
                RequireDigit = true,
                RequireLowercase = true,
                RequireNonAlphanumeric = true,
                RequireUppercase = true
            };

            string[] randomChars = new[] {
                "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
                "abcdefghijkmnopqrstuvwxyz",    // lowercase
                "0123456789",                   // digits
                "!@$?_-"                        // non-alphanumeric
            };

            Random random = new Random(Environment.TickCount);
            List<char> chars = new List<char>();

            if (passwordOptions.RequireUppercase)
                chars.Insert(random.Next(0, chars.Count), 
                    randomChars[0][random.Next(0, randomChars[0].Length)]);

            if (passwordOptions.RequireLowercase)
                chars.Insert(random.Next(0, chars.Count), 
                    randomChars[1][random.Next(0, randomChars[1].Length)]);

            if (passwordOptions.RequireDigit)
                chars.Insert(random.Next(0, chars.Count), 
                    randomChars[2][random.Next(0, randomChars[2].Length)]);

            if (passwordOptions.RequireNonAlphanumeric)
                chars.Insert(random.Next(0, chars.Count), 
                    randomChars[3][random.Next(0, randomChars[3].Length)]);

            for (int i = chars.Count; i < passwordOptions.RequiredLength
                                      || chars.Distinct().Count() < passwordOptions.RequiredUniqueChars; i++)
            {
                string rcs = randomChars[random.Next(0, randomChars.Length)];
                chars.Insert(random.Next(0, chars.Count), 
                    rcs[random.Next(0, rcs.Length)]);
            }

            return new string(chars.ToArray());


           
        }
    }
}
