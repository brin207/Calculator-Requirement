using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Requirement
{
    class Class1
    {
        private double output = 0;
        private double secondVal = 0;
        private string op = "";
        private double memVal = 0;
        private bool inEq = false;

        public double Output { get => output; set => output = value; }
        public double SecondVal { get => secondVal; set => secondVal = value; }
        public string Op { get => op; set => op = value; }
        public double MemVal { get => memVal; set => memVal = value; }
        public bool InEq { get => inEq; set => inEq = value; }
    }
}
