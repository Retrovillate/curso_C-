using System;

namespace presentacion2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			int i=0;
			decimal x = 0.0m;
			float f = 0.0f;
			double d = 0.0D;
			string cadena = "hola mundo";
			bool bandera = false;
			DateTime fecha = DateTime.MinValue;
			Console.WriteLine ("el valor de i es : " + i);
			Console.WriteLine ("el valor de x es : " + x);
			Console.WriteLine ("el valor de f es : {0:F2}",f);
			Console.WriteLine ("el valor de d es : "+d);
			Console.WriteLine ("el valor de la cadena es : "+cadena);
			Console.WriteLine ("el valor de la bandera es : "+bandera.ToString());
			Console.WriteLine ("el valor del deltatime es : "+fecha.ToLongDateString());
		}
	}
}
