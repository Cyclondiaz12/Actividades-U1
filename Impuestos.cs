using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Impuestos
    {
        static void Main(string[] args)
        {
            double t = 1.17; 
            double p;
            int i;
            double x;

            Console.WriteLine("Menu: escriba el número de la opción de su interés");
            Console.WriteLine("1.Producto normal");
            Console.WriteLine("2.Producto/medicina");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Introduzca el valor de su producto en pesos mexicanos");
                    x = double.Parse(Console.ReadLine());
                    p = x * t;
                    Console.WriteLine("El precio de su producto es: " + p + " pesos, considerando los impuestos");
                    break;
                case 2:
                    Console.WriteLine("Introduzca el valor de su medicina");
                    x = double.Parse(Console.ReadLine());
                    p = x;
                    Console.WriteLine("El precio de su medicina es: " + p + " pesos, sin impuestos");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }
        }
    }
}
