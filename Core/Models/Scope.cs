using System;

namespace OpenTheDoor.Models
{
    class Scope : Entity
    {
        private string Key;

        public Scope(string scopeKey): base()
        {
            Key = scopeKey;
        }

        public string GetKey()
        {
            return Key;
        }
    }
}
