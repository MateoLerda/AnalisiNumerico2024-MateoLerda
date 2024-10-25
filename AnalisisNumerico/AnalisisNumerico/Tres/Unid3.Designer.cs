namespace AnalisisNumerico.Tres
{
    partial class Unid3
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
			label17 = new Label();
			cbMetodo = new ComboBox();
			btnBorrarTodo = new Button();
			btnBorrarUlt = new Button();
			txbGrado = new TextBox();
			label16 = new Label();
			txbTolerancia = new TextBox();
			label15 = new Label();
			panelPuntos = new Panel();
			label14 = new Label();
			label13 = new Label();
			txbPuntoY = new TextBox();
			txbPuntoX = new TextBox();
			lblDimension = new Label();
			btnLimpiar = new Button();
			btnCalcular = new Button();
			btnGenerar = new Button();
			label5 = new Label();
			panel3 = new Panel();
			label6 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			lblMetodo = new Label();
			panel9 = new Panel();
			panel10 = new Panel();
			label9 = new Label();
			lblEfectividad = new Label();
			panel7 = new Panel();
			panel8 = new Panel();
			label7 = new Label();
			lblcorrelacion = new Label();
			panel5 = new Panel();
			panel6 = new Panel();
			lblFuncionIngresada = new Label();
			lblfuncion = new Label();
			paneGrafica = new Panel();
			label4 = new Label();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			panel9.SuspendLayout();
			panel7.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.GhostWhite;
			panel1.Controls.Add(label17);
			panel1.Controls.Add(cbMetodo);
			panel1.Controls.Add(btnBorrarTodo);
			panel1.Controls.Add(btnBorrarUlt);
			panel1.Controls.Add(txbGrado);
			panel1.Controls.Add(label16);
			panel1.Controls.Add(txbTolerancia);
			panel1.Controls.Add(label15);
			panel1.Controls.Add(panelPuntos);
			panel1.Controls.Add(label14);
			panel1.Controls.Add(label13);
			panel1.Controls.Add(txbPuntoY);
			panel1.Controls.Add(txbPuntoX);
			panel1.Controls.Add(lblDimension);
			panel1.Controls.Add(btnLimpiar);
			panel1.Controls.Add(btnCalcular);
			panel1.Controls.Add(btnGenerar);
			panel1.Controls.Add(label5);
			panel1.Location = new Point(19, 68);
			panel1.Name = "panel1";
			panel1.Size = new Size(294, 370);
			panel1.TabIndex = 22;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.BackColor = Color.GhostWhite;
			label17.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label17.Location = new Point(15, 292);
			label17.Name = "label17";
			label17.Size = new Size(75, 17);
			label17.TabIndex = 41;
			label17.Text = "Metodo:  ";
			// 
			// cbMetodo
			// 
			cbMetodo.FormattingEnabled = true;
			cbMetodo.Items.AddRange(new object[] { "Regresión Lineal", "Regresión Polinomial" });
			cbMetodo.Location = new Point(96, 291);
			cbMetodo.Name = "cbMetodo";
			cbMetodo.Size = new Size(158, 23);
			cbMetodo.TabIndex = 40;
			cbMetodo.SelectedIndexChanged += cbMetodo_SelectedIndexChanged;
			// 
			// btnBorrarTodo
			// 
			btnBorrarTodo.BackColor = Color.Tan;
			btnBorrarTodo.Location = new Point(149, 223);
			btnBorrarTodo.Name = "btnBorrarTodo";
			btnBorrarTodo.Size = new Size(116, 23);
			btnBorrarTodo.TabIndex = 39;
			btnBorrarTodo.Text = "Borrar Todo";
			btnBorrarTodo.UseVisualStyleBackColor = false;
			btnBorrarTodo.Click += btnBorrarTodo_Click;
			// 
			// btnBorrarUlt
			// 
			btnBorrarUlt.BackColor = Color.Tan;
			btnBorrarUlt.Location = new Point(27, 223);
			btnBorrarUlt.Name = "btnBorrarUlt";
			btnBorrarUlt.Size = new Size(116, 23);
			btnBorrarUlt.TabIndex = 38;
			btnBorrarUlt.Text = "Borrar Ultimo";
			btnBorrarUlt.UseVisualStyleBackColor = false;
			btnBorrarUlt.Click += btnBorrarUlt_Click;
			// 
			// txbGrado
			// 
			txbGrado.Location = new Point(217, 262);
			txbGrado.Name = "txbGrado";
			txbGrado.Size = new Size(67, 23);
			txbGrado.TabIndex = 37;
			txbGrado.TextChanged += txbGrado_TextChanged;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.BackColor = Color.GhostWhite;
			label16.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label16.Location = new Point(163, 263);
			label16.Name = "label16";
			label16.Size = new Size(66, 17);
			label16.TabIndex = 36;
			label16.Text = "Grado:  ";
			// 
			// txbTolerancia
			// 
			txbTolerancia.Location = new Point(90, 262);
			txbTolerancia.Name = "txbTolerancia";
			txbTolerancia.Size = new Size(67, 23);
			txbTolerancia.TabIndex = 35;
			txbTolerancia.TextChanged += txbTolerancia_TextChanged;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.BackColor = Color.GhostWhite;
			label15.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label15.Location = new Point(15, 263);
			label15.Name = "label15";
			label15.Size = new Size(87, 17);
			label15.TabIndex = 34;
			label15.Text = "Toleracia:  ";
			// 
			// panelPuntos
			// 
			panelPuntos.BackColor = Color.Gainsboro;
			panelPuntos.Location = new Point(15, 101);
			panelPuntos.Name = "panelPuntos";
			panelPuntos.Size = new Size(269, 116);
			panelPuntos.TabIndex = 33;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.BackColor = Color.GhostWhite;
			label14.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label14.Location = new Point(188, 67);
			label14.Name = "label14";
			label14.Size = new Size(15, 17);
			label14.TabIndex = 32;
			label14.Text = "y";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.BackColor = Color.GhostWhite;
			label13.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label13.Location = new Point(119, 67);
			label13.Name = "label13";
			label13.Size = new Size(16, 17);
			label13.TabIndex = 31;
			label13.Text = "x";
			// 
			// txbPuntoY
			// 
			txbPuntoY.Location = new Point(141, 65);
			txbPuntoY.Name = "txbPuntoY";
			txbPuntoY.Size = new Size(41, 23);
			txbPuntoY.TabIndex = 30;
			// 
			// txbPuntoX
			// 
			txbPuntoX.Location = new Point(75, 65);
			txbPuntoX.Name = "txbPuntoX";
			txbPuntoX.Size = new Size(41, 23);
			txbPuntoX.TabIndex = 29;
			// 
			// lblDimension
			// 
			lblDimension.AutoSize = true;
			lblDimension.BackColor = Color.GhostWhite;
			lblDimension.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDimension.Location = new Point(14, 67);
			lblDimension.Name = "lblDimension";
			lblDimension.Size = new Size(73, 17);
			lblDimension.TabIndex = 28;
			lblDimension.Text = "Puntos:  ";
			// 
			// btnLimpiar
			// 
			btnLimpiar.BackColor = Color.SaddleBrown;
			btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
			btnLimpiar.ForeColor = Color.Transparent;
			btnLimpiar.Location = new Point(149, 325);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(129, 31);
			btnLimpiar.TabIndex = 27;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = false;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnCalcular
			// 
			btnCalcular.BackColor = SystemColors.ButtonShadow;
			btnCalcular.Location = new Point(14, 325);
			btnCalcular.Name = "btnCalcular";
			btnCalcular.Size = new Size(129, 31);
			btnCalcular.TabIndex = 25;
			btnCalcular.Text = "Calcular";
			btnCalcular.UseVisualStyleBackColor = false;
			btnCalcular.Click += btnCalcular_Click;
			// 
			// btnGenerar
			// 
			btnGenerar.BackColor = Color.SaddleBrown;
			btnGenerar.ForeColor = Color.Transparent;
			btnGenerar.Location = new Point(206, 65);
			btnGenerar.Name = "btnGenerar";
			btnGenerar.Size = new Size(85, 23);
			btnGenerar.TabIndex = 24;
			btnGenerar.Text = "Generar";
			btnGenerar.UseVisualStyleBackColor = false;
			btnGenerar.Click += btnGenerar_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.SaddleBrown;
			label5.Font = new Font("Britannic Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.GhostWhite;
			label5.Location = new Point(99, 9);
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
			panel3.TabIndex = 21;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Britannic Bold", 24F, FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.SaddleBrown;
			label6.Location = new Point(377, 9);
			label6.Name = "label6";
			label6.Size = new Size(104, 36);
			label6.TabIndex = 4;
			label6.Text = "Σ(x+y)";
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
			label1.ForeColor = Color.SaddleBrown;
			label1.Location = new Point(75, 5);
			label1.Name = "label1";
			label1.Size = new Size(287, 41);
			label1.TabIndex = 1;
			label1.Text = "Ajuste de curvas";
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
			// panel2
			// 
			panel2.BackColor = Color.GhostWhite;
			panel2.Controls.Add(lblMetodo);
			panel2.Controls.Add(panel9);
			panel2.Controls.Add(panel7);
			panel2.Controls.Add(panel5);
			panel2.Controls.Add(paneGrafica);
			panel2.Controls.Add(label4);
			panel2.Location = new Point(319, 68);
			panel2.Name = "panel2";
			panel2.Size = new Size(463, 370);
			panel2.TabIndex = 23;
			// 
			// lblMetodo
			// 
			lblMetodo.AutoSize = true;
			lblMetodo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblMetodo.Location = new Point(202, 16);
			lblMetodo.Name = "lblMetodo";
			lblMetodo.Size = new Size(61, 17);
			lblMetodo.TabIndex = 7;
			lblMetodo.Text = "metodo";
			// 
			// panel9
			// 
			panel9.BackColor = Color.Gainsboro;
			panel9.Controls.Add(panel10);
			panel9.Controls.Add(label9);
			panel9.Controls.Add(lblEfectividad);
			panel9.Location = new Point(8, 94);
			panel9.Name = "panel9";
			panel9.Size = new Size(217, 46);
			panel9.TabIndex = 27;
			// 
			// panel10
			// 
			panel10.BackColor = Color.Tan;
			panel10.Location = new Point(8, 0);
			panel10.Name = "panel10";
			panel10.Size = new Size(11, 75);
			panel10.TabIndex = 0;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(25, 14);
			label9.Name = "label9";
			label9.Size = new Size(89, 17);
			label9.TabIndex = 5;
			label9.Text = "Efectividad:";
			// 
			// lblEfectividad
			// 
			lblEfectividad.AutoSize = true;
			lblEfectividad.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblEfectividad.Location = new Point(120, 13);
			lblEfectividad.Name = "lblEfectividad";
			lblEfectividad.Size = new Size(47, 16);
			lblEfectividad.TabIndex = 6;
			lblEfectividad.Text = "label2";
			// 
			// panel7
			// 
			panel7.BackColor = Color.Gainsboro;
			panel7.Controls.Add(panel8);
			panel7.Controls.Add(label7);
			panel7.Controls.Add(lblcorrelacion);
			panel7.Location = new Point(231, 94);
			panel7.Name = "panel7";
			panel7.Size = new Size(217, 46);
			panel7.TabIndex = 27;
			// 
			// panel8
			// 
			panel8.BackColor = Color.Sienna;
			panel8.Location = new Point(8, 0);
			panel8.Name = "panel8";
			panel8.Size = new Size(11, 75);
			panel8.TabIndex = 0;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(25, 14);
			label7.Name = "label7";
			label7.Size = new Size(108, 16);
			label7.TabIndex = 5;
			label7.Text = "Correlación (r):";
			// 
			// lblcorrelacion
			// 
			lblcorrelacion.AutoSize = true;
			lblcorrelacion.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblcorrelacion.Location = new Point(139, 14);
			lblcorrelacion.Name = "lblcorrelacion";
			lblcorrelacion.Size = new Size(47, 16);
			lblcorrelacion.TabIndex = 6;
			lblcorrelacion.Text = "label2";
			// 
			// panel5
			// 
			panel5.BackColor = Color.Gainsboro;
			panel5.Controls.Add(panel6);
			panel5.Controls.Add(lblFuncionIngresada);
			panel5.Controls.Add(lblfuncion);
			panel5.Location = new Point(8, 42);
			panel5.Name = "panel5";
			panel5.Size = new Size(440, 46);
			panel5.TabIndex = 26;
			// 
			// panel6
			// 
			panel6.BackColor = Color.SaddleBrown;
			panel6.Location = new Point(8, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(11, 75);
			panel6.TabIndex = 0;
			// 
			// lblFuncionIngresada
			// 
			lblFuncionIngresada.AutoSize = true;
			lblFuncionIngresada.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFuncionIngresada.Location = new Point(25, 14);
			lblFuncionIngresada.Name = "lblFuncionIngresada";
			lblFuncionIngresada.Size = new Size(69, 17);
			lblFuncionIngresada.TabIndex = 5;
			lblFuncionIngresada.Text = "Función:";
			// 
			// lblfuncion
			// 
			lblfuncion.AutoSize = true;
			lblfuncion.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblfuncion.Location = new Point(127, 14);
			lblfuncion.Name = "lblfuncion";
			lblfuncion.Size = new Size(47, 16);
			lblfuncion.TabIndex = 6;
			lblfuncion.Text = "label2";
			// 
			// paneGrafica
			// 
			paneGrafica.Location = new Point(8, 146);
			paneGrafica.Name = "paneGrafica";
			paneGrafica.Size = new Size(448, 219);
			paneGrafica.TabIndex = 25;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.SaddleBrown;
			label4.Font = new Font("Britannic Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.GhostWhite;
			label4.Location = new Point(50, 9);
			label4.Name = "label4";
			label4.Size = new Size(131, 30);
			label4.TabIndex = 24;
			label4.Text = "Resultado";
			// 
			// Unid3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Tan;
			ClientSize = new Size(800, 450);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(panel3);
			Name = "Unid3";
			Text = "Unid3";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Panel panel3;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Button btnGenerar;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Panel paneGrafica;
        private Panel panel9;
        private Panel panel10;
        private Label label9;
        private Label lblEfectividad;
        private Panel panel7;
        private Panel panel8;
        private Label label7;
        private Label lblcorrelacion;
        private Panel panel5;
        private Panel panel6;
        private Label lblFuncionIngresada;
        private Label lblfuncion;
        private Label lblDimension;
        private Label label14;
        private Label label13;
        private TextBox txbPuntoY;
        private TextBox txbPuntoX;
        private Button btnBorrarTodo;
        private Button btnBorrarUlt;
        private TextBox txbGrado;
        private Label label16;
        private TextBox txbTolerancia;
        private Label label15;
        private Panel panelPuntos;
        private Label label17;
        private ComboBox cbMetodo;
		private Label lblMetodo;
	}
}