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
			lblIdFactura = new Label();
			lblSubTotal = new Label();
			lblResSubTotal = new Label();
			lblTotal = new Label();
			lblIVA = new Label();
			lblResTotal = new Label();
			lblResIVA = new Label();
			txtTikedFactura = new TextBox();
			btnPagar = new Button();
			btnCancelar = new Button();
			gbDatosFactura = new GroupBox();
			lvwListaTikedFactura = new ListView();
			colTiked = new ColumnHeader();
			colIdentificacionTiked = new ColumnHeader();
			colNombreTiked = new ColumnHeader();
			colApellido1Tiked = new ColumnHeader();
			ColApelldio2Tiked = new ColumnHeader();
			colFechaNacimientoTiked = new ColumnHeader();
			ColEdadTiked = new ColumnHeader();
			colGeneroTiked = new ColumnHeader();
			ColTelefonoTiked = new ColumnHeader();
			btnBuscarPacientePaciente = new Button();
			gbListaFactura = new GroupBox();
			txtTikedId = new TextBox();
			lblTiked = new Label();
			btnAgregar = new Button();
			lblFechaFacura = new Label();
			cboServicio = new ComboBox();
			dtpFechaFactura = new DateTimePicker();
			lblBuscarServicio = new Label();
			lvwListaFactura = new ListView();
			colFechaFactura = new ColumnHeader();
			colCodigo = new ColumnHeader();
			colServicio = new ColumnHeader();
			colMonto = new ColumnHeader();
			gbTotalFactura = new GroupBox();
			btnBuscarTiked = new Button();
			gbDatosFactura.SuspendLayout();
			gbListaFactura.SuspendLayout();
			gbTotalFactura.SuspendLayout();
			SuspendLayout();
			// 
			// lblIdFactura
			// 
			lblIdFactura.AutoSize = true;
			lblIdFactura.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdFactura.Location = new Point(12, 19);
			lblIdFactura.Name = "lblIdFactura";
			lblIdFactura.Size = new Size(151, 15);
			lblIdFactura.TabIndex = 1;
			lblIdFactura.Text = "Buscar por ID del paciente";
			lblIdFactura.TextAlign = ContentAlignment.MiddleRight;
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
			// txtTikedFactura
			// 
			txtTikedFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			txtTikedFactura.Location = new Point(164, 12);
			txtTikedFactura.MaxLength = 10;
			txtTikedFactura.Name = "txtTikedFactura";
			txtTikedFactura.Size = new Size(127, 22);
			txtTikedFactura.TabIndex = 1;
			// 
			// btnPagar
			// 
			btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnPagar.Location = new Point(262, 61);
			btnPagar.Name = "btnPagar";
			btnPagar.Size = new Size(100, 31);
			btnPagar.TabIndex = 10;
			btnPagar.Text = "Pagar";
			btnPagar.UseVisualStyleBackColor = true;
			btnPagar.Click += btnPagar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancelar.Location = new Point(369, 61);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(111, 31);
			btnCancelar.TabIndex = 11;
			btnCancelar.Text = "Cancerlar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// gbDatosFactura
			// 
			gbDatosFactura.Controls.Add(lvwListaTikedFactura);
			gbDatosFactura.Controls.Add(btnBuscarPacientePaciente);
			gbDatosFactura.Controls.Add(lblIdFactura);
			gbDatosFactura.Controls.Add(txtTikedFactura);
			gbDatosFactura.Dock = DockStyle.Top;
			gbDatosFactura.Location = new Point(0, 0);
			gbDatosFactura.Name = "gbDatosFactura";
			gbDatosFactura.Size = new Size(533, 154);
			gbDatosFactura.TabIndex = 19;
			gbDatosFactura.TabStop = false;
			// 
			// lvwListaTikedFactura
			// 
			lvwListaTikedFactura.BackColor = SystemColors.Info;
			lvwListaTikedFactura.Columns.AddRange(new ColumnHeader[] { colTiked, colIdentificacionTiked, colNombreTiked, colApellido1Tiked, ColApelldio2Tiked, colFechaNacimientoTiked, ColEdadTiked, colGeneroTiked, ColTelefonoTiked });
			lvwListaTikedFactura.GridLines = true;
			lvwListaTikedFactura.Location = new Point(6, 44);
			lvwListaTikedFactura.Name = "lvwListaTikedFactura";
			lvwListaTikedFactura.Size = new Size(509, 98);
			lvwListaTikedFactura.TabIndex = 3;
			lvwListaTikedFactura.UseCompatibleStateImageBehavior = false;
			lvwListaTikedFactura.View = View.Details;
			// 
			// colTiked
			// 
			colTiked.Text = "Tiked";
			// 
			// colIdentificacionTiked
			// 
			colIdentificacionTiked.Text = "Identificacion";
			colIdentificacionTiked.Width = 100;
			// 
			// colNombreTiked
			// 
			colNombreTiked.Text = "Nombre";
			colNombreTiked.Width = 100;
			// 
			// colApellido1Tiked
			// 
			colApellido1Tiked.Text = "Primer Apellido";
			colApellido1Tiked.Width = 100;
			// 
			// ColApelldio2Tiked
			// 
			ColApelldio2Tiked.Text = "Segundo Apellido";
			ColApelldio2Tiked.Width = 100;
			// 
			// colFechaNacimientoTiked
			// 
			colFechaNacimientoTiked.Text = "Fecha Nacimiento";
			colFechaNacimientoTiked.Width = 100;
			// 
			// ColEdadTiked
			// 
			ColEdadTiked.Text = "Edad";
			// 
			// colGeneroTiked
			// 
			colGeneroTiked.Text = "Genero";
			// 
			// ColTelefonoTiked
			// 
			ColTelefonoTiked.Text = "Telefono";
			ColTelefonoTiked.Width = 100;
			// 
			// btnBuscarPacientePaciente
			// 
			btnBuscarPacientePaciente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBuscarPacientePaciente.Location = new Point(297, 12);
			btnBuscarPacientePaciente.Name = "btnBuscarPacientePaciente";
			btnBuscarPacientePaciente.Size = new Size(92, 26);
			btnBuscarPacientePaciente.TabIndex = 2;
			btnBuscarPacientePaciente.Text = "Buscar";
			btnBuscarPacientePaciente.UseVisualStyleBackColor = true;
			btnBuscarPacientePaciente.Click += btnBuscarPacientePaciente_Click;
			// 
			// gbListaFactura
			// 
			gbListaFactura.Controls.Add(btnBuscarTiked);
			gbListaFactura.Controls.Add(txtTikedId);
			gbListaFactura.Controls.Add(lblTiked);
			gbListaFactura.Controls.Add(btnAgregar);
			gbListaFactura.Controls.Add(lblFechaFacura);
			gbListaFactura.Controls.Add(cboServicio);
			gbListaFactura.Controls.Add(dtpFechaFactura);
			gbListaFactura.Controls.Add(lblBuscarServicio);
			gbListaFactura.Controls.Add(lvwListaFactura);
			gbListaFactura.Dock = DockStyle.Fill;
			gbListaFactura.Location = new Point(0, 154);
			gbListaFactura.Name = "gbListaFactura";
			gbListaFactura.Size = new Size(533, 507);
			gbListaFactura.TabIndex = 20;
			gbListaFactura.TabStop = false;
			// 
			// txtTikedId
			// 
			txtTikedId.Location = new Point(176, 14);
			txtTikedId.MaxLength = 100;
			txtTikedId.Name = "txtTikedId";
			txtTikedId.Size = new Size(162, 23);
			txtTikedId.TabIndex = 4;
			txtTikedId.KeyPress += textBox1_KeyPress;
			// 
			// lblTiked
			// 
			lblTiked.AutoSize = true;
			lblTiked.Location = new Point(135, 22);
			lblTiked.Name = "lblTiked";
			lblTiked.Size = new Size(35, 15);
			lblTiked.TabIndex = 6;
			lblTiked.Text = "Tiked";
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(454, 43);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(73, 23);
			btnAgregar.TabIndex = 8;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// lblFechaFacura
			// 
			lblFechaFacura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblFechaFacura.Location = new Point(114, 76);
			lblFechaFacura.Name = "lblFechaFacura";
			lblFechaFacura.Size = new Size(56, 19);
			lblFechaFacura.TabIndex = 4;
			lblFechaFacura.Text = "Fecha";
			lblFechaFacura.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cboServicio
			// 
			cboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
			cboServicio.FormattingEnabled = true;
			cboServicio.Location = new Point(176, 43);
			cboServicio.Name = "cboServicio";
			cboServicio.Size = new Size(236, 23);
			cboServicio.TabIndex = 5;
			// 
			// dtpFechaFactura
			// 
			dtpFechaFactura.CustomFormat = "dd/MM/yyy";
			dtpFechaFactura.Format = DateTimePickerFormat.Custom;
			dtpFechaFactura.Location = new Point(176, 72);
			dtpFechaFactura.Name = "dtpFechaFactura";
			dtpFechaFactura.Size = new Size(162, 23);
			dtpFechaFactura.TabIndex = 6;
			// 
			// lblBuscarServicio
			// 
			lblBuscarServicio.AutoSize = true;
			lblBuscarServicio.Location = new Point(24, 51);
			lblBuscarServicio.Name = "lblBuscarServicio";
			lblBuscarServicio.Size = new Size(146, 15);
			lblBuscarServicio.TabIndex = 1;
			lblBuscarServicio.Text = "Agregar Servicio a la Venta";
			lblBuscarServicio.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lvwListaFactura
			// 
			lvwListaFactura.Columns.AddRange(new ColumnHeader[] { colFechaFactura, colCodigo, colServicio, colMonto });
			lvwListaFactura.GridLines = true;
			lvwListaFactura.Location = new Point(18, 101);
			lvwListaFactura.Name = "lvwListaFactura";
			lvwListaFactura.Size = new Size(509, 302);
			lvwListaFactura.TabIndex = 9;
			lvwListaFactura.UseCompatibleStateImageBehavior = false;
			lvwListaFactura.View = View.Details;
			// 
			// colFechaFactura
			// 
			colFechaFactura.Text = "Fecha";
			colFechaFactura.Width = 80;
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
			gbTotalFactura.Location = new Point(0, 560);
			gbTotalFactura.Name = "gbTotalFactura";
			gbTotalFactura.Size = new Size(533, 101);
			gbTotalFactura.TabIndex = 21;
			gbTotalFactura.TabStop = false;
			// 
			// btnBuscarTiked
			// 
			btnBuscarTiked.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnBuscarTiked.Location = new Point(454, 14);
			btnBuscarTiked.Name = "btnBuscarTiked";
			btnBuscarTiked.Size = new Size(73, 23);
			btnBuscarTiked.TabIndex = 7;
			btnBuscarTiked.Text = "Buscar";
			btnBuscarTiked.UseVisualStyleBackColor = true;
			btnBuscarTiked.Click += btnBuscarTiked_Click;
			// 
			// frmFacturacion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(533, 661);
			Controls.Add(gbTotalFactura);
			Controls.Add(gbListaFactura);
			Controls.Add(gbDatosFactura);
			Name = "frmFacturacion";
			Text = "Facturacion";
			Load += frmFacturacion_Load;
			gbDatosFactura.ResumeLayout(false);
			gbDatosFactura.PerformLayout();
			gbListaFactura.ResumeLayout(false);
			gbListaFactura.PerformLayout();
			gbTotalFactura.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Label lblIdFactura;
		private Label lblSubTotal;
		private Label lblResSubTotal;
		private Label lblTotal;
		private Label lblIVA;
		private Label lblResTotal;
		private Label lblResIVA;
		private TextBox txtTikedFactura;
		private Button btnPagar;
		private Button btnCancelar;
		private GroupBox gbDatosFactura;
		private GroupBox gbListaFactura;
		private ListView lvwListaFactura;
		private GroupBox gbTotalFactura;
		private Button btnAgregar;
		private ComboBox cboServicio;
		private Label lblBuscarServicio;
		private ColumnHeader colCodigo;
		private ColumnHeader colServicio;
		private ColumnHeader colMonto;
		private Button btnBuscarPacientePaciente;
		private ColumnHeader colFechaFactura;
		private ListView lvwListaTikedFactura;
		private ColumnHeader colTiked;
		private ColumnHeader colIdentificacionTiked;
		private ColumnHeader colNombreTiked;
		private ColumnHeader colApellido1Tiked;
		private ColumnHeader ColApelldio2Tiked;
		private ColumnHeader colFechaNacimientoTiked;
		private ColumnHeader ColEdadTiked;
		private ColumnHeader colGeneroTiked;
		private ColumnHeader ColTelefonoTiked;
		private Label lblFechaFacura;
		private DateTimePicker dtpFechaFactura;
		private TextBox txtTikedId;
		private Label lblTiked;
		private Button btnBuscarTiked;
	}
}