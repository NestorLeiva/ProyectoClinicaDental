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
        public frmPacientes()
        {
            InitializeComponent();
        }
        //   ------------------------------------------------------- Validaciones TextBox  -------------------------------------------------------
        private void txtIdentificacionPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!metodosValidaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El campo debe contener solo Numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
                 * realizo la validacion del metodo // valido que sea Distinto
                 * e.keychar es caracter que se le esta pasando al parametro 
                 * si el metodo SoloNumeros devuelve un true  se bloquan  los caracteres no validos
                 */
            }
        }

        private void txtNombrePadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // con el KeyPress valido el string en tiempo real
            if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("El campo debe contener solo Texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
                 * e.keychar.toString() convierto el caracter en string antes de ser enviado al metodo
                 * e.handled = true bloquea todos los caracteres no validos
                 */
            }

        }

        private void txtApellidoPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("El campo debe contener solo Texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //   ------------------------------------------------------- Validaciones TextBox  -------------------------------------------------------

        private void txtNombreHijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!metodosValidaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("El campo debe contener solo Texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellidoHijo_KeyPress(object sender, KeyPressEventArgs e)
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

        //   ------------------------------------------------------- Botones  -------------------------------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePadre.Text = "";
            txtApellidoPadre.Text = "";
            txtIdentificacionPadre.Text = "";
            cboSexoPadre.Text = "";
            lblResEdadPadre.Text = "";
            txtTelefonoPadre.Text = "";
            txtEmailPadre.Text = "";
            //- ---------------------------------------------
            txtNombreHijo.Text = "";
            txtApellidoHijo.Text = "";
            txtIdentificacionHijo.Text = "";
            lblResEdadHijo.Text = "";
            cboSexoHijo.Text = "";
            txtTelefonoHIjo.Text = "";
            txtEmailHijo.Text = "";
            //- ---------------------------------------------
            cboDireccionProvincia.Text = "";
            txtDireccionCanton.Text = "";
            txtDireccionDistrito.Text = "";
            txtDieccionOtrasSenas.Text = "";
        }

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
    } // fin frmPacientes : Form
} // fin ProyectoClinicaDental
