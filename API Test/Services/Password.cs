using API_Test.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Services
{
    public class Password
    {
        PasswordHasher<ApplicationUser> ph;
        public Password()
        {
            ph = new PasswordHasher<ApplicationUser>();
        }

        public bool ValidatePassword(ApplicationUser user, string hash,string pass)
        {
             
            //var password = "h9GPEQis!tZ2Ga5";
            var Verify = ph.VerifyHashedPassword(user, hash, pass);

            return Verify == PasswordVerificationResult.Success;
        }

    }
}
