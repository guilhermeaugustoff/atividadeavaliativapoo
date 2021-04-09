using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Avaliativa_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double valor, multa, taxa, vmulta, total;
            int dias;

            valor = Double.Parse(txtconta.Text);
            dias = int.Parse(txtatraso.Text);

            multa = 8.49;
            taxa = 1.0005;

            vmulta = multa + dias * (valor * taxa);
            total = valor + vmulta;

            MessageBox.Show("O valor da multa que será cobrado é de: "+vmulta+", e o valor " +
                "total que será cobrado é de R$"+total+".");




        }
    }
}
