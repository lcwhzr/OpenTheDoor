//using Jose;
using System;
using System.Collections.Generic;


namespace OpenTheDoor.Models
{
    class AccesToken : Entity
    {

        private string Identifier;
        private DateTime Expiry;
        private string UserIdentifier;
        private Service Service;
        private List<Scope> Scopes;
        private bool Revoked = false;

        public AccesToken(
            string identifier,
            DateTime expiry,
            string userIdentifier,
            Service service,
            List<Scope> scopes
        ): base()
        {
            /*
                var payload = new Dictionary<string, object>()
                {
                    { "sub", "mr.x@contoso.com" },
                    { "exp", 1300819380 }
                };

                string token = JWT.Encode(payload, null, JwsAlgorithm.none);
             
             
             */
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
