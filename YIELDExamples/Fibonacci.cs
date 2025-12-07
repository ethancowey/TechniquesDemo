using System;
using System.Collections.Generic;

/// <summary>
/// Demonstrates the yield keyword to lazily generate Fibonacci numbers.
/// This approach uses deferred execution, computing values only when needed.
/// </summary>
class Fibonacci
{
    /// <summary>
    /// Generates the first 'count' numbers in the Fibonacci sequence.
    /// Uses yield return for lazy evaluation without storing all values in memory.
    /// </summary>
    /// <param name="count">The number of Fibonacci numbers to generate</param>
    /// <returns>An enumerable sequence of Fibonacci numbers</returns>
    public static IEnumerable<int> Generate(int count)
    {
        // Initialize first two Fibonacci numbers: F(0)=0, F(1)=1
        int a = 0, b = 1;
        for (int i = 0; i < count; i++)
        {
            // Return current value and pause execution (lazy evaluation)
            yield return a;
            // Calculate next Fibonacci number using the formula: F(n) = F(n-1) + F(n-2)
            int temp = a;
            a = b;
            b = temp + b;
        }
    }

    public static void Run()
    {
        // Generate and display the first 10 Fibonacci numbers
        foreach (var n in Generate(10))
            Console.WriteLine(n);
    }
}
