using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_lista
{
    public partial class exercicio7 : Form
    {
        public exercicio7()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 11)
            {
                errorProvider1.SetError(textBox1, "Erro, CPF invalido!");

                if (textBox1.TextLength != 11)
                {
                    errorProvider1.SetError(textBox1, "Erro, CPF invalido!!");
                }
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {
                exercicio8 exercicio8 = new exercicio8();
                exercicio8.Show();
            }
        }
    } 
