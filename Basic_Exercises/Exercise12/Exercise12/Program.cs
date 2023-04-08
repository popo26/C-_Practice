//12.Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
//and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

//Test Data:
//Enter a digit: 25
//Expected Output:
//25 25 25 25
//25252525
//25 25 25 25
//25252525

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Program
    {
        static void Main()
        {
            string num;
            string row1;
            string row2;
            Console.WriteLine("Enter a digit: ");
            num = Console.ReadLine();
            row1 = num + " ";
            row2 = num;

            for (int i = 0; i < 3; i++)
            {
                row1 += num + " ";
                row2 += num;
            }
            Console.WriteLine(row1);
            Console.WriteLine(row2);
            Console.WriteLine(row1);
            Console.WriteLine(row2);
            Console.ReadKey();


        }
    }
}
