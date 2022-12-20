using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace لخوارزميات
{
    public partial class casear_ciphertext : Form
    {  char[] alpha = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        public casear_ciphertext()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index;
            bool numeric = Int32.TryParse(textBox2.Text, out index);
            textBox2.Text = "";
            char[] input = textBox1.Text.ToArray();

            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (input[i] == ' ')
                {
                    textBox3.Text += " ";
                    continue;
                }
                for (int j = 0; j < 26; j++)
                    if (input[i] == alpha[j])
                        textBox3.Text += alpha[(j + index) % 26];

            }

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            int index;
            bool numeric = Int32.TryParse(textBox2.Text, out index);
            textBox3.Text = "";
            char[] input = textBox3.Text.ToArray();

            for (int i = 0; i < textBox2.TextLength; i++)
            {
                if (input[i] == ' ')
                {
                    textBox1.Text += " ";
                    continue;
                }
                for (int j = 0; j < 26; j++)
                    if (input[i] == alpha[j])

                        if (j - index < 0)
                        {
                            textBox1.Text += alpha[26 + (j - index)];

                        }
                        else
                        {
                            textBox1.Text += alpha[j - index];

                        }

            }
        }


        private void casear_ciphertext_Load(object sender, EventArgs e)
        {

        }

        
    }
}
