using ProjectToBeTested2;
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
            IUser kirin = new User("Hanako", "Anderson");
            Console.WriteLine(kirin.DescribeMyFullName());

            IUser torii =  new User("Taro");
            Console.WriteLine(torii.DescribeMyFirstName());

            Console.ReadKey();
        }
    }


}