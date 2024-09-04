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

            btnEjecutar.BackColor = Color.YellowGreen;
            btnEjecutar.ForeColor = Color.White;

        }
        //
        //-------------------Validar----------------
        //
        private void validarCampo()
        {
            var vr = false;
            var vr2 = false;
            vr = !string.IsNullOrEmpty(cbMetodo.Text);
            btnEjecutar.Enabled = vr;
            vr2 = !string.IsNullOrEmpty(txbDimension.Text);
            btnGenerar .Enabled = vr2;
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
        //----------------Limpiar-------------------
        //
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unidad2 newForm = new Unidad2();
            newForm.Show();
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.BackColor = Color.YellowGreen;
            btnGenerar.ForeColor = Color.White;
        }
    }
}
