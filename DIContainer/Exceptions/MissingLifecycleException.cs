using System;

namespace DIContainer.Exceptions
{
    public class MissingLifecycleException : Exception
    {
        public MissingLifecycleException(string message = "Lifecycle missing.")
            : base(message)
        {
        }
    }
}