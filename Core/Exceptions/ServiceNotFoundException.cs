using System;

namespace Core.Exceptions
{
    [Serializable]
    class ServiceNotFoundException : Exception
    {
        public ServiceNotFoundException(int serviceId)
            : base(String.Format("Service Not Found With This ID: {0}", serviceId))
        {
        }
    }
}
