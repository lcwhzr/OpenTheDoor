using System.Collections.Generic;
using Core.Factories;
using Core.Managers;
using Core.Models;

namespace Core.Services
{
    public class AccessTokenCreator
    {
        private AccessTokenFactory _accessTokenFactory;
        private AccessTokensManager _accessTokensManager;

        public AccessTokenFactory AccessTokenFactory
        {
            set
            {
                _accessTokenFactory = value;
            }
        }

        public AccessTokensManager AccessTokensManager
        {
            set
            {
                _accessTokensManager = value;
            }
        }

        public AccessToken Create(string userIdentifier, string userEmail, Service service, List<Scope> scopes)
        {
            AccessToken accessToken = _accessTokenFactory.Create(
                userIdentifier,
                userEmail,
                service,
                scopes
            );

            _accessTokensManager.AddAccessToken(accessToken);

            return accessToken;
        }
    }
}
