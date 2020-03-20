using System;
using Core.Models;

namespace Core.Factories
{
    public class ServiceFactory
    {
        public Service CreateService(string domainName, Scope scope = null)
        {
            Service service = new Service(domainName, Guid.NewGuid().ToString());

            if (null != scope)
            {
                service.SetScope(scope);
            }

            return service;
        }
    }
}
