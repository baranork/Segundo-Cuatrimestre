using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            /* int numeros;
           int mayor = 0;
           int menor = 0;
           int total = 0;
           bool flag = true;
           int i;

           for(i = 0; i<5; i++)
           {
               Console.Write("Ingrese un numero: ");
               numeros = int.Parse(Console.ReadLine());
               if (flag)
               {
                   mayor = numeros;
                   menor = numeros;
                   flag = false;
               }

               if(numeros < menor)
               {
                   menor = numeros;
               }
               if (numeros > mayor)
               {
                   mayor = numeros;
               }
               total = total + numeros;

           }

           Console.WriteLine("\n\nLa suma de todos los numeros ingresados es: {0}", total);
           Console.WriteLine("El menor numero ingresado fue el: {0}, y el mayor el: {1}", menor, mayor);
           Console.WriteLine("El promedio de los numeros ingresados es: {0}", (((float)total)) / i);
           Console.ReadKey(); */

            int numero;
            int cuadrado;
            int cubo;

            Console.Write("Ingrese un numero. De ese numero se le mostraran su cuadrado y su cubo: ");
            numero = int.Parse(Console.ReadLine());

            while(numero == 0)
            {
                Console.Write("ERROR! Reingrese el numero");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado = numero * numero;
            cubo = cuadrado * numero;

            Console.Write("Numero: {0} Cuadrado: {1} Cubo: {2}", numero, cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
