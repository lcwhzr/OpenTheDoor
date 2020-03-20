using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenTheDoor.Models;
using OpenTheDoor.SSO;

namespace Core.Managers
{
    public class ScopesManager
    {
        private Repository<Scope> scopeRepository;
        public ScopesManager()
        {
        }

      

        void AddScope(Scope scope)
        {
            scopeRepository.InsertAsync(scope);
            scopeRepository.Save();



        }

        async Task<List<Scope>> GetScopsAsync()
        {
            List<Scope> scops = await scopeRepository.GetAllAsync();
            scopeRepository.Save();
            return scops;

        }

        void DeleteScopeAsync(object id)
        {
            scopeRepository.DeleteAsync(id);
            scopeRepository.Save();

        }



        async Task<Scope> GetScopeyId(object id)
        {
            Scope scope = await scopeRepository.GetById(id);
            scopeRepository.Save();
            return scope;

        }
    }

}
