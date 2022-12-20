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
    public partial class Form1 : Form
    {   Form play = new Form2();
        Form hill = new Form3();
        Form cas = new casear_ciphertext();
        Form Aff = new Affine_cipher();
        Form RSA = new RSA_Cepher();
        Form Diffe = new Diffe_Helman();
        public Form1()
        {
            InitializeComponent();
        }

      
      

        private void button1_Click_1(object sender, EventArgs e)
        {
                   if (hill== null)
            {
                hill = new Form3();

                hill.Show();
            }
            else
          hill.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (play== null)
            {
                play = new Form2();

                play.Show();
            }
            else
          play.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cas == null)
            {
                cas = new casear_ciphertext();

                cas.Show();
            }
            else
                cas.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        { if (Aff == null)
            {
                Aff = new Affine_cipher();

                Aff.Show();
            }
            else
                Aff.Show();
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (RSA == null)
            {
                RSA = new RSA_Cepher();

                RSA.Show();
            }
            else
                RSA.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        { 
            if (Diffe == null)
            {
                Diffe = new Diffe_Helman();

                Diffe.Show();
            }
            else
                Diffe.Show();

        }
   
        }
    }

