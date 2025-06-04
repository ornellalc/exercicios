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
    public partial class exercicio9 : Form
    {
        public exercicio9()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void exercicio9_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exercicio10 exercicio10 = new exercicio10();
            exercicio10.ShowDialog();
        }
    }
}
