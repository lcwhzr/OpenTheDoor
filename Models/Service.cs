namespace OpenTheDoor.Models
{
    class Service
    {
        private string DomainName;
        private string ApiKey;
        private Scope Scope;
        private bool Active = true;

        public Service(string domainName, string apiKey)
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
