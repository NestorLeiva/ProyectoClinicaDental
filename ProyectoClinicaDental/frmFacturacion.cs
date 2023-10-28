using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoClinicaDental
{
	public partial class frmFacturacion : Form
	{


		public frmFacturacion()
		{
			InitializeComponent();
			llenarCboXML();
		}

		private void llenarCboXML()
		{
			string rutaArchivoXML = "Servicios.xml";

			XmlDocument xmlDocServicos = new XmlDocument();
			xmlDocServicos.Load(rutaArchivoXML);

			/* obtengo los elementos 'item' en el archivo XML*/
			XmlNodeList items = xmlDocServicos.SelectNodes("/Servicios/Servicio//NombreServicio");

			// Recorre los elementos y agrégalos al ComboBox
			foreach (XmlNode item in items)
			{
				cboServicio.Items.Add(item.InnerText);
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string elementoObtenido = cboServicio.SelectedItem as string;
			if (!string.IsNullOrEmpty(elementoObtenido))
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("Servicios.xml");/*cargo el archivo XMl*/

				XmlNode _xmlNode = xmlDoc.SelectSingleNode($"/Servicios/Servicio[NombreServicio='{elementoObtenido}']");
				/* Se utiliza XPath  (XML Path Language)  para buscar un nodo específico en el archivo XML. 
				 * El nodo busca en la ruta "/Servicios/Servicio" donde el valor del atributo "NombreServicio" coincide con el elemento seleccionado en el ComboBox. 
				 * El resultado se almacena en la variable _xmlNode.*/

				if (_xmlNode != null) /*valido que el nodo no sea nulo*/
				{
					// Obtener los valores de los atributos del nodo
					string codigo = _xmlNode.SelectSingleNode("Codigo").InnerText;
					string nombreServicio = elementoObtenido;
					string monto = _xmlNode.SelectSingleNode("Monto").InnerText;

					// Agregar los valores al ListView
					ListViewItem listViewFactura = new ListViewItem(codigo);
					listViewFactura.SubItems.Add(nombreServicio);
					listViewFactura.SubItems.Add(monto);

					/*imprimo los datos en la listview*/
					lvwListaFactura.Items.Add(listViewFactura);
					/*llamada al metodo*/
					this.calculoMatematico();
				}

			}// fin if

		}// fin btnAgregar



		private void calculoMatematico()
		{
			/*declaracion de variables para el calculo Matematico*/
			double subtotal = 0;
			double iva = 0.02; /*2%*/
			double total = 0;


			foreach (ListViewItem item in lvwListaFactura.Items) /*recorro los elementos de la listview*/
			{
				double monto = double.Parse(item.SubItems[2].Text);
				/*obtengo el valor del subindice monto y se convierte en double*/
				subtotal += monto;
				/*agrego los montos y acumulo la suma */
			}
			
			iva = subtotal * iva; /*multiplico el subtotal por el IVA*/
			total = subtotal + iva; /*sumo el subtotal + el IVA*/

			/*imprimo los valores en los labels*/
			lblResSubTotal.Text = subtotal.ToString();
			lblResIVA.Text = iva.ToString();
			lblResTotal.Text = total.ToString();


		} /* fin calculoMatematico */
	}
}
