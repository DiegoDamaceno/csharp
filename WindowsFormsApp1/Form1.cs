using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtmedia.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            decimal nota1, nota2, nota3, media, mediafinal;
            nota1 = Convert.ToDecimal(txtnota1.Text);
            nota2 = Convert.ToDecimal(txtnota2.Text);
            nota3 = Convert.ToDecimal(txtnota3.Text);
            media = nota1 + nota2 + nota3;
            mediafinal = media / 3;
            txtmedia.Text = mediafinal.ToString();

        }
    }
}
