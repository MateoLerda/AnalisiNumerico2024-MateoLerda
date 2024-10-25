using AnalisisNumerico.Cuatro;
using AnalisisNumerico.Dos;
using AnalisisNumerico.Tres;

namespace AnalisisNumerico
{
	public partial class Inicio : Form
	{
		public Inicio()
		{
			InitializeComponent();
			this.Size = new Size(800, 600);
			this.BackgroundImage = Properties.Resources.imgInicio;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			this.WindowState = FormWindowState.Maximized;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnUnidad1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unidad1a unidad = new Unidad1a();
			unidad.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unidad2 unidad = new Unidad2();
			unidad.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unid3 unidad = new Unid3();
			unidad.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Unidad4 unidad = new Unidad4();
			unidad.ShowDialog();
		}
	}
}
