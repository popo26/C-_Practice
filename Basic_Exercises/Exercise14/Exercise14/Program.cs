//14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
//Test Data:
//Enter the amount of celsius: 30
//Expected Output:
//Kelvin = 303
//Fahrenheit = 86

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the amount of celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("In Kelvin: {0}", celsius + 273.15);
            Console.WriteLine("In Fahrenheit: {0}", (celsius * 1.8) + 32);
            Console.ReadKey();
        }
    }
}
