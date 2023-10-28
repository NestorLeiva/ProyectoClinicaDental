namespace ProyectoClinicaDental
{
	partial class frmFacturacion
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
			lblNombreFactura = new Label();
			lblIdentificacionFactura = new Label();
			lblSubTotal = new Label();
			lblResSubTotal = new Label();
			lblTotal = new Label();
			lblIVA = new Label();
			lblResTotal = new Label();
			lblResIVA = new Label();
			txtIdentificacionFactura = new TextBox();
			btnPagar = new Button();
			btnCancelar = new Button();
			gbDatosFactura = new GroupBox();
			btnBuscarPacientePaciente = new Button();
			lblNombreFacturaPadre = new Label();
			gbListaFactura = new GroupBox();
			btnAgregar = new Button();
			cboServicio = new ComboBox();
			lblBuscarServicio = new Label();
			lvwListaFactura = new ListView();
			colCodigo = new ColumnHeader();
			colServicio = new ColumnHeader();
			colMonto = new ColumnHeader();
			gbTotalFactura = new GroupBox();
			gbDatosFactura.SuspendLayout();
			gbListaFactura.SuspendLayout();
			gbTotalFactura.SuspendLayout();
			SuspendLayout();
			// 
			// lblNombreFactura
			// 
			lblNombreFactura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombreFactura.Location = new Point(12, 64);
			lblNombreFactura.Name = "lblNombreFactura";
			lblNombreFactura.Size = new Size(135, 29);
			lblNombreFactura.TabIndex = 0;
			lblNombreFactura.Text = "Cliente";
			lblNombreFactura.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdentificacionFactura
			// 
			lblIdentificacionFactura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdentificacionFactura.Location = new Point(12, 18);
			lblIdentificacionFactura.Name = "lblIdentificacionFactura";
			lblIdentificacionFactura.Size = new Size(135, 37);
			lblIdentificacionFactura.TabIndex = 1;
			lblIdentificacionFactura.Text = "Identificacion";
			lblIdentificacionFactura.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSubTotal
			// 
			lblSubTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblSubTotal.Location = new Point(6, 19);
			lblSubTotal.Name = "lblSubTotal";
			lblSubTotal.Size = new Size(100, 23);
			lblSubTotal.TabIndex = 4;
			lblSubTotal.Text = "SubTotal";
			lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblResSubTotal
			// 
			lblResSubTotal.BackColor = SystemColors.ActiveBorder;
			lblResSubTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblResSubTotal.Location = new Point(112, 19);
			lblResSubTotal.Name = "lblResSubTotal";
			lblResSubTotal.Size = new Size(100, 23);
			lblResSubTotal.TabIndex = 5;
			lblResSubTotal.Text = "0.0";
			lblResSubTotal.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblTotal.Location = new Point(262, 19);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(100, 23);
			lblTotal.TabIndex = 6;
			lblTotal.Text = "Total";
			lblTotal.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIVA
			// 
			lblIVA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblIVA.Location = new Point(6, 61);
			lblIVA.Name = "lblIVA";
			lblIVA.Size = new Size(100, 23);
			lblIVA.TabIndex = 7;
			lblIVA.Text = "IVA 2%";
			lblIVA.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblResTotal
			// 
			lblResTotal.BackColor = SystemColors.ActiveBorder;
			lblResTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblResTotal.Location = new Point(368, 19);
			lblResTotal.Name = "lblResTotal";
			lblResTotal.Size = new Size(111, 23);
			lblResTotal.TabIndex = 8;
			lblResTotal.Text = "0.0";
			lblResTotal.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblResIVA
			// 
			lblResIVA.BackColor = SystemColors.ActiveBorder;
			lblResIVA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblResIVA.Location = new Point(112, 61);
			lblResIVA.Name = "lblResIVA";
			lblResIVA.Size = new Size(100, 23);
			lblResIVA.TabIndex = 9;
			lblResIVA.Text = "0.0";
			lblResIVA.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtIdentificacionFactura
			// 
			txtIdentificacionFactura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionFactura.Location = new Point(153, 21);
			txtIdentificacionFactura.MaxLength = 10;
			txtIdentificacionFactura.Name = "txtIdentificacionFactura";
			txtIdentificacionFactura.Size = new Size(218, 33);
			txtIdentificacionFactura.TabIndex = 1;
			// 
			// btnPagar
			// 
			btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnPagar.Location = new Point(262, 61);
			btnPagar.Name = "btnPagar";
			btnPagar.Size = new Size(100, 31);
			btnPagar.TabIndex = 4;
			btnPagar.Text = "Pagar";
			btnPagar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancelar.Location = new Point(369, 61);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(111, 31);
			btnCancelar.TabIndex = 5;
			btnCancelar.Text = "Cancerlar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// gbDatosFactura
			// 
			gbDatosFactura.Controls.Add(btnBuscarPacientePaciente);
			gbDatosFactura.Controls.Add(lblNombreFacturaPadre);
			gbDatosFactura.Controls.Add(lblNombreFactura);
			gbDatosFactura.Controls.Add(lblIdentificacionFactura);
			gbDatosFactura.Controls.Add(txtIdentificacionFactura);
			gbDatosFactura.Dock = DockStyle.Top;
			gbDatosFactura.Location = new Point(0, 0);
			gbDatosFactura.Name = "gbDatosFactura";
			gbDatosFactura.Size = new Size(548, 103);
			gbDatosFactura.TabIndex = 19;
			gbDatosFactura.TabStop = false;
			// 
			// btnBuscarPacientePaciente
			// 
			btnBuscarPacientePaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnBuscarPacientePaciente.Location = new Point(406, 24);
			btnBuscarPacientePaciente.Name = "btnBuscarPacientePaciente";
			btnBuscarPacientePaciente.Size = new Size(73, 30);
			btnBuscarPacientePaciente.TabIndex = 17;
			btnBuscarPacientePaciente.Text = "Buscar";
			btnBuscarPacientePaciente.UseVisualStyleBackColor = true;
			// 
			// lblNombreFacturaPadre
			// 
			lblNombreFacturaPadre.BackColor = SystemColors.ButtonShadow;
			lblNombreFacturaPadre.Location = new Point(153, 60);
			lblNombreFacturaPadre.Name = "lblNombreFacturaPadre";
			lblNombreFacturaPadre.Size = new Size(218, 33);
			lblNombreFacturaPadre.TabIndex = 16;
			lblNombreFacturaPadre.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// gbListaFactura
			// 
			gbListaFactura.Controls.Add(btnAgregar);
			gbListaFactura.Controls.Add(cboServicio);
			gbListaFactura.Controls.Add(lblBuscarServicio);
			gbListaFactura.Controls.Add(lvwListaFactura);
			gbListaFactura.Dock = DockStyle.Fill;
			gbListaFactura.Location = new Point(0, 103);
			gbListaFactura.Name = "gbListaFactura";
			gbListaFactura.Size = new Size(548, 504);
			gbListaFactura.TabIndex = 20;
			gbListaFactura.TabStop = false;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(406, 10);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(73, 23);
			btnAgregar.TabIndex = 3;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// cboServicio
			// 
			cboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
			cboServicio.FormattingEnabled = true;
			cboServicio.Location = new Point(164, 11);
			cboServicio.Name = "cboServicio";
			cboServicio.Size = new Size(236, 23);
			cboServicio.TabIndex = 2;
			// 
			// lblBuscarServicio
			// 
			lblBuscarServicio.AutoSize = true;
			lblBuscarServicio.Location = new Point(12, 19);
			lblBuscarServicio.Name = "lblBuscarServicio";
			lblBuscarServicio.Size = new Size(146, 15);
			lblBuscarServicio.TabIndex = 1;
			lblBuscarServicio.Text = "Agregar Servicio a la Venta";
			lblBuscarServicio.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lvwListaFactura
			// 
			lvwListaFactura.Columns.AddRange(new ColumnHeader[] { colCodigo, colServicio, colMonto });
			lvwListaFactura.GridLines = true;
			lvwListaFactura.Location = new Point(6, 40);
			lvwListaFactura.Name = "lvwListaFactura";
			lvwListaFactura.Size = new Size(509, 318);
			lvwListaFactura.TabIndex = 0;
			lvwListaFactura.UseCompatibleStateImageBehavior = false;
			lvwListaFactura.View = View.Details;
			// 
			// colCodigo
			// 
			colCodigo.Text = "Codigo";
			colCodigo.Width = 100;
			// 
			// colServicio
			// 
			colServicio.Text = "Servicio";
			colServicio.Width = 200;
			// 
			// colMonto
			// 
			colMonto.Text = "Monto";
			colMonto.Width = 100;
			// 
			// gbTotalFactura
			// 
			gbTotalFactura.Controls.Add(lblSubTotal);
			gbTotalFactura.Controls.Add(lblResSubTotal);
			gbTotalFactura.Controls.Add(lblTotal);
			gbTotalFactura.Controls.Add(btnCancelar);
			gbTotalFactura.Controls.Add(lblIVA);
			gbTotalFactura.Controls.Add(btnPagar);
			gbTotalFactura.Controls.Add(lblResTotal);
			gbTotalFactura.Controls.Add(lblResIVA);
			gbTotalFactura.Dock = DockStyle.Bottom;
			gbTotalFactura.Location = new Point(0, 506);
			gbTotalFactura.Name = "gbTotalFactura";
			gbTotalFactura.Size = new Size(548, 101);
			gbTotalFactura.TabIndex = 21;
			gbTotalFactura.TabStop = false;
			// 
			// frmFacturacion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(548, 607);
			Controls.Add(gbTotalFactura);
			Controls.Add(gbListaFactura);
			Controls.Add(gbDatosFactura);
			MaximumSize = new Size(564, 646);
			Name = "frmFacturacion";
			Text = "Facturacion";
			gbDatosFactura.ResumeLayout(false);
			gbDatosFactura.PerformLayout();
			gbListaFactura.ResumeLayout(false);
			gbListaFactura.PerformLayout();
			gbTotalFactura.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label lblNombreFactura;
		private Label lblIdentificacionFactura;
		private Label lblSubTotal;
		private Label lblResSubTotal;
		private Label lblTotal;
		private Label lblIVA;
		private Label lblResTotal;
		private Label lblResIVA;
		private TextBox txtIdentificacionFactura;
		private Button btnPagar;
		private Button btnCancelar;
		private GroupBox gbDatosFactura;
		private GroupBox gbListaFactura;
		private ListView lvwListaFactura;
		private GroupBox gbTotalFactura;
		private Label lblNombreFacturaPadre;
		private Button btnAgregar;
		private ComboBox cboServicio;
		private Label lblBuscarServicio;
		private ColumnHeader colCodigo;
		private ColumnHeader colServicio;
		private ColumnHeader colMonto;
		private Button btnBuscarPacientePaciente;
	}
}