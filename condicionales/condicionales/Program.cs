using System;

namespace condicionales
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int val1 = 0, val2 = 0;
			String cadena;
			Console.WriteLine ("Digite el primer valor");
			//leer datos por teclado
			cadena = Console.ReadLine ();
			val1 = Convert.ToInt32 (cadena);
			Console.WriteLine ("Digite el segundo valor");
			cadena = Console.ReadLine ();
			val2 = Convert.ToInt32 (cadena);
			//Console.WriteLine ("el valor del val1 es " + val1);
			//Console.WriteLine ("el valor del val2 es " + val2);
			if (val1 <= val2) {
				if (val1 == val2) {
					Console.WriteLine ("el valor 1 y valor 2 son igual");
				} else {
					Console.WriteLine ("el valor 2 es mayor");
				}
			} else {
				Console.WriteLine ("el valor 1 es mayor");

			}

		}
	}
}
