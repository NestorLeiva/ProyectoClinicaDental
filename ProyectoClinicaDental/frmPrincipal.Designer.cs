namespace ProyectoClinicaDental
{
	partial class frmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			mnArchivo = new ToolStripMenuItem();
			mnLogin = new ToolStripMenuItem();
			mnRegistroPacientes = new ToolStripMenuItem();
			registroNuevosFuncionarios = new ToolStripMenuItem();
			mnMantenimientoServicios = new ToolStripMenuItem();
			mnConsultaHistorial = new ToolStripMenuItem();
			mnVentas = new ToolStripMenuItem();
			reporteDeVentas = new ToolStripMenuItem();
			mnAcercaDe = new ToolStripMenuItem();
			mnSalir = new ToolStripMenuItem();
			mnCerrarSesion = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { mnArchivo, mnAcercaDe, mnSalir });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1132, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// mnArchivo
			// 
			mnArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnLogin, mnRegistroPacientes, registroNuevosFuncionarios, mnMantenimientoServicios, mnConsultaHistorial, mnVentas, reporteDeVentas, mnCerrarSesion });
			mnArchivo.Name = "mnArchivo";
			mnArchivo.Size = new Size(60, 20);
			mnArchivo.Text = "Archivo";
			// 
			// mnLogin
			// 
			mnLogin.Name = "mnLogin";
			mnLogin.Size = new Size(281, 22);
			mnLogin.Text = "Inicio Sesion";
			mnLogin.Click += mnLogin_Click;
			// 
			// mnRegistroPacientes
			// 
			mnRegistroPacientes.Name = "mnRegistroPacientes";
			mnRegistroPacientes.Size = new Size(281, 22);
			mnRegistroPacientes.Text = "Registro Pacientes";
			mnRegistroPacientes.Click += mnRegistroPacientes_Click;
			// 
			// registroNuevosFuncionarios
			// 
			registroNuevosFuncionarios.Name = "registroNuevosFuncionarios";
			registroNuevosFuncionarios.Size = new Size(281, 22);
			registroNuevosFuncionarios.Text = "Registro Funcionarios";
			registroNuevosFuncionarios.Click += registroNuevosFuncionariosToolStripMenuItem_Click;
			// 
			// mnMantenimientoServicios
			// 
			mnMantenimientoServicios.Name = "mnMantenimientoServicios";
			mnMantenimientoServicios.Size = new Size(281, 22);
			mnMantenimientoServicios.Text = "Mantenimiento Servicios Clinica Dental";
			mnMantenimientoServicios.Click += mnMantenimientoServicios_Click;
			// 
			// mnConsultaHistorial
			// 
			mnConsultaHistorial.Name = "mnConsultaHistorial";
			mnConsultaHistorial.Size = new Size(281, 22);
			mnConsultaHistorial.Text = "Consulta Historial Pacientes";
			mnConsultaHistorial.Click += mnConsultaHistorial_Click;
			// 
			// mnVentas
			// 
			mnVentas.Name = "mnVentas";
			mnVentas.Size = new Size(281, 22);
			mnVentas.Text = "Facturacion";
			mnVentas.Click += mnVentas_Click;
			// 
			// reporteDeVentas
			// 
			reporteDeVentas.Name = "reporteDeVentas";
			reporteDeVentas.Size = new Size(281, 22);
			reporteDeVentas.Text = "Reporte de Ventas";
			reporteDeVentas.Click += reporteDeVentasToolStripMenuItem_Click;
			// 
			// mnAcercaDe
			// 
			mnAcercaDe.Name = "mnAcercaDe";
			mnAcercaDe.Size = new Size(71, 20);
			mnAcercaDe.Text = "Acerca de";
			mnAcercaDe.Click += mnAcercaDe_Click;
			// 
			// mnSalir
			// 
			mnSalir.Name = "mnSalir";
			mnSalir.Size = new Size(41, 20);
			mnSalir.Text = "Salir";
			mnSalir.Click += mnSalir_Click;
			// 
			// mnCerrarSesion
			// 
			mnCerrarSesion.Name = "mnCerrarSesion";
			mnCerrarSesion.Size = new Size(281, 22);
			mnCerrarSesion.Text = "Cerrar Sesion";
			mnCerrarSesion.Click += mnCerrarSesion_Click;
			// 
			// frmPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1132, 889);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "frmPrincipal";
			Text = "Clinica Dental Infantil Happy Teeth";
			Load += frmPrincipal_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem mnArchivo;
		private ToolStripMenuItem mnAcercaDe;
		private ToolStripMenuItem mnSalir;
		private ToolStripMenuItem mnVentas;
		private ToolStripMenuItem mnRegistroPacientes;
		private ToolStripMenuItem mnMantenimientoServicios;
		private ToolStripMenuItem mnConsultaHistorial;
		private ToolStripMenuItem mnLogin;
		private ToolStripMenuItem registroNuevosFuncionarios;
		private ToolStripMenuItem reporteDeVentas;
		private ToolStripMenuItem mnCerrarSesion;
	}
}