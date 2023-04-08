//17.Write a C# program to create a new string from a given string (length 1 or more ) with the first character added
//at the front and back.
//Sample Output:
//Input a string : The quick brown fox jumps over the lazy dog.
//TThe quick brown fox jumps over the lazy dog.T

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string input = Console.ReadLine();
            Console.WriteLine(AddFirstChar(input));
            Console.ReadKey();
        }
        public static string AddFirstChar(string str)
        {
            int len = str.Length;
            if (len >= 1)
            {
                return str[0] + str + str[0];
            }
            else { return str; };
        }
    }
}
