using System;
using System.Collections.Generic;
using System.Linq;
using DIContainer.Exceptions;

namespace DIContainer.DependencyInjection
{
    public class DiContainer
    {
        private readonly Dictionary<Type, ServiceDescriptor> _registeredServices;

        public DiContainer(IEnumerable<ServiceDescriptor> serviceDescriptors)
        {
            _registeredServices = new Dictionary<Type, ServiceDescriptor>();
            foreach (var service in serviceDescriptors.Where(service => !_registeredServices.ContainsKey(service.ServiceType)))
            {
                _registeredServices.Add(service.ServiceType, service);
            }
        }

        private void CheckServiceTypeRegistered(Type serviceType)
        {
            if (!_registeredServices.ContainsKey(serviceType))
            {
                throw new ServiceNotRegisteredException($"Service of type {serviceType.Name} isn't registered.");
            }
        }

        private static void CheckTypeIsNotAbstractOrInterface(Type type)
        {
            if (type.IsAbstract || type.IsInterface)
            {
                throw new InstancingAbstractOrInterfaceException();
            }
        }

        private object[] ResolveConstructorParameters(Type type)
        {
            var constructorInfo = type.GetConstructors().First();
            return constructorInfo.GetParameters().Select(x => GetService(x.ParameterType)).ToArray();
        }

        private static object GetOrCreateSingleton(ServiceDescriptor serviceDescriptor, Type type, object[] resolvedParameters)
        {
            if (serviceDescriptor.Implementation != null) return serviceDescriptor.Implementation;
            var implementation = Activator.CreateInstance(type, resolvedParameters);
            serviceDescriptor.Implementation = implementation;

            return serviceDescriptor.Implementation;
        }

        private static object CreateInstanceBasedOnLifecycle(ServiceDescriptor serviceDescriptor, Type type, object[] resolvedParameters)
        {
            return serviceDescriptor.Lifetime switch
            {
                ServiceLifetimeEnum.Transient => Activator.CreateInstance(type, resolvedParameters),
                ServiceLifetimeEnum.Singleton => GetOrCreateSingleton(serviceDescriptor, type, resolvedParameters),
                ServiceLifetimeEnum.Scoped => null,
                _ => throw new MissingLifecycleException()
            };
        }

        private object GetService(Type serviceType)
        {
            CheckServiceTypeRegistered(serviceType);
            var serviceDescriptor = _registeredServices[serviceType];
            var actualType = serviceDescriptor.ImplementationType ?? serviceDescriptor.ServiceType;
            CheckTypeIsNotAbstractOrInterface(actualType);
            var parameters = ResolveConstructorParameters(actualType);

            return CreateInstanceBasedOnLifecycle(serviceDescriptor, actualType, parameters);
        }
        
        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }
    }
}