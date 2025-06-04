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
    public partial class Exercício_5 : Form
    {
        public Exercício_5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnremover_Click_1(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            produtos.Items.Add(txtNome.Text);
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (produtos.SelectedIndex != -1)
            {

                produtos.Items.RemoveAt(produtos.SelectedIndex);

            }
            else
            {
                MessageBox.Show("Item não selecionado");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exercicio6 exercicio6 = new exercicio6();
            exercicio6.Show();
        }
    }
    }

