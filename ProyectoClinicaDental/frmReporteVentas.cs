using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoClinicaDental
{
	public partial class frmReporteVentas : Form
	{
		public frmReporteVentas()
		{
			InitializeComponent();
		}

		private void frmReporteVentas_Load(object sender, EventArgs e)
		{
			this.ListarVentas();
		}

		private void ListarVentas()
		{

			try
			{
				XmlDocument xmlDocVentas = new XmlDocument();
				/*cargo el archivo xml*/
				xmlDocVentas.Load("Consulta_Venta.xml");
				/*obtengo la lista de los nodos*/
				XmlNodeList nodoVenta = xmlDocVentas.SelectNodes("//Servicio");

				foreach (XmlNode lstVenta in nodoVenta)
				{

					ListViewItem itemVenta = new ListViewItem(lstVenta.SelectSingleNode("FechaFactura").InnerText);

					itemVenta.SubItems.Add(lstVenta.SelectSingleNode("Codigo").InnerText);
					itemVenta.SubItems.Add(lstVenta.SelectSingleNode("NombreServicio").InnerText);
					itemVenta.SubItems.Add(lstVenta.SelectSingleNode("Monto").InnerText);
					;

					/*Agrego los datos a la lista*/
					lvwReporteFacturas.Items.Add(itemVenta);
				}/*Fin del Foreach*/

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error al cargar la Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




	}
}
