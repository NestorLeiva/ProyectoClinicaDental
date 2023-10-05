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
            this.cargarPantalla(ventanaAcercade);
        }

        private void mnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventanaVenta = new frmVentas();
            this.cargarPantalla(ventanaVenta);
        }

        private void mnLogin_Click(object sender, EventArgs e)
        {
            frmLogin ventanaLogin = new frmLogin();
            this.cargarPantalla(ventanaLogin);
        }

        private void mnRegistroPacientes_Click(object sender, EventArgs e)
        {
            frmRegistroPacientes ventanaRegistroPacientes = new frmRegistroPacientes();
            this.cargarPantalla(ventanaRegistroPacientes);
        }

        private void mnMantenimientoServicios_Click(object sender, EventArgs e)
        {
            frmMantenimientoServicios ventanaMantenimientoServicios = new frmMantenimientoServicios();
            this.cargarPantalla(ventanaMantenimientoServicios);
        }

        private void mnConsultaHistorial_Click(object sender, EventArgs e)
        {
            frmConsultaHistoria ventantaConsultaHistorial = new frmConsultaHistoria();
            this.cargarPantalla(ventantaConsultaHistorial);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void cargarPantalla(Form pantalla) 
        { 
            pantalla.MdiParent = this;
            pantalla.BackColor = BackColor;
            pantalla.Show();

        }
    }
}