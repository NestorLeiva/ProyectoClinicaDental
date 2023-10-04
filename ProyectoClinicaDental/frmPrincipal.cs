namespace ProyectoClinicaDental
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventanaAcercade = new frmAcercaDe();
            ventanaAcercade.MdiParent = this;
            ventanaAcercade.Show();
        }

        private void mnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventanaVenta = new frmVentas();
            ventanaVenta.MdiParent = this;
            ventanaVenta.Show();
        }

        private void mnLogin_Click(object sender, EventArgs e)
        {
            frmLogin ventanaLogin = new frmLogin();
            ventanaLogin.MdiParent = this;
            ventanaLogin.Show();
        }

        private void mnRegistroPacientes_Click(object sender, EventArgs e)
        {
            frmRegistroPacientes ventanaRegistroPacientes = new frmRegistroPacientes();
            ventanaRegistroPacientes.MdiParent = this;
            ventanaRegistroPacientes.Show();
        }

        private void mnMantenimientoServicios_Click(object sender, EventArgs e)
        {
            frmMantenimientoServicios ventanaMantenimientoServicios = new frmMantenimientoServicios();
            ventanaMantenimientoServicios.MdiParent = this;
            ventanaMantenimientoServicios.Show();
        }

        private void mnConsultaHistorial_Click(object sender, EventArgs e)
        {
            frmConsultaHistoria ventantaConsultaHistorial = new frmConsultaHistoria();
            ventantaConsultaHistorial.MdiParent = this;
            ventantaConsultaHistorial.Show();
        }
    }
}