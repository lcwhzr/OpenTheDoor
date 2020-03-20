using OpenTheDoor.Core.Exceptions;
using OpenTheDoor.Core.Factories;
using OpenTheDoor.Core.Managers;
using OpenTheDoor.Core.Models;

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

        public ScopesManager ScopeManager
        {
            set
            {
                _scopesManager = value;
            }
        }

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

            _scopesManager.AddScope(scope);

			Service service = _serviceFactory.CreateService(serviceDomainName, scope);

            _servicesManager.AddService(service);

			return service;
        }
	}
}
