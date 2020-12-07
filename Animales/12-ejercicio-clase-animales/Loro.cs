using System;
public class Loro: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Pumaje { get; set; }
    
    public Loro() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Loro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Hablar() // <- Abstraccion
    {
        Console.WriteLine("Hablar");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("una ave mediana");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {
        Console.WriteLine("Velocidad normal");
    }
}