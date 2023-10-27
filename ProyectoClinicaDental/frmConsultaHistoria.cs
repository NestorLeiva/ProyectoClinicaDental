﻿using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoClinicaDental
{
	public partial class frmConsultaHistoria : Form
	{
		public frmConsultaHistoria()
		{
			InitializeComponent();
		}


		private void frmConsultaHistoria_Load(object sender, EventArgs e) /*cargo automaticamente la lista de los pacientes*/
		{
			try
			{
				XmlDocument xmlDocPadres = new XmlDocument();
				/*cargo el archivo xml*/
				xmlDocPadres.Load("Padres.xml");
				/*obtengo la lista de los nodos*/
				XmlNodeList nodoHijo = xmlDocPadres.SelectNodes("//Hijo");


				foreach (XmlNode lstHijo in nodoHijo)
				{
					Hijo hijo = new Hijo(DateTime.Parse(lstHijo.SelectSingleNode("FechaNacimiento").InnerText));
					int edadAnios = hijo.edadAnio;
					int edadMeses = hijo.edadMeses;

					ListViewItem itemHijo = new ListViewItem(lstHijo.SelectSingleNode("Id").InnerText);

					itemHijo.SubItems.Add(lstHijo.SelectSingleNode("Nombre").InnerText);
					itemHijo.SubItems.Add(lstHijo.SelectSingleNode("ApellidoPrimero").InnerText);
					itemHijo.SubItems.Add(lstHijo.SelectSingleNode("ApellidoSegundo").InnerText);
					itemHijo.SubItems.Add(lstHijo.SelectSingleNode("FechaNacimiento").InnerText);
					itemHijo.SubItems.Add(edadAnios.ToString() + " años " + edadMeses.ToString() + " meses");
					itemHijo.SubItems.Add(lstHijo.SelectSingleNode("Genero").InnerText);
					itemHijo.SubItems.Add(lstHijo.SelectSingleNode("Telefono").InnerText);

					/*Agrego los datos a la lista*/
					lvwListaPacientes.Items.Add(itemHijo);
				}/*Fin del Foreach*/

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error al cargar la Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnBusqueda_Click(object sender, EventArgs e)
		{
			/*Realizar un filtrado en la lista por ID*/
			try
			{
				string consultaId = txtBusquedaIdentificacion.Text; /*Obtengo el Id*/
				/*realizo una "limpia" de la lista */
				lvwListaPacientes.Items.Clear();

				// Cargar el archivo XML
				XmlDocument xmlDoc = new XmlDocument();
				//cargo el archivo xml
				xmlDoc.Load("Padres.xml");

				// Buscar el nodo Hijo con el Id especificado
				XmlNode hijoNode = xmlDoc.SelectSingleNode($"//Hijo[Id='{consultaId}']");
				/* se realiza la busqueda en todos los nodos "Hijo /
				 * [Id='{consulta}'] es una exprecion de busqueda en los atributos Id con un valor igual al de la variable consultaId  "*/
				if (hijoNode != null)
				{
					Hijo hijo = new Hijo(DateTime.Parse(hijoNode.SelectSingleNode("FechaNacimiento").InnerText));
					int edadAnios = hijo.edadAnio;
					int edadMeses = hijo.edadMeses;

					/*Mostrar los datos en el ListView*/
					ListViewItem itemHijo = new ListViewItem(hijoNode.SelectSingleNode("Id").InnerText);
					itemHijo.SubItems.Add(hijoNode.SelectSingleNode("Nombre").InnerText);
					itemHijo.SubItems.Add(hijoNode.SelectSingleNode("ApellidoPrimero").InnerText);
					itemHijo.SubItems.Add(hijoNode.SelectSingleNode("ApellidoSegundo").InnerText);
					itemHijo.SubItems.Add(hijoNode.SelectSingleNode("FechaNacimiento").InnerText);
					itemHijo.SubItems.Add(edadAnios.ToString() + " años " + edadMeses.ToString() + " meses");
					itemHijo.SubItems.Add(hijoNode.SelectSingleNode("Genero").InnerText);
					itemHijo.SubItems.Add(hijoNode.SelectSingleNode("Telefono").InnerText);

					/*Agrego los datos a la lista*/
					lvwListaPacientes.Items.Add(itemHijo);
				}
				else
				{
					MessageBox.Show("No se Encontro Ningun Paciente con el ID " + consultaId);
				}
				/* con el If valido si el valor de la variable consultaId es valido o no*/

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error al cargar la Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtBusquedaIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!metodosValidaciones.soloNumeros(e.KeyChar))
			{
				e.Handled = true;
				/*valido el metodo, si es true se pasan los caracteres numerticos 
				si es False se omiten los carecteres*/
			}
		}




	}
}
