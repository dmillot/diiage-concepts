namespace DIContainer.DependencyInjection
{
    public interface IContainer
    {
        public void AddSingleton<TService>();
        public void AddSingleton<TService>(TService implementation);
        public void AddSingleton<TService, TImplementation>() where TImplementation : TService;
        
        public void AddTransient<TService>();
        public void AddTransient<TService>(TService implementation);
        public void AddTransient<TService, TImplementation>() where TImplementation : TService;
    }
}