using System;

namespace CalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Calculator V2 ****");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Operator +, -, /, *: ");
            string op = Console.ReadLine();
            
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                double result = num1 + num2;
                Console.WriteLine("Result: " + result);
            } else if (op == "-"){

                double result = num1 - num2;
                Console.WriteLine("Result: " + result);
            } else if (op == "/")
            {
                double result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }else if (op == "*")
            {
                double result = num1 * num2;
                Console.WriteLine("Result: " + result);
            } else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}