using System;

namespace OpenTheDoor.Models
{
    public class Scope : Entity
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
