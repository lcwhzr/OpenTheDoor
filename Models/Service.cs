using System.Collections.Generic;

namespace OpenTheDoor.Models
{
    class Service
    {
        private string Name;
        private string ApiKey;
        private List<Scope> Scopes;
        private bool Active = true;

        public Service(string name, string apiKey)
        {
            Name = name;
            ApiKey = apiKey;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetApiKey()
        {
            return ApiKey;
        }

        public List<Scope> GetScopes()
        {
            return Scopes;
        }

        public void SetScopes(List<Scope> scopes)
        {
            Scopes = scopes;
        }

        public bool IsActive()
        {
            return Active;
        }

        public void SetActive(bool active)
        {
            Active = active;
        }
    }
}
