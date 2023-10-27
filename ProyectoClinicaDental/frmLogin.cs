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
	public partial class frmLogin : Form
	{
		Funcionario nFuncionario;// inicializacion de la clase
		public frmLogin()
		{
			InitializeComponent();
			nFuncionario = new Funcionario();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtUsuario.Text = "";
			txtContrasenia.Text = "";
		}

		private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				List<Funcionario> funcionarios = Funcionario.LeerFuncionariosDesdeXML("Funcionarios.xml");
				// realiza la comprobación de inicio de sesión con la lista de funcionarios

				string usuarios = txtUsuario.Text.ToUpper();
				string contrasenia = txtContrasenia.Text.ToUpper();
				/*Obtengo los valores ingresados en, txtUsuario y txtContrasenia, y se almacenan en las variables usuarios y contrasenia. \
				 * Estos valores representan el nombre de usuario y la contraseña que el usuario ha ingresado en la interfaz.*/

				foreach (Funcionario funcionario in funcionarios)
				{
					if (funcionario.Usuario == usuarios && funcionario.Contrasenia == contrasenia)
					{
						/* Para cada Funcionario en la lista, se compara el nombre de usuario (funcionario.Usuario) y la contraseña (funcionario.Contrasenia)
						 * con los valores ingresados por el usuario (usuarios y contrasenia).*/
						MessageBox.Show("Inicio de Sesión Exitoso", "Clinica Dental Happy Teeth");
						/*mensaje de exito*/

						frmPrincipal frm_Principal = new frmPrincipal(); /*objeto del frmPrincipal*/
						frm_Principal.Show(); /*muestro la pantalla principal*/
						this.Hide();/* oculto la pantalla*/

						return;
					}
				}
				MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
				/*Mensaje de Inicio de Sesión Exitoso*/
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Login Clinica Dental Happy Teeth", MessageBoxButtons.OK, MessageBoxIcon.Error);
				/*Mensaje de Credenciales Incorrectas*/
			}

		}
	}
}
