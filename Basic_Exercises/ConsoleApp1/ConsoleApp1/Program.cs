

//5.Write a C# Sharp program to swap two numbers. Go to the editor
//Test Data:
//Input the First Number : 5
//Input the Second Number : 6
//Expected Output:
//After Swapping :
//First Number : 6
//Second Number : 5


using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Input the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int num3;
        num3 = num1;
        num1 = num2;
        num2 = num3;
        

        Console.WriteLine("First Number is " + num1);
        Console.WriteLine("Second Number is " + num2);
        Console.ReadKey();

    }

}