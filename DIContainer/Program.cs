using System;
using DIContainer.DependencyInjection;
using DIContainer.Services;

namespace DIContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new DiServiceCollection();
            
            services.AddSingleton<RandomGuidGenerator>(new RandomGuidGenerator());
            services.AddSingleton(new RandomGuidGenerator());
            services.AddSingleton<RandomGuidGenerator>();
            services.AddSingleton<IRandomGuidProvider>();
            services.AddSingleton<IRandomGuidProvider, RandomGuidProvider>();
            
            
            //services.RegisterSingleton<RandomGuidGenerator>();
            
            //services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();
            
            //services.RegisterTransient<ISomeService, SomeService>();

            //services.RegisterSingleton(new RandomGuidGenerator());
            
            var container = services.GenerateContainer();

            var serviceFirst = container.GetService<RandomGuidGenerator>();
            var serviceSecond = container.GetService<RandomGuidGenerator>();
 
            Console.WriteLine(serviceFirst.RandomGuid);
            Console.WriteLine(serviceSecond.RandomGuid);
        }
    }
}