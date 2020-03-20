using System;

namespace OpenTheDoor.Core.Models
{
    public class RefreshToken : Entity
    {
        private string Identifier;
        private DateTime Expiry;
        private AccesToken AccesToken;
        private bool Revoked = false;

        public RefreshToken(
            string identifier,
            DateTime expiry,
            AccesToken accesToken
        ): base()
        {
            Identifier = identifier;
            Expiry = expiry;
            AccesToken = accesToken;
        }

        public string GetIdentifier()
        {
            return Identifier;
        }

        public DateTime GetExpiry()
        {
            return Expiry;
        }

        public AccesToken GetAccessToken()
        {
            return AccesToken;
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
