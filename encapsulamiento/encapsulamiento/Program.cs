using System;

namespace objetos
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// declar el objeto de tipo clsEmpleado
			clsEmpleados empleado;
			//crear el objeto de tipo empleado
			empleado= new clsEmpleados();
			// asignar caracteristicas del objeto
			empleado.Edad = 25;
			empleado.Nombre=("Camilo Rodriguez");
			empleado.SueldoDiario = 12.5m;
			decimal total;
			total = empleado.CalculaSalario (30);
			Console.WriteLine ("Empleado  : " + empleado.Nombre);
			//imprimir con el tipo moneda
			Console.WriteLine ("Salario mensual es : " + total.ToString("C"));

		}
	}
}
