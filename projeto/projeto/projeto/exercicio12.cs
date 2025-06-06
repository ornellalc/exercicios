using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace projeto
{
    public partial class exercicio12 : Form
    {
        public exercicio12()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            exercicio13 exercicio13 = new exercicio13();
            exercicio13.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.BackColor = Color.DarkGray;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                label1.Text = "Modo escuro ativado! ";
                toolStripStatusLabel1.Text = "ativado";
            }
            else
            {
                this.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
                label1.Text = "Modo escuro desativado! ";
                toolStripStatusLabel1.Text = "desativado";
            }
            if (checkBox2.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
            if (radioButton1.Checked)
            {
                label1.Text += "Idioma: português ";
                toolStripStatusLabel2.Text = "português";
            }
            if (radioButton2.Checked)
            {
                label1.Text += "Idioma: inglês ";
                toolStripStatusLabel2.Text = "inglês";

            }
            if (radioButton3.Checked)
            {
                label1.Text += "Idioma: espanhol ";
                toolStripStatusLabel2.Text = "espanhol";

            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                label1.Text += "Idioma: ";
            }
        }

        
    }
}

