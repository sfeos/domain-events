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
            IServiceCollection services = new ServiceCollection();
            
            services.AddMediatR(typeof(PingEventHappened));
            services.AddScoped<IPingService, PingService>();

            _provider = services.BuildServiceProvider();

            
            var pingService = _provider.GetService<IPingService>();
            pingService.Ping();


            Console.ReadLine();
        }
    }
}
