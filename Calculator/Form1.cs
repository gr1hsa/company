using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {   
        private void CorrectNumber()
        {               
            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
                label1.Text = label1.Text.Remove(0, 1);


            if (label1.Text[0] == '-')
            {
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(",") != 2))
                    label1.Text = label1.Text.Remove(1, 1);
            }
        }
        private bool CanPress()
        {
            if (!Multi.Enabled)
                return false;

            if (!Del.Enabled)
                return false;

            if (!Plus.Enabled)
                return false;

            if (!Minus.Enabled)
                return false;

            if (!xsqrt.Enabled)
                return false;

            if (!xpowy.Enabled)
                return false;

            return true;
        }
        private void FreeButtons()
        {
            Multi.Enabled = true;
            Del.Enabled = true;
            Plus.Enabled = true;
            Minus.Enabled = true;
            xsqrt.Enabled = true;
            xpowy.Enabled = true;
        }
        
        public Form1()
        {
            InitializeComponent();
            
            label1.Text = "0";
            C = new Calc();
        }
        Calc C;
        int k = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";

            CorrectNumber();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";

            CorrectNumber();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                label1.Text = "-" + label1.Text;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                label1.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void pow2_Click(object sender, EventArgs e)
        {
           
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                label1.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void xsqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                xsqrt.Enabled = false;

                label1.Text = "0";
            }
        }

        private void xpowy_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                xpowy.Enabled = false;

                label1.Text = "0";
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            C.Clear_A();
            FreeButtons();
            k = 0;
        }

        private void equally_Click(object sender, EventArgs e)
        {
            if (!Multi.Enabled)
                label1.Text = C.Multiplication(Convert.ToDouble(label1.Text)).ToString();

            if (!Del.Enabled)
                label1.Text = C.Division(Convert.ToDouble(label1.Text)).ToString();

            if (!Plus.Enabled)
                label1.Text = C.Sum(Convert.ToDouble(label1.Text)).ToString();

            if (!Minus.Enabled)
                label1.Text = C.Subtraction(Convert.ToDouble(label1.Text)).ToString();

            if (!xsqrt.Enabled)
                label1.Text = C.xsqrt(Convert.ToDouble(label1.Text)).ToString();

            if (!xpowy.Enabled)
                label1.Text = C.xpowy(Convert.ToDouble(label1.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void fact_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((int)Convert.ToDouble(label1.Text) > 0)
                {
                    C.Put_A((int)Convert.ToDouble(label1.Text));

                    label1.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    label1.Text = "Плохое число";



            }
        }
        private void Multi_Click(object sender, EventArgs e)
        {
            if(CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                Multi.Enabled = false;

                label1.Text = "0";
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                Del.Enabled = false;

                label1.Text = "0";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                Plus.Enabled = false;

                label1.Text = "0";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                Minus.Enabled = false;

                label1.Text = "0";
            }
        }

        private void Mplus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(label1.Text));
        }

        private void Mminus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(label1.Text));
        }

        private void Mmulti_Click(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(label1.Text));
        }

        private void Mdel_Click(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(label1.Text));
        }

        private void MRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    label1.Text = C.MemoryShow().ToString();

                if (k == 2)
                {
                    C.Memory_Clear();
                    label1.Text = "0";

                    k = 0;
                }
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf(",") == -1)
                label1.Text += ",";
        }
    }
}
