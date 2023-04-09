//21.Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20

using System;


namespace Exercise21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1==20||num2==20||(num1+num2==20));
            Console.ReadKey();

        }
    }
}
