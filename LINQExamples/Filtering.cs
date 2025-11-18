using System;
using System.Linq;

class Filtering
{
    public static void Run()
    {
        var numbers = Enumerable.Range(1, 10);
        var evens = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers:");
        foreach (var n in evens)
            Console.WriteLine(n);
    }
}
