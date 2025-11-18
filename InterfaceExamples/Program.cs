// INTERFACE vs ABSTRACT CLASS:
// - Interfaces define *only* contracts (method/property signatures), no implementation (unless using default methods in C# 8+).
// - Abstract classes can include both abstract members (no implementation) and concrete members (with implementation).
// - A class can implement multiple interfaces, but can only inherit from one abstract class.
// - Use interfaces for capability-based design (e.g., IFlyable, ISerializable), and abstract classes for shared base behavior.


// Create a list of IAnimal — allows polymorphism
List<IAnimal> animals = new List<IAnimal>
{
    new Dog(),
    new Cat()
};

// Call Speak() on each animal — each responds differently
foreach (var animal in animals)
{
    animal.Speak();  // Dynamic dispatch based on actual type
}
