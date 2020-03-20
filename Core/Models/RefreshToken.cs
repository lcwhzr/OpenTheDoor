using System;

namespace Core.Models
{
    public class RefreshToken : Entity
    {
        public string Identifier { get; internal set; }
        public DateTime Expiry { get; internal set; }
        public AccessToken AccessToken { get; internal set; }
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
