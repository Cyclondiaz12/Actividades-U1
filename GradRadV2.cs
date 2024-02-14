
using System;

namespace Act1 {
	class radianes {

		static void Main(string[] args) {
			double c;
			double pi;
			double r;
			Console.WriteLine("Introduce los grados que deseas convertir a radianes");
			c = Double.Parse(Console.ReadLine());
			r = c*(Math.PI/180);
			Console.WriteLine("En radianes, son: "+r);
		}

	}

}

