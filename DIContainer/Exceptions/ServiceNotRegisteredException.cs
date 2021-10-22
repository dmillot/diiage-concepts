using System;

namespace DIContainer.Exceptions
{
    public class ServiceNotRegisteredException : Exception
    {
        public ServiceNotRegisteredException(string message)
            : base(message)
        {
        }
    }
}