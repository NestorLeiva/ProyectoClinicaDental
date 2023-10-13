namespace ProyectoClinicaDental
{
    partial class frmLogin
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
            lblUsuario = new Label();
            lblContrasenia = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(53, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(278, 86);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio Sesion Clinica Denta Happy Teeth";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(93, 344);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(212, 35);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(93, 418);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(212, 35);
            lblContrasenia.TabIndex = 2;
            lblContrasenia.Text = "Contrasena";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(93, 382);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(212, 33);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(93, 456);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(212, 33);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(39, 510);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 35);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(213, 510);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 35);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logoClinica;
            pbLogo.Location = new Point(93, 113);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(203, 210);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 571);
            Controls.Add(pbLogo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "frmLogin";
            Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblContrasenia;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Button btnAceptar;
        private Button btnLimpiar;
        private PictureBox pbLogo;
    }
}