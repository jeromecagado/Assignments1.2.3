﻿using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Assignments1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Welcome to the calculations app.");
            do
            {

                Console.WriteLine("\nPlease enter:");
                Console.WriteLine("\"a\" for addition");
                Console.WriteLine("\"s\" for subtraction");
                Console.WriteLine("\"m\" for multiplication");
                Console.WriteLine("\"d\" for division");
                Console.WriteLine("\"e\" to exit\n");

                char value = Convert.ToChar(Console.ReadLine().ToLower());
                Console.WriteLine();

                switch (value)
                {
                    case 'a':
                        Addition();
                        break;
                    case 's':
                        Subtraction();
                        break;
                    case 'm':
                        Multiplication();
                        break;
                    case 'd':
                        Division();
                        break;
                    case 'e':
                        Console.WriteLine("You are exiting the program. Goodbye!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You entered the wrong key. Try again.");
                        break;
                }
            } while (flag);
        }
        
        static void Addition()
        {
            Console.WriteLine("Please enter the first number");
            int firstIntegerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondIntegerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is:{firstIntegerNumber + secondIntegerNumber}\n");
        }

        static void Subtraction()
        {
            Console.WriteLine("Please enter the first number");
            int firstSubtractedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondSubtractedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is: {firstSubtractedNumber - secondSubtractedNumber}\n");
        }

        static void Multiplication()
        {
            Console.WriteLine("Please enter the first number");
            int firstMultipliedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondMultipliedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is: {firstMultipliedNumber * secondMultipliedNumber}\n");
        }

        static void Division()
        {
            Console.WriteLine("Please enter the first number");
            double firstDividedNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            double secondDividedNumber = Convert.ToDouble(Console.ReadLine());
            while (secondDividedNumber == 0)
            {
                Console.WriteLine("Please enter a number not zero");
                secondDividedNumber = Convert.ToDouble(Console.ReadLine());
            }
           
            Console.WriteLine($"The answer is: {firstDividedNumber / secondDividedNumber}\n");
            
        }
    }
}
