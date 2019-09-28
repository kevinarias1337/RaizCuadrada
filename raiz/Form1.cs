using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raiz
{
    public partial class Form1 : Form
    {
        Raiz raiz = new Raiz();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            raiz.setNumero(double.Parse(txtnumero.Text));
            lbltotal.Text = raiz.calcularRaiz().ToString();
            lbltotal.Visible = true;

        }
    }
}
