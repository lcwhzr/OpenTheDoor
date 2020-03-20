using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.SSO;

namespace Core.Managers
{
    public class ServicesManager
    {
        private Repository<Service> serviceRepository;

        public ServicesManager()
        {
        }

        public void AddService(Service service)
        {
            serviceRepository.InsertAsync(service);
            serviceRepository.Save();
        }

        public async Task<List<Service>> GetServicesAsync()
        {
            List<Service> services = await serviceRepository.GetAllAsync();
            serviceRepository.Save();

            return services;
        }

        public void DeleteServiceAsync(object id)
        {
              serviceRepository.DeleteAsync(id);
              serviceRepository.Save();
        }

        public async Task<Service> GetServiceById(object id)
        {
            Service service =  await serviceRepository.GetById(id);
            serviceRepository.Save();

            return service;
        }
    }
}
