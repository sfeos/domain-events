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
            => _mediator = mediator;

        public void Ping()
        {
            Console.WriteLine("Scanning Sectors!");
            _mediator.Publish(new ScannerEventCompleted("Some result from the scan."));
        }
    }
}
