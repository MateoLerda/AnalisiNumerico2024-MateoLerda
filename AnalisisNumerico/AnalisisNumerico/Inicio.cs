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
    }
}
