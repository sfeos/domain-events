using System;
using MediatR;
using TestDomainEvents.Events;

namespace TestDomainEvents
{
    public interface IPingService
    {
        void Ping();
    }

    public class PingService : IPingService
    {
        private readonly IMediator _mediator;

        public PingService(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        public void Ping()
        {
            Console.WriteLine("Something should cause!");
            _mediator.Publish(new PingEventHappened());
        }
    }

    public class NotificationService : NotificationHandler<PingEventHappened>
    {
        protected override void HandleCore(PingEventHappened message)
        {
            Console.WriteLine("Notification Sent");
        }
    }

    public class SomeOtherService : NotificationHandler<PingEventHappened>
    {
        protected override void HandleCore(PingEventHappened message)
        {
            Console.WriteLine("Some Other Service");
        }
    }
}
