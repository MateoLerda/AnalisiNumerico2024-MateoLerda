using Analisis_Numerico;
using AnalisisNumerico.Tres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.Cuatro
{
	public partial class Unidad4 : Form
	{
		public Unidad4()
		{
			InitializeComponent();
			areaResult.Visible = false;
			metodoResult.Visible = false;

		}


		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unidad4 newForm = new Unidad4();
			newForm.Show();
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Inicio inicio = new Inicio();
			inicio.ShowDialog();
			this.Close();
		}
		//Validar Campos 
		private void ValidarCampos()
		{

			bool validar = false;
			if ((this.cbMetodo.SelectedIndex) % 2 == 0)
			{
				validar = !string.IsNullOrEmpty(txbFuncion.Text) && !string.IsNullOrEmpty(cbMetodo.Text) && !string.IsNullOrEmpty(txbXi.Text) && !string.IsNullOrEmpty(txbXd.Text);
			}
			else
			{
				validar = !string.IsNullOrEmpty(txbFuncion.Text) && !string.IsNullOrEmpty(cbMetodo.Text) && !string.IsNullOrEmpty(txbXi.Text) && !string.IsNullOrEmpty(txbXd.Text) && !string.IsNullOrEmpty(txbSubInterv.Text);
			}

			btnCalcular.Enabled = validar;

			if (validar)
			{
				btnCalcular.BackColor = Color.Firebrick;
				btnCalcular.ForeColor = Color.White;
			}
		}

		private void txbFuncion_TextChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void txbXi_TextChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void txbXd_TextChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void txbSubInterv_TextChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidarCampos();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			Logica4 logica = new Logica4();
			Datos datos = new Datos() {
				Funcion = txbFuncion.Text,
				Xi = double.Parse(txbXi.Text),
				Xd = double.Parse(txbXd.Text),
				CantidadSubInter = string.IsNullOrEmpty(txbSubInterv.Text) ? 0 : int.Parse(txbSubInterv.Text),
				Metodo = cbMetodo.SelectedIndex,
			};
			Resultado4 resultado = logica.CalculoArea(datos);
			impResults(resultado);
			graficador();
		}

		private void impResults(Resultado4 resultado){

			if (!resultado.Sucsses)
			{
				MessageBox.Show(resultado.Message);
				return;
			}
			areaResult.Text= resultado.Area.ToString();
			areaResult.Visible= true;
			metodoResult.Text= (cbMetodo.SelectedIndex == 5)? "1/3 y 3/8 Convinado": cbMetodo.Text;
			metodoResult.Visible= true;
			
			btnCalcular.BackColor = Color.Coral;

		}

		private async void graficador() {

			await grafica.EnsureCoreWebView2Async(null);

			
			string funcion = txbFuncion.Text; 
			string funcionModificada = Regex.Replace(funcion, @"\+", "%2B");
			funcionModificada = Regex.Replace(funcionModificada, @"\blog\b", "ln");


			string urlGeoGebra = $"https://www.geogebra.org/graphing?command=f(x)={funcionModificada}";
		
			grafica.CoreWebView2.Navigate(urlGeoGebra);
		}
	}
}
