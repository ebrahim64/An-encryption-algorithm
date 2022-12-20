namespace لخوارزميات
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxc1 = new System.Windows.Forms.TextBox();
            this.textBoxplantext = new System.Windows.Forms.TextBox();
            this.textBoxciphertext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button_Decription = new System.Windows.Forms.Button();
            this.button_Encription = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.textBoxC4 = new System.Windows.Forms.TextBox();
            this.textBoxC5 = new System.Windows.Forms.TextBox();
            this.textBoxC6 = new System.Windows.Forms.TextBox();
            this.textBoxC7 = new System.Windows.Forms.TextBox();
            this.textBoxC8 = new System.Windows.Forms.TextBox();
            this.textBoxC9 = new System.Windows.Forms.TextBox();
            this.textBoxC10 = new System.Windows.Forms.TextBox();
            this.textBoxC11 = new System.Windows.Forms.TextBox();
            this.textBoxC12 = new System.Windows.Forms.TextBox();
            this.textBoxC13 = new System.Windows.Forms.TextBox();
            this.textBoxC14 = new System.Windows.Forms.TextBox();
            this.textBoxC16 = new System.Windows.Forms.TextBox();
            this.textBoxC15 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxc1
            // 
            this.textBoxc1.Enabled = false;
            this.textBoxc1.Location = new System.Drawing.Point(30, 125);
            this.textBoxc1.Name = "textBoxc1";
            this.textBoxc1.Size = new System.Drawing.Size(32, 27);
            this.textBoxc1.TabIndex = 0;
            this.textBoxc1.TextChanged += new System.EventHandler(this.textBoxc1_TextChanged);
            // 
            // textBoxplantext
            // 
            this.textBoxplantext.Location = new System.Drawing.Point(333, 139);
            this.textBoxplantext.Multiline = true;
            this.textBoxplantext.Name = "textBoxplantext";
            this.textBoxplantext.Size = new System.Drawing.Size(293, 75);
            this.textBoxplantext.TabIndex = 0;
            this.textBoxplantext.TextChanged += new System.EventHandler(this.textBoxplan_TextChanged);
            // 
            // textBoxciphertext
            // 
            this.textBoxciphertext.Location = new System.Drawing.Point(333, 246);
            this.textBoxciphertext.Multiline = true;
            this.textBoxciphertext.Name = "textBoxciphertext";
            this.textBoxciphertext.Size = new System.Drawing.Size(293, 79);
            this.textBoxciphertext.TabIndex = 0;
            this.textBoxciphertext.TextChanged += new System.EventHandler(this.textBoxcipher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "مصفوفة المفتاح";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "الرسالة الاصلية";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(565, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "2*2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(464, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 23);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "3*3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(333, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 23);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "4*4";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // button_Decription
            // 
            this.button_Decription.Location = new System.Drawing.Point(789, 437);
            this.button_Decription.Name = "button_Decription";
            this.button_Decription.Size = new System.Drawing.Size(115, 69);
            this.button_Decription.TabIndex = 6;
            this.button_Decription.Text = "Decription";
            this.button_Decription.UseVisualStyleBackColor = true;
            this.button_Decription.Click += new System.EventHandler(this.button_Decription_Click);
            // 
            // button_Encription
            // 
            this.button_Encription.Location = new System.Drawing.Point(627, 437);
            this.button_Encription.Name = "button_Encription";
            this.button_Encription.Size = new System.Drawing.Size(144, 69);
            this.button_Encription.TabIndex = 8;
            this.button_Encription.Text = "Encriptoin";
            this.button_Encription.UseVisualStyleBackColor = true;
            this.button_Encription.Click += new System.EventHandler(this.button_Encription_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "الرسالة المشفرة";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(40, 437);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(144, 69);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear_Key";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBoxC2
            // 
            this.textBoxC2.Enabled = false;
            this.textBoxC2.Location = new System.Drawing.Point(83, 125);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(33, 27);
            this.textBoxC2.TabIndex = 9;
            this.textBoxC2.TextChanged += new System.EventHandler(this.textBoxC2_TextChanged);
            // 
            // textBoxC3
            // 
            this.textBoxC3.Enabled = false;
            this.textBoxC3.Location = new System.Drawing.Point(143, 125);
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.Size = new System.Drawing.Size(31, 27);
            this.textBoxC3.TabIndex = 10;
            this.textBoxC3.TextChanged += new System.EventHandler(this.textBoxC3_TextChanged);
            // 
            // textBoxC4
            // 
            this.textBoxC4.Enabled = false;
            this.textBoxC4.Location = new System.Drawing.Point(201, 125);
            this.textBoxC4.Name = "textBoxC4";
            this.textBoxC4.Size = new System.Drawing.Size(33, 27);
            this.textBoxC4.TabIndex = 11;
            this.textBoxC4.TextChanged += new System.EventHandler(this.textBoxC4_TextChanged);
            // 
            // textBoxC5
            // 
            this.textBoxC5.Enabled = false;
            this.textBoxC5.Location = new System.Drawing.Point(30, 187);
            this.textBoxC5.Name = "textBoxC5";
            this.textBoxC5.Size = new System.Drawing.Size(32, 27);
            this.textBoxC5.TabIndex = 12;
            this.textBoxC5.TextChanged += new System.EventHandler(this.textBoxC5_TextChanged);
            // 
            // textBoxC6
            // 
            this.textBoxC6.Enabled = false;
            this.textBoxC6.Location = new System.Drawing.Point(83, 187);
            this.textBoxC6.Name = "textBoxC6";
            this.textBoxC6.Size = new System.Drawing.Size(33, 27);
            this.textBoxC6.TabIndex = 13;
            this.textBoxC6.TextChanged += new System.EventHandler(this.textBoxC6_TextChanged);
            // 
            // textBoxC7
            // 
            this.textBoxC7.Enabled = false;
            this.textBoxC7.Location = new System.Drawing.Point(141, 187);
            this.textBoxC7.Name = "textBoxC7";
            this.textBoxC7.Size = new System.Drawing.Size(33, 27);
            this.textBoxC7.TabIndex = 14;
            this.textBoxC7.TextChanged += new System.EventHandler(this.textBoxC7_TextChanged);
            // 
            // textBoxC8
            // 
            this.textBoxC8.Enabled = false;
            this.textBoxC8.Location = new System.Drawing.Point(202, 187);
            this.textBoxC8.Name = "textBoxC8";
            this.textBoxC8.Size = new System.Drawing.Size(32, 27);
            this.textBoxC8.TabIndex = 15;
            this.textBoxC8.TextChanged += new System.EventHandler(this.textBoxC8_TextChanged);
            // 
            // textBoxC9
            // 
            this.textBoxC9.Enabled = false;
            this.textBoxC9.Location = new System.Drawing.Point(30, 246);
            this.textBoxC9.Name = "textBoxC9";
            this.textBoxC9.Size = new System.Drawing.Size(32, 27);
            this.textBoxC9.TabIndex = 16;
            this.textBoxC9.TextChanged += new System.EventHandler(this.textBoxC9_TextChanged);
            // 
            // textBoxC10
            // 
            this.textBoxC10.Enabled = false;
            this.textBoxC10.Location = new System.Drawing.Point(83, 246);
            this.textBoxC10.Name = "textBoxC10";
            this.textBoxC10.Size = new System.Drawing.Size(33, 27);
            this.textBoxC10.TabIndex = 17;
            this.textBoxC10.TextChanged += new System.EventHandler(this.textBoxC10_TextChanged);
            // 
            // textBoxC11
            // 
            this.textBoxC11.Enabled = false;
            this.textBoxC11.Location = new System.Drawing.Point(141, 246);
            this.textBoxC11.Name = "textBoxC11";
            this.textBoxC11.Size = new System.Drawing.Size(32, 27);
            this.textBoxC11.TabIndex = 18;
            this.textBoxC11.TextChanged += new System.EventHandler(this.textBoxC11_TextChanged);
            // 
            // textBoxC12
            // 
            this.textBoxC12.Enabled = false;
            this.textBoxC12.Location = new System.Drawing.Point(202, 246);
            this.textBoxC12.Name = "textBoxC12";
            this.textBoxC12.Size = new System.Drawing.Size(32, 27);
            this.textBoxC12.TabIndex = 19;
            this.textBoxC12.TextChanged += new System.EventHandler(this.textBoxC12_TextChanged);
            // 
            // textBoxC13
            // 
            this.textBoxC13.Enabled = false;
            this.textBoxC13.Location = new System.Drawing.Point(30, 299);
            this.textBoxC13.Name = "textBoxC13";
            this.textBoxC13.Size = new System.Drawing.Size(32, 27);
            this.textBoxC13.TabIndex = 20;
            this.textBoxC13.TextChanged += new System.EventHandler(this.textBoxC13_TextChanged);
            // 
            // textBoxC14
            // 
            this.textBoxC14.Enabled = false;
            this.textBoxC14.Location = new System.Drawing.Point(83, 299);
            this.textBoxC14.Name = "textBoxC14";
            this.textBoxC14.Size = new System.Drawing.Size(33, 27);
            this.textBoxC14.TabIndex = 21;
            this.textBoxC14.TextChanged += new System.EventHandler(this.textBoxC14_TextChanged);
            // 
            // textBoxC16
            // 
            this.textBoxC16.Enabled = false;
            this.textBoxC16.Location = new System.Drawing.Point(202, 299);
            this.textBoxC16.Name = "textBoxC16";
            this.textBoxC16.Size = new System.Drawing.Size(33, 27);
            this.textBoxC16.TabIndex = 22;
            this.textBoxC16.TextChanged += new System.EventHandler(this.textBoxC16_TextChanged);
            // 
            // textBoxC15
            // 
            this.textBoxC15.Enabled = false;
            this.textBoxC15.Location = new System.Drawing.Point(143, 299);
            this.textBoxC15.Name = "textBoxC15";
            this.textBoxC15.Size = new System.Drawing.Size(33, 27);
            this.textBoxC15.TabIndex = 23;
            this.textBoxC15.TextChanged += new System.EventHandler(this.textBoxC15_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 533);
            this.Controls.Add(this.textBoxC15);
            this.Controls.Add(this.textBoxC16);
            this.Controls.Add(this.textBoxC14);
            this.Controls.Add(this.textBoxC13);
            this.Controls.Add(this.textBoxC12);
            this.Controls.Add(this.textBoxC11);
            this.Controls.Add(this.textBoxC10);
            this.Controls.Add(this.textBoxC9);
            this.Controls.Add(this.textBoxC8);
            this.Controls.Add(this.textBoxC7);
            this.Controls.Add(this.textBoxC6);
            this.Controls.Add(this.textBoxC5);
            this.Controls.Add(this.textBoxC4);
            this.Controls.Add(this.textBoxC3);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Encription);
            this.Controls.Add(this.button_Decription);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxciphertext);
            this.Controls.Add(this.textBoxplantext);
            this.Controls.Add(this.textBoxc1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxc1;
        private System.Windows.Forms.TextBox textBoxplantext;
        private System.Windows.Forms.TextBox textBoxciphertext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button_Decription;
        private System.Windows.Forms.Button button_Encription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.TextBox textBoxC4;
        private System.Windows.Forms.TextBox textBoxC5;
        private System.Windows.Forms.TextBox textBoxC6;
        private System.Windows.Forms.TextBox textBoxC7;
        private System.Windows.Forms.TextBox textBoxC8;
        private System.Windows.Forms.TextBox textBoxC9;
        private System.Windows.Forms.TextBox textBoxC10;
        private System.Windows.Forms.TextBox textBoxC11;
        private System.Windows.Forms.TextBox textBoxC12;
        private System.Windows.Forms.TextBox textBoxC13;
        private System.Windows.Forms.TextBox textBoxC14;
        private System.Windows.Forms.TextBox textBoxC16;
        private System.Windows.Forms.TextBox textBoxC15;
    }
}