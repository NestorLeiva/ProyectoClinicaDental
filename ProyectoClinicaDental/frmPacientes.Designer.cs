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
            lblEdadRes = new Label();
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
            txtIdPadre = new TextBox();
            textBox4 = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccionProvincia = new TextBox();
            txtDireccionCanton = new TextBox();
            textBox10 = new TextBox();
            txtDieccionOtrasSenas = new TextBox();
            txtDireccionDistrito = new TextBox();
            textBox7 = new TextBox();
            dtpFechaNac = new DateTimePicker();
            cboSexo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            cboSexoHijo = new ComboBox();
            lblTelefonoHijo = new Label();
            lblEmailHijo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            lblDatosPadre = new Label();
            lblTituloHijo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logoClinica;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(125, 136);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(244, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Pacientes ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombrePadre
            // 
            lblNombrePadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombrePadre.Location = new Point(22, 198);
            lblNombrePadre.Name = "lblNombrePadre";
            lblNombrePadre.Size = new Size(141, 23);
            lblNombrePadre.TabIndex = 2;
            lblNombrePadre.Text = "Nombre del Padre";
            lblNombrePadre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblApellidoPadre
            // 
            lblApellidoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidoPadre.Location = new Point(22, 233);
            lblApellidoPadre.Name = "lblApellidoPadre";
            lblApellidoPadre.Size = new Size(141, 23);
            lblApellidoPadre.TabIndex = 3;
            lblApellidoPadre.Text = "Apellido del Padre";
            lblApellidoPadre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIdPadre
            // 
            lblIdPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdPadre.Location = new Point(22, 268);
            lblIdPadre.Name = "lblIdPadre";
            lblIdPadre.Size = new Size(141, 23);
            lblIdPadre.TabIndex = 4;
            lblIdPadre.Text = "Id del Padre";
            lblIdPadre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSexo
            // 
            lblSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexo.Location = new Point(22, 379);
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
            lblTelefono.Location = new Point(22, 408);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(141, 23);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            lblTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProvincia
            // 
            lblProvincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProvincia.Location = new Point(22, 519);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(141, 23);
            lblProvincia.TabIndex = 8;
            lblProvincia.Text = "Provincia";
            lblProvincia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(22, 443);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(141, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCanton
            // 
            lblCanton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCanton.Location = new Point(22, 554);
            lblCanton.Name = "lblCanton";
            lblCanton.Size = new Size(141, 23);
            lblCanton.TabIndex = 10;
            lblCanton.Text = "Canton";
            lblCanton.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOtrasSenas
            // 
            lblOtrasSenas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOtrasSenas.Location = new Point(22, 624);
            lblOtrasSenas.Name = "lblOtrasSenas";
            lblOtrasSenas.Size = new Size(141, 23);
            lblOtrasSenas.TabIndex = 11;
            lblOtrasSenas.Text = "Otras Senas";
            lblOtrasSenas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDistrito
            // 
            lblDistrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDistrito.Location = new Point(22, 589);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(141, 23);
            lblDistrito.TabIndex = 12;
            lblDistrito.Text = "Distrito";
            lblDistrito.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEdadRes
            // 
            lblEdadRes.BackColor = SystemColors.ActiveBorder;
            lblEdadRes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdadRes.Location = new Point(169, 335);
            lblEdadRes.Name = "lblEdadRes";
            lblEdadRes.Size = new Size(169, 29);
            lblEdadRes.TabIndex = 13;
            lblEdadRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdad
            // 
            lblEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(22, 344);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(141, 23);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "Edad";
            lblEdad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFechaNacPadre
            // 
            lblFechaNacPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacPadre.Location = new Point(22, 309);
            lblFechaNacPadre.Name = "lblFechaNacPadre";
            lblFechaNacPadre.Size = new Size(141, 23);
            lblFechaNacPadre.TabIndex = 15;
            lblFechaNacPadre.Text = "Fecha Nacimiento";
            lblFechaNacPadre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombreHijo
            // 
            lblNombreHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreHijo.Location = new Point(344, 204);
            lblNombreHijo.Name = "lblNombreHijo";
            lblNombreHijo.Size = new Size(168, 23);
            lblNombreHijo.TabIndex = 16;
            lblNombreHijo.Text = "Nombre Hijo";
            lblNombreHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblApellidoHijo
            // 
            lblApellidoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidoHijo.Location = new Point(344, 239);
            lblApellidoHijo.Name = "lblApellidoHijo";
            lblApellidoHijo.Size = new Size(168, 23);
            lblApellidoHijo.TabIndex = 17;
            lblApellidoHijo.Text = "Apellido Hijo";
            lblApellidoHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFechaNacHijo
            // 
            lblFechaNacHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacHijo.Location = new Point(344, 309);
            lblFechaNacHijo.Name = "lblFechaNacHijo";
            lblFechaNacHijo.Size = new Size(168, 23);
            lblFechaNacHijo.TabIndex = 18;
            lblFechaNacHijo.Text = "Fecha Nacimiento Hijo";
            lblFechaNacHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIdHijo
            // 
            lblIdHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdHijo.Location = new Point(344, 274);
            lblIdHijo.Name = "lblIdHijo";
            lblIdHijo.Size = new Size(168, 23);
            lblIdHijo.TabIndex = 19;
            lblIdHijo.Text = "Id Hijo";
            lblIdHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSexoHijo
            // 
            lblSexoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexoHijo.Location = new Point(344, 379);
            lblSexoHijo.Name = "lblSexoHijo";
            lblSexoHijo.Size = new Size(168, 23);
            lblSexoHijo.TabIndex = 20;
            lblSexoHijo.Text = "Sexo Hijo";
            lblSexoHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEdadHijo
            // 
            lblEdadHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdadHijo.Location = new Point(344, 344);
            lblEdadHijo.Name = "lblEdadHijo";
            lblEdadHijo.Size = new Size(168, 23);
            lblEdadHijo.TabIndex = 21;
            lblEdadHijo.Text = "Edad";
            lblEdadHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombrePadre
            // 
            txtNombrePadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombrePadre.Location = new Point(169, 198);
            txtNombrePadre.Name = "txtNombrePadre";
            txtNombrePadre.Size = new Size(169, 29);
            txtNombrePadre.TabIndex = 23;
            // 
            // txtApellidoPadre
            // 
            txtApellidoPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoPadre.Location = new Point(169, 233);
            txtApellidoPadre.Name = "txtApellidoPadre";
            txtApellidoPadre.Size = new Size(169, 29);
            txtApellidoPadre.TabIndex = 24;
            // 
            // txtIdPadre
            // 
            txtIdPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdPadre.Location = new Point(169, 268);
            txtIdPadre.Name = "txtIdPadre";
            txtIdPadre.Size = new Size(169, 29);
            txtIdPadre.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(518, 443);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 29);
            textBox4.TabIndex = 26;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(169, 408);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(169, 29);
            txtTelefono.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(169, 443);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 29);
            txtEmail.TabIndex = 28;
            // 
            // txtDireccionProvincia
            // 
            txtDireccionProvincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccionProvincia.Location = new Point(169, 513);
            txtDireccionProvincia.Name = "txtDireccionProvincia";
            txtDireccionProvincia.Size = new Size(169, 29);
            txtDireccionProvincia.TabIndex = 30;
            // 
            // txtDireccionCanton
            // 
            txtDireccionCanton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccionCanton.Location = new Point(169, 548);
            txtDireccionCanton.Name = "txtDireccionCanton";
            txtDireccionCanton.Size = new Size(169, 29);
            txtDireccionCanton.TabIndex = 31;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(518, 198);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(169, 29);
            textBox10.TabIndex = 32;
            // 
            // txtDieccionOtrasSenas
            // 
            txtDieccionOtrasSenas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDieccionOtrasSenas.Location = new Point(169, 618);
            txtDieccionOtrasSenas.Name = "txtDieccionOtrasSenas";
            txtDieccionOtrasSenas.Size = new Size(169, 29);
            txtDieccionOtrasSenas.TabIndex = 33;
            // 
            // txtDireccionDistrito
            // 
            txtDireccionDistrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccionDistrito.Location = new Point(169, 583);
            txtDireccionDistrito.Name = "txtDireccionDistrito";
            txtDireccionDistrito.Size = new Size(169, 29);
            txtDireccionDistrito.TabIndex = 34;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(518, 408);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 29);
            textBox7.TabIndex = 35;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(169, 309);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(169, 23);
            dtpFechaNac.TabIndex = 36;
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Seleccione", "Hombre", "Mujer" });
            cboSexo.Location = new Point(169, 379);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(169, 23);
            cboSexo.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(518, 309);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(169, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(518, 344);
            label1.Name = "label1";
            label1.Size = new Size(169, 29);
            label1.TabIndex = 38;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboSexoHijo
            // 
            cboSexoHijo.FormattingEnabled = true;
            cboSexoHijo.Items.AddRange(new object[] { "Seleccione", "Hombre", "Mujer" });
            cboSexoHijo.Location = new Point(518, 382);
            cboSexoHijo.Name = "cboSexoHijo";
            cboSexoHijo.Size = new Size(169, 23);
            cboSexoHijo.TabIndex = 40;
            // 
            // lblTelefonoHijo
            // 
            lblTelefonoHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefonoHijo.Location = new Point(344, 414);
            lblTelefonoHijo.Name = "lblTelefonoHijo";
            lblTelefonoHijo.Size = new Size(168, 23);
            lblTelefonoHijo.TabIndex = 42;
            lblTelefonoHijo.Text = "Telefono Hijo";
            lblTelefonoHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmailHijo
            // 
            lblEmailHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailHijo.Location = new Point(344, 449);
            lblEmailHijo.Name = "lblEmailHijo";
            lblEmailHijo.Size = new Size(168, 23);
            lblEmailHijo.TabIndex = 45;
            lblEmailHijo.Text = "Email Hijo";
            lblEmailHijo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(518, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 29);
            textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(518, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 29);
            textBox2.TabIndex = 49;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(193, 710);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 30);
            btnGuardar.TabIndex = 54;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(429, 710);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 30);
            btnLimpiar.TabIndex = 55;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(311, 710);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 30);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDatosPadre
            // 
            lblDatosPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosPadre.Location = new Point(22, 162);
            lblDatosPadre.Name = "lblDatosPadre";
            lblDatosPadre.Size = new Size(316, 23);
            lblDatosPadre.TabIndex = 57;
            lblDatosPadre.Text = "Datos del Padre";
            lblDatosPadre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloHijo
            // 
            lblTituloHijo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloHijo.Location = new Point(344, 162);
            lblTituloHijo.Name = "lblTituloHijo";
            lblTituloHijo.Size = new Size(343, 23);
            lblTituloHijo.TabIndex = 58;
            lblTituloHijo.Text = "Datos del Hijo";
            lblTituloHijo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 752);
            Controls.Add(lblTituloHijo);
            Controls.Add(lblDatosPadre);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblEmailHijo);
            Controls.Add(lblTelefonoHijo);
            Controls.Add(cboSexoHijo);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(cboSexo);
            Controls.Add(dtpFechaNac);
            Controls.Add(textBox7);
            Controls.Add(txtDireccionDistrito);
            Controls.Add(txtDieccionOtrasSenas);
            Controls.Add(textBox10);
            Controls.Add(txtDireccionCanton);
            Controls.Add(txtDireccionProvincia);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(textBox4);
            Controls.Add(txtIdPadre);
            Controls.Add(txtApellidoPadre);
            Controls.Add(txtNombrePadre);
            Controls.Add(lblEdadHijo);
            Controls.Add(lblSexoHijo);
            Controls.Add(lblIdHijo);
            Controls.Add(lblFechaNacHijo);
            Controls.Add(lblApellidoHijo);
            Controls.Add(lblNombreHijo);
            Controls.Add(lblFechaNacPadre);
            Controls.Add(lblEdad);
            Controls.Add(lblEdadRes);
            Controls.Add(lblDistrito);
            Controls.Add(lblOtrasSenas);
            Controls.Add(lblCanton);
            Controls.Add(lblEmail);
            Controls.Add(lblProvincia);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblSexo);
            Controls.Add(lblIdPadre);
            Controls.Add(lblApellidoPadre);
            Controls.Add(lblNombrePadre);
            Controls.Add(lblTitulo);
            Controls.Add(pbLogo);
            Name = "frmPacientes";
            Text = "Registro Pacientes";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblEdadRes;
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
        private TextBox txtIdPadre;
        private TextBox textBox4;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDireccionProvincia;
        private TextBox txtDireccionCanton;
        private TextBox textBox10;
        private TextBox txtDieccionOtrasSenas;
        private TextBox txtDireccionDistrito;
        private TextBox textBox7;
        private DateTimePicker dtpFechaNac;
        private ComboBox cboSexo;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox cboSexoHijo;
        private Label lblTelefonoHijo;
        private Label lblEmailHijo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Label lblDatosPadre;
        private Label lblTituloHijo;
    }
}