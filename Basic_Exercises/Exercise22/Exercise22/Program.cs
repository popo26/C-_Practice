//22.Write a C# program to check if an given integer is within 20 of 100 or 200.
//Sample Output:
//Input an integer:
//25
//False

//!!I dont understand the question

using System;


namespace Exercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Input an integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(num));
            Console.ReadKey();
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
    }
}
