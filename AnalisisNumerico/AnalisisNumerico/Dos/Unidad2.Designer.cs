namespace AnalisisNumerico.Dos
{
    partial class Unidad2
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
			panel3 = new Panel();
			label6 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			labmetodoResult = new Label();
			label5 = new Label();
			btnGenerar = new Button();
			btnLimpiar = new Button();
			panel4 = new Panel();
			txbDimension = new TextBox();
			lblDimension = new Label();
			btnEjecutar = new Button();
			label4 = new Label();
			cbMetodo = new ComboBox();
			lblMetodo = new Label();
			panel2 = new Panel();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.BackColor = Color.GhostWhite;
			panel3.Controls.Add(label6);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(label1);
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(12, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(763, 49);
			panel3.TabIndex = 19;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Britannic Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.DarkOliveGreen;
			label6.Location = new Point(445, 16);
			label6.Name = "label6";
			label6.Size = new Size(66, 23);
			label6.TabIndex = 4;
			label6.Text = "x1+x2";
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
			label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.DarkOliveGreen;
			label1.Location = new Point(55, 3);
			label1.Name = "label1";
			label1.Size = new Size(397, 38);
			label1.TabIndex = 1;
			label1.Text = "Sistemas de Ecuaciones ";
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
			// panel1
			// 
			panel1.BackColor = Color.GhostWhite;
			panel1.Controls.Add(labmetodoResult);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(btnGenerar);
			panel1.Controls.Add(btnLimpiar);
			panel1.Controls.Add(panel4);
			panel1.Controls.Add(txbDimension);
			panel1.Controls.Add(lblDimension);
			panel1.Controls.Add(btnEjecutar);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(cbMetodo);
			panel1.Controls.Add(lblMetodo);
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(12, 68);
			panel1.Name = "panel1";
			panel1.Size = new Size(763, 370);
			panel1.TabIndex = 20;
			// 
			// labmetodoResult
			// 
			labmetodoResult.AutoSize = true;
			labmetodoResult.BackColor = Color.GhostWhite;
			labmetodoResult.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labmetodoResult.Location = new Point(579, 350);
			labmetodoResult.Name = "labmetodoResult";
			labmetodoResult.Size = new Size(93, 17);
			labmetodoResult.TabIndex = 23;
			labmetodoResult.Text = "Dimension: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.YellowGreen;
			label5.Font = new Font("Britannic Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.GhostWhite;
			label5.Location = new Point(579, 144);
			label5.Name = "label5";
			label5.Size = new Size(131, 30);
			label5.TabIndex = 22;
			label5.Text = "Resultado";
			// 
			// btnGenerar
			// 
			btnGenerar.Location = new Point(420, 59);
			btnGenerar.Name = "btnGenerar";
			btnGenerar.Size = new Size(145, 33);
			btnGenerar.TabIndex = 21;
			btnGenerar.Text = "Generar";
			btnGenerar.UseVisualStyleBackColor = true;
			btnGenerar.Click += btnGenerar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.BackColor = Color.DarkOliveGreen;
			btnLimpiar.Location = new Point(571, 108);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(166, 33);
			btnLimpiar.TabIndex = 16;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = false;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// panel4
			// 
			panel4.Location = new Point(535, 177);
			panel4.Name = "panel4";
			panel4.Size = new Size(202, 172);
			panel4.TabIndex = 20;
			// 
			// txbDimension
			// 
			txbDimension.Location = new Point(435, 20);
			txbDimension.Name = "txbDimension";
			txbDimension.Size = new Size(65, 23);
			txbDimension.TabIndex = 18;
			txbDimension.TextChanged += txbDimension_TextChanged;
			// 
			// lblDimension
			// 
			lblDimension.AutoSize = true;
			lblDimension.BackColor = Color.GhostWhite;
			lblDimension.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDimension.Location = new Point(336, 22);
			lblDimension.Name = "lblDimension";
			lblDimension.Size = new Size(93, 17);
			lblDimension.TabIndex = 17;
			lblDimension.Text = "Dimension: ";
			// 
			// btnEjecutar
			// 
			btnEjecutar.Location = new Point(571, 59);
			btnEjecutar.Name = "btnEjecutar";
			btnEjecutar.Size = new Size(166, 33);
			btnEjecutar.TabIndex = 15;
			btnEjecutar.Text = "Ejecutar";
			btnEjecutar.UseVisualStyleBackColor = true;
			btnEjecutar.Click += btnEjecutar_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.YellowGreen;
			label4.Font = new Font("Britannic Bold", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.GhostWhite;
			label4.Location = new Point(14, 22);
			label4.Name = "label4";
			label4.Size = new Size(280, 38);
			label4.TabIndex = 4;
			label4.Text = "Ingreso de Datos";
			// 
			// cbMetodo
			// 
			cbMetodo.FormattingEnabled = true;
			cbMetodo.Items.AddRange(new object[] { "Metodo Gauss-Jordan", "Metodo Gauss-Seidel" });
			cbMetodo.Location = new Point(579, 21);
			cbMetodo.Name = "cbMetodo";
			cbMetodo.Size = new Size(158, 23);
			cbMetodo.TabIndex = 2;
			cbMetodo.SelectedIndexChanged += cbMetodo_SelectedIndexChanged;
			// 
			// lblMetodo
			// 
			lblMetodo.AutoSize = true;
			lblMetodo.BackColor = Color.GhostWhite;
			lblMetodo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblMetodo.Location = new Point(508, 21);
			lblMetodo.Name = "lblMetodo";
			lblMetodo.Size = new Size(65, 17);
			lblMetodo.TabIndex = 3;
			lblMetodo.Text = "Metodo:";
			// 
			// panel2
			// 
			panel2.Location = new Point(14, 42);
			panel2.Name = "panel2";
			panel2.Size = new Size(515, 325);
			panel2.TabIndex = 19;
			// 
			// Unidad2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkOliveGreen;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Controls.Add(panel3);
			Name = "Unidad2";
			Text = "Form1";
			Load += Unidad2_Load;
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLimpiar;
        private Button btnEjecutar;
        private Label label4;
        private ComboBox cbMetodo;
        private Label lblMetodo;
        private Label lblDimension;
        private Button btnGenerar;
        private Panel panel4;
        private Panel panel2;
        private Label label5;
        private TextBox txbDimension;
		private Label labmetodoResult;
	}
}