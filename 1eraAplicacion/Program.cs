using System;

namespace _1eraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Le pedimos al usuario que ingrese el 1er valor
            Console.WriteLine("Introduce el primer número");
            // Lo parseamos de texto a entero
            int num1 = int.Parse(Console.ReadLine());
            // Le pedimos al usuario que ingrese el 2do valor
            Console.WriteLine("Introduce el segundo número");
            // Lo parseamos de texto a entero
            int num2 = int.Parse(Console.ReadLine());
            // Realizamos la suma y mostramos el resultado
            Console.WriteLine($"El resultado es {num1 + num2}");

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
