using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name of the app

            Console.Write("\n\n");
            Console.Write("Basic calculator:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            //Choose math operator

            Console.Write("\nHere are the options :\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Remainder.\n6-Exit.\n");
            Console.Write("\nInput your choice :");

            // Choose First and Second Number

            Console.Write("Enter the First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Math operator

            mathOperator = Convert.ToInt32(Console.ReadLine());
        }
    }
}
