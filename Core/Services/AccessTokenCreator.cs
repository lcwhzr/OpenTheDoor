using System.Collections.Generic;
using Core.Factories;
using Core.Managers;
using Core.Models;

namespace Core.Services
{
    public class AccessTokenCreator
    {
        private AccessTokenFactory _accessTokenFactory;
        private AccesTokensManager _accessTokensManager;

        public AccessTokenFactory AccessTokenFactory
        {
            set
            {
                _accessTokenFactory = value;
            }
        }

        public AccesTokensManager AccessTokensManager
        {
            set
            {
                _accessTokensManager = value;
            }
        }

        public AccesToken Create(string userIdentifier, string userEmail, Service service, List<Scope> scopes)
        {
            AccesToken accessToken = _accessTokenFactory.Create(
                userIdentifier,
                userEmail,
                service,
                scopes
            );

            _accessTokensManager.AddAccesToken(accessToken);

            return accessToken;
        }
    }
}
