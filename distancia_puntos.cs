
using System;

class Punto
{
    public decimal X { get; set; }
    public decimal Y { get; set; }
    public decimal Z { get; set; }

    public Punto(decimal x, decimal y)
    {
        X = x;
        Y = y;
        Z = 0; 
    }

    public Punto(decimal x, decimal y, decimal z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double MedirDistancia(Punto destino)
    {
        double distancia;

        if (Z == 0 && destino.Z == 0)
        {
            distancia = Math.Sqrt(Math.Pow((double)(destino.X - X), 2) + Math.Pow((double)(destino.Y - Y), 2));
        }
        else 
        {
            distancia = Math.Sqrt(Math.Pow((double)(destino.X - X), 2) + Math.Pow((double)(destino.Y - Y), 2) + Math.Pow((double)(destino.Z - Z), 2));
        }

        return distancia;
    }
}

class Program
{
    static void Main()
    {
        Punto puntoOrigen2D = new Punto(0, 0);
        Punto puntoDestino2D = new Punto(3, 4);

        double distancia2D = puntoOrigen2D.MedirDistancia(puntoDestino2D);

        Console.WriteLine("Distancia en 2D: " + distancia2D);

        Punto puntoOrigen3D = new Punto(1, 2, 3);
        Punto puntoDestino3D = new Punto(4, 5, 6);

        double distancia3D = puntoOrigen3D.MedirDistancia(puntoDestino3D);

        Console.WriteLine("Distancia en 3D: " + distancia3D);
    }
}
