using System;

namespace Clases_abstrasctas
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// instancia vacia
			//ClseClienteBase cliente= new ClseClienteBase();

			//instancia con parametros
			//ClseClienteBase cliente= new ClseClienteBase(3,"camilo","juanito","prueb",4,"andres");

			// instancia vacia
			//clsClientesConContacto cliente = new clsClientesConContacto( );
			clsClientesConContacto cliente = new clsClientesConContacto(0,"Marcos Hernandez","001","HEHM",1,"Marcos Hernandez","3354656","878787","mx@yahoo.com","AV TIGRE","213131","7567687","La Cueva del Jaguar","Tuxtla Gutierrez","Chiapas","290969");

			// impresion de linea
//			Console.WriteLine (cliente.Clave + " " + cliente.Nombre);
//			Console.WriteLine (cliente.TipoRegimen);
//			Console.WriteLine (cliente.RFC);
			clsImpresion Impresion;
			Impresion = new clsImpresion ();
			Impresion.ImprimeCliente (cliente);
		}
	}
}
