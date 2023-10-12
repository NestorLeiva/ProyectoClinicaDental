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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

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
    }
}
