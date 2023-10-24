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
			txtTelefonoFuncionario = new TextBox();
			lblTelefono = new Label();
			txtEmailFuncionario = new TextBox();
			lblEmail = new Label();
			btnLimpiar = new Button();
			gbTitulo = new GroupBox();
			gbBusquedaFuncionario = new GroupBox();
			btnBuscar = new Button();
			txtBuscarIdFuncionario = new TextBox();
			lblBuscarIdFuncionario = new Label();
			gbDatosFuncionarios = new GroupBox();
			rbtnGeneroFuncionario = new RadioButton();
			rbtnGeneroMFuncionario = new RadioButton();
			gbBotones = new GroupBox();
			btnModificar = new Button();
			((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
			gbTitulo.SuspendLayout();
			gbBusquedaFuncionario.SuspendLayout();
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
			lblPuesto.Location = new Point(360, 78);
			lblPuesto.Name = "lblPuesto";
			lblPuesto.Size = new Size(106, 21);
			lblPuesto.TabIndex = 3;
			lblPuesto.Text = "Puesto";
			lblPuesto.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblContrasenia
			// 
			lblContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblContrasenia.Location = new Point(360, 185);
			lblContrasenia.Name = "lblContrasenia";
			lblContrasenia.Size = new Size(106, 21);
			lblContrasenia.TabIndex = 5;
			lblContrasenia.Text = "Contrasena";
			lblContrasenia.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblUsuario
			// 
			lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsuario.Location = new Point(360, 127);
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
			txtPuestoFuncionario.Location = new Point(489, 75);
			txtPuestoFuncionario.Name = "txtPuestoFuncionario";
			txtPuestoFuncionario.Size = new Size(203, 29);
			txtPuestoFuncionario.TabIndex = 9;
			txtPuestoFuncionario.KeyPress += txtPuestoFuncionario_KeyPress;
			// 
			// txtUsuarioFuncionario
			// 
			txtUsuarioFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsuarioFuncionario.Location = new Point(489, 124);
			txtUsuarioFuncionario.Name = "txtUsuarioFuncionario";
			txtUsuarioFuncionario.Size = new Size(203, 29);
			txtUsuarioFuncionario.TabIndex = 10;
			txtUsuarioFuncionario.KeyPress += txtUsuarioFuncionario_KeyPress;
			// 
			// txtContraseniaFuncionario
			// 
			txtContraseniaFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtContraseniaFuncionario.Location = new Point(489, 182);
			txtContraseniaFuncionario.Name = "txtContraseniaFuncionario";
			txtContraseniaFuncionario.Size = new Size(203, 29);
			txtContraseniaFuncionario.TabIndex = 11;
			txtContraseniaFuncionario.KeyPress += txtContraseniaFuncionario_KeyPress;
			// 
			// btnGuardar
			// 
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnGuardar.Location = new Point(12, 22);
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
			btnCancerlar.Location = new Point(580, 29);
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
			pbLogo.Location = new Point(12, 12);
			pbLogo.Name = "pbLogo";
			pbLogo.Size = new Size(106, 119);
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
			lblGenero.Location = new Point(3, 162);
			lblGenero.Name = "lblGenero";
			lblGenero.Size = new Size(106, 21);
			lblGenero.TabIndex = 17;
			lblGenero.Text = "Genero";
			lblGenero.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtTelefonoFuncionario
			// 
			txtTelefonoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTelefonoFuncionario.Location = new Point(130, 220);
			txtTelefonoFuncionario.Name = "txtTelefonoFuncionario";
			txtTelefonoFuncionario.Size = new Size(203, 29);
			txtTelefonoFuncionario.TabIndex = 22;
			txtTelefonoFuncionario.KeyPress += txtTelefonoFuncionario_KeyPress;
			// 
			// lblTelefono
			// 
			lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTelefono.Location = new Point(12, 223);
			lblTelefono.Name = "lblTelefono";
			lblTelefono.Size = new Size(106, 21);
			lblTelefono.TabIndex = 21;
			lblTelefono.Text = "Telefono";
			lblTelefono.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtEmailFuncionario
			// 
			txtEmailFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmailFuncionario.Location = new Point(489, 27);
			txtEmailFuncionario.Name = "txtEmailFuncionario";
			txtEmailFuncionario.Size = new Size(203, 29);
			txtEmailFuncionario.TabIndex = 24;
			txtEmailFuncionario.KeyPress += txtEmailFuncionario_KeyPress;
			// 
			// lblEmail
			// 
			lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEmail.Location = new Point(360, 30);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(106, 21);
			lblEmail.TabIndex = 23;
			lblEmail.Text = "Email";
			lblEmail.TextAlign = ContentAlignment.MiddleRight;
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
			gbTitulo.Controls.Add(gbBusquedaFuncionario);
			gbTitulo.Controls.Add(lblTitulo);
			gbTitulo.Controls.Add(pbLogo);
			gbTitulo.Dock = DockStyle.Top;
			gbTitulo.Location = new Point(0, 0);
			gbTitulo.Name = "gbTitulo";
			gbTitulo.Size = new Size(726, 186);
			gbTitulo.TabIndex = 28;
			gbTitulo.TabStop = false;
			// 
			// gbBusquedaFuncionario
			// 
			gbBusquedaFuncionario.Controls.Add(btnBuscar);
			gbBusquedaFuncionario.Controls.Add(txtBuscarIdFuncionario);
			gbBusquedaFuncionario.Controls.Add(lblBuscarIdFuncionario);
			gbBusquedaFuncionario.Dock = DockStyle.Bottom;
			gbBusquedaFuncionario.Location = new Point(3, 132);
			gbBusquedaFuncionario.Name = "gbBusquedaFuncionario";
			gbBusquedaFuncionario.Size = new Size(720, 51);
			gbBusquedaFuncionario.TabIndex = 15;
			gbBusquedaFuncionario.TabStop = false;
			// 
			// btnBuscar
			// 
			btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnBuscar.Location = new Point(620, 20);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(91, 28);
			btnBuscar.TabIndex = 29;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = true;
			// 
			// txtBuscarIdFuncionario
			// 
			txtBuscarIdFuncionario.Location = new Point(245, 22);
			txtBuscarIdFuncionario.Name = "txtBuscarIdFuncionario";
			txtBuscarIdFuncionario.Size = new Size(369, 23);
			txtBuscarIdFuncionario.TabIndex = 1;
			txtBuscarIdFuncionario.KeyPress += txtBuscarIdFuncionario_KeyPress;
			// 
			// lblBuscarIdFuncionario
			// 
			lblBuscarIdFuncionario.AutoSize = true;
			lblBuscarIdFuncionario.Location = new Point(9, 25);
			lblBuscarIdFuncionario.Name = "lblBuscarIdFuncionario";
			lblBuscarIdFuncionario.Size = new Size(223, 15);
			lblBuscarIdFuncionario.TabIndex = 0;
			lblBuscarIdFuncionario.Text = "Buscar por Identificacion del Funcionario";
			// 
			// gbDatosFuncionarios
			// 
			gbDatosFuncionarios.Controls.Add(rbtnGeneroFuncionario);
			gbDatosFuncionarios.Controls.Add(rbtnGeneroMFuncionario);
			gbDatosFuncionarios.Controls.Add(lblNombreFuncionario);
			gbDatosFuncionarios.Controls.Add(lblIdentificacionFuncionario);
			gbDatosFuncionarios.Controls.Add(lblPuesto);
			gbDatosFuncionarios.Controls.Add(lblContrasenia);
			gbDatosFuncionarios.Controls.Add(lblUsuario);
			gbDatosFuncionarios.Controls.Add(txtEmailFuncionario);
			gbDatosFuncionarios.Controls.Add(txtNombreFuncionario);
			gbDatosFuncionarios.Controls.Add(lblEmail);
			gbDatosFuncionarios.Controls.Add(txtIdentificacionFuncionario);
			gbDatosFuncionarios.Controls.Add(txtTelefonoFuncionario);
			gbDatosFuncionarios.Controls.Add(txtPuestoFuncionario);
			gbDatosFuncionarios.Controls.Add(lblTelefono);
			gbDatosFuncionarios.Controls.Add(txtUsuarioFuncionario);
			gbDatosFuncionarios.Controls.Add(txtContraseniaFuncionario);
			gbDatosFuncionarios.Controls.Add(lblApellidoFuncionario);
			gbDatosFuncionarios.Controls.Add(txtApellidoFuncionario);
			gbDatosFuncionarios.Controls.Add(lblGenero);
			gbDatosFuncionarios.Dock = DockStyle.Fill;
			gbDatosFuncionarios.Location = new Point(0, 186);
			gbDatosFuncionarios.Name = "gbDatosFuncionarios";
			gbDatosFuncionarios.Size = new Size(726, 370);
			gbDatosFuncionarios.TabIndex = 29;
			gbDatosFuncionarios.TabStop = false;
			gbDatosFuncionarios.Text = "Datos Funcionarios";
			// 
			// rbtnGeneroFuncionario
			// 
			rbtnGeneroFuncionario.AutoSize = true;
			rbtnGeneroFuncionario.Location = new Point(221, 165);
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
			rbtnGeneroMFuncionario.Location = new Point(135, 165);
			rbtnGeneroMFuncionario.Name = "rbtnGeneroMFuncionario";
			rbtnGeneroMFuncionario.Size = new Size(80, 19);
			rbtnGeneroMFuncionario.TabIndex = 27;
			rbtnGeneroMFuncionario.TabStop = true;
			rbtnGeneroMFuncionario.Text = "Masculino";
			rbtnGeneroMFuncionario.UseVisualStyleBackColor = true;
			// 
			// gbBotones
			// 
			gbBotones.Controls.Add(btnModificar);
			gbBotones.Controls.Add(btnGuardar);
			gbBotones.Controls.Add(btnCancerlar);
			gbBotones.Controls.Add(btnLimpiar);
			gbBotones.Dock = DockStyle.Bottom;
			gbBotones.Location = new Point(0, 487);
			gbBotones.Name = "gbBotones";
			gbBotones.Size = new Size(726, 69);
			gbBotones.TabIndex = 30;
			gbBotones.TabStop = false;
			// 
			// btnModificar
			// 
			btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnModificar.Location = new Point(462, 29);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(112, 28);
			btnModificar.TabIndex = 28;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = true;
			// 
			// frmFuncionarios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(726, 556);
			Controls.Add(gbBotones);
			Controls.Add(gbDatosFuncionarios);
			Controls.Add(gbTitulo);
			Name = "frmFuncionarios";
			Text = "Nuevos Funcionarios";
			Load += frmFuncionarios_Load;
			((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
			gbTitulo.ResumeLayout(false);
			gbBusquedaFuncionario.ResumeLayout(false);
			gbBusquedaFuncionario.PerformLayout();
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
		private TextBox txtTelefonoFuncionario;
		private Label lblTelefono;
		private TextBox txtEmailFuncionario;
		private Label lblEmail;
		private Button btnLimpiar;
		private GroupBox gbTitulo;
		private GroupBox gbDatosFuncionarios;
		private GroupBox gbBotones;
		private RadioButton rbtnGeneroFuncionario;
		private RadioButton rbtnGeneroMFuncionario;
		private Button btnModificar;
		private Button btnBuscar;
		private GroupBox gbBusquedaFuncionario;
		private Label lblBuscarIdFuncionario;
		private TextBox txtBuscarIdFuncionario;
	}
}