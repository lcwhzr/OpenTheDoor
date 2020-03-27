using System;

namespace Core.Models
{
    public class RefreshToken : Entity
    {
        public string Identifier { get; }
        public DateTime Expiry { get; }
        public AccessToken AccessToken { get; }
        public bool Revoked { get; }

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
            Revoked = false;
        }
    }
}
