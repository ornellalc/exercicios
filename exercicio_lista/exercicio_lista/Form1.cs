namespace exercicio_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            label1.Text = "Ola, windows forms";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exericicio2 exericicio2 = new exericicio2();
            exericicio2.Show();
        }
    }
}
