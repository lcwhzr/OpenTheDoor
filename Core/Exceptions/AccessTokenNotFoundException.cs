using System;

namespace Core.Exceptions
{
    [Serializable]
    class AccessTokenNotFoundException : Exception
    {
        public AccessTokenNotFoundException(int accessTokenId)
            : base(String.Format("Access Token Not Found With This ID: {0}", accessTokenId))
        {
        }
    }
}
