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
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public void print()
        {
            Console.WriteLine("Den danske ");
            Console.WriteLine("JS");
        }

    }
}
