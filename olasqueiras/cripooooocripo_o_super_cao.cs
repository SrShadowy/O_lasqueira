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
    public partial class cripooooocripo_o_super_cao : Form
    {
        public cripooooocripo_o_super_cao()
        {
            InitializeComponent();
        }

        public string ceziar (string x)
        {
            int[] chave = { 0, 2, 3, 1 };

            char[] ceza = x.ToCharArray();
            int c = 0;
            for (int i = 0; i < ceza.Length; i++)
            {
                if (c < 3)
                {
                    ceza[i] = Convert.ToChar((int)(ceza[i] + chave[c]));

                    c++;
                }
                else
                {
                    ceza[i] = Convert.ToChar((int)(ceza[i] + chave[c]));
                    c = 0;
                }

            }

            x = new string(ceza);

            return x;
        }

        public string desceziar(string x)
        {
            int[] chave = { 0, 2, 3, 1 };

            char[] ceza = x.ToCharArray();
            int c = 0;
            for (int i = 0; i < ceza.Length; i++)
            {
                if (c < 3)
                {
                    ceza[i] = Convert.ToChar((int)(ceza[i] - chave[c]));

                    c++;
                }
                else
                {
                    ceza[i] = Convert.ToChar((int)(ceza[i] - chave[c]));
                    c = 0;
                }

            }

            x = new string(ceza);

            return x;
        }

        private void cripooooocripo_o_super_cao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ceziar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = desceziar(textBox1.Text);
        }
    }
}
