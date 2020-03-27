using Core.Models;
using Core.SSO;
using System.Collections.Generic;

namespace Core.Factories
{
    public class AccessTokenFactory
    {
        private JWTService _jwtService;

        public JWTService JWTService
        {
            set
            {
                _jwtService = value;
            }
        }

        public AccessToken Create(string userIdentifier, string userEmail, Service service, List<Scope> scopes)
        {
            string token = _jwtService.JWTGenerate(userIdentifier, userEmail);

            return new AccessToken(
                token,
                System.DateTime.Now.Date.AddHours(1),
                userIdentifier,
                service,
                scopes
            );
        }
    }
}
