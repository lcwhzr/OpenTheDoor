using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class AccessToken : Entity
    {
        public string Identifier { get; }
        public DateTime Expiry { get; }
        public string UserIdentifier { get; }
        public Service Service { get; }
        public List<Scope> Scopes { get; }
        public bool Revoked { get; }

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
            Revoked = false;
        }
    }
}
