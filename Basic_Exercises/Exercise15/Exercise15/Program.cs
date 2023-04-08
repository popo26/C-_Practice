//15.Write a C# program remove specified a character from a non-empty string using index of a character.
//Test Data:
//w3resource
//Sample Output:
//wresource
//w3resourc
//3resource

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "w3resource";
            Console.WriteLine("Test Data is : {0}", text);

            Console.WriteLine("Test Data without index 1 is {0}", text.Remove(1, 1));
            Console.WriteLine("Test Data without index 9 is {0}", text.Remove(9, 1));
            Console.WriteLine("Test Data without index 0 is {0}", text.Remove(0, 1));
            Console.ReadKey();
        }
    }
}
