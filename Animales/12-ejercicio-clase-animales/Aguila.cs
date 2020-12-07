using System;
public class aguila: Aves // <- Herencia
{
    public bool EsDomestico { get; set; }
    public string Pumaje { get; set; }

    public aguila() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public aguila(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Volar() // <- Abstraccion
    {
        Console.WriteLine("Vuela alto");
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
        Console.WriteLine("Velocidad alta");
    }
}