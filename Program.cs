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
                Console.WriteLine(num1 + num2);
            } else if (op == "-"){
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
