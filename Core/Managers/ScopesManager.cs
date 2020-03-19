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

      

        void AddService(Scope scope)
        {
            scopeRepository.InsertAsync(scope);
            scopeRepository.Save();



        }

        async Task<List<Scope>> GetSScopsAsync()
        {
            List<Scope> scops = await scopeRepository.GetAllAsync();
            scopeRepository.Save();
            return scops;

        }

        void DeleteServiceAsync(object id)
        {
            scopeRepository.DeleteAsync(id);
            scopeRepository.Save();

        }



        async Task<Scope> GetServiceById(object id)
        {
            Scope scope = await scopeRepository.GetById(id);
            scopeRepository.Save();
            return scope;

        }
    }

}
