using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your choice: 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");
            int userChoice = Convert.ToInt32(Console.ReadLine());


            if (userChoice == 1 || userChoice == 2 || userChoice == 3 || userChoice == 4)
            {
                List<float> nums = new List<float>();

                bool isContinueAddingNumbers = true;
                while (isContinueAddingNumbers)
                {
                    Console.WriteLine("\nEnter the number:");
                    nums.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Continue?: Y/N ");
                    var answer = Console.ReadLine().ToUpper();
                    if (answer == "N")
                        isContinueAddingNumbers = false;
                }
                switch (userChoice)
                {
                    case 1:
                        Addition(nums.ToArray());
                        break;
                    case 2:
                        Subtraction(nums.ToArray());
                        break;
                    case 3:
                        Multiplication(nums.ToArray());
                        break;
                    case 4:
                        Division(nums.ToArray());
                        break;
                }
            }
            else
            {
                Console.WriteLine("Select a number between 1 and 4.");
            }
            Console.ReadKey();
        }

        static void Addition(params float[] list)
        {
            float total = 0;
            for (int i = 0; i < list.Length; i++)
            { 
            total += list[i];
            }
            Console.WriteLine($"\nAddition result is {total}.");
        }

        static void Subtraction(params float[] list)
        {
            float total = list[0];
            
            for (int i = 1; i < list.Length; i++)
            {
                total -= list[i];
            }
            Console.WriteLine($"\nSubtraction result is {total}.");
        }

        static void Multiplication(params float[] list)
        {
            float total = list[0];
            
            for (int i = 1; i < list.Length; i++)
            {
                total *= list[i];  
            }
            Console.WriteLine($"\nMultiplication result is {total}.");
        }

        static void Division(params float[] list)
        {
            float total = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                total /= list[i];
            }
            Console.WriteLine($"\nDivisiton result is {total}.");
        }
    }
}
