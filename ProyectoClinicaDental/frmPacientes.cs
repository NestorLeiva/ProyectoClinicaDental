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
    }
}
