using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListItration

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text");
            string enter = Console.ReadLine();
            string[] value= new string[100];
            for(var i = 0; i <100; i++)
            {
                value[i] = enter;
            }
        }
    }
}
