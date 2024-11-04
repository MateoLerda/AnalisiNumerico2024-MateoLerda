namespace AnalisisNumerico.Cuatro
{
	partial class Unidad4
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
			panel1 = new Panel();
			btnLimpiar = new Button();
			panel9 = new Panel();
			panel10 = new Panel();
			label17 = new Label();
			cbMetodo = new ComboBox();
			btnCalcular = new Button();
			panel7 = new Panel();
			panel8 = new Panel();
			lblSubInter = new Label();
			txbSubInterv = new TextBox();
			panel2 = new Panel();
			txbXi = new TextBox();
			panel4 = new Panel();
			lblXi = new Label();
			lblXd = new Label();
			txbXd = new TextBox();
			panel5 = new Panel();
			panel6 = new Panel();
			lblFuncionIngresada = new Label();
			txbFuncion = new TextBox();
			label5 = new Label();
			panel3 = new Panel();
			label6 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel11 = new Panel();
			metodoResult = new Label();
			panel13 = new Panel();
			areaResult = new Label();
			panel14 = new Panel();
			lblArea = new Label();
			label4 = new Label();
			grafica = new Microsoft.Web.WebView2.WinForms.WebView2();
			panel1.SuspendLayout();
			panel9.SuspendLayout();
			panel7.SuspendLayout();
			panel2.SuspendLayout();
			panel5.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel11.SuspendLayout();
			panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)grafica).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.GhostWhite;
			panel1.Controls.Add(btnLimpiar);
			panel1.Controls.Add(panel9);
			panel1.Controls.Add(btnCalcular);
			panel1.Controls.Add(panel7);
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(panel5);
			panel1.Controls.Add(label5);
			panel1.Location = new Point(19, 68);
			panel1.Name = "panel1";
			panel1.Size = new Size(409, 370);
			panel1.TabIndex = 25;
			// 
			// btnLimpiar
			// 
			btnLimpiar.BackColor = Color.Firebrick;
			btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
			btnLimpiar.ForeColor = Color.Transparent;
			btnLimpiar.Location = new Point(222, 317);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(153, 36);
			btnLimpiar.TabIndex = 27;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = false;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// panel9
			// 
			panel9.BackColor = Color.Gainsboro;
			panel9.Controls.Add(panel10);
			panel9.Controls.Add(label17);
			panel9.Controls.Add(cbMetodo);
			panel9.Location = new Point(14, 227);
			panel9.Name = "panel9";
			panel9.Size = new Size(377, 60);
			panel9.TabIndex = 46;
			// 
			// panel10
			// 
			panel10.BackColor = Color.PeachPuff;
			panel10.Location = new Point(8, 0);
			panel10.Name = "panel10";
			panel10.Size = new Size(11, 75);
			panel10.TabIndex = 0;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.BackColor = Color.Gainsboro;
			label17.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label17.Location = new Point(25, 16);
			label17.Name = "label17";
			label17.Size = new Size(86, 21);
			label17.TabIndex = 41;
			label17.Text = "Metodo:  ";
			// 
			// cbMetodo
			// 
			cbMetodo.FormattingEnabled = true;
			cbMetodo.Items.AddRange(new object[] { "Trapecios Simple", "Trapecios Múltiples ", "Simpson 1/3 Simple ", "Simpson 1/3 Multiple ", "Simpson 3/8 ", "1/3 Multiple y  3/8 Convinados" });
			cbMetodo.Location = new Point(125, 16);
			cbMetodo.Name = "cbMetodo";
			cbMetodo.Size = new Size(158, 23);
			cbMetodo.TabIndex = 40;
			cbMetodo.SelectedIndexChanged += cbMetodo_SelectedIndexChanged;
			// 
			// btnCalcular
			// 
			btnCalcular.BackColor = SystemColors.ButtonShadow;
			btnCalcular.Location = new Point(39, 317);
			btnCalcular.Name = "btnCalcular";
			btnCalcular.Size = new Size(153, 36);
			btnCalcular.TabIndex = 25;
			btnCalcular.Text = "Calcular";
			btnCalcular.UseVisualStyleBackColor = false;
			btnCalcular.Click += btnCalcular_Click;
			// 
			// panel7
			// 
			panel7.BackColor = Color.Gainsboro;
			panel7.Controls.Add(panel8);
			panel7.Controls.Add(lblSubInter);
			panel7.Controls.Add(txbSubInterv);
			panel7.Location = new Point(14, 175);
			panel7.Name = "panel7";
			panel7.Size = new Size(377, 46);
			panel7.TabIndex = 45;
			// 
			// panel8
			// 
			panel8.BackColor = Color.Gold;
			panel8.Location = new Point(8, 0);
			panel8.Name = "panel8";
			panel8.Size = new Size(11, 75);
			panel8.TabIndex = 0;
			// 
			// lblSubInter
			// 
			lblSubInter.AutoSize = true;
			lblSubInter.BackColor = Color.Gainsboro;
			lblSubInter.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblSubInter.Location = new Point(25, 15);
			lblSubInter.Name = "lblSubInter";
			lblSubInter.Size = new Size(238, 17);
			lblSubInter.TabIndex = 34;
			lblSubInter.Text = "Cantidad de sub intervalos (n):  ";
			// 
			// txbSubInterv
			// 
			txbSubInterv.Location = new Point(269, 14);
			txbSubInterv.Name = "txbSubInterv";
			txbSubInterv.Size = new Size(80, 23);
			txbSubInterv.TabIndex = 35;
			txbSubInterv.TextChanged += txbSubInterv_TextChanged;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Gainsboro;
			panel2.Controls.Add(txbXi);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(lblXi);
			panel2.Controls.Add(lblXd);
			panel2.Controls.Add(txbXd);
			panel2.Location = new Point(14, 112);
			panel2.Name = "panel2";
			panel2.Size = new Size(377, 57);
			panel2.TabIndex = 45;
			// 
			// txbXi
			// 
			txbXi.Location = new Point(73, 22);
			txbXi.Name = "txbXi";
			txbXi.Size = new Size(67, 23);
			txbXi.TabIndex = 43;
			txbXi.TextChanged += txbXi_TextChanged;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Orange;
			panel4.Location = new Point(8, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(11, 75);
			panel4.TabIndex = 0;
			// 
			// lblXi
			// 
			lblXi.AutoSize = true;
			lblXi.BackColor = Color.Gainsboro;
			lblXi.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lblXi.Location = new Point(25, 19);
			lblXi.Name = "lblXi";
			lblXi.Size = new Size(54, 27);
			lblXi.TabIndex = 36;
			lblXi.Text = "Xi:  ";
			// 
			// lblXd
			// 
			lblXd.AutoSize = true;
			lblXd.BackColor = Color.Gainsboro;
			lblXd.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lblXd.Location = new Point(158, 19);
			lblXd.Name = "lblXd";
			lblXd.Size = new Size(60, 27);
			lblXd.TabIndex = 42;
			lblXd.Text = "Xd:  ";
			// 
			// txbXd
			// 
			txbXd.Location = new Point(224, 23);
			txbXd.Name = "txbXd";
			txbXd.Size = new Size(67, 23);
			txbXd.TabIndex = 37;
			txbXd.TextChanged += txbXd_TextChanged;
			// 
			// panel5
			// 
			panel5.BackColor = Color.Gainsboro;
			panel5.Controls.Add(panel6);
			panel5.Controls.Add(lblFuncionIngresada);
			panel5.Controls.Add(txbFuncion);
			panel5.Location = new Point(14, 60);
			panel5.Name = "panel5";
			panel5.Size = new Size(377, 46);
			panel5.TabIndex = 44;
			// 
			// panel6
			// 
			panel6.BackColor = Color.Coral;
			panel6.Location = new Point(8, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(11, 75);
			panel6.TabIndex = 0;
			// 
			// lblFuncionIngresada
			// 
			lblFuncionIngresada.AutoSize = true;
			lblFuncionIngresada.Font = new Font("Britannic Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
			lblFuncionIngresada.Location = new Point(25, 14);
			lblFuncionIngresada.Name = "lblFuncionIngresada";
			lblFuncionIngresada.Size = new Size(94, 25);
			lblFuncionIngresada.TabIndex = 5;
			lblFuncionIngresada.Text = "Función:";
			// 
			// txbFuncion
			// 
			txbFuncion.Location = new Point(125, 14);
			txbFuncion.Name = "txbFuncion";
			txbFuncion.Size = new Size(217, 23);
			txbFuncion.TabIndex = 29;
			txbFuncion.TextChanged += txbFuncion_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Firebrick;
			label5.Font = new Font("Britannic Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.GhostWhite;
			label5.Location = new Point(149, 13);
			label5.Name = "label5";
			label5.Size = new Size(83, 30);
			label5.TabIndex = 23;
			label5.Text = "Carga";
			// 
			// panel3
			// 
			panel3.BackColor = Color.GhostWhite;
			panel3.Controls.Add(label6);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(label1);
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(19, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(763, 49);
			panel3.TabIndex = 24;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Britannic Bold", 24F, FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.Firebrick;
			label6.Location = new Point(435, 9);
			label6.Name = "label6";
			label6.Size = new Size(67, 36);
			label6.TabIndex = 4;
			label6.Text = "h/2";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Constantia", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(517, 16);
			label3.Name = "label3";
			label3.Size = new Size(121, 14);
			label3.TabIndex = 3;
			label3.Text = "Alumno : Mateo Lerda";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Constantia", 9F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(517, 32);
			label2.Name = "label2";
			label2.Size = new Size(239, 14);
			label2.TabIndex = 2;
			label2.Text = "Profesores : Carlos Walker ,Ezequiel Albornoz";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Britannic Bold", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Firebrick;
			label1.Location = new Point(55, 5);
			label1.Name = "label1";
			label1.Size = new Size(371, 41);
			label1.TabIndex = 1;
			label1.Text = "Integración Numérica";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.LogoUCSE1;
			pictureBox1.Location = new Point(14, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(35, 43);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// panel11
			// 
			panel11.BackColor = Color.GhostWhite;
			panel11.Controls.Add(metodoResult);
			panel11.Controls.Add(panel13);
			panel11.Controls.Add(label4);
			panel11.Location = new Point(434, 70);
			panel11.Name = "panel11";
			panel11.Size = new Size(348, 104);
			panel11.TabIndex = 26;
			// 
			// metodoResult
			// 
			metodoResult.AutoSize = true;
			metodoResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
			metodoResult.Location = new Point(161, 20);
			metodoResult.Name = "metodoResult";
			metodoResult.Size = new Size(69, 21);
			metodoResult.TabIndex = 6;
			metodoResult.Text = "Metodo";
			// 
			// panel13
			// 
			panel13.BackColor = Color.Gainsboro;
			panel13.Controls.Add(areaResult);
			panel13.Controls.Add(panel14);
			panel13.Controls.Add(lblArea);
			panel13.Location = new Point(12, 49);
			panel13.Name = "panel13";
			panel13.Size = new Size(299, 37);
			panel13.TabIndex = 45;
			// 
			// areaResult
			// 
			areaResult.AutoSize = true;
			areaResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
			areaResult.Location = new Point(103, 9);
			areaResult.Name = "areaResult";
			areaResult.Size = new Size(47, 21);
			areaResult.TabIndex = 6;
			areaResult.Text = "Area";
			// 
			// panel14
			// 
			panel14.BackColor = Color.Coral;
			panel14.Location = new Point(8, 0);
			panel14.Name = "panel14";
			panel14.Size = new Size(11, 75);
			panel14.TabIndex = 0;
			// 
			// lblArea
			// 
			lblArea.AutoSize = true;
			lblArea.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
			lblArea.Location = new Point(25, 9);
			lblArea.Name = "lblArea";
			lblArea.Size = new Size(52, 21);
			lblArea.TabIndex = 5;
			lblArea.Text = "Area:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Firebrick;
			label4.Font = new Font("Britannic Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.GhostWhite;
			label4.Location = new Point(12, 11);
			label4.Name = "label4";
			label4.Size = new Size(131, 30);
			label4.TabIndex = 47;
			label4.Text = "Resultado";
			// 
			// grafica
			// 
			grafica.AllowExternalDrop = true;
			grafica.BackColor = Color.WhiteSmoke;
			grafica.CreationProperties = null;
			grafica.DefaultBackgroundColor = Color.White;
			grafica.Location = new Point(434, 180);
			grafica.Name = "grafica";
			grafica.Size = new Size(348, 258);
			grafica.TabIndex = 27;
			grafica.ZoomFactor = 1D;
			// 
			// Unidad4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Firebrick;
			ClientSize = new Size(800, 450);
			Controls.Add(grafica);
			Controls.Add(panel11);
			Controls.Add(panel1);
			Controls.Add(panel3);
			Name = "Unidad4";
			Text = "Unidad4";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel11.ResumeLayout(false);
			panel11.PerformLayout();
			panel13.ResumeLayout(false);
			panel13.PerformLayout();
			((System.ComponentModel.ISupportInitialize)grafica).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Label label17;
		private ComboBox cbMetodo;
		private Button btnBorrarTodo;
		private Button btnBorrarUlt;
		private TextBox txbXd;
		private Label lblXi;
		private TextBox txbSubInterv;
		private Label lblSubInter;
		private Panel panelPuntos;
		private Label label14;
		private Label label13;
		private TextBox txbPuntoY;
		private TextBox txbFuncion;
		private Button btnLimpiar;
		private Button btnCalcular;
		private Button btnGenerar;
		private Label label5;
		private Panel panel3;
		private Label label6;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label lblXd;
		private Panel panel2;
		private TextBox txbXi;
		private Panel panel4;
		private Panel panel5;
		private Panel panel6;
		private Label lblFuncionIngresada;
		private Panel panel9;
		private Panel panel10;
		private Panel panel7;
		private Panel panel8;
		private Panel panel11;
		private Label label4;
		private Panel panel13;
		private Panel panel14;
		private Label lblArea;
		private Label metodoResult;
		private Label areaResult;
		private Microsoft.Web.WebView2.WinForms.WebView2 grafica;
	}
}