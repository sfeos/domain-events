using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TestDomainEvents.Events;

namespace TestDomainEvents
{
    class Program
    {
        private static IServiceProvider _provider;

        static void Main(string[] args)
        {
            // Using Microsoft's Dependency Injection
            IServiceCollection services = new ServiceCollection();
            
            // Using MediatR Nuget package to create sub/pub
            services.AddMediatR(typeof(ScannerEventCompleted));
            services.AddScoped<IScannerService, ScannerService>();

            _provider = services.BuildServiceProvider();

            
            var scannerService = _provider.GetService<IScannerService>();
            scannerService.Ping();


            Console.ReadLine();
        }
    }
}
