using System;
using System.Collections.Generic;

// interfata IAnimal
interface IAnimal
{
    string Nume { get; }
    string Sunet { get; }
}
 // clasa Animal, ce impleneteaza IAnimal
class Animal : IAnimal
{
    public string Nume { get; init; }
    public string Sunet { get; init; }

// constructorul cls Animal
    public Animal(string nume, string sunet)
    {
        Nume = nume;
        Sunet = sunet;
    }
}

//* clase ce mostenesc clasa Animal
class Broasca : Animal
{
    public Broasca() : base("Broasca", "Oac Oac Oac Oaca!") { }
}

class Pisica : Animal
{
    public Pisica() : base("Pisica", "Miau Miau Miau!") { }
}

class Sarpe : Animal
{
    public Sarpe() : base("Sarpe", "SSSSSSSSsssssssssssss!") { }
}

//ToDo: trebuie afisat sunetul fiecarui animal 
//* afiseaza sunetul animalului
class SoundDisplay
{
    public void DisplaySound(IAnimal animal)
    {
        Console.WriteLine($"{animal.Nume} face sunetul: {animal.Sunet}");
    }
}

class Program
{
    static void Main()
    {
        var animale = new List<IAnimal>
        {
            new Broasca(),
            new Pisica(),
            new Sarpe()
        };

        var display = new SoundDisplay();

        // sunetul fiecarui animal
        foreach (var animal in animale)
        {
            display.DisplaySound(animal);
        }
    }
}