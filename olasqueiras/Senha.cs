using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace olasqueiras
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //Evitar que tenha espaço no textbox
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void bnt_verificar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Where(x => char.IsSymbol(x)).Count() > 0 || Regex.IsMatch(textBox1.Text, @"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]") && textBox1.Text.Where(x => char.IsLetter(x)).Count() > 0 && textBox1.Text.Where(x => char.IsDigit(x)).Count() > 0 && textBox1.Text.Length > 5 && textBox1.Text == textBox2.Text)
                label1.Text = "Senha Valida";
            else
                label1.Text = "Senha invalida";
        }
    }
}
