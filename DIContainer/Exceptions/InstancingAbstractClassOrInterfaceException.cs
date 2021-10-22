using System;

namespace DIContainer.Exceptions
{
    public class InstancingAbstractOrInterfaceException : Exception
    {
        public InstancingAbstractOrInterfaceException(string message = "Cannot instantiate abstract classes or interfaces.")
            : base(message)
        {
        }
    }
}