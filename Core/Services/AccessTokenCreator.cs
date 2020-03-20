using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Exceptions;
using Core.Factories;
using Core.Managers;
using Core.Models;

namespace Core.Services
{
    public class AccessTokenCreator
    {
        private AccessTokenFactory _accessTokenFactory;
        private AccessTokensManager _accessTokensManager;
        private ScopesManager _scopesManager;
        private ServicesManager _servicesManager;

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

        public ScopesManager ScopesManager
        {
            set
            {
                _scopesManager = value;
            }
        }

        public ServicesManager ServicesManager
        {
            set
            {
                _servicesManager = value;
            }
        }

        public async Task<AccessToken> Create(string userIdentifier, string userEmail, string serviceId, List<int> scopeIds)
        {
            List<Scope> scopes;
            Service service;
            
            try
            {
                scopes = await _scopesManager.GetScopesByIds(scopeIds);
            }
            catch (InvalidScopeServiceException exception)
            {
                throw exception;
            }

            try
            {
                service = await _servicesManager.GetServiceById(serviceId);
            }
            catch (ServiceNotFoundException exception)
            {
                throw exception;
            }

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
