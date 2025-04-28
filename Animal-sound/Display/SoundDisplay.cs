using AnimalSound.Interfaces;

namespace AnimalSound.Display;

public class SoundDisplay
{
    public void DisplaySound(IAnimal animal)
    {
        Console.WriteLine($"{animal.Nume} face urmatorul sunet: {animal.Sunet}");
    }
}
