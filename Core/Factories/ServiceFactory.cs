using System;
using Core.Models;

namespace Core.Factories
{
    public class ServiceFactory
    {
        public Service Create(string domainName, Scope scope = null)
        {
            return new Service(domainName, Guid.NewGuid().ToString(), scope);
        }
    }
}
