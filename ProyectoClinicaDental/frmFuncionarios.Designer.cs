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
			lblIdFuncionario = new Label();
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
			lblSexo = new Label();
			cboSexoFuncionario = new ComboBox();
			lblResEdadFuncionario = new Label();
			lblEdad = new Label();
			txtTelefonoFuncionario = new TextBox();
			lblTelefono = new Label();
			txtEmailFuncionario = new TextBox();
			lblEmail = new Label();
			lblFechaNacimientoFuncionario = new Label();
			dtpFechaNacFuncionario = new DateTimePicker();
			btnLimpiar = new Button();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			groupBox3 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// lblTitulo
			// 
			lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitulo.Location = new Point(6, 19);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(366, 51);
			lblTitulo.TabIndex = 0;
			lblTitulo.Text = "Ingrese los datos para Nuevos Funcionarios de la Clinica Dental Happy Teeth";
			lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNombreFuncionario
			// 
			lblNombreFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombreFuncionario.Location = new Point(6, 21);
			lblNombreFuncionario.Name = "lblNombreFuncionario";
			lblNombreFuncionario.Size = new Size(106, 21);
			lblNombreFuncionario.TabIndex = 1;
			lblNombreFuncionario.Text = "Nombre ";
			lblNombreFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblIdFuncionario
			// 
			lblIdFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdFuncionario.Location = new Point(6, 113);
			lblIdFuncionario.Name = "lblIdFuncionario";
			lblIdFuncionario.Size = new Size(106, 21);
			lblIdFuncionario.TabIndex = 2;
			lblIdFuncionario.Text = "Identificacion";
			lblIdFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblPuesto
			// 
			lblPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblPuesto.Location = new Point(360, 113);
			lblPuesto.Name = "lblPuesto";
			lblPuesto.Size = new Size(106, 21);
			lblPuesto.TabIndex = 3;
			lblPuesto.Text = "Puesto";
			lblPuesto.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblContrasenia
			// 
			lblContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblContrasenia.Location = new Point(360, 204);
			lblContrasenia.Name = "lblContrasenia";
			lblContrasenia.Size = new Size(106, 21);
			lblContrasenia.TabIndex = 5;
			lblContrasenia.Text = "Contrasena";
			lblContrasenia.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblUsuario
			// 
			lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsuario.Location = new Point(360, 162);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(106, 21);
			lblUsuario.TabIndex = 6;
			lblUsuario.Text = "Usuario";
			lblUsuario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// txtNombreFuncionario
			// 
			txtNombreFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombreFuncionario.Location = new Point(135, 13);
			txtNombreFuncionario.Name = "txtNombreFuncionario";
			txtNombreFuncionario.Size = new Size(203, 29);
			txtNombreFuncionario.TabIndex = 7;
			txtNombreFuncionario.KeyPress += txtNombreFuncionario_KeyPress;
			// 
			// txtIdentificacionFuncionario
			// 
			txtIdentificacionFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtIdentificacionFuncionario.Location = new Point(135, 105);
			txtIdentificacionFuncionario.Name = "txtIdentificacionFuncionario";
			txtIdentificacionFuncionario.Size = new Size(203, 29);
			txtIdentificacionFuncionario.TabIndex = 8;
			txtIdentificacionFuncionario.KeyPress += txtIdentificacionFuncionario_KeyPress;
			// 
			// txtPuestoFuncionario
			// 
			txtPuestoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPuestoFuncionario.Location = new Point(489, 105);
			txtPuestoFuncionario.Name = "txtPuestoFuncionario";
			txtPuestoFuncionario.Size = new Size(203, 29);
			txtPuestoFuncionario.TabIndex = 9;
			txtPuestoFuncionario.KeyPress += txtPuestoFuncionario_KeyPress;
			// 
			// txtUsuarioFuncionario
			// 
			txtUsuarioFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsuarioFuncionario.Location = new Point(489, 152);
			txtUsuarioFuncionario.Name = "txtUsuarioFuncionario";
			txtUsuarioFuncionario.Size = new Size(203, 29);
			txtUsuarioFuncionario.TabIndex = 10;
			txtUsuarioFuncionario.KeyPress += txtUsuarioFuncionario_KeyPress;
			// 
			// txtContraseniaFuncionario
			// 
			txtContraseniaFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtContraseniaFuncionario.Location = new Point(489, 201);
			txtContraseniaFuncionario.Name = "txtContraseniaFuncionario";
			txtContraseniaFuncionario.Size = new Size(203, 29);
			txtContraseniaFuncionario.TabIndex = 11;
			// 
			// btnGuardar
			// 
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnGuardar.Location = new Point(6, 22);
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
			btnCancerlar.Location = new Point(301, 22);
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
			pbLogo.Location = new Point(101, 73);
			pbLogo.Name = "pbLogo";
			pbLogo.Size = new Size(182, 219);
			pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pbLogo.TabIndex = 14;
			pbLogo.TabStop = false;
			// 
			// txtApellidoFuncionario
			// 
			txtApellidoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtApellidoFuncionario.Location = new Point(135, 60);
			txtApellidoFuncionario.Name = "txtApellidoFuncionario";
			txtApellidoFuncionario.Size = new Size(203, 29);
			txtApellidoFuncionario.TabIndex = 16;
			txtApellidoFuncionario.KeyPress += txtApellidoFuncionario_KeyPress;
			// 
			// lblApellidoFuncionario
			// 
			lblApellidoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblApellidoFuncionario.Location = new Point(6, 68);
			lblApellidoFuncionario.Name = "lblApellidoFuncionario";
			lblApellidoFuncionario.Size = new Size(106, 21);
			lblApellidoFuncionario.TabIndex = 15;
			lblApellidoFuncionario.Text = "Apellido";
			lblApellidoFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSexo
			// 
			lblSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblSexo.Location = new Point(6, 243);
			lblSexo.Name = "lblSexo";
			lblSexo.Size = new Size(106, 21);
			lblSexo.TabIndex = 17;
			lblSexo.Text = "Sexo";
			lblSexo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cboSexoFuncionario
			// 
			cboSexoFuncionario.FormattingEnabled = true;
			cboSexoFuncionario.Items.AddRange(new object[] { "Masculino", "Femenino" });
			cboSexoFuncionario.Location = new Point(135, 243);
			cboSexoFuncionario.Name = "cboSexoFuncionario";
			cboSexoFuncionario.Size = new Size(203, 23);
			cboSexoFuncionario.TabIndex = 18;
			// 
			// lblResEdadFuncionario
			// 
			lblResEdadFuncionario.BackColor = SystemColors.ActiveBorder;
			lblResEdadFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblResEdadFuncionario.Location = new Point(135, 196);
			lblResEdadFuncionario.Name = "lblResEdadFuncionario";
			lblResEdadFuncionario.Size = new Size(203, 29);
			lblResEdadFuncionario.TabIndex = 19;
			lblResEdadFuncionario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblEdad
			// 
			lblEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblEdad.Location = new Point(6, 204);
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
			lblFechaNacimientoFuncionario.Location = new Point(6, 152);
			lblFechaNacimientoFuncionario.Name = "lblFechaNacimientoFuncionario";
			lblFechaNacimientoFuncionario.Size = new Size(106, 40);
			lblFechaNacimientoFuncionario.TabIndex = 25;
			lblFechaNacimientoFuncionario.Text = "Fecha Nacimiento";
			lblFechaNacimientoFuncionario.TextAlign = ContentAlignment.MiddleRight;
			// 
			// dtpFechaNacFuncionario
			// 
			dtpFechaNacFuncionario.Location = new Point(135, 160);
			dtpFechaNacFuncionario.Name = "dtpFechaNacFuncionario";
			dtpFechaNacFuncionario.Size = new Size(203, 23);
			dtpFechaNacFuncionario.TabIndex = 26;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLimpiar.Location = new Point(157, 22);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(112, 28);
			btnLimpiar.TabIndex = 27;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lblTitulo);
			groupBox1.Controls.Add(pbLogo);
			groupBox1.Location = new Point(197, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(371, 321);
			groupBox1.TabIndex = 28;
			groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lblNombreFuncionario);
			groupBox2.Controls.Add(lblIdFuncionario);
			groupBox2.Controls.Add(lblPuesto);
			groupBox2.Controls.Add(dtpFechaNacFuncionario);
			groupBox2.Controls.Add(lblContrasenia);
			groupBox2.Controls.Add(lblFechaNacimientoFuncionario);
			groupBox2.Controls.Add(lblUsuario);
			groupBox2.Controls.Add(txtEmailFuncionario);
			groupBox2.Controls.Add(txtNombreFuncionario);
			groupBox2.Controls.Add(lblEmail);
			groupBox2.Controls.Add(txtIdentificacionFuncionario);
			groupBox2.Controls.Add(txtTelefonoFuncionario);
			groupBox2.Controls.Add(txtPuestoFuncionario);
			groupBox2.Controls.Add(lblTelefono);
			groupBox2.Controls.Add(txtUsuarioFuncionario);
			groupBox2.Controls.Add(lblEdad);
			groupBox2.Controls.Add(txtContraseniaFuncionario);
			groupBox2.Controls.Add(lblResEdadFuncionario);
			groupBox2.Controls.Add(lblApellidoFuncionario);
			groupBox2.Controls.Add(cboSexoFuncionario);
			groupBox2.Controls.Add(txtApellidoFuncionario);
			groupBox2.Controls.Add(lblSexo);
			groupBox2.Location = new Point(12, 339);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(720, 280);
			groupBox2.TabIndex = 29;
			groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btnGuardar);
			groupBox3.Controls.Add(btnCancerlar);
			groupBox3.Controls.Add(btnLimpiar);
			groupBox3.Location = new Point(197, 625);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(426, 59);
			groupBox3.TabIndex = 30;
			groupBox3.TabStop = false;
			// 
			// frmFuncionarios
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(767, 721);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "frmFuncionarios";
			Text = "Nuevos Funcionarios";
			Load += frmFuncionarios_Load;
			((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label lblTitulo;
		private Label lblNombreFuncionario;
		private Label lblIdFuncionario;
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
		private Label lblSexo;
		private ComboBox cboSexoFuncionario;
		private Label lblResEdadFuncionario;
		private Label lblEdad;
		private TextBox txtTelefonoFuncionario;
		private Label lblTelefono;
		private TextBox txtEmailFuncionario;
		private Label lblEmail;
		private Label lblFechaNacimientoFuncionario;
		private DateTimePicker dtpFechaNacFuncionario;
		private Button btnLimpiar;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
	}
}