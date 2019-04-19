using System;

namespace presentancion2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			int i=10;
			decimal x = 12.2m;
			bool bandera=false;
			//cadena vacia
			//string cadena = String.Empty;
			//cadena numerica
			string cadena = "12345";
			DateTime fecha=DateTime.MinValue;
			// cambio de decimal a entero
			// x = i;
			// cambio de decimal a entero por cast
			//i=(int)x;
			// cambio de decimal a entero por convercion
			//i=Convert.ToInt32(x);
			// cambio de booleando a entero por convercion
			//i=Convert.ToInt32(bandera);
			// cambio de string a entero por convercion
			i=Convert.ToInt32(cadena);
			Console.WriteLine ("el valor de i es ; " + i);
			Console.WriteLine ("el valor de x es ; " + x);
			Console.WriteLine ("el valor de la bandera es ; " + bandera.ToString());
			Console.WriteLine("el valor de la cadena es : "+cadena);
			Console.WriteLine ("el valor de la fecha es : " + fecha.ToLongDateString ());

		}
	}
}
