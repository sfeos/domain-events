using System;
using MediatR;
using TestDomainEvents.Events;

namespace TestDomainEvents
{
    public interface IScannerService
    {
        void Ping();
    }

    public class ScannerService : IScannerService
    {
        private readonly IMediator _mediator;

        public ScannerService(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public void Ping()
        {
            Console.WriteLine("Scanning Sectors!");
            _mediator.Publish(new ScannerEventCompleted("Some result from the scan."));
        }
    }

    public class NotificationService : NotificationHandler<ScannerEventCompleted>
    {
        protected override void HandleCore(ScannerEventCompleted message)
        {
            Console.WriteLine(
                string.Format(
                    "Display updated with scanner results. {0}", 
                    message.TestString));
        }
    }

    public class SomeOtherService : NotificationHandler<ScannerEventCompleted>
    {
        protected override void HandleCore(ScannerEventCompleted message)
        {
            Console.WriteLine("Some other subscribed service fired.");
        }
    }
}
