using System;
using Core.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace OpenTheDoor.SSO
{
    public class SSOContext : DbContext
    {
        public SSOContext()
        {
            Database.EnsureCreated();
        }

        public SSOContext(DbContextOptions<SSOContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<AccessToken> AccessToken { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Scope> Scope { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //options
            //.UseSqlite(connectionString, providerOptions => providerOptions.CommandTimeout(60));


            if (optionsBuilder.IsConfigured)

            {

                Console.WriteLine("ok");
            }

        }
    }
}