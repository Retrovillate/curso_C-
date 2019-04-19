using System;

namespace objetos
{
	public class clsEmpleados
	{
		//propiedades de la clase
		public String Nombre;
		private String _Nombre;
		public decimal SueldoDiario;
		public int Edad;
		//constructor de la clase
		public clsEmpleados ()
		{
			// usualmente se inicializan las propiedades
			Nombre="";
			SueldoDiario = 0.0m;
			Edad = 0;
		}
		//metodos de la clase
		public decimal CalculaSalario (int NumeroDias){
			return SueldoDiario*NumeroDias;
		}
	}
}

