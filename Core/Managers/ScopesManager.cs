using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Exceptions;
using Core.Models;
using Core.SSO;

namespace Core.Managers
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

        public async Task<List<Scope>> GetScopesAsync()
        {
            List<Scope> scopes = await scopeRepository.GetAllAsync();
            scopeRepository.Save();

            return scopes;
        }

        public void DeleteScopeAsync(object id)
        {
            scopeRepository.DeleteAsync(id);
            scopeRepository.Save();
        }

        public async Task<Scope> GetScopeById(object id)
        {
            Scope scope = await scopeRepository.GetById(id);
            scopeRepository.Save();

            return scope;
        }

        public async Task<List<Scope>> GetScopesByIds(List<int> scopesId)
        {
            List<Scope> scopes = new List<Scope>();

            foreach(int scopeId in scopesId)
            {
                Scope scope = await scopeRepository.GetById(scopeId);

                if (scope is null)
                {
                    throw new InvalidScopeServiceException();
                }

                scopeRepository.Save();
                scopes.Add(scope);
            }

            return scopes;
        }
    }
}