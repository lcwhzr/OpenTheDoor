using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.SSO;

namespace Core.Managers
{
    public class AccesTokensManager
    {
        private Repository<AccesToken> accesTokenRepository;

        public AccesTokensManager()
        {
        }

        public void AddAccesToken(AccesToken accesToken)
        {
            accesTokenRepository.InsertAsync(accesToken);
            accesTokenRepository.Save();
        }

        public async Task<List<AccesToken>> GetAccesTokensAsync()
        {
            List<AccesToken> accesTokens = await accesTokenRepository.GetAllAsync();
            accesTokenRepository.Save();

            return accesTokens;
        }

        public void DeleteAccesTokenAsync(object id)
        {
            accesTokenRepository.DeleteAsync(id);
            accesTokenRepository.Save();
        }

        public async Task<AccesToken> GetAccesTokenById(object id)
        {
            AccesToken accesToken = await accesTokenRepository.GetById(id);
            accesTokenRepository.Save();

            return accesToken;
        }
    }
}

    

