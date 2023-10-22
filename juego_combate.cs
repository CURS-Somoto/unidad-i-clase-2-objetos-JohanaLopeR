
using System;

class Guerrero
{
    public int Vida { get; set; }
    public int NivelAtaque { get; set; }
    public string Nombre { get; set; }

    public Guerrero(int vida, int nivelAtaque, string nombre)
    {
        Vida = vida;
        NivelAtaque = nivelAtaque;
        Nombre = nombre;
    }

    public int Ataque()
    {
        return NivelAtaque;
    }

    public void RecibeAtaque(int ataque)
    {
        Vida -= ataque;
    }
}

class Enfrentamiento
{
    public void Iniciar(Guerrero guerrero1, Guerrero guerrero2)
    {
        Console.WriteLine("¡Comienza el enfrentamiento!");
        Console.WriteLine($"{guerrero1.Nombre} (Vida: {guerrero1.Vida}) vs {guerrero2.Nombre} (Vida: {guerrero2.Vida})\n");

        while (guerrero1.Vida > 0 && guerrero2.Vida > 0)
        {
            int ataqueGuerrero1 = guerrero1.Ataque();
            guerrero2.RecibeAtaque(ataqueGuerrero1);
            Console.WriteLine($"{guerrero1.Nombre} ataca a {guerrero2.Nombre} causando {ataqueGuerrero1} de daño.");
            Console.WriteLine($"{guerrero2.Nombre} tiene {guerrero2.Vida} de vida restante.\n");

            if (guerrero2.Vida <= 0)
            {
                Console.WriteLine($"{guerrero1.Nombre} ha derrotado a {guerrero2.Nombre}.");
                break;
            }

            int ataqueGuerrero2 = guerrero2.Ataque();
            guerrero1.RecibeAtaque(ataqueGuerrero2);
            Console.WriteLine($"{guerrero2.Nombre} ataca a {guerrero1.Nombre} causando {ataqueGuerrero2} de daño.");
            Console.WriteLine($"{guerrero1.Nombre} tiene {guerrero1.Vida} de vida restante.\n");

        
            if (guerrero1.Vida <= 0)
            {
                Console.WriteLine($"{guerrero2.Nombre} ha derrotado a {guerrero1.Nombre}.");
                break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Guerrero guerrero1 = new Guerrero(100, 15, "Guerrero 1");
        Guerrero guerrero2 = new Guerrero(90, 18, "Guerrero 2");

        Enfrentamiento enfrentamiento = new Enfrentamiento();
        enfrentamiento.Iniciar(guerrero1, guerrero2);
    }
}
