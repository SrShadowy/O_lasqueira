using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
    }
}
