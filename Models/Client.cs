using System;

namespace OpenTheDoor.Models
{
    class Client
    {
        public String Name { get; }
        public String Identifier { get; }
        public String Secret { get; }
        public Array RedirectURIs { get; set; }
        public Array Grants { get; set; }
        public Array Scopes { get; set; }
        public Boolean Active { get; set; }

        public Client(string clientName, string identifierClient, string clientSecret)
        {
            Name = clientName;
            Identifier = identifierClient;
            Secret = clientSecret;
            Active = true;
        }

        public Boolean IsActive()
        {
            return Active;
        }
    }
}
