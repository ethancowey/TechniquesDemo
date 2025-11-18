using System;

// A concrete implementation of ILogger that logs to the console
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Console] {message}");
    }
}