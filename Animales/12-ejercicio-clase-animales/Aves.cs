using System;

public abstract class Aves: Animal
{
    public int Alas { get; set; }

    public void volar()
    {
        Console.WriteLine("Volando...");
    }
}