//13.Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows
//tall using that digit. 
//Test Data:
//Enter a number: 5
//Expected Output:
//555
//5 5
//5 5
//5 5
//555

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();

            Console.WriteLine(num + num + num);
            Console.WriteLine(num + " " + num);
            Console.WriteLine(num + " " + num);
            Console.WriteLine(num + " " + num);
            Console.WriteLine(num + num + num);
            Console.ReadKey();

        }
    }
}
