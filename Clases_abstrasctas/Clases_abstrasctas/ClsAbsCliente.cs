using System;

namespace Clases_abstrasctas
{
	public abstract class ClsAbsCliente
	{
		public abstract int ID {
			get;
			set;
		}
		public abstract string Nombre {
			get;
			set;
		}
		public abstract string Clave {
			get;
			set;
		}
		public abstract string RFC {
			get;
			set;
		}
		public abstract int TipoRegimen {
			get;
			set;
		}
		public abstract string NombreContacto {
			get;
			set;
		}

	}
}

