using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCityWeb.Models;

namespace SmartCityWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Location> Location { get; set; }
        public DbSet<Tree> Tree { get; set; }
        public DbSet<Sensor> Sensor { get; set; }
    }
}
