namespace ProyectoClinicaDental
{
	partial class frmIngresoConsulta
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
			gbConsultaPaciente = new GroupBox();
			btnAgregarIdPaciente = new Button();
			txtIdentificacionPaciente = new TextBox();
			lblIdConsulta = new Label();
			gbConsultaTiked = new GroupBox();
			lblResTiked = new Label();
			lblTiked = new Label();
			dtpFechaConsulta = new DateTimePicker();
			lblFechaConsulta = new Label();
			gbConsultaPaciente.SuspendLayout();
			gbConsultaTiked.SuspendLayout();
			SuspendLayout();
			// 
			// gbConsultaPaciente
			// 
			gbConsultaPaciente.Controls.Add(btnAgregarIdPaciente);
			gbConsultaPaciente.Controls.Add(txtIdentificacionPaciente);
			gbConsultaPaciente.Controls.Add(lblIdConsulta);
			gbConsultaPaciente.Dock = DockStyle.Top;
			gbConsultaPaciente.Location = new Point(0, 0);
			gbConsultaPaciente.Name = "gbConsultaPaciente";
			gbConsultaPaciente.Size = new Size(595, 85);
			gbConsultaPaciente.TabIndex = 0;
			gbConsultaPaciente.TabStop = false;
			// 
			// btnAgregarIdPaciente
			// 
			btnAgregarIdPaciente.Location = new Point(411, 28);
			btnAgregarIdPaciente.Name = "btnAgregarIdPaciente";
			btnAgregarIdPaciente.Size = new Size(75, 23);
			btnAgregarIdPaciente.TabIndex = 2;
			btnAgregarIdPaciente.Text = "Agregar";
			btnAgregarIdPaciente.UseVisualStyleBackColor = true;
			// 
			// txtIdentificacionPaciente
			// 
			txtIdentificacionPaciente.Location = new Point(164, 28);
			txtIdentificacionPaciente.Name = "txtIdentificacionPaciente";
			txtIdentificacionPaciente.Size = new Size(232, 23);
			txtIdentificacionPaciente.TabIndex = 1;
			// 
			// lblIdConsulta
			// 
			lblIdConsulta.AutoSize = true;
			lblIdConsulta.Location = new Point(12, 36);
			lblIdConsulta.Name = "lblIdConsulta";
			lblIdConsulta.Size = new Size(146, 15);
			lblIdConsulta.TabIndex = 0;
			lblIdConsulta.Text = "Identificacion del Paciente";
			// 
			// gbConsultaTiked
			// 
			gbConsultaTiked.Controls.Add(lblFechaConsulta);
			gbConsultaTiked.Controls.Add(dtpFechaConsulta);
			gbConsultaTiked.Controls.Add(lblResTiked);
			gbConsultaTiked.Controls.Add(lblTiked);
			gbConsultaTiked.Dock = DockStyle.Fill;
			gbConsultaTiked.Location = new Point(0, 85);
			gbConsultaTiked.Name = "gbConsultaTiked";
			gbConsultaTiked.Size = new Size(595, 140);
			gbConsultaTiked.TabIndex = 1;
			gbConsultaTiked.TabStop = false;
			// 
			// lblResTiked
			// 
			lblResTiked.BackColor = SystemColors.ButtonShadow;
			lblResTiked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblResTiked.Location = new Point(90, 24);
			lblResTiked.Name = "lblResTiked";
			lblResTiked.Size = new Size(162, 39);
			lblResTiked.TabIndex = 1;
			lblResTiked.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTiked
			// 
			lblTiked.AutoSize = true;
			lblTiked.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblTiked.Location = new Point(12, 35);
			lblTiked.Name = "lblTiked";
			lblTiked.Size = new Size(39, 17);
			lblTiked.TabIndex = 0;
			lblTiked.Text = "Tiked";
			// 
			// dtpFechaConsulta
			// 
			dtpFechaConsulta.CustomFormat = "dd/MM/yyyy";
			dtpFechaConsulta.Format = DateTimePickerFormat.Custom;
			dtpFechaConsulta.Location = new Point(90, 90);
			dtpFechaConsulta.Name = "dtpFechaConsulta";
			dtpFechaConsulta.Size = new Size(200, 23);
			dtpFechaConsulta.TabIndex = 2;
			// 
			// lblFechaConsulta
			// 
			lblFechaConsulta.AutoSize = true;
			lblFechaConsulta.Location = new Point(13, 96);
			lblFechaConsulta.Name = "lblFechaConsulta";
			lblFechaConsulta.Size = new Size(38, 15);
			lblFechaConsulta.TabIndex = 3;
			lblFechaConsulta.Text = "Fecha";
			// 
			// frmIngresoConsulta
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(595, 225);
			Controls.Add(gbConsultaTiked);
			Controls.Add(gbConsultaPaciente);
			Name = "frmIngresoConsulta";
			Text = "Ingreso a Consulta";
			gbConsultaPaciente.ResumeLayout(false);
			gbConsultaPaciente.PerformLayout();
			gbConsultaTiked.ResumeLayout(false);
			gbConsultaTiked.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbConsultaPaciente;
		private Label lblIdConsulta;
		private Button btnAgregarIdPaciente;
		private TextBox txtIdentificacionPaciente;
		private GroupBox gbConsultaTiked;
		private Label lblTiked;
		private Label lblResTiked;
		private Label lblFechaConsulta;
		private DateTimePicker dtpFechaConsulta;
	}
}