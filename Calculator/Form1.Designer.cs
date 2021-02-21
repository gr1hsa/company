namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mmulti = new System.Windows.Forms.Button();
            this.Mminus = new System.Windows.Forms.Button();
            this.Mplus = new System.Windows.Forms.Button();
            this.MRC = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.fact = new System.Windows.Forms.Button();
            this.xpowy = new System.Windows.Forms.Button();
            this.xsqrt = new System.Windows.Forms.Button();
            this.pow2 = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Mdel = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CE);
            this.groupBox1.Controls.Add(this.comma);
            this.groupBox1.Controls.Add(this.Plus);
            this.groupBox1.Controls.Add(this.Minus);
            this.groupBox1.Controls.Add(this.Multi);
            this.groupBox1.Controls.Add(this.Del);
            this.groupBox1.Controls.Add(this.Mdel);
            this.groupBox1.Controls.Add(this.Mmulti);
            this.groupBox1.Controls.Add(this.Mminus);
            this.groupBox1.Controls.Add(this.Mplus);
            this.groupBox1.Controls.Add(this.MRC);
            this.groupBox1.Controls.Add(this.equally);
            this.groupBox1.Controls.Add(this.fact);
            this.groupBox1.Controls.Add(this.xpowy);
            this.groupBox1.Controls.Add(this.xsqrt);
            this.groupBox1.Controls.Add(this.pow2);
            this.groupBox1.Controls.Add(this.sqrt);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Mmulti
            // 
            this.Mmulti.Location = new System.Drawing.Point(271, 399);
            this.Mmulti.Name = "Mmulti";
            this.Mmulti.Size = new System.Drawing.Size(75, 48);
            this.Mmulti.TabIndex = 0;
            this.Mmulti.Text = "M*";
            this.Mmulti.Click += new System.EventHandler(this.Mmulti_Click);
            // 
            // Mminus
            // 
            this.Mminus.Location = new System.Drawing.Point(190, 399);
            this.Mminus.Name = "Mminus";
            this.Mminus.Size = new System.Drawing.Size(75, 48);
            this.Mminus.TabIndex = 20;
            this.Mminus.Text = "M-";
            this.Mminus.UseVisualStyleBackColor = true;
            this.Mminus.Click += new System.EventHandler(this.Mminus_Click);
            // 
            // Mplus
            // 
            this.Mplus.Location = new System.Drawing.Point(109, 399);
            this.Mplus.Name = "Mplus";
            this.Mplus.Size = new System.Drawing.Size(75, 48);
            this.Mplus.TabIndex = 19;
            this.Mplus.Text = "M+";
            this.Mplus.UseVisualStyleBackColor = true;
            this.Mplus.Click += new System.EventHandler(this.Mplus_Click);
            // 
            // MRC
            // 
            this.MRC.Location = new System.Drawing.Point(28, 399);
            this.MRC.Name = "MRC";
            this.MRC.Size = new System.Drawing.Size(75, 48);
            this.MRC.TabIndex = 18;
            this.MRC.Text = "MRC";
            this.MRC.UseVisualStyleBackColor = true;
            this.MRC.Click += new System.EventHandler(this.MRC_Click);
            // 
            // equally
            // 
            this.equally.Location = new System.Drawing.Point(655, 245);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(75, 124);
            this.equally.TabIndex = 17;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            // 
            // fact
            // 
            this.fact.Location = new System.Drawing.Point(655, 163);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(75, 42);
            this.fact.TabIndex = 16;
            this.fact.Text = "n!";
            this.fact.UseVisualStyleBackColor = true;
            this.fact.Click += new System.EventHandler(this.fact_Click);
            // 
            // xpowy
            // 
            this.xpowy.Location = new System.Drawing.Point(655, 91);
            this.xpowy.Name = "xpowy";
            this.xpowy.Size = new System.Drawing.Size(75, 42);
            this.xpowy.TabIndex = 15;
            this.xpowy.Text = "x^y";
            this.xpowy.UseVisualStyleBackColor = true;
            this.xpowy.Click += new System.EventHandler(this.xpowy_Click);
            // 
            // xsqrt
            // 
            this.xsqrt.Location = new System.Drawing.Point(528, 327);
            this.xsqrt.Name = "xsqrt";
            this.xsqrt.Size = new System.Drawing.Size(75, 42);
            this.xsqrt.TabIndex = 14;
            this.xsqrt.Text = "x sqrt";
            this.xsqrt.UseVisualStyleBackColor = true;
            this.xsqrt.Click += new System.EventHandler(this.xsqrt_Click);
            // 
            // pow2
            // 
            this.pow2.Location = new System.Drawing.Point(528, 245);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(75, 42);
            this.pow2.TabIndex = 13;
            this.pow2.Text = "x^2";
            this.pow2.UseVisualStyleBackColor = true;
            this.pow2.Click += new System.EventHandler(this.pow2_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(528, 163);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 42);
            this.sqrt.TabIndex = 12;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(528, 91);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 42);
            this.button11.TabIndex = 11;
            this.button11.Text = "+/-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(200, 327);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 42);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(323, 245);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 42);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 245);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(76, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(323, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 58);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mdel
            // 
            this.Mdel.Location = new System.Drawing.Point(352, 399);
            this.Mdel.Name = "Mdel";
            this.Mdel.Size = new System.Drawing.Size(75, 48);
            this.Mdel.TabIndex = 21;
            this.Mdel.Text = "M/";
            this.Mdel.UseVisualStyleBackColor = true;
            this.Mdel.Click += new System.EventHandler(this.Mdel_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(424, 327);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 42);
            this.Del.TabIndex = 22;
            this.Del.Text = "/";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(424, 245);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(75, 42);
            this.Multi.TabIndex = 23;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(424, 163);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 42);
            this.Minus.TabIndex = 24;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(424, 91);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 42);
            this.Plus.TabIndex = 25;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(76, 327);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(75, 42);
            this.comma.TabIndex = 26;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(323, 327);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(75, 42);
            this.CE.TabIndex = 27;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Mmulti;
        private System.Windows.Forms.Button Mminus;
        private System.Windows.Forms.Button Mplus;
        private System.Windows.Forms.Button MRC;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Button fact;
        private System.Windows.Forms.Button xpowy;
        private System.Windows.Forms.Button xsqrt;
        private System.Windows.Forms.Button pow2;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button Mdel;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button comma;
    }
}

