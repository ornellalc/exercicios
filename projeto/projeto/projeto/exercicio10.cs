using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class exercicio10 : Form
    {
        public exercicio10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exercicio11 exercicio11 = new exercicio11();
            exercicio11.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text += "";

            if (checkBox1.Checked)
            {
                label2.Text += checkBox1.Text;
            }
            else
            {
                label2.Text += "";
            }


            if (checkBox2.Checked)
            {
                label2.Text += checkBox2.Text;
            }
            else
            {
                label2.Text += "";
            }


            if (checkBox3.Checked)
            {
                label2.Text += checkBox3.Text;
            }
            else
            {
                label2.Text += "";
            }


            if (checkBox4.Checked)
            {
                label2.Text += checkBox4.Text;
            }

            else
            {
                label2.Text += "";
            }

        }
    }
}
