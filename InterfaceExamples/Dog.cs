using System;

// Dog implements the IAnimal interface
public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");  // Dog's version of Speak
    }
}