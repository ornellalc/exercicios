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
    public partial class exercicio5 : Form
    {
        public exercicio5()
        {
            InitializeComponent();
        }

        private void exercicio5_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            produtos.Items.Add(txtNome.Text);
        }

        private void btnremover_Click_1(object sender, EventArgs e)
        {
            if (produtos.SelectedIndex != -1)
            {
                produtos.Items.RemoveAt(produtos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Item não selecionado!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exercicio6 exercicio6 = new exercicio6();
            exercicio6.Show();
        }
    }
}
