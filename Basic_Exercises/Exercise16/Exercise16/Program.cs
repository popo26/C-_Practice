//16.Write a C# program to create a new string from a given string where the first and last characters
//will change their positions. 
//Test Data:
//w3resource
//Python
//Sample Output:
//e3resourcw
//nythoP
//x

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine(Swap(input));
            Console.ReadKey();
        }

        public static string Swap(string text)
        {
            int length = text.Length;
            if (text.Length > 1)
            {
                return text[length - 1] + text.Substring(1, length - 2) + text[0];
            }
            else 
            {
                return text;
            }
           
                    
        }
    }
}
