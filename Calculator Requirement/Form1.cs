﻿using System;
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
            public static double secondVal = 0;
            public static string op = "";
            public static double memVal = 0;
            public static bool inEq = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if ((outptPreview.Text == "0") || (outptPreview.Text == ""))
            {

                outptPreview.Text = "2";
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "2";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
                Global.output = 0;
                Global.inEq = false;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "1";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "3";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "4";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "5";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "6";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "7";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "8";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "9";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input" || Global.inEq == true)
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString())) // for % reset inEq
            {

                outptDisp.Text = Global.output.ToString() + Global.op;
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
                Global.inEq = true;
            }
            else if (outptDisp.Text == (Global.output.ToString() + Global.op + outptPreview.Text)) //for %
            {

                outptDisp.AppendText("=");
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

                Global.inEq = true;
                outptPreview.Text = Global.output.ToString();

            }
            else if (outptDisp.Text.Contains("="))
            {

                if (outptDisp.Text.Contains("+"))
                {

                    string[] vars = outptDisp.Text.Split('+', '=');
   
                    Global.output = Global.output + Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "+" + vars[1] + "=";
                }
                else if (Global.op == "-")
                {

                    string[] vars = outptDisp.Text.Split('-', '=');

                    if (vars[0] == "")
                    {

                        Global.output = Global.output - Double.Parse(vars[2]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[2] + "=";
                    }
                    else
                    {

                        Global.output = Global.output - Double.Parse(vars[1]);
                        outptDisp.Text = outptPreview.Text + "-" + vars[1] + "=";
                    }
                }
                else if (outptDisp.Text.Contains("*"))
                {

                    string[] vars = outptDisp.Text.Split('*', '=');
                    Global.output = Global.output * Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "*" + vars[1] + "=";
                }
                else if (outptDisp.Text.Contains("/"))
                {

                    string[] vars = outptDisp.Text.Split('/', '=');
                    Global.output = Global.output / Double.Parse(vars[1]);
                    outptDisp.Text = outptPreview.Text + "/" + vars[1] + "=";
                }

                Global.inEq = true;
                outptPreview.Text = Global.output.ToString();
            }
            else if (outptPreview.Text == "Cannot divide by zero" || outptPreview.Text == "Invalid Input")
            {

                outptDisp.Text = "";
                outptPreview.Text = "0";
                Global.output = 0;
                Global.inEq = false;
                btnPercent.Enabled = btnFraction.Enabled = btnSquared.Enabled = btnSquareRt.Enabled = btnDiv.Enabled = btnx.Enabled = btnNeg.Enabled = btnPos.Enabled = btnDot.Enabled = btnPosNeg.Enabled = true;
            }
            else
            {

                outptDisp.Text = outptDisp.Text + outptPreview.Text + "=";
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

                Global.inEq = true;
                outptPreview.Text = Global.output.ToString();
            }
        }

        private void btnPos_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                Global.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(Global.output.ToString() + "+");
            }
            else if (outptDisp.Text.Contains("="))
            {

                outptDisp.Text = outptPreview.Text + "+";
                Global.output = Double.Parse(outptPreview.Text);
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString()))
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

                outptDisp.Text = Global.output.ToString() + "+";
                outptPreview.Text = "0";
            }
            else
            {

                Global.output = Global.output + Double.Parse(outptPreview.Text);
                outptDisp.Text = "";
                outptDisp.AppendText(Global.output.ToString() + "+");
            }

            outptPreview.Text = "0";
            Global.op = "+";
            Global.inEq = false;
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                Global.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(Global.output.ToString() + "-");
            }
            else if (outptDisp.Text.Contains("="))
            {

                outptDisp.Text = outptPreview.Text + "-";
                Global.output = Double.Parse(outptPreview.Text);
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString()))
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

                outptDisp.Text = Global.output.ToString() + "-";
                outptPreview.Text = "0";
            }
            else
            {

                Global.output = Global.output - Double.Parse(outptPreview.Text);
                outptDisp.Text = "";
                outptDisp.AppendText(Global.output.ToString() + "-");
            }

            outptPreview.Text = "0";
            Global.op = "-";
            Global.inEq = false;
        }
    

        private void btnx_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                Global.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(Global.output.ToString() + "*");
            }
            else if (outptDisp.Text.Contains("="))
            {

                outptDisp.Text = outptPreview.Text + "*";
                Global.output = Double.Parse(outptPreview.Text);
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString()))
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

                outptDisp.Text = Global.output.ToString() + "*";
                outptPreview.Text = "0";
            }
            else
            {

                Global.output = Double.Parse(outptPreview.Text) * Global.output;
                outptDisp.Text = "";
                outptDisp.AppendText(Global.output.ToString() + "*");
            }

            outptPreview.Text = "0";
            Global.op = "*";
            Global.inEq = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            if (outptDisp.Text == "0" || outptDisp.Text == "")
            {

                Global.output = Double.Parse(outptPreview.Text);
                outptDisp.AppendText(Global.output.ToString() + "/");
                outptPreview.Text = "0";
                Global.op = "/";
            }
            else if (outptDisp.Text.Contains("="))
            {

                outptDisp.Text = outptPreview.Text + "/";
                Global.output = Double.Parse(outptPreview.Text);
            }
            else if ((outptDisp.Text == Global.output.ToString() + Global.op + Global.secondVal.ToString()) && (outptPreview.Text == Global.secondVal.ToString()))
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

                outptDisp.Text = Global.output.ToString() + "/";
                outptPreview.Text = "0";
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
                    outptDisp.AppendText(Global.output.ToString() + "/");
                    outptPreview.Text = "0";
                    Global.op = "/";
                }
            }

            Global.inEq = false;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {

            outptDisp.Text = "";
            outptPreview.Text = "0";
            Global.output = 0;
            Global.inEq = false;
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
                Global.output = Math.Sqrt(Double.Parse(outptPreview.Text));
                outptPreview.Text = Global.output.ToString();
                Global.inEq = true;
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
                Global.output = 0;
                Global.inEq = false;
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

        private void btnSquared_Click(object sender, EventArgs e)
        {

            outptDisp.Text = $"{outptPreview.Text}^2";
            Global.output = Double.Parse(outptPreview.Text) * Double.Parse(outptPreview.Text);
            outptPreview.Text = Global.output.ToString();
            Global.inEq = true;
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
                Global.output = 1/Double.Parse(outptPreview.Text);
                outptPreview.Text = Global.output.ToString();
                Global.inEq = true;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        if ((Global.output.ToString() + Global.op) == outptDisp.Text)
            {

                if (Global.op.Equals("+") || Global.op.Equals("-"))
                {

                    Global.secondVal = Global.output*(Double.Parse(outptPreview.Text) / 100);
                }
                else if (Global.op.Equals("*") || Global.op.Equals("/"))
                {

                    Global.secondVal = Double.Parse(outptPreview.Text) / 100;
                }

                outptDisp.Text = Global.output.ToString() + Global.op + Global.secondVal.ToString();
                outptPreview.Text = Global.secondVal.ToString();
                Global.inEq = true;
            }         
        }

        private void btnMS_Click(object sender, EventArgs e)
        {

            Global.memVal = Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {

            Global.memVal = Global.memVal - Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {

            Global.memVal = Global.memVal + Double.Parse(outptPreview.Text);
            btnMC.Enabled = btnMR.Enabled = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {

            outptPreview.Text = Global.memVal.ToString();
            Global.inEq = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

            Global.memVal = 0;
            btnMC.Enabled = btnMR.Enabled = false;
        }
    }
}
