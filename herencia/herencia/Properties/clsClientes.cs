﻿using System;

namespace herencia
{
	public class clsClientes
	{
		private int _IdCliente;
		public int IdCliente{
			get{
				return _IdCliente;
			}
			set{
				_IdCliente = value;
			}
		}
		private string _Nombres;

		public string  Nombres{
			get{
				return _Nombres;
			}
			set{
				_Nombres = value;
			}
		}
		private string _Apellidos;

		public string  Apellidos{
			get{
				return _Apellidos;
			}
			set{
				_Apellidos = value;
			}
		}
		public clsClientes ()
		{
		}
	}
}

