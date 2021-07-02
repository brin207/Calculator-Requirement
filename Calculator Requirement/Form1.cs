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
           
        Class1 clss = new Class1(); //Class 1 assigned variable == clss
        private void btn3_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "3";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "3";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "3";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "4";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "4";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "4";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "5";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "5";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "5";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "6";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "6";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "6";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "7";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "7";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "7";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "8";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "8";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "8";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "9";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "9";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "9";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "0";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "0";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
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
                clss.inEq = true;
            }
            else if (outptDisp.Text == (clss.output.ToString() + clss.op + outptPreview.Text)) //for %
            {
                outptDisp.AppendText("=");
                switch (clss.op)
                {
                    case "+":
                        clss.output = clss.output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.output = clss.output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.output = clss.output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            clss.output = clss.output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                clss.inEq = true;
                outptPreview.Text = clss.output.ToString();
            }
            else if (outptDisp.Text.Contains("="))
            {
                if (outptDisp.Text.Contains("+"))
                {
                    string[] vars = outptDisp.Text.Split('+', '=');
   
                    clss.output = clss.output + Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "+" + vars[1] + "=";
                }
                else if (clss.op == "-")
                {
                    string[] vars = outptDisp.Text.Split('-', '=');

                    if (vars[0] == "")
                    {
                        clss.output = clss.output - Double.Parse(vars[2]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[2] + "=";
                    }
                    else
                    {
                        clss.output = clss.output - Double.Parse(vars[1]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[1] + "=";
                    }
                }
                else if (outptDisp.Text.Contains("*"))
                {
                    string[] vars = outptDisp.Text.Split('*', '=');
                    clss.output = clss.output * Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "*" + vars[1] + "=";
                }
                else if (outptDisp.Text.Contains("/"))
                {
                    string[] vars = outptDisp.Text.Split('/', '=');
                    clss.output = clss.output / Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "/" + vars[1] + "=";
                }
                clss.inEq = true;
                outptPreview.Text = clss.output.ToString();
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {
                outptDisp.Text = "";
                outptPreview.Text = "0";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else
            {
                outptDisp.Text = outptDisp.Text + outptPreview.Text + "=";
                switch (clss.op)
                {
                    case "+":
                        clss.output = clss.output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.output = clss.output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.output = clss.output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.output = clss.output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                clss.inEq = true;
                outptPreview.Text = clss.output.ToString();
            }
        }
        private void btnPos_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.output.ToString() + "+");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "+";
                clss.output = Double.Parse(outptPreview.Text);
            }
            else
            {
                switch (clss.op)
                {
                    case "+":
                        clss.output = clss.output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.output = clss.output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.output = clss.output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.output = clss.output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.output.ToString() + "+";
                outptPreview.Text = "0";
            }
            outptPreview.Text = "0";
            clss.op = "+";
            clss.inEq = false;
        }
        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.output.ToString() + "-");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "-";
                clss.output = Double.Parse(outptPreview.Text);
            }
            else
            {
                switch (clss.op)
                {
                    case "+":
                        clss.output = clss.output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.output = clss.output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.output = clss.output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.output = clss.output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.output.ToString() + "-";
                outptPreview.Text = "0";
            }
            outptPreview.Text = "0";
            clss.op = "-";
            clss.inEq = false;
        }
        private void btnx_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.output.ToString() + "*");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "*";
                clss.output = Double.Parse(outptPreview.Text);
            }
            else
            {
                switch (clss.op)
                {
                    case "+":
                        clss.output = clss.output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.output = clss.output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.output = clss.output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            clss.output = clss.output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.output.ToString() + "*";
                outptPreview.Text = "0";
            }
            outptPreview.Text = "0";
            clss.op = "*";
            clss.inEq = false;
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.output.ToString() + "/");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "/";
                clss.output = Double.Parse(outptPreview.Text);
            }
            else
            {
                switch (clss.op)
                {
                    case "+":
                        clss.output = clss.output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.output = clss.output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.output = clss.output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.output = clss.output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.output.ToString() + "/";
            }
            outptPreview.Text = "0";
            clss.op = "/";
            clss.inEq = false;
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            outptDisp.Text = "";
            outptPreview.Text = "0";
            clss.output = 0;
            clss.inEq = false;
            btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            if (clss.memVal != 0)
            {
                btnMC.Enabled = btnMR.Enabled = true;
            }
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
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if (clss.inEq == true)
            {
                outptDisp.Text = "";
                clss.inEq = false;
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
            clss.output = Double.Parse(outptPreview.Text) * Double.Parse(outptPreview.Text);
            outptPreview.Text = clss.output.ToString();
            clss.inEq = true;
        }
        private void btnFraction_Click(object sender, EventArgs e)
        {
            if (Double.Parse(outptPreview.Text) == 0)
            {
                outptDisp.Text = $"1/({outptPreview.Text})";
                outptPreview.Text = "Cannot divide by zero";
                btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
            }
            else
            {
                outptDisp.Text = $"1/({outptPreview.Text})";
                clss.output = 1/Double.Parse(outptPreview.Text);
                outptPreview.Text = clss.output.ToString();
                clss.inEq = true;
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
        if ((clss.output.ToString() + clss.op) == outptDisp.Text)
            {
                if (clss.op.Equals("+") || clss.op.Equals("-"))
                {
                    clss.secondVal = clss.output*(Double.Parse(outptPreview.Text) / 100);
                }
                else if (clss.op.Equals("*") || clss.op.Equals("/"))
                {
                    clss.secondVal = Double.Parse(outptPreview.Text) / 100;
                }
                outptDisp.Text = clss.output.ToString() + clss.op + clss.secondVal.ToString();
                outptPreview.Text = clss.secondVal.ToString();
                clss.inEq = true;
            }         
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            clss.memVal = Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
            clss.inEq = true;
        }
        private void btnMminus_Click(object sender, EventArgs e)
        {
            clss.memVal = clss.memVal - Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
            clss.inEq = true;
        }
        private void btnMplus_Click(object sender, EventArgs e)
        {
            clss.memVal = clss.memVal + Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
            clss.inEq = true;
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            outptPreview.Text = clss.memVal.ToString();
            clss.inEq = true;
        }
        private void btnMC_Click(object sender, EventArgs e)
        {
            clss.memVal = 0;
            btnMC.Enabled = btnMR.Enabled = false;
        }
        private void btnClrPrev_Click(object sender, EventArgs e)
        {
            if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {
                outptDisp.Text = "";
                outptPreview.Text = "0";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else
            {
                outptPreview.Text = "0";
            }
        }
        private void btnSquareRt_Click(object sender, EventArgs e)
        {
            if (Double.Parse(outptPreview.Text) < 0)
            {
                outptDisp.Text = $"sqrt({outptPreview.Text})";
                outptPreview.Text = "Invalid Input";
                btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
            }
            else
            {
                outptDisp.Text = $"sqrt({outptPreview.Text})";
                clss.output = Math.Sqrt(Double.Parse(outptPreview.Text));
                outptPreview.Text = clss.output.ToString();
                clss.inEq = true;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "1";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "1";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "1";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.inEq == false))
            {
                outptPreview.Text = "2";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.inEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "2";
                clss.output = 0;
                clss.inEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.memVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.output.ToString() + clss.op + clss.secondVal.ToString()) && (outptPreview.Text == clss.secondVal.ToString())) // for % reset clss.inEq
            {
                outptDisp.Text = clss.output.ToString() + clss.op;
                outptPreview.Text = "2";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "2";
            }
        }
    }
}
