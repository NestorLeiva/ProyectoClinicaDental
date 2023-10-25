namespace BLL
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Persona
	{
		// Los campos están marcados con ?, lo que indica que son de tipo nullable, es decir, pueden ser nulos. Esto significa que pueden contener un valor o ser null.
		private string nombre = string.Empty;
		private string apellido = string.Empty;
		private int identificacion;
		private string genero = string.Empty;
		private int telefono;
		private string email = string.Empty;

		public Persona()
		{
			// constructor vacio 
		}

		public Persona(string nombre, string apellido, int identificacion,  string genero, int telefono, string email)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.identificacion = identificacion;
			this.genero = genero;
			this.telefono = telefono;
			this.email = email;
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
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