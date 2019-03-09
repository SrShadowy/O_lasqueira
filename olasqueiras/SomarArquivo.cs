using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olasqueiras
{
    public partial class SomarArquivo : Form
    {
        public SomarArquivo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = richTextBox1.Lines.Length;
            string[] linhas = richTextBox1.Lines;
            int a = 0, b = 0, r = 0;
            b = Convert.ToInt32(linhas[0]);
            for (int i = 1; i < x; i++)
            {
                if (linhas[i] != "") { 
               a = Convert.ToInt32(linhas[i]);
               r =  b + a;
               b = r;
                }

            }

            label2.Text = r.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new OpenFileDialog();
            DialogResult reulst = x.ShowDialog();
            if (reulst == DialogResult.OK)
            {
                textBox1.Text = x.FileName;
                string[] readText = System.IO.File.ReadAllLines(x.FileName);
                for (int i = 0; i < readText.Length; i++)
                {
                    richTextBox1.AppendText(readText[i] + Environment.NewLine);

                }
                


            }
        }
    }
}
