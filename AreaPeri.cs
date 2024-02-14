using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class AreaPeri
    {
        static void Main(string[] args)
        {

            int i;
            double l;
            double s;
            double p;
            double a;
            double f;

            Console.WriteLine("Escriba el número correspondiente a la opción de su interés");
            Console.WriteLine("1. Perimetro");
            Console.WriteLine("2. Area");

            i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("Introduzca el número de lados");
                    l = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el largo de cada lado (en metros)");
                    s = Double.Parse(Console.ReadLine());
                    p = s * l;
                    Console.WriteLine("Su perímetro es:" + p + " metros");
                    break;
                case 2:
                    Console.WriteLine("Introduzca el número de lados");
                    l = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el largo de cada lado (en metros)");
                    s = Double.Parse(Console.ReadLine());
                    p = s * l;
                    Console.WriteLine("Introduzca el largo del apotema");
                    a = Double.Parse(Console.ReadLine());
                    f = (a * p) / 2;
                    Console.WriteLine("Su area es:" + f + " metros");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }
        }
    }
}
