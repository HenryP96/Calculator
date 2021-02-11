using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorClass
    {
        public CalculatorClass()
        {

        }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }
        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {
            return dividend/divisor;
        }

        public double Accumulator
        {
            get; private set;
        }


        public void Clear()
        {
            Accumulator = 0;
        }

    }
}

//HEJ
