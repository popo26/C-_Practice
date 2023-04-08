//11.Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
//Test Data:
//Enter your age - 25
//Expected Output:
//You look older than 25

using System;


namespace Exercise11
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"You look older than {age}.");
            Console.ReadKey();
        }
    }
}
