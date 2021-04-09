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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtatraso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num;

            num = int.Parse(txtmes.Text);

            if(num == 1)
            {
                MessageBox.Show("Janeiro");
            }
            else if (num == 2)
            {
                MessageBox.Show("Fevereiro");
            }
            else if (num == 3)
            {
                MessageBox.Show("Março");
            }
            else if (num == 4)
            {
                MessageBox.Show("Abril");
            }
            else if (num == 5)
            {
                MessageBox.Show("Maio");
            }
            else if (num == 6)
            {
                MessageBox.Show("Junho");
            }
            else if (num == 7)
            {
                MessageBox.Show("Julho");
            }
            else if (num == 8)
            {
                MessageBox.Show("Agosto");
            }
            else if (num == 9)
            {
                MessageBox.Show("Setembro");
            }
            else if (num == 10)
            {
                MessageBox.Show("Outubro");
            }
            else if (num == 11)
            {
                MessageBox.Show("Novembro");
            }
            else if (num == 12)
            {
                MessageBox.Show("Dezembro");
            }
            else
            {
                MessageBox.Show("Error 404");
            }
        }
    }
}
