//26.Write a C# program to compute the sum of the first 500 prime numbers.
//Sample Output:
//Sum of the first 500 prime numbers:
//824693

using System;


namespace Exercise26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            bool isPrime;
            for (int i = 2; i < 501; i++)
            {
                num++;
                Console.WriteLine(num);
                for (int j = i; j < 501; j++)
                {
                    if (num % j == 1)
                    {
                        isPrime = false;
                        Console.WriteLine(num);
                    }
                    else
                    {
                        isPrime = true;
                        sum = sum + num;
                        Console.WriteLine(sum);
                    }
                }
            }

            //Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
