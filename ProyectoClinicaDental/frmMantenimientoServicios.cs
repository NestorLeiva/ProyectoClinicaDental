using BLL;
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
using Utils;

namespace ProyectoClinicaDental
{
	public partial class frmMantenimientoServicios : Form
	{
		List<Negocio> lstServicios;

		public frmMantenimientoServicios()
		{
			InitializeComponent();
		}

		private void frmMantenimientoServicios_Load(object sender, EventArgs e)
		{
			try
			{
				lstServicios = new List<Negocio>();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Registro Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		/* ---------------------------- Validaciones texbox --------------------------------------- */
		private void txtNombreServicio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		private void txtCostoServicio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				Negocio nNegocio = new Negocio() /*Agrego los servicios al XML*/
				{
					Codigo = this.txtCodigoServicio.Text.ToUpper(),
					NombreServicio = this.txtNombreServicio.Text.ToUpper(),
					Monto = Convert.ToInt32(this.txtMontoServicio.Text)
				};



				XmlDocument xmlExisteServicio = new XmlDocument();
				xmlExisteServicio.Load("Servicios.xml");

				XmlNode existeServicio = xmlExisteServicio.SelectSingleNode($"//Servicio[Codigo='{nNegocio.Codigo}']");
				/*Verifico si existe un servico con el mismo codigo*/

				if (existeServicio != null) {
					MessageBox.Show("El servicio con el mismo código ya existe.", "Agregar Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				/*Guardo el fichero con la ruta por defecto*/
				nNegocio.GrabarXMLservicios("Servicios.xml");

				/*Agrego a la lista */
				this.lstServicios.Add(nNegocio);


				/*Muestro en el listview los datos*/
				ListViewItem itemServico = new ListViewItem();
				itemServico.Text = nNegocio.Codigo.ToString();
				itemServico.SubItems.Add(nNegocio.NombreServicio);
				itemServico.SubItems.Add(nNegocio.Monto.ToString());
				/*agrego los datos de la lista al listview*/
				this.lvwServicios.Items.Add(itemServico);


				/*Mensaje de exito*/
				MessageBox.Show("Se agregaro el Servicio con Exito", "Ingreso de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				/*Mensaje de error*/
				MessageBox.Show(ex.Message, "Agregar Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnActualiza_Click(object sender, EventArgs e)
		{
			try
			{
				XmlDocument xmlDocServicios = new XmlDocument(); // instancia del objeto
				xmlDocServicios.Load("Servicios.xml"); //cargo el fichero
				XmlNodeList nodoServicios = xmlDocServicios.SelectNodes("//Servicio");//obtengo la lista de los nodos

				foreach (XmlNode lstMonto in nodoServicios)
				{
					ListViewItem itemServico = new ListViewItem(lstMonto.SelectSingleNode("Codigo").InnerText);
					itemServico.SubItems.Add(lstMonto.SelectSingleNode("NombreServicio").InnerText);
					itemServico.SubItems.Add(lstMonto.SelectSingleNode("Monto").InnerText);

					/*Agrego los datos a la lista*/
					lvwServicios.Items.Add(itemServico);
				}

			}
			catch (Exception ex)
			{
				/*mensaje de Error*/
				MessageBox.Show(ex.Message, "Lista de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtCodigoServicio.Text=string.Empty;
			txtNombreServicio.Text=string.Empty;
			txtMontoServicio.Text=string.Empty;
		}





		/* ---------------------------- Validaciones texbox --------------------------------------- */

	}
}
