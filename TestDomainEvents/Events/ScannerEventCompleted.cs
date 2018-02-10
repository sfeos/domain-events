using MediatR;

namespace TestDomainEvents.Events
{
    public class ScannerEventCompleted : INotification
    {
        public string TestString { get; set; }

        public ScannerEventCompleted(string test)
        {
            TestString = test;
        }
    }
}
