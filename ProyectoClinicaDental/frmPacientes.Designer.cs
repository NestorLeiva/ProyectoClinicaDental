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
			lblIdPadre = new Label();
			lblSexo = new Label();
			lblDireccion = new Label();
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
			lblIdHijo = new Label();
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
			dateTimePicker1 = new DateTimePicker();
			lblResEdadHijo = new Label();
			cboSexoHijo = new ComboBox();
			lblTelefonoHijo = new Label();
			lblEmailHijo = new Label();
			txtApellidoHijo = new TextBox();
			txtIdentificacionHijo = new TextBox();
			btnGuardar = new Button();
			btnLimpiar = new Button();
			btnCancelar = new Button();
			lblDatosPadre = new Label();
			lblTituloHijo = new Label();
			cboDireccionProvincia = new ComboBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			groupBox3 = new GroupBox();
			groupBox4 = new GroupBox();
			groupBox5 = new GroupBox();
			lblIdPadreBusqueda = new Label();
			txtIdentificacionPadreBusqueda = new TextBox();
			btnBusquedaIdPadre = new Button();
			((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox5.SuspendLayout();
			SuspendLayout();
			// 
			// pbLogo
			// 
			pbLogo.Image = Properties.Resources.logoClinica;
			pbLogo.Location = new Point(38, 12);
			pbLogo.Name = "pbLogo";
			pbLogo.Size = new Size(125, 136);
			pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pbLogo.TabIndex = 0;
			pbLogo.TabStop = false;
			// 
			// lblTitulo
			// 
			lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitulo.Location = new Point(175, 12);
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
			// lblIdPadre
			// 
			lblIdPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdPadre.Location = new Point(6, 125);
			lblIdPadre.Name = "lblIdPadre";
			lblIdPadre.Size = new Size(141, 23);
			lblIdPadre.TabIndex = 4;
			lblIdPadre.Text = "Id del Padre";
			lblIdPadre.TextAlign = ContentAlignment.MiddleRight;
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
			// lblDireccion
			// 
			lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDireccion.Location = new Point(22, 478);
			lblDireccion.Name = "lblDireccion";
			lblDireccion.Size = new Size(316, 23);
			lblDireccion.TabIndex = 6;
			lblDireccion.Text = "Direccion";
			lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
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
			// lblIdHijo
			// 
			lblIdHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdHijo.Location = new Point(6, 131);
			lblIdHijo.Name = "lblIdHijo";
			lblIdHijo.Size = new Size(168, 23);
			lblIdHijo.TabIndex = 19;
			lblIdHijo.Text = "Id Hijo";
			lblIdHijo.TextAlign = ContentAlignment.MiddleRight;
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
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(180, 166);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(169, 23);
			dateTimePicker1.TabIndex = 39;
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
			btnGuardar.Location = new Point(6, 31);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(112, 30);
			btnGuardar.TabIndex = 54;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLimpiar.Location = new Point(242, 31);
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
			btnCancelar.Location = new Point(124, 31);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(112, 30);
			btnCancelar.TabIndex = 56;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblDatosPadre
			// 
			lblDatosPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDatosPadre.Location = new Point(6, 19);
			lblDatosPadre.Name = "lblDatosPadre";
			lblDatosPadre.Size = new Size(316, 23);
			lblDatosPadre.TabIndex = 57;
			lblDatosPadre.Text = "Datos del Padre";
			lblDatosPadre.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblTituloHijo
			// 
			lblTituloHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTituloHijo.Location = new Point(6, 19);
			lblTituloHijo.Name = "lblTituloHijo";
			lblTituloHijo.Size = new Size(343, 23);
			lblTituloHijo.TabIndex = 58;
			lblTituloHijo.Text = "Datos del Hijo";
			lblTituloHijo.TextAlign = ContentAlignment.MiddleCenter;
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
			// groupBox1
			// 
			groupBox1.Controls.Add(lblDatosPadre);
			groupBox1.Controls.Add(lblNombrePadre);
			groupBox1.Controls.Add(lblApellidoPadre);
			groupBox1.Controls.Add(lblIdPadre);
			groupBox1.Controls.Add(lblSexo);
			groupBox1.Controls.Add(lblTelefono);
			groupBox1.Controls.Add(lblEmail);
			groupBox1.Controls.Add(lblResEdadPadre);
			groupBox1.Controls.Add(lblEdad);
			groupBox1.Controls.Add(lblFechaNacPadre);
			groupBox1.Controls.Add(txtNombrePadre);
			groupBox1.Controls.Add(txtApellidoPadre);
			groupBox1.Controls.Add(txtIdentificacionPadre);
			groupBox1.Controls.Add(txtTelefonoPadre);
			groupBox1.Controls.Add(cboSexoPadre);
			groupBox1.Controls.Add(txtEmailPadre);
			groupBox1.Controls.Add(dtpFechaNac);
			groupBox1.Location = new Point(22, 154);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(336, 342);
			groupBox1.TabIndex = 60;
			groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lblTituloHijo);
			groupBox2.Controls.Add(lblNombreHijo);
			groupBox2.Controls.Add(lblApellidoHijo);
			groupBox2.Controls.Add(lblFechaNacHijo);
			groupBox2.Controls.Add(lblIdHijo);
			groupBox2.Controls.Add(lblSexoHijo);
			groupBox2.Controls.Add(lblEdadHijo);
			groupBox2.Controls.Add(txtIdentificacionHijo);
			groupBox2.Controls.Add(txtEmailHijo);
			groupBox2.Controls.Add(txtApellidoHijo);
			groupBox2.Controls.Add(txtNombreHijo);
			groupBox2.Controls.Add(lblEmailHijo);
			groupBox2.Controls.Add(txtTelefonoHIjo);
			groupBox2.Controls.Add(lblTelefonoHijo);
			groupBox2.Controls.Add(lblResEdadHijo);
			groupBox2.Controls.Add(cboSexoHijo);
			groupBox2.Controls.Add(dateTimePicker1);
			groupBox2.Location = new Point(364, 154);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(373, 342);
			groupBox2.TabIndex = 61;
			groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(lblProvincia);
			groupBox3.Controls.Add(lblCanton);
			groupBox3.Controls.Add(lblOtrasSenas);
			groupBox3.Controls.Add(cboDireccionProvincia);
			groupBox3.Controls.Add(lblDistrito);
			groupBox3.Controls.Add(txtDireccionCanton);
			groupBox3.Controls.Add(txtDieccionOtrasSenas);
			groupBox3.Controls.Add(txtDireccionDistrito);
			groupBox3.Location = new Point(22, 504);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(715, 163);
			groupBox3.TabIndex = 62;
			groupBox3.TabStop = false;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(btnGuardar);
			groupBox4.Controls.Add(btnLimpiar);
			groupBox4.Controls.Add(btnCancelar);
			groupBox4.Location = new Point(227, 673);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(370, 76);
			groupBox4.TabIndex = 63;
			groupBox4.TabStop = false;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(btnBusquedaIdPadre);
			groupBox5.Controls.Add(txtIdentificacionPadreBusqueda);
			groupBox5.Controls.Add(lblIdPadreBusqueda);
			groupBox5.Location = new Point(191, 63);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(546, 85);
			groupBox5.TabIndex = 64;
			groupBox5.TabStop = false;
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
			// txtIdentificacionPadreBusqueda
			// 
			txtIdentificacionPadreBusqueda.Location = new Point(179, 19);
			txtIdentificacionPadreBusqueda.Name = "txtIdentificacionPadreBusqueda";
			txtIdentificacionPadreBusqueda.Size = new Size(343, 23);
			txtIdentificacionPadreBusqueda.TabIndex = 1;
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
			// frmPacientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 761);
			Controls.Add(groupBox5);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(lblDireccion);
			Controls.Add(lblTitulo);
			Controls.Add(pbLogo);
			Name = "frmPacientes";
			Text = "Registro Pacientes";
			((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbLogo;
		private Label lblTitulo;
		private Label lblNombrePadre;
		private Label lblApellidoPadre;
		private Label lblIdPadre;
		private Label lblSexo;
		private Label lblDireccion;
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
		private Label lblIdHijo;
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
		private DateTimePicker dateTimePicker1;
		private Label lblResEdadHijo;
		private ComboBox cboSexoHijo;
		private Label lblTelefonoHijo;
		private Label lblEmailHijo;
		private TextBox txtApellidoHijo;
		private TextBox txtIdentificacionHijo;
		private Button btnGuardar;
		private Button btnLimpiar;
		private Button btnCancelar;
		private Label lblDatosPadre;
		private Label lblTituloHijo;
		private ComboBox cboDireccionProvincia;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private GroupBox groupBox5;
		private Label lblIdPadreBusqueda;
		private Button btnBusquedaIdPadre;
		private TextBox txtIdentificacionPadreBusqueda;
	}
}