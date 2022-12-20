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
    public partial class Form2 : Form
    {
        char[] alpha = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        // static string letter = alpha.ToUpper();
        //static string  output =null;
        //static string matrix = null;
        //static string matrix2D = null;
        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            char[] matrix = (textBox2.Text + new string(alpha)).ToCharArray();
            //block blok of tow letter
            for (int i = 0; i < matrix.Length; i++)
            {  //change every j to i
                if (matrix[i] == 'j')
                {
                    matrix[i] = 'i';
                }
            }


            for (int i = 0; i < matrix.Length; i++)
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    if (matrix[i] == matrix[j])
                    {
                        matrix = (new string(matrix)).Remove(j, 1).ToCharArray();
                    }
                }
                    char[,] matrix2D = new char[5, 5];
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            matrix2D[i, j] = matrix[i * 5 + j];
                        }
                    }


                    char[] words = (Convert.ToString(textBox3.Text)).ToArray();


                    for (int j = 0; j < words.Length; j += 2)
                    {
                        char firstletter;
                        char secondletter;
                        //change every j to i
                        if (words[j] == 'j')
                        {
                            words[j] = 'i';
                        }

                        if (j + 1 < words.Length && words[j + 1] == 'j')
                        { words[j + 1] = 'i'; }

                        if (j + 1 == words.Length)
                        {
                            firstletter = words[j];
                            secondletter = 'x';
                        }

                        else if ((j + 1 < words.Length && words[j] == words[j + 1]))
                        {
                            firstletter = words[j];
                            secondletter = 'x';
                            j--;
                        }

                        else
                        {
                            firstletter = words[j];
                            secondletter = words[j + 1];
                        }

                        int f_x = 0, f_y = 0, S_x = 0, S_y = 0;
                        for (int row = 0; row < 5; row++)
                        {
                            for (int col = 0; col < 5; col++)
                            {
                                if (firstletter == matrix2D[row, col])
                                {
                                    f_x = row;
                                    f_y = col;
                                }
                                if (secondletter == matrix2D[row, col])
                                {
                                    S_x = row;
                                    S_y = col;
                                }
                            }
                        }
                        if (f_x == S_x)
                        {
                            textBox1.Text += matrix2D[f_x, (f_y - 1) % 5];
                            textBox1.Text += matrix2D[S_x, (S_y - 1) % 5];
                        }



                        else if (f_y == S_y)
                        {
                            textBox1.Text += matrix2D[(f_x + 1) % 5, f_y];
                            textBox1.Text += matrix2D[(S_x + 1) % 5, S_y];
                        }

                        else
                        {
                            textBox1.Text += matrix2D[f_x, S_y];
                            textBox1.Text += matrix2D[S_x, f_y];
                        }
                    }
                    textBox1.Text += " ";
                }
        }
    }
