﻿using BLL;
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
		Persona nPersona; // instancia de la clase persona
		Funcionario nFuncionario;
		public frmFuncionarios()
		{
			InitializeComponent();
			nPersona = new Persona(); // inicializacion de la instacia Persona
			nFuncionario = new Funcionario();
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
				else
				{
					// obtengo el string y es asignado al get&set de la clase persona
					nPersona.Nombre = txtNombreFuncionario.Text;
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
				else
				{
					nPersona.Apellido = txtApellidoFuncionario.Text;
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
				else
				{
					nPersona.Identificacion = Convert.ToInt32(txtIdentificacionFuncionario.Text);
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
				else
				{
					nPersona.Telefono = Convert.ToInt32(txtTelefonoFuncionario.Text);
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
				else
				{
					nPersona.Email = txtEmailFuncionario.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPuestoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
				else
				{
					nFuncionario.Puesto = txtPuestoFuncionario.Text;
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
				else
				{
					nFuncionario.Usuario = txtUsuarioFuncionario.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtContraseniaFuncionario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString())            {
				e.Handled = true;
			}
            else
            {
                nFuncionario.Contrasenia = txtContraseniaFuncionario.Text;
            }
        }

		//   -------------------------------------------------------  Botones  -------------------------------------------------------
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtNombreFuncionario.Text = "";
			txtApellidoFuncionario.Text = "";
			txtIdentificacionFuncionario.Text = "";
			lblResEdadFuncionario.Text = "";
			cboSexoFuncionario.Text = "";
			txtEmailFuncionario.Text = "";
			txtTelefonoFuncionario.Text = "";
			txtPuestoFuncionario.Text = "";
			txtUsuarioFuncionario.Text = "";
			txtContraseniaFuncionario.Text = "";
		}
		private void btnCancerlar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{

		}


	} // fin frmFuncionarios : Form
}
