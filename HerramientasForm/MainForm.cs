/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 15/08/2024
 * Hora: 20:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HerramientasForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCursoClick(object sender, EventArgs e)
		{
			if(rbt1A.Checked)
				lblCurso.Text = "1er Año";
			if(rbt2A.Checked)
				lblCurso.Text = "2do Año";
			if(rbt3a.Checked)
				lblCurso.Text= "3er Año";
		}
		void BtnIdiomaClick(object sender, EventArgs e)
		{
			if(cbxCast.Checked)
				lblIdiomas.Text="Castellano";
			if(cbxIngles.Checked)
				lblIdiomas.Text="INGLES";
			if(cbxOtro.Checked)
				lblIdiomas.Text="OTROS";
			if(cbxCast.Checked && cbxIngles.Checked)
				lblIdiomas.Text = "CASTELLANO - INGLES";
		}
		void BtnVentana2Click(object sender, EventArgs e)
		{
			Ventana2 V2 = new Ventana2();//CREAR OBJETO E INSTANCIAR
			this.Hide();//OCULTAR FORM ACTUAL (MAINFORM)
			V2.ShowDialog();//MOSTRAR LA NUEVA VENTANA O NEW FORM (VENTANA 2)
			this.Show();//MOSTRAR FORMULARIO (MAIN FORM)

		}
		void Ventana2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ventana2 V2 = new Ventana2();
			this.Hide();
			V2.ShowDialog();
			this.Show();
		}
		void Ventana3ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ventana3 V3 = new Ventana3();
			this.Hide();
			V3.ShowDialog();
			this.Show();
		}
		
		
		
		
		
	}
}
