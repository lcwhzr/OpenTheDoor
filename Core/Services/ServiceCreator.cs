using Core.Exceptions;
using Core.Factories;
using Core.Managers;
using Core.Models;

namespace Core.Services
{
    public class ServiceCreator
    {
        private ServiceFactory _serviceFactory;
        private ScopesManager _scopesManager;
        private ServicesManager _servicesManager;

        public ServiceFactory ServiceFactory
        {
            set
            {
                _serviceFactory = value;
            }
        }

        //public ScopesManager ScopeManager
        //{
        //    set
        //    {
        //        //_scopesManager = value;
        //        _scopesManager = new ScopesManager();
        //    }
        //}

        public ServicesManager ServiceManager
        {
            set
            {
                _servicesManager = value;
            }
        }

        public Service Create(string serviceDomainName, string serviceScopeKey)
        {
            try
            {
                ScopeKeyService.KeyInScopeKeys(serviceScopeKey);
            }
            catch (InvalidScopeServiceException exception)
            {
                throw exception;
            }

            Scope scope = new Scope(serviceScopeKey);
            try
            {
                //_scopesManager.AddScope(scope);
                _scopesManager.AddScope(scope);

            }
            catch (System.Exception)
            {

                throw;
            }
            
            Service service = _serviceFactory.Create(serviceDomainName, scope);

            _servicesManager.AddService(service);

            return service;
        }
    }
}
