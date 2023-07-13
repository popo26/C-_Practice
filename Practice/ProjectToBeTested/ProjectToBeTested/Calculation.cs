using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectToBeTested
{
    public static class Calculation
    {
        //public static double Addition(double num)
        //{
        //    return num + num;
        //}

        //public static double Subtraction(double num1, double num2)
        //{
        //    return num1 - num2;
        //}

        //public static double Multiplication(double num1, double num2)
        //{
        //    return num1 * num2;
        //}

        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return num1 / num2;
        }
    }
}
