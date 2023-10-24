using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
	public class Funcionario : Persona  // herencia
	{
		// Los campos están marcados con ?, lo que indica que son de tipo nullable, es decir, pueden ser nulos. Esto significa que pueden contener un valor o ser null.

		private string puesto = string.Empty;
		private string usuario = string.Empty;
		private string contrasenia = string.Empty;

		/* el : base realiza la llamada al constructor de la clase persona
         * el Base  nos asegura de que los campos esten inicializados correctamente
         * ("", "", 0, new DateOnly(), 0, "", 0, "") son los valores predeterminados  para los campos y propiedades de la clase  base 
        */

		public Funcionario()
		{
			// constructor 
		}

		public Funcionario(string puesto, string usuario, string contrasenia) :
			base("", "", 0, new DateTime(), 0, "", 0, "")
		{
			// constuctor con parametros
			Puesto = puesto;
			Usuario = usuario;
			Contrasenia = contrasenia;
		}

		public string Puesto
		{
			get { return puesto; }
			set { puesto = value; }
		}
		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}
		public string Contrasenia
		{
			get { return contrasenia; }
			set { contrasenia = value; }
		}
		// -----------------------------------------------------------------------------------

		// metodo para grabar el archivo XMl
		XmlDocument xmlDocFuncionario = new XmlDocument();
		public void grabarXML(string rutaArchivo)
		{
			if (File.Exists(rutaArchivo)) /*Valido que exista el archivo*/
			{
				xmlDocFuncionario.Load(rutaArchivo);
				/*cargo el archivo existente*/
			}
			else
			{
				/*Si no existe el archivo se crea*/
				XmlNode xmlRoot = xmlDocFuncionario.CreateElement("Funcionarios");
				xmlDocFuncionario.AppendChild(xmlRoot);
			}
			// se agregan los demas datos al xml

			/*nodo padre*/
			XmlNode xmlFuncionario = xmlDocFuncionario.CreateElement("Funcionrario");
			xmlDocFuncionario.DocumentElement.AppendChild(xmlFuncionario);
			/*accedo al nodo padre por medio del DocumentElement y posterior agrego los nodos Hijos */

			// -----------------------------------------------------------------------------------
			/*nodo nombre*/
			XmlNode xmlNombre = xmlDocFuncionario.CreateElement("Nombre");
			xmlNombre.InnerText = this.Nombre;
			xmlFuncionario.AppendChild(xmlNombre);

			/*nodo apellido*/
			XmlNode xmlApellido = xmlDocFuncionario.CreateElement("Apellido");
			xmlApellido.InnerText = this.Apellido;
			xmlFuncionario.AppendChild(xmlApellido);

			/*nodo Identificacion*/
			XmlNode xmlId = xmlDocFuncionario.CreateElement("Id");
			xmlId.InnerText = this.Identificacion.ToString();
			xmlFuncionario.AppendChild(xmlId);

			/*nodo Genero*/
			XmlNode xmlGenero = xmlDocFuncionario.CreateElement("Genero");
			xmlGenero.InnerText = this.Genero;
			xmlFuncionario.AppendChild(xmlGenero);

			/*nodo Telefono*/
			XmlNode xmlTelefono = xmlDocFuncionario.CreateElement("Telefono");
			xmlTelefono.InnerText = this.Telefono.ToString();
			xmlFuncionario.AppendChild(xmlTelefono);

			/*nodo email*/
			XmlNode xmlEmail = xmlDocFuncionario.CreateElement("Email");
			xmlEmail.InnerText = this.Email;
			xmlFuncionario.AppendChild(xmlEmail);

			/*Nodo Puesto*/
			XmlNode xmlPuesto = xmlDocFuncionario.CreateElement("Puesto");
			xmlPuesto.InnerText = this.Puesto;
			xmlFuncionario.AppendChild(xmlPuesto);

			/*nodo usuario*/
			XmlNode xmlUsuario = xmlDocFuncionario.CreateElement("Usuario");
			xmlUsuario.InnerText = this.Usuario;
			xmlFuncionario.AppendChild(xmlPuesto);

			/*nodo contrasenia*/
			XmlNode xmlContrasenia = xmlDocFuncionario.CreateElement("Contrasenia");
			xmlContrasenia.InnerText = this.Contrasenia;
			xmlFuncionario.AppendChild(xmlContrasenia);


			DAL.ArchivoXML archivoFuncionarioXML = new DAL.ArchivoXML(); // instancia & inicializacion del objeto
			archivoFuncionarioXML.escribirXML(rutaArchivo,xmlDocFuncionario);

			xmlDocFuncionario.Save(rutaArchivo);

		} // fin btn grabarXML

	} // fin class Funcionario
}
