using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalSound.Interfaces;

namespace AnimalSound.Animals;

public abstract class Animal : IAnimal
{
    public string Nume => GetType().Name;
    public string Sunet { get; }

    protected Animal(string sunet)
    {
        Sunet = sunet;
    }
}
