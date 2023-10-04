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
    }
}