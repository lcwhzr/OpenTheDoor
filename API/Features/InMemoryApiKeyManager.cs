using API.Features;
using API.Interfaces;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.NewFolder
{
    public class InMemoryApiKeyManager : IApiKeyManager
    {
        private readonly IDictionary<string, ApiKey> _apiKeys;

        public InMemoryApiKeyManager()
        {
            var existingApiKeys = new List<ApiKey>
        {
            //new ApiKey(1, "Finance", "C5BFF7F0-B4DF-475E-A331-F737424F013C", new DateTime(2019, 01, 01),
            //    new List<string>
            //    {
            //        //Roles.Employee,
            //    }),
            //new ApiKey(2, "Reception", "5908D47C-85D3-4024-8C2B-6EC9464398AD", new DateTime(2019, 01, 01),
            //    new List<string>
            //    {
            //        //Roles.Employee
            //    }),
            new ApiKey(3, "authentication_access", "06795D9D-A770-44B9-9B27-03C6ABDB1BAE", new DateTime(2019, 01, 01),
                new List<string>
                {
                    Roles.authentication_access,
                }),
            new ApiKey(4, "all_access", "FA872702-8787-45DC-89F0-FC1BE900591B", new DateTime(2020, 03, 01),
                new List<string>
                {
                    Roles.all_access
                })
        };

            _apiKeys = existingApiKeys.ToDictionary(x => x.Key, x => x);
        }

        public Task<ApiKey> Execute(string providedApiKey)
        {
            _apiKeys.TryGetValue(providedApiKey, out var key);
            return Task.FromResult(key);
        }
    }
}
