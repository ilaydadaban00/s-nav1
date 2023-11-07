using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav1_hilal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double dolar, miktar;

            miktar = Convert.ToDouble(txtMiktar.Text);
            dolar = Convert.ToDouble(txtDolar.Text);

            dolar = dolar * miktar;

            lblTL.Text = dolar.ToString();
        }
    }
}
