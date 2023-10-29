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
using System.Xml;
using DAL;

namespace ProyectoClinicaDental
{
	public partial class frmPacientes : Form
	{
		List<Hijo> lstHijos; // instancia de la clase padre
		Padre nPadre;
		private ArchivoXML _archivoXML;
		public frmPacientes()
		{
			InitializeComponent();
			_archivoXML = new ArchivoXML();
		}

		private void frmPacientes_Load(object sender, EventArgs e)
		{
			try
			{
				lstHijos = new List<Hijo>(); // inicializacion de la Lista Hijo
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Registrar Padre", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//   ------------------------------------------------------- Validaciones  Edad -------------------------------------------------------
		private void dtpFechaHijo_ValueChanged(object sender, EventArgs e) /*ValueChanged evento que se dispara al acceder al objeto*/
		{
			Hijo nHijo = new Hijo();
			try
			{
				nHijo.setFechaNacimiento(dtpFechaHijo.Value); /*asigno la fecha seleccionada en el DateTimePicker al objeto hijo.*/
				// Calcula la edad en años y meses
				int edadAnos = nHijo.edadAnio;
				int edadMeses = nHijo.edadMeses;
				/*se calcula la edad en años y meses utilizando las propiedades EdadAnos y EdadMeses de la clase */

				// Muestra la edad en el Label
				lblResEdadHijo.Text = $"{edadAnos} años y {edadMeses} meses";
				/*$ = cadena interpolada... permitiendo la combinacion de texto estatico y valores estaticos*/
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error al ingresar la Fecha de naciemiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//   ------------------------------------------------------- Validaciones TextBox Padre -------------------------------------------------------
		private void txtIdentificacionPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
				/* realizo la validacion del metodo // valido que sea Distinto
                 * e.keychar es caracter que se le esta pasando al parametro 
                 * si el metodo SoloNumeros devuelve un true  se bloquan  los caracteres no validos*/
			}
		}

		private void txtNombrePadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			// con el KeyPress valido el string en tiempo real
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
				/* e.keychar.toString() convierto el caracter en string antes de ser enviado al metodo
                 * e.handled = true bloquea todos los caracteres no validos */
			}
		}
		private void txtApellidoPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		private void txtApellidoSegundoPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}
		private void txtIdentificacionPadre_KeyPress_1(object sender, KeyPressEventArgs e)
		{
            if (!metodosValidaciones.soloNumeros(e.KeyChar))
            {
				e.Handled = true;
            }
        }


		private void txtTelefonoPadre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
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
		}

		//   ------------------------------------------------------- Validaciones TextBox Hijo  -------------------------------------------------------

		private void txtNombreHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		private void txtApellidoHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}
		private void txtApellidoPrimeroHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}
		private void txtIdentificacionHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtTelefonoHIjo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtEmailHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			string email = txtEmailPadre.Text + e.KeyChar;
			if (!metodosValidaciones.isEmail(email))
			{
				e.Handled = true;
			}
		}
		//   ------------------------------------------------------- Validaciones TextBox Direccion  -------------------------------------------------------
		private void txtDireccionCanton_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		private void txtDireccionDistrito_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		//   ------------------------------------------------------- Validaciones TextBox Busqueda  -------------------------------------------------------
		private void txtIdentificacionPadreBusqueda_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		//   ------------------------------------------------------- Botones  -------------------------------------------------------

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{

				Direccion nDireccion = new Direccion() /* inicializacion de la clase */
				{
					Provincia = this.cboDireccionProvincia.SelectedItem.ToString().ToUpper(), // selecciono el item del combobox
					Canton = this.txtDireccionCanton.Text.ToUpper(),
					Distrito = this.txtDireccionDistrito.Text.ToUpper(),
					OtrasSenas = this.txtDieccionOtrasSenas.Text.ToUpper()
				};

				nPadre = new Padre()// inicializacion de la clase  
				{
					Identificacion = Convert.ToInt32(this.txtIdentificacionPadre.Text.Replace("-", string.Empty)),
					Nombre = this.txtNombrePadre.Text.ToUpper(),
					ApellidoPrimero = this.txtApellidoPrimeroPadre.Text.ToUpper(),
					ApellidoSegundo = this.txtApellidoSegundoPadre.Text.ToUpper(),
					Genero = (this.rbtnGeneroMPadre.Checked ? "M" : "F"),
					Telefono = Convert.ToInt32(this.txtTelefonoPadre.Text),
					Email = this.txtEmailPadre.Text.ToLower(),
					/* ------------------------------------------ direccion -------------------------------------------------------*/
					nDireccion = nDireccion, // accedo al metodo y le asigno los datos 
					/* ------------------------------------------   Hijos   ------------------------------------------------------- */
					Hijos = this.lstHijos // agrego a la lista

				};

				// ruta relativa para archivo xml + nombre
				nPadre.GrabarXML("Padres.xml");
				MessageBox.Show("Se registro al Padre / Paciente Exitosamente", "Registrar Padre / Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
				// mensaje de exito 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Registrar Padre / Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// mensaje de error 
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				Hijo _iHijo = new Hijo()
				{
					Identificacion = Convert.ToInt32(this.txtIdentificacionHijo.Text),
					Nombre = this.txtNombreHijo.Text.ToUpper(),
					ApellidoPrimero = this.txtApellidoPrimeroHijo.Text.ToUpper(),
					ApellidoSegundo = this.txtApellidoSegundoHijo.Text.ToUpper(),
					Genero = (this.rbtnGeneroMHijo.Checked ? "M" : "F"),
					fechaNaciemiento = this.dtpFechaHijo.Value.Date,
					Telefono = Convert.ToInt32(this.txtTelefonoHIjo.Text),
				};
				// agrego los hijos a la lista
				this.lstHijos.Add(_iHijo);
				/*Mensaje de exito*/
				MessageBox.Show("Se agrego la informacion del Hijo Exitosamente.");
			}
			catch (Exception ex)
			{
				/*Mensaje de error*/
				MessageBox.Show(ex.Message, "Ocurrio un problema con la informacion ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			/*realizar la limpieza general de los TextBox*/
			txtNombrePadre.Text = string.Empty;
			txtApellidoPrimeroPadre.Text = string.Empty;
			txtApellidoSegundoPadre.Text = string.Empty;
			txtIdentificacionPadre.Text = string.Empty;
			txtTelefonoPadre.Text = string.Empty;
			txtEmailPadre.Text = string.Empty;
			//- ---------------------------------------------
			txtNombreHijo.Text = string.Empty;
			txtApellidoPrimeroHijo.Text = string.Empty;
			txtApellidoSegundoHijo.Text = string.Empty;
			txtIdentificacionHijo.Text = string.Empty; ;
			lblResEdadHijo.Text = string.Empty;
			txtTelefonoHIjo.Text = string.Empty;
			//- ---------------------------------------------
			txtDireccionCanton.Text = string.Empty;
			txtDireccionDistrito.Text = string.Empty;
			txtDieccionOtrasSenas.Text = string.Empty;
		}


	} // fin frmPacientes : Form
} // fin ProyectoClinicaDental
