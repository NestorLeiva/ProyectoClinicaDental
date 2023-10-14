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

        //   ------------------------------------------------------- Validaciones Botones  -------------------------------------------------------
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
