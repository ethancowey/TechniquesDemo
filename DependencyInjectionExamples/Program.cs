// DEPENDENCY INJECTION:
// Instead of creating a logger inside this class (tight coupling),
// we inject an ILogger from the outside (loose coupling).
// This makes the class easier to test, extend, and maintain.
//- You can easily swap ConsoleLogger for a FileLogger, DatabaseLogger, or even a MockLogger in tests.
//- This pattern is the foundation of Inversion of Control (IoC) and is widely used in ASP.NET Core with built-in DI containers.



// Inject ConsoleLogger into ReportGenerator
ILogger logger = new ConsoleLogger();
var generator = new ReportGenerator(logger);

generator.Generate();
