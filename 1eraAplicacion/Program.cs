using System;

namespace _1eraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int VALOR = 5;

            const int VALOR2 = 7;

            Console.WriteLine("El valor de la constante es: {1}", VALOR, VALOR2);

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
