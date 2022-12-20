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

    public partial class Affine_cipher : Form
    {          static int c1;
        int a, c;
        static string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static char[] letter = alpha.ToCharArray();
         
        public Affine_cipher()
        {
            InitializeComponent();
        }

        private void Affine_cipher_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox3.Text);
            // textBox3.Text = "";
            string plantext = textBox2.Text;
            int x = 0;
            string ciphertext = "";
            plantext = plantext.ToUpper();

            for (int i = 0; i < plantext.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (plantext[i] == letter[j])
                    {
                        x = j;
                        ciphertext = letter[(a * x + b) % 26].ToString();
                        textBox3.Text += ciphertext;
                    }
                }
            }

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string plantext;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox3.Text);
            string ciphertext = textBox3.Text;
            int c = 0;
            ciphertext = ciphertext.ToUpper();

            a = int.Parse(textBox1.Text);
            for (int i = 1; i < 26; i++)
            {
                if (((a * i) % 26) == 1)
                { c1 = i; }

            }
            for (int i = 0; i < ciphertext.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (ciphertext[i] == letter[j])
                    {
                        c = j;
                        int v = (c1 * (c - b) % 26);
                        plantext = letter[v].ToString();
                        textBox1.Text += plantext;
                    }
                }
            }
        }


        
    }
}

