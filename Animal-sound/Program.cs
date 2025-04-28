using System;
using System.Collections.Generic;
using AnimalSound.Interfaces;
using AnimalSound.Animals;
using AnimalSound.Display;

namespace AnimalSound;

public class Program
{
    public static void Main()
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
