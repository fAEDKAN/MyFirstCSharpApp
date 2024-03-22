using System;

namespace _1eraAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 29;

            // Mostrar mensaje en consola
            Console.WriteLine($"Tienes una edad de {++edad} años");
            // Agregando el operador (++) como sufijo, hacemos que se incremente en 1 el valor de la variable
            // Si lo aplicamos al final no tendrá efecto, ya que el código así como se ejecuta de arriba hacia abajo, también lo hace de izquierda a derecha

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
