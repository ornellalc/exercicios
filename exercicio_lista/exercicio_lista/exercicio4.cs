using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_lista
{
    public partial class exercicio4 : Form
    {
        int contador = 0;
        public exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            contador = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Exercício_5 exercicio5 = new Exercício_5();


            exercicio5.Show();
        }
    }
}
