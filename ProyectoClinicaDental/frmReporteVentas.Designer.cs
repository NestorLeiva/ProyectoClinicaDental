﻿namespace ProyectoClinicaDental
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
			gbListaFactura = new GroupBox();
			lvwReporteFacturas = new ListView();
			gbConsultaFactura = new GroupBox();
			btnConsultar = new Button();
			cboFechaReporteVentas = new ComboBox();
			lblConsultarFecha = new Label();
			gbListaFactura.SuspendLayout();
			gbConsultaFactura.SuspendLayout();
			SuspendLayout();
			// 
			// gbListaFactura
			// 
			gbListaFactura.Controls.Add(lvwReporteFacturas);
			gbListaFactura.Dock = DockStyle.Fill;
			gbListaFactura.Location = new Point(0, 0);
			gbListaFactura.Name = "gbListaFactura";
			gbListaFactura.Size = new Size(792, 550);
			gbListaFactura.TabIndex = 67;
			gbListaFactura.TabStop = false;
			// 
			// lvwReporteFacturas
			// 
			lvwReporteFacturas.Dock = DockStyle.Fill;
			lvwReporteFacturas.GridLines = true;
			lvwReporteFacturas.Location = new Point(3, 19);
			lvwReporteFacturas.Name = "lvwReporteFacturas";
			lvwReporteFacturas.Size = new Size(786, 528);
			lvwReporteFacturas.TabIndex = 0;
			lvwReporteFacturas.UseCompatibleStateImageBehavior = false;
			lvwReporteFacturas.View = View.Details;
			// 
			// gbConsultaFactura
			// 
			gbConsultaFactura.Controls.Add(btnConsultar);
			gbConsultaFactura.Controls.Add(cboFechaReporteVentas);
			gbConsultaFactura.Controls.Add(lblConsultarFecha);
			gbConsultaFactura.Dock = DockStyle.Top;
			gbConsultaFactura.Location = new Point(0, 0);
			gbConsultaFactura.Name = "gbConsultaFactura";
			gbConsultaFactura.Size = new Size(792, 100);
			gbConsultaFactura.TabIndex = 68;
			gbConsultaFactura.TabStop = false;
			// 
			// btnConsultar
			// 
			btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnConsultar.Location = new Point(433, 32);
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
			cboFechaReporteVentas.Size = new Size(245, 29);
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
			ClientSize = new Size(792, 550);
			Controls.Add(gbConsultaFactura);
			Controls.Add(gbListaFactura);
			Name = "frmReporteVentas";
			Text = "Reporte Ventas";
			gbListaFactura.ResumeLayout(false);
			gbConsultaFactura.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbListaFactura;
		private ListView lvwReporteFacturas;
		private GroupBox gbConsultaFactura;
		private Button btnConsultar;
		private ComboBox cboFechaReporteVentas;
		private Label lblConsultarFecha;
	}
}