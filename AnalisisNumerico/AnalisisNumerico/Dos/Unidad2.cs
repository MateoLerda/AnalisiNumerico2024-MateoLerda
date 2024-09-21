using AnalisisNumerico.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.Dos
{
	public partial class Unidad2 : Form
	{
		public Unidad2()
		{
			InitializeComponent();
		}

		private void Unidad2_Load(object sender, EventArgs e)
		{
			labmetodoResult.Visible = false;
			btnEjecutar.Enabled = false;
			btnGenerar.Enabled = false;
			cbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Inicio inicio = new Inicio();
			inicio.ShowDialog();
			this.Close();
		}
		//
		//---------------Ejecutar----------------------
		//
		private void btnEjecutar_Click(object sender, EventArgs e)
		{
			Datos datos = new Datos();
			datos.dimension = int.Parse(txbDimension.Text);
			datos.Matriz = GuardarMatriz(datos.dimension);
			datos.Metodo = cbMetodo.SelectedIndex;
			Unidad2Logica logica = new Unidad2Logica();
			Result result = logica.CalculosU2(datos);
			if (result.sucses)
			{
				resultado(result.Resultados);
				labmetodoResult.Text = cbMetodo.Text;
				labmetodoResult.Visible = true;
				btnEjecutar.BackColor = Color.YellowGreen;
				btnEjecutar.ForeColor = Color.White;
			}
			else
			{
				MessageBox.Show(result.message);
			}
		}
		//
		//
		private void resultado(List<double> list)
		{
			panel4.Controls.Clear();
			int puntox = 10;
			int puntoy = 20;
			int x = 250;
			if (list.Count >= 7)
			{
				x = 100;
			}
			for (int i = 0; i < list.Count; i++)
			{
				Label lbl = new Label();
				lbl.Text = $"X {i + 1} = {list[i]}";
				if (i == 7)
				{
					puntox = puntox + 85;
					puntoy = 50;
				}
				lbl.Location = new Point(puntox, puntoy);
				lbl.Size = new Size(x, 15);
				lbl.Font = new Font("Britannic Bold", 12);
				panel4.Controls.Add(lbl);
				panel4.Show();
				puntoy += 20;
			}
		}
		//
		//-------------------GuardarMatriz-----------------
		//
		private double[,] GuardarMatriz(int dimesion)
		{
			double[,] Matriz = new double[dimesion, dimesion + 1];
			for (int row = 0; row < dimesion; row++)
			{
				for (int col = 0; col < dimesion + 1; col++)
				{
					Control textBox = panel2.Controls.Find($"({row},{col})", true).First();
					if (!double.TryParse((textBox as TextBox).Text, out double numero))
					{
						MessageBox.Show("Ingresar todos los valores de forma correcta");
						return null;
					}
					if (row == col && double.Parse((textBox as TextBox).Text) == 0)
					{
						MessageBox.Show("Hay un 0 en la diagonal principal");
						return null;
					}
					Matriz[row, col] = numero;
				}
			}
			return Matriz;
		}
		//
		//-------------------Validar----------------
		//
		private void validarCampo()
		{
			var vr = false;
			var vr2 = false;
			vr2 = !string.IsNullOrEmpty(txbDimension.Text);
			btnGenerar.Enabled = vr2;

			vr = !string.IsNullOrEmpty(cbMetodo.Text) && vr2;
			btnEjecutar.Enabled = vr;

			if (vr2)
			{
				btnGenerar.BackColor = Color.DarkOliveGreen;
				btnGenerar.ForeColor = Color.Black;
			}

			if (vr)
			{
				btnEjecutar.BackColor = Color.DarkOliveGreen;
				btnEjecutar.ForeColor = Color.Black;
			}
		}

		private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			validarCampo();
		}
		//
		//------------Genaerar---------
		//
		private void btnGenerar_Click(object sender, EventArgs e)
		{
			if (int.Parse(txbDimension.Text) > 10)
			{
				MessageBox.Show("Dimencion incorrecta");
			}
			else
			{
				int dimension = int.Parse(txbDimension.Text);
				int puntox = 15;
				int puntoy = 30;
				if (dimension <= 7)
				{
					puntoy = 70;
				}
				panel2.Controls.Clear();
				for (int row = 0; row < dimension; row++)
				{
					for (int col = 0; col < dimension + 1; col++)
					{
						string nombre = $"({row},{col})";
						TextBox textBox = new TextBox();
						textBox.Name = nombre;
						ToolTip tooltip = new ToolTip();
						tooltip.SetToolTip(textBox, nombre);
						textBox.Location = new Point(puntox, puntoy);
						textBox.Size = new Size(35, 30);
						if (col == dimension)
						{
							textBox.BackColor = Color.DarkOliveGreen;
						}
						else if (dimension <= 7)
						{
							Label lbl = new Label();
							lbl.Text = $"X {col + 1}";
							lbl.Location = new Point(puntox + 35, puntoy);
							lbl.Size = new Size(25, 30);
							panel2.Controls.Add(lbl);
							puntox += 65;
						}
						else
						{
							puntox += 35;
						}
						if (col == row)
						{
							textBox.BackColor = Color.YellowGreen;
							textBox.ForeColor = Color.White;
						}
						panel2.Controls.Add(textBox);
						panel2.Show();

					}
					puntox = 15;
					puntoy += 30;
				}
			}
			btnGenerar.BackColor = Color.YellowGreen;
			btnGenerar.ForeColor = Color.White;
		}
		//
		//----------------Limpiar-------------------
		//
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unidad2 newForm = new Unidad2();
			newForm.Show();
			this.Close();
		}

		private void txbDimension_TextChanged(object sender, EventArgs e)
		{
			validarCampo();
		}

		
	}
}
