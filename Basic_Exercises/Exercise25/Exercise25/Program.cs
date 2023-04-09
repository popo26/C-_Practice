

//25.Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. 
//Sample Output:
//Odd numbers from 1 to 99. Prints one number per line.
//1
//3
//5
//7
//9
//...
//95
//97
//99

using System;


namespace Exercise25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
