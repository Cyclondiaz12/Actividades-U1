using System;


	class dolareuro {

		static void Main(string[] args) {
			double c;
			double d;
			double e;
			int i;
			double t;
			double x;
			Console.WriteLine("Menu: escriba el número de la opción de su interés");
			Console.WriteLine("1.Dolar a Euro");
			Console.WriteLine("2.Euro a Dolar");
			i = int.Parse(Console.ReadLine());
			switch (i) {
			case 1:
				Console.WriteLine("Introduzca el valor de 1 dolar en Euros");
				x = Double.Parse(Console.ReadLine());
				Console.WriteLine("Introduzca el monto en dolares que desea convertir");
				d = Double.Parse(Console.ReadLine());
				e = d*x;
				Console.WriteLine(d+"Dolares son:"+e+"euros");
				break;
			case 2:
				Console.WriteLine("Introduzca el valor de 1 Euro en Dolares");
				x = Double.Parse(Console.ReadLine());
				Console.WriteLine("Introduzca el monto en Euros que desea convertir");
				e = Double.Parse(Console.ReadLine());
				d = e*x;
				Console.WriteLine(e+"Euros son:"+d+"Dolares");
				break;
			default:
				Console.WriteLine("Opción Invalida");
				break;
			}
		}

	}



