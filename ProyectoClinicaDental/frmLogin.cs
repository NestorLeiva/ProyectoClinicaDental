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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            // pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            // pbLogo.Image = Image.FromFile(@"/ProyectoClinicaDental/ProyectoClinicaDental/img/logoClinica.png");

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
    }
}
