﻿using System;
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
    public partial class exercicio6 : Form
    {
        public exercicio6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            this.BackColor = Color.Yellow;

            this.BackColor = Color.ForestGreen;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;

            this.BackColor = Color.CadetBlue;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exercicio7 exercicio7 = new exercicio7();
            exercicio7.Show();
        }
    }
}
