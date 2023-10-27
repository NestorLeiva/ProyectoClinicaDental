using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
	public class Negocio
	{

		private string codigo = string.Empty;
		private string nombreServicio = string.Empty;
		private int monto;

		public string Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		public string NombreServicio
		{
			get { return nombreServicio; }
			set { nombreServicio = value; }
		}

		public int Monto
		{
			get { return monto; }
			set { monto = value; }
		}

		XmlDocument xmlDocServicios = new XmlDocument();// objeto tipo xml
		public void GrabarXMLservicios(string rutaArchivo)
		{
			if (File.Exists(rutaArchivo))
			{
				xmlDocServicios.Load(rutaArchivo);
				/*se carga el fichero*/
			}
			else
			{
				/*Creo el fichreo si no existe*/
				XmlNode xmlRoot = xmlDocServicios.CreateElement("Servicios");
				xmlDocServicios.AppendChild(xmlRoot);
			}
			/*nodo Padre*/
			XmlNode xmlServicios = xmlDocServicios.CreateElement("Servicio");
			xmlDocServicios.DocumentElement.AppendChild(xmlServicios);
			/*se accede al nodo padre y posterior se agregan los nodos*/

			/*nodo Codigo*/
			XmlNode xmlCodigo = xmlDocServicios.CreateElement("Codigo");
			xmlCodigo.InnerText = this.Codigo;
			xmlServicios.AppendChild(xmlCodigo);

			/*nodo NombreServicio*/
			XmlNode xmlNombreServicio = xmlDocServicios.CreateElement("NombreServicio");
			xmlNombreServicio.InnerText = this.NombreServicio;
			xmlServicios.AppendChild(xmlNombreServicio);

			/*nodo Monto*/
			XmlNode xmlMonto = xmlDocServicios.CreateElement("Monto");
			xmlMonto.InnerText = this.Monto.ToString();
			xmlServicios.AppendChild (xmlMonto);


			/*instancia de la clase DAL*/
			DAL.ArchivoXML archivoXMLNegocio = new DAL.ArchivoXML();
			/*realizo la escritura del fichero*/
			archivoXMLNegocio.escribirXML(rutaArchivo, xmlDocServicios);
			/*realizo el guardado del fichero*/
			xmlDocServicios.Save(rutaArchivo);

		}// fin metodo grabarXml

	} // fin class Negocio
}
