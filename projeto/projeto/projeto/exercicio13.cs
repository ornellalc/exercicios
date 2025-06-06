using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace projeto
{
    public partial class exercicio13 : Form
    {
        List<string> categoriaSelecionadas = new List<string>();

        public class produtos
        {
            public string nome;
            public string categoria;
            public string preco;
        }
        private List<produtos> Listaprodutos;


        public exercicio13()
        {
            InitializeComponent();

            Listaprodutos = new List<produtos>()
            {
                 new produtos {nome= "celular", categoria="eletrônico", preco="2500"},
                 new produtos {nome= "camiseta", categoria="roupa", preco="80"},
                 new produtos {nome= "percy jackson", categoria="livro", preco="45"},
                 new produtos {nome= "cookie", categoria="alimento", preco="8"},
            };
           

        }

        private void exercicio13_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Livros");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Eletrônicos");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Roupas");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("Alimentos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoriaSelecionadas.Count == 0)
            {
                foreach (var produto in Listaprodutos)
                {
                    listBox1.Items.Add(produto);
                }
            }

            
        }
    }
}
