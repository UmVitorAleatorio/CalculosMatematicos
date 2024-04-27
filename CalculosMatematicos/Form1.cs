using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculosMatematicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, r;

        private void btnSub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            r = n1 - n2;
            txtResult.Text = r.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            r = n1 * n2;
            txtResult.Text = r.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            r = n1 / n2;
            txtResult.Text = r.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            r = n1 % n2;
            txtResult.Text = r.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            Close();
            }
        }

        private void btnApag_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtResult.Text = "";
            txtN1.Focus();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            r = n1 + n2;
            txtResult.Text = r.ToString();
        }
    }
}
