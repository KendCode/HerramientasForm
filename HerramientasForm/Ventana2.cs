/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 15/08/2024
 * Hora: 21:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HerramientasForm
{
	/// <summary>
	/// Description of Ventana2.
	/// </summary>
	public partial class Ventana2 : Form
	{
		public Ventana2()
		{
			
			InitializeComponent();
			
			
		}
		void BtnNombreClick(object sender, EventArgs e)
		{
			string nom = txtNombre.Text;
			cbbx_Nombres.Items.Add(nom);
			txtNombre.Clear();
			txtNombre.Focus();
			
		}
		void BtnNumerosClick(object sender, EventArgs e)
		{
			try{
			int num = int.Parse(txtNumero.Text);
			lbx_Numeros.Items.Add(num);
			}
			catch(Exception x){
				MessageBox.Show("Error... ingrese numeros enteros");
			}
			finally{
				txtNumero.Clear();
				txtNumero.Focus();
			}
			
		}
		void BtnPosicionClick(object sender, EventArgs e)
		{
			try{
			short pos = Convert.ToInt16(txtNumero.Text);
			if(pos>lbx_Numeros.Items.Count)
				MessageBox.Show("La posicion ingresada no existe");
			else{
				string valor = lbx_Numeros.Items[pos-1].ToString();
				MessageBox.Show("El valor es "+valor);
			}
		}
		catch(Exception x){
			MessageBox.Show("Error... ingrese un numero entero");
		}
		finally{
			
			txtNumero.Clear();
			txtNumero.Focus();
		}
		}
		
		
	}
}
