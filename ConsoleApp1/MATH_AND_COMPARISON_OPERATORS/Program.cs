using System;

namespace MATH_AND_COMPARISON_OPERATORS
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeks = Convert.ToInt32(Console.ReadLine());
            /****Person 2***/
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int weeks2 = Convert.ToInt32(Console.ReadLine());


        }
    }
}
