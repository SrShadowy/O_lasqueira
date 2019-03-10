using System;
using System.Windows.Forms;

namespace olasqueiras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form senhas = new Senha();
            senhas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form soma = new SomarArquivo();
            soma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form xess = new chess();
            xess.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ceza = new cripooooocripo_o_super_cao();
            ceza.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
