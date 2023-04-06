//9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {

        static void Main()
        {
            float num1, num2, num3, num4;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the forth number: ");
            num4 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", num1, num2, num3, num4, (num1 + num2 + num3 + num4) / 4);
            Console.ReadKey();

        }
    }
}
