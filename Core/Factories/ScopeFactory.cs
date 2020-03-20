using OpenTheDoor.Core.Models;

namespace OpenTheDoor.Core.Factories
{
    public class ScopeFactory
    {
        public Scope CreateScope(string scopeKey)
        {
            

            return new Scope(scopeKey);
        }
    }
}
