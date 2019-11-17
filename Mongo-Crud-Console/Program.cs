using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Mongo_Crud_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

        }
    }
}
