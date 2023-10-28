namespace ProyectoClinicaDental
{
	partial class frmPacientes
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
			pbLogo = new PictureBox();
			lblTitulo = new Label();
			lblApellidoPrimeoPadre = new Label();
			lblIdentificacionPadre = new Label();
			lblTelefono = new Label();
			lblProvincia = new Label();
			lblEmail = new Label();
			lblCanton = new Label();
			lblOtrasSenas = new Label();
			lblDistrito = new Label();
			lblNombreHijo = new Label();
			lblApellidoPrimeroHijo = new Label();
			lblFechaNacHijo = new Label();
			lblIdentificacionHijo = new Label();
			lblSexoHijo = new Label();
			lblEdadHijo = new Label();
			txtNombrePadre = new TextBox();
			txtApellidoPrimeroPadre = new TextBox();
			txtTelefonoPadre = new TextBox();
			txtEmailPadre = new TextBox();
			txtDireccionCanton = new TextBox();
			txtNombreHijo = new TextBox();
			txtDieccionOtrasSenas = new TextBox();
			txtDireccionDistrito = new TextBox();
			txtTelefonoHIjo = new TextBox();
			dtpFechaHijo = new DateTimePicker();
			lblResEdadHijo = new Label();
			lblTelefonoHijo = new Label();
			txtApellidoPrimeroHijo = new TextBox();
			txtIdentificacionHijo = new TextBox();
			btnGuardar = new Button();
			btnLimpiar = new Button();
			btnCancelar = new Button();
			cboDireccionProvincia = new ComboBox();
			gbDatosPadre = new GroupBox();
			txtIdentificacionPadre = new TextBox();
			txtApellidoSegundoPadre = new TextBox();
			lblApellidoSegundoPadre = new Label();
			rbtnGeneroFPadre = new RadioButton();
			rbtnGeneroMPadre = new RadioButton();
			lblGeneroPadre = new Label();
			lblNombrePadre = new Label();
			gbDatosHijo = new GroupBox();
			txtApellidoSegundoHijo = new TextBox();
			lblApellidoSegundoHijo = new Label();
			btnAgregar = new Button();
			rbtnGeneroFHijo = new RadioButton();
			rbtnGeneroMHijo = new RadioButton();
			gbDireccion = new GroupBox();
			gbBotones = new GroupBox();
			gbTitulo = new GroupBox();
			((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
			gbDatosPadre.SuspendLayout();
			gbDatosHijo.SuspendLayout();
			gbDireccion.SuspendLayout();
			gbBotones.SuspendLayout();
			gbTitulo.SuspendLayout();
			SuspendLayout();
			// 
			// pbLogo
			// 
			pbLogo.Image = Properties.Resources.logoClinica;
			pbLogo.Location = new Point(6, 22);
			pbLogo.Name = "pbLogo";
			pbLogo.Size = new Size(125, 136);
			pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pbLogo.TabIndex = 0;
			pbLogo.TabStop = false;
			// 
			// lblTitulo
			// 
			lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitulo.Location = new Point(137, 19);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(348, 48);
			lblTitulo.TabIndex = 1;
			lblTitulo.Text = "Registro de Pacientes ";
			lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblApellidoPrimeoPadre
			// 
			lblApellidoPrimeoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoPrimeoPadre.Location = new Point(6, 75);
			lblApellidoPrimeoPadre.Name = "lblApellidoPrimeoPadre";
			lblApellidoPrimeoPadre.Size = new Size(141, 23);
			lblApellidoPrimeoPadre.TabIndex = 3;
			lblApellidoPrimeoPadre.Text = "Primer Apellido ";
			lblApellidoPrimeoPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdentificacionPadre
			// 
			lblIdentificacionPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdentificacionPadre.Location = new Point(6, 145);
			lblIdentificacionPadre.Name = "lblIdentificacionPadre";
			lblIdentificacionPadre.Size = new Size(141, 23);
			lblIdentificacionPadre.TabIndex = 4;
			lblIdentificacionPadre.Text = "Identificacion";
			lblIdentificacionPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblTelefono
			// 
			lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTelefono.Location = new Point(6, 222);
			lblTelefono.Name = "lblTelefono";
			lblTelefono.Size = new Size(141, 23);
			lblTelefono.TabIndex = 7;
			lblTelefono.Text = "Telefono";
			lblTelefono.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblProvincia
			// 
			lblProvincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblProvincia.Location = new Point(6, 22);
			lblProvincia.Name = "lblProvincia";
			lblProvincia.Size = new Size(98, 23);
			lblProvincia.TabIndex = 8;
			lblProvincia.Text = "Provincia";
			lblProvincia.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblEmail
			// 
			lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEmail.Location = new Point(6, 257);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(141, 23);
			lblEmail.TabIndex = 9;
			lblEmail.Text = "Email";
			lblEmail.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblCanton
			// 
			lblCanton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblCanton.Location = new Point(6, 57);
			lblCanton.Name = "lblCanton";
			lblCanton.Size = new Size(98, 23);
			lblCanton.TabIndex = 10;
			lblCanton.Text = "Canton";
			lblCanton.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblOtrasSenas
			// 
			lblOtrasSenas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblOtrasSenas.Location = new Point(6, 127);
			lblOtrasSenas.Name = "lblOtrasSenas";
			lblOtrasSenas.Size = new Size(98, 23);
			lblOtrasSenas.TabIndex = 11;
			lblOtrasSenas.Text = "Otras Senas";
			lblOtrasSenas.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblDistrito
			// 
			lblDistrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDistrito.Location = new Point(6, 92);
			lblDistrito.Name = "lblDistrito";
			lblDistrito.Size = new Size(98, 23);
			lblDistrito.TabIndex = 12;
			lblDistrito.Text = "Distrito";
			lblDistrito.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblNombreHijo
			// 
			lblNombreHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombreHijo.Location = new Point(6, 40);
			lblNombreHijo.Name = "lblNombreHijo";
			lblNombreHijo.Size = new Size(168, 23);
			lblNombreHijo.TabIndex = 16;
			lblNombreHijo.Text = "Nombre ";
			lblNombreHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblApellidoPrimeroHijo
			// 
			lblApellidoPrimeroHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoPrimeroHijo.Location = new Point(6, 75);
			lblApellidoPrimeroHijo.Name = "lblApellidoPrimeroHijo";
			lblApellidoPrimeroHijo.Size = new Size(168, 23);
			lblApellidoPrimeroHijo.TabIndex = 17;
			lblApellidoPrimeroHijo.Text = "Primer Apellido";
			lblApellidoPrimeroHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblFechaNacHijo
			// 
			lblFechaNacHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFechaNacHijo.Location = new Point(6, 180);
			lblFechaNacHijo.Name = "lblFechaNacHijo";
			lblFechaNacHijo.Size = new Size(168, 23);
			lblFechaNacHijo.TabIndex = 18;
			lblFechaNacHijo.Text = "Fecha Nacimiento";
			lblFechaNacHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdentificacionHijo
			// 
			lblIdentificacionHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdentificacionHijo.Location = new Point(6, 145);
			lblIdentificacionHijo.Name = "lblIdentificacionHijo";
			lblIdentificacionHijo.Size = new Size(168, 23);
			lblIdentificacionHijo.TabIndex = 19;
			lblIdentificacionHijo.Text = "Identificacion";
			lblIdentificacionHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSexoHijo
			// 
			lblSexoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblSexoHijo.Location = new Point(6, 250);
			lblSexoHijo.Name = "lblSexoHijo";
			lblSexoHijo.Size = new Size(168, 23);
			lblSexoHijo.TabIndex = 20;
			lblSexoHijo.Text = "Genero";
			lblSexoHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblEdadHijo
			// 
			lblEdadHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEdadHijo.Location = new Point(6, 215);
			lblEdadHijo.Name = "lblEdadHijo";
			lblEdadHijo.Size = new Size(168, 23);
			lblEdadHijo.TabIndex = 21;
			lblEdadHijo.Text = "Edad";
			lblEdadHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtNombrePadre
			// 
			txtNombrePadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombrePadre.Location = new Point(153, 40);
			txtNombrePadre.Name = "txtNombrePadre";
			txtNombrePadre.Size = new Size(169, 29);
			txtNombrePadre.TabIndex = 1;
			txtNombrePadre.KeyPress += txtNombrePadre_KeyPress;
			// 
			// txtApellidoPrimeroPadre
			// 
			txtApellidoPrimeroPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoPrimeroPadre.Location = new Point(153, 75);
			txtApellidoPrimeroPadre.Name = "txtApellidoPrimeroPadre";
			txtApellidoPrimeroPadre.Size = new Size(169, 29);
			txtApellidoPrimeroPadre.TabIndex = 2;
			txtApellidoPrimeroPadre.KeyPress += txtApellidoPadre_KeyPress;
			// 
			// txtTelefonoPadre
			// 
			txtTelefonoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTelefonoPadre.Location = new Point(153, 216);
			txtTelefonoPadre.MaxLength = 8;
			txtTelefonoPadre.Name = "txtTelefonoPadre";
			txtTelefonoPadre.Size = new Size(169, 29);
			txtTelefonoPadre.TabIndex = 7;
			txtTelefonoPadre.KeyPress += txtTelefonoPadre_KeyPress;
			// 
			// txtEmailPadre
			// 
			txtEmailPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmailPadre.Location = new Point(153, 251);
			txtEmailPadre.Name = "txtEmailPadre";
			txtEmailPadre.Size = new Size(169, 29);
			txtEmailPadre.TabIndex = 8;
			txtEmailPadre.KeyPress += txtEmailPadre_KeyPress;
			// 
			// txtDireccionCanton
			// 
			txtDireccionCanton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtDireccionCanton.Location = new Point(110, 51);
			txtDireccionCanton.Name = "txtDireccionCanton";
			txtDireccionCanton.Size = new Size(581, 29);
			txtDireccionCanton.TabIndex = 10;
			txtDireccionCanton.KeyPress += txtDireccionCanton_KeyPress;
			// 
			// txtNombreHijo
			// 
			txtNombreHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombreHijo.Location = new Point(180, 34);
			txtNombreHijo.Name = "txtNombreHijo";
			txtNombreHijo.Size = new Size(169, 29);
			txtNombreHijo.TabIndex = 13;
			txtNombreHijo.KeyPress += txtNombreHijo_KeyPress;
			// 
			// txtDieccionOtrasSenas
			// 
			txtDieccionOtrasSenas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtDieccionOtrasSenas.Location = new Point(110, 121);
			txtDieccionOtrasSenas.Name = "txtDieccionOtrasSenas";
			txtDieccionOtrasSenas.Size = new Size(581, 29);
			txtDieccionOtrasSenas.TabIndex = 12;
			// 
			// txtDireccionDistrito
			// 
			txtDireccionDistrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtDireccionDistrito.Location = new Point(110, 86);
			txtDireccionDistrito.Name = "txtDireccionDistrito";
			txtDireccionDistrito.Size = new Size(581, 29);
			txtDireccionDistrito.TabIndex = 11;
			txtDireccionDistrito.KeyPress += txtDireccionDistrito_KeyPress;
			// 
			// txtTelefonoHIjo
			// 
			txtTelefonoHIjo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTelefonoHIjo.Location = new Point(180, 279);
			txtTelefonoHIjo.MaxLength = 8;
			txtTelefonoHIjo.Name = "txtTelefonoHIjo";
			txtTelefonoHIjo.Size = new Size(169, 29);
			txtTelefonoHIjo.TabIndex = 20;
			txtTelefonoHIjo.KeyPress += txtTelefonoHIjo_KeyPress;
			// 
			// dtpFechaHijo
			// 
			dtpFechaHijo.Location = new Point(180, 180);
			dtpFechaHijo.Name = "dtpFechaHijo";
			dtpFechaHijo.Size = new Size(169, 23);
			dtpFechaHijo.TabIndex = 17;
			dtpFechaHijo.ValueChanged += dtpFechaHijo_ValueChanged;
			// 
			// lblResEdadHijo
			// 
			lblResEdadHijo.BackColor = SystemColors.ActiveBorder;
			lblResEdadHijo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblResEdadHijo.Location = new Point(180, 215);
			lblResEdadHijo.Name = "lblResEdadHijo";
			lblResEdadHijo.Size = new Size(169, 29);
			lblResEdadHijo.TabIndex = 38;
			lblResEdadHijo.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblTelefonoHijo
			// 
			lblTelefonoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTelefonoHijo.Location = new Point(6, 285);
			lblTelefonoHijo.Name = "lblTelefonoHijo";
			lblTelefonoHijo.Size = new Size(168, 23);
			lblTelefonoHijo.TabIndex = 42;
			lblTelefonoHijo.Text = "Telefono";
			lblTelefonoHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtApellidoPrimeroHijo
			// 
			txtApellidoPrimeroHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoPrimeroHijo.Location = new Point(180, 69);
			txtApellidoPrimeroHijo.Name = "txtApellidoPrimeroHijo";
			txtApellidoPrimeroHijo.Size = new Size(169, 29);
			txtApellidoPrimeroHijo.TabIndex = 14;
			txtApellidoPrimeroHijo.KeyPress += txtApellidoHijo_KeyPress;
			// 
			// txtIdentificacionHijo
			// 
			txtIdentificacionHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionHijo.Location = new Point(180, 139);
			txtIdentificacionHijo.MaxLength = 10;
			txtIdentificacionHijo.Name = "txtIdentificacionHijo";
			txtIdentificacionHijo.Size = new Size(169, 29);
			txtIdentificacionHijo.TabIndex = 16;
			txtIdentificacionHijo.KeyPress += txtIdentificacionHijo_KeyPress;
			// 
			// btnGuardar
			// 
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnGuardar.Location = new Point(29, 31);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(112, 30);
			btnGuardar.TabIndex = 22;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLimpiar.Location = new Point(398, 31);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(112, 30);
			btnLimpiar.TabIndex = 24;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancelar.Location = new Point(218, 31);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(112, 30);
			btnCancelar.TabIndex = 23;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// cboDireccionProvincia
			// 
			cboDireccionProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
			cboDireccionProvincia.FormattingEnabled = true;
			cboDireccionProvincia.Items.AddRange(new object[] { "Cartago", "San Jose", "Alajuela", "Limon", "Guanacaste", "Heredia", "Puntarenas" });
			cboDireccionProvincia.Location = new Point(110, 22);
			cboDireccionProvincia.Name = "cboDireccionProvincia";
			cboDireccionProvincia.Size = new Size(581, 23);
			cboDireccionProvincia.TabIndex = 9;
			// 
			// gbDatosPadre
			// 
			gbDatosPadre.Controls.Add(txtIdentificacionPadre);
			gbDatosPadre.Controls.Add(txtApellidoSegundoPadre);
			gbDatosPadre.Controls.Add(lblApellidoSegundoPadre);
			gbDatosPadre.Controls.Add(rbtnGeneroFPadre);
			gbDatosPadre.Controls.Add(rbtnGeneroMPadre);
			gbDatosPadre.Controls.Add(lblGeneroPadre);
			gbDatosPadre.Controls.Add(lblNombrePadre);
			gbDatosPadre.Controls.Add(txtNombrePadre);
			gbDatosPadre.Controls.Add(lblApellidoPrimeoPadre);
			gbDatosPadre.Controls.Add(txtApellidoPrimeroPadre);
			gbDatosPadre.Controls.Add(lblIdentificacionPadre);
			gbDatosPadre.Controls.Add(lblTelefono);
			gbDatosPadre.Controls.Add(txtTelefonoPadre);
			gbDatosPadre.Controls.Add(lblEmail);
			gbDatosPadre.Controls.Add(txtEmailPadre);
			gbDatosPadre.Location = new Point(12, 179);
			gbDatosPadre.Name = "gbDatosPadre";
			gbDatosPadre.Size = new Size(336, 342);
			gbDatosPadre.TabIndex = 1;
			gbDatosPadre.TabStop = false;
			gbDatosPadre.Text = "DATOS DEL PADRE";
			// 
			// txtIdentificacionPadre
			// 
			txtIdentificacionPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionPadre.Location = new Point(153, 145);
			txtIdentificacionPadre.MaxLength = 10;
			txtIdentificacionPadre.Name = "txtIdentificacionPadre";
			txtIdentificacionPadre.Size = new Size(169, 29);
			txtIdentificacionPadre.TabIndex = 4;
			txtIdentificacionPadre.KeyPress += txtIdentificacionPadre_KeyPress_1;
			// 
			// txtApellidoSegundoPadre
			// 
			txtApellidoSegundoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoSegundoPadre.Location = new Point(153, 110);
			txtApellidoSegundoPadre.Name = "txtApellidoSegundoPadre";
			txtApellidoSegundoPadre.Size = new Size(169, 29);
			txtApellidoSegundoPadre.TabIndex = 3;
			txtApellidoSegundoPadre.KeyPress += txtApellidoSegundoPadre_KeyPress;
			// 
			// lblApellidoSegundoPadre
			// 
			lblApellidoSegundoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoSegundoPadre.Location = new Point(6, 106);
			lblApellidoSegundoPadre.Name = "lblApellidoSegundoPadre";
			lblApellidoSegundoPadre.Size = new Size(141, 23);
			lblApellidoSegundoPadre.TabIndex = 55;
			lblApellidoSegundoPadre.Text = "Segundo Apellido ";
			lblApellidoSegundoPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// rbtnGeneroFPadre
			// 
			rbtnGeneroFPadre.AutoSize = true;
			rbtnGeneroFPadre.Location = new Point(240, 185);
			rbtnGeneroFPadre.Name = "rbtnGeneroFPadre";
			rbtnGeneroFPadre.Size = new Size(78, 19);
			rbtnGeneroFPadre.TabIndex = 6;
			rbtnGeneroFPadre.TabStop = true;
			rbtnGeneroFPadre.Text = "Femenino";
			rbtnGeneroFPadre.UseVisualStyleBackColor = true;
			// 
			// rbtnGeneroMPadre
			// 
			rbtnGeneroMPadre.AutoSize = true;
			rbtnGeneroMPadre.Location = new Point(160, 187);
			rbtnGeneroMPadre.Name = "rbtnGeneroMPadre";
			rbtnGeneroMPadre.Size = new Size(75, 19);
			rbtnGeneroMPadre.TabIndex = 5;
			rbtnGeneroMPadre.TabStop = true;
			rbtnGeneroMPadre.Text = "Maculino";
			rbtnGeneroMPadre.UseVisualStyleBackColor = true;
			// 
			// lblGeneroPadre
			// 
			lblGeneroPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblGeneroPadre.Location = new Point(6, 181);
			lblGeneroPadre.Name = "lblGeneroPadre";
			lblGeneroPadre.Size = new Size(141, 23);
			lblGeneroPadre.TabIndex = 52;
			lblGeneroPadre.Text = "Genero";
			lblGeneroPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblNombrePadre
			// 
			lblNombrePadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombrePadre.Location = new Point(6, 46);
			lblNombrePadre.Name = "lblNombrePadre";
			lblNombrePadre.Size = new Size(141, 23);
			lblNombrePadre.TabIndex = 37;
			lblNombrePadre.Text = "Nombre";
			lblNombrePadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// gbDatosHijo
			// 
			gbDatosHijo.Controls.Add(txtApellidoSegundoHijo);
			gbDatosHijo.Controls.Add(lblApellidoSegundoHijo);
			gbDatosHijo.Controls.Add(btnAgregar);
			gbDatosHijo.Controls.Add(rbtnGeneroFHijo);
			gbDatosHijo.Controls.Add(rbtnGeneroMHijo);
			gbDatosHijo.Controls.Add(lblNombreHijo);
			gbDatosHijo.Controls.Add(txtNombreHijo);
			gbDatosHijo.Controls.Add(lblApellidoPrimeroHijo);
			gbDatosHijo.Controls.Add(txtApellidoPrimeroHijo);
			gbDatosHijo.Controls.Add(lblIdentificacionHijo);
			gbDatosHijo.Controls.Add(txtIdentificacionHijo);
			gbDatosHijo.Controls.Add(lblFechaNacHijo);
			gbDatosHijo.Controls.Add(dtpFechaHijo);
			gbDatosHijo.Controls.Add(lblEdadHijo);
			gbDatosHijo.Controls.Add(lblResEdadHijo);
			gbDatosHijo.Controls.Add(lblSexoHijo);
			gbDatosHijo.Controls.Add(lblTelefonoHijo);
			gbDatosHijo.Controls.Add(txtTelefonoHIjo);
			gbDatosHijo.Location = new Point(354, 179);
			gbDatosHijo.Name = "gbDatosHijo";
			gbDatosHijo.Size = new Size(373, 342);
			gbDatosHijo.TabIndex = 3;
			gbDatosHijo.TabStop = false;
			gbDatosHijo.Text = "DATOS DEL HIJO";
			// 
			// txtApellidoSegundoHijo
			// 
			txtApellidoSegundoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoSegundoHijo.Location = new Point(180, 104);
			txtApellidoSegundoHijo.Name = "txtApellidoSegundoHijo";
			txtApellidoSegundoHijo.Size = new Size(169, 29);
			txtApellidoSegundoHijo.TabIndex = 15;
			txtApellidoSegundoHijo.KeyPress += txtApellidoPrimeroHijo_KeyPress;
			// 
			// lblApellidoSegundoHijo
			// 
			lblApellidoSegundoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoSegundoHijo.Location = new Point(6, 110);
			lblApellidoSegundoHijo.Name = "lblApellidoSegundoHijo";
			lblApellidoSegundoHijo.Size = new Size(168, 23);
			lblApellidoSegundoHijo.TabIndex = 53;
			lblApellidoSegundoHijo.Text = "Segundo Apellido ";
			lblApellidoSegundoHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnAgregar
			// 
			btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnAgregar.Location = new Point(6, 311);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(82, 25);
			btnAgregar.TabIndex = 21;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// rbtnGeneroFHijo
			// 
			rbtnGeneroFHijo.AutoSize = true;
			rbtnGeneroFHijo.Location = new Point(268, 255);
			rbtnGeneroFHijo.Name = "rbtnGeneroFHijo";
			rbtnGeneroFHijo.Size = new Size(78, 19);
			rbtnGeneroFHijo.TabIndex = 19;
			rbtnGeneroFHijo.TabStop = true;
			rbtnGeneroFHijo.Text = "Femenino";
			rbtnGeneroFHijo.UseVisualStyleBackColor = true;
			// 
			// rbtnGeneroMHijo
			// 
			rbtnGeneroMHijo.AutoSize = true;
			rbtnGeneroMHijo.Location = new Point(187, 255);
			rbtnGeneroMHijo.Name = "rbtnGeneroMHijo";
			rbtnGeneroMHijo.Size = new Size(75, 19);
			rbtnGeneroMHijo.TabIndex = 18;
			rbtnGeneroMHijo.TabStop = true;
			rbtnGeneroMHijo.Text = "Maculino";
			rbtnGeneroMHijo.UseVisualStyleBackColor = true;
			// 
			// gbDireccion
			// 
			gbDireccion.Controls.Add(lblProvincia);
			gbDireccion.Controls.Add(cboDireccionProvincia);
			gbDireccion.Controls.Add(lblCanton);
			gbDireccion.Controls.Add(txtDireccionCanton);
			gbDireccion.Controls.Add(lblDistrito);
			gbDireccion.Controls.Add(txtDireccionDistrito);
			gbDireccion.Controls.Add(lblOtrasSenas);
			gbDireccion.Controls.Add(txtDieccionOtrasSenas);
			gbDireccion.Location = new Point(12, 527);
			gbDireccion.Name = "gbDireccion";
			gbDireccion.Size = new Size(715, 163);
			gbDireccion.TabIndex = 2;
			gbDireccion.TabStop = false;
			gbDireccion.Text = "DATOS DIRECCION";
			// 
			// gbBotones
			// 
			gbBotones.Controls.Add(btnGuardar);
			gbBotones.Controls.Add(btnLimpiar);
			gbBotones.Controls.Add(btnCancelar);
			gbBotones.Dock = DockStyle.Bottom;
			gbBotones.Location = new Point(0, 692);
			gbBotones.Name = "gbBotones";
			gbBotones.Size = new Size(748, 76);
			gbBotones.TabIndex = 4;
			gbBotones.TabStop = false;
			// 
			// gbTitulo
			// 
			gbTitulo.Controls.Add(pbLogo);
			gbTitulo.Controls.Add(lblTitulo);
			gbTitulo.Dock = DockStyle.Top;
			gbTitulo.Location = new Point(0, 0);
			gbTitulo.Name = "gbTitulo";
			gbTitulo.Size = new Size(748, 173);
			gbTitulo.TabIndex = 65;
			gbTitulo.TabStop = false;
			// 
			// frmPacientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(748, 768);
			Controls.Add(gbTitulo);
			Controls.Add(gbBotones);
			Controls.Add(gbDireccion);
			Controls.Add(gbDatosHijo);
			Controls.Add(gbDatosPadre);
			Name = "frmPacientes";
			Text = "Registro Pacientes";
			Load += frmPacientes_Load;
			((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
			gbDatosPadre.ResumeLayout(false);
			gbDatosPadre.PerformLayout();
			gbDatosHijo.ResumeLayout(false);
			gbDatosHijo.PerformLayout();
			gbDireccion.ResumeLayout(false);
			gbDireccion.PerformLayout();
			gbBotones.ResumeLayout(false);
			gbTitulo.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbLogo;
		private Label lblTitulo;
		private Label lblApellidoPrimeoPadre;
		private Label lblIdentificacionPadre;
		private Label lblTelefono;
		private Label lblProvincia;
		private Label lblEmail;
		private Label lblCanton;
		private Label lblOtrasSenas;
		private Label lblDistrito;
		private Label lblNombreHijo;
		private Label lblApellidoPrimeroHijo;
		private Label lblFechaNacHijo;
		private Label lblIdentificacionHijo;
		private Label lblSexoHijo;
		private Label lblEdadHijo;
		private TextBox txtNombrePadre;
		private TextBox txtApellidoPrimeroPadre;
		private TextBox txtTelefonoPadre;
		private TextBox txtEmailPadre;
		private TextBox txtDireccionCanton;
		private TextBox txtNombreHijo;
		private TextBox txtDieccionOtrasSenas;
		private TextBox txtDireccionDistrito;
		private TextBox txtTelefonoHIjo;
		private DateTimePicker dtpFechaHijo;
		private Label lblResEdadHijo;
		private Label lblTelefonoHijo;
		private TextBox txtApellidoPrimeroHijo;
		private TextBox txtIdentificacionHijo;
		private Button btnGuardar;
		private Button btnLimpiar;
		private Button btnCancelar;
		private ComboBox cboDireccionProvincia;
		private GroupBox gbDatosPadre;
		private GroupBox gbDatosHijo;
		private GroupBox gbDireccion;
		private GroupBox gbBotones;
		private GroupBox gbTitulo;
		private Label lblNombrePadre;
		private RadioButton rbtnGeneroFHijo;
		private RadioButton rbtnGeneroMHijo;
		private RadioButton rbtnGeneroFPadre;
		private RadioButton rbtnGeneroMPadre;
		private Label lblGeneroPadre;
		private Button btnAgregar;
		private Label lblApellidoSegundoPadre;
		private TextBox txtApellidoSegundoPadre;
		private Label lblApellidoSegundoHijo;
		private TextBox txtApellidoSegundoHijo;
		private TextBox txtIdentificacionPadre;
	}
}