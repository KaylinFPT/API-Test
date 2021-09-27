using API_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace API_Test.Data
{
    public class TruckContext : IdentityDbContext
    {

        public TruckContext(DbContextOptions<TruckContext> options)
           : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Transporter> Transporter { get; set; }

      
    }


}

