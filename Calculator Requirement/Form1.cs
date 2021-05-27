using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Requirement
{
    public partial class calcDesign : Form
    {

        public calcDesign()
        {
            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "2";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = outptPreview.Text + "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outptPreview.Text = "0";
        }

        private void calcDesign_Load(object sender, EventArgs e)
        {

        }

        private void outptPreview_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == "")){

                outptPreview.Text = "1";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "1";
            }
        }
    

        private void btn3_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "3";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "4";

            }
            else
            {

                outptPreview.Text = outptPreview.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "5";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "6";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "7";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "8";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "9";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "0";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            outptPreview.Text = outptPreview.Text + ".";
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            outptPreview.Text = outptPreview.Text + "=";
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            
            outptDisp.AppendText("+" + outptPreview.Text);
            outptPreview.Text = "";
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            outptDisp.AppendText("-" + outptPreview.Text);
            outptPreview.Text = "";
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            outptDisp.AppendText("*" + outptPreview.Text);
            outptPreview.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            outptDisp.AppendText("/" + outptPreview.Text);
            outptPreview.Text = "";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {

            outptDisp.Text = "";
            outptPreview.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (outptPreview.Text == "0")
            {

                //None
            }
            else
            {
                if (outptPreview.Text.Length == 1)
                {

                    outptPreview.Text = "0";
                }
                else
                {

                    outptPreview.Text = outptPreview.Text.Remove(outptPreview.Text.Length - 1, 1);
                }
            }
        }
    }
}
