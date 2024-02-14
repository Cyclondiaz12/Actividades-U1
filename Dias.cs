using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Dias
    {
        static void Main(string[] args)
        {
          
            int i;


            Console.WriteLine("Escriba un número del 1 al 7 para asignar el día de la semana al que corresponde");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("El día es: Lunes");
                    break;
                case 2:
                    Console.WriteLine("El día es: Martes");
                    break;
                case 3:
                    Console.WriteLine("El día es: Miércoles");
                    break;
                case 4:
                    Console.WriteLine("El día es: Jueves");
                    break;
                case 5:
                    Console.WriteLine("El día es: Viernes");
                    break;
                case 6:
                    Console.WriteLine("El día es: Sábado");
                    break;
                case 7:
                    Console.WriteLine("El día es: Domingo");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }
        }
    }
}
