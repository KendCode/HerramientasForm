/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 20/08/2024
 * Hora: 20:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace HerramientasForm
{
	partial class Ventana3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.RadioButton rbtFemenino;
		private System.Windows.Forms.RadioButton rbtMasculino;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rbtIndependiente;
		private System.Windows.Forms.RadioButton rbtAsalariado;
		private System.Windows.Forms.RadioButton rbtSinTrabajo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbbxEstudio;
		private System.Windows.Forms.Label lblDatos;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.LinkLabel linkYouTube;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.LinkLabel linkITBM;
		private System.Windows.Forms.LinkLabel linkFacebook;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana3));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblDatos = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbtIndependiente = new System.Windows.Forms.RadioButton();
			this.rbtAsalariado = new System.Windows.Forms.RadioButton();
			this.rbtSinTrabajo = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.cbbxEstudio = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rbtFemenino = new System.Windows.Forms.RadioButton();
			this.rbtMasculino = new System.Windows.Forms.RadioButton();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.linkITBM = new System.Windows.Forms.LinkLabel();
			this.linkFacebook = new System.Windows.Forms.LinkLabel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.linkYouTube = new System.Windows.Forms.LinkLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(747, 629);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lblDatos);
			this.tabPage1.Controls.Add(this.btnGuardar);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(739, 581);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Datos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lblDatos
			// 
			this.lblDatos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatos.Location = new System.Drawing.Point(92, 461);
			this.lblDatos.Name = "lblDatos";
			this.lblDatos.Size = new System.Drawing.Size(580, 106);
			this.lblDatos.TabIndex = 3;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(327, 398);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(98, 33);
			this.btnGuardar.TabIndex = 2;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbtIndependiente);
			this.groupBox2.Controls.Add(this.rbtAsalariado);
			this.groupBox2.Controls.Add(this.rbtSinTrabajo);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cbbxEstudio);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(386, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(337, 386);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Académicos";
			// 
			// rbtIndependiente
			// 
			this.rbtIndependiente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtIndependiente.Location = new System.Drawing.Point(37, 276);
			this.rbtIndependiente.Name = "rbtIndependiente";
			this.rbtIndependiente.Size = new System.Drawing.Size(104, 24);
			this.rbtIndependiente.TabIndex = 5;
			this.rbtIndependiente.TabStop = true;
			this.rbtIndependiente.Text = "Independiente";
			this.rbtIndependiente.UseVisualStyleBackColor = true;
			// 
			// rbtAsalariado
			// 
			this.rbtAsalariado.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtAsalariado.Location = new System.Drawing.Point(37, 306);
			this.rbtAsalariado.Name = "rbtAsalariado";
			this.rbtAsalariado.Size = new System.Drawing.Size(104, 24);
			this.rbtAsalariado.TabIndex = 4;
			this.rbtAsalariado.TabStop = true;
			this.rbtAsalariado.Text = "Asalariado";
			this.rbtAsalariado.UseVisualStyleBackColor = true;
			// 
			// rbtSinTrabajo
			// 
			this.rbtSinTrabajo.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtSinTrabajo.Location = new System.Drawing.Point(37, 246);
			this.rbtSinTrabajo.Name = "rbtSinTrabajo";
			this.rbtSinTrabajo.Size = new System.Drawing.Size(104, 24);
			this.rbtSinTrabajo.TabIndex = 3;
			this.rbtSinTrabajo.TabStop = true;
			this.rbtSinTrabajo.Text = "Sin Trabajo";
			this.rbtSinTrabajo.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 202);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tipo de Trabajo:";
			// 
			// cbbxEstudio
			// 
			this.cbbxEstudio.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbxEstudio.FormattingEnabled = true;
			this.cbbxEstudio.Items.AddRange(new object[] {
			"Bachiller",
			"Tec. BAsico",
			"Tec. Medio",
			"Tec. Superior",
			"Licenciatura",
			"Maestria",
			"Doctorado"});
			this.cbbxEstudio.Location = new System.Drawing.Point(69, 98);
			this.cbbxEstudio.Name = "cbbxEstudio";
			this.cbbxEstudio.Size = new System.Drawing.Size(150, 24);
			this.cbbxEstudio.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 32);
			this.label5.TabIndex = 0;
			this.label5.Text = "Estudio:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.dtpFecha);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.rbtFemenino);
			this.groupBox1.Controls.Add(this.rbtMasculino);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(374, 386);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personales";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(203, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 184);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(203, 287);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(145, 29);
			this.dtpFecha.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Genero";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(172, 251);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fecha de Nacimiento";
			// 
			// rbtFemenino
			// 
			this.rbtFemenino.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtFemenino.Location = new System.Drawing.Point(9, 322);
			this.rbtFemenino.Name = "rbtFemenino";
			this.rbtFemenino.Size = new System.Drawing.Size(132, 34);
			this.rbtFemenino.TabIndex = 5;
			this.rbtFemenino.TabStop = true;
			this.rbtFemenino.Text = "Femenino";
			this.rbtFemenino.UseVisualStyleBackColor = true;
			// 
			// rbtMasculino
			// 
			this.rbtMasculino.Font = new System.Drawing.Font("Microsoft YaHei", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtMasculino.Location = new System.Drawing.Point(9, 278);
			this.rbtMasculino.Name = "rbtMasculino";
			this.rbtMasculino.Size = new System.Drawing.Size(137, 49);
			this.rbtMasculino.TabIndex = 4;
			this.rbtMasculino.TabStop = true;
			this.rbtMasculino.Text = "Masculino";
			this.rbtMasculino.UseVisualStyleBackColor = true;
			// 
			// txtApellido
			// 
			this.txtApellido.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(6, 202);
			this.txtApellido.Multiline = true;
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(179, 35);
			this.txtApellido.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 49);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellidos:";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(6, 98);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(182, 32);
			this.txtNombre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombres:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.linkITBM);
			this.tabPage2.Controls.Add(this.linkFacebook);
			this.tabPage2.Controls.Add(this.pictureBox4);
			this.tabPage2.Controls.Add(this.pictureBox3);
			this.tabPage2.Controls.Add(this.linkYouTube);
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(739, 581);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Imagenes";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// linkITBM
			// 
			this.linkITBM.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkITBM.LinkColor = System.Drawing.Color.Black;
			this.linkITBM.Location = new System.Drawing.Point(561, 191);
			this.linkITBM.Name = "linkITBM";
			this.linkITBM.Size = new System.Drawing.Size(65, 23);
			this.linkITBM.TabIndex = 5;
			this.linkITBM.TabStop = true;
			this.linkITBM.Text = "ITBM";
			this.linkITBM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkITBMLinkClicked);
			// 
			// linkFacebook
			// 
			this.linkFacebook.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkFacebook.LinkColor = System.Drawing.Color.Black;
			this.linkFacebook.Location = new System.Drawing.Point(270, 191);
			this.linkFacebook.Name = "linkFacebook";
			this.linkFacebook.Size = new System.Drawing.Size(120, 23);
			this.linkFacebook.TabIndex = 4;
			this.linkFacebook.TabStop = true;
			this.linkFacebook.Text = "FACEBOOK";
			this.linkFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFacebookLinkClicked);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(509, 15);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(179, 163);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(245, 15);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(179, 163);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// linkYouTube
			// 
			this.linkYouTube.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkYouTube.LinkColor = System.Drawing.Color.Black;
			this.linkYouTube.Location = new System.Drawing.Point(35, 191);
			this.linkYouTube.Name = "linkYouTube";
			this.linkYouTube.Size = new System.Drawing.Size(120, 23);
			this.linkYouTube.TabIndex = 1;
			this.linkYouTube.TabStop = true;
			this.linkYouTube.Text = "YOU TUBE";
			this.linkYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkYouTubeLinkClicked);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(6, 15);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(177, 163);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// Ventana3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 642);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8);
			this.Name = "Ventana3";
			this.Text = "Ventana3";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
