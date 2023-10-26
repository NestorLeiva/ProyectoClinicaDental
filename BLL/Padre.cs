using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
	public class Padre : Persona
	{
		// esta clase Hereda todo lo de Persona por ese motivo no tiene nada
		public List<Hijo> Hijos { get; set; } = new List<Hijo>();

		public Padre() { 
			/* constructor vacio*/
		}


		// lista para guardar los hijos

		public Direccion nDireccion { get; set; }
		public Hijo nHijo { get; set; }

		XmlDocument xmlDocPacientes = new XmlDocument(); // instancia & incializacion del objeto

		public void GrabarXML(string rutaArchivo)
		{

			if (File.Exists(rutaArchivo)) /*Valido que exista el archivo*/
			{
				xmlDocPacientes.Load(rutaArchivo);
				/*cargo el archivo existente*/
			}
			else
			{
				/*crea el archivo si no existe*/
				XmlNode xmlRoot = xmlDocPacientes.CreateElement("Padres");
				xmlDocPacientes.AppendChild(xmlRoot);
			}

			/*nodo Padre*/
			XmlNode xmlPadre = xmlDocPacientes.CreateElement("Padre");
			xmlDocPacientes.DocumentElement.AppendChild(xmlPadre);
			/*accedo al nodo padre por medio del DocumentElement y posterior agrego los nodos Hijos */

			// ------------------------------------------------------------------------------------------------

			/*Nodo Identificacion*/
			XmlNode xmlId = xmlDocPacientes.CreateElement("Id");
			xmlId.InnerText = this.Identificacion.ToString();
			xmlPadre.AppendChild(xmlId);

			/*Nodo nombre*/
			XmlNode xmlNombre = xmlDocPacientes.CreateElement("Nombre");
			xmlNombre.InnerText = this.Nombre;
			xmlPadre.AppendChild(xmlNombre);

			/*nodo apellido*/
			XmlNode xmlApellido = xmlDocPacientes.CreateElement("Apellido");
			xmlApellido.InnerText = this.Apellido;
			xmlPadre.AppendChild(xmlApellido);

			/*nodo genero*/
			XmlNode xmlGenero = xmlDocPacientes.CreateElement("Genero");
			xmlGenero.InnerText = this.Genero;
			xmlPadre.AppendChild(xmlGenero);

			/*nodo telefono*/
			XmlNode xmlTelefono = xmlDocPacientes.CreateElement("Telefono");
			xmlTelefono.InnerText = this.Telefono.ToString();
			xmlPadre.AppendChild(xmlTelefono);

			/*nodo email*/
			XmlNode xmlEmail = xmlDocPacientes.CreateElement("Email");
			xmlEmail.InnerText = this.Email;
			xmlPadre.AppendChild(xmlEmail);
			// ------------------------------------------------------------------------------------------------

			/*nodo Direccion Provinvia*/
			XmlNode xmlDirProvincia = xmlDocPacientes.CreateElement("Provincia");
			xmlDirProvincia.InnerText = nDireccion.Provincia.ToString();
			xmlPadre.AppendChild(xmlDirProvincia);

			/*nodo direccion Canton*/
			XmlNode xmlDirCaton = xmlDocPacientes.CreateElement("Canton");
			xmlDirCaton.InnerText = nDireccion.Canton;
			xmlPadre.AppendChild(xmlDirCaton);

			/*nodo direccion Distrito*/
			XmlNode xmlDirDistrito = xmlDocPacientes.CreateElement("Distrito");
			xmlDirDistrito.InnerText = nDireccion.Distrito;
			xmlPadre.AppendChild(xmlDirDistrito);

			/*nodo Direccion OtrasSenas*/
			XmlNode xmlDirOtrasSenias = xmlDocPacientes.CreateElement("OtrasSenias");
			xmlDirOtrasSenias.InnerText = nDireccion.OtrasSenas;
			xmlPadre.AppendChild(xmlDirOtrasSenias);
			// ------------------------------------------------------------------------------------------------

			/*agrego el xmlHijos al nodo Padre*/
			XmlNode xmlHijos = xmlDocPacientes.CreateElement("Hijos");
			xmlPadre.AppendChild(xmlHijos);

			// ---------------------------------- registrar hijos padre ---------------------------------------
			foreach (Hijo mocoso in this.Hijos)
			{
				/*nodo Padre*/
				XmlNode _xmlHijo = xmlDocPacientes.CreateElement("Hijo");
				xmlDocPacientes.DocumentElement.AppendChild(_xmlHijo);
				/*accedo al nodo padre por medio del DocumentElement y posterior agrego los nodos Hijos */

				/*Nodo Identificacion*/
				XmlNode xmlIdHijo = xmlDocPacientes.CreateElement("Id");
				xmlIdHijo.InnerText = mocoso.Identificacion.ToString();
				_xmlHijo.AppendChild(xmlIdHijo);

				/*Nodo nombre*/
				XmlNode xmlNombreHijo = xmlDocPacientes.CreateElement("Nombre");
				xmlNombreHijo.InnerText = mocoso.Nombre;
				_xmlHijo.AppendChild(xmlNombreHijo);

				/*nodo apellido*/
				XmlNode xmlApellidoHijo = xmlDocPacientes.CreateElement("Apellido");
				xmlApellidoHijo.InnerText = mocoso.Apellido;
				_xmlHijo.AppendChild(xmlApellidoHijo);

				/*nodo Fecha Nacimiento*/
				XmlNode xmlFechaNacimiento = xmlDocPacientes.CreateElement("FechaNacimiento");
				xmlFechaNacimiento.InnerText = mocoso.fechaNaciemiento.ToString("dd/MM/yyyy");
				_xmlHijo.AppendChild(xmlFechaNacimiento);

				/*nodo genero*/
				XmlNode xmlGeneroHijo = xmlDocPacientes.CreateElement("Genero");
				xmlGeneroHijo.InnerText = mocoso.Genero;
				_xmlHijo.AppendChild(xmlGeneroHijo);

				/*nodo telefono*/
				XmlNode xmlTelefonoHijo = xmlDocPacientes.CreateElement("Telefono");
				xmlTelefonoHijo.InnerText = mocoso.Telefono.ToString();
				_xmlHijo.AppendChild(xmlTelefonoHijo);

				/*nodo email*/
				XmlNode xmlEmailHijo = xmlDocPacientes.CreateElement("Email");
				xmlEmailHijo.InnerText = mocoso.Email;
				_xmlHijo.AppendChild(xmlEmailHijo);

			}
			// ------------------------------------------------------------------------------------------------
			DAL.ArchivoXML archivoPacientesXML = new DAL.ArchivoXML();
			archivoPacientesXML.escribirXML(rutaArchivo, xmlDocPacientes);

			xmlDocPacientes.Save(rutaArchivo);

		} // fin btn grabar



	} // fin class padre
}
