using System;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            if (textBox1.Text != string.Empty)
            {
                char[] inputString = textBox1.Text.ToCharArray();
                string resString = "";
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    resString += Convert.ToString(inputString[i]);
                }

                if (textBox1.Text.Equals(resString))
                {
                    textBox2.Text = "Палиндром";
                }
                else
                {
                    textBox2.Text = "Не палиндром";
                }
            }
        }
    }
}
