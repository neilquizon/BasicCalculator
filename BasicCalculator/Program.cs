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

            Console.Write("\nPlease choose from the below options :\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Remainder.\n6-Exit.\n");
            Console.Write("\nInput your choice :");

            // Choose First and Second Number

            int num1, num2, opt;

            Console.Write("Enter First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Math operator

            opt = Convert.ToInt32(Console.ReadLine());

            // Case statement

            switch (opt)
            {
                case 1:
                    Console.Write("The Sum of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;


            }
        }
    }
}

