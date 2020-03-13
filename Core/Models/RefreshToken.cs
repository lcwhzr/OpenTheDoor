using System;

namespace OpenTheDoor.Models
{
    class RefreshToken : IEntity
    {
        private string Identifier;
        private DateTime Expiry;
        private AccesToken AccesToken;
        private bool Revoked = false;

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public RefreshToken(string identifier, DateTime expiry, AccesToken accesToken)
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
