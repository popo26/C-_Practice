//Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum

using System;


namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Triple(num1, num2);
            Console.ReadKey();
        }

        public static void Triple(double num1, double num2)
        {
            double sum;
            if (num1 == num2)
            {
                sum = num1 + num2;
                Console.WriteLine("\nThe matching number so triple of the sum is {0}", sum*3);
            }
            else
            {
                Console.WriteLine("\nThe simple sum is {0}", num1+num2);
            }
        }
    }
}
