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
    public partial class exericicio2 : Form
    {
        public exericicio2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exercicio3 exercicio3 = new exercicio3();
            exercicio3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola," + textBox1.Text);
        }
    }
}
