﻿using System;

namespace herencia
{
	// de donde va heredada la clase 
	public class clsClientesVentas : clsClientes
	{
		private string _RFC;

		public string RFC{
			get{
				return _RFC;
			}
			set{
				_RFC = value;
			}
		}
		private string _Direccion;

		public string Direccion{
			get{
				return _Direccion;
			}
			set{
				_Direccion = value;
			}
		}
		private string _Colonia;

		public string Colonia{
			get{
				return _Colonia;
			}
			set{
				_Colonia = value;
			}
		}
		private string _Municipio;

		public string Municipio{
			get{
				return _Municipio;
			}
			set{
				_Municipio = value;
			}
		}
		private bool _EsCredito;

		public bool EsCredito{
			get{
				return _EsCredito;
			}
			set{
				_EsCredito = value;
			}
		}
		public clsClientesVentas ()
		{
		}
	}
}

