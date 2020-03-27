using System;

namespace Core.Exceptions
{
    [Serializable]
    class InvalidJWTException : Exception
    {
        public InvalidJWTException(Exception exception)
            : base(exception.Message)
        {
        }
    }
}
