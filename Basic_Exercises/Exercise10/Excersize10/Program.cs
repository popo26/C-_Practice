//10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
//Test Data:
//Enter first number - 5
//Enter second number - 6
//Enter third number - 7

//Expected Output:
//Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize10
{
    internal class Program
    {
        static void Main()
        {
            double num1, num2, num3;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The result of specified numbers {0}, {1}, and {2}, (x+y).z is {3} and x.y+y.z is {4}",
                num1, num2, num3, (num1 + num2) * num3, num1 * num2 + num2 * num3);
            Console.ReadLine();
        }
    }
}
