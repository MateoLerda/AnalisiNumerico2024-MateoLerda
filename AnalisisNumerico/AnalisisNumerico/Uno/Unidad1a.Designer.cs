namespace AnalisisNumerico
{
    partial class Unidad1a
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
			components = new System.ComponentModel.Container();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			timer1 = new System.Windows.Forms.Timer(components);
			panel1 = new Panel();
			tbTolerancia = new TextBox();
			label7 = new Label();
			btnLimpiar = new Button();
			btnEjecutar = new Button();
			label4 = new Label();
			txtFuncion = new TextBox();
			lblFuncion = new Label();
			tbIteraciones = new TextBox();
			cbMetodo = new ComboBox();
			lblInteracciones = new Label();
			lblMetodo = new Label();
			tbXd = new TextBox();
			lblxi = new Label();
			lblXd = new Label();
			txtXi = new TextBox();
			panel2 = new Panel();
			panel8 = new Panel();
			lblError = new Label();
			label9 = new Label();
			panel9 = new Panel();
			lblResultadoMetodo = new Label();
			lblMetodoElegido = new Label();
			panel6 = new Panel();
			lblConverge = new Label();
			label10 = new Label();
			panel7 = new Panel();
			panel10 = new Panel();
			lbliteracionesResult = new Label();
			label8 = new Label();
			panel11 = new Panel();
			panel4 = new Panel();
			panel5 = new Panel();
			lblFuncionIngresada = new Label();
			lblRaiz = new Label();
			label5 = new Label();
			panel3 = new Panel();
			label6 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel12 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel8.SuspendLayout();
			panel6.SuspendLayout();
			panel10.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel12.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.GhostWhite;
			panel1.Controls.Add(tbTolerancia);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(btnLimpiar);
			panel1.Controls.Add(btnEjecutar);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(txtFuncion);
			panel1.Controls.Add(lblFuncion);
			panel1.Controls.Add(tbIteraciones);
			panel1.Controls.Add(cbMetodo);
			panel1.Controls.Add(lblInteracciones);
			panel1.Controls.Add(lblMetodo);
			panel1.Controls.Add(tbXd);
			panel1.Controls.Add(lblxi);
			panel1.Controls.Add(lblXd);
			panel1.Controls.Add(txtXi);
			panel1.Location = new Point(6, 61);
			panel1.Name = "panel1";
			panel1.Size = new Size(379, 370);
			panel1.TabIndex = 16;
			// 
			// tbTolerancia
			// 
			tbTolerancia.Location = new Point(120, 283);
			tbTolerancia.Name = "tbTolerancia";
			tbTolerancia.Size = new Size(225, 23);
			tbTolerancia.TabIndex = 18;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(3, 283);
			label7.Name = "label7";
			label7.Size = new Size(86, 17);
			label7.TabIndex = 17;
			label7.Text = "Tolerancia:";
			// 
			// btnLimpiar
			// 
			btnLimpiar.BackColor = Color.MediumSlateBlue;
			btnLimpiar.Location = new Point(190, 328);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(166, 33);
			btnLimpiar.TabIndex = 16;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = false;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnEjecutar
			// 
			btnEjecutar.Location = new Point(14, 328);
			btnEjecutar.Name = "btnEjecutar";
			btnEjecutar.Size = new Size(170, 33);
			btnEjecutar.TabIndex = 15;
			btnEjecutar.Text = "Ejecutar";
			btnEjecutar.UseVisualStyleBackColor = true;
			btnEjecutar.Click += btnEjecutar_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.SlateBlue;
			label4.Font = new Font("Britannic Bold", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.GhostWhite;
			label4.Location = new Point(39, 23);
			label4.Name = "label4";
			label4.Size = new Size(280, 38);
			label4.TabIndex = 4;
			label4.Text = "Ingreso de Datos";
			// 
			// txtFuncion
			// 
			txtFuncion.Location = new Point(120, 196);
			txtFuncion.Name = "txtFuncion";
			txtFuncion.Size = new Size(225, 23);
			txtFuncion.TabIndex = 0;
			txtFuncion.TextChanged += txtFuncion_TextChanged;
			// 
			// lblFuncion
			// 
			lblFuncion.AutoSize = true;
			lblFuncion.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFuncion.Location = new Point(10, 199);
			lblFuncion.Name = "lblFuncion";
			lblFuncion.Size = new Size(69, 17);
			lblFuncion.TabIndex = 1;
			lblFuncion.Text = "Funcion:";
			// 
			// tbIteraciones
			// 
			tbIteraciones.Location = new Point(156, 235);
			tbIteraciones.Name = "tbIteraciones";
			tbIteraciones.Size = new Size(189, 23);
			tbIteraciones.TabIndex = 14;
			tbIteraciones.TextChanged += tbIteraciones_TextChanged;
			// 
			// cbMetodo
			// 
			cbMetodo.FormattingEnabled = true;
			cbMetodo.Items.AddRange(new object[] { "Metodo de la Bisección", "Metodo de la Regla Falsa", "Newton-Raphson (Tangente)", "Metodo de la Secante" });
			cbMetodo.Location = new Point(120, 85);
			cbMetodo.Name = "cbMetodo";
			cbMetodo.Size = new Size(225, 23);
			cbMetodo.TabIndex = 2;
			cbMetodo.SelectedIndexChanged += cbMetodo_SelectedIndexChanged;
			// 
			// lblInteracciones
			// 
			lblInteracciones.AutoSize = true;
			lblInteracciones.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblInteracciones.Location = new Point(3, 236);
			lblInteracciones.Name = "lblInteracciones";
			lblInteracciones.Size = new Size(147, 17);
			lblInteracciones.TabIndex = 13;
			lblInteracciones.Text = "Iteraciones Totales:";
			// 
			// lblMetodo
			// 
			lblMetodo.AutoSize = true;
			lblMetodo.BackColor = Color.GhostWhite;
			lblMetodo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblMetodo.Location = new Point(10, 88);
			lblMetodo.Name = "lblMetodo";
			lblMetodo.Size = new Size(65, 17);
			lblMetodo.TabIndex = 3;
			lblMetodo.Text = "Metodo:";
			// 
			// tbXd
			// 
			tbXd.Location = new Point(120, 159);
			tbXd.Name = "tbXd";
			tbXd.Size = new Size(225, 23);
			tbXd.TabIndex = 12;
			tbXd.TextChanged += tbXd_TextChanged;
			// 
			// lblxi
			// 
			lblxi.AutoSize = true;
			lblxi.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblxi.Location = new Point(14, 126);
			lblxi.Name = "lblxi";
			lblxi.Size = new Size(31, 17);
			lblxi.TabIndex = 9;
			lblxi.Text = "Xi: ";
			// 
			// lblXd
			// 
			lblXd.AutoSize = true;
			lblXd.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblXd.Location = new Point(14, 162);
			lblXd.Name = "lblXd";
			lblXd.Size = new Size(36, 17);
			lblXd.TabIndex = 11;
			lblXd.Text = "Xd: ";
			// 
			// txtXi
			// 
			txtXi.AccessibleDescription = "Ingresar xi";
			txtXi.Location = new Point(120, 123);
			txtXi.Name = "txtXi";
			txtXi.Size = new Size(225, 23);
			txtXi.TabIndex = 10;
			txtXi.TextChanged += txtXi_TextChanged;
			// 
			// panel2
			// 
			panel2.BackColor = Color.GhostWhite;
			panel2.Controls.Add(panel8);
			panel2.Controls.Add(lblResultadoMetodo);
			panel2.Controls.Add(lblMetodoElegido);
			panel2.Controls.Add(panel6);
			panel2.Controls.Add(panel10);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(label5);
			panel2.Location = new Point(391, 61);
			panel2.Name = "panel2";
			panel2.Size = new Size(378, 371);
			panel2.TabIndex = 17;
			// 
			// panel8
			// 
			panel8.BackColor = SystemColors.ButtonFace;
			panel8.Controls.Add(lblError);
			panel8.Controls.Add(label9);
			panel8.Controls.Add(panel9);
			panel8.Location = new Point(23, 268);
			panel8.Name = "panel8";
			panel8.Size = new Size(328, 60);
			panel8.TabIndex = 17;
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblError.Location = new Point(142, 21);
			lblError.Name = "lblError";
			lblError.Size = new Size(52, 21);
			lblError.TabIndex = 8;
			lblError.Text = "label2";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(25, 21);
			label9.Name = "label9";
			label9.Size = new Size(52, 17);
			label9.TabIndex = 8;
			label9.Text = "Error:";
			// 
			// panel9
			// 
			panel9.BackColor = Color.MediumOrchid;
			panel9.Location = new Point(8, 0);
			panel9.Name = "panel9";
			panel9.Size = new Size(11, 75);
			panel9.TabIndex = 0;
			// 
			// lblResultadoMetodo
			// 
			lblResultadoMetodo.AutoSize = true;
			lblResultadoMetodo.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblResultadoMetodo.Location = new Point(184, 343);
			lblResultadoMetodo.Name = "lblResultadoMetodo";
			lblResultadoMetodo.Size = new Size(46, 18);
			lblResultadoMetodo.TabIndex = 8;
			lblResultadoMetodo.Text = "label4";
			// 
			// lblMetodoElegido
			// 
			lblMetodoElegido.AutoSize = true;
			lblMetodoElegido.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblMetodoElegido.Location = new Point(48, 343);
			lblMetodoElegido.Name = "lblMetodoElegido";
			lblMetodoElegido.Size = new Size(130, 18);
			lblMetodoElegido.TabIndex = 7;
			lblMetodoElegido.Text = "Segun el metodo:  ";
			// 
			// panel6
			// 
			panel6.BackColor = SystemColors.ButtonFace;
			panel6.Controls.Add(lblConverge);
			panel6.Controls.Add(label10);
			panel6.Controls.Add(panel7);
			panel6.Location = new Point(23, 202);
			panel6.Name = "panel6";
			panel6.Size = new Size(328, 60);
			panel6.TabIndex = 17;
			// 
			// lblConverge
			// 
			lblConverge.AutoSize = true;
			lblConverge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblConverge.Location = new Point(142, 22);
			lblConverge.Name = "lblConverge";
			lblConverge.Size = new Size(52, 21);
			lblConverge.TabIndex = 9;
			lblConverge.Text = "label2";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(25, 22);
			label10.Name = "label10";
			label10.Size = new Size(80, 17);
			label10.TabIndex = 9;
			label10.Text = "Converge:";
			// 
			// panel7
			// 
			panel7.BackColor = Color.BlueViolet;
			panel7.Location = new Point(8, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(11, 75);
			panel7.TabIndex = 0;
			// 
			// panel10
			// 
			panel10.BackColor = SystemColors.ButtonFace;
			panel10.Controls.Add(lbliteracionesResult);
			panel10.Controls.Add(label8);
			panel10.Controls.Add(panel11);
			panel10.Location = new Point(23, 136);
			panel10.Name = "panel10";
			panel10.Size = new Size(328, 60);
			panel10.TabIndex = 17;
			// 
			// lbliteracionesResult
			// 
			lbliteracionesResult.AutoSize = true;
			lbliteracionesResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbliteracionesResult.Location = new Point(142, 20);
			lbliteracionesResult.Name = "lbliteracionesResult";
			lbliteracionesResult.Size = new Size(52, 21);
			lbliteracionesResult.TabIndex = 7;
			lbliteracionesResult.Text = "label2";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(25, 23);
			label8.Name = "label8";
			label8.Size = new Size(92, 17);
			label8.TabIndex = 7;
			label8.Text = "Iteraciones:";
			// 
			// panel11
			// 
			panel11.BackColor = Color.DarkSlateBlue;
			panel11.Location = new Point(8, 0);
			panel11.Name = "panel11";
			panel11.Size = new Size(11, 75);
			panel11.TabIndex = 0;
			// 
			// panel4
			// 
			panel4.BackColor = SystemColors.ButtonFace;
			panel4.Controls.Add(panel5);
			panel4.Controls.Add(lblFuncionIngresada);
			panel4.Controls.Add(lblRaiz);
			panel4.Location = new Point(23, 70);
			panel4.Name = "panel4";
			panel4.Size = new Size(328, 60);
			panel4.TabIndex = 16;
			// 
			// panel5
			// 
			panel5.BackColor = Color.SlateBlue;
			panel5.Location = new Point(8, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(11, 75);
			panel5.TabIndex = 0;
			// 
			// lblFuncionIngresada
			// 
			lblFuncionIngresada.AutoSize = true;
			lblFuncionIngresada.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFuncionIngresada.Location = new Point(25, 21);
			lblFuncionIngresada.Name = "lblFuncionIngresada";
			lblFuncionIngresada.Size = new Size(42, 17);
			lblFuncionIngresada.TabIndex = 5;
			lblFuncionIngresada.Text = "Raiz:";
			// 
			// lblRaiz
			// 
			lblRaiz.AutoSize = true;
			lblRaiz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblRaiz.Location = new Point(142, 18);
			lblRaiz.Name = "lblRaiz";
			lblRaiz.Size = new Size(52, 21);
			lblRaiz.TabIndex = 6;
			lblRaiz.Text = "label2";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.SlateBlue;
			label5.Font = new Font("Britannic Bold", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.GhostWhite;
			label5.Location = new Point(105, 23);
			label5.Name = "label5";
			label5.Size = new Size(171, 38);
			label5.TabIndex = 15;
			label5.Text = "Resultado";
			// 
			// panel3
			// 
			panel3.BackColor = Color.GhostWhite;
			panel3.Controls.Add(label6);
			panel3.Controls.Add(label3);
			panel3.Controls.Add(label2);
			panel3.Controls.Add(label1);
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(6, 5);
			panel3.Name = "panel3";
			panel3.Size = new Size(763, 49);
			panel3.TabIndex = 18;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Britannic Bold", 24F, FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.Indigo;
			label6.Location = new Point(395, 5);
			label6.Name = "label6";
			label6.Size = new Size(105, 36);
			label6.TabIndex = 4;
			label6.Text = " √ f(x)";
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
			label1.ForeColor = Color.Indigo;
			label1.Location = new Point(69, 3);
			label1.Name = "label1";
			label1.Size = new Size(342, 76);
			label1.TabIndex = 1;
			label1.Text = "Raices de Funciones \r\n\r\n";
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
			// panel12
			// 
			panel12.Anchor = AnchorStyles.None;
			panel12.Controls.Add(panel3);
			panel12.Controls.Add(panel2);
			panel12.Controls.Add(panel1);
			panel12.Location = new Point(12, 3);
			panel12.Name = "panel12";
			panel12.Size = new Size(777, 435);
			panel12.TabIndex = 19;
			// 
			// Unidad1a
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Indigo;
			ClientSize = new Size(807, 450);
			Controls.Add(panel12);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "Unidad1a";
			Text = "Unidad1";
			Load += Unidad1a_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel8.ResumeLayout(false);
			panel8.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel10.ResumeLayout(false);
			panel10.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel12.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Timer timer1;
		private Panel panel1;
		private TextBox tbTolerancia;
		private Label label7;
		private Button btnLimpiar;
		private Button btnEjecutar;
		private Label label4;
		private TextBox txtFuncion;
		private Label lblFuncion;
		private TextBox tbIteraciones;
		private ComboBox cbMetodo;
		private Label lblInteracciones;
		private Label lblMetodo;
		private TextBox tbXd;
		private Label lblxi;
		private Label lblXd;
		private TextBox txtXi;
		private Panel panel2;
		private Panel panel8;
		private Label lblError;
		private Label label9;
		private Panel panel9;
		private Label lblResultadoMetodo;
		private Label lblMetodoElegido;
		private Panel panel6;
		private Label lblConverge;
		private Label label10;
		private Panel panel7;
		private Panel panel10;
		private Label lbliteracionesResult;
		private Label label8;
		private Panel panel11;
		private Panel panel4;
		private Panel panel5;
		private Label lblFuncionIngresada;
		private Label lblRaiz;
		private Label label5;
		private Panel panel3;
		private Label label6;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Panel panel12;
	}
}