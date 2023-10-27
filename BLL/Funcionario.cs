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
		private string puesto = string.Empty;
		private string usuario = string.Empty;
		private string contrasenia = string.Empty;

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
			/*nodo Identificacion*/
			XmlNode xmlId = xmlDocFuncionario.CreateElement("Id");
			xmlId.InnerText = this.Identificacion.ToString();
			xmlFuncionario.AppendChild(xmlId);

			/*nodo nombre*/
			XmlNode xmlNombre = xmlDocFuncionario.CreateElement("Nombre");
			xmlNombre.InnerText = this.Nombre;
			xmlFuncionario.AppendChild(xmlNombre);

			/*nodo apellido*/
			XmlNode xmlApellido = xmlDocFuncionario.CreateElement("ApellidoPrimero");
			xmlApellido.InnerText = this.ApellidoPrimero;
			xmlFuncionario.AppendChild(xmlApellido);

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
			xmlFuncionario.AppendChild(xmlUsuario);

			/*nodo contrasenia*/
			XmlNode xmlContrasenia = xmlDocFuncionario.CreateElement("Contrasenia");
			xmlContrasenia.InnerText = this.Contrasenia;
			xmlFuncionario.AppendChild(xmlContrasenia);


			DAL.ArchivoXML archivoFuncionarioXML = new DAL.ArchivoXML(); // instancia & inicializacion del objeto
			archivoFuncionarioXML.escribirXML(rutaArchivo,xmlDocFuncionario);

			xmlDocFuncionario.Save(rutaArchivo);

		} // fin btn grabarXML


		public static List<Funcionario> LeerFuncionariosDesdeXML(string rutaArchivo)
		{
			List<Funcionario> funcionarios = new List<Funcionario>(); 
			/*Se crea una lista de objetos Funcionario para almacenar los funcionarios que se leerán del archivo XML.*/
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(rutaArchivo);
			/*Se carga el archivo xml*/

			XmlNodeList funcionarioNodes = xmlDoc.SelectNodes("/Funcionarios/Funcionrario");
			/*  método SelectNodes para selecciona todos los nodos <Funcionrario> dentro del elemento <Funcionarios> en el archivo XML.*/

			foreach (XmlNode funcionarioNode in funcionarioNodes)
			{
				Funcionario funcionario = new Funcionario
				{
					Usuario = funcionarioNode.SelectSingleNode("Usuario").InnerText,
					Contrasenia = funcionarioNode.SelectSingleNode("Contrasenia").InnerText
					// Asigna otros datos del funcionario si es necesario
				};
				funcionarios.Add(funcionario);
				/*Una vez que se han asignado todas las propiedades del objeto Funcionario, se agrega el objeto a la lista funcionarios utilizando el método Add*/
			}
			/* foreach para iterar a través de todos los nodos de funcionario encontrados en el archivo XML.*/

			return funcionarios; // devuelve la lista de funcionarios
		}






	} // fin class Funcionario
}
