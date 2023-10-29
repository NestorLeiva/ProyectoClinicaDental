using BLL;
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
using Utils;

namespace ProyectoClinicaDental
{
	public partial class frmFacturacion : Form
	{
		List<Negocio> lstNegocio;
		List<Negocio> lstNegocioTiked;
		private Negocio _Negocio = new Negocio();
		private Padre _Padre = new Padre();

		private static int numeroTiked = 1; /*declaracion de una variable con valor estatico*/

		public frmFacturacion()
		{
			InitializeComponent();
			//_Negocio.lstNegocio = lstNegocio;
			llenarCboXML();
		}


		private void frmFacturacion_Load(object sender, EventArgs e)
		{
			try
			{
				/*Inicializacion de la lista*/
				lstNegocio = new List<Negocio>();
				lstNegocioTiked = new List<Negocio>();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Reporte Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
				/*toma el contenido textual del nodo item utilizando item.InnerText y se agrega ese contenido como un elemento al ComboBox cboServicio*/
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			DateTime fecha = dtpFechaFactura.Value;
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
					string codigo = _xmlNode.SelectSingleNode("Codigo").InnerText;/*Se obtienen los valores de los atributos del nodo _xmlNode*/
					string nombreServicio = elementoObtenido;/*Se obtienen los valores de los atributos del nodo _xmlNode*/
					string monto = _xmlNode.SelectSingleNode("Monto").InnerText;/*Se obtienen los valores de los atributos del nodo _xmlNode*/


					double dbMonto;
					if (double.TryParse(monto, out dbMonto))/*Convierto el valor de monto en doble*/
					{
						Negocio _negocio = new Negocio /*instancia de la clase */
						{
							Fecha = fecha,
							Codigo = codigo,
							NombreServicio = nombreServicio,
							Monto = dbMonto

						};
						lstNegocio.Add(_negocio);
						/*agrega la instancia de Negocio a una lista llamada lstNegocio*/

						// Agregar los valores al ListView
						ListViewItem listViewFactura = new ListViewItem(fecha.ToString("dd/MM/yyyy"));
						listViewFactura.SubItems.Add(codigo);
						listViewFactura.SubItems.Add(nombreServicio);
						listViewFactura.SubItems.Add(monto);
						/*imprimo los datos en la listview*/
						lvwListaFactura.Items.Add(listViewFactura);
					}

					/*llamada al metodo*/
					this.calculoMatematico();
				}

			}// fin if

		}// fin btnAgregar

		private void btnPagar_Click(object sender, EventArgs e)
		{
			/*invoca a los metodos*/
			_Negocio.grabarXmlVenta("Consulta_Venta.xml", lstNegocio);
			/*Mensaje de exito*/
			MessageBox.Show("Pago realizado con Exito.");
		}

		private void calculoMatematico()
		{
			/*declaracion de variables para el calculo Matematico*/
			double subtotal = 0;
			double iva = 0.02; /*2%*/
			double total = 0;


			foreach (ListViewItem item in lvwListaFactura.Items) /*recorro los elementos de la listview*/
			{
				double monto = double.Parse(item.SubItems[3].Text);
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

		private void btnBuscarPacientePaciente_Click(object sender, EventArgs e)
		{
			try
			{
				string consultaId = txtTikedFactura.Text; /*obtengo el Id y se lo paso a una variable*/
				XmlDocument xmlDoc = new XmlDocument(); /*instancia del objeto*/
				xmlDoc.Load("Padres.xml"); /*Cargo el Documento*/

				XmlNode xmlNodoHijo = xmlDoc.SelectSingleNode($"//Hijo[Id='{consultaId}']");
				/* se realiza la busqueda en todos los nodos "Hijo /
				 * [Id='{consultaID}'] exprecion de busqueda con un valor igual al de la variable consultaId  "*/
				if (xmlNodoHijo != null)
				{
					/*obtengo la fecha de nacimento del nodo */
					Hijo _hijo = new Hijo(DateTime.Parse(xmlNodoHijo.SelectSingleNode("FechaNacimiento").InnerText));
					/*Metodos para calcular la edad*/
					int edadAnios = _hijo.edadAnio;
					int edadMeses = _hijo.edadMeses;

					ListViewItem itemHijo = new ListViewItem(numeroTiked.ToString());
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("Id").InnerText);
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("Nombre").InnerText);
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("ApellidoPrimero").InnerText);
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("ApellidoSegundo").InnerText);
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("FechaNacimiento").InnerText);
					itemHijo.SubItems.Add(edadAnios.ToString() + " años " + edadMeses.ToString() + " meses"); /*Imprimo la edad */
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("Genero").InnerText);
					itemHijo.SubItems.Add(xmlNodoHijo.SelectSingleNode("Telefono").InnerText);
					/*imprimo los valores en la lista*/
					lvwListaTikedFactura.Items.Add(itemHijo);
					/*incremento de la variable*/
					numeroTiked++;
					/*Mensaje de exito*/
					MessageBox.Show("Tiked Generado con exito para el paceiente con el Id:" + txtTikedFactura.Text);
				}
				else
				{
					MessageBox.Show("No existe un paceiente con el Id:" + txtTikedFactura.Text);
				}
			}
			catch (Exception ex)
			{
				/*mensaje de error*/
				MessageBox.Show(ex.Message, "Error al cargar al paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnBuscarTiked_Click(object sender, EventArgs e)
		{

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
