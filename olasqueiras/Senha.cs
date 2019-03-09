using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace olasqueiras
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] x = new bool[5];
            char[] pass = textBox1.Text.ToCharArray();
            if (textBox1.TextLength > 7)
            {

                if (textBox1.Text == textBox2.Text)
                {

                    foreach (char item in pass)
                    {
                        if (char.IsSymbol(item))
                        {
                            x[0] = true;
                        }

                        if (char.IsNumber(item))
                        {
                            x[1] = true;

                            //
                        }
                        if (char.IsLetter(item))
                        {

                            x[2] = true;
                            //		  
                        }


                    }

                    x[3] = Regex.IsMatch(textBox1.Text, @"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]");



                    int b = 0;

                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i])
                        {
                            b++;
                        }

                    }
                    if (b > 2)
                    {
                        label1.Text = "Ok";
                    }


                }
                else
                {
                    label1.Text = "Nonononononono";
                }
            }
            else
            {
                label1.Text = "Falta caracteres!";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }
    }
}
