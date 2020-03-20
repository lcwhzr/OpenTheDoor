using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenTheDoor.Models;
using OpenTheDoor.SSO;

namespace Core.Managers
{
    public class RefreshTokenManager
    {

        private Repository<RefreshToken> refreshTokenRepository;
        public RefreshTokenManager()
        {
        }

        void AddRefreshToken(RefreshToken refreshToken)
        {
            refreshTokenRepository.InsertAsync(refreshToken);
            refreshTokenRepository.Save();



        }

        async Task<List<RefreshToken>> GetRefreshTokensAsync()
        {
            List<RefreshToken> refreshTokens = await refreshTokenRepository.GetAllAsync();
            refreshTokenRepository.Save();
            return refreshTokens;

        }

        void DeleterefreshTokenAsync(object id)
        {
            refreshTokenRepository.DeleteAsync(id);
            refreshTokenRepository.Save();

        }



        async Task<RefreshToken> GetrefreshTokenById(object id)
        {
            RefreshToken refreshToken = await refreshTokenRepository.GetById(id);
            refreshTokenRepository.Save();
            return refreshToken;

        }
    }
}

