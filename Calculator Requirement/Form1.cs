using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator_Requirement;

namespace Calculator_Requirement
{
    public partial class calcDesign : Form
    {

        public calcDesign()
        {
            InitializeComponent();
        }
            public double output = 0;
            public double secondVal = 0;
            public string op = "";
            public double memVal = 0;
            public bool inEq = false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "2";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "2";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "2";
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
            if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else
            {

                outptPreview.Text = "0";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "1";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "1";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "1";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "1";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "3";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "3";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "3";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "4";

            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "4";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "4";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "5";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "5";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "5";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "6";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "6";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "6";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "7";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "7";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "7";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "8";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "8";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "8";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "9";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "9";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "9";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {

            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (inEq == false))
            {

                outptPreview.Text = "0";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = output.ToString() + op;
                outptPreview.Text = "0";
            }
            else
            {

                outptPreview.Text = outptPreview.Text + "0";
            }
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!outptPreview.Text.Contains("."))
            {

                outptPreview.Text = outptPreview.Text + ".";
            }
        }

        private void btnEq_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                outptDisp.Text = outptPreview.Text + "=";
                inEq = true;
            }
            else if (outptDisp.Text == (output.ToString() + op + outptPreview.Text)) //for %
            {

                outptDisp.AppendText("=");
                switch (op)
                {

                    case "+":
                        output = output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        output = output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        output = output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            output = output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }

                inEq = true;
                outptPreview.Text = output.ToString();

            }
            else if (outptDisp.Text.Contains("="))
            {

                if (outptDisp.Text.Contains("+"))
                {

                    string[] vars = outptDisp.Text.Split('+', '=');
   
                    output = output + Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "+" + vars[1] + "=";
                }
                else if (op == "-")
                {

                    string[] vars = outptDisp.Text.Split('-', '=');

                    if (vars[0] == "")
                    {

                        output = output - Double.Parse(vars[2]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[2] + "=";
                    }
                    else
                    {

                        output = output - Double.Parse(vars[1]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[1] + "=";
                    }
                }
                else if (outptDisp.Text.Contains("*"))
                {

                    string[] vars = outptDisp.Text.Split('*', '=');
                    output = output * Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "*" + vars[1] + "=";
                }
                else if (outptDisp.Text.Contains("/"))
                {

                    string[] vars = outptDisp.Text.Split('/', '=');
                    output = output / Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "/" + vars[1] + "=";
                }

                inEq = true;
                outptPreview.Text = output.ToString();
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else
            {

                outptDisp.Text = outptDisp.Text + outptPreview.Text + "=";
                switch (op)
                {

                    case "+":
                        output = output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        output = output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        output = output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            output = output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }

                inEq = true;
                outptPreview.Text = output.ToString();
            }
        }

        private void btnPos_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(output.ToString() + "+");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {

                outptDisp.Text = outptPreview.Text + "+";
                output = Double.Parse(outptPreview.Text);
            }
            else //if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString()))
            {

                switch (op)
                {

                    case "+":
                        output = output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        output = output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        output = output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            output = output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }

                outptDisp.Text = output.ToString() + "+";
                outptPreview.Text = "0";
            }
            /*else
            {

                output = output + Double.Parse(outptPreview.Text);
                outptDisp.Text = "";
                outptDisp.AppendText(output.ToString() + "+");
            }*/

            outptPreview.Text = "0";
            op = "+";
            inEq = false;
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(output.ToString() + "-");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {

                outptDisp.Text = outptPreview.Text + "-";
                output = Double.Parse(outptPreview.Text);
            }
            else //if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString()))
            {

                switch (op)
                {

                    case "+":
                        output = output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        output = output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        output = output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            output = output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }

                outptDisp.Text = output.ToString() + "-";
                outptPreview.Text = "0";
            }
            /*else
            {

                output = output - Double.Parse(outptPreview.Text);
                outptDisp.Text = "";
                outptDisp.AppendText(output.ToString() + "-");
            }*/

            outptPreview.Text = "0";
            op = "-";
            inEq = false;
        }
    

        private void btnx_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(output.ToString() + "*");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {

                outptDisp.Text = outptPreview.Text + "*";
                output = Double.Parse(outptPreview.Text);
            }
            else //if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString()))
            {

                switch (op)
                {

                    case "+":
                        output = output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        output = output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        output = output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            output = output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }

                outptDisp.Text = output.ToString() + "*";
                outptPreview.Text = "0";
            }
            /*else
            {

                output = Double.Parse(outptPreview.Text) * output;
                outptDisp.Text = "";
                outptDisp.AppendText(output.ToString() + "*");
            }*/

            outptPreview.Text = "0";
            op = "*";
            inEq = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(output.ToString() + "/");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {

                outptDisp.Text = outptPreview.Text + "/";
                output = Double.Parse(outptPreview.Text);
            }
            else //if ((outptDisp.Text == output.ToString() + op + secondVal.ToString()) && (outptPreview.Text == secondVal.ToString()))
            {

                switch (op)
                {

                    case "+":
                        output = output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        output = output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        output = output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            output = output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }

                outptDisp.Text = output.ToString() + "/";
            }
            /*else
            {

                if (outptPreview.Text == "0")
                {

                    outptPreview.Text = "Cannot divide by zero";
                    btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                }
                else
                {

                    output = output / Double.Parse(outptPreview.Text);
                    outptDisp.Text = "";
                    outptDisp.AppendText(output.ToString() + "/");
                    outptPreview.Text = "0";
                    op = "/";
                }
            }*/

            outptPreview.Text = "0";
            op = "/";
            inEq = false;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {

            outptDisp.Text = "";
            outptPreview.Text = "0";
            output = 0;
            inEq = false;
            btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
        }
        private void btnPosNeg_Click(object sender, EventArgs e)
        {

            if (outptPreview.Text == "0" || outptPreview.Text == ""){

                //none
            }
            else
            {
                double convert = Double.Parse(outptPreview.Text) * -1;
                outptPreview.Text = convert.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Double.Parse(outptPreview.Text) < 0)
            {

                outptDisp.Text = $"sqrt({outptPreview.Text})";
                outptPreview.Text = "Invalid Input";
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
            }
            else
            {

                outptDisp.Text = $"sqrt({outptPreview.Text})";
                output = Math.Sqrt(Double.Parse(outptPreview.Text));
                outptPreview.Text = output.ToString();
                inEq = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (outptPreview.Text == "0")
            {

                //None
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                output = 0;
                inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if (inEq == true)
            {

                outptDisp.Text = "";
                inEq = false;
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

        private void btnSquared_Click(object sender, EventArgs e)
        {

            outptDisp.Text = $"({outptPreview.Text})^2";
            output = Double.Parse(outptPreview.Text) * Double.Parse(outptPreview.Text);
            outptPreview.Text = output.ToString();
            inEq = true;
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {

            if (Double.Parse(outptPreview.Text) == 0)
            {

                outptDisp.Text = $"1/({outptPreview.Text})";
                outptPreview.Text = "Cannot divide by zero";
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
            }
            else
            {

                outptDisp.Text = $"1/({outptPreview.Text})";
                output = 1/Double.Parse(outptPreview.Text);
                outptPreview.Text = output.ToString();
                inEq = true;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        if ((output.ToString() + op) == outptDisp.Text)
            {

                if (op.Equals("+") || op.Equals("-"))
                {

                    secondVal = output*(Double.Parse(outptPreview.Text) / 100);
                }
                else if (op.Equals("*") || op.Equals("/"))
                {

                    secondVal = Double.Parse(outptPreview.Text) / 100;
                }

                outptDisp.Text = output.ToString() + op + secondVal.ToString();
                outptPreview.Text = secondVal.ToString();
                inEq = true;
            }         
        }

        private void btnMS_Click(object sender, EventArgs e)
        {

            memVal = Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {

            memVal = memVal - Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {

            memVal = memVal + Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {

            outptPreview.Text = memVal.ToString();
            inEq = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

            memVal = 0;
            btnMC.Enabled = btnMR.Enabled = false;
        }
    }
}
