using API_Test.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Services
{
    public class Register
    {

        private readonly UserManager<IdentityUser> _userManager; 
        private readonly ILogger<Register> _logger;

        public Register(UserManager<IdentityUser> userManager , ILogger<Register> logger)
        {
            _userManager = userManager; 
            _logger = logger;
        }


        public async Task<bool> CreateAsync(string email, string firstName,string lastName, string PhoneNumber, string password)
        { 
                var user = new ApplicationUser
                {
                    UserName = email,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = PhoneNumber,
                    Role = "Individual Customer"
                };
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");


                    await _userManager.AddToRoleAsync(user, user.Role);
                return true;
                }
            return false;
            
        }

        internal async Task<bool> Create(string email, string firstName, string lastName, string PhoneNumber, string password)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = PhoneNumber,
                Role = "Individual Customer"
            };
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");


                await _userManager.AddToRoleAsync(user, user.Role);
                return true;
            }
            return false;
        }
    }
}
