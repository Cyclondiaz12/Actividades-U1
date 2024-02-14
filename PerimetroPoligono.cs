using System;

    class poligreg
    {

        static void Main(string[] args)
        {
            double l;
            double p;
            double s;
            Console.WriteLine("Introduzca el número de lados");
            l = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el largo de cada lado (en metros)");
            s = Double.Parse(Console.ReadLine());
            p = s * l;
            Console.WriteLine("Su perímetro es:" + p + " metros");
        }

    }



