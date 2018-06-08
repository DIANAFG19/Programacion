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
            //Mostrar mensaje y pedir información al usuario.
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es " + nombre);
            //Hacer una suma con dos números que ingrese el usuario.
            Console.WriteLine("Escribe dos número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            int numero2 = Convert.ToInt16(Console.ReadLine());
            int suma = numero1 + numero2;
            Console.WriteLine("La suma de " + numero1 + " + " + numero2 + " = " + suma);
            Console.ReadKey();
        }
    }
}
