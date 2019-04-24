using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePay
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate;
            int weeks;
            double Totalpay;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            weeks = Convert.ToInt32(Console.ReadLine());
            Totalpay = rate * weeks;
            /****Person 2***/
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            weeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1:");
            long Pay = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 2:");
            long Pay2 = Convert.ToInt64(Console.ReadLine());
            Totalpay = rate * weeks;
            //Console.WriteLine(Totalpay);
        }
    }
}
