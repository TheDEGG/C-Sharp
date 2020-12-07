using System;
public class PezGlobo: Peces // <- Herencia
{
    public string Escamas { get; set; }

        public void Defensa() // <- Abstraccion
    {
        Console.WriteLine("Inflaser");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Pez normal");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        Console.WriteLine("Velocidad Lenta");
    }
}