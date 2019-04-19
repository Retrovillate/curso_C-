using System;

namespace objetos
{
	public class clsEmpleados
	{
		//constructor de la clase
		public clsEmpleados ()
		{
			// usualmente se inicializan las propiedades
			Nombre="";
			SueldoDiario = 0.0m;
			Edad = 0;
		}

		//propiedades de la clase
		// encapsulamiento privado
		private String _Nombre;
		public String Nombre
		{
			get {
				return _Nombre;
			}
			set{
				_Nombre = value;

			}
		}
		//encapsulamiento publico
		public decimal SueldoDiario {
			get;
			set;
		}
		public int Edad {
			get;
			set;
		}
		//metodos de la clase
		public decimal CalculaSalario (int NumeroDias){
			return SueldoDiario*NumeroDias;
		}
	}
}



