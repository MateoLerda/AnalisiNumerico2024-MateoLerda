using Analisis_Numerico;
using AnalisisNumerico.Dos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnalisisNumerico.Tres
{
	public partial class Unid3 : Form
	{
		public Graficador graficador { get; set; }
		private Data data = new Data();
		public Unid3()
		{
			InitializeComponent();
			lblcorrelacion.Visible = false;
			lblfuncion.Visible = false;
			lblEfectividad.Visible = false;
			lblMetodo.Visible = false;
		}



		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Inicio inicio = new Inicio();
			inicio.ShowDialog();
			this.Close();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unid3 newForm = new Unid3();
			newForm.Show();
			this.Close();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			if (data.Puntos.Count == 15)
			{
				MessageBox.Show("Se superaron los 15 puntos maximos");
				return;
			}
			double[] eje = new double[2];
			eje[0] = double.Parse(txbPuntoX.Text);
			eje[1] = double.Parse(txbPuntoY.Text);
			data.Puntos.Add(eje);
			showPuntos(data.Puntos);
		}

		private void showPuntos(List<double[]> list)
		{

			panelPuntos.Controls.Clear();
			int x = 5;
			int y = 10;
			for (int i = 0; i < list.Count; i++)
			{
				Label labelX = new Label();
				labelX.Text = $"(X: " + Math.Round(list[i][0], 1).ToString();
				labelX.Location = new Point(x, y);
				labelX.Size = new Size(45, 15);
				Label labelY = new Label();
				labelY.Text = $"Y: " + Math.Round(list[i][1], 1).ToString() + ")";
				labelY.Location = new Point(x + 42, y);
				labelY.Size = new Size(45, 15);
				panelPuntos.Controls.Add(labelX);
				panelPuntos.Controls.Add(labelY);
				panelPuntos.Show();
				y += 20;
				if (i == 4)
				{
					y = 10;
					x = 90;
				}
				if (i == 9)
				{
					y = 10;
					x = 175;
				}

			}

		}

		private void setPanelGrafica() { 
			paneGrafica.Controls.Clear();
			this.graficador = new Graficador();
			paneGrafica.Controls.Add(graficador);
			graficador.Dock = DockStyle.Fill;
		}
		private void btnBorrarUlt_Click(object sender, EventArgs e)
		{
			if (data.Puntos.Count == 0)
			{
				MessageBox.Show("Ya no hay elementos en la lista");
				return;
			}
			int ultimo = data.Puntos.Count - 1;
			data.Puntos.RemoveAt(ultimo);
			showPuntos(data.Puntos);
		}

		private void btnBorrarTodo_Click(object sender, EventArgs e)
		{
			data.Puntos.Clear();
			showPuntos(data.Puntos);
		}
		private void ValidarCampos()
		{

			bool validar = false;
			if (this.cbMetodo.SelectedIndex == 0) {
                validar = !string.IsNullOrEmpty(txbTolerancia.Text) && !string.IsNullOrEmpty(cbMetodo.Text) && data.Puntos.Count > 0;
			}
			else
			{
                validar = !string.IsNullOrEmpty(txbTolerancia.Text) && !string.IsNullOrEmpty(cbMetodo.Text) && !string.IsNullOrEmpty(txbGrado.Text) && data.Puntos.Count > 0;
            }
			btnCalcular.Enabled = validar;

			if (validar)
			{
				btnCalcular.BackColor = Color.Tan;
			}
		}

		private void txbTolerancia_TextChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void txbGrado_TextChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}
		//
		//-------------Calcular------------------
		//
		private void btnCalcular_Click(object sender, EventArgs e)
		{
			Unid3Logica logica= new Unid3Logica();
			data.Metodo= cbMetodo.SelectedIndex;
			data.Tolerancia = Convert.ToDouble(txbTolerancia.Text);
			data.Grado = string.IsNullOrEmpty(txbGrado.Text)? 1 : int.Parse(txbGrado.Text);
			Resultado result= logica.Calcular(data);
			ImpResultado(result, data.Puntos);
			btnCalcular.BackColor = Color.SaddleBrown;
			btnCalcular.ForeColor= Color.White;
		}

		//
		//-----------------Resultados-----------
		//
		private void ImpResultado(Resultado result, List<double[]> list) { 
			lblMetodo.Visible= true;
			lblMetodo.Text= cbMetodo.Text;
            lblcorrelacion.Visible = true;
			lblcorrelacion.Text =  $"{result.PorcentEfectiv} %";
			lblfuncion.Visible = true;
			lblfuncion.Text = $"y = {result.Funcion}";
            lblEfectividad.Visible = true;
			lblEfectividad.Text = (result.EfectAjust)? "Aceptable" : "No aceptable";
            setPanelGrafica();
			graficador.Graficar(list, result.Funcion);
		}
	}
}
