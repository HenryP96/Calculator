using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculatorClass calc = new CalculatorClass();
            Console.WriteLine($"2+7 = {calc.Add(2, 7)}");
            Console.WriteLine($"12-2 = {calc.Subtract(12, 2)}");
            Console.WriteLine($"4*5 = {calc.Multiply(4, 5)}");
            Console.WriteLine($"5^3 = {calc.Power(5, -3)}");
            calc.print();

        }
    }
}
