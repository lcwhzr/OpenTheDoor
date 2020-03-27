using System;
using Core.Exceptions;
using Core.Managers;
using Core.Models;
using Core.SSO;
using Newtonsoft.Json;

namespace Core.Services
{
    public class AccessTokenVerifier
    {
        private JWTService _jwtService;
        private AccessTokensManager _accessTokensManager;

        public JWTService JWTService
        {
            set
            {
                _jwtService = value;
            }
        }

        public AccessTokensManager AccessTokensManager
        {
            set
            {
                _accessTokensManager = value;
            }
        }

        public AccessToken Verify(string token)
        {
            string tokenDecoded;

            try
            {
                tokenDecoded = _jwtService.JWTDecode(token);
            }
            catch (Exception exception)
            {
                throw new InvalidJWTException(exception);
            }

            dynamic tokenProperties = JsonConvert.DeserializeObject(tokenDecoded);

            try
            {
                return _accessTokensManager.GetAccessTokenById(tokenProperties.identifier);
            }
            catch (Exception exception)
            {
                throw new AccessTokenNotFoundException(tokenProperties.identifier);
            }
        }
    }
}
