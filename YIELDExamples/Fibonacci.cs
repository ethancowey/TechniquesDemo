using System;
using System.Collections.Generic;

class Fibonacci
{
    public static IEnumerable<int> Generate(int count)
    {
        int a = 0, b = 1;
        for (int i = 0; i < count; i++)
        {
            yield return a;
            int temp = a;
            a = b;
            b = temp + b;
        }
    }

    public static void Run()
    {
        foreach (var n in Generate(10))
            Console.WriteLine(n);
    }
}
