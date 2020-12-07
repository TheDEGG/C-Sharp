using System;

public abstract class Peces: Animal
{
    public int Aletas { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nadando...");
    }
}