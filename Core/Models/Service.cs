using System;

namespace Core.Models
{
    public class Service : Entity
    {
        public string DomainName { get; internal set; }
        public string ApiKey { get; internal set; }
        public Scope Scope { get; internal set; }
        private bool Active = true;

        public Service() { }

        public Service(string domainName, string apiKey): base()
        {
            DomainName = domainName;
            ApiKey = apiKey;
        }

        public string GetDomainName()
        {
            return DomainName;
        }

        public string GetApiKey()
        {
            return ApiKey;
        }

        public Scope GetScope()
        {
            return Scope;
        }

        public void SetScope(Scope scope)
        {
            Scope = scope;
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