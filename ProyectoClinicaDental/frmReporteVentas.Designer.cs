namespace ProyectoClinicaDental
{
	partial class frmReporteVentas
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
			groupBox1 = new GroupBox();
			lvwReporteVentas = new ListView();
			groupBox2 = new GroupBox();
			btnConsultar = new Button();
			cboFechaReporteVentas = new ComboBox();
			lblConsultarFecha = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lvwReporteVentas);
			groupBox1.Location = new Point(12, 118);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(768, 647);
			groupBox1.TabIndex = 67;
			groupBox1.TabStop = false;
			// 
			// lvwReporteVentas
			// 
			lvwReporteVentas.Dock = DockStyle.Fill;
			lvwReporteVentas.GridLines = true;
			lvwReporteVentas.Location = new Point(3, 19);
			lvwReporteVentas.Name = "lvwReporteVentas";
			lvwReporteVentas.Size = new Size(762, 625);
			lvwReporteVentas.TabIndex = 0;
			lvwReporteVentas.UseCompatibleStateImageBehavior = false;
			lvwReporteVentas.View = View.Details;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnConsultar);
			groupBox2.Controls.Add(cboFechaReporteVentas);
			groupBox2.Controls.Add(lblConsultarFecha);
			groupBox2.Location = new Point(12, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(768, 100);
			groupBox2.TabIndex = 68;
			groupBox2.TabStop = false;
			// 
			// btnConsultar
			// 
			btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnConsultar.Location = new Point(355, 32);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(109, 29);
			btnConsultar.TabIndex = 2;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = true;
			// 
			// cboFechaReporteVentas
			// 
			cboFechaReporteVentas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cboFechaReporteVentas.FormattingEnabled = true;
			cboFechaReporteVentas.Items.AddRange(new object[] { "Dia", "Mes", "Anio" });
			cboFechaReporteVentas.Location = new Point(167, 32);
			cboFechaReporteVentas.Name = "cboFechaReporteVentas";
			cboFechaReporteVentas.Size = new Size(182, 29);
			cboFechaReporteVentas.TabIndex = 1;
			// 
			// lblConsultarFecha
			// 
			lblConsultarFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblConsultarFecha.Location = new Point(23, 32);
			lblConsultarFecha.Name = "lblConsultarFecha";
			lblConsultarFecha.Size = new Size(138, 23);
			lblConsultarFecha.TabIndex = 0;
			lblConsultarFecha.Text = "Fecha a Consultar";
			// 
			// frmReporteVentas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(796, 779);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "frmReporteVentas";
			Text = "Reporte Ventas";
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private ListView lvwReporteVentas;
		private GroupBox groupBox2;
		private Button btnConsultar;
		private ComboBox cboFechaReporteVentas;
		private Label lblConsultarFecha;
	}
}