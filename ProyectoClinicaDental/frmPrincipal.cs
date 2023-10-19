namespace ProyectoClinicaDental
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{

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
			frmFacturacion ventanaFactura = new frmFacturacion();
			this.cargarPantalla(ventanaFactura);
		}

		private void mnLogin_Click(object sender, EventArgs e)
		{
			frmLogin ventanaLogin = new frmLogin();
			this.cargarPantalla(ventanaLogin);
		}

		private void mnRegistroPacientes_Click(object sender, EventArgs e)
		{
			frmPacientes ventanaPacientes = new frmPacientes();
			this.cargarPantalla(ventanaPacientes);
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

		private void registroNuevosFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFuncionarios ventanaFuncionarios = new frmFuncionarios();
			this.cargarPantalla(ventanaFuncionarios);
		}

		private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmReporteVentas ventanaReporte = new frmReporteVentas();
			this.cargarPantalla(ventanaReporte);
		}



		private void cargarPantalla(Form pantalla)
		{
			pantalla.MdiParent = this;
			pantalla.BackColor = BackColor;
			pantalla.Show();

		}


	}
}