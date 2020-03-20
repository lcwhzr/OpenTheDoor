using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.SSO;

namespace Core.Managers
{
    public class RefreshTokenManager
    {
        private Repository<RefreshToken> refreshTokenRepository;

        public RefreshTokenManager()
        {
        }

        public void AddRefreshToken(RefreshToken refreshToken)
        {
            refreshTokenRepository.InsertAsync(refreshToken);
            refreshTokenRepository.Save();
        }

        public async Task<List<RefreshToken>> GetRefreshTokensAsync()
        {
            List<RefreshToken> refreshTokens = await refreshTokenRepository.GetAllAsync();
            refreshTokenRepository.Save();

            return refreshTokens;
        }

        public void DeleterefreshTokenAsync(object id)
        {
            refreshTokenRepository.DeleteAsync(id);
            refreshTokenRepository.Save();
        }

        public async Task<RefreshToken> GetrefreshTokenById(object id)
        {
            RefreshToken refreshToken = await refreshTokenRepository.GetById(id);
            refreshTokenRepository.Save();

            return refreshToken;
        }
    }
}

