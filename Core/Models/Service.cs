using System;

namespace Core.Models
{
    public class Service : Entity
    {
        public string DomainName { get; }
        public string ApiKey { get; }
        public Scope Scope { get; internal set; }
        public bool Active { get; internal set; }

        public Service() { }

        public Service(string domainName, string apiKey, Scope scope = null) : base()
        {
            DomainName = domainName;
            ApiKey = apiKey;
            Scope = scope;
        }
    }
}