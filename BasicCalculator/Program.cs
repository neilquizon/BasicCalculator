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

            int num1, num2, opt;

            Console.Write("\nPlease choose from the below options :\n\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Remainder.\n6-Exit.\n");
            Console.Write("\nPLease enter your choice: ");
            opt = Convert.ToInt32(Console.ReadLine());

            // Choose First and Second Number            

            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine()); 

            // Case statement

            switch (opt)
            {
                //addition
                case 1:               
                    Console.Write("\nThe Sum of {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    Console.Read();
                    break;

                //subtraction
                case 2:
                    Console.Write("\nThe Difference of {0} and {1} is: {2}\n", num1, num2, num1 - num2);
                    Console.Read();
                    break;

                //multiplication
                case 3:
                    Console.Write("\nThe Product of {0} and {1} is: {2}\n", num1, num2, num1 * num2);
                    Console.Read();
                    break;

                //division
                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("\nThe second number is zero. The answer is Undefined.\n");
                    }
                    else
                    {
                        Console.Write("\nThe Quotient of {0} and {1} is : {2}\n", num1, num2, num1 / num2);
                    }
                    Console.Read();
                    break;

                //Remainder
                case 5:
                    Console.Write("\nThe Remainder of {0} and {1} is: {2}\n", num1, num2, num1 % num2);
                    Console.Read();
                    break;






            }
        }
    }
}

