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
    public partial class chess : Form
    {
      
        public chess()
        {
            InitializeComponent();
        }

        private void chess_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("     01 02 03 04 05 06 07 08" + Environment.NewLine);
            richTextBox1.AppendText("     -----------------------" + Environment.NewLine);
            richTextBox1.AppendText(" A | 01 02 03 04 05 06 07 08" + Environment.NewLine);
            richTextBox1.AppendText(" B | 09 10 11 12 13 14 15 16" + Environment.NewLine);
            richTextBox1.AppendText(" C | 17 18 19 20 21 22 23 24" + Environment.NewLine);
            richTextBox1.AppendText(" D | 25 26 27 28 29 30 31 32" + Environment.NewLine);
            richTextBox1.AppendText(" E | 33 34 35 36 37 38 39 40" + Environment.NewLine);
            richTextBox1.AppendText(" F | 41 42 43 44 45 46 47 48" + Environment.NewLine);
            richTextBox1.AppendText(" G | 49 50 51 52 53 54 55 56" + Environment.NewLine);
            richTextBox1.AppendText(" H | 57 58 59 60 61 62 63 64" + Environment.NewLine);


        }
        Char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8' };
        Char[] ah = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        Char[] ha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        int[,] array2D = new int[,] { { 1, 2,3,4,5,6,7,8 }, { 9,10,11,12,13,14,15,16 }, {17,18,19,20,21,22,23,24 }, { 25, 26, 27,28,29,30,31,32 }, {33,34,35,36,37,38,39,40 },{41,42,43,44,45,46,47,48 },{49,50,51,52,53,54,55,56 },{57,58,59,60,61,62,63,64 } };

        private void button1_Click(object sender, EventArgs e)
        {
            int letra = 0;
            for (int x = 0; x < ah.Length; x++)
            {
                if (textBox1.Text == ah[x].ToString() || textBox1.Text == ha[x].ToString())
                {
                    letra = x;
                    if ( Convert.ToInt32(textBox2.Text) <= 8  )
                    {
                        label1.Text = array2D[letra, Convert.ToInt32(textBox2.Text) - 1].ToString();
                    }
                    else { label1.Text = textBox2.Text + " o valor eh muito alto " + Environment.NewLine + "ou muito baixo mizera eh de 1 a 8"; }
                }
                else if(textBox2.Text == ah[x].ToString() || textBox2.Text == ha[x].ToString())
                {
                    letra = x;
                    if (Convert.ToInt32(textBox1.Text) <= 8 ) { 
                    label1.Text = array2D[letra, Convert.ToInt32(textBox1.Text) - 1].ToString();
                    }
                    else { label1.Text = textBox1.Text + " o valor eh muito alto eh de 1 a 8"; }
                }
               
                letra = 0;
            }
            
        }
    }
}
