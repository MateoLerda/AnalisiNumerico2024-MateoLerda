namespace AnalisisNumerico
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnUnidad1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Britannic Bold", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(618, 201);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(711, 53);
            label1.TabIndex = 0;
            label1.Text = "Sistema Analisis Numerico 2024";
            label1.Click += label1_Click;
            // 
            // btnUnidad1
            // 
            btnUnidad1.BackColor = Color.DarkBlue;
            btnUnidad1.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUnidad1.ForeColor = Color.WhiteSmoke;
            btnUnidad1.Location = new Point(730, 279);
            btnUnidad1.Margin = new Padding(4, 3, 4, 3);
            btnUnidad1.Name = "btnUnidad1";
            btnUnidad1.Size = new Size(466, 42);
            btnUnidad1.TabIndex = 1;
            btnUnidad1.Text = "Unidad 1: Raíces de funciones";
            btnUnidad1.UseVisualStyleBackColor = false;
            btnUnidad1.Click += btnUnidad1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(730, 497);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(466, 42);
            button3.TabIndex = 3;
            button3.Text = "Unidad 4: Integracion Numerica";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(730, 425);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(466, 42);
            button4.TabIndex = 4;
            button4.Text = "Unidad 3: Ajustes de curvas";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(730, 352);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(466, 42);
            button5.TabIndex = 5;
            button5.Text = "Unidad 2: Sistema de Ecuaciones";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1771, 801);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnUnidad1);
            Controls.Add(label1);
            Font = new Font("Broadway", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Inicio";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUnidad1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
