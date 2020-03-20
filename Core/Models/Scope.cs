using System;

namespace OpenTheDoor.Core.Models
{
    public class Scope : Entity
    {
        private string Key;

        public Scope() { }

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
