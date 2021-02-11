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
            if(divisor==0)
            {
                throw new DivideByZeroException("Error: 'Divide by zero'");
            }

            Accumulator = dividend / divisor;
            return dividend / divisor;
        }

        public double Accumulator
        {
            get; private set;
        }


        public void Clear()
        {
            Accumulator = 0;
        }


        //OVERLOADS
        public double Add(double addend)
        {
            return Accumulator += addend;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator -= subtractor;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }

        public double Divide(double divisor)
        {
            try
            {
                return Accumulator /= divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Could not divide by zero");
                return 0;
            }
        }

        public double Power(double exponent)
        {
            return Accumulator = Math.Pow(Accumulator, exponent);
        }
    }
}

//HEJ
