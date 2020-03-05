namespace OpenTheDoor.Models
{
    class Scope
    {
        private string ScopeName;

        public Scope(string scope)
        {
            ScopeName = scope;
        }

        public string GetScopeName()
        {
            return ScopeName;
        }
    }
}
