//20.Write a C# program to get the absolute value of the difference between two given numbers.
//Return double the absolute value of the difference if the first number is greater than second number.

using System;


namespace Exercise20
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            AbsoluteNum(num1, num2);
            Console.ReadKey();


        }
        public static void AbsoluteNum(double num1, double num2)
        {

            if (num1 > num2)
            {
                Console.WriteLine("\nFirst number is bigger. The double of the absolute " +
                    "value of the difference is {0}", Math.Abs(num1 - num2)*2);
            }
            else
            {
                Console.WriteLine("\nThe absolute value of the difference is {0}", Math.Abs(num1-num2));
            }
        }
    }
}
