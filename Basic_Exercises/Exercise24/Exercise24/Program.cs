//24.Write a C# program to find the longest word in a string.
//Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
//Sample Output:
//following

using System;
using System.Collections.Generic;

namespace Exercise24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string longestWord = Console.ReadLine();

            string[] wordArray = longestWord.Split(' ');

            int max = 0;
            string maxWord = " ";

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i].Length> max)
                {
                    max = wordArray[i].Length;
                    maxWord = wordArray[i];
                }
            }
            Console.WriteLine("\nThe longest word in this string is {0}", maxWord);
           
            Console.ReadKey();

        }
    }
}
