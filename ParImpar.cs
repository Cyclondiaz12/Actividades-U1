using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ParImpar
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Indique un número: ");
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " es par");
                }
                else
                {
                    Console.WriteLine(numero + " no es par");
                }
            }
            else
            {
                Console.WriteLine("Opción Inválida. Por favor ingrese un número válido.");
            }
        }
    }
}

    
