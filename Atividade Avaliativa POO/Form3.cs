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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblpagamento_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string nome;
            int diarias;
            double vdiaria, diariafixa;

            nome = (txtnome.Text);
            diarias = int.Parse(txtdiarias.Text);
            diariafixa = 180.00;

            if(diarias > 15)
            {
                vdiaria = (diariafixa + 10.00) * diarias;
               
            }
            else if (diarias == 15)
            {
                vdiaria = (diariafixa + 12.00) * diarias;
            }
            else
            {
                vdiaria = (diariafixa + 15.00) * diarias;
            }

            MessageBox.Show("O total a pagar pelo cliente" + nome + "é de R$" + vdiaria + ".");
        }

        private void txtdiarias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
