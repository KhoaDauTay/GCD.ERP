using System;
using Application.Interfaces.IServices;
using Microsoft.Extensions.DependencyInjection;
using Service.Account;
using Service.Mail;

namespace Service
{
    
        public static class DependencyInjection
        {
            public static void AddService(this IServiceCollection services)
            
            {
                services.AddTransient<IMailService, MailService>();
                services.AddTransient<IAccountService, AccountService>();
                
            }
        }
    }
