using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace Ioc
{
    class Program
    {
        static void Main(string[] args)
        {

            using IHost host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Email>();
                    services.AddScoped<IMessageWriter, MessageWriter>();
                })
                .Build();

            host.Run();
        }
    }
}
