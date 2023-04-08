

//18.Write a C# program to check two given integers and return true if one is negative and one is positive.
//Sample Output:
//Input first integer:
//-5
//Input second integer:
//25
//Check if one is negative and one is positive:
//True


using System;

namespace Exercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            CompareNums(num1, num2);
            Console.ReadKey();


        }
        public static void CompareNums(int num1, int num2)
        {
            bool truth = num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0;

            if (truth)
            {
                Console.WriteLine("\nTrue");
            }
            else
            {
                Console.WriteLine("\nFalse");
            }

        }


    }
}
