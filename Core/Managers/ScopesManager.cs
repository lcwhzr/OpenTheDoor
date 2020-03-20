using System.Collections.Generic;
using System.Threading.Tasks;
using OpenTheDoor.Core.Models;
using OpenTheDoor.Core.SSO;

namespace OpenTheDoor.Core.Managers
{
    public class ScopesManager
    {
        private Repository<Scope> scopeRepository;

        public ScopesManager()
        {
        }

        public void AddScope(Scope scope)
        {
            scopeRepository.InsertAsync(scope);
            scopeRepository.Save();
        }

        public async Task<List<Scope>> GetSScopsAsync()
        {
            List<Scope> scops = await scopeRepository.GetAllAsync();
            scopeRepository.Save();

            return scops;
        }

        public void DeleteServiceAsync(object id)
        {
            scopeRepository.DeleteAsync(id);
            scopeRepository.Save();
        }

        public async Task<Scope> GetServiceById(object id)
        {
            Scope scope = await scopeRepository.GetById(id);
            scopeRepository.Save();

            return scope;
        }
    }
}
