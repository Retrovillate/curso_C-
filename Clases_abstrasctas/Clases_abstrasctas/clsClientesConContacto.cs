using System;

namespace Clases_abstrasctas
{
	public class clsClientesConContacto : ClseClienteBase
	{
		public clsClientesConContacto(){
			_Direccion= new clsDirecciones();
		}
		public clsClientesConContacto(int pID, string pNombre, string PClave, string pRFC, int pTipoRegimen, string pNombreContacto, string PTelefono1, string pTelefono2, string pEmail, string pCalle, string pNumeroExterior, string pNumeroInterior, string pColonia, string pMunicipio, string pEstado, string pCP){
			ID = pID;
			Nombre = pNombre;
			Clave = PClave;
			RFC = pRFC;
			TipoRegimen = pTipoRegimen;
			NombreContacto = pNombreContacto;
			Telefono1 = PTelefono1;
			Telefono2 = pTelefono2;
			Email = pEmail;
			_Direccion= new clsDirecciones();
			Direccion.Calle = pCalle;
			Direccion.NumeroExterior = pNumeroExterior;
			Direccion.NumeroInterior = pNumeroInterior;
			Direccion.Colonia = pColonia;
			Direccion.Municipio = pMunicipio;
			Direccion.Estado = pEstado;
			Direccion.CP = pCP;
		}
		public string Telefono1 {
			get;
			set;
		}
		public string Telefono2 {
			get;
			set;
		}
		public string Email {
			get;
			set;
		}
		private clsDirecciones _Direccion;
		public clsDirecciones Direccion{
			get {
				return _Direccion;
			}
			set {
				_Direccion = value;
			}
			}
				
	}
}

