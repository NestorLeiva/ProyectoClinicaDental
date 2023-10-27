namespace ProyectoClinicaDental
{
	partial class frmConsultaHistoria
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
			gbConsultaHijo = new GroupBox();
			lblModificar = new Label();
			btnModificar = new Button();
			btnBusqueda = new Button();
			txtBusquedaIdentificacion = new TextBox();
			lblIdBusqueda = new Label();
			gbListaConsulta = new GroupBox();
			lvwListaPacientes = new ListView();
			colID = new ColumnHeader();
			colNombre = new ColumnHeader();
			colApellidoPrimero = new ColumnHeader();
			colApelldidoSegundo = new ColumnHeader();
			colFechaNacimiento = new ColumnHeader();
			colEdad = new ColumnHeader();
			colGenero = new ColumnHeader();
			colTelefono = new ColumnHeader();
			gbConsultarPadres = new GroupBox();
			lblFilaConsulta = new Label();
			btnModificarPadre = new Button();
			btnConsultarIdPadre = new Button();
			txtConsutarIdPadre = new TextBox();
			lblConsultaIdPadre = new Label();
			gbListaConsultaPadre = new GroupBox();
			lvwListaPadres = new ListView();
			colIdPadre = new ColumnHeader();
			colNombrePadre = new ColumnHeader();
			colApellidoPrimeroPadre = new ColumnHeader();
			colApellidoSegundoPadre = new ColumnHeader();
			colGeneroPadre = new ColumnHeader();
			colTelefonoPadre = new ColumnHeader();
			colEmailPadre = new ColumnHeader();
			colProvincia = new ColumnHeader();
			colCanton = new ColumnHeader();
			colDistrito = new ColumnHeader();
			colOtrasSenias = new ColumnHeader();
			gbConsultaHijo.SuspendLayout();
			gbListaConsulta.SuspendLayout();
			gbConsultarPadres.SuspendLayout();
			gbListaConsultaPadre.SuspendLayout();
			SuspendLayout();
			// 
			// gbConsultaHijo
			// 
			gbConsultaHijo.Controls.Add(lblModificar);
			gbConsultaHijo.Controls.Add(btnModificar);
			gbConsultaHijo.Controls.Add(btnBusqueda);
			gbConsultaHijo.Controls.Add(txtBusquedaIdentificacion);
			gbConsultaHijo.Controls.Add(lblIdBusqueda);
			gbConsultaHijo.Dock = DockStyle.Top;
			gbConsultaHijo.Location = new Point(0, 0);
			gbConsultaHijo.Name = "gbConsultaHijo";
			gbConsultaHijo.Size = new Size(779, 85);
			gbConsultaHijo.TabIndex = 65;
			gbConsultaHijo.TabStop = false;
			gbConsultaHijo.Text = "Consultar Hijo";
			// 
			// lblModificar
			// 
			lblModificar.AutoSize = true;
			lblModificar.Location = new Point(6, 60);
			lblModificar.Name = "lblModificar";
			lblModificar.Size = new Size(146, 15);
			lblModificar.TabIndex = 4;
			lblModificar.Text = "Marque la fila del paciente";
			// 
			// btnModificar
			// 
			btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnModificar.Location = new Point(528, 50);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(118, 31);
			btnModificar.TabIndex = 3;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnBusqueda
			// 
			btnBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnBusqueda.Location = new Point(528, 18);
			btnBusqueda.Name = "btnBusqueda";
			btnBusqueda.Size = new Size(118, 31);
			btnBusqueda.TabIndex = 2;
			btnBusqueda.Text = "Consultar";
			btnBusqueda.UseVisualStyleBackColor = true;
			btnBusqueda.Click += btnBusqueda_Click;
			// 
			// txtBusquedaIdentificacion
			// 
			txtBusquedaIdentificacion.Location = new Point(158, 22);
			txtBusquedaIdentificacion.MaxLength = 10;
			txtBusquedaIdentificacion.Name = "txtBusquedaIdentificacion";
			txtBusquedaIdentificacion.Size = new Size(343, 23);
			txtBusquedaIdentificacion.TabIndex = 1;
			txtBusquedaIdentificacion.KeyPress += txtBusquedaIdentificacion_KeyPress;
			// 
			// lblIdBusqueda
			// 
			lblIdBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdBusqueda.Location = new Point(42, 22);
			lblIdBusqueda.Name = "lblIdBusqueda";
			lblIdBusqueda.Size = new Size(110, 23);
			lblIdBusqueda.TabIndex = 0;
			lblIdBusqueda.Text = "Buscar por Id ";
			// 
			// gbListaConsulta
			// 
			gbListaConsulta.Controls.Add(lvwListaPacientes);
			gbListaConsulta.Location = new Point(0, 91);
			gbListaConsulta.Name = "gbListaConsulta";
			gbListaConsulta.Size = new Size(780, 236);
			gbListaConsulta.TabIndex = 66;
			gbListaConsulta.TabStop = false;
			// 
			// lvwListaPacientes
			// 
			lvwListaPacientes.BackColor = SystemColors.Info;
			lvwListaPacientes.Columns.AddRange(new ColumnHeader[] { colID, colNombre, colApellidoPrimero, colApelldidoSegundo, colFechaNacimiento, colEdad, colGenero, colTelefono });
			lvwListaPacientes.Dock = DockStyle.Fill;
			lvwListaPacientes.GridLines = true;
			lvwListaPacientes.LabelEdit = true;
			lvwListaPacientes.Location = new Point(3, 19);
			lvwListaPacientes.Name = "lvwListaPacientes";
			lvwListaPacientes.Size = new Size(774, 214);
			lvwListaPacientes.TabIndex = 0;
			lvwListaPacientes.UseCompatibleStateImageBehavior = false;
			lvwListaPacientes.View = View.Details;
			// 
			// colID
			// 
			colID.Text = "Identificacion";
			colID.Width = 100;
			// 
			// colNombre
			// 
			colNombre.Text = "Nombre";
			colNombre.Width = 100;
			// 
			// colApellidoPrimero
			// 
			colApellidoPrimero.Text = "Primer Apellido";
			colApellidoPrimero.Width = 100;
			// 
			// colApelldidoSegundo
			// 
			colApelldidoSegundo.Text = "Segundo Apellido";
			colApelldidoSegundo.Width = 110;
			// 
			// colFechaNacimiento
			// 
			colFechaNacimiento.Text = "Fecha Nacimiento";
			colFechaNacimiento.Width = 110;
			// 
			// colEdad
			// 
			colEdad.Text = "Edad";
			colEdad.Width = 100;
			// 
			// colGenero
			// 
			colGenero.Text = "Genero";
			colGenero.Width = 100;
			// 
			// colTelefono
			// 
			colTelefono.Text = "Telefono";
			colTelefono.Width = 110;
			// 
			// gbConsultarPadres
			// 
			gbConsultarPadres.Controls.Add(lblFilaConsulta);
			gbConsultarPadres.Controls.Add(btnModificarPadre);
			gbConsultarPadres.Controls.Add(btnConsultarIdPadre);
			gbConsultarPadres.Controls.Add(txtConsutarIdPadre);
			gbConsultarPadres.Controls.Add(lblConsultaIdPadre);
			gbConsultarPadres.Location = new Point(0, 330);
			gbConsultarPadres.Name = "gbConsultarPadres";
			gbConsultarPadres.Size = new Size(779, 92);
			gbConsultarPadres.TabIndex = 67;
			gbConsultarPadres.TabStop = false;
			gbConsultarPadres.Text = "Consultar Padre";
			// 
			// lblFilaConsulta
			// 
			lblFilaConsulta.AutoSize = true;
			lblFilaConsulta.Location = new Point(6, 60);
			lblFilaConsulta.Name = "lblFilaConsulta";
			lblFilaConsulta.Size = new Size(146, 15);
			lblFilaConsulta.TabIndex = 4;
			lblFilaConsulta.Text = "Marque la fila del paciente";
			// 
			// btnModificarPadre
			// 
			btnModificarPadre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnModificarPadre.Location = new Point(528, 50);
			btnModificarPadre.Name = "btnModificarPadre";
			btnModificarPadre.Size = new Size(118, 31);
			btnModificarPadre.TabIndex = 6;
			btnModificarPadre.Text = "Modificar";
			btnModificarPadre.UseVisualStyleBackColor = true;
			// 
			// btnConsultarIdPadre
			// 
			btnConsultarIdPadre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			btnConsultarIdPadre.Location = new Point(528, 14);
			btnConsultarIdPadre.Name = "btnConsultarIdPadre";
			btnConsultarIdPadre.Size = new Size(118, 31);
			btnConsultarIdPadre.TabIndex = 5;
			btnConsultarIdPadre.Text = "Consultar";
			btnConsultarIdPadre.UseVisualStyleBackColor = true;
			// 
			// txtConsutarIdPadre
			// 
			txtConsutarIdPadre.Location = new Point(179, 19);
			txtConsutarIdPadre.MaxLength = 10;
			txtConsutarIdPadre.Name = "txtConsutarIdPadre";
			txtConsutarIdPadre.Size = new Size(343, 23);
			txtConsutarIdPadre.TabIndex = 4;
			// 
			// lblConsultaIdPadre
			// 
			lblConsultaIdPadre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblConsultaIdPadre.Location = new Point(35, 19);
			lblConsultaIdPadre.Name = "lblConsultaIdPadre";
			lblConsultaIdPadre.Size = new Size(117, 23);
			lblConsultaIdPadre.TabIndex = 0;
			lblConsultaIdPadre.Text = "Buscar por Id ";
			// 
			// gbListaConsultaPadre
			// 
			gbListaConsultaPadre.Controls.Add(lvwListaPadres);
			gbListaConsultaPadre.Location = new Point(0, 428);
			gbListaConsultaPadre.Name = "gbListaConsultaPadre";
			gbListaConsultaPadre.Size = new Size(780, 316);
			gbListaConsultaPadre.TabIndex = 68;
			gbListaConsultaPadre.TabStop = false;
			// 
			// lvwListaPadres
			// 
			lvwListaPadres.BackColor = SystemColors.Info;
			lvwListaPadres.Columns.AddRange(new ColumnHeader[] { colIdPadre, colNombrePadre, colApellidoPrimeroPadre, colApellidoSegundoPadre, colGeneroPadre, colTelefonoPadre, colEmailPadre, colProvincia, colCanton, colDistrito, colOtrasSenias });
			lvwListaPadres.Dock = DockStyle.Fill;
			lvwListaPadres.GridLines = true;
			lvwListaPadres.LabelEdit = true;
			lvwListaPadres.Location = new Point(3, 19);
			lvwListaPadres.Name = "lvwListaPadres";
			lvwListaPadres.Size = new Size(774, 294);
			lvwListaPadres.TabIndex = 0;
			lvwListaPadres.UseCompatibleStateImageBehavior = false;
			lvwListaPadres.View = View.Details;
			// 
			// colIdPadre
			// 
			colIdPadre.Text = "Identificacion";
			colIdPadre.Width = 100;
			// 
			// colNombrePadre
			// 
			colNombrePadre.Text = "Nombre";
			colNombrePadre.Width = 100;
			// 
			// colApellidoPrimeroPadre
			// 
			colApellidoPrimeroPadre.Text = "Primer Apellido";
			colApellidoPrimeroPadre.Width = 100;
			// 
			// colApellidoSegundoPadre
			// 
			colApellidoSegundoPadre.Text = "Segundo Apellido";
			colApellidoSegundoPadre.Width = 110;
			// 
			// colGeneroPadre
			// 
			colGeneroPadre.Text = "Genero";
			colGeneroPadre.Width = 100;
			// 
			// colTelefonoPadre
			// 
			colTelefonoPadre.Text = "Telefono";
			colTelefonoPadre.Width = 100;
			// 
			// colEmailPadre
			// 
			colEmailPadre.Text = "Email";
			colEmailPadre.Width = 100;
			// 
			// colProvincia
			// 
			colProvincia.Text = "Provincia";
			colProvincia.Width = 100;
			// 
			// colCanton
			// 
			colCanton.Text = "Canton";
			colCanton.Width = 100;
			// 
			// colDistrito
			// 
			colDistrito.Text = "Distrito";
			colDistrito.Width = 100;
			// 
			// colOtrasSenias
			// 
			colOtrasSenias.Text = "OtrasSenas";
			colOtrasSenias.Width = 100;
			// 
			// frmConsultaHistoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(779, 744);
			Controls.Add(gbListaConsultaPadre);
			Controls.Add(gbConsultarPadres);
			Controls.Add(gbListaConsulta);
			Controls.Add(gbConsultaHijo);
			Name = "frmConsultaHistoria";
			Text = "Consulta Historial Paciente";
			Load += frmConsultaHistoria_Load;
			gbConsultaHijo.ResumeLayout(false);
			gbConsultaHijo.PerformLayout();
			gbListaConsulta.ResumeLayout(false);
			gbConsultarPadres.ResumeLayout(false);
			gbConsultarPadres.PerformLayout();
			gbListaConsultaPadre.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbConsultaHijo;
		private Button btnBusqueda;
		private TextBox txtBusquedaIdentificacion;
		private Label lblIdBusqueda;
		private GroupBox gbListaConsulta;
		private ListView lvwListaPacientes;
		private Label lblModificar;
		private Button btnModificar;
		private ColumnHeader colNombre;
		private ColumnHeader colApellidoPrimero;
		private ColumnHeader colApelldidoSegundo;
		private ColumnHeader colFechaNacimiento;
		private ColumnHeader colGenero;
		private ColumnHeader colTelefono;
		private ColumnHeader colEdad;
		private ColumnHeader colID;
		private GroupBox gbConsultarPadres;
		private Label lblFilaConsulta;
		private Button btnModificarPadre;
		private Button btnConsultarIdPadre;
		private TextBox txtConsutarIdPadre;
		private Label lblConsultaIdPadre;
		private GroupBox gbListaConsultaPadre;
		private ListView lvwListaPadres;
		private ColumnHeader colIdPadre;
		private ColumnHeader colNombrePadre;
		private ColumnHeader colApellidoPrimeroPadre;
		private ColumnHeader colApellidoSegundoPadre;
		private ColumnHeader colGeneroPadre;
		private ColumnHeader colTelefonoPadre;
		private ColumnHeader colEmailPadre;
		private ColumnHeader colProvincia;
		private ColumnHeader colCanton;
		private ColumnHeader colDistrito;
		private ColumnHeader colOtrasSenias;
	}
}