using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        private int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public void SetNumberOne(int numberOne)
        {
            NumberOne = numberOne;
        }

        public void SetNumberTwo(int numberTwo)
        {
            NumberTwo = numberTwo;
        }

        public int Add()
        {
            return NumberOne + NumberTwo;
        }
        public int Subtract()
        {
            return NumberOne - NumberTwo;
        }
        public int Multiply()
        {
            return NumberOne * NumberTwo;
        }
        public int Divide()
        {
            return NumberOne / NumberTwo;
        }
    }
}
