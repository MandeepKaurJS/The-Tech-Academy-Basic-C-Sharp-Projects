using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProject
{
    class Program
    {
        struct Amount
        {
            public double amount;
        };
        static void Main(string[] args)
        {
            Amount a;
            a.amount = 5.5;
            Console.WriteLine("Decimal value is : " + a.amount);
            Console.ReadLine();
        }
    }
}
