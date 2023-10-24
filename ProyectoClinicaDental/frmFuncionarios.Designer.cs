namespace ProyectoClinicaDental
{
	partial class frmFuncionarios
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
			lblTitulo = new Label();
			lblNombreFuncionario = new Label();
			lblIdentificacionFuncionario = new Label();
			lblPuesto = new Label();
			lblContrasenia = new Label();
			lblUsuario = new Label();
			txtNombreFuncionario = new TextBox();
			txtIdentificacionFuncionario = new TextBox();
			txtPuestoFuncionario = new TextBox();
			txtUsuarioFuncionario = new TextBox();
			txtContraseniaFuncionario = new TextBox();
			btnGuardar = new Button();
			btnCancerlar = new Button();
			pbLogo = new PictureBox();
			txtApellidoFuncionario = new TextBox();
			lblApellidoFuncionario = new Label();
			lblGenero = new Label();
			lblResEdadFuncionario = new Label();
			lblEdad = new Label();
			txtTelefonoFuncionario = new TextBox();
			lblTelefono = new Label();
			txtEmailFuncionario = new TextBox();
			lblEmail = new Label();
			lblFechaNacimientoFuncionario = new Label();
			dtpFechaNacFuncionario = new DateTimePicker();
			btnLimpiar = new Button();
			gbTitulo = new GroupBox();
			gbDatosFuncionarios = new GroupBox();
			rbtnGeneroFuncionario = new RadioButton();
			rbtnGeneroMFuncionario = new RadioButton();
			gbBotones = new GroupBox();
			btnModificar = new Button();
			btnBuscar = new Button();
			((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
			gbTitulo.SuspendLayout();
			gbDatosFuncionarios.SuspendLayout();
			gbBotones.SuspendLayout();
			SuspendLayout();
			// 
			// lblTitulo
			// 
			lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitulo.Location = new Point(194, 22);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(359, 51);
			lblTitulo.TabIndex = 0;
			lblTitulo.Text = "Ingrese los datos para Nuevos Funcionarios de la Clinica Dental Happy Teeth";
			lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNombreFuncionario
			// 
			lblNombreFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombreFuncionario.Location = new Point(12, 30);
			lblNombreFuncionario.Name = "lblNombreFuncionario";
			lblNombreFuncionario.Size = new Size(106, 21);
			lblNombreFuncionario.TabIndex = 1;
			lblNombreFuncionario.Text = "Nombre ";
			lblNombreFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdentificacionFuncionario
			// 
			lblIdentificacionFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdentificacionFuncionario.Location = new Point(12, 124);
			lblIdentificacionFuncionario.Name = "lblIdentificacionFuncionario";
			lblIdentificacionFuncionario.Size = new Size(106, 21);
			lblIdentificacionFuncionario.TabIndex = 2;
			lblIdentificacionFuncionario.Text = "Identificacion";
			lblIdentificacionFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblPuesto
			// 
			lblPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblPuesto.Location = new Point(360, 116);
			lblPuesto.Name = "lblPuesto";
			lblPuesto.Size = new Size(106, 21);
			lblPuesto.TabIndex = 3;
			lblPuesto.Text = "Puesto";
			lblPuesto.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblContrasenia
			// 
			lblContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblContrasenia.Location = new Point(360, 223);
			lblContrasenia.Name = "lblContrasenia";
			lblContrasenia.Size = new Size(106, 21);
			lblContrasenia.TabIndex = 5;
			lblContrasenia.Text = "Contrasena";
			lblContrasenia.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblUsuario
			// 
			lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsuario.Location = new Point(360, 165);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(106, 21);
			lblUsuario.TabIndex = 6;
			lblUsuario.Text = "Usuario";
			lblUsuario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtNombreFuncionario
			// 
			txtNombreFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombreFuncionario.Location = new Point(135, 22);
			txtNombreFuncionario.Name = "txtNombreFuncionario";
			txtNombreFuncionario.Size = new Size(203, 29);
			txtNombreFuncionario.TabIndex = 7;
			txtNombreFuncionario.KeyPress += txtNombreFuncionario_KeyPress;
			// 
			// txtIdentificacionFuncionario
			// 
			txtIdentificacionFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionFuncionario.Location = new Point(135, 116);
			txtIdentificacionFuncionario.Name = "txtIdentificacionFuncionario";
			txtIdentificacionFuncionario.Size = new Size(203, 29);
			txtIdentificacionFuncionario.TabIndex = 8;
			txtIdentificacionFuncionario.KeyPress += txtIdentificacionFuncionario_KeyPress;
			// 
			// txtPuestoFuncionario
			// 
			txtPuestoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPuestoFuncionario.Location = new Point(489, 113);
			txtPuestoFuncionario.Name = "txtPuestoFuncionario";
			txtPuestoFuncionario.Size = new Size(203, 29);
			txtPuestoFuncionario.TabIndex = 9;
			txtPuestoFuncionario.KeyPress += txtPuestoFuncionario_KeyPress;
			// 
			// txtUsuarioFuncionario
			// 
			txtUsuarioFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsuarioFuncionario.Location = new Point(489, 162);
			txtUsuarioFuncionario.Name = "txtUsuarioFuncionario";
			txtUsuarioFuncionario.Size = new Size(203, 29);
			txtUsuarioFuncionario.TabIndex = 10;
			txtUsuarioFuncionario.KeyPress += txtUsuarioFuncionario_KeyPress;
			// 
			// txtContraseniaFuncionario
			// 
			txtContraseniaFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtContraseniaFuncionario.Location = new Point(489, 220);
			txtContraseniaFuncionario.Name = "txtContraseniaFuncionario";
			txtContraseniaFuncionario.Size = new Size(203, 29);
			txtContraseniaFuncionario.TabIndex = 11;
			txtContraseniaFuncionario.KeyPress += txtContraseniaFuncionario_KeyPress;
			// 
			// btnGuardar
			// 
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnGuardar.Location = new Point(366, 22);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(112, 28);
			btnGuardar.TabIndex = 12;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnCancerlar
			// 
			btnCancerlar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancerlar.Location = new Point(484, 22);
			btnCancerlar.Name = "btnCancerlar";
			btnCancerlar.Size = new Size(112, 28);
			btnCancerlar.TabIndex = 13;
			btnCancerlar.Text = "Cancelar";
			btnCancerlar.UseVisualStyleBackColor = true;
			btnCancerlar.Click += btnCancerlar_Click;
			// 
			// pbLogo
			// 
			pbLogo.Image = Properties.Resources.logoClinica;
			pbLogo.Location = new Point(6, 22);
			pbLogo.Name = "pbLogo";
			pbLogo.Size = new Size(124, 145);
			pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pbLogo.TabIndex = 14;
			pbLogo.TabStop = false;
			// 
			// txtApellidoFuncionario
			// 
			txtApellidoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoFuncionario.Location = new Point(135, 68);
			txtApellidoFuncionario.Name = "txtApellidoFuncionario";
			txtApellidoFuncionario.Size = new Size(203, 29);
			txtApellidoFuncionario.TabIndex = 16;
			txtApellidoFuncionario.KeyPress += txtApellidoFuncionario_KeyPress;
			// 
			// lblApellidoFuncionario
			// 
			lblApellidoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoFuncionario.Location = new Point(12, 76);
			lblApellidoFuncionario.Name = "lblApellidoFuncionario";
			lblApellidoFuncionario.Size = new Size(106, 21);
			lblApellidoFuncionario.TabIndex = 15;
			lblApellidoFuncionario.Text = "Apellido";
			lblApellidoFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblGenero
			// 
			lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblGenero.Location = new Point(6, 270);
			lblGenero.Name = "lblGenero";
			lblGenero.Size = new Size(106, 21);
			lblGenero.TabIndex = 17;
			lblGenero.Text = "Genero";
			lblGenero.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblResEdadFuncionario
			// 
			lblResEdadFuncionario.BackColor = SystemColors.ActiveBorder;
			lblResEdadFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblResEdadFuncionario.Location = new Point(135, 223);
			lblResEdadFuncionario.Name = "lblResEdadFuncionario";
			lblResEdadFuncionario.Size = new Size(203, 29);
			lblResEdadFuncionario.TabIndex = 19;
			lblResEdadFuncionario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblEdad
			// 
			lblEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEdad.Location = new Point(6, 231);
			lblEdad.Name = "lblEdad";
			lblEdad.Size = new Size(106, 21);
			lblEdad.TabIndex = 20;
			lblEdad.Text = "Edad";
			lblEdad.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtTelefonoFuncionario
			// 
			txtTelefonoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTelefonoFuncionario.Location = new Point(489, 18);
			txtTelefonoFuncionario.Name = "txtTelefonoFuncionario";
			txtTelefonoFuncionario.Size = new Size(203, 29);
			txtTelefonoFuncionario.TabIndex = 22;
			txtTelefonoFuncionario.KeyPress += txtTelefonoFuncionario_KeyPress;
			// 
			// lblTelefono
			// 
			lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTelefono.Location = new Point(360, 22);
			lblTelefono.Name = "lblTelefono";
			lblTelefono.Size = new Size(106, 21);
			lblTelefono.TabIndex = 21;
			lblTelefono.Text = "Telefono";
			lblTelefono.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtEmailFuncionario
			// 
			txtEmailFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmailFuncionario.Location = new Point(489, 65);
			txtEmailFuncionario.Name = "txtEmailFuncionario";
			txtEmailFuncionario.Size = new Size(203, 29);
			txtEmailFuncionario.TabIndex = 24;
			txtEmailFuncionario.KeyPress += txtEmailFuncionario_KeyPress;
			// 
			// lblEmail
			// 
			lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEmail.Location = new Point(360, 68);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(106, 21);
			lblEmail.TabIndex = 23;
			lblEmail.Text = "Email";
			lblEmail.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblFechaNacimientoFuncionario
			// 
			lblFechaNacimientoFuncionario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblFechaNacimientoFuncionario.Location = new Point(12, 168);
			lblFechaNacimientoFuncionario.Name = "lblFechaNacimientoFuncionario";
			lblFechaNacimientoFuncionario.Size = new Size(106, 40);
			lblFechaNacimientoFuncionario.TabIndex = 25;
			lblFechaNacimientoFuncionario.Text = "Fecha Nacimiento";
			lblFechaNacimientoFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// dtpFechaNacFuncionario
			// 
			dtpFechaNacFuncionario.CustomFormat = "dd/mm/yyyy";
			dtpFechaNacFuncionario.Format = DateTimePickerFormat.Custom;
			dtpFechaNacFuncionario.Location = new Point(135, 168);
			dtpFechaNacFuncionario.Name = "dtpFechaNacFuncionario";
			dtpFechaNacFuncionario.Size = new Size(203, 23);
			dtpFechaNacFuncionario.TabIndex = 26;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLimpiar.Location = new Point(130, 22);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(112, 28);
			btnLimpiar.TabIndex = 27;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// gbTitulo
			// 
			gbTitulo.Controls.Add(lblTitulo);
			gbTitulo.Controls.Add(pbLogo);
			gbTitulo.Dock = DockStyle.Top;
			gbTitulo.Location = new Point(0, 0);
			gbTitulo.Name = "gbTitulo";
			gbTitulo.Size = new Size(721, 186);
			gbTitulo.TabIndex = 28;
			gbTitulo.TabStop = false;
			// 
			// gbDatosFuncionarios
			// 
			gbDatosFuncionarios.Controls.Add(rbtnGeneroFuncionario);
			gbDatosFuncionarios.Controls.Add(rbtnGeneroMFuncionario);
			gbDatosFuncionarios.Controls.Add(lblNombreFuncionario);
			gbDatosFuncionarios.Controls.Add(lblIdentificacionFuncionario);
			gbDatosFuncionarios.Controls.Add(lblPuesto);
			gbDatosFuncionarios.Controls.Add(dtpFechaNacFuncionario);
			gbDatosFuncionarios.Controls.Add(lblContrasenia);
			gbDatosFuncionarios.Controls.Add(lblFechaNacimientoFuncionario);
			gbDatosFuncionarios.Controls.Add(lblUsuario);
			gbDatosFuncionarios.Controls.Add(txtEmailFuncionario);
			gbDatosFuncionarios.Controls.Add(txtNombreFuncionario);
			gbDatosFuncionarios.Controls.Add(lblEmail);
			gbDatosFuncionarios.Controls.Add(txtIdentificacionFuncionario);
			gbDatosFuncionarios.Controls.Add(txtTelefonoFuncionario);
			gbDatosFuncionarios.Controls.Add(txtPuestoFuncionario);
			gbDatosFuncionarios.Controls.Add(lblTelefono);
			gbDatosFuncionarios.Controls.Add(txtUsuarioFuncionario);
			gbDatosFuncionarios.Controls.Add(lblEdad);
			gbDatosFuncionarios.Controls.Add(txtContraseniaFuncionario);
			gbDatosFuncionarios.Controls.Add(lblResEdadFuncionario);
			gbDatosFuncionarios.Controls.Add(lblApellidoFuncionario);
			gbDatosFuncionarios.Controls.Add(txtApellidoFuncionario);
			gbDatosFuncionarios.Controls.Add(lblGenero);
			gbDatosFuncionarios.Dock = DockStyle.Fill;
			gbDatosFuncionarios.Location = new Point(0, 186);
			gbDatosFuncionarios.Name = "gbDatosFuncionarios";
			gbDatosFuncionarios.Size = new Size(721, 385);
			gbDatosFuncionarios.TabIndex = 29;
			gbDatosFuncionarios.TabStop = false;
			gbDatosFuncionarios.Text = "Datos Funcionarios";
			gbDatosFuncionarios.Enter += gbDatosFuncionarios_Enter;
			// 
			// rbtnGeneroFuncionario
			// 
			rbtnGeneroFuncionario.AutoSize = true;
			rbtnGeneroFuncionario.Location = new Point(224, 273);
			rbtnGeneroFuncionario.Name = "rbtnGeneroFuncionario";
			rbtnGeneroFuncionario.Size = new Size(78, 19);
			rbtnGeneroFuncionario.TabIndex = 28;
			rbtnGeneroFuncionario.TabStop = true;
			rbtnGeneroFuncionario.Text = "Femenino";
			rbtnGeneroFuncionario.UseVisualStyleBackColor = true;
			// 
			// rbtnGeneroMFuncionario
			// 
			rbtnGeneroMFuncionario.AutoSize = true;
			rbtnGeneroMFuncionario.Location = new Point(138, 273);
			rbtnGeneroMFuncionario.Name = "rbtnGeneroMFuncionario";
			rbtnGeneroMFuncionario.Size = new Size(80, 19);
			rbtnGeneroMFuncionario.TabIndex = 27;
			rbtnGeneroMFuncionario.TabStop = true;
			rbtnGeneroMFuncionario.Text = "Masculino";
			rbtnGeneroMFuncionario.UseVisualStyleBackColor = true;
			// 
			// gbBotones
			// 
			gbBotones.Controls.Add(btnBuscar);
			gbBotones.Controls.Add(btnModificar);
			gbBotones.Controls.Add(btnGuardar);
			gbBotones.Controls.Add(btnCancerlar);
			gbBotones.Controls.Add(btnLimpiar);
			gbBotones.Dock = DockStyle.Bottom;
			gbBotones.Location = new Point(0, 502);
			gbBotones.Name = "gbBotones";
			gbBotones.Size = new Size(721, 69);
			gbBotones.TabIndex = 30;
			gbBotones.TabStop = false;
			// 
			// btnModificar
			// 
			btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnModificar.Location = new Point(248, 22);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(112, 28);
			btnModificar.TabIndex = 28;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnBuscar.Location = new Point(12, 22);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(112, 28);
			btnBuscar.TabIndex = 29;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = true;
			// 
			// frmFuncionarios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(721, 571);
			Controls.Add(gbBotones);
			Controls.Add(gbDatosFuncionarios);
			Controls.Add(gbTitulo);
			Name = "frmFuncionarios";
			Text = "Nuevos Funcionarios";
			Load += frmFuncionarios_Load;
			((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
			gbTitulo.ResumeLayout(false);
			gbDatosFuncionarios.ResumeLayout(false);
			gbDatosFuncionarios.PerformLayout();
			gbBotones.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label lblTitulo;
		private Label lblNombreFuncionario;
		private Label lblIdentificacionFuncionario;
		private Label lblPuesto;
		private Label lblContrasenia;
		private Label lblUsuario;
		private TextBox txtNombreFuncionario;
		private TextBox txtIdentificacionFuncionario;
		private TextBox txtPuestoFuncionario;
		private TextBox txtUsuarioFuncionario;
		private TextBox txtContraseniaFuncionario;
		private Button btnGuardar;
		private Button btnCancerlar;
		private PictureBox pbLogo;
		private TextBox txtApellidoFuncionario;
		private Label lblApellidoFuncionario;
		private Label lblGenero;
		private Label lblResEdadFuncionario;
		private Label lblEdad;
		private TextBox txtTelefonoFuncionario;
		private Label lblTelefono;
		private TextBox txtEmailFuncionario;
		private Label lblEmail;
		private Label lblFechaNacimientoFuncionario;
		private DateTimePicker dtpFechaNacFuncionario;
		private Button btnLimpiar;
		private GroupBox gbTitulo;
		private GroupBox gbDatosFuncionarios;
		private GroupBox gbBotones;
		private RadioButton rbtnGeneroFuncionario;
		private RadioButton rbtnGeneroMFuncionario;
		private Button btnModificar;
		private Button btnBuscar;
	}
}