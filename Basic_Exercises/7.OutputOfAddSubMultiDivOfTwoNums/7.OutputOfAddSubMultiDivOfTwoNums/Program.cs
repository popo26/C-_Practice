//7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
//Test Data:
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100
//25 / 4 = 6
//25 mod 4 = 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OutputOfAddSubMultiDivOfTwoNums
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2;

            Console.WriteLine("Input the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: {0} + {1} = {2}", num1, num2, num1+num2);
            Console.WriteLine("Subtraction: {0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("Multiplication: {0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("Division: {0} / {1} = {2}", num1, num2, num1/num2);
            Console.WriteLine("Modular: {0} % {1} = {2}", num1, num2, num1 % num2);
            Console.ReadKey();
        }
    }
}
