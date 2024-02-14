using System;

	class fahr {

		static void Main(string[] args) {
			double c;
			double f;
			Console.WriteLine("Introduce los grados que deseas convertir a radianes");
			c = Double.Parse(Console.ReadLine());
			f = (c*9/5)+32;
			Console.WriteLine("En radianes, son: "+f);
		}

	}



