using BLL;
using Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinicaDental
{
	public partial class frmPacientes : Form
	{
		Padre nPadre;   // instancia de la clase padre
		Hijo nHijo;     // instancia de la clase hijo
		Direccion nDireccion; // instancia de la clase direccion

		public frmPacientes()
		{
			InitializeComponent();
			nPadre = new Padre();   // inicializacion de la clase 
			nHijo = new Hijo();     // inicializacion de la clase 
			nDireccion = new Direccion(); // inicializacion de la clase 
		}
		//   ------------------------------------------------------- Validaciones TextBox Padre -------------------------------------------------------
		private void txtIdentificacionPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("El campo debe contener solo Numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				/* realizo la validacion del metodo // valido que sea Distinto
                 * e.keychar es caracter que se le esta pasando al parametro 
                 * si el metodo SoloNumeros devuelve un true  se bloquan  los caracteres no validos
                 */
			}
			else
			{
				nPadre.Identificacion = Convert.ToInt32(txtIdentificacionPadre.Text);
			}
		}

		private void txtNombrePadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			// con el KeyPress valido el string en tiempo real
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
				MessageBox.Show("El campo debe contener solo Texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				/* e.keychar.toString() convierto el caracter en string antes de ser enviado al metodo
                 * e.handled = true bloquea todos los caracteres no validos */
			}
			else
			{
				nPadre.Nombre = txtNombrePadre.Text;
			}
		}

		private void txtApellidoPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
				MessageBox.Show("El campo debe contener solo Texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				nPadre.Apellido = txtApellidoPadre.Text;
			}
		}

		private void txtTelefonoPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				nPadre.Telefono = Convert.ToInt32(txtTelefonoPadre);
			}
		}
		private void txtEmailPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			string email = txtEmailPadre.Text + e.KeyChar;
			// Agrego el carácter presionado al  TextBox
			if (!metodosValidaciones.isEmail(email))
			{
				e.Handled = true;
			}
			else
			{
				nPadre.Email = txtEmailPadre.Text;

			}
		}

		//   ------------------------------------------------------- Validaciones TextBox Hijo  -------------------------------------------------------

		private void txtNombreHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
				MessageBox.Show("El campo debe contener solo Texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				nHijo.Nombre = txtNombreHijo.Text;
			}
		}

		private void txtApellidoHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
			else
			{
				nHijo.Apellido = txtApellidoHijo.Text;
			}
		}
		private void txtIdentificacionHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				nHijo.Identificacion = Convert.ToInt32(txtIdentificacionHijo.Text);
			}
		}

		private void txtTelefonoHIjo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				nHijo.Telefono = Convert.ToInt32(txtTelefonoHIjo.Text);
			}
		}

		private void txtEmailHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			string email = txtEmailPadre.Text + e.KeyChar;
			if (!metodosValidaciones.isEmail(email))
			{
				e.Handled = true;
			}
			else
			{
				nHijo.Email = txtEmailHijo.Text;
			}
		}

		//   ------------------------------------------------------- Validaciones TextBox Direccion  -------------------------------------------------------
		private void txtDireccionCanton_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
			else
			{
				nDireccion.Canton = txtDireccionCanton.Text;
			}
		}

		private void txtDireccionDistrito_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
			else
			{
				nDireccion.Distrito = txtDireccionDistrito.Text;
			}
		}

		private void txtDieccionOtrasSenas_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
			else
			{
				nDireccion.OtrasSenas = txtDieccionOtrasSenas.Text;
			}
		}
		//   ------------------------------------------------------- Validaciones TextBox Busqueda  -------------------------------------------------------
		private void txtIdentificacionPadreBusqueda_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				nPadre.Identificacion = Convert.ToInt32(txtIdentificacionPadre);
			}
		}
		//   ------------------------------------------------------- Botones  -------------------------------------------------------
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtNombrePadre.Text = "";
			txtApellidoPadre.Text = "";
			txtIdentificacionPadre.Text = "";

			lblResEdadPadre.Text = "";
			txtTelefonoPadre.Text = "";
			txtEmailPadre.Text = "";
			//- ---------------------------------------------
			txtNombreHijo.Text = "";
			txtApellidoHijo.Text = "";
			txtIdentificacionHijo.Text = "";
			lblResEdadHijo.Text = "";

			txtTelefonoHIjo.Text = "";
			txtEmailHijo.Text = "";
			//- ---------------------------------------------
			cboDireccionProvincia.Text = "";
			txtDireccionCanton.Text = "";
			txtDireccionDistrito.Text = "";
			txtDieccionOtrasSenas.Text = "";
		}

		private void gbDatosPadre_Enter(object sender, EventArgs e)
		{

		}
	} // fin frmPacientes : Form
} // fin ProyectoClinicaDental
