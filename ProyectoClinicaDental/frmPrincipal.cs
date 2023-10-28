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
			frmAcercaDe pantalla = new frmAcercaDe();
			this.cargarPantalla(pantalla);
		}

		private void mnVentas_Click(object sender, EventArgs e)
		{
			frmFacturacion pantalla = new frmFacturacion();
			this.cargarPantalla(pantalla);
		}

		private void mnLogin_Click(object sender, EventArgs e)
		{
			frmLogin pantalla = new frmLogin();
			this.cargarPantalla(pantalla);
		}

		private void mnRegistroPacientes_Click(object sender, EventArgs e)
		{
			frmPacientes pantalla = new frmPacientes();
			this.cargarPantalla(pantalla);
		}

		private void mnMantenimientoServicios_Click(object sender, EventArgs e)
		{
			frmMantenimientoServicios pantalla = new frmMantenimientoServicios();
			this.cargarPantalla(pantalla);
		}

		private void mnConsultaHistorial_Click(object sender, EventArgs e)
		{
			frmConsultaHistoria pantalla = new frmConsultaHistoria();
			this.cargarPantalla(pantalla);
		}

		private void registroNuevosFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFuncionarios pantalla = new frmFuncionarios();
			this.cargarPantalla(pantalla);
		}

		private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmReporteVentas pantalla = new frmReporteVentas();
			this.cargarPantalla(pantalla);
		}



		private void cargarPantalla(Form pantalla)
		{
			pantalla.MdiParent = this;
			pantalla.BackColor = BackColor;
			pantalla.Show();


		}

		private void mnCerrarSesion_Click(object sender, EventArgs e)
		{
			this.Close();
			/*cierro el formulario principal*/
			frmLogin frm_Login = new frmLogin();
			frm_Login.Show();

		}

		private void mnIngresoConsulta_Click(object sender, EventArgs e)
		{
			frmIngresoConsulta pantalla = new frmIngresoConsulta();
			this.cargarPantalla(pantalla);
		}
	}
}