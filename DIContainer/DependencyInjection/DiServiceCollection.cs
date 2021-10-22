using System.Collections.Generic;

namespace DIContainer.DependencyInjection
{
    public class DiServiceCollection : IContainer
    {
        private readonly List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();

        #region Singleton

        public void AddSingleton<TService>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetimeEnum.Singleton));
        }
        
        public void AddSingleton<TService>(TService implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetimeEnum.Singleton));
        }
        
        public void AddSingleton<TService, TImplementation>() where TImplementation : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetimeEnum.Singleton));
        }
        #endregion

        #region Transient
        public void AddTransient<TService>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetimeEnum.Transient));
        }
        
        public void AddTransient<TService>(TService implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetimeEnum.Transient));
        }
        
        public void AddTransient<TService, TImplementation>() where TImplementation : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifetimeEnum.Transient));
        }
        #endregion

        public DiContainer GenerateContainer()
        {
            return new DiContainer(_serviceDescriptors);
        }
    }
}