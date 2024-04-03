using System;

namespace _1eraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Introducí la medida del radio:");

            double radio = double.Parse(Console.ReadLine());

            // double area = radio * radio * PI;

            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El área del círculo es: {area}");

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
