using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class RadGrad2
    {
        static void Main()
        {
            double g;
            double r;
            int i;

            Console.WriteLine("Menu: escriba el número de la opción de su interés");
            Console.WriteLine("1.Grados a Radianes");
            Console.WriteLine("2. Radianes a Grados");

            i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("Introduzca los grados que desea convertir");
                    g = double.Parse(Console.ReadLine());
                    r = g * (Math.PI / 180);
                    Console.WriteLine(g + " Grados son: " + r + " radianes");
                    break;
                case 2:
                    Console.WriteLine("Introduzca los radianes que desea convertir");
                    r = double.Parse(Console.ReadLine());
                    g = r * (180 / Math.PI);
                    Console.WriteLine(r + " Radianes son: " + g + " grados");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }
        }
    }
}
