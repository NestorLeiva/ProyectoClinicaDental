namespace ProyectoClinicaDental
{
	partial class frmConsultaHistoria
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			gbConsulta = new GroupBox();
			btnBusqueda = new Button();
			txtIdentificacionPadreBusqueda = new TextBox();
			lblIdBusqueda = new Label();
			gbListaConsulta = new GroupBox();
			lvwConsultaHistorialPaciente = new ListView();
			btnModificar = new Button();
			lblModificar = new Label();
			gbConsulta.SuspendLayout();
			gbListaConsulta.SuspendLayout();
			SuspendLayout();
			// 
			// gbConsulta
			// 
			gbConsulta.Controls.Add(lblModificar);
			gbConsulta.Controls.Add(btnModificar);
			gbConsulta.Controls.Add(btnBusqueda);
			gbConsulta.Controls.Add(txtIdentificacionPadreBusqueda);
			gbConsulta.Controls.Add(lblIdBusqueda);
			gbConsulta.Dock = DockStyle.Top;
			gbConsulta.Location = new Point(0, 0);
			gbConsulta.Name = "gbConsulta";
			gbConsulta.Size = new Size(780, 85);
			gbConsulta.TabIndex = 65;
			gbConsulta.TabStop = false;
			// 
			// btnBusqueda
			// 
			btnBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnBusqueda.Location = new Point(528, 14);
			btnBusqueda.Name = "btnBusqueda";
			btnBusqueda.Size = new Size(118, 31);
			btnBusqueda.TabIndex = 2;
			btnBusqueda.Text = "Consultar";
			btnBusqueda.UseVisualStyleBackColor = true;
			// 
			// txtIdentificacionPadreBusqueda
			// 
			txtIdentificacionPadreBusqueda.Location = new Point(179, 19);
			txtIdentificacionPadreBusqueda.Name = "txtIdentificacionPadreBusqueda";
			txtIdentificacionPadreBusqueda.Size = new Size(343, 23);
			txtIdentificacionPadreBusqueda.TabIndex = 1;
			// 
			// lblIdBusqueda
			// 
			lblIdBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdBusqueda.Location = new Point(6, 19);
			lblIdBusqueda.Name = "lblIdBusqueda";
			lblIdBusqueda.Size = new Size(177, 23);
			lblIdBusqueda.TabIndex = 0;
			lblIdBusqueda.Text = "Buscar por Id ";
			// 
			// gbListaConsulta
			// 
			gbListaConsulta.Controls.Add(lvwConsultaHistorialPaciente);
			gbListaConsulta.Dock = DockStyle.Fill;
			gbListaConsulta.Location = new Point(0, 85);
			gbListaConsulta.Name = "gbListaConsulta";
			gbListaConsulta.Size = new Size(780, 659);
			gbListaConsulta.TabIndex = 66;
			gbListaConsulta.TabStop = false;
			// 
			// lvwConsultaHistorialPaciente
			// 
			lvwConsultaHistorialPaciente.Dock = DockStyle.Fill;
			lvwConsultaHistorialPaciente.GridLines = true;
			lvwConsultaHistorialPaciente.Location = new Point(3, 19);
			lvwConsultaHistorialPaciente.Name = "lvwConsultaHistorialPaciente";
			lvwConsultaHistorialPaciente.Size = new Size(774, 637);
			lvwConsultaHistorialPaciente.TabIndex = 0;
			lvwConsultaHistorialPaciente.UseCompatibleStateImageBehavior = false;
			lvwConsultaHistorialPaciente.View = View.Details;
			// 
			// btnModificar
			// 
			btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnModificar.Location = new Point(528, 50);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(118, 31);
			btnModificar.TabIndex = 3;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = true;
			// 
			// lblModificar
			// 
			lblModificar.AutoSize = true;
			lblModificar.Location = new Point(6, 60);
			lblModificar.Name = "lblModificar";
			lblModificar.Size = new Size(146, 15);
			lblModificar.TabIndex = 4;
			lblModificar.Text = "Marque la fila del paciente";
			// 
			// frmConsultaHistoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(780, 744);
			Controls.Add(gbListaConsulta);
			Controls.Add(gbConsulta);
			Name = "frmConsultaHistoria";
			Text = "Consulta Historial Paciente";
			gbConsulta.ResumeLayout(false);
			gbConsulta.PerformLayout();
			gbListaConsulta.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbConsulta;
		private Button btnBusqueda;
		private TextBox txtIdentificacionPadreBusqueda;
		private Label lblIdBusqueda;
		private GroupBox gbListaConsulta;
		private ListView lvwConsultaHistorialPaciente;
		private Label lblModificar;
		private Button btnModificar;
	}
}