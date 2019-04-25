using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy
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
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            weeks = Convert.ToInt32(Console.ReadLine());

            /****Person 2***/
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            long rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            long weeks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1:");
            Pay  = rate * weeks;
            Console.WriteLine(Pay);
            Console.WriteLine("Annual salary of Person 2:");
            Pay2 = rate1 * weeks1;
            Console.WriteLine(Pay2);
            TotalPayperson2 = Pay2;
            Totalpayperson1 = Pay;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool ispersonMakemore = Totalpayperson1 > TotalPayperson2;
            Console.WriteLine(ispersonMakemore);
            Console.ReadLine();
        }
    }
}
