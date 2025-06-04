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
    public partial class exercicio3 : Form
    {
        public exercicio3()
        {
            InitializeComponent();
        }

        private void exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variaveis
            int v1 = 0;
            int v2 = 0;
            int res = 0;

            //texto pra inteiro
            v1 = Convert.ToInt32(valor1.Text);
            v2 = Convert.ToInt32(valor2.Text);

            //soma
            res = v1 + v2;

            //converte resultado em texto
            resultado.Text = res.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //variaveis
            int v1 = 0;
            int v2 = 0;
            int res = 0;

            //texto pra inteiro
            v1 = Convert.ToInt32(valor1.Text);
            v2 = Convert.ToInt32(valor2.Text);

            //subtração
            res = v1 - v2;

            //converte resultado em texto
            resultado.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //variaveis
            int v1 = 0;
            int v2 = 0;
            int res = 0;

            //texto pra inteiro
            v1 = Convert.ToInt32(valor1.Text);
            v2 = Convert.ToInt32(valor2.Text);

            //multiplicação
            res = v1 * v2;

            //converte resultado em texto
            resultado.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //variaveis
            int v1 = 0;
            int v2 = 0;
            int res = 0;

            //texto pra inteiro
            v1 = Convert.ToInt32(valor1.Text);
            v2 = Convert.ToInt32(valor2.Text);

            if (v2 == 0 || v1==0)
            {
                MessageBox.Show("Erro!! Não divisível por 0");
            }
            else
            {
               //divisao
               res = v1 / v2;
            }


            //converte resultado em texto
            resultado.Text = res.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            exercicio4 exercicio4 = new exercicio4();
            exercicio4.Show();
        }
    }
}
