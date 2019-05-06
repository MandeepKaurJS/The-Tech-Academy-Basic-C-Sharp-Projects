using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProject
{
    class Program
    {
        struct Number
        {
            public double Amount;
        };
        static void Main(string[] args)
        {
            Number a;
            a.Amount = 5.5;
            Console.WriteLine("Decimal value is : " + a.Amount);
            Console.ReadLine();
        }
    }
}
