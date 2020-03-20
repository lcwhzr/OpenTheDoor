using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using OpenTheDoor.Models;

namespace OpenTheDoor.SSO
{
    public class SSOContext : DbContext
    {

        public SSOContext(DbContextOptions<SSOContext> options) : base(options)
        {
        }
        public string connection;
        public DbSet<Service> Services { get; set; }
        public DbSet<AccesToken> AccesToken { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Scope> Scope { get; set; }
        public DbSet<ScopeKeyService> ScopeKeyService { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //options
            //.UseSqlite(connectionString, providerOptions => providerOptions.CommandTimeout(60));

            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = this.connection };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);

        }

        public SSOContext(string connection)
        {
            this.connection = connection;

        }
    }
}