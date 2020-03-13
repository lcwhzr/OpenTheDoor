using Microsoft.EntityFrameworkCore;
using OpenTheDoor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTheDoor.SSO
{
    class SSOContext : DbContext
    {
        public SSOContext(DbContextOptions<SSOContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.();
            //optionsBuilder.UseApplicationServiceProvider("Data Source=blog.db");
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}