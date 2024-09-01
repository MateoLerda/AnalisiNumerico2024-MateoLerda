using AnalisisNumerico.Unidad1;
using AnalisisNumerico.Uno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AnalisisNumerico
{
	public partial class Unidad1a : Form
	{
		public Unidad1a()
		{
			InitializeComponent();
		}


		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Inicio inicio = new Inicio();
			inicio.ShowDialog();
			this.Close();
		}

		//EJECUTAR PRINCIPAL
		private void btnEjecutar_Click(object sender, EventArgs e)
		{

			Datos datos = new Datos()
			{
				Funcion = txtFuncion.Text,
				Metodo = cbMetodo.SelectedIndex,
				Xi = Convert.ToInt64(txtXi.Text),
				Iteraciones = int.Parse(tbIteraciones.Text),
			};

			if (string.IsNullOrEmpty(tbTolerancia.Text))
			{
				datos.Tolerancia = 0.0001;
			}
			else
			{
				datos.Tolerancia = Convert.ToDouble(tbTolerancia.Text);
			}
			if (cbMetodo.SelectedIndex != 2)
			{
				datos.Xd = Convert.ToInt64(tbXd.Text);
			}
			//metodo
			Unida1Logica service = new Unida1Logica();
			Result result = service.CalculosU1(datos);
			//visibles 
			lblConverge.Visible = true;
			lblError.Visible = true;
			lblRaiz.Visible = true;
			lbliteracionesResult.Visible = true;
			lblResultadoMetodo.Visible = true;
			//valores 
			lblConverge.Text = (result.Converge) ? "Si" : "No";
			lblError.Text = result.Error;
			lblRaiz.Text = (result.Raiz).ToString();
			lbliteracionesResult.Text = result.Interacciones.ToString();
			lblResultadoMetodo.Text = this.cbMetodo.Text;
			btnEjecutar.BackColor = Color.Indigo;
			btnEjecutar.ForeColor = Color.White;
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unidad1a newForm = new Unidad1a();
			newForm.Show();
			this.Close();
		}
		private void Unidad1a_Resize(object sender, EventArgs e)
		{
			panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
			panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
		}

		private void Unidad1a_Load(object sender, EventArgs e)
		{
			lblConverge.Visible = false;
			lblError.Visible = false;
			lblRaiz.Visible = false;
			lbliteracionesResult.Visible = false;
			lblResultadoMetodo.Visible = false;
			btnEjecutar.Enabled = false;
			btnEjecutar.ForeColor = Color.Black;
		}

		private void validarCampo()
		{
			var vr = false;
			if (this.cbMetodo.SelectedIndex == 2)
			{
				vr = !string.IsNullOrEmpty(txtFuncion.Text) && !string.IsNullOrEmpty(cbMetodo.Text) && !string.IsNullOrEmpty(txtXi.Text) && !string.IsNullOrEmpty(tbIteraciones.Text);
			}
			else
			{
				vr = !string.IsNullOrEmpty(txtFuncion.Text) && !string.IsNullOrEmpty(cbMetodo.Text) && !string.IsNullOrEmpty(txtXi.Text) && !string.IsNullOrEmpty(tbXd.Text) && !string.IsNullOrEmpty(tbIteraciones.Text);
			}
			btnEjecutar.Enabled = vr;
			if (vr)
			{
				btnEjecutar.BackColor = Color.MediumSlateBlue;
				btnEjecutar.ForeColor = Color.Black;
			}
		}

		private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			validarCampo();
		}

		private void txtXi_TextChanged(object sender, EventArgs e)
		{
			validarCampo();
		}

		private void tbXd_TextChanged(object sender, EventArgs e)
		{
			validarCampo();
		}

		private void txtFuncion_TextChanged(object sender, EventArgs e)
		{
			validarCampo();
		}

		private void tbIteraciones_TextChanged(object sender, EventArgs e)
		{
			validarCampo();
		}

	}
}
