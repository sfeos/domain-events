using System;
using MediatR;
using TestDomainEvents.Events;

namespace TestDomainEvents.Services
{
    public class NotificationService : NotificationHandler<ScannerEventCompleted>
    {
        protected override void HandleCore(ScannerEventCompleted message)
        {
            Console.WriteLine(
                string.Format(
                    "Display updated with scanner results. {0}", 
                    message.ScannerResultString));
        }
    }
}
