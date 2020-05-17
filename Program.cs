using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Producto p1 = new Producto {
                Id = 1,
                Nombre = "Ryzen 5 2600",
                Precio = 659.50
            };

            Console.WriteLine(p1.Nombre + " " + p1.Precio);
        }
    }
}
