using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using OpenTheDoor.Core.Models;

namespace OpenTheDoor.Core.SSO
{
    class SSOContext : DbContext
    {
        private string connectionString;
        public DbSet<Service> Services { get; set; }
        public DbSet<AccesToken> AccesToken { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Scope> Scope { get; set; }
        public DbSet<ScopeKeyService> ScopeKeyService { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options
            .UseSqlite(connectionString, providerOptions => providerOptions.CommandTimeout(60));
     
        }

        public SSOContext(string connectionString)
        {
            this.connectionString = connectionString;

        }
    }
}