using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class AccesToken : Entity
    {
        private string Identifier;
        private DateTime Expiry;
        private string UserIdentifier;
        private Service Service;
        private List<Scope> Scopes;
        private bool Revoked = false;

        public AccesToken() { }

        public AccesToken(
            string identifier,
            DateTime expiry,
            string userIdentifier,
            Service service,
            List<Scope> scopes
        ): base()
        {
            Identifier = identifier;
            Expiry = expiry;
            UserIdentifier = userIdentifier;
            Service = service;
            Scopes = scopes;
        }

        public string GetIdentifier()
        {
            return Identifier;
        }

        public DateTime GetExpiry()
        {
            return Expiry;
        }

        public string GetUserIdentifier()
        {
            return UserIdentifier;
        }

        public Service GetService()
        {
            return Service;
        }

        public List<Scope> GetScopes()
        {
            return Scopes;
        }

        public bool IsRevoked()
        {
            return Revoked;
        }

        public void Revoke()
        {
            Revoked = true;
        }
    }
}
