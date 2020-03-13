namespace OpenTheDoor.Models
{
    class Scope
    {
        private string Key;

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
