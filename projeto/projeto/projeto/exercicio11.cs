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
    public partial class exercicio11 : Form
    {
        public exercicio11()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formulário1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filho1 f1 = new filho1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filho2 f2 = new filho2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exercicio12 exercicio12 = new exercicio12();
            exercicio12.Show();
        }
    }
}
