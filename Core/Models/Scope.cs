using System;

namespace Core.Models
{
    public class Scope : Entity
    {
        public string Key { get; }

        public Scope() { }

        public Scope(string scopeKey): base()
        {
            Key = scopeKey;
        }
    }
}
