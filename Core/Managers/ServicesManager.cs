using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenTheDoor.Models;
using OpenTheDoor.SSO;

namespace Core.Managers
{
    public class ServicesManager
    {
        private Repository<Service> serviceRepository;
        public ServicesManager()
        {
            

        }

        void AddService(Service service)
        {
            serviceRepository.InsertAsync(service);
            serviceRepository.Save();



        }

        async Task<List<Service>> GetServicesAsync()
        {
            List<Service> services = await serviceRepository.GetAllAsync();
            serviceRepository.Save();
            return services;

        }

        void DeleteServiceAsync(object id)
        {
              serviceRepository.DeleteAsync(id);
              serviceRepository.Save();

        }

       

        async Task<Service> GetServiceById(object id)
        {
            Service service =  await serviceRepository.GetById(id);
            serviceRepository.Save();
            return service;

        }
    }

}
