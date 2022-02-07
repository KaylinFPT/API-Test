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

        public DbSet<Exporter> Exporter { get; set; }

        public DbSet<Booking> Booking { get; set; }

        public DbSet<Warehouse> Warehouse { get; set; }

        public DbSet<API_Test.Models.Slots> Slots { get; set; }

        public DbSet<MarketTypes> MarketTypes { get; set; }



    }


}

