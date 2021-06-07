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

        static class Global
        {

            public static double output = 0;
            public static string op = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "2";
            }
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "2";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "2";
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

            if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else
            {

                outptPreview.Text = "0";
            }
        }

        private void calcDesign_Load(object sender, EventArgs e)
        {

        }

        private void outptPreview_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "1";
            }
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "1";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "3";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "4";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "5";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "6";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "7";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "8";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "9";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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

            switch (Global.op)
            {

                case "+":
                    Global.output = Global.output + Double.Parse(outptPreview.Text);
                    break;
                case "-":
                    Global.output = Global.output - Double.Parse(outptPreview.Text);
                    break;
                case "*":
                    Global.output = Global.output * Double.Parse(outptPreview.Text);
                    break;
                case "/":
                    if (outptPreview.Text == "0")
                    {

                        outptPreview.Text = "Cannot divide by zero";
                        btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                    }
                    else
                    {

                        Global.output = Global.output / Double.Parse(outptPreview.Text);
                    }
                    break;
                default:
                    break;
            }
            outptDisp.Text = "=" + outptPreview.Text + outptDisp.Text;
            outptPreview.Text = Global.output.ToString();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            
            Global.output = Double.Parse(outptPreview.Text) + Global.output;

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                outptDisp.AppendText("+" + Global.output.ToString());
            }
            else if ((Global.output.ToString() + Global.op) == outptDisp.Text)
            {

                //None
            }
            else
            {

                outptDisp.Text = "";
                outptDisp.AppendText("+" + Global.output.ToString());
            }

            outptPreview.Text = "0";
            Global.op = "+";
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            Global.output = Global.output - Double.Parse(outptPreview.Text);

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                outptDisp.AppendText("-" + Global.output.ToString());
            }
            else
            {

                outptDisp.Text = "";
                outptDisp.AppendText("-" + Global.output.ToString());
            }

            outptPreview.Text = "0";
            Global.op = "-";
        }
    

        private void btnx_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                outptDisp.AppendText("*" + outptPreview.Text);
                Global.output = Double.Parse(outptPreview.Text);
            }
            else
            {

                Global.output = Global.output * Double.Parse(outptPreview.Text);
                outptDisp.Text = "";
                outptDisp.AppendText("*" + Global.output.ToString());
            }

            outptPreview.Text = "0";
            Global.op = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                outptDisp.AppendText("/" + outptPreview.Text);
                Global.output = Double.Parse(outptPreview.Text);
                outptPreview.Text = "0";
                Global.op = "/";
            }
            else
            {

                if (outptPreview.Text == "0")
                {

                    outptPreview.Text = "Cannot divide by zero";
                    btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                }
                else
                {

                    Global.output = Global.output / Double.Parse(outptPreview.Text);
                    outptDisp.Text = "";
                    outptDisp.AppendText("/" + Global.output.ToString());
                    outptPreview.Text = "0";
                    Global.op = "/";
                }
            }

        }

        private void btnClr_Click(object sender, EventArgs e)
        {

            outptDisp.Text = "";
            outptPreview.Text = "0";
            Global.output = 0;
            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {

            if (outptPreview.Text == "0" || outptPreview.Text == ""){

                //none
            }
            else if (Double.Parse(outptPreview.Text) > 0)
            {

                outptPreview.Text = outptPreview.Text + "-";
            }
            else if (Double.Parse(outptPreview.Text) < 0)
            {
                double converted = Double.Parse(outptPreview.Text) * -1;
                outptPreview.Text = converted.ToString();
            }
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
            else if (outptPreview.Text == "Cannot divide by zero")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                Global.output = 0;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
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
