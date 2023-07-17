using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectToBeTested
{
    ///<summary>
    ///Class to be tested by UnitTestProject1 project
    ///</summary>>
    public static class Calculation
    {
        /// <summary>
        /// Division method
        /// </summary>
        /// <param name="num1">Divident as a double input</param>
        /// <param name="num2">Divider as a double input</param>
        /// <returns>Double output</returns>
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
