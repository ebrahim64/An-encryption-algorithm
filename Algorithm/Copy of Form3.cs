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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string alphabate = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //string Kmatrix = null;
        static double[][] Kmatrix = null;
        //static char[,] Kmatrix = null;
        int charvalue(string x)
        {

            return alphabate.IndexOf(x.ToUpper());
        }
       // new double[][] { new double[] { 5, 7, 10 }, new double[] { 13, 17, 7 }, new double[] { 0, 5, 4 }

        /*Matrix keyMatrix;
        Matrix InversekeyMatrix;
        Matrix PlanMatrix;
        Matrix CipherMatrix;
        Matrix Daciphermatrix;*/
        // /////////////////  KEYMAT نقوم بأنشا دالة المفتاح اسمها ////////////////////////////
         void Keymat()
          {
              if (radioButton1.Checked)
              {
                  if (textBoxc1.Text != "" && textBoxC2.Text != "" && textBoxC5.Text != "" && textBoxC6.Text != "")
                  { 
              Kmatrix = new double[][] {new double[] {Convert.ToInt32(charvalue(textBoxc1.Text)),Convert.ToInt32(charvalue(textBoxC2.Text))}, new double[] {Convert.ToInt32(charvalue(textBoxC5.Text)),Convert.ToInt32(charvalue(textBoxC6.Text))}};
                  }
              else
                  {      MessageBox.Show("احد حقول المفتاح فارغ");
                  }
                  return;
              }

              /*   if (radioButton2.Checked)
              {
                  if (textBoxc1.Text != "" && textBoxC2.Text != "" && textBoxC3.Text != "" && textBoxC5.Text != "" && textBoxC6.Text != "" && textBoxC7.Text != "" && textBoxC9.Text != "" && textBoxC10.Text != "" && textBoxC11.Text != "")
                  { 
                Kmatrix = new double[][] {new double[] {Convert.ToInt32(charvalue(textBoxc1.Text)),Convert.ToInt32(charvalue(textBoxC2)),Convert.ToInt32(charvalue(textBoxC3))},new double[] {Convert.ToInt32(charvalue(textBoxC5)),Convert.ToInt32(charvalue(textBoxC6)),Convert.ToInt32(charvalue(textBoxC7))},new double[] {Convert.ToInt32(charvalue(textBoxC9.Text)),Convert.ToInt32(charvalue(textBoxC10)),Convert.ToInt32(charvalue(textBoxC11))}};
                  }
              else
                  {      MessageBox.Show("احد حقول المفتاح فارغ");
                  }
                  return;
              }
                if (radioButton3.Checked)
              {
                  if (textBoxc1.Text != "" && textBoxC2.Text != "" && textBoxC3.Text != "" && textBoxC4.Text != "" && textBoxC5.Text != "" && textBoxC6.Text != "" && textBoxC7.Text != "" && textBoxC8.Text != "" && textBoxC9.Text != "" && textBoxC10.Text != "" && textBoxC11.Text != "" && textBoxC12.Text != "" && textBoxC13.Text != "" && textBoxC14.Text != "" && textBoxC15.Text != "" && textBoxC16.Text != "")
                  { 
                Kmatrix = new double[][] {new double[] {Convert.ToInt32(charvalue(textBoxc1.Text)),Convert.ToInt32(charvalue(textBoxC2)),Convert.ToInt32(charvalue(textBoxC3)),Convert.ToInt32(charvalue(textBoxC4))},new double[] {Convert.ToInt32(charvalue(textBoxC5)),Convert.ToInt32(charvalue(textBoxC6)),Convert.ToInt32(charvalue(textBoxC7)),Convert.ToInt32(charvalue(textBoxC8))},
                    new double[] {Convert.ToInt32(charvalue(textBoxC9.Text)),Convert.ToInt32(charvalue(textBoxC10)),Convert.ToInt32(charvalue(textBoxC11)),Convert.ToInt32(charvalue(textBoxC12))},new double[] {Convert.ToInt32(charvalue(textBoxC13.Text)),Convert.ToInt32(charvalue(textBoxC14)),Convert.ToInt32(charvalue(textBoxC15)),Convert.ToInt32(charvalue(textBoxC16))}};
                  }

              else
                  {      MessageBox.Show("احد حقول المفتاح فارغ");
                  }
                  return;
              }
          }*/


              // /////////////////  KeyInv نقوم بأنشا دالة مقلوب  المفتاح اسمها ////////////////////////////

        /* 
       
      

         Matrix KeyInv(Matrix key)
         {
             fraction det = key.Determinent();
             if (det == 0)
                 return null;
             int detMod = Mod(Convert.ToInt32(det), alphabets.length);
             if (detMod == 0)
                 return null;
             int x = 0;
             if (Matrix.GCD(alphabets.length, detMod) != 1)
                 return null;
             for (int i = 0; i < alphabets.length; i++)
             { 
                 if(Mod(detMod * i ,alphabets.length) == 1)
                 {
                 x = i;
                 break;
             }
         }
         Matrix Agj = KeyEventArgs.Adjoint();
         Matrix Adjx = Matrix.multiply(Adj,x);
         Matrix Adjxmod;
         Adjxmod=Matrix.Mod(Adjx,alphabets.length);
         Matrix Inveersekey=Adjxmod;
         return Inversekey;
          */
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxc1.Enabled = textBoxC2.Enabled = true; textBoxC3.Enabled = textBoxC4.Enabled = false;
            textBoxC5.Enabled = textBoxC6.Enabled = true; textBoxC7.Enabled = textBoxC8.Enabled = false;
            textBoxC9.Enabled = textBoxC10.Enabled = textBoxC11.Enabled = textBoxC12.Enabled = textBoxC13.Enabled = false;
            textBoxC14.Enabled = textBoxC15.Enabled = textBoxC16.Enabled = false;
            textBoxc1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBoxc1.Clear();
            textBoxC2.Clear();
            textBoxC3.Clear();
            textBoxC4.Clear();
            textBoxC5.Clear();
            textBoxC6.Clear();
            textBoxC7.Clear();
            textBoxC8.Clear();
            textBoxC9.Clear();
            textBoxC10.Clear();
            textBoxC11.Clear();
            textBoxC12.Clear();
            textBoxC13.Clear();
            textBoxC14.Clear();
            textBoxC15.Clear();
            textBoxC16.Clear();
            textBoxc1.Focus();


        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBoxc1.Enabled = textBoxC2.Enabled = true; textBoxC3.Enabled = textBoxC4.Enabled = false;
            textBoxC5.Enabled = textBoxC6.Enabled = true; textBoxC7.Enabled = textBoxC8.Enabled = false;
            textBoxC9.Enabled = textBoxC10.Enabled = textBoxC11.Enabled = textBoxC12.Enabled = textBoxC13.Enabled = false;
            textBoxC14.Enabled = textBoxC15.Enabled = textBoxC16.Enabled = false;
            textBoxc1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBoxc1.Enabled = textBoxC2.Enabled = textBoxC3.Enabled = true; textBoxC4.Enabled = false;
            textBoxC5.Enabled = textBoxC6.Enabled = textBoxC7.Enabled = true; textBoxC8.Enabled = false;
            textBoxC9.Enabled = textBoxC10.Enabled = textBoxC11.Enabled = true; textBoxC12.Enabled = false;
            textBoxC14.Enabled = textBoxC15.Enabled = textBoxC16.Enabled = textBoxC13.Enabled = false;
            textBoxc1.Focus();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBoxc1.Enabled = textBoxC2.Enabled = textBoxC3.Enabled = true; textBoxC4.Enabled = true;
            textBoxC5.Enabled = textBoxC6.Enabled = textBoxC7.Enabled = true; textBoxC8.Enabled = true;
            textBoxC9.Enabled = textBoxC10.Enabled = textBoxC11.Enabled = true; textBoxC12.Enabled = true;
            textBoxC14.Enabled = textBoxC15.Enabled = textBoxC16.Enabled = textBoxC13.Enabled = true;
            textBoxc1.Focus();
        }

        private void textBoxC2_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC2.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC2.Clear();
                textBoxC2.Focus();
            }
            else
            {
                // textBoxC2.Text = Convert.ToString(cv);
                if (textBoxC3.Enabled == false)
                {
                    textBoxC5.Focus();
                }
                textBoxC3.Focus();
            }
        }

        private void textBoxC3_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC3.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC3.Clear();
                textBoxC3.Focus();
            }
            else
            {
                // textBoxC3.Text = Convert.ToString(cv);
                if (textBoxC4.Enabled == false)
                {
                    textBoxC5.Focus();
                }
                textBoxC4.Focus();
            }

        }

        private void textBoxC4_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC4.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC4.Clear();
                textBoxC4.Focus();
            }
            else
            {
                //  textBoxC4.Text = Convert.ToString(cv);
                textBoxC5.Focus();
            }
        }

        private void textBoxC5_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC5.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC5.Clear();
                textBoxC5.Focus();
            }
            else
            {
                // textBoxC5.Text = Convert.ToString(cv);
                textBoxC6.Focus();
            }
        }

        private void textBoxC6_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC6.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC6.Clear();
                textBoxC6.Focus();
            }
            else
            {
                // textBoxC6.Text = Convert.ToString(cv);
                textBoxC7.Focus();
            }
        }

        private void textBoxC7_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC7.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC7.Clear();
                textBoxC7.Focus();
            }
            else
            {

                if (textBoxC8.Enabled == false)
                {
                    textBoxC9.Focus();
                }
                textBoxC8.Focus();
            }
        }

        private void textBoxC8_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC8.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC8.Clear();
                textBoxC8.Focus();
            }
            else
            {
                // textBoxC8.Text = Convert.ToString(cv);
                textBoxC9.Focus();
            }
        }

        private void textBoxC9_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC9.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC9.Clear();
                textBoxC9.Focus();
            }
            else
            {
                // textBoxC9.Text = Convert.ToString(cv);
                textBoxC10.Focus();
            }
        }

        private void textBoxC10_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC10.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC10.Clear();
                textBoxC10.Focus();
            }
            else
            {
                //  textBoxC10.Text = Convert.ToString(cv);
                textBoxC11.Focus();
            }
        }

        private void textBoxC11_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC11.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC11.Clear();
                textBoxC11.Focus();
            }
            else
            {
                //  textBoxC11.Text = Convert.ToString(cv);

                textBoxC12.Focus();
            }
        }

        private void textBoxC12_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC12.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC12.Clear();
                textBoxC12.Focus();
            }
            else
            {
                //  textBoxC12.Text = Convert.ToString(cv);
                textBoxC13.Focus();
            }
        }

        private void textBoxC13_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC13.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC13.Clear();
                textBoxC13.Focus();
            }
            else
            {
                // textBoxC13.Text = Convert.ToString(cv);
                textBoxC14.Focus();
            }
        }

        private void textBoxC14_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC14.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC14.Clear();
                textBoxC14.Focus();
            }
            else
            {
                // textBoxC14.Text = Convert.ToString(cv);
                textBoxC15.Focus();
            }
        }

        private void textBoxC15_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC15.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC15.Clear();
                textBoxC15.Focus();
            }
            else
            {
                // textBoxC15.Text = Convert.ToString(cv);
                textBoxC16.Focus();
            }
        }

        private void textBoxC16_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxC16.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxC16.Clear();
                textBoxC16.Focus();
            }
            else
            {
                // textBoxC16.Text = Convert.ToString(cv);
                textBoxC16.Focus();
            }
        }

        private void textBoxcipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxplan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxc1_TextChanged(object sender, EventArgs e)
        {
            int cv = charvalue(textBoxc1.Text);
            if (cv == -1)
            {
                MessageBox.Show("الرمز الذي ادخل غير صحيح", "خطاء في الادخال");
                textBoxc1.Clear();
                textBoxc1.Focus();
            }
            else
            {
                //textBoxc1.Text = Convert.ToString(cv);
                textBoxC2.Focus();
            }
        }

        private void button_Encription_Click(object sender, EventArgs e)
        {
            /*
              if (textBoxplantext.Text !=string.Empty)
              textBoxciphertext.Clear();
          string plantext = textBoxplantext.Text.ToUpper();
          keyMat();
           
          if (KeyInv(keyMatrix) == null)
              MessageBox.Show( "اعيد كتابته بطريقة صحيح","المتاح غير صالح");

          else {
              ///تفعيل زر المصفوفة 2*2
              if (radioButton1.Checked)
              {
                  bool alone = true;

                  for (int i = 0; i < plantext.Length; i += 2)
                  {
                      string B1 = "";
                      int f = 0;
                      alone = true;

                      if (alphabets.Contains(plantext[i]))
                      {
                          for (int j = i + 1; j < plantext.Length; j++)
                          {
                              if (alphabets.Contains(plantext[j]))
                              {
                                  PlanMatrix = new Matrix(new double[,] { { alphabets.IndexOf(plantext[i]) }, { alphabets.IndexOf(plantext[j]) } });
                                  alone = false;
                                  break;
                              }
                              else
                              {
                                  B1 += plantext[i];
                                  f++;

                              }
                          }
                          if (alone == true)
                          {
                              PlanMatrix = new Matrix(new double[,] { { alphabets.IndexOf(plantext[i]) }, { 0 } });
                          }
                          i += f;
                          CipherMatrix = CipherMatrix.Multiply(keyMatrix, PlanMatrix);
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0].numerator), alphabets.length)];
                          textBoxciphertext.Text += B1;
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0].numerator), alphabets.length)];
                      }
                      else
                      {
                          textBoxciphertext.Text += plantext[i].ToString();
                          i--;
                      }
                  }
              }
  }
           ///تفعيل زر المصفوفة 3*3
          if(radioButton2.Checked)
          {
              for(int i=0 ;i<plantext.length)
              {
                  string B1="";
                  string B2="";
                  int f1=0;
                  int f2=0;
                  int outerj =0;
                  bool alone1 =true;
                  bool alone2 =true;
                  if(alphabate.Contains(plantext[i]))
                  {
                      for(int j=i+1 ;j<plantext.length;j++)
                      {
                          if(alphabate.Contains(plantext[j]))
                          {
                              outerj=j;
                              alone1=false;
                              for(int k=j+1; k<plantext.length; k++)
                              {
                                  if(alphabate.Contains(plantext[k]))
                                  {
                                      planmatrix = new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{ alphabate.IndexOf(plantext[j]) },{ alphabate.IndexOf(plantext[k])}});
                                      alone2=false;
                                      goto Top;
                                  }
                                  else
                                  {
                                      B2 += plantext[k];
                                      f2++;
                                  }
                              }
                              goto Top;
                          }
                          else{
                              B1 +=plantext[j];
                              f1++;
                          }
                      }
                  Top:
                      if(alone1 ==true)
                      {
                          planMatrix =new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{0},{0}});
                      }
                      else
                            if(alone2 ==true)
                      {
                          planMatrix =new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{alphabate.IndexOf(plantext[outerj])},{0}});
                      }
                      i +=f1 + f2;
                           CipherMatrix = CipherMatrix.Multiply(keyMatrix, PlanMatrix);
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0].numerator), alphabets.length)];
                          textBoxciphertext.Text += B1;
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0].numerator), alphabets.length)];
                          textBoxciphertext.Text += B2;
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0].numerator), alphabets.length)];
                  }
                  else
                  {
                      textBoxciphertext.Text +=plantext[i].ToString();
                      i -=2;
                  }
              }
          }
         ///////////// ///     تفعيل زر المصفوفة 4*4   /////////////////////////////////
          if(radioButton3.Checked)
          {
              for(int i=0 ;i<plantext.length ;i +=4)
              {
                  string B1="";
                  string B2="";
                  string B3="";
                  int f1=0;
                  int f2=0;
                  int f3=0;
                  int outerj =0;
                  int outerk =0;
                  bool alone1 =true;
                  bool alone2 =true;
                  bool alone3 =true;
                  if(alphabate.Contains(plantext[i]))
                  {
                      for(int j=i+1 ;j<plantext.length;j++)
                      {
                          if(alphabate.Contains(plantext[j]))
                          {
                              outerj=j;
                              alone1=false;
                              for(int k=j+1; k<plantext.length; k++)
                              {
                                  if(alphabate.Contains(plantext[k]))
                                  {
                                      outerk =k;
                                      alone2=false;
                                      for(int h =k+1 ;h<plantext.length;h++)
                                      {
                                          if(alphabate.Contains(plantext[h]))
                                          { 
                                                 planmatrix = new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{ alphabate.IndexOf(plantext[j]) },{ alphabate.IndexOf(plantext[k])}});
                                                 alone3=false;
                                                  goto Top;
                                          }
                                           else{
                                              B3 +=plantext[h];
                                              f3++;
                                          }
                                            
                                          }
                                           goto Top;                            
                                          }
                                  else
                                  {
                                      B2 += plantext[k];
                                      f2++;
                                  }
                              }
                              goto Top;
                          }
                          else{
                              B1 +=plantext[j];
                              f1++;
                          }
                      }
                  Top:
                      if(alone1 ==true)
                      {
                          planMatrix =new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{0},{0},{0}});
                      }
                      else
                            if(alone2 ==true)
                      {
                          planMatrix =new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{alphabate.IndexOf(plantext[outerj])},{alphabate.IndexOf(plantext[outerk])},{0}});
                      }
                       else
                            if(alone3 ==true)
                      {
                          planMatrix =new Matrix(new double[,] {{alphabate.IndexOf(plantext[i])},{alphabate.IndexOf(plantext[outerj])},{alphabate.IndexOf(plantext[outerk])},{0}});
                        
                      i +=f1 + f2 + f3;
                          CipherMatrix = CipherMatrix.Multiply(keyMatrix, PlanMatrix);
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0].numerator), alphabets.length)];
                          textBoxciphertext.Text += B1;
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0].numerator), alphabets.length)];
                          textBoxciphertext.Text += B2;
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0].numerator), alphabets.length)];
                          textBoxciphertext.Text += B3;
                          textBoxciphertext.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[3, 0].numerator), alphabets.length)];
                  }
                  else
                  {
                      textBoxciphertext.Text +=plantext[i].ToString();
                      i -=3;
                            }
                                     }
              }
          }
             * */
        }

        private void button_Decription_Click(object sender, EventArgs e)
        {
              /* keyMat();          
           if (KeyInv(keyMatrix) == null)
               MessageBox.Show( "اعيد كتابته بطريقة صحيح","المتاح غير صالح");

             else{

               InversKeyMatrix =KeyInv(keyMatrix);         
               if (textBoxciphertext.Text ="")
               MessageBox.Show("بعض الحقول المطلوبة فارغ","خطاء");           
               else {

                   textBoxplantext.Clear();
           string Ciphertext = textBoxciphertext.Text.ToUpper();
                   
               ///       تفعيل زر المصفوفة 2*2    //////////////////////////////////////
               if (radioButton1.Checked)
               {
                   bool alone = true;

                   for (int i = 0; i < Ciphertext.Length; i += 2)
                   {
                       string B1 = "";
                       int f = 0;
                       alone = true;

                       if (alphabets.Contains(Ciphertext[i]))
                       {
                           for (int j = i + 1; j < Ciphertext.Length; j++)
                           {
                               if (alphabets.Contains(Ciphertext[j]))
                               {
                                   CipherMatrix = new Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) } });
                                   alone = false;
                                   break;
                               }
                               else
                               {
                                   B1 += Ciphertext[i];
                                   f++;

                               }
                           }
                           if (alone == true)
                           {
                               CipherMatrix = new Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 } });
                           }
                           i += f;
                           PlanMatrix = planMatrix.Multiply(keyMatrix, CipherMatrix);
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[0, 0].numerator), alphabets.length)];
                           textBoxplantext.Text += B1;
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[1, 0].numerator), alphabets.length)];
                       }
                       else
                       {
                           textBoxplantext.Text += Ciphertext[i].ToString();
                           i--;
                       }
                   }
               }
   }
            ///تفعيل زر المصفوفة 3*3
           if(radioButton2.Checked)
           {
               for(int i=0 ;i<Ciphertext.length)
               {
                   string B1="";
                   string B2="";
                   int f1=0;
                   int f2=0;
                   int outerj =0;
                   bool alone1 =true;
                   bool alone2 =true;
                   if(alphabate.Contains(Ciphertext[i]))
                   {
                       for(int j=i+1 ;j<Ciphertext.length;j++)
                       {
                           if(alphabate.Contains(Ciphertext[j]))
                           {
                               outerj=j;
                               alone1=false;
                               for(int k=j+1; k<Ciphertext.length; k++)
                               {
                                   if(alphabate.Contains(Ciphertext[k]))
                                   {
                                       Ciphermatrix = new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{ alphabate.IndexOf(Ciphertext[j]) },{ alphabate.IndexOf(Ciphertext[k])}});
                                       alone2=false;
                                       goto Top;
                                   }
                                   else
                                   {
                                       B2 += Ciphertext[k];
                                       f2++;
                                   }
                               }
                               goto Top;
                           }
                           else{
                               B1 +=Ciphertext[j];
                               f1++;
                           }
                       }
                   Top:
                       if(alone1 ==true)
                       {
                           CipherMatrix =new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{0},{0}});
                       }
                       else
                             if(alone2 ==true)
                       {
                           CipherMatrix =new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{alphabate.IndexOf(Ciphertext[outerj])},{0}});
                       }
                       i +=f1 + f2;
                           PlanMatrix = PlanMatrix.Multiply(keyMatrix, CipherMatrix);
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[0, 0].numerator), alphabets.length)];
                           textBoxplantext.Text += B1;
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[1, 0].numerator), alphabets.length)];
                           textBoxplantext.Text += B2;
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[2, 0].numerator), alphabets.length)];
                   }
                   else
                   {
                       textBoxplantext.Text +=Ciphertext[i].ToString();
                       i -=2;
                   }
               }
           }
          ///////////// ///     تفعيل زر المصفوفة 4*4   /////////////////////////////////
           if(radioButton3.Checked)
           {
               for(int i=0 ;i<Ciphertext.length ;i +=4)
               {
                   string B1="";
                   string B2="";
                   string B3="";
                   int f1=0;
                   int f2=0;
                   int f3=0;
                   int outerj =0;
                   int outerk =0;
                   bool alone1 =true;
                   bool alone2 =true;
                   bool alone3 =true;
                   if(alphabate.Contains(Ciphertext[i]))
                   {
                       for(int j=i+1 ;j<Ciphertext.length;j++)
                       {
                           if(alphabate.Contains(Ciphertext[j]))
                           {
                               outerj=j;
                               alone1=false;
                               for(int k=j+1; k<Ciphertext.length; k++)
                               {
                                   if(alphabate.Contains(Ciphertext[k]))
                                   {
                                       outerk =k;
                                       alone2=false;
                                       for(int h =k+1 ;h<Ciphertext.length;h++)
                                       {
                                           if(alphabate.Contains(Ciphertext[h]))
                                           { 
                                                  CipherMatrix = new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{ alphabate.IndexOf(Ciphertext[j]) },{ alphabate.IndexOf(Ciphertext[k])}});
                                                  alone3=false;
                                                   goto Top;
                                           }
                                            else{
                                               B3 +=Ciphertext[h];
                                               f3++;
                                           }
                                            
                                           }
                                            goto Top;                            
                                           }
                                   else
                                   {
                                       B2 += Ciphertext[k];
                                       f2++;
                                   }
                               }
                               goto Top;
                           }
                           else{
                               B1 +=Ciphertext[j];
                               f1++;
                           }
                       }
                   Top:
                       if(alone1 ==true)
                       {
                           CipherMatrix =new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{0},{0},{0}});
                       }
                       else
                             if(alone2 ==true)
                       {
                           CipherMatrix =new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{alphabate.IndexOf(Ciphertext[outerj])},{alphabate.IndexOf(Ciphertext[outerk])},{0}});
                       }
                        else
                             if(alone3 ==true)
                       {
                           CipherMatrix =new Matrix(new double[,] {{alphabate.IndexOf(Ciphertext[i])},{alphabate.IndexOf(Ciphertext[outerj])},{alphabate.IndexOf(Ciphertext[outerk])},{0}});
                        
                       i +=f1 + f2 + f3;
                           PlanMatrix = PlanMatrix.Multiply(keyMatrix, CipherMatrix);
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[0, 0].numerator), alphabets.length)];
                           textBoxplantext.Text += B1;
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[1, 0].numerator), alphabets.length)];
                           textBoxplantext.Text += B2;
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[2, 0].numerator), alphabets.length)];
                           textBoxplantext.Text += B3;
                           textBoxplantext.Text += alphabets[Mod(Convert.ToInt32(PlanMatrix[3, 0].numerator), alphabets.length)];
                   }
                   else
                   {
                       textBoxplantext.Text +=Ciphertext[i].ToString();
                       i -=3;
                             }
                                      }
               }
           }
               */

        }


    
        
        
        }
    
}
               
