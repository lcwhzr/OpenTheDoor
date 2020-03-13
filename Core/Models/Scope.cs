using System;

namespace OpenTheDoor.Models
{
    class Scope : IEntity
    {
        private string Key;

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public Scope(string scopeKey)
        {
            Key = scopeKey;
        }

        public string GetKey()
        {
            return Key;
        }
    }
}
