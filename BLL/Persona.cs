﻿namespace BLL
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Persona
	{
		private string nombre = string.Empty;
		private string apellidoPrimero = string.Empty;
		private string apellidoSegundo = string.Empty;
		private int identificacion;
		private string genero = string.Empty;
		private int telefono;
		private string email = string.Empty;
		

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string ApellidoPrimero
		{
			get { return apellidoPrimero; }
			set { apellidoPrimero = value; }
		}

		public string ApellidoSegundo
		{
			get { return apellidoSegundo; }
			set { apellidoSegundo = value; }
		}

		public int Identificacion
		{
			get { return identificacion; }
			set { identificacion = value; }
		}
		
		public string Genero
		{
			get { return genero; }
			set { genero = value; }
		}
		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

	} // fin class Persona

	
}