using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.SSO;

namespace Core.Managers
{
    public class AccessTokensManager
    {
        private Repository<AccessToken> accessTokenRepository;

        public AccessTokensManager()
        {
        }

        public void AddAccessToken(AccessToken accessToken)
        {
            accessTokenRepository.InsertAsync(accessToken);
            accessTokenRepository.Save();
        }

        public async Task<List<AccessToken>> GetAccessTokensAsync()
        {
            List<AccessToken> accessTokens = await accessTokenRepository.GetAllAsync();
            accessTokenRepository.Save();

            return accessTokens;
        }

        public void DeleteAccessTokenAsync(object id)
        {
            accessTokenRepository.DeleteAsync(id);
            accessTokenRepository.Save();
        }

        public async Task<AccessToken> GetAccessTokenById(object id)
        {
            AccessToken accessToken = await accessTokenRepository.GetById(id);
            accessTokenRepository.Save();

            return accessToken;
        }
    }
}

    

