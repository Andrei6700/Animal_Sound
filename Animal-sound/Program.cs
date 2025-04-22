using System;
using System.Collections.Generic;

interface IAnimal
{
    string Nume { get; }
    string Sunet { get; }
}

abstract class Animal : IAnimal
{
    public string Nume => GetType().Name; 
    public string Sunet { get; }

    protected Animal(string sunet)
    {
        Sunet = sunet;
    }
}

class Broasca : Animal
{
    public Broasca() : base("Oac Oac Oac Oaca!") { }
}

class Pisica : Animal
{
    public Pisica() : base("Miau Miau Miau!") { }
}

class Sarpe : Animal
{
    public Sarpe() : base("SSSSSSSSsssssssssssss!") { }
}

class SoundDisplay
{
    public void DisplaySound(IAnimal animal)
    {
        Console.WriteLine($"{animal.Nume} face urmatorul sunet: {animal.Sunet}");
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

        foreach (var animal in animale)
        {
            display.DisplaySound(animal);
        }
    }
}