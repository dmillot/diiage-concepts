using System;

namespace DIContainer.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; }
        
        public Type ImplementationType { get; }

        public object Implementation { get; internal set; }

        public ServiceLifetimeEnum Lifetime { get; }
        
        public ServiceDescriptor(object implementation, ServiceLifetimeEnum lifetime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifetime;
        }
        
        public ServiceDescriptor(Type serviceType, ServiceLifetimeEnum lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
        }

        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetimeEnum lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
            ImplementationType = implementationType;
        }
    }
}