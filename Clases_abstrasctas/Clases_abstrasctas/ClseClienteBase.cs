using System;

namespace Clases_abstrasctas
{
	public class ClseClienteBase : ClsAbsCliente
	{
		// constructores
		public ClseClienteBase(){
			ID = 0;
			Nombre = String.Empty;
			Clave = String.Empty;
			RFC = String.Empty;
			TipoRegimen = 0;
			NombreContacto = String.Empty;

		}
		public ClseClienteBase(int pID, string pNombre, string PClave, string pRFC, int pTipoRegimen, string pNombreContacto){
			ID = pID;
			Nombre = pNombre;
			Clave = PClave;
			RFC = pRFC;
			TipoRegimen = pTipoRegimen;
			NombreContacto = pNombreContacto;
		}
		// override implementado los atributos de la clase abstracta
		public override int ID {
			get;
			set;
		}
		public override  string Nombre {
			get;
			set;
		}
		public override  string Clave {
			get;
			set;
		}
		public override  string RFC {
			get;
			set;
		}
		public override  int TipoRegimen {
			get;
			set;
		}
		public override  string NombreContacto {
			get;
			set;
		}
		
	}
}

