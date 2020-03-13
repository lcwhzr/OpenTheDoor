using Microsoft.EntityFrameworkCore;
using OpenTheDoor.Models;

namespace OpenTheDoor.SSO
{
    class SSOContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<AccesToken> AccesToken { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Scope> Scope { get; set; }
        public DbSet<ScopeKeyService> ScopeKeyService { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer();
        }

        public SSOContext()
        {

        }

      


    }
}