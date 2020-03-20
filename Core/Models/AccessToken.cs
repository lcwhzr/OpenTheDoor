using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class AccessToken : Entity
    {
        public string Identifier { get; internal set; }
        public DateTime Expiry { get; internal set; }
        public string UserIdentifier { get; internal set; }
        public Service Service { get; internal set; }
        public List<Scope> Scopes { get; internal set; }
        private bool Revoked = false;

        public AccessToken() { }

        public AccessToken(
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
