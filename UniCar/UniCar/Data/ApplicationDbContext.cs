using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniCar.Models;

namespace UniCar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UniCar.Models.Job> Job { get; set; }
        public DbSet<UniCar.Models.Application> Application { get; set; }
        public DbSet<UniCar.Models.WorkHistory> WorkHistory { get; set; }
    }
}
