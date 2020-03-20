using System;
using Core.Models;
using Core.Exceptions;

namespace Core.Factories
{
    class ServiceFactory
    {
        public Service CreateService(string domainName, Scope scope = null)
        {
            Service service = new Service(domainName, Guid.NewGuid().ToString());

            if (null != scope)
            {
                try
                {
                    ScopeKeyService.KeyInScopeKeys(scope);
                }
                catch(InvalidScopeServiceException exception)
                {
                    throw exception;
                }

                service.SetScope(scope);
            }

            return service;
        }
    }
}
