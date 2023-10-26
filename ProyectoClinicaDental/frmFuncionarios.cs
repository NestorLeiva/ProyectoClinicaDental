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
using Utils;

namespace ProyectoClinicaDental
{
	public partial class frmFuncionarios : Form
	{

		Funcionario nFuncionario;// instancia de la clase
		public frmFuncionarios()
		{
			InitializeComponent();
		}

		private void frmFuncionarios_Load(object sender, EventArgs e) { }
		//   ------------------------------------------------------- Validaciones TextBox  -------------------------------------------------------
		private void txtNombreFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtApellidoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtIdentificacionFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloNumeros(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtTelefonoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloNumeros(e.KeyChar))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtEmailFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				string email = txtEmailFuncionario.Text + e.KeyChar;
				if (!metodosValidaciones.isEmail(email))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//   ------------------------------------------------------- Validaciones TextBox  -------------------------------------------------------
		private void txtPuestoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtUsuarioFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtContraseniaFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void txtBuscarIdFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		//   -------------------------------------------------------  Botones  -------------------------------------------------------
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				nFuncionario = new Funcionario() /* inicializacion de la clase Funcionario*/
				{
					Identificacion = Convert.ToInt32(this.txtIdentificacionFuncionario.Text),
					Nombre = this.txtNombreFuncionario.Text,
					Apellido = this.txtApellidoFuncionario.Text,
					Genero = (this.rbtnGeneroMFuncionario.Checked ? "M" : "F"),
					Telefono = Convert.ToInt32(this.txtTelefonoFuncionario.Text),
					Email = this.txtEmailFuncionario.Text,
					Puesto = this.txtPuestoFuncionario.Text,
					Usuario = this.txtUsuarioFuncionario.Text,
					Contrasenia = this.txtContraseniaFuncionario.Text
					/*se agregan los string */
				};

				nFuncionario.grabarXML("Funcionarios.xml");
				// ruta para escribir el XML
				MessageBox.Show("Se registro al Funcionario Exitosamente", "Registrar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
				// mensaje de exito 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Registrar Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// mensaje de error 
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtNombreFuncionario.Text = string.Empty;
			txtApellidoFuncionario.Text = string.Empty;
			txtIdentificacionFuncionario.Text = string.Empty;
			txtEmailFuncionario.Text = string.Empty;
			txtTelefonoFuncionario.Text = string.Empty;
			txtPuestoFuncionario.Text = string.Empty;
			txtUsuarioFuncionario.Text = string.Empty;
			txtContraseniaFuncionario.Text = string.Empty;
		}
		private void btnCancerlar_Click(object sender, EventArgs e)
		{
			this.Close();
		}



	} // fin frmFuncionarios : Form
}
