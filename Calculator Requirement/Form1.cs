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
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "3";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "3";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "3";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "4";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "4";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "4";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "5";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "5";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "5";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "6";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "6";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "6";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "7";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "7";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "7";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "8";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "8";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "8";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "9";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "9";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "9";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "0";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "0";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
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
                clss.InEq = true;
            }
            else if (outptDisp.Text == (clss.Output.ToString() + clss.Op + outptPreview.Text)) //for %
            {
                outptDisp.AppendText("=");
                switch (clss.Op)
                {
                    case "+":
                        clss.Output = clss.Output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.Output = clss.Output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.Output = clss.Output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                clss.InEq = true;
                outptPreview.Text = clss.Output.ToString();
            }
            else if (outptDisp.Text.Contains("="))
            {
                if (outptDisp.Text.Contains("+"))
                {
                    string[] vars = outptDisp.Text.Split('+', '=');
   
                    clss.Output = clss.Output + Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "+" + vars[1] + "=";
                }
                else if (clss.Op == "-")
                {
                    string[] vars = outptDisp.Text.Split('-', '=');

                    if (vars[0] == "")
                    {
                        clss.Output = clss.Output - Double.Parse(vars[2]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[2] + "=";
                    }
                    else
                    {
                        clss.Output = clss.Output - Double.Parse(vars[1]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[1] + "=";
                    }
                }
                else if (outptDisp.Text.Contains("*"))
                {
                    string[] vars = outptDisp.Text.Split('*', '=');
                    clss.Output = clss.Output * Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "*" + vars[1] + "=";
                }
                else if (outptDisp.Text.Contains("/"))
                {
                    string[] vars = outptDisp.Text.Split('/', '=');
                    clss.Output = clss.Output / Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "/" + vars[1] + "=";
                }
                clss.InEq = true;
                outptPreview.Text = clss.Output.ToString();
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {
                outptDisp.Text = "";
                outptPreview.Text = "0";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else
            {
                outptDisp.Text = outptDisp.Text + outptPreview.Text + "=";
                switch (clss.Op)
                {
                    case "+":
                        clss.Output = clss.Output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.Output = clss.Output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.Output = clss.Output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                clss.InEq = true;
                outptPreview.Text = clss.Output.ToString();
            }
        }
        private void btnPos_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.Output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.Output.ToString() + "+");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "+";
                clss.Output = Double.Parse(outptPreview.Text);
            }
            else
            {
                switch (clss.Op)
                {
                    case "+":
                        clss.Output = clss.Output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.Output = clss.Output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.Output = clss.Output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.Output.ToString() + "+";
                outptPreview.Text = "0";
            }
            outptPreview.Text = "0";
            clss.Op = "+";
            clss.InEq = false;
        }
        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.Output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.Output.ToString() + "-");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "-";
                clss.Output = Double.Parse(outptPreview.Text);
            }
            else
            {
                switch (clss.Op)
                {
                    case "+":
                        clss.Output = clss.Output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.Output = clss.Output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.Output = clss.Output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.Output.ToString() + "-";
                outptPreview.Text = "0";
            }
            outptPreview.Text = "0";
            clss.Op = "-";
            clss.InEq = false;
        }
        private void btnx_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.Output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.Output.ToString() + "*");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "*";
                clss.Output = Double.Parse(outptPreview.Text);
            }
            else //if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString()))
            {
                switch (clss.Op)
                {
                    case "+":
                        clss.Output = clss.Output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.Output = clss.Output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.Output = clss.Output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {

                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {

                            clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.Output.ToString() + "*";
                outptPreview.Text = "0";
            }
            /*else
            {

                clss.Output = Double.Parse(outptPreview.Text) * clss.Output;
                outptDisp.Text = "";
                outptDisp.AppendText(clss.Output.ToString() + "*");
            }*/
            outptPreview.Text = "0";
            clss.Op = "*";
            clss.InEq = false;
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {
                clss.Output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(clss.Output.ToString() + "/");
            }
            else if (outptDisp.Text.Contains("=") || outptDisp.Text.Contains("("))
            {
                outptDisp.Text = outptPreview.Text + "/";
                clss.Output = Double.Parse(outptPreview.Text);
            }
            else //if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString()))
            {
                switch (clss.Op)
                {
                    case "+":
                        clss.Output = clss.Output + Double.Parse(outptPreview.Text);
                        break;
                    case "-":
                        clss.Output = clss.Output - Double.Parse(outptPreview.Text);
                        break;
                    case "*":
                        clss.Output = clss.Output * Double.Parse(outptPreview.Text);
                        break;
                    case "/":
                        if (outptPreview.Text == "0")
                        {
                            outptPreview.Text = "Cannot divide by zero";
                            btnMC.Enabled = btnMR.Enabled = btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = false;
                        }
                        else
                        {
                            clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                        }
                        break;
                    default:
                        break;
                }
                outptDisp.Text = clss.Output.ToString() + "/";
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

                    clss.Output = clss.Output / Double.Parse(outptPreview.Text);
                    outptDisp.Text = "";
                    outptDisp.AppendText(clss.Output.ToString() + "/");
                    outptPreview.Text = "0";
                    clss.Op = "/";
                }
            }*/
            outptPreview.Text = "0";
            clss.Op = "/";
            clss.InEq = false;
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            outptDisp.Text = "";
            outptPreview.Text = "0";
            clss.Output = 0;
            clss.InEq = false;
            btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            if (clss.MemVal != 0)
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
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if (clss.InEq == true)
            {
                outptDisp.Text = "";
                clss.InEq = false;
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
            clss.Output = Double.Parse(outptPreview.Text) * Double.Parse(outptPreview.Text);
            outptPreview.Text = clss.Output.ToString();
            clss.InEq = true;
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
                clss.Output = 1/Double.Parse(outptPreview.Text);
                outptPreview.Text = clss.Output.ToString();
                clss.InEq = true;
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
        if ((clss.Output.ToString() + clss.Op) == outptDisp.Text)
            {
                if (clss.Op.Equals("+") || clss.Op.Equals("-"))
                {
                    clss.SecondVal = clss.Output*(Double.Parse(outptPreview.Text) / 100);
                }
                else if (clss.Op.Equals("*") || clss.Op.Equals("/"))
                {
                    clss.SecondVal = Double.Parse(outptPreview.Text) / 100;
                }
                outptDisp.Text = clss.Output.ToString() + clss.Op + clss.SecondVal.ToString();
                outptPreview.Text = clss.SecondVal.ToString();
                clss.InEq = true;
            }         
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            clss.MemVal = Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
            clss.InEq = true;
        }
        private void btnMminus_Click(object sender, EventArgs e)
        {
            clss.MemVal = clss.MemVal - Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
            clss.InEq = true;
        }
        private void btnMplus_Click(object sender, EventArgs e)
        {
            clss.MemVal = clss.MemVal + Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
            clss.InEq = true;
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            outptPreview.Text = clss.MemVal.ToString();
            clss.InEq = true;
        }
        private void btnMC_Click(object sender, EventArgs e)
        {
            clss.MemVal = 0;
            btnMC.Enabled = btnMR.Enabled = false;
        }
        private void btnClrPrev_Click(object sender, EventArgs e)
        {
            if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {
                outptDisp.Text = "";
                outptPreview.Text = "0";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
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
                clss.Output = Math.Sqrt(Double.Parse(outptPreview.Text));
                outptPreview.Text = clss.Output.ToString();
                clss.InEq = true;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "1";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "1";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "1";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (((outptPreview.Text == "0") || (outptPreview.Text == "")) && (clss.InEq == false))
            {
                outptPreview.Text = "2";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || clss.InEq == true)
            {
                outptDisp.Text = "";
                outptPreview.Text = "2";
                clss.Output = 0;
                clss.InEq = false;
                btnMplus.Enabled = btnMminus.Enabled = btnMS.Enabled = btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
                if (clss.MemVal != 0)
                {
                    btnMC.Enabled = btnMR.Enabled = true;
                }
            }
            else if ((outptDisp.Text == clss.Output.ToString() + clss.Op + clss.SecondVal.ToString()) && (outptPreview.Text == clss.SecondVal.ToString())) // for % reset clss.InEq
            {
                outptDisp.Text = clss.Output.ToString() + clss.Op;
                outptPreview.Text = "2";
            }
            else
            {
                outptPreview.Text = outptPreview.Text + "2";
            }
        }
    }
}
