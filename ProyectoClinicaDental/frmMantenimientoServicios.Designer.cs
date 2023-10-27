namespace ProyectoClinicaDental
{
	partial class frmMantenimientoServicios
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
			gbServicios = new GroupBox();
			btnActualiza = new Button();
			txtCodigoServicio = new TextBox();
			lblCodigo = new Label();
			btnLimpiar = new Button();
			btnAgregar = new Button();
			txtMontoServicio = new TextBox();
			txtNombreServicio = new TextBox();
			lblCostoServicio = new Label();
			lblNobreServicio = new Label();
			lvwServicios = new ListView();
			colCodigo = new ColumnHeader();
			colNombreServicio = new ColumnHeader();
			ColMonto = new ColumnHeader();
			gbServicios.SuspendLayout();
			SuspendLayout();
			// 
			// gbServicios
			// 
			gbServicios.Controls.Add(btnActualiza);
			gbServicios.Controls.Add(txtCodigoServicio);
			gbServicios.Controls.Add(lblCodigo);
			gbServicios.Controls.Add(btnLimpiar);
			gbServicios.Controls.Add(btnAgregar);
			gbServicios.Controls.Add(txtMontoServicio);
			gbServicios.Controls.Add(txtNombreServicio);
			gbServicios.Controls.Add(lblCostoServicio);
			gbServicios.Controls.Add(lblNobreServicio);
			gbServicios.Dock = DockStyle.Top;
			gbServicios.Location = new Point(0, 0);
			gbServicios.Name = "gbServicios";
			gbServicios.Size = new Size(519, 156);
			gbServicios.TabIndex = 0;
			gbServicios.TabStop = false;
			gbServicios.Text = "Ingreso de Nuevos Servicios";
			// 
			// btnActualiza
			// 
			btnActualiza.Location = new Point(431, 122);
			btnActualiza.Name = "btnActualiza";
			btnActualiza.Size = new Size(75, 23);
			btnActualiza.TabIndex = 6;
			btnActualiza.Text = "Actualizar";
			btnActualiza.UseVisualStyleBackColor = true;
			btnActualiza.Click += btnActualiza_Click;
			// 
			// txtCodigoServicio
			// 
			txtCodigoServicio.Location = new Point(133, 22);
			txtCodigoServicio.Name = "txtCodigoServicio";
			txtCodigoServicio.Size = new Size(215, 23);
			txtCodigoServicio.TabIndex = 1;
			txtCodigoServicio.TextAlign = HorizontalAlignment.Center;
			// 
			// lblCodigo
			// 
			lblCodigo.AutoSize = true;
			lblCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblCodigo.Location = new Point(23, 28);
			lblCodigo.Name = "lblCodigo";
			lblCodigo.Size = new Size(100, 17);
			lblCodigo.TabIndex = 6;
			lblCodigo.Text = "Codigo Servicio";
			lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Location = new Point(273, 122);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(75, 23);
			btnLimpiar.TabIndex = 5;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(10, 122);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(75, 23);
			btnAgregar.TabIndex = 4;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// txtMontoServicio
			// 
			txtMontoServicio.Location = new Point(133, 83);
			txtMontoServicio.Name = "txtMontoServicio";
			txtMontoServicio.Size = new Size(215, 23);
			txtMontoServicio.TabIndex = 3;
			txtMontoServicio.TextAlign = HorizontalAlignment.Center;
			txtMontoServicio.KeyPress += txtCostoServicio_KeyPress;
			// 
			// txtNombreServicio
			// 
			txtNombreServicio.Location = new Point(133, 51);
			txtNombreServicio.Name = "txtNombreServicio";
			txtNombreServicio.Size = new Size(215, 23);
			txtNombreServicio.TabIndex = 2;
			txtNombreServicio.TextAlign = HorizontalAlignment.Center;
			txtNombreServicio.KeyPress += txtNombreServicio_KeyPress;
			// 
			// lblCostoServicio
			// 
			lblCostoServicio.AutoSize = true;
			lblCostoServicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblCostoServicio.Location = new Point(10, 89);
			lblCostoServicio.Name = "lblCostoServicio";
			lblCostoServicio.Size = new Size(113, 17);
			lblCostoServicio.TabIndex = 1;
			lblCostoServicio.Text = "Costo del Servicio";
			lblCostoServicio.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblNobreServicio
			// 
			lblNobreServicio.AutoSize = true;
			lblNobreServicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblNobreServicio.Location = new Point(17, 57);
			lblNobreServicio.Name = "lblNobreServicio";
			lblNobreServicio.Size = new Size(106, 17);
			lblNobreServicio.TabIndex = 0;
			lblNobreServicio.Text = "Nombre Servicio";
			lblNobreServicio.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lvwServicios
			// 
			lvwServicios.Columns.AddRange(new ColumnHeader[] { colCodigo, colNombreServicio, ColMonto });
			lvwServicios.Dock = DockStyle.Fill;
			lvwServicios.Location = new Point(0, 156);
			lvwServicios.Name = "lvwServicios";
			lvwServicios.Size = new Size(519, 295);
			lvwServicios.TabIndex = 7;
			lvwServicios.UseCompatibleStateImageBehavior = false;
			lvwServicios.View = View.Details;
			// 
			// colCodigo
			// 
			colCodigo.Text = "Codigo Servicio";
			colCodigo.Width = 100;
			// 
			// colNombreServicio
			// 
			colNombreServicio.Text = "Servicio";
			colNombreServicio.Width = 100;
			// 
			// ColMonto
			// 
			ColMonto.Text = "Monto sin IVA";
			ColMonto.Width = 100;
			// 
			// frmMantenimientoServicios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(519, 451);
			Controls.Add(lvwServicios);
			Controls.Add(gbServicios);
			MaximumSize = new Size(535, 490);
			Name = "frmMantenimientoServicios";
			Text = "Mantenimiento Servicios";
			Load += frmMantenimientoServicios_Load;
			gbServicios.ResumeLayout(false);
			gbServicios.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbServicios;
		private Label lblNobreServicio;
		private Button btnLimpiar;
		private Button btnAgregar;
		private TextBox txtMontoServicio;
		private TextBox txtNombreServicio;
		private Label lblCostoServicio;
		private TextBox txtCodigoServicio;
		private Label lblCodigo;
		private ListView lvwServicios;
		private ColumnHeader colCodigo;
		private ColumnHeader colNombreServicio;
		private ColumnHeader ColMonto;
		private Button btnActualiza;
	}
}