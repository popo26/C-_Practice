using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectToBeTested
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Calculation.Addition(2));
            //Console.WriteLine(Calculation.Subtraction(8, 4));
            //Console.WriteLine(Calculation.Multiplication(2, 2));
            Console.WriteLine(Calculation.Division(2, 0)); 
            Console.ReadKey();
        }
    }


}

