using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();
// Mamifero
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("----------------------Manifero--------------------");
            Console.WriteLine("--------------------------------------------------");
            Perro p = new Perro();
            p.Nombre = "Perro: Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            Console.WriteLine("");

            Gato g = new Gato();
            g.Nombre = "Gato: Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine("");

            Mono m = new Mono();
            m.Nombre = "Mono: Cesar";
            m.Patas = 4;
            m.Pelaje = "negro";
            m.Comer();
            m.Caminar();
            m.Maullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine("");
// AVES     
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-----------------------Aves-----------------------");
            Console.WriteLine("--------------------------------------------------");

            aguila a = new aguila();
            a.Nombre = "Aguila : Falcon";
            a.Pumaje = "Color  : negro y blanco";
            a.Comer();
            a.Volar();
            a.Tamano();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Pumaje);
            Console.WriteLine("");

            Loro l = new Loro();
            l.Nombre = "Loro: Paco";
            l.Pumaje = "Color: Verde";
            l.Comer();
            l.Hablar();
            l.Tamano();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Pumaje);
            Console.WriteLine("");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("----------------------Peces-----------------------");
            Console.WriteLine("--------------------------------------------------");

            PezGlobo pg = new PezGlobo();
            pg.Nombre = "Pez: Globito";
            pg.Escamas = "Color: Amarillo";
            pg.Aletas = 3;
            pg.Comer();
            pg.Defensa();
            pg.Tamano();

            Console.WriteLine(pg.Nombre);
            Console.WriteLine(pg.Escamas);
            Console.WriteLine(pg.Aletas);
            Console.WriteLine("");
        }
    }
}
