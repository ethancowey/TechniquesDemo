using System;

// Cat also implements the IAnimal interface
public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");  // Cat's version of Speak
    }
}