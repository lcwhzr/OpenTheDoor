using System;

namespace Core.Models
{
    public class RefreshToken : Entity
    {
        private string Identifier;
        private DateTime Expiry;
        private AccessToken AccessToken;
        private bool Revoked = false;

        public RefreshToken() { }

        public RefreshToken(
            string identifier,
            DateTime expiry,
            AccessToken accessToken
        ): base()
        {
            Identifier = identifier;
            Expiry = expiry;
            AccessToken = accessToken;
        }

        public string GetIdentifier()
        {
            return Identifier;
        }

        public DateTime GetExpiry()
        {
            return Expiry;
        }

        public AccessToken GetAccessToken()
        {
            return AccessToken;
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
