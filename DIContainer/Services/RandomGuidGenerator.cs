using System;

namespace DIContainer.Services
{
    public class RandomGuidGenerator
    {
        public Guid RandomGuid { get; set; } = Guid.NewGuid();
    }
}