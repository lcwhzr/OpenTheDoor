using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.SSO;
using OpenTheDoor.SSO;

namespace Core.Managers
{
    public class ScopesManager
    {
        //private Repository<Scope> scopeRepository = new Repository<Scope>();
        private Repository<Scope> scopeRepository;

        public ScopesManager(SSOContext sSOContext)
        {
            scopeRepository = new Repository<Scope>(sSOContext);
        }

        public void AddScope(Scope scope)
        {
            scopeRepository.InsertAsync(scope);
            scopeRepository.Save();
        }

        public async Task<List<Scope>> GetScopsAsync()
        {
            List<Scope> scops = await scopeRepository.GetAllAsync();
            scopeRepository.Save();

            return scops;
        }

        public void DeleteScopeAsync(object id)
        {
            scopeRepository.DeleteAsync(id);
            scopeRepository.Save();
        }

        public async Task<Scope> GetScopeyId(object id)
        {
            Scope scope = await scopeRepository.GetById(id);
            scopeRepository.Save();

            return scope;
        }
    }
}