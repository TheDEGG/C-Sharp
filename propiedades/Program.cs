using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";
            
            Alumno b = new Alumno();
            b.id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";

            Console.WriteLine(a.PrimerNombre);
        }
    }
}
