//23.Write a C# program to convert a given string into lowercase.
//Sample Output:
//write a c# sharp program to display the following pattern using the alphabet.

using System;


namespace Exercise23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lowerString;
            Console.WriteLine("Enter a string: ");
            lowerString = Console.ReadLine().ToLower();
            Console.WriteLine(lowerString);
            Console.ReadKey();

        }
    }
}
