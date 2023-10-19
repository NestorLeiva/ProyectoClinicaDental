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
			groupBox5 = new GroupBox();
			btnBusqueda = new Button();
			txtIdentificacionPadreBusqueda = new TextBox();
			lblIdBusqueda = new Label();
			groupBox1 = new GroupBox();
			lvwConsultaHistorialPaciente = new ListView();
			groupBox5.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(btnBusqueda);
			groupBox5.Controls.Add(txtIdentificacionPadreBusqueda);
			groupBox5.Controls.Add(lblIdBusqueda);
			groupBox5.Location = new Point(12, 12);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(743, 85);
			groupBox5.TabIndex = 65;
			groupBox5.TabStop = false;
			// 
			// btnBusqueda
			// 
			btnBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnBusqueda.Location = new Point(528, 14);
			btnBusqueda.Name = "btnBusqueda";
			btnBusqueda.Size = new Size(118, 31);
			btnBusqueda.TabIndex = 2;
			btnBusqueda.Text = "Consultar";
			btnBusqueda.UseVisualStyleBackColor = true;
			// 
			// txtIdentificacionPadreBusqueda
			// 
			txtIdentificacionPadreBusqueda.Location = new Point(179, 19);
			txtIdentificacionPadreBusqueda.Name = "txtIdentificacionPadreBusqueda";
			txtIdentificacionPadreBusqueda.Size = new Size(343, 23);
			txtIdentificacionPadreBusqueda.TabIndex = 1;
			// 
			// lblIdBusqueda
			// 
			lblIdBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblIdBusqueda.Location = new Point(6, 19);
			lblIdBusqueda.Name = "lblIdBusqueda";
			lblIdBusqueda.Size = new Size(177, 23);
			lblIdBusqueda.TabIndex = 0;
			lblIdBusqueda.Text = "Buscar por Id ";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lvwConsultaHistorialPaciente);
			groupBox1.Location = new Point(12, 103);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(743, 622);
			groupBox1.TabIndex = 66;
			groupBox1.TabStop = false;
			// 
			// lvwConsultaHistorialPaciente
			// 
			lvwConsultaHistorialPaciente.Dock = DockStyle.Fill;
			lvwConsultaHistorialPaciente.GridLines = true;
			lvwConsultaHistorialPaciente.Location = new Point(3, 19);
			lvwConsultaHistorialPaciente.Name = "lvwConsultaHistorialPaciente";
			lvwConsultaHistorialPaciente.Size = new Size(737, 600);
			lvwConsultaHistorialPaciente.TabIndex = 0;
			lvwConsultaHistorialPaciente.UseCompatibleStateImageBehavior = false;
			lvwConsultaHistorialPaciente.View = View.Details;
			// 
			// frmConsultaHistoria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(780, 744);
			Controls.Add(groupBox1);
			Controls.Add(groupBox5);
			Name = "frmConsultaHistoria";
			Text = "frmConsultaHistoria";
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox5;
		private Button btnBusqueda;
		private TextBox txtIdentificacionPadreBusqueda;
		private Label lblIdBusqueda;
		private GroupBox groupBox1;
		private ListView lvwConsultaHistorialPaciente;
	}
}