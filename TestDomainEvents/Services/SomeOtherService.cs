using System;
using MediatR;
using TestDomainEvents.Events;

namespace TestDomainEvents.Services
{
    public class SomeOtherService : NotificationHandler<ScannerEventCompleted>
    {
        protected override void HandleCore(ScannerEventCompleted message) 
            => Console.WriteLine("Some other subscribed service fired.");
    }
}
