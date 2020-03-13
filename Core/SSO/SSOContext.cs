using Microsoft.EntityFrameworkCore;
using OpenTheDoor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTheDoor.SSO
{
    class SSOContext : DbContext
    {
        public SSOContext()
        {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<AccesToken> AccesToken { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Scope> Scope { get; set; }
        public DbSet<ScopeKeyService> ScopeKeyService { get; set; }


    }
}