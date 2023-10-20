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
			lblNombrePadre = new Label();
			lblApellidoPadre = new Label();
			lblIdentificacionPadre = new Label();
			lblSexo = new Label();
			lblTelefono = new Label();
			lblProvincia = new Label();
			lblEmail = new Label();
			lblCanton = new Label();
			lblOtrasSenas = new Label();
			lblDistrito = new Label();
			lblResEdadPadre = new Label();
			lblEdad = new Label();
			lblFechaNacPadre = new Label();
			lblNombreHijo = new Label();
			lblApellidoHijo = new Label();
			lblFechaNacHijo = new Label();
			lblIdentificacionHijo = new Label();
			lblSexoHijo = new Label();
			lblEdadHijo = new Label();
			txtNombrePadre = new TextBox();
			txtApellidoPadre = new TextBox();
			txtIdentificacionPadre = new TextBox();
			txtEmailHijo = new TextBox();
			txtTelefonoPadre = new TextBox();
			txtEmailPadre = new TextBox();
			txtDireccionCanton = new TextBox();
			txtNombreHijo = new TextBox();
			txtDieccionOtrasSenas = new TextBox();
			txtDireccionDistrito = new TextBox();
			txtTelefonoHIjo = new TextBox();
			dtpFechaNac = new DateTimePicker();
			cboSexoPadre = new ComboBox();
			dtpFechaHijo = new DateTimePicker();
			lblResEdadHijo = new Label();
			cboSexoHijo = new ComboBox();
			lblTelefonoHijo = new Label();
			lblEmailHijo = new Label();
			txtApellidoHijo = new TextBox();
			txtIdentificacionHijo = new TextBox();
			btnGuardar = new Button();
			btnLimpiar = new Button();
			btnCancelar = new Button();
			lblTituloDatosPadre = new Label();
			lblTituloDatosHijo = new Label();
			cboDireccionProvincia = new ComboBox();
			gbDatosPadre = new GroupBox();
			gbDatosHijo = new GroupBox();
			gbDireccion = new GroupBox();
			gbBotones = new GroupBox();
			btnModificar = new Button();
			gbConsulta = new GroupBox();
			btnBusquedaIdPadre = new Button();
			txtIdentificacionPadreBusqueda = new TextBox();
			lblIdPadreBusqueda = new Label();
			gbCabezera = new GroupBox();
			((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
			gbDatosPadre.SuspendLayout();
			gbDatosHijo.SuspendLayout();
			gbDireccion.SuspendLayout();
			gbBotones.SuspendLayout();
			gbConsulta.SuspendLayout();
			gbCabezera.SuspendLayout();
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
			// lblNombrePadre
			// 
			lblNombrePadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombrePadre.Location = new Point(6, 55);
			lblNombrePadre.Name = "lblNombrePadre";
			lblNombrePadre.Size = new Size(141, 23);
			lblNombrePadre.TabIndex = 2;
			lblNombrePadre.Text = "Nombre del Padre";
			lblNombrePadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblApellidoPadre
			// 
			lblApellidoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoPadre.Location = new Point(6, 90);
			lblApellidoPadre.Name = "lblApellidoPadre";
			lblApellidoPadre.Size = new Size(141, 23);
			lblApellidoPadre.TabIndex = 3;
			lblApellidoPadre.Text = "Apellido del Padre";
			lblApellidoPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdentificacionPadre
			// 
			lblIdentificacionPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdentificacionPadre.Location = new Point(6, 125);
			lblIdentificacionPadre.Name = "lblIdentificacionPadre";
			lblIdentificacionPadre.Size = new Size(141, 23);
			lblIdentificacionPadre.TabIndex = 4;
			lblIdentificacionPadre.Text = "Id del Padre";
			lblIdentificacionPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSexo
			// 
			lblSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblSexo.Location = new Point(6, 236);
			lblSexo.Name = "lblSexo";
			lblSexo.Size = new Size(141, 23);
			lblSexo.TabIndex = 5;
			lblSexo.Text = "Sexo";
			lblSexo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblTelefono
			// 
			lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTelefono.Location = new Point(6, 265);
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
			lblEmail.Location = new Point(6, 300);
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
			// lblResEdadPadre
			// 
			lblResEdadPadre.BackColor = SystemColors.ActiveBorder;
			lblResEdadPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblResEdadPadre.Location = new Point(153, 192);
			lblResEdadPadre.Name = "lblResEdadPadre";
			lblResEdadPadre.Size = new Size(169, 29);
			lblResEdadPadre.TabIndex = 13;
			lblResEdadPadre.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblEdad
			// 
			lblEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEdad.Location = new Point(6, 201);
			lblEdad.Name = "lblEdad";
			lblEdad.Size = new Size(141, 23);
			lblEdad.TabIndex = 14;
			lblEdad.Text = "Edad";
			lblEdad.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblFechaNacPadre
			// 
			lblFechaNacPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFechaNacPadre.Location = new Point(6, 166);
			lblFechaNacPadre.Name = "lblFechaNacPadre";
			lblFechaNacPadre.Size = new Size(141, 23);
			lblFechaNacPadre.TabIndex = 15;
			lblFechaNacPadre.Text = "Fecha Nacimiento";
			lblFechaNacPadre.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblNombreHijo
			// 
			lblNombreHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombreHijo.Location = new Point(6, 61);
			lblNombreHijo.Name = "lblNombreHijo";
			lblNombreHijo.Size = new Size(168, 23);
			lblNombreHijo.TabIndex = 16;
			lblNombreHijo.Text = "Nombre Hijo";
			lblNombreHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblApellidoHijo
			// 
			lblApellidoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoHijo.Location = new Point(6, 96);
			lblApellidoHijo.Name = "lblApellidoHijo";
			lblApellidoHijo.Size = new Size(168, 23);
			lblApellidoHijo.TabIndex = 17;
			lblApellidoHijo.Text = "Apellido Hijo";
			lblApellidoHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblFechaNacHijo
			// 
			lblFechaNacHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFechaNacHijo.Location = new Point(6, 166);
			lblFechaNacHijo.Name = "lblFechaNacHijo";
			lblFechaNacHijo.Size = new Size(168, 23);
			lblFechaNacHijo.TabIndex = 18;
			lblFechaNacHijo.Text = "Fecha Nacimiento Hijo";
			lblFechaNacHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdentificacionHijo
			// 
			lblIdentificacionHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdentificacionHijo.Location = new Point(6, 131);
			lblIdentificacionHijo.Name = "lblIdentificacionHijo";
			lblIdentificacionHijo.Size = new Size(168, 23);
			lblIdentificacionHijo.TabIndex = 19;
			lblIdentificacionHijo.Text = "Id Hijo";
			lblIdentificacionHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSexoHijo
			// 
			lblSexoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblSexoHijo.Location = new Point(6, 236);
			lblSexoHijo.Name = "lblSexoHijo";
			lblSexoHijo.Size = new Size(168, 23);
			lblSexoHijo.TabIndex = 20;
			lblSexoHijo.Text = "Sexo Hijo";
			lblSexoHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblEdadHijo
			// 
			lblEdadHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEdadHijo.Location = new Point(6, 201);
			lblEdadHijo.Name = "lblEdadHijo";
			lblEdadHijo.Size = new Size(168, 23);
			lblEdadHijo.TabIndex = 21;
			lblEdadHijo.Text = "Edad";
			lblEdadHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtNombrePadre
			// 
			txtNombrePadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombrePadre.Location = new Point(153, 55);
			txtNombrePadre.Name = "txtNombrePadre";
			txtNombrePadre.Size = new Size(169, 29);
			txtNombrePadre.TabIndex = 23;
			txtNombrePadre.KeyPress += txtNombrePadre_KeyPress;
			// 
			// txtApellidoPadre
			// 
			txtApellidoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoPadre.Location = new Point(153, 90);
			txtApellidoPadre.Name = "txtApellidoPadre";
			txtApellidoPadre.Size = new Size(169, 29);
			txtApellidoPadre.TabIndex = 24;
			txtApellidoPadre.KeyPress += txtApellidoPadre_KeyPress;
			// 
			// txtIdentificacionPadre
			// 
			txtIdentificacionPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionPadre.Location = new Point(153, 125);
			txtIdentificacionPadre.Name = "txtIdentificacionPadre";
			txtIdentificacionPadre.Size = new Size(169, 29);
			txtIdentificacionPadre.TabIndex = 25;
			txtIdentificacionPadre.KeyPress += txtIdentificacionPadre_KeyPress;
			// 
			// txtEmailHijo
			// 
			txtEmailHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmailHijo.Location = new Point(180, 300);
			txtEmailHijo.Name = "txtEmailHijo";
			txtEmailHijo.Size = new Size(169, 29);
			txtEmailHijo.TabIndex = 26;
			txtEmailHijo.KeyPress += txtEmailHijo_KeyPress;
			// 
			// txtTelefonoPadre
			// 
			txtTelefonoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTelefonoPadre.Location = new Point(153, 265);
			txtTelefonoPadre.Name = "txtTelefonoPadre";
			txtTelefonoPadre.Size = new Size(169, 29);
			txtTelefonoPadre.TabIndex = 27;
			txtTelefonoPadre.KeyPress += txtTelefonoPadre_KeyPress;
			// 
			// txtEmailPadre
			// 
			txtEmailPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmailPadre.Location = new Point(153, 300);
			txtEmailPadre.Name = "txtEmailPadre";
			txtEmailPadre.Size = new Size(169, 29);
			txtEmailPadre.TabIndex = 28;
			txtEmailPadre.KeyPress += txtEmailPadre_KeyPress;
			// 
			// txtDireccionCanton
			// 
			txtDireccionCanton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtDireccionCanton.Location = new Point(110, 51);
			txtDireccionCanton.Name = "txtDireccionCanton";
			txtDireccionCanton.Size = new Size(581, 29);
			txtDireccionCanton.TabIndex = 31;
			txtDireccionCanton.KeyPress += txtDireccionCanton_KeyPress;
			// 
			// txtNombreHijo
			// 
			txtNombreHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombreHijo.Location = new Point(180, 55);
			txtNombreHijo.Name = "txtNombreHijo";
			txtNombreHijo.Size = new Size(169, 29);
			txtNombreHijo.TabIndex = 32;
			txtNombreHijo.KeyPress += txtNombreHijo_KeyPress;
			// 
			// txtDieccionOtrasSenas
			// 
			txtDieccionOtrasSenas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtDieccionOtrasSenas.Location = new Point(110, 121);
			txtDieccionOtrasSenas.Name = "txtDieccionOtrasSenas";
			txtDieccionOtrasSenas.Size = new Size(581, 29);
			txtDieccionOtrasSenas.TabIndex = 33;
			txtDieccionOtrasSenas.KeyPress += txtDieccionOtrasSenas_KeyPress;
			// 
			// txtDireccionDistrito
			// 
			txtDireccionDistrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtDireccionDistrito.Location = new Point(110, 86);
			txtDireccionDistrito.Name = "txtDireccionDistrito";
			txtDireccionDistrito.Size = new Size(581, 29);
			txtDireccionDistrito.TabIndex = 34;
			txtDireccionDistrito.KeyPress += txtDireccionDistrito_KeyPress;
			// 
			// txtTelefonoHIjo
			// 
			txtTelefonoHIjo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTelefonoHIjo.Location = new Point(180, 265);
			txtTelefonoHIjo.Name = "txtTelefonoHIjo";
			txtTelefonoHIjo.Size = new Size(169, 29);
			txtTelefonoHIjo.TabIndex = 35;
			txtTelefonoHIjo.KeyPress += txtTelefonoHIjo_KeyPress;
			// 
			// dtpFechaNac
			// 
			dtpFechaNac.Location = new Point(153, 166);
			dtpFechaNac.Name = "dtpFechaNac";
			dtpFechaNac.Size = new Size(169, 23);
			dtpFechaNac.TabIndex = 36;
			// 
			// cboSexoPadre
			// 
			cboSexoPadre.FormattingEnabled = true;
			cboSexoPadre.Items.AddRange(new object[] { "Masculino", "Femenino" });
			cboSexoPadre.Location = new Point(153, 236);
			cboSexoPadre.Name = "cboSexoPadre";
			cboSexoPadre.Size = new Size(169, 23);
			cboSexoPadre.TabIndex = 37;
			// 
			// dtpFechaHijo
			// 
			dtpFechaHijo.Location = new Point(180, 166);
			dtpFechaHijo.Name = "dtpFechaHijo";
			dtpFechaHijo.Size = new Size(169, 23);
			dtpFechaHijo.TabIndex = 39;
			// 
			// lblResEdadHijo
			// 
			lblResEdadHijo.BackColor = SystemColors.ActiveBorder;
			lblResEdadHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblResEdadHijo.Location = new Point(180, 201);
			lblResEdadHijo.Name = "lblResEdadHijo";
			lblResEdadHijo.Size = new Size(169, 29);
			lblResEdadHijo.TabIndex = 38;
			lblResEdadHijo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cboSexoHijo
			// 
			cboSexoHijo.FormattingEnabled = true;
			cboSexoHijo.Items.AddRange(new object[] { "Masculino", "Femenino" });
			cboSexoHijo.Location = new Point(180, 239);
			cboSexoHijo.Name = "cboSexoHijo";
			cboSexoHijo.Size = new Size(169, 23);
			cboSexoHijo.TabIndex = 40;
			// 
			// lblTelefonoHijo
			// 
			lblTelefonoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTelefonoHijo.Location = new Point(6, 271);
			lblTelefonoHijo.Name = "lblTelefonoHijo";
			lblTelefonoHijo.Size = new Size(168, 23);
			lblTelefonoHijo.TabIndex = 42;
			lblTelefonoHijo.Text = "Telefono Hijo";
			lblTelefonoHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblEmailHijo
			// 
			lblEmailHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEmailHijo.Location = new Point(6, 306);
			lblEmailHijo.Name = "lblEmailHijo";
			lblEmailHijo.Size = new Size(168, 23);
			lblEmailHijo.TabIndex = 45;
			lblEmailHijo.Text = "Email Hijo";
			lblEmailHijo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtApellidoHijo
			// 
			txtApellidoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoHijo.Location = new Point(180, 90);
			txtApellidoHijo.Name = "txtApellidoHijo";
			txtApellidoHijo.Size = new Size(169, 29);
			txtApellidoHijo.TabIndex = 48;
			txtApellidoHijo.KeyPress += txtApellidoHijo_KeyPress;
			// 
			// txtIdentificacionHijo
			// 
			txtIdentificacionHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionHijo.Location = new Point(180, 125);
			txtIdentificacionHijo.Name = "txtIdentificacionHijo";
			txtIdentificacionHijo.Size = new Size(169, 29);
			txtIdentificacionHijo.TabIndex = 49;
			txtIdentificacionHijo.KeyPress += txtIdentificacionHijo_KeyPress;
			// 
			// btnGuardar
			// 
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnGuardar.Location = new Point(29, 31);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(112, 30);
			btnGuardar.TabIndex = 54;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLimpiar.Location = new Point(398, 31);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(112, 30);
			btnLimpiar.TabIndex = 55;
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
			btnCancelar.TabIndex = 56;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblTituloDatosPadre
			// 
			lblTituloDatosPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTituloDatosPadre.Location = new Point(6, 19);
			lblTituloDatosPadre.Name = "lblTituloDatosPadre";
			lblTituloDatosPadre.Size = new Size(316, 23);
			lblTituloDatosPadre.TabIndex = 57;
			lblTituloDatosPadre.Text = "Datos del Padre";
			lblTituloDatosPadre.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTituloDatosHijo
			// 
			lblTituloDatosHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTituloDatosHijo.Location = new Point(6, 19);
			lblTituloDatosHijo.Name = "lblTituloDatosHijo";
			lblTituloDatosHijo.Size = new Size(343, 23);
			lblTituloDatosHijo.TabIndex = 58;
			lblTituloDatosHijo.Text = "Datos del Hijo";
			lblTituloDatosHijo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cboDireccionProvincia
			// 
			cboDireccionProvincia.FormattingEnabled = true;
			cboDireccionProvincia.Items.AddRange(new object[] { "Cartago", "San Jose", "Alajuela", "Limon", "Guanacaste", "Heredia", "Puntarenas" });
			cboDireccionProvincia.Location = new Point(110, 22);
			cboDireccionProvincia.Name = "cboDireccionProvincia";
			cboDireccionProvincia.Size = new Size(581, 23);
			cboDireccionProvincia.TabIndex = 59;
			// 
			// gbDatosPadre
			// 
			gbDatosPadre.Controls.Add(lblTituloDatosPadre);
			gbDatosPadre.Controls.Add(lblNombrePadre);
			gbDatosPadre.Controls.Add(txtNombrePadre);
			gbDatosPadre.Controls.Add(lblApellidoPadre);
			gbDatosPadre.Controls.Add(txtApellidoPadre);
			gbDatosPadre.Controls.Add(lblIdentificacionPadre);
			gbDatosPadre.Controls.Add(txtIdentificacionPadre);
			gbDatosPadre.Controls.Add(lblFechaNacPadre);
			gbDatosPadre.Controls.Add(dtpFechaNac);
			gbDatosPadre.Controls.Add(lblEdad);
			gbDatosPadre.Controls.Add(lblResEdadPadre);
			gbDatosPadre.Controls.Add(lblSexo);
			gbDatosPadre.Controls.Add(cboSexoPadre);
			gbDatosPadre.Controls.Add(lblTelefono);
			gbDatosPadre.Controls.Add(txtTelefonoPadre);
			gbDatosPadre.Controls.Add(lblEmail);
			gbDatosPadre.Controls.Add(txtEmailPadre);
			gbDatosPadre.Location = new Point(22, 191);
			gbDatosPadre.Name = "gbDatosPadre";
			gbDatosPadre.Size = new Size(336, 342);
			gbDatosPadre.TabIndex = 60;
			gbDatosPadre.TabStop = false;
			// 
			// gbDatosHijo
			// 
			gbDatosHijo.Controls.Add(lblTituloDatosHijo);
			gbDatosHijo.Controls.Add(lblNombreHijo);
			gbDatosHijo.Controls.Add(txtNombreHijo);
			gbDatosHijo.Controls.Add(lblApellidoHijo);
			gbDatosHijo.Controls.Add(txtApellidoHijo);
			gbDatosHijo.Controls.Add(lblIdentificacionHijo);
			gbDatosHijo.Controls.Add(txtIdentificacionHijo);
			gbDatosHijo.Controls.Add(lblFechaNacHijo);
			gbDatosHijo.Controls.Add(dtpFechaHijo);
			gbDatosHijo.Controls.Add(lblEdadHijo);
			gbDatosHijo.Controls.Add(lblResEdadHijo);
			gbDatosHijo.Controls.Add(lblSexoHijo);
			gbDatosHijo.Controls.Add(cboSexoHijo);
			gbDatosHijo.Controls.Add(lblTelefonoHijo);
			gbDatosHijo.Controls.Add(txtTelefonoHIjo);
			gbDatosHijo.Controls.Add(lblEmailHijo);
			gbDatosHijo.Controls.Add(txtEmailHijo);
			gbDatosHijo.Location = new Point(364, 191);
			gbDatosHijo.Name = "gbDatosHijo";
			gbDatosHijo.Size = new Size(373, 342);
			gbDatosHijo.TabIndex = 61;
			gbDatosHijo.TabStop = false;
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
			gbDireccion.Location = new Point(22, 539);
			gbDireccion.Name = "gbDireccion";
			gbDireccion.Size = new Size(715, 163);
			gbDireccion.TabIndex = 62;
			gbDireccion.TabStop = false;
			// 
			// gbBotones
			// 
			gbBotones.Controls.Add(btnModificar);
			gbBotones.Controls.Add(btnGuardar);
			gbBotones.Controls.Add(btnLimpiar);
			gbBotones.Controls.Add(btnCancelar);
			gbBotones.Location = new Point(28, 708);
			gbBotones.Name = "gbBotones";
			gbBotones.Size = new Size(709, 76);
			gbBotones.TabIndex = 63;
			gbBotones.TabStop = false;
			// 
			// btnModificar
			// 
			btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnModificar.Location = new Point(532, 31);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(112, 30);
			btnModificar.TabIndex = 57;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = true;
			// 
			// gbConsulta
			// 
			gbConsulta.Controls.Add(btnBusquedaIdPadre);
			gbConsulta.Controls.Add(txtIdentificacionPadreBusqueda);
			gbConsulta.Controls.Add(lblIdPadreBusqueda);
			gbConsulta.Location = new Point(137, 70);
			gbConsulta.Name = "gbConsulta";
			gbConsulta.Size = new Size(546, 85);
			gbConsulta.TabIndex = 64;
			gbConsulta.TabStop = false;
			// 
			// btnBusquedaIdPadre
			// 
			btnBusquedaIdPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnBusquedaIdPadre.Location = new Point(6, 48);
			btnBusquedaIdPadre.Name = "btnBusquedaIdPadre";
			btnBusquedaIdPadre.Size = new Size(118, 31);
			btnBusquedaIdPadre.TabIndex = 2;
			btnBusquedaIdPadre.Text = "Consultar";
			btnBusquedaIdPadre.UseVisualStyleBackColor = true;
			// 
			// txtIdentificacionPadreBusqueda
			// 
			txtIdentificacionPadreBusqueda.Location = new Point(189, 19);
			txtIdentificacionPadreBusqueda.Name = "txtIdentificacionPadreBusqueda";
			txtIdentificacionPadreBusqueda.Size = new Size(343, 23);
			txtIdentificacionPadreBusqueda.TabIndex = 1;
			txtIdentificacionPadreBusqueda.KeyPress += txtIdentificacionPadreBusqueda_KeyPress;
			// 
			// lblIdPadreBusqueda
			// 
			lblIdPadreBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdPadreBusqueda.Location = new Point(6, 19);
			lblIdPadreBusqueda.Name = "lblIdPadreBusqueda";
			lblIdPadreBusqueda.Size = new Size(177, 23);
			lblIdPadreBusqueda.TabIndex = 0;
			lblIdPadreBusqueda.Text = "Buscar por Id del Padre";
			// 
			// gbCabezera
			// 
			gbCabezera.Controls.Add(pbLogo);
			gbCabezera.Controls.Add(lblTitulo);
			gbCabezera.Controls.Add(gbConsulta);
			gbCabezera.Location = new Point(22, 12);
			gbCabezera.Name = "gbCabezera";
			gbCabezera.Size = new Size(715, 173);
			gbCabezera.TabIndex = 65;
			gbCabezera.TabStop = false;
			// 
			// frmPacientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(760, 799);
			Controls.Add(gbCabezera);
			Controls.Add(gbBotones);
			Controls.Add(gbDireccion);
			Controls.Add(gbDatosHijo);
			Controls.Add(gbDatosPadre);
			Name = "frmPacientes";
			Text = "Registro Pacientes";
			((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
			gbDatosPadre.ResumeLayout(false);
			gbDatosPadre.PerformLayout();
			gbDatosHijo.ResumeLayout(false);
			gbDatosHijo.PerformLayout();
			gbDireccion.ResumeLayout(false);
			gbDireccion.PerformLayout();
			gbBotones.ResumeLayout(false);
			gbConsulta.ResumeLayout(false);
			gbConsulta.PerformLayout();
			gbCabezera.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbLogo;
		private Label lblTitulo;
		private Label lblNombrePadre;
		private Label lblApellidoPadre;
		private Label lblIdentificacionPadre;
		private Label lblSexo;
		private Label lblTelefono;
		private Label lblProvincia;
		private Label lblEmail;
		private Label lblCanton;
		private Label lblOtrasSenas;
		private Label lblDistrito;
		private Label lblResEdadPadre;
		private Label lblEdad;
		private Label lblFechaNacPadre;
		private Label lblNombreHijo;
		private Label lblApellidoHijo;
		private Label lblFechaNacHijo;
		private Label lblIdentificacionHijo;
		private Label lblSexoHijo;
		private Label lblEdadHijo;
		private TextBox txtNombrePadre;
		private TextBox txtApellidoPadre;
		private TextBox txtIdentificacionPadre;
		private TextBox txtEmailHijo;
		private TextBox txtTelefonoPadre;
		private TextBox txtEmailPadre;
		private TextBox txtDireccionCanton;
		private TextBox txtNombreHijo;
		private TextBox txtDieccionOtrasSenas;
		private TextBox txtDireccionDistrito;
		private TextBox txtTelefonoHIjo;
		private DateTimePicker dtpFechaNac;
		private ComboBox cboSexoPadre;
		private DateTimePicker dtpFechaHijo;
		private Label lblResEdadHijo;
		private ComboBox cboSexoHijo;
		private Label lblTelefonoHijo;
		private Label lblEmailHijo;
		private TextBox txtApellidoHijo;
		private TextBox txtIdentificacionHijo;
		private Button btnGuardar;
		private Button btnLimpiar;
		private Button btnCancelar;
		private Label lblTituloDatosPadre;
		private Label lblTituloDatosHijo;
		private ComboBox cboDireccionProvincia;
		private GroupBox gbDatosPadre;
		private GroupBox gbDatosHijo;
		private GroupBox gbDireccion;
		private GroupBox gbBotones;
		private GroupBox gbConsulta;
		private Label lblIdPadreBusqueda;
		private Button btnBusquedaIdPadre;
		private TextBox txtIdentificacionPadreBusqueda;
		private Button btnModificar;
		private GroupBox gbCabezera;
	}
}