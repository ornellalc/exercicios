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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "* jpg; * png|";
            ofd.Title = "Selecionar imagens";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exercicio9 exercicio9 = new exercicio9();
            exercicio9.ShowDialog();
        }
    }
}
