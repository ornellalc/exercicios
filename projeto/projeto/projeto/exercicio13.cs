using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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

        public class produtos
        {
            public string nome{ get; set; }
            public string categoria { get; set; }
            public string preco { get; set; }
            
            public override string  ToString()
            {
                return $" {nome} {categoria} - {preco}";
            }

        }
        private List<produtos> Listaprodutos;

        private List<string>categoriaSelecionadas = new List<string>();


        public exercicio13()
        {
            InitializeComponent();

            Listaprodutos = new List<produtos>()
            {
                 new produtos {nome= "celular", categoria="eletrônico", preco="2500"},
                 new produtos {nome= "camiseta", categoria="roupa", preco="80"},
                 new produtos {nome= "livro c#", categoria="livro", preco="45"},
                 new produtos {nome= "cookie", categoria="alimento", preco="8"},
            };
        }

        private void exercicio13_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("livro");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("eletrônico");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("roupa");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            categoriaSelecionadas.Add("alimento");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (checkBox1.Checked == false)
            {
                categoriaSelecionadas.Remove("eletrônico");

            }
            if (checkBox2.Checked == false)
            {
                categoriaSelecionadas.Remove("roupa");
            }
            if (checkBox3.Checked == false)
            {
                categoriaSelecionadas.Remove("alimento");
            }
            if (checkBox4.Checked == false)
            {
                categoriaSelecionadas.Remove("livro"); 
            }



            if (categoriaSelecionadas.Count == 0)
            {
                listBox1.Items.Add("Nenhuma categoria selecionada!");
            }
            else 
            {
                var produtosfiltrados = Listaprodutos.Where(
                    p => categoriaSelecionadas.Contains(p.categoria)).ToList();
                if (produtosfiltrados.Any())
                {
                    foreach(var produtos in produtosfiltrados)
                    {
                        listBox1.Items.Add(produtos);
                    }
                }
                else
                {
                    listBox1.Items.Add("nenhum produto encontrado");
                }
            }
        }
    }
}
