using System;

namespace herencia
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			clsClientesVentas Cliente;
			Cliente = new clsClientesVentas ();
			Cliente.IdCliente = 123;
			Cliente.Apellidos = "Hernandez Hernandez";
			Cliente.Nombres = "Marcos";
			Cliente.RFC = "HEHM";
			Cliente.Direccion = "Av. Tigres 119";
			Cliente.Colonia = "La cueva del jaguar";
			Cliente.Municipio = "Tuxtla Gutierrez";
			Cliente.EsCredito = true;
			Console.WriteLine (Cliente.Apellidos + " " + Cliente.Nombres);
			Console.WriteLine (Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
			Console.WriteLine (Cliente.RFC);
			if (Cliente.EsCredito) {
				Console.WriteLine ("El cliente tiene credito");
			}
			else {
				Console.WriteLine ("El cliente no tiene credito");
			}
			//Console.WriteLine ("Hello World!");
		}
	}
}
