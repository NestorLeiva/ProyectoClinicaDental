using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DAL;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DAL
{
	public class Negocio
	{
		private ArchivoXML _archivoXML = new ArchivoXML();
		public List<Negocio> lstNegocio { get; set; }

		public string Codigo { get; set; } = string.Empty;
		public string NombreServicio { get; set; } = string.Empty;
		public double Monto { get; set; }
		public DateTime Fecha { get; set; }
		public int NumeroTiked {  get; set; }

		public double SubTotal { get; set; }
		public double IVA { get; set; }
		public double Total { get; set; }

		public Negocio()
		{
			lstNegocio = new List<Negocio>();
		}

		XmlDocument xmlDocServicios = new XmlDocument();// objeto tipo xml
		XmlDocument xmlDocConsulta = new XmlDocument();
		XmlDocument xmlDocTiked = new XmlDocument();
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
			xmlServicios.AppendChild(xmlMonto);


			/*instancia de la clase DAL*/
			DAL.ArchivoXML archivoXMLNegocio = new DAL.ArchivoXML();
			/*realizo la escritura del fichero*/
			archivoXMLNegocio.escribirXML(rutaArchivo, xmlDocServicios);
			/*realizo el guardado del fichero*/
			xmlDocServicios.Save(rutaArchivo);

		}// fin metodo grabarXml

		public void grabarXmlVenta(string rutaArchivo, List<Negocio> listaNegocio)/*xml Factura*/
		{
			if (File.Exists(rutaArchivo))
			{
				xmlDocConsulta.Load(rutaArchivo);/*cargo el archivo existente*/
			}
			else
			{
				/*crea el archivo si no existe*/
				XmlNode xmlRoot = xmlDocConsulta.CreateElement("Ventas");
				xmlDocConsulta.AppendChild(xmlRoot);
			}
			/*nodo Padre*/
			XmlNode xmlVentaPadre = xmlDocConsulta.CreateElement("Venta");
			xmlDocConsulta.DocumentElement.AppendChild(xmlVentaPadre);
			/*accedo al nodo padre por medio del DocumentElement y posterior agrego los nodos Hijos */



			foreach (Negocio servicio in listaNegocio)
			{
				// Nodo Padre para servicios
				XmlNode nodoServicio = xmlDocConsulta.CreateElement("Servicio");
				xmlVentaPadre.AppendChild(nodoServicio);

				/*Nodo Fecha Factura*/
				XmlNode xmlFecha = xmlDocConsulta.CreateElement("FechaFactura");
				xmlFecha.InnerText = servicio.Fecha.ToString();
				nodoServicio.AppendChild(xmlFecha);

				/*nodo codigo*/
				XmlNode xmlCodigo = xmlDocConsulta.CreateElement("Codigo");
				xmlCodigo.InnerText = servicio.Codigo;
				nodoServicio.AppendChild(xmlCodigo);


				/*nodo NombreServicio*/
				XmlNode xmlNombreServicio = xmlDocConsulta.CreateElement("NombreServicio");
				xmlNombreServicio.InnerText = servicio.NombreServicio;
				nodoServicio.AppendChild(xmlNombreServicio);



				/*Nodo monto*/
				XmlNode xmlMonto = xmlDocConsulta.CreateElement("Monto");
				xmlMonto.InnerText = servicio.Monto.ToString();
				nodoServicio.AppendChild(xmlMonto);

			}
			ArchivoXML archivoXMLConsulta = new ArchivoXML();
			archivoXMLConsulta.escribirXML(rutaArchivo, xmlDocConsulta);
			xmlDocConsulta.Save(rutaArchivo);


			//falta metodos guardar
		} // fin grabarXMLConsulta


		

	} // fin class Negocio
}
