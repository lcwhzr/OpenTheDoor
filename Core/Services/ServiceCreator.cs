﻿using Core.Exceptions;
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

            Service service = _serviceFactory.Create(serviceDomainName, scope);

            _servicesManager.AddService(service);

            return service;
        }
    }
}
