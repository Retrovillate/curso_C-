using System;

namespace Clases_abstrasctas
{
	public class clsImpresion
	{
		
			public void ImprimeCliente(ClsAbsCliente cliente){

			Console.WriteLine (cliente.Clave + " " + cliente.Nombre);
			Console.WriteLine (cliente.TipoRegimen);
			Console.WriteLine (cliente.RFC);
			}
	}
}

