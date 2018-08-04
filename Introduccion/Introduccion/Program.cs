using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            //MEN� DE INICIO.
            Console.Write("\n\t\t\tBIENVENIDO\n\n \t\tMEN�");
            Console.Write("\n\t1.- Hola Mundo. \n\t2.- Saltos de L�nea, tabulaci�n, comentarios.");
            Console.Write("\n\t3.- Recepci�n de variables. \n\t4.- Suma de dos n�meros.\n\n");
            Console.Write("SELECCIONE LA SESI�N QUE DESEA CONSULTAR (1, 2, 3 o 4): ");
            int opcion = Convert.ToInt16(Console.ReadLine());

            if(opcion == 1)
            {
                Console.Write("Bienvenido a la programaci�n en C# desde consola.");
                Console.WriteLine("Bienvenido a la programaci�n en C# desde consola.");
                Console.WriteLine("Saliendo... Press any key...");
                Console.ReadKey();
            }
            else if (opcion == 2)
            {
                /*
                 * Comentario a bloque.
                 * 
                 */
                 // Comentario de l�nea.

                Console.WriteLine("Saliendo... Press any key...");
                Console.ReadKey();
            }
            else if(opcion == 3)
            {
                Console.WriteLine("Escribe tu nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Tu nombre es " + nombre);
                Console.WriteLine("Saliendo... Press any key...");
                Console.ReadKey();
            }
            else if (opcion == 4)
            {
                // Hacer una suma con dos n�meros que ingrese el usuario.
                Console.Write("Escribe un n�mero: ");
                int numero1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Escribe un n�mero: ");
                int numero2 = Convert.ToInt16(Console.ReadLine());
                int suma = numero1 + numero2;
                Console.WriteLine("La suma de " + numero1 + " + " + numero2 + " = " + suma);
                Console.WriteLine("Saliendo... Press any key...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Saliendo... Press any key...");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
