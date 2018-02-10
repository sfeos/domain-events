using MediatR;

namespace TestDomainEvents.Events
{
    public class ScannerEventCompleted : INotification
    {
        public string ScannerResultString { get; set; }

        public ScannerEventCompleted(string scannerResults) 
            => ScannerResultString = scannerResults;
    }
}
