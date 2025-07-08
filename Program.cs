using System.Numerics;
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
                Console.WriteLine("\"e\" to exit");

                char value = Convert.ToChar(Console.ReadLine().ToLower());

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
                    default:
                        flag = false;
                        break;
                }
            } while (flag);
        }
        
        public static void Addition()
        {
            Console.WriteLine("Please enter the first numbers!");
            int firstIntegerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondIntegerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is:{firstIntegerNumber + secondIntegerNumber}");
        }

        public static void Subtraction()
        {
            Console.WriteLine("Please enter the first numbers!");
            int firstSubtractedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondSubtractedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is: {firstSubtractedNumber - secondSubtractedNumber}");
        }

        public static void Multiplication()
        {
            Console.WriteLine("Please enter the first numbers!");
            int firstMultipliedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondMultipliedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The answer is: {firstMultipliedNumber * secondMultipliedNumber}");
        }

        public static void Division()
        {
            Console.WriteLine("Please enter the first numbers!");
            double firstDividedNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number not zero.");
            double secondDividedNumber = Convert.ToDouble(Console.ReadLine());
            while (secondDividedNumber == 0)
            {
                Console.WriteLine("Please enter a number not zero");
                secondDividedNumber = Convert.ToDouble(Console.ReadLine());
            }
           
            Console.WriteLine($"The answer is: {firstDividedNumber / secondDividedNumber}");
        }
    }
}
