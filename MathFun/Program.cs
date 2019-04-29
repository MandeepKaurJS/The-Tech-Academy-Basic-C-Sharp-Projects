using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your required number to see some" +
         "math operations on it");
            int Number = Convert.ToInt32(Console.ReadLine());
            userMathod user = new userMathod();
           // user.AddFun(g.Number);
            //Console.WriteLine(g.Number);
            
            Console.WriteLine(user.AddFun(Number));
            Console.ReadLine();
            Console.WriteLine(user.MultiplyFun(Number));
            Console.ReadLine();
            Console.WriteLine(user.DivideFun(Number));
            Console.ReadLine();
            Console.WriteLine(user.MinusFun(Number));
            Console.ReadLine();



        }
    }
}
