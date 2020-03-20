using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenTheDoor.Models;
using OpenTheDoor.SSO;

namespace Core.Managers
{
    public class AccesTokensManager
    {

        private Repository<AccesToken> accesTokenRepository;
        public AccesTokensManager()
        {
        }



        void AddAccesToken(AccesToken accesToken)
        {
            accesTokenRepository.InsertAsync(accesToken);
            accesTokenRepository.Save();



        }

        async Task<List<AccesToken>> GetAccesTokensAsync()
        {
            List<AccesToken> accesTokens = await accesTokenRepository.GetAllAsync();
            accesTokenRepository.Save();
            return accesTokens;

        }

        void DeleteAccesTokenAsync(object id)
        {
            accesTokenRepository.DeleteAsync(id);
            accesTokenRepository.Save();

        }



        async Task<AccesToken> GetAccesTokenById(object id)
        {
            AccesToken accesToken = await accesTokenRepository.GetById(id);
            accesTokenRepository.Save();
            return accesToken;

        }
    }

}

    

