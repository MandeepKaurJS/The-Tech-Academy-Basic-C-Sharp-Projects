using System;

namespace MathFun
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter an integer");
            long Number =Convert.ToInt64(Console.ReadLine());
            long multiply = Number * 50;
            Console.WriteLine("Multiply with 50 : \n" + multiply);

            /*Second question */

            Console.WriteLine("Enter An Integer");
            int num = Convert.ToInt32(Console.ReadLine());
            int Add = num + 25;
            Console.WriteLine("Number After Addition: " + Add);

            
        }
    }
}
