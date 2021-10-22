using System;
using DIContainer.Services;

namespace DIContainer
{
    public class SomeService : ISomeService
    {
        private readonly IRandomGuidProvider _randomGuidProvider;

        public SomeService(IRandomGuidProvider randomGuidProvider)
        {
            _randomGuidProvider = randomGuidProvider;
        }
        
        public void PrintSomething()
        {
            Console.WriteLine(_randomGuidProvider.RandomGuid);
        }
    }
}