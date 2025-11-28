using System;
using Microsoft.Extensions.DependencyInjection;

// LIFETIMES IN DEPENDENCY INJECTION:
// - Transient: New instance every time (like handing out fresh paper each request).
// - Scoped: Same instance within a scope (like one notebook per meeting).
// - Singleton: Same instance for the whole app (like one shared whiteboard).
class Program
{
    static void Main()
    {
        // Create a DI container (ServiceCollection)
        var services = new ServiceCollection();

        // Register IService with different lifetimes:
        // Transient: new instance every time it's requested
        services.AddTransient<IService, OperationService>();

        // Build the ServiceProvider
        var provider = services.BuildServiceProvider();

        // Demonstrate lifetimes
        Console.WriteLine("=== Transient ===");
        var transient1 = provider.GetService<IService>();
        var transient2 = provider.GetService<IService>();
        Console.WriteLine(transient1.GetOperationId());
        Console.WriteLine(transient2.GetOperationId()); // new id each time


        // Scoped: one instance per scope (e.g., per web request)
        services.AddScoped<IService, OperationService>();

        // Build the ServiceProvider
        provider = services.BuildServiceProvider();

        Console.WriteLine("\n=== Scoped ===");
        using (var scope1 = provider.CreateScope())
        {
            var scoped1 = scope1.ServiceProvider.GetService<IService>();
            var scoped2 = scope1.ServiceProvider.GetService<IService>();
            Console.WriteLine(scoped1.GetOperationId());
            Console.WriteLine(scoped2.GetOperationId()); // Same ID within scope
        }
        using (var scope2 = provider.CreateScope())
        {
            var scoped3 = scope2.ServiceProvider.GetService<IService>();
            Console.WriteLine(scoped3.GetOperationId()); // Different ID in new scope
        }

        // Singleton: one instance for the entire application lifetime
        services.AddSingleton<IService, OperationService>();

        // Build the ServiceProvider
        provider = services.BuildServiceProvider();

        Console.WriteLine("\n=== Singleton ===");
        var singleton1 = provider.GetService<IService>();
        var singleton2 = provider.GetService<IService>();
        Console.WriteLine(singleton1.GetOperationId());
        Console.WriteLine(singleton2.GetOperationId()); // Same ID always
    }
}