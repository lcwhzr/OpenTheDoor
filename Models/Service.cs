using System;
using System.Collections.Generic;

namespace OpenTheDoor.Models
{
    class Service
    {
        private string Name;
        private string ApiKey;
        private Boolean Active;
        private List<Scope> Scopes;

        public Service(string clientName, string apiKey)
        {
            Name = clientName;
            ApiKey = apiKey;
            Active = true;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetApiKey()
        {
            return ApiKey;
        }

        public Boolean IsActive()
        {
            return Active;
        }

        public void Desactive()
        {
            Active = false;
        }

        public List<Scope> GetScopes()
        {
            return Scopes;
        }
    }
}
