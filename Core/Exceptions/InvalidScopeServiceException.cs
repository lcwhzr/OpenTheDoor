using System;

namespace OpenTheDoor.Core.Exceptions
{
    [Serializable]
    class InvalidScopeServiceException : Exception
    {
        public InvalidScopeServiceException(string invalidScopeKey)
            : base(String.Format("Invalid Scope Key: {0}", invalidScopeKey))
        {
        }
    }
}
