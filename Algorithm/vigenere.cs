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
    public partial class vigenere : Form
    {         string m= null;//message 
           string k= null;//key
        public vigenere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             textBox3.Clear();

         m = textBox1.Text; 
            k= textBox2.Text;

         int r = 0; 
            string s =null;

         for (int i = 0; i <m.Length; i++)
         {
          if (r == k.Length - 1)

          r = 0;//if end the key

        else if (r<k. Length && i> 0)
              r++;
             else if (r< k.Length && i == 0)

                r = 0;

             if (r < k.Length)
             {        s += Cls_vignear.Encryptoin(m.Substring(i,

                    1). ToUpper(),Cls_vignear.getkey (k.Substring(r,1).ToUpper()));

}

} 
            textBox3.Text=s;

}
        

        private void button2_Click(object sender, EventArgs e)
        {      
            
textBox1.Clear();

m = textBox3.Text;
            k= textBox2.Text;

int r = 0;
            string s = null;
      for (int i = 0; i < m.Length; i++)
      {    if (r == k.Length -1) 
    r = 0;//if end the key
      else if (r<k.Length && i > 0)
           r++;

         else if (r<k.Length && i== 0)
             r = 0;
          if(r<k.Length)
          {
            s += Cls_vignear.Dencryptoin(m.Substring(1, 1). ToUpper(), 
                Cls_vignear.getkey (k. Substring(r, 1).ToUpper())); 
          }
      }

textBox3.Text = s;
      }


        }
    }
