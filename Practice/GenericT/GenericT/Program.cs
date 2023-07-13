

public class Program

{
    public static void Main()
    {
        int[] intArray = CreateArray(5, 6);
        foreach (int x in intArray)
        {
            Console.WriteLine(x);
        }
        Console.ReadLine();
    }

    public static int[] CreateArray(int firstNum, int secondNum) 
    { 
     return new int[] { firstNum, secondNum };
    }
}