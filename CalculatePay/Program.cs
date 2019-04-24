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
            double Totalpayperson1;
            double TotalPayperson2;
            long Pay;
            long Pay2;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            weeks = Convert.ToInt32(Console.ReadLine());
            
            /****Person 2***/
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            weeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1:");
             Pay = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 2:");
            Pay2 = Convert.ToInt64(Console.ReadLine());
            TotalPayperson2 = rate * weeks;//+ Pay2;
            Totalpayperson1 = rate * weeks; //+ Pay;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool ispersonMakemore = Totalpayperson1 > TotalPayperson2;
            Console.WriteLine(ispersonMakemore);
            Console.ReadLine();
        }
    }
}
