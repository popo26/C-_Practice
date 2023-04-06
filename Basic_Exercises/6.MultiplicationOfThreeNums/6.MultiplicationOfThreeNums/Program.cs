//6.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
//Test Data:
//Input the first number to multiply: 2
//Input the second number to multiply: 3
//Input the third number to multiply: 6
//Expected Output:
//2 x 3 x 6 = 36


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MultiplicationOfThreeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number to multiply: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe answer is: ");
            Console.WriteLine(num1 * num2 * num3);
            Console.ReadKey();

        }
    }
}
