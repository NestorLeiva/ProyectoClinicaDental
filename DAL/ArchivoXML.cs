using System.Xml;

namespace DAL
{
	public class ArchivoXML
	{
		public ArchivoXML()
		{
			// constructor vacio
		}

		public List<string> ListaXML = new List<string>();

		public XmlDocument leerXML(string rutaArchivo)
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(rutaArchivo);
			return xmlDoc;
			/* Crea una instancia de XmlDocument llamada xmlDoc.
			 * creo  el archivo XML ubicado en la ruta especificada utilizando el método Load de XmlDocument. 
			 * devuelvo el objeto XmlDocument que representa el contenido del archivo XML.*/
		}
		// Metodo Override
		public void escribirXML(string rutaArchivo, MemoryStream msDatosXML)
		{
			FileStream fsArchivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write);
			/* Crea un objeto FileStream llamado fsArchivo para abrir el archivo en la ruta especificada en modo de creación (FileMode.Create) 
			 * y con permisos de escritura (FileAccess.Write).*/
			if (fsArchivo != null)
			{
				msDatosXML.WriteTo(fsArchivo);
				fsArchivo.Close();
				msDatosXML.Close();
				/* Luego, verifica si fsArchivo no es nulo. Si es nulo, no se realiza ninguna operación adicional. 
				 * Si fsArchivo no es nulo, los datos del MemoryStream se escriben en el archivo utilizando el método WriteTo. 
				 * Finalmente, se cierra el archivo y el MemoryStream.*/
			}
		}
		// Metodo Override
		public void escribirXML(string rutaArchivo, XmlDocument datosXMl)
		{
			datosXMl.Save(rutaArchivo);
			/* el método guardar los datos XML en el archivo especificado.*/
		}

		public void modificarMXL(string rutaArchivo, string nodoXMLMod, string nuevoNodoXML)
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(rutaArchivo);
			// cargo el archivo XML existente 

			XmlNode nodoXML = xmlDoc.SelectSingleNode(nodoXMLMod);
			//Selecciono el nodo  a modificar por medio del parametro 

			if (nodoXML != null)
			{
				nodoXML.InnerText = nuevoNodoXML;
				// actualizo el valor del nodo 
				xmlDoc.Save(rutaArchivo);
				// guardo los cambios en el archivo XML
			}
		}
	} // fin class ArchivoXML
}// fin namespace DAL