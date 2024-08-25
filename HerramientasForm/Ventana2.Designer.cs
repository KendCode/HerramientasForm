/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 15/08/2024
 * Hora: 21:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HerramientasForm
{
	partial class Ventana2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnNombre;
		private System.Windows.Forms.ComboBox cbbx_Nombres;
		private System.Windows.Forms.Button btnNumeros;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lbx_Numeros;
		private System.Windows.Forms.Button btnPosicion;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnNombre = new System.Windows.Forms.Button();
			this.cbbx_Nombres = new System.Windows.Forms.ComboBox();
			this.btnNumeros = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbx_Numeros = new System.Windows.Forms.ListBox();
			this.btnPosicion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(63, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(45, 108);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(172, 36);
			this.txtNombre.TabIndex = 1;
			// 
			// btnNombre
			// 
			this.btnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNombre.Location = new System.Drawing.Point(70, 177);
			this.btnNombre.Name = "btnNombre";
			this.btnNombre.Size = new System.Drawing.Size(119, 42);
			this.btnNombre.TabIndex = 2;
			this.btnNombre.Text = "Agregar";
			this.btnNombre.UseVisualStyleBackColor = true;
			this.btnNombre.Click += new System.EventHandler(this.BtnNombreClick);
			// 
			// cbbx_Nombres
			// 
			this.cbbx_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbx_Nombres.FormattingEnabled = true;
			this.cbbx_Nombres.Items.AddRange(new object[] {
			"Maria",
			"Luis",
			"Sara",
			"Teresa"});
			this.cbbx_Nombres.Location = new System.Drawing.Point(45, 269);
			this.cbbx_Nombres.Name = "cbbx_Nombres";
			this.cbbx_Nombres.Size = new System.Drawing.Size(172, 39);
			this.cbbx_Nombres.TabIndex = 3;
			// 
			// btnNumeros
			// 
			this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNumeros.Location = new System.Drawing.Point(286, 168);
			this.btnNumeros.Name = "btnNumeros";
			this.btnNumeros.Size = new System.Drawing.Size(119, 42);
			this.btnNumeros.TabIndex = 6;
			this.btnNumeros.Text = "Agregar";
			this.btnNumeros.UseVisualStyleBackColor = true;
			this.btnNumeros.Click += new System.EventHandler(this.BtnNumerosClick);
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(329, 108);
			this.txtNumero.Multiline = true;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(172, 36);
			this.txtNumero.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(344, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 39);
			this.label2.TabIndex = 4;
			this.label2.Text = "NUMERO";
			// 
			// lbx_Numeros
			// 
			this.lbx_Numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbx_Numeros.FormattingEnabled = true;
			this.lbx_Numeros.ItemHeight = 20;
			this.lbx_Numeros.Items.AddRange(new object[] {
			"23",
			"5",
			"555",
			"869"});
			this.lbx_Numeros.Location = new System.Drawing.Point(344, 234);
			this.lbx_Numeros.Name = "lbx_Numeros";
			this.lbx_Numeros.Size = new System.Drawing.Size(157, 124);
			this.lbx_Numeros.TabIndex = 7;
			// 
			// btnPosicion
			// 
			this.btnPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPosicion.Location = new System.Drawing.Point(426, 168);
			this.btnPosicion.Name = "btnPosicion";
			this.btnPosicion.Size = new System.Drawing.Size(141, 42);
			this.btnPosicion.TabIndex = 8;
			this.btnPosicion.Text = "Mostrar Posicion";
			this.btnPosicion.UseVisualStyleBackColor = true;
			this.btnPosicion.Click += new System.EventHandler(this.BtnPosicionClick);
			// 
			// Ventana2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(809, 451);
			this.Controls.Add(this.btnPosicion);
			this.Controls.Add(this.lbx_Numeros);
			this.Controls.Add(this.btnNumeros);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbbx_Nombres);
			this.Controls.Add(this.btnNombre);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Name = "Ventana2";
			this.Text = "Ventana2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
