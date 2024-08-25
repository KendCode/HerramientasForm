/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 20/08/2024
 * Hora: 20:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HerramientasForm
{
	/// <summary>
	/// Description of Ventana3.
	/// </summary>
	public partial class Ventana3 : Form
	{
		public Ventana3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			string nom = txtNombre.Text;
			string ape = txtApellido.Text;
			
			//GENERO
			string genero;
			if(rbtMasculino.Checked)
				genero = "Masculino";
			else
				genero="Femenino";
			//Nacimiento
			DateTime fecha = dtpFecha.Value;
			
			//Estudio
			int indice = cbbxEstudio.SelectedIndex;
			string es = cbbxEstudio.Items[indice].ToString();
			//trabajo
			string trabajo="";
			if(rbtSinTrabajo.Checked)
				trabajo="Sin Trabajo";
			if(rbtIndependiente.Checked)
				trabajo = "Independiente";
			if(rbtAsalariado.Checked)
				trabajo = "Asalariado";
			
			//
			lblDatos.Text = "Su nombre es: "+nom+" "+ape+" de genero "
				+genero+" con fecha de nacimineto "+fecha.ToString()+
				" sunivel de estudio es "+es+ " y trabajo "+trabajo;
			
		}
		void LinkYouTubeLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkYouTube.LinkVisited = true;
			System.Diagnostics.Process.Start("https://www.youtube.com/@CONTRARUTA_2024");
		}
		void LinkFacebookLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkFacebook.LinkVisited = true;
			System.Diagnostics.Process.Start("https://www.facebook.com/itboliviamar.edu.bo/?locale=es_LA");
		}
		void LinkITBMLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkITBM.LinkVisited = true;
			System.Diagnostics.Process.Start("https://itboliviamar.globalnex.net/");
		}
		
	}
}
